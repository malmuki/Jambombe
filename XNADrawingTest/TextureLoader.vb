Imports Microsoft.Xna.Framework.Graphics

Module TextureLoader

    Private textureList As New List(Of Texture2D)

    Public Sub addTexture(ByVal text As Texture2D)
        textureList.Add(text)
    End Sub

End Module