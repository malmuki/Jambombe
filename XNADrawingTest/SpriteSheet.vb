Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class SpriteSheet

    Private spriteList As Texture2D
    Private currentFrame As Integer()
    Private currentRow As Integer
    Private frameAmount As Integer(,)
    Private size As Point = Point.Zero
    Private time As Double = 0.2
    Private currentTime As Double = 0

    Public Sub setSheet(t As Texture2D, c As Point, s As Point)
        spriteList = t
        ReDim frameAmount(c.X, c.Y)
        ReDim currentFrame(c.Y)
        currentRow = 0
        size = s
    End Sub

    Public Function getTexture() As Texture2D
        Return spriteList
    End Function
    Public Function getCurrentArea() As Rectangle
        Return New Rectangle(currentFrame(currentRow) * size.X, currentRow * size.Y, size.X, size.Y)
    End Function
    Public Sub nextFrame(timeDown As Double)
        currentTime -= Math.Abs(timeDown)
        If currentTime <= 0 Then
            currentTime = time
            currentFrame(currentRow) = (currentFrame(currentRow) + 1) Mod currentFrame.Length
        End If
    End Sub
    Public Sub setRow(r As Integer)
        currentRow = r
    End Sub
    'Beaucoup plus beau et plus facile d'utilser debug...
    Private Sub debug(s As String)
        System.Diagnostics.Debugger.Log(0, "", s & vbNewLine)
    End Sub
End Class