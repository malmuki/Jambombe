Module modMusic
    Public calledMusic As Boolean = False

    Public Sub Music(ByVal musicFile As String)
        'Joue la musique
        calledMusic = True
        If musicFile = "pause" Then
            frmIntro.AxWMPMusic.Ctlcontrols.pause()
        ElseIf musicFile = "unpause" Then
            frmIntro.AxWMPMusic.Ctlcontrols.play()
        Else
            frmIntro.AxWMPMusic.Ctlcontrols.stop()
            frmIntro.AxWMPMusic.URL = musicFile
            frmIntro.AxWMPMusic.Ctlcontrols.play()
            calledMusic = False
        End If
    End Sub

    Public Sub SoundSelectionEffect(ByVal soundFile As String)
        'Effet sonore #2
        frmCombat.AxWMPSoundSelectionEffect.URL = soundFile
    End Sub

    Public Sub PlaySoundEffect(ByVal soundFile As String)
        'Effet sonore #1
        frmCombat.AxWMPSoundEffect.URL = soundFile
    End Sub
End Module
