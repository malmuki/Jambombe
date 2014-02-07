Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Audio
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.GamerServices
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.Media
Imports System.IO
Imports System.Threading

Public Class Game
    Inherits Microsoft.Xna.Framework.Game

    Const SAUT_H = 3 * BLOCK_SIZE

    Dim changed As Boolean = True
    Dim globalPos As New Location

    Dim w As Integer
    Dim h As Integer

    Dim sizeW As Integer
    Dim sizeH As Integer

    Dim personnage As personnage = GlobalV.personnage
    Dim allMonsters As New List(Of personnage)
    Dim allUnits As New List(Of personnage)

    'Fields in our game graphic manager etc'
    Private graphics As GraphicsDeviceManager
    Private spriteBatch As SpriteBatch
    Private font As SpriteFont
    'Texture that we will render'
    Private blockSheet As Texture2D
    Private inventaire As Texture2D
    Private ironBlock As Rectangle
    Private sky As Rectangle
    Private grass As Rectangle
    Private grass2 As Rectangle
    Private dirt As Rectangle
    Private dirt2 As Rectangle
    Private dirt3 As Rectangle
    Private dirt4 As Rectangle
    Private other As Rectangle
    Private grassback As Rectangle
    Private dirtback As Rectangle
    Private wood As Rectangle
    Private leaf As Rectangle
    Private ironOre As Rectangle
    Private coal As Rectangle
    Private rock As Rectangle
    Private planche As Rectangle
    Private oven As Rectangle
    Private workbench As Rectangle

    'Game sounds
    Dim pickaxe As SoundEffect

    Dim Delais As Double = 500
    Dim currentPickaxeDelais As Double = Delais
    Dim currentToggleDelais As Double = Delais

    Dim blocks As Block(,)

    Dim random As Random = New Random

    Public Sub New()
        graphics = New GraphicsDeviceManager(Me)
        graphics.PreferredBackBufferWidth = res(currentRes, 0)
        graphics.PreferredBackBufferHeight = res(currentRes, 1)

    End Sub

    Protected Overrides Sub OnExiting(sender As Object, args As EventArgs)
        MyBase.OnExiting(sender, args)
        End
    End Sub

    Protected Overrides Sub Initialize()
        Me.IsMouseVisible = True
        Window.AllowUserResizing = True
        MyBase.Initialize()
    End Sub
    Protected Overrides Sub LoadContent()
        ' TODO: use this.Content to load your game content here
        MyBase.LoadContent()
        ' Create a new SpriteBatch, which can be used to draw textures.
        spriteBatch = New SpriteBatch(GraphicsDevice)
        font = Content.Load(Of SpriteFont)("myfont")
        'TODO load the save world file here
        Dim filereader As StreamReader
        'loading inventory
        If File.Exists(GlobalV.personnage.PNomPersonnage & ".txt") Then
            filereader = File.OpenText(GlobalV.personnage.PNomPersonnage & ".txt")
            Dim items(8) As Integer
            For i = 0 To items.Length - 1
                items(i) = CInt(filereader.ReadLine)
            Next
            GlobalV.inventaire = New Inventaire(items, items(8))
        Else
            GlobalV.inventaire = New Inventaire
        End If

        'Load the texture'
        'We are using Stream since i couldn't find how to make content in VB'
        'Loading the texture'
        blockSheet = Texture2D.FromStream(GraphicsDevice, New System.IO.StreamReader("../../../Blocks/BlockSheet.png").BaseStream)
        inventaire = Texture2D.FromStream(GraphicsDevice, New System.IO.StreamReader("../../../Blocks/inventaire.png").BaseStream)
        ironBlock = New Rectangle(3 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        sky = New Rectangle(2 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        grass = New Rectangle(1 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        grass2 = New Rectangle(1 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        dirt = New Rectangle(0 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        dirt2 = New Rectangle(0 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        dirt3 = New Rectangle(0 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        dirt4 = New Rectangle(0 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        other = New Rectangle(4 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        grassback = New Rectangle(5 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        dirtback = New Rectangle(6 * BLOCK_SIZE, 0 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        wood = New Rectangle(0 * BLOCK_SIZE, 1 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        leaf = New Rectangle(1 * BLOCK_SIZE, 1 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        ironOre = New Rectangle(2 * BLOCK_SIZE, 1 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        coal = New Rectangle(3 * BLOCK_SIZE, 1 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        rock = New Rectangle(4 * BLOCK_SIZE, 1 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        planche = New Rectangle(5 * BLOCK_SIZE, 1 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        oven = New Rectangle(6 * BLOCK_SIZE, 1 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        workbench = New Rectangle(0 * BLOCK_SIZE, 2 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)

        parseMap()
        w = ((blocks.GetLength(1) - 1) * BLOCK_SIZE)
        h = ((blocks.GetLength(0) - 1) * BLOCK_SIZE)
        personnage.pos.setMin(BLOCK_SIZE - 1, BLOCK_SIZE - 1)
        personnage.pos.setMax(w - personnage.pos.getSize.X, h - personnage.pos.getSize.Y)

        globalPos.setMin(BLOCK_SIZE - 1, BLOCK_SIZE - 1)
        globalPos.setMax(w - sizeW, h - sizeH)

        personnage.setTexture(Texture2D.FromStream(GraphicsDevice, New System.IO.StreamReader("../../../Images/homme/CharacterSpriteSheet.png").BaseStream), New Point(4, 3), New Point(50, 71))

        allUnits.Add(personnage)
        For i As Integer = 0 To 3
            allMonsters.Add(New personnage(New Point(i * 2, 0)))
            allMonsters(i).pos.setMin(BLOCK_SIZE - 1, BLOCK_SIZE - 1)
            allMonsters(i).pos.setMax(w - personnage.pos.getSize.X, h - personnage.pos.getSize.Y)
            allMonsters(i).setTexture(Texture2D.FromStream(GraphicsDevice, New System.IO.StreamReader("../../Resources/asludge.gif").BaseStream), New Point(4, 3), New Point(My.Resources.asludge.Width, My.Resources.asludge.Height))

            allUnits.Add(allMonsters(i))
        Next
        pickaxe = SoundEffect.FromStream(TitleContainer.OpenStream("pickaxe.wav"))
        SoundEffect.MasterVolume = CSng(modIntro.volume) / 100
    End Sub

    Protected Overrides Sub Update(ByVal gameTime As Microsoft.Xna.Framework.GameTime)
        'Allows the game to exit'
        sizeW = graphics.GraphicsDevice.Viewport.Width
        sizeH = graphics.GraphicsDevice.Viewport.Height
        globalPos.setMax(w - sizeW, h - sizeH)

        personnage.resetTexture()

        'avance vers droite
        If Keyboard.GetState().IsKeyDown(CType(moveRight, Keys)) Then
            personnage.moveRight(gameTime.ElapsedGameTime.TotalSeconds,
                                      getFirstCollision(personnage.pos.getTopRight,
                                                        tP(personnage.pos.getBottomRight, New Point(0, -1)), New Point(1, 0)).X)
        End If
        'avance vers gauche
        If Keyboard.GetState().IsKeyDown(CType(moveLeft, Keys)) Then
            personnage.moveLeft(-gameTime.ElapsedGameTime.TotalSeconds,
                                      getFirstCollision(personnage.pos.getTopLeft,
                                                        tP(personnage.pos.getBottomLeft, New Point(0, -1)), New Point(-1, 0)).X)
        End If
        'up and away
        If Keyboard.GetState().IsKeyDown(CType(moveSaut, Keys)) Then
            If Not collision(personnage.pos.getBottomLeft, tP(personnage.pos.getBottomRight, New Point(-1, 0))) Then
                If personnage.VectorLeft <= 0 Then 'si deja dans les airs
                    personnage.VectorLeft = SAUT_H
                End If
            End If
        End If

        'click gauche
        If Mouse.GetState.LeftButton = ButtonState.Pressed Then
            If Mouse.GetState.X >= 0 AndAlso Mouse.GetState.X < sizeW AndAlso Mouse.GetState.Y >= 0 AndAlso Mouse.GetState.Y < sizeH Then

                If currentPickaxeDelais <= 0 Then
                    currentPickaxeDelais = Delais
                    Dim blockPosition = getBlockFromLocation(Mouse.GetState.X + globalPos.getX, Mouse.GetState.Y + globalPos.getY)
                    Dim pCenter = getBlockFromLocation(personnage.pos.getCenter)
                    Dim pRange = personnage.getRange

                    If withinRange(blockPosition, pCenter, pRange) Then
                        If getBlock(blockPosition).PCassable Then
                            pickaxe.Play()
                            If blocks(blockPosition.Y, blockPosition.X).blockTypeP = 9 OrElse blocks(blockPosition.Y, blockPosition.X).blockTypeP = 10 Then
                                If blocks(blockPosition.Y, blockPosition.X).blockTypeP = 9 Then
                                    GlobalV.inventaire.setNbItemX(1, True)
                                Else
                                    GlobalV.inventaire.setNbItemX(1, False)
                                End If
                            Else
                                If getBlock(blockPosition).blockTypeP <> 0 Then
                                    GlobalV.inventaire.setNbItemX(getBlock(blockPosition).blockTypeP - 1, 1)
                                End If
                            End If

                            If blockPosition.Y < 17 Then
                                blocks(blockPosition.Y, blockPosition.X) = New Block(sky, True, blockPosition.X, blockPosition.Y, False, 0)
                            ElseIf blockPosition.Y = 17 Then
                                blocks(blockPosition.Y, blockPosition.X) = New Block(grassback, True, blockPosition.X, blockPosition.Y, False, 0)
                            Else
                                blocks(blockPosition.Y, blockPosition.X) = New Block(dirtback, True, blockPosition.X, blockPosition.Y, False, 0)
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'click droit
        If Mouse.GetState.RightButton = ButtonState.Pressed Then
            If Mouse.GetState.X >= 0 AndAlso Mouse.GetState.X < sizeW AndAlso Mouse.GetState.Y >= 0 AndAlso Mouse.GetState.Y < sizeH Then
                Dim blockPosition = getBlockFromLocation(Mouse.GetState.X + globalPos.getX, Mouse.GetState.Y + globalPos.getY)
                Dim blockUnderPersoTopLeft = getBlockFromLocation(personnage.pos.getTopLeft.X, personnage.pos.getTopLeft.Y)
                Dim blockUnderPersoBottomRight = getBlockFromLocation(personnage.pos.getBottomRight.X - 1, personnage.pos.getBottomRight.Y - 1)
                Dim pCenter = getBlockFromLocation(personnage.pos.getCenter)
                Dim pRange = personnage.getRange

                If withinRange(blockPosition, pCenter, pRange) Then
                    If blocks(blockPosition.Y, blockPosition.X).blockTypeP = 9 OrElse blocks(blockPosition.Y, blockPosition.X).blockTypeP = 10 Then
                        'TODO
                        GlobalV.inventaire.interation()

                    ElseIf Not ((blockPosition.X >= blockUnderPersoTopLeft.X AndAlso blockPosition.X <= blockUnderPersoBottomRight.X) AndAlso _
                            (blockPosition.Y >= blockUnderPersoTopLeft.Y AndAlso blockPosition.Y <= blockUnderPersoBottomRight.Y)) Then
                        If Not blocks(blockPosition.Y, blockPosition.X).PCassable Then
                            If GlobalV.inventaire.getNbItemX(GlobalV.inventaire.getIndex) > 0 Then
                                blocks(blockPosition.Y, blockPosition.X) = New Block(getItemByIndex, False, blockPosition.X, blockPosition.Y, True, getTypeByIndex)
                                GlobalV.inventaire.setNbItemX(GlobalV.inventaire.getIndex, -1)
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If Keyboard.GetState().IsKeyDown(Keys.D1) Then
            GlobalV.inventaire.setIndex(0)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D2) Then
            GlobalV.inventaire.setIndex(1)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D3) Then
            GlobalV.inventaire.setIndex(2)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D4) Then
            GlobalV.inventaire.setIndex(3)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D5) Then
            GlobalV.inventaire.setIndex(4)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D6) Then
            GlobalV.inventaire.setIndex(5)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D7) Then
            GlobalV.inventaire.setIndex(6)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D8) Then
            GlobalV.inventaire.setIndex(7)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D9) Then
            GlobalV.inventaire.setIndex(8)
            GlobalV.inventaire.toolIsSelectedP() = False
        ElseIf Keyboard.GetState().IsKeyDown(Keys.D0) Then
            GlobalV.inventaire.toolIsSelectedP() = True
        End If

        If Keyboard.GetState().IsKeyDown(Keys.T) And currentToggleDelais <= 0 Then
            GlobalV.inventaire.toggleOutil()
            currentToggleDelais = Delais
        End If

        If Keyboard.GetState().IsKeyDown(Keys.Escape) Then
            showMenu = True
            threadd = Thread.CurrentThread
            Thread.CurrentThread.Suspend()
            SoundEffect.MasterVolume = CSng(modIntro.volume) / 100

            graphics.PreferredBackBufferWidth = res(currentRes, 0)
            graphics.PreferredBackBufferHeight = res(currentRes, 1)
            graphics.ApplyChanges()
        End If


        'getBlockFromLocation(personnage.pos.getX, personnage.pos.getY)

        'TODO: Add your update logic here'
        'The method that will update our sprite position'
        UpdateSprite(gameTime)
        centerScreen()

        Dim collidedMonsters = monsterCollision()

        For i As Integer = 0 To collidedMonsters.Count - 1
            showBattle = True
            threadd = Thread.CurrentThread
            Thread.CurrentThread.Suspend()
            allMonsters.Remove(collidedMonsters(i))
            allUnits.Remove(collidedMonsters(i))
        Next

        currentPickaxeDelais -= gameTime.ElapsedGameTime.TotalMilliseconds
        currentToggleDelais -= gameTime.ElapsedGameTime.TotalMilliseconds

        MyBase.Update(gameTime)
    End Sub



    Protected Overrides Sub Draw(ByVal gameTime As Microsoft.Xna.Framework.GameTime)
        GraphicsDevice.Clear(Color.Black)

        'Draw the sprite'
        spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend)
        For i As Integer = 0 To (sizeH \ BLOCK_SIZE) + (sizeH \ 3)
            For j As Integer = 0 To (sizeW \ BLOCK_SIZE) + BLOCK_SIZE
                Dim currentBlock = blockA(i, j)
                'Makes sure not to draw the border blocks as well as blocks outside the bounds of the array.
                If currentBlock.X >= 1 AndAlso currentBlock.X < (blocks.GetLength(1) - 1) AndAlso _
                   currentBlock.Y >= 1 AndAlso currentBlock.Y < (blocks.GetLength(0) - 1) Then
                    spriteBatch.Draw(blockSheet, New Vector2((j * BLOCK_SIZE) - (globalPos.getX Mod BLOCK_SIZE), (i * BLOCK_SIZE) - (globalPos.getY Mod BLOCK_SIZE)), getBlock(currentBlock).PTextureIndex, Color.White)
                End If
            Next
        Next

        spriteBatch.Draw(blockSheet, New Vector2(125, 25), dirt, Color.White) '0
        spriteBatch.Draw(blockSheet, New Vector2(187, 25), rock, Color.White) '1
        spriteBatch.Draw(blockSheet, New Vector2(252, 25), wood, Color.White) '2
        spriteBatch.Draw(blockSheet, New Vector2(317, 25), planche, Color.White) '3
        spriteBatch.Draw(blockSheet, New Vector2(382, 25), ironBlock, Color.White) '4
        spriteBatch.Draw(blockSheet, New Vector2(447, 25), coal, Color.White) '5
        spriteBatch.Draw(blockSheet, New Vector2(515, 25), ironOre, Color.White) '6
        ' spriteBatch.Draw(blockSheet, New Vector2(581, 0), , Color.White) '7
        spriteBatch.Draw(blockSheet, New Vector2(648, 25), GlobalV.inventaire.getTool(), Color.White) ' l'outil
        spriteBatch.Draw(inventaire, New Vector2(100, 0), Color.White) 'le contour brun

        For i = 0 To GlobalV.inventaire.getTableauInventaire.Length - 2
            spriteBatch.DrawString(font, CStr(GlobalV.inventaire.getNbItemX(i)), New Vector2(115 + (i * 65), 48), Color.Black)
        Next
        spriteBatch.DrawString(font, CStr(GlobalV.inventaire.nbOutilP), New Vector2(635, 48), Color.Black)

        For i As Integer = 0 To allMonsters.Count - 1
            spriteBatch.Draw(allMonsters(i).getTexture, New Vector2(allMonsters(i).pos.getX - globalPos.getX, allMonsters(i).pos.getY - globalPos.getY), allMonsters(i).getTextureArea, Color.White)
        Next

        spriteBatch.Draw(personnage.getTexture, New Vector2(personnage.pos.getX - globalPos.getX, personnage.pos.getY - globalPos.getY), personnage.getTextureArea, Color.White)

        spriteBatch.End()
        MyBase.Draw(gameTime)
    End Sub

    Private Sub UpdateSprite(ByVal gameTime As GameTime)
        'Code pour la gravité de toutes les unitées.
        For i As Integer = 0 To allUnits.Count - 1
            If allUnits(i).VectorLeft <= 0 Then
                allUnits(i).pos.modifyPosY(gameTime.ElapsedGameTime.TotalSeconds,
                                          getFirstCollision(allUnits(i).pos.getBottomLeft,
                                                            tP(allUnits(i).pos.getBottomRight, New Point(-1, 0)), New Point(0, 1)).Y)
            End If

            'Code pour sauter
            If allUnits(i).VectorLeft > 0 Then
                Dim stopJump = getFirstCollision(allUnits(i).pos.getTopLeft,
                                                 tP(allUnits(i).pos.getTopRight, New Point(-1, 0)), New Point(0, -1)).Y
                If stopJump <> 0 Then
                    allUnits(i).pos.modifyPosY(-gameTime.ElapsedGameTime.TotalSeconds,
                                               getFirstCollision(allUnits(i).pos.getTopLeft,
                                                                 tP(allUnits(i).pos.getTopRight, New Point(-1, 0)), New Point(0, -1)).Y)
                    allUnits(i).VectorLeft -= 5
                Else
                    allUnits(i).VectorLeft = 0
                End If
            End If
        Next

    End Sub

    Private Sub parseMap()
        Dim readMap() As String = File.ReadAllLines("../../../Map.map")
        ReDim blocks(readMap.GetLength(0) - 1, readMap(0).Length - 1)
        For i As Integer = 0 To blocks.GetLength(0) - 1
            For j As Integer = 0 To blocks.GetLength(1) - 1
                'System.Diagnostics.Debugger.Log(0, "", "j = " & j & vbNewLine)
                Try
                    blocks(i, j) = parseBlock(readMap(i)(j), i, j)
                Catch ex As Exception
                    blocks(i, j) = parseBlock(CChar("z"), i, j)
                End Try
            Next
        Next
    End Sub

    Private Function parseBlock(ByVal c As Char, i As Integer, j As Integer) As Block
        Const PASSABLE As Boolean = True
        Const N_PASSABLE As Boolean = False

        Select Case c
            Case CChar("s")
                If i < 17 Then
                    Return New Block(sky, PASSABLE, i, j, False, 0)
                ElseIf i = 17 Then
                    Return New Block(grassback, PASSABLE, i, j, False, 0)
                Else
                    Return New Block(dirtback, PASSABLE, i, j, False, 0)
                End If

            Case CChar("i")
                Return New Block(ironBlock, N_PASSABLE, i, j, True, 5)
            Case CChar("g")
                Dim randomTile = random.Next Mod 2
                Select Case randomTile
                    Case 1
                        Return New Block(grass, N_PASSABLE, i, j, True, 1)
                    Case Else
                        Return New Block(grass2, N_PASSABLE, i, j, True, 1)
                End Select
            Case CChar("d")
                Dim randomTile = random.Next Mod 75
                Select Case randomTile
                    Case 1
                        Return New Block(dirt2, N_PASSABLE, i, j, True, 1)
                    Case 2
                        Return New Block(dirt3, N_PASSABLE, i, j, True, 1)
                    Case 3
                        Return New Block(dirt4, N_PASSABLE, i, j, True, 1)
                    Case Else
                        Return New Block(dirt, N_PASSABLE, i, j, True, 1)
                End Select
            Case CChar("w")
                Return New Block(wood, N_PASSABLE, i, j, True, 3)
            Case CChar("l")
                Return New Block(leaf, N_PASSABLE, i, j, True, 0)
            Case CChar("p")
                Return New Block(planche, N_PASSABLE, i, j, True, 4)
            Case CChar("r")
                Return New Block(rock, N_PASSABLE, i, j, True, 2)
            Case CChar("c")
                Return New Block(coal, N_PASSABLE, i, j, True, 6)
            Case CChar("i")
                Return New Block(ironOre, N_PASSABLE, i, j, True, 7)
            Case CChar("f")
                Return New Block(oven, N_PASSABLE, i, j, True, 9)
            Case CChar("W")
                Return New Block(workbench, N_PASSABLE, i, j, True, 10)
            Case Else
                Return New Block(other, N_PASSABLE, i, j, True, 0)
        End Select
    End Function

    Private Sub centerScreen()
        Dim newX = personnage.pos.getCenter.X - (sizeW \ 2)
        Dim newY = personnage.pos.getCenter.Y - (sizeH \ 2)

        globalPos.setPosX(newX)
        globalPos.setPosY(newY)

    End Sub

    'Retourne les coordonnées d'un block à partir des coordonnées d'un array par rapport à l'écran.
    Private Function blockA(ByVal i As Integer, ByVal j As Integer) As Point
        Return getBlockFromLocation((j * BLOCK_SIZE) - (globalPos.getX Mod BLOCK_SIZE) + globalPos.getX, i * BLOCK_SIZE + globalPos.getY)
    End Function

    'En gros, cette fonction prend un point1 et un point2, et retourne tout les blocks dans la région entre ces deux points.
    'En général, point1 sera le point en haut à gauche et le point2 et bas à droite.
    Private Function getFirstCollision(p1 As Point, p2 As Point, p3 As Point) As Point
        Dim oldPoint As Point = New Point(p1.X, p2.Y)
        Dim distance As Point = New Point(p3.X * 100, p3.Y * 100)
        Dim collisionFound = False
        For i As Integer = 0 To 3
            If p1.Y <= 0 OrElse p2.Y <= 0 OrElse Not collision(p1, p2) Then
                If p3.X < 0 Then
                    distance = New Point(p1.X - oldPoint.X - (p1.X Mod BLOCK_SIZE) + BLOCK_SIZE, p1.Y - oldPoint.Y - (p1.Y Mod BLOCK_SIZE))
                ElseIf p3.Y < 0 Then
                    distance = New Point(p1.X - oldPoint.X - (p1.X Mod BLOCK_SIZE), p1.Y - oldPoint.Y - (p1.Y Mod BLOCK_SIZE) + BLOCK_SIZE)
                Else
                    distance = New Point(p1.X - oldPoint.X - (p1.X Mod BLOCK_SIZE), p1.Y - oldPoint.Y - (p1.Y Mod BLOCK_SIZE))
                End If
                collisionFound = True
                Exit For
            End If
            p1.X += BLOCK_SIZE * p3.X
            p2.X += BLOCK_SIZE * p3.X
            p1.Y += BLOCK_SIZE * p3.Y
            p2.Y += BLOCK_SIZE * p3.Y
        Next
        Return distance
    End Function
    Private Function getBlocksInRange(p1 As Point, p2 As Point) As List(Of Block)
        Dim blockList As List(Of Block) = New List(Of Block)
        Dim topLeft As Point = getBlockFromLocation(p1.X, p1.Y)
        Dim bottomRight As Point = getBlockFromLocation(p2.X, p2.Y)

        For i As Integer = topLeft.Y To bottomRight.Y
            For j As Integer = topLeft.X To bottomRight.X
                blockList.Add(getBlock(i, j))
            Next
        Next
        Return blockList
    End Function

    Private Function getBlockFromLocation(ByVal p As Point) As Point
        Return getBlockFromLocation(p.X, p.Y)
    End Function

    Private Function getBlockFromLocation(ByVal x As Integer, ByVal y As Integer) As Point
        Return New Point(x \ BLOCK_SIZE, y \ BLOCK_SIZE)
    End Function

    Private Function getBlock(p As Point) As Block
        Return getBlock(p.Y, p.X)
    End Function

    Private Function getBlock(x As Integer, y As Integer) As Block
        Return blocks(x, y)
    End Function

    Private Function collision(p1 As Point, p2 As Point) As Boolean
        Return collision(getBlocksInRange(p1, p2))
    End Function

    Private Function collision(blockList As List(Of Block)) As Boolean
        Dim collided As Boolean = True
        For Each b As Block In blockList
            If Not b.PPassable Then
                collided = False
                Exit For
            End If
        Next
        'getBlock(getBlockFromLocation(personnage.getposX + personnage.getCaracterW + 5, personnage.getposY)).isPassable
        Return collided
    End Function

    Private Function monsterCollision() As List(Of personnage)
        Dim list As New List(Of personnage)
        For Each m As personnage In allMonsters
            If personnage.pos.getTopLeft.X     < m.pos.getBottomRight.X AndAlso _
               personnage.pos.getBottomRight.X > m.pos.getTopLeft.X AndAlso _
               personnage.pos.getTopLeft.Y     < m.pos.getBottomRight.Y AndAlso _
               personnage.pos.getBottomRight.Y > m.pos.getTopLeft.Y Then
                list.Add(m)
            End If
        Next
        Return list
    End Function

    '''<summary>
    '''Adds two points together.
    '''</summary>
    '''<param name="p1">The first point</param>
    '''<param name="p2">The second point</param>
    '''<returns>The translated point.</returns>
    Private Function tP(p1 As Point, p2 As Point) As Point
        Return New Point(p1.X + p2.X, p1.Y + p2.Y)
    End Function

    '''<summary>
    '''Calculates the difference between two points.
    '''</summary>
    '''<param name="p1">The first point</param>
    '''<param name="p2">The second point</param>
    '''<returns>The difference between the two points.</returns>
    Private Function tPD(p1 As Point, p2 As Point) As Point
        Return New Point(p1.X - p2.X, p1.Y - p2.Y)
    End Function

    Public Function withinRange(p1 As Point, p2 As Point, r As Integer) As Boolean
        Dim difference = tPD(p1, p2)
        If difference.X < 0 Then
            difference = tP(difference, New Point(1, 0))
        End If
        If difference.Y < 0 Then
            difference = tP(difference, New Point(0, 2))
        Else
            difference = tP(difference, New Point(0, -2))
        End If

        Return Math.Abs(difference.X) <= r AndAlso Math.Abs(difference.Y) < r
    End Function

    'Beaucoup plus beau et plus facile d'utilser debug...
    Private Sub debug(s As String)
        System.Diagnostics.Debugger.Log(0, "", s & vbNewLine)
    End Sub


    Private Function getItemByIndex() As Rectangle
        Select Case GlobalV.inventaire.getIndex
            Case 0
                Return dirt
            Case 1
                Return rock
            Case 2
                Return wood
            Case 3
                Return planche
            Case 4
                Return ironBlock
            Case 5
                Return coal
            Case 6
                Return ironOre
            Case 7
            Case 9
                Return oven
            Case 10
                Return workbench
        End Select
    End Function

    Private Function getTypeByIndex() As Integer
        Select Case GlobalV.inventaire.getIndex
            Case 0
                Return 1
            Case 1
                Return 2
            Case 2
                Return 3
            Case 3
                Return 4
            Case 4
                Return 5
            Case 5
                Return 6
            Case 6
                Return 7
            Case 9
                Return 9
            Case 10
                Return 10
        End Select
    End Function
End Class