Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework

Public Class personnage

    Const REGEN_PV_TOUR As Single = 0.05
    Const REGEN_MP_TOUR As Single = 0.05

    Private maxPV As Integer
    Private maxPM As Integer
    Private PV As Integer
    Private PM As Integer
    Private range As Integer
    Public pos As New Location

    'pour le saut
    Public VectorLeft As Integer = 0

    Sub New(p As Point)
        maxPV = 100
        maxPM = 20
        PV = maxPV
        PM = maxPM
        range = 4
        pos.setPosX(GlobalV.BLOCK_SIZE * (p.X + 1))
        pos.setPosY((GlobalV.BLOCK_SIZE * (p.Y + 1)) - pos.getSize.Y)

    End Sub

    Public Sub moveLeft(ByVal time As Double, ByVal limit As Integer)
        pos.modifyPosX(time, limit)
        textureSheet.setRow(0)
        textureSheet.nextFrame(time)
    End Sub
    Public Sub moveRight(ByVal time As Double, ByVal limit As Integer)
        pos.modifyPosX(time, limit)
        textureSheet.setRow(1)
        textureSheet.nextFrame(time)
    End Sub
    'get

    Public Function getCaracterW() As Integer
        Return pos.getSize.X
    End Function
    Public Function getCaracterH() As Integer
        Return pos.getSize.Y
    End Function
    Public Function getRange() As Integer
        Return range
    End Function

    Private textureSheet As SpriteSheet = New SpriteSheet
    Public Sub setTexture(ByVal value As Texture2D, ByVal c As Point, s As Point)
        pos.setWidth(s.X - 1)
        pos.setHeight(s.Y - 1)
        textureSheet.setSheet(value, c, s)
    End Sub
    Public Function getTexture() As Texture2D
        Return textureSheet.getTexture
    End Function
    Public Function getTextureArea() As Rectangle
        Return textureSheet.getCurrentArea
    End Function
    Public Sub resetTexture()
        textureSheet.setRow(2)
    End Sub

    'nomperso
    Private nomPersonnage As String
    Public Property PNomPersonnage() As String
        Get
            Return nomPersonnage
        End Get
        Set(ByVal value As String)
            nomPersonnage = value
        End Set
    End Property
    'classe
    Private classe As String
    Public Property PClasse() As String
        Get
            Return classe
        End Get
        Set(ByVal value As String)
            classe = value
        End Set
    End Property

    'Beaucoup plus beau et plus facile d'utilser debug...
    Private Sub debug(s As String)
        System.Diagnostics.Debugger.Log(0, "", s & vbNewLine)
    End Sub
End Class