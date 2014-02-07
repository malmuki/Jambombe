Imports System.IO

Module modIntro
    Dim fontenter As Font = New Font("MS Sans Serif", 16, FontStyle.Bold)
    Dim fontleave As Font = New Font("MS Sans Serif", 12, FontStyle.Bold)

    'Variables pour resolution
    Const VALEUR_TITRE As Integer = 600
    Const TOTAL_RESOLUTIONS As Integer = 3
    Public res(TOTAL_RESOLUTIONS, 1) As Integer
    Public valMenu As Integer
    Dim resCompteur As Integer = 0
    Public currentRes As Integer = 0

    'Valeur Keycode pour movement du personnage
    Public moveUp As Integer = CInt(Keys.W)
    Public moveDown As Integer = CInt(Keys.S)
    Public moveLeft As Integer = CInt(Keys.A)
    Public moveRight As Integer = CInt(Keys.D)
    Public moveSaut As Integer = CInt(Keys.Space)
    Public iniMoveUp As Integer
    Public iniMoveDown As Integer
    Public iniMoveLeft As Integer
    Public iniMoveRight As Integer
    Public iniMoveSaut As Integer

    Public iniVolume As Integer
    Public volume As Integer = 100

    Public showBattle As Boolean = False
    Public showMenu As Boolean = False

    Public gameStarted As Boolean = False

    Public Sub MouseEnters(ByVal labelMouseEnters As Label)
        labelMouseEnters.Font = fontenter
    End Sub

    Public Sub MouseLeaves(ByVal labelMouseLeaves As Label)
        labelMouseLeaves.Font = fontleave
    End Sub

    Public Sub SetRes()
        'Affecte des valeurs de resolutions
        res(0, 0) = 800
        res(0, 1) = 600
        res(1, 0) = 1024
        res(1, 1) = 768
        res(2, 0) = 1280
        res(2, 1) = 960
        res(3, 0) = 1920
        res(3, 1) = 1080
    End Sub
    Public Sub SelectRes()
        'Permet de changer la resolution afficher dans les options
        If resCompteur + valMenu < 0 Then
            resCompteur = TOTAL_RESOLUTIONS
        ElseIf resCompteur + valMenu > TOTAL_RESOLUTIONS Then
            resCompteur = 0
        Else
            resCompteur += valMenu
        End If
        frmIntro.lblResCurrent.Text = CStr(res(resCompteur, 0)) & " x " & CStr(res(resCompteur, 1))
    End Sub
    Public Sub Options(VieilleLargeur As Integer, VieilleHauteur As Integer, newMoveUp As Integer, newMoveDown As Integer, newMoveLeft As Integer, newMoveRight As Integer, newMoveSaut As Integer)
        'Affecte la resolution a la form d'intro
        currentRes = resCompteur
        frmIntro.Width = (res(currentRes, 0))
        frmIntro.Height = (res(currentRes, 1))
        frmIntro.Left = CInt(frmIntro.Left - ((frmIntro.Width - VieilleLargeur) / 2))
        frmIntro.Top = CInt(frmIntro.Top - ((frmIntro.Height - VieilleHauteur) / 2))
        frmIntro.pnlMenu.Left = CInt(frmIntro.pnlMenu.Left + ((frmIntro.Width - VieilleLargeur) / 2))
        frmIntro.pnlMenu.Top = CInt(frmIntro.pnlMenu.Top + ((frmIntro.Height - VieilleHauteur) / 2))
        frmIntro.pnlOptions.Left = frmIntro.pnlMenu.Left
        frmIntro.pnlOptions.Top = frmIntro.pnlMenu.Top
        frmIntro.lbltitre.Left = CInt((frmIntro.Width - frmIntro.lbltitre.Width) / 2)
        frmIntro.lbltitre.Top = CInt((frmIntro.Height - VALEUR_TITRE + frmIntro.lbltitre.Height) / 2)
        volume = frmIntro.trbVolume.Value
        moveUp = newMoveUp
        moveDown = newMoveDown
        moveLeft = newMoveLeft
        moveRight = newMoveRight
        moveSaut = newMoveSaut
    End Sub

    Public Sub KeyToText(ByRef LabelReturned As Label, ByVal KeyChar As Integer)
        'Affecte les "Keybinds". Affecte leur valeur au label correspondant. Verifie que la touche est valide.
        Dim tempMoveUp As Integer = moveUp
        Dim tempMoveDown As Integer = moveDown
        Dim tempMoveLeft As Integer = moveLeft
        Dim tempMoveright As Integer = moveRight
        Dim tempMoveSaut As Integer = moveSaut

        If LabelReturned.Name = frmIntro.lblValHaut.Name Then
            moveUp = KeyChar
        ElseIf LabelReturned.Name = frmIntro.lblValBas.Name Then
            moveDown = KeyChar
        ElseIf LabelReturned.Name = frmIntro.lblValGauche.Name Then
            moveLeft = KeyChar
        ElseIf LabelReturned.Name = frmIntro.lblValDroit.Name Then
            moveRight = KeyChar
        ElseIf LabelReturned.Name = frmIntro.lblValSaut.Name Then
            moveSaut = KeyChar
        End If
        Select Case KeyChar
            Case CInt(Keys.ControlKey)
                LabelReturned.Text = "CTRL"
            Case CInt(Keys.ShiftKey)
                LabelReturned.Text = "Maj"
            Case CInt(Keys.Enter)
                LabelReturned.Text = "Entrée"
            Case CInt(Keys.CapsLock)
                LabelReturned.Text = "Verr Maj"
            Case CInt(Keys.NumPad0)
                LabelReturned.Text = "Num 0"
            Case CInt(Keys.NumPad1)
                LabelReturned.Text = "Num 1"
            Case CInt(Keys.NumPad2)
                LabelReturned.Text = "Num 2"
            Case CInt(Keys.NumPad3)
                LabelReturned.Text = "Num 3"
            Case CInt(Keys.NumPad4)
                LabelReturned.Text = "Num 4"
            Case CInt(Keys.NumPad5)
                LabelReturned.Text = "Num 5"
            Case CInt(Keys.NumPad6)
                LabelReturned.Text = "Num 6"
            Case CInt(Keys.NumPad7)
                LabelReturned.Text = "Num 7"
            Case CInt(Keys.NumPad8)
                LabelReturned.Text = "Num 8"
            Case CInt(Keys.NumPad9)
                LabelReturned.Text = "Num 9"
            Case CInt(Keys.F1)
                LabelReturned.Text = "F1"
            Case CInt(Keys.F2)
                LabelReturned.Text = "F2"
            Case CInt(Keys.F3)
                LabelReturned.Text = "F3"
            Case CInt(Keys.F4)
                LabelReturned.Text = "F4"
            Case CInt(Keys.F5)
                LabelReturned.Text = "F5"
            Case CInt(Keys.F6)
                LabelReturned.Text = "F6"
            Case CInt(Keys.F7)
                LabelReturned.Text = "F7"
            Case CInt(Keys.F8)
                LabelReturned.Text = "F8"
            Case CInt(Keys.F9)
                LabelReturned.Text = "F9"
            Case CInt(Keys.F10)
                LabelReturned.Text = "F10"
            Case CInt(Keys.F11)
                LabelReturned.Text = "F11"
            Case CInt(Keys.F12)
                LabelReturned.Text = "F12"
            Case CInt(Keys.Escape)
                LabelReturned.Text = "Esc"
            Case CInt(Keys.Space)
                LabelReturned.Text = "Espace"
            Case CInt(Keys.Alt)
                LabelReturned.Text = "Alt"
            Case CInt(Keys.OemPeriod)
                LabelReturned.Text = "."
            Case CInt(Keys.Oemcomma)
                LabelReturned.Text = ","
            Case CInt(Keys.OemQuestion)
                LabelReturned.Text = "?"
            Case CInt(Keys.OemSemicolon)
                LabelReturned.Text = ";"
            Case CInt(Keys.Oemtilde)
                LabelReturned.Text = "~"
            Case CInt(Keys.OemQuotes)
                LabelReturned.Text = "'"
            Case CInt(Keys.OemOpenBrackets)
                LabelReturned.Text = "["
            Case CInt(Keys.OemCloseBrackets)
                LabelReturned.Text = "]"
            Case CInt(Keys.Oemplus)
                LabelReturned.Text = "="
            Case CInt(Keys.OemMinus)
                LabelReturned.Text = "-"
            Case CInt(Keys.OemBackslash)
                LabelReturned.Text = "\"
            Case 37
                LabelReturned.Text = "←"
            Case 38
                LabelReturned.Text = "↑"
            Case 39
                LabelReturned.Text = "→"
            Case 40
                LabelReturned.Text = "↓"
            Case 46 To 57, 65 To 90
                LabelReturned.Text = Chr(KeyChar)
            Case Else
                If LabelReturned.Name = frmIntro.lblValHaut.Name Then
                    Call KeyToText(frmIntro.lblValHaut, tempMoveUp)
                ElseIf LabelReturned.Name = frmIntro.lblValBas.Name Then
                    Call KeyToText(frmIntro.lblValBas, tempMoveDown)
                ElseIf LabelReturned.Name = frmIntro.lblValGauche.Name Then
                    Call KeyToText(frmIntro.lblValGauche, tempMoveLeft)
                ElseIf LabelReturned.Name = frmIntro.lblValDroit.Name Then
                    Call KeyToText(frmIntro.lblValDroit, tempMoveright)
                ElseIf LabelReturned.Name = frmIntro.lblValSaut.Name Then
                    Call KeyToText(frmIntro.lblValDroit, tempMoveSaut)
                End If
                Call SoundSelectionEffect("cursor - buzzer.wav")
        End Select
    End Sub
    Public Sub AfficheOptions()
        'Affecte la resolution actuelle au lblRes et affiche le menu d'options
        resCompteur = currentRes
        frmIntro.lblResCurrent.Text = CStr(res(currentRes, 0)) & " x " & CStr(res(currentRes, 1))

        Call KeyToText(frmIntro.lblValHaut, moveUp)
        Call KeyToText(frmIntro.lblValBas, moveDown)
        Call KeyToText(frmIntro.lblValGauche, moveLeft)
        Call KeyToText(frmIntro.lblValDroit, moveRight)
        Call KeyToText(frmIntro.lblValSaut, moveSaut)

        iniVolume = volume
        iniMoveUp = moveUp
        iniMoveDown = moveDown
        iniMoveLeft = moveLeft
        iniMoveRight = moveRight
        iniMoveSaut = moveSaut

        frmIntro.pnlMenu.Visible = False
        frmIntro.pnlOptions.Visible = True

    End Sub

    Public Sub ResetOptions()
        'Ramene les valeurs aux valeurs precedentes.
        moveUp = iniMoveUp
        moveDown = iniMoveDown
        moveLeft = iniMoveLeft
        moveRight = iniMoveRight
        moveSaut = iniMoveSaut

        Call KeyToText(frmIntro.lblValHaut, moveUp)
        Call KeyToText(frmIntro.lblValBas, moveDown)
        Call KeyToText(frmIntro.lblValGauche, moveLeft)
        Call KeyToText(frmIntro.lblValDroit, moveRight)
        Call KeyToText(frmIntro.lblValSaut, moveSaut)

        Call SoundVolume(iniVolume)
        frmIntro.trbVolume.Value = iniVolume

        resCompteur = currentRes
        frmIntro.lblResCurrent.Text = CStr(res(currentRes, 0)) & " x " & CStr(res(currentRes, 1))

        frmIntro.lblBinding.Visible = False
    End Sub

    Public Sub Intro()
        'Passe de l'intro label aux menus.
        If frmIntro.tmrIntro.Enabled Then
            frmIntro.tmrIntro.Stop()
            frmIntro.lblIntro.Visible = False
            frmIntro.pnlMenu.Visible = True
        End If
    End Sub

    Public Sub ReadVar()
        'Lecture du fichier ini et affectation des variables.
        Dim fichierLecture As StreamReader = File.OpenText("JamBombe.ini")
        Dim iniVars(8) As String
        Dim compteur As Integer = 0

        For compteur = 0 To 8
            iniVars(compteur) = CStr(fichierLecture.ReadLine())
        Next compteur

        resCompteur = CInt(iniVars(1).Substring(12, iniVars(1).Length - 12))
        volume = CInt(iniVars(2).Substring(12, iniVars(2).Length - 12))
        moveUp = CInt(iniVars(4).Substring(12, iniVars(4).Length - 12))
        moveDown = CInt(iniVars(5).Substring(12, iniVars(5).Length - 12))
        moveLeft = CInt(iniVars(6).Substring(12, iniVars(6).Length - 12))
        moveRight = CInt(iniVars(7).Substring(12, iniVars(7).Length - 12))
        moveSaut = CInt(iniVars(8).Substring(12, iniVars(8).Length - 12))

        Call SoundVolume(volume)

        Call Options(800, 600, moveUp, moveDown, moveLeft, moveRight, moveSaut)
        fichierLecture.Close()
    End Sub

    Public Sub SaveOptions()
        'Sauvegarde des options dans un fichier ini
        Dim fichierEcriture As StreamWriter
        fichierEcriture = File.CreateText("JamBombe.ini")

        fichierEcriture.WriteLine("***** NE PAS MODIFIER!!! *****")
        fichierEcriture.WriteLine("Resolution: " & currentRes)
        fichierEcriture.WriteLine("Volume:     " & volume.ToString)
        fichierEcriture.WriteLine("Keybinds")
        fichierEcriture.WriteLine("Haut:       " & moveUp.ToString)
        fichierEcriture.WriteLine("Bas:        " & moveDown.ToString)
        fichierEcriture.WriteLine("Gauche:     " & moveLeft.ToString)
        fichierEcriture.WriteLine("Droite:     " & moveRight.ToString)
        fichierEcriture.WriteLine("Saut:       " & moveSaut.ToString)

        fichierEcriture.Close()
    End Sub

    Public Sub SoundVolume(SndVolume As Integer)
        'Affectation de volume.
        volume = SndVolume
        frmIntro.AxWMPMusic.settings.volume = volume
        frmCombat.AxWMPSoundSelectionEffect.settings.volume = volume
        frmCombat.AxWMPSoundEffect.settings.volume = volume
        frmIntro.trbVolume.Value = volume
        frmIntro.lblVolValue.Text = volume.ToString & " %"
    End Sub
End Module
