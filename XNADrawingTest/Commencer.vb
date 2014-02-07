Imports System.Threading
Imports System.IO
Imports Microsoft.Xna.Framework

Public Class frmCommencer

    Private Sub btnDemarer_Click(sender As Object, e As EventArgs) Handles btnDemarer.Click
        Const INVALIDE As String = "Entrer non-valide!"

        GlobalV.personnage = New personnage(New Point(20, 2))
        If txtnom.Text <> "" Then
            GlobalV.personnage.PNomPersonnage = txtnom.Text
        Else
            MessageBox.Show(INVALIDE, INVALIDE, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Select Case lsbClasse.SelectedIndex

            Case 0
                GlobalV.personnage.PClasse = GlobalV.NOM_CLASSE_WARRIOR
            Case 1
                GlobalV.personnage.PClasse = GlobalV.NOM_CLASSE_MAGE
            Case 2
                GlobalV.personnage.PClasse = GlobalV.NOM_CLASSE_ROGUE
            Case Else
                MessageBox.Show(INVALIDE, INVALIDE, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        Dim thread As New Thread(AddressOf startGame)
        thread.Start()
        frmIntro.Hide()
        Me.Hide()
        Call Music("village.mp3")
    End Sub

    Sub startGame()
        Using Game As New Game
            Game.Run()
        End Using
    End Sub

End Class