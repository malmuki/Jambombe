Imports System.Threading

Public Class frmIntro
    Dim keyToBind As Integer
    Dim tempMoveUp As Integer
    Dim tempMoveDown As Integer
    Dim tempMoveLeft As Integer
    Dim tempMoveRight As Integer
    Dim tempMoveSaut As Integer
    Dim introFlashValeurMax As Boolean
    Dim introFlashValeurActive As Integer

    Private Sub lblOptions_Click(sender As Object, e As EventArgs) Handles lblOptions.Click
        'Joue un son distinctif, affiche le panel d'options.
        Call SoundSelectionEffect("cursor - accept.wav")
        Call AfficheOptions()
    End Sub

    Private Sub lblQuitter_Click(sender As Object, e As EventArgs) Handles lblQuitter.Click
        End
    End Sub

    Private Sub frmIntro_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, trbVolume.KeyDown
        'Verifie pour l'affectation de "keybinds" pour qu'une touche ne sois pas affecter a plus d'une action.
        'Joue un son distinctif en cas d'erreur.
        Call Intro()

        If lblBinding.Visible Then
            If e.KeyCode <> moveDown AndAlso e.KeyCode <> moveUp AndAlso e.KeyCode <> moveRight AndAlso e.KeyCode <> moveLeft AndAlso e.KeyCode <> moveSaut Then
                Select Case keyToBind
                    Case 1
                        Call KeyToText(lblValHaut, e.KeyCode)
                    Case 2
                        KeyToText(lblValBas, e.KeyCode)
                    Case 3
                        Call KeyToText(lblValDroit, e.KeyCode)
                    Case 4
                        Call KeyToText(lblValGauche, e.KeyCode)
                    Case 5
                        Call KeyToText(lblValSaut, e.KeyCode)
                End Select
            Else
                Call SoundSelectionEffect("cursor - buzzer.wav")
            End If
            lblBinding.Visible = False
        End If
    End Sub

    Private Sub frmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chargement de la musique d'intro, des variables sauvegarder dans le fichier ini et ajustement de la fenetre en consequence.
        AxWMPMusic.URL = "intro.mp3"
        Call SetRes()
        Call ReadVar()
        lbltitre.Left = CInt((Me.Width - lbltitre.Width) / 2)
        lblIntro.Top = CInt(pnlMenu.Top + (pnlMenu.Height - lblIntro.Height) / 2)
        lblIntro.Left = CInt(pnlMenu.Left + (pnlMenu.Width - lblIntro.Width) / 2)
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        'Affiche le menu de base, assigne les changements d'options (propriétés)
        Call SoundSelectionEffect("cursor - accept.wav")
        pnlMenu.Visible = True
        pnlOptions.Visible = False
        Me.Focus()
        Call Options(Me.Width, Me.Height, moveUp, moveDown, moveLeft, moveRight, moveSaut)
        Call SaveOptions()
    End Sub

    Private Sub lblResDown_Click(sender As Object, e As EventArgs) Handles lblResDown.Click
        'Sert a descendre dans les resolutions possibles (Tableau)
        valMenu = -1
        'Affiche la resolution affecter a la nouvelle valeur dans le tableau
        Call SelectRes()
    End Sub

    Private Sub lblResUp_Click(sender As Object, e As EventArgs) Handles lblResUp.Click
        'Sert a monter dans les resolutions possibles (Tableau)
        valMenu = 1
        'Affiche la resolution affecter a la nouvelle valeur dans le tableau
        Call SelectRes()
    End Sub

    'Prends en charge l'entrée et sortie du curseur dans les different labels.

    Private Sub lblResDown_MouseEnter(sender As Object, e As EventArgs) Handles lblResDown.MouseEnter, lblResUp.MouseEnter
        'Change l'affichage pour montrer ce qui est sélectionner et joue un son
        Call SoundSelectionEffect("cursor - move.wav")
        Call MouseEnters(CType(sender, Label))
        CType(sender, Label).Top += -3
        CType(sender, Label).Left += -3
    End Sub

    Private Sub lblResDown_MouseLeave(sender As Object, e As EventArgs) Handles lblResDown.MouseLeave, lblResUp.MouseLeave
        'Ramene l'affichage de départ pour montrer la déselection de l'item.
        Call MouseLeaves(CType(sender, Label))
        CType(sender, Label).Top += 3
        CType(sender, Label).Left += 3
    End Sub

    Private Sub lblOptions_MouseEnter(sender As Object, e As EventArgs) Handles lblOptions.MouseEnter, lblCommencer.MouseEnter, lblQuitter.MouseEnter
        'Change l'affichage pour montrer ce qui est sélectionner et joue un son
        Call SoundSelectionEffect("cursor - move.wav")
        Call MouseEnters(CType(sender, Label))
    End Sub

    Private Sub lblOptions_MouseLeave(sender As Object, e As EventArgs) Handles lblOptions.MouseLeave, lblQuitter.MouseLeave, lblCommencer.MouseLeave
        'Ramene l'affichage de départ pour montrer la déselection de l'item.
        Call MouseLeaves(CType(sender, Label))
    End Sub

    Private Sub lblValHaut_Click(sender As Object, e As EventArgs) Handles lblValHaut.Click
        'Appelle l'affectation de variable
        lblBinding.Text = "Affectez Haut"
        lblBinding.Visible = True
        keyToBind = 1
        Me.Focus()
    End Sub

    Private Sub frmIntro_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If lblBinding.Visible = True Then
            Me.Focus()
        End If
    End Sub

    Private Sub lblValBas_Click(sender As Object, e As EventArgs) Handles lblValBas.Click
        'Appelle l'affectation de variable
        lblBinding.Text = "Affectez Bas"
        lblBinding.Visible = True
        keyToBind = 2
        Me.Focus()
    End Sub

    Private Sub lblValGauche_Click(sender As Object, e As EventArgs) Handles lblValGauche.Click
        'Appelle l'affectation de variable
        lblBinding.Text = "Affectez Gauche"
        lblBinding.Visible = True
        keyToBind = 4
        Me.Focus()
    End Sub

    Private Sub lblValDroit_Click(sender As Object, e As EventArgs) Handles lblValDroit.Click
        'Appelle l'affectation de variable
        lblBinding.Text = "Affectez Droit"
        lblBinding.Visible = True
        keyToBind = 3
        Me.Focus()
    End Sub

    Private Sub tmrIntro_Tick(sender As Object, e As EventArgs) Handles tmrIntro.Tick
        'Affiche un jolie label dont la couleur change avec le temps.
        Const VALEUR_FLASH_MODIFIE As Integer = 2
        Const VALEUR_MIN_FLASH As Integer = 35
        Const VALEUR_MAX_FLASH As Integer = 250
        If introFlashValeurMax Then
            If introFlashValeurActive < VALEUR_MIN_FLASH Then
                introFlashValeurActive = introFlashValeurActive + VALEUR_FLASH_MODIFIE
                introFlashValeurMax = False
            Else
                introFlashValeurActive = introFlashValeurActive - VALEUR_FLASH_MODIFIE

            End If

        Else
            If introFlashValeurActive > VALEUR_MAX_FLASH Then
                introFlashValeurActive = introFlashValeurActive - VALEUR_FLASH_MODIFIE
                introFlashValeurMax = True
            Else
                introFlashValeurActive = introFlashValeurActive + VALEUR_FLASH_MODIFIE

            End If
        End If
        lblIntro.ForeColor = Color.FromArgb(introFlashValeurActive, introFlashValeurActive, introFlashValeurActive)
    End Sub

    Private Sub lblValSaut_Click(sender As Object, e As EventArgs) Handles lblValSaut.Click
        'Appelle l'affectation de variable
        lblBinding.Text = "Affectez Saut"
        lblBinding.Visible = True
        keyToBind = 5
        Me.Focus()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        'Joue un son distinctif pour spécifier a l'utilisateur que les changements ont ete annule et retourne au panel
        'precedent
        Call SoundSelectionEffect("cursor - cancel.wav")
        keyToBind = 0
        lblBinding.Visible = False
        moveUp = iniMoveUp
        moveDown = iniMoveDown
        moveLeft = iniMoveLeft
        moveRight = iniMoveRight
        moveSaut = iniMoveSaut
        pnlMenu.Visible = True
        pnlOptions.Visible = False
        Me.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Joue un son distinctif pour specifier a l'utilisateur l'annulation des changements.
        Call SoundSelectionEffect("cursor - cancel.wav")
        Call ResetOptions()
    End Sub

    Private Sub lbltitre_Click(sender As Object, e As EventArgs) Handles lbltitre.Click, lblIntro.Click, Me.MouseClick

        Call Intro()
    End Sub

    Private Sub trbVolume_Scroll(sender As Object, e As EventArgs) Handles trbVolume.Scroll
        'Change la valeur de volume des differents sons et musique du jeu
        Call SoundVolume(trbVolume.Value)
    End Sub

    Private Sub AxWMPMusic_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWMPMusic.PlayStateChange
        'Permet de jouer en boucle la musique
        If calledMusic = False Then
            AxWMPMusic.Ctlcontrols.play()
        End If
    End Sub

    Private Sub lblCommencer_Click(sender As Object, e As EventArgs) Handles lblCommencer.Click
        'Joue un son distinctif pour specifier a l'utilisateur que son choix est pris en compte
        'Affiche la fenetre suivante.
        Call SoundSelectionEffect("cursor - accept.wav")
        'frmCombat.Show
        Call Music("village.mp3")
        If Not gameStarted Then
            gameStarted = True
            frmCommencer.Show()
        Else
            Me.Hide()
            threadd.Resume()
        End If
    End Sub

    Private Sub tmrMenu_Tick(sender As Object, e As EventArgs) Handles tmrMenu.Tick
        If showMenu Then
            lblCommencer.Text = "Continuer"
            Call Music("intro.mp3")
            Me.Show()
            showMenu = False
        End If
    End Sub
End Class
