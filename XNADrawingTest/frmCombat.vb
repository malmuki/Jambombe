Imports System.Threading
Public Class frmCombat

    Dim labelAction(3) As Label
    Dim actionSelect As Integer
    Dim imageInUse As Integer
    Dim turnAvailable As Boolean = True
    Dim compteurTour As Integer = 0
    Dim monstre1TourActif As Boolean = False
    Dim defenseModifier As Integer = 1

    Const EXP_GAIN As Integer = 10


    Private Sub frmCombat_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        lblMnstrDmg.Visible = False
        lblHeroDmg.Visible = False
        If turnAvailable AndAlso battleIsOver = False AndAlso Me.Enabled Then
            Select Case CInt(e.KeyCode)
                Case moveDown
                    Call SoundSelectionEffect("cursor - move.wav")
                    Call SelectionAction(1)
                Case moveUp
                    Call SoundSelectionEffect("cursor - move.wav")
                    Call SelectionAction(-1)
                Case Keys.Enter
                    Call SoundSelectionEffect("cursor - set.wav")
                    If actionSelect = 0 Then
                        tmrAttaque.Enabled = True
                    ElseIf actionSelect = 3 Then
                        Call courrir()
                    End If
                    Call Selection()
                Case Keys.Escape
                    Call SoundSelectionEffect("cursor - cancel.wav")
                Case moveSaut
                    tmrMonstre1Atk.Enabled = True
                    Call SoundSelectionEffect("cursor - buzzer.wav")
            End Select
        ElseIf battleIsOver = False Then
            If e.KeyCode = Keys.Enter Then
                Call SoundSelectionEffect("cursor - buzzer.wav")
            End If
        ElseIf battleIsOver Then
            If e.KeyCode = Keys.Enter Then
                Me.Hide()
                threadd.Resume()
                Call Music("village.mp3")
            End If
        End If
        If e.KeyCode = Keys.P AndAlso battleIsOver = False Then
            Call SoundSelectionEffect("pause.wav")
            If Me.Enabled Then
                Me.Enabled = False
                lblPause.Visible = True
                Call Music("pause")
                tmrAttaque.Stop()
                tmrTour.Stop()
                tmrMonstre1Tour.Stop()
                tmrMonstre1Atk.Stop()
            Else
                Me.Enabled = True
                lblPause.Visible = False
                Call Music("unpause")
                If imageInUse <> 0 Then
                    tmrAttaque.Start()
                End If
                If compteurTour < 131 Then
                    tmrTour.Start()
                End If
                If monstre1TourActif Then
                    tmrMonstre1Tour.Start()
                End If
                If picMonstre1.Top <> 155 Then
                    tmrMonstre1Atk.Start()
                End If
            End If
        End If
    End Sub

    Private Sub frmCombat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        picMonstre1.Image = My.Resources.asludge
        labelAction(0) = lblAttaque
        labelAction(1) = lblDefense
        labelAction(2) = lblItem
        labelAction(3) = lblCourrir
        picBackground.Size = Me.Size
        picBackground.Top = 0
        picBackground.Left = 0
        lblMnstrDmg.ForeColor = Color.Red
        lblHeroDmg.ForeColor = Color.Red
        lblNom.Text = GlobalV.personnage.PNomPersonnage
        lblHeroHP.Text = CStr(heroHP) & "/300"
    End Sub

    Public Sub SelectionAction(ByVal movement As Integer)
        If actionSelect + movement > 3 Then
            actionSelect = 0
        ElseIf actionSelect + movement < 0 Then
            actionSelect = 3
        Else
            actionSelect += movement
        End If
        picMain.Top = labelAction(actionSelect).Top
    End Sub

    Private Sub tmrAttaque_Tick(sender As Object, e As EventArgs) Handles tmrAttaque.Tick
        Dim dommageHero As Integer
        imageInUse += 1
        Select Case imageInUse
            Case 1
                picA1.Visible = False
                picA2.Visible = True
            Case 2
                picA2.Visible = False
                picA3.Visible = True
            Case 3
                picA3.Visible = False
                picA4.Visible = True
            Case 4
                picA4.Visible = False
                picA5.Visible = True
            Case 5
                picA5.Visible = False
                picA6.Visible = True
            Case 6
                picA6.Visible = False
                Call PlaySoundEffect("390.wav")
                dommageHero = CInt((Rnd() * heroDamage))
                If dommageHero > 0 Then
                    lblHeroDmg.Text = CStr(dommageHero)
                Else
                    lblHeroDmg.Text = "Manqué!"
                End If
                lblHeroDmg.Visible = True
                monstre1HP -= dommageHero
                picA7.Visible = True
            Case Else
                If battleIsOver Then
                    imageInUse += 1
                End If
                imageInUse = 0
                picA7.Visible = False
                picA1.Visible = True
                tmrAttaque.Enabled = False
        End Select
    End Sub

    Private Sub lblAttaque_Click(sender As Object, e As EventArgs) Handles lblAttaque.Click
        If battleIsOver = False Then
            tmrAttaque.Enabled = True
            Call Selection()
            Call SoundSelectionEffect("cursor - set.wav")
        End If
    End Sub

    Private Sub lbl_Actions_MouseEnter(sender As Object, e As EventArgs) Handles lblAttaque.MouseEnter, lblDefense.MouseEnter, lblCourrir.MouseEnter, lblItem.MouseEnter
        If battleIsOver = False Then
            If picMain.Top <> CType(sender, Label).Top Then
                picMain.Top = CType(sender, Label).Top
                Call SoundSelectionEffect("cursor - move.wav")
            End If
            Select Case CType(sender, Label).Name
                Case lblAttaque.Name
                    actionSelect = 0
                Case lblCourrir.Name
                    actionSelect = 3
                Case lblItem.Name
                    actionSelect = 2
                Case lblDefense.Name
                    actionSelect = 1
            End Select
        End If
    End Sub

    Private Sub tmrTour_Tick(sender As Object, e As EventArgs) Handles tmrTour.Tick
        compteurTour += 1
        picATBMove.Width += 1
        If compteurTour >= 131 Then
            picMain.Top = lblAttaque.Top
            actionSelect = 0
            lblAttaque.Enabled = True
            lblCourrir.Enabled = True
            lblItem.Enabled = True
            lblDefense.Enabled = True
            picMain.Visible = True
            turnAvailable = True

            tmrTour.Enabled = False
        End If
    End Sub

    Private Sub tmrMonstre1Atk_Tick(sender As Object, e As EventArgs) Handles tmrMonstre1Atk.Tick
        Dim dommageMonstre As Integer

        If picMonstre1.Left < picA1.Left - 100 Then
            picMonstre1.Top = picA1.Top
            picMonstre1.Left = picA1.Left - 100
        ElseIf picMonstre1.Left = picA1.Left - 100 Then
            picMonstre1.Left = picA1.Left - 80
            picMonstre1.Top += -10
            Call PlaySoundEffect("hit.wav")
        ElseIf picMonstre1.Left = picA1.Left - 80 Then
            picMonstre1.Left = picA1.Left - 99
            picMonstre1.Top += 10
            dommageMonstre = CInt(((Rnd() * monstre1Damage)) / defenseModifier)
            If dommageMonstre > 0 Then
                lblMnstrDmg.Text = CStr(dommageMonstre)
            Else
                lblMnstrDmg.Text = "Manqué!"
            End If
            lblMnstrDmg.Visible = True
            heroHP -= dommageMonstre
            lblHeroHP.Text = CStr(heroHP) & "/300"
        ElseIf picMonstre1.Left = picA1.Left - 99 Then
            picMonstre1.Left = 135
            picMonstre1.Top = 155
            tmrMonstre1Atk.Enabled = False
        End If

    End Sub

    Private Sub tmrMonstre1Tour_Tick(sender As Object, e As EventArgs) Handles tmrMonstre1Tour.Tick
        If monstre1HP > 0 Then
            tmrMonstre1Atk.Enabled = True
            monstre1TourActif = False
        Else
            tmrMonstre1Tour.Enabled = False
            experience += EXP_GAIN
            lblExpGain.Text = experience.ToString
            picMonstre1.Hide()
            Call PlaySoundEffect("kill2.wav")
            Call Music("fanfare.mp3")
            battleIsOver = True
            pnlExp.Visible = True
        End If
        tmrMonstre1Tour.Enabled = False
    End Sub

    Private Sub lblCourrir_Click(sender As Object, e As EventArgs) Handles lblCourrir.Click
        If battleIsOver = False Then
            Call courrir()
            Call Selection()
        End If
    End Sub

    Public Sub Selection()
        lblAttaque.Enabled = False
        lblCourrir.Enabled = False
        lblItem.Enabled = False
        lblDefense.Enabled = False
        picMain.Visible = False
        turnAvailable = False
        compteurTour = 0
        picATBMove.Width = 0
        tmrTour.Enabled = True
        tmrMonstre1Tour.Enabled = True
        monstre1TourActif = True
    End Sub

    Public Sub courrir()
        Call PlaySoundEffect("run.wav")
    End Sub

    Private Sub tmrCombat_Tick(sender As Object, e As EventArgs) Handles tmrCombat.Tick
        If showBattle Then
            Call Combat()
        End If
    End Sub

    Public Sub Combat()
        pnlExp.Visible = False
        picMonstre1.Visible = True
        Call Music("battle theme.mp3")
        Call PlaySoundEffect("battle swirl.wav")
        monstre1HP = 10
        monstre1Damage = 7
        battleIsOver = False
        Me.Show()
        showBattle = False
    End Sub

    Private Sub lblOk_Click(sender As Object, e As EventArgs) Handles lblOk.Click
        Me.Hide()
        threadd.Resume()
        Call Music("village.mp3")
    End Sub
End Class