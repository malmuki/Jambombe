Imports Microsoft.Xna.Framework

Public Class Location
    Private speedX As Single = 300
    Private speedY As Single = 300
    'Avec une variable speed, on peut maintenant faire des spells de vitesse facilement.
    Private speed As New Vector2(speedX, speedY)
    Private pos As Point = Point.Zero
    Private size As Point = Point.Zero
    Private isLimited As Boolean = False
    Private max As Point = Point.Zero
    Private min As Point = Point.Zero

    Public Sub modifyPosX(ByVal time As Double, ByVal limit As Integer)
        Dim moveTo = speed.X * CSng(time)
        If limit = 0 Then
        ElseIf limit < 0 Then
            setPosX(pos.X + CInt(Math.Max(moveTo, limit)))
        Else
            setPosX(pos.X + CInt(Math.Min(moveTo, limit)))
        End If
    End Sub
    Public Sub modifyPosY(ByVal time As Double, ByVal limit As Integer)
        Dim moveTo = speed.Y * CSng(time)
        If limit = 0 Then
        ElseIf limit < 0 Then
            setPosY(pos.Y + CInt(Math.Max(moveTo, limit)))
        Else
            setPosY(pos.Y + CInt(Math.Min(moveTo, limit)))
        End If
    End Sub
    Public Sub setPosX(ByVal x As Integer)
        If isLimited Then
            If min.X <= x AndAlso x <= max.X Then
                pos.X = x
            ElseIf x > max.X Then
                pos.X = max.X
            Else
                pos.X = min.X
            End If
        Else
            pos.X = x
        End If
    End Sub
    Public Sub setPosY(ByVal y As Integer)
        If isLimited Then
            If min.Y <= y AndAlso y <= max.Y Then
                pos.Y = y
            ElseIf y > max.Y Then
                pos.Y = max.Y
            Else
                pos.Y = min.Y
            End If
        Else
            pos.Y = y
        End If
        'We are only tracking on the X axis.
    End Sub
    Public Sub setSpeed(s As Vector2)
        speed = s
    End Sub
    Public Sub setWidth(w As Integer)
        size.X = w
    End Sub
    Public Sub setHeight(h As Integer)
        size.Y = h
    End Sub

    Public Sub setMin(x As Integer, y As Integer)
        min = New Point(x, y)
        If min.X > max.X Then
            max.X = min.X
        End If
        If min.Y > max.Y Then
            max.Y = min.Y
        End If
        isLimited = True
        If pos.X < min.X Then
            setPosX(min.X)
        End If
        If pos.Y < min.Y Then
            setPosY(min.Y)
        End If
    End Sub
    Public Sub setMax(x As Integer, y As Integer)
        max = New Point(x, y)
        If max.X < min.X Then
            min.X = max.X
        End If
        If max.Y < min.Y Then
            min.Y = max.Y
        End If
        isLimited = True
        If pos.X > max.X Then
            setPosX(max.X)
        End If
        If pos.Y > max.Y Then
            setPosY(max.Y)
        End If
    End Sub

    Public Function getX() As Integer
        Return pos.X
    End Function
    Public Function getY() As Integer
        Return pos.Y
    End Function
    Public Function getSpeed() As Vector2
        Return speed
    End Function
    Public Function getSize() As Point
        Return size
    End Function
    Public Function getTopLeft() As Point
        Return New Point(getX, getY)
    End Function

    Public Function getTopRight() As Point
        Return New Point(getX() + getSize.X, getY)
    End Function

    Public Function getBottomLeft() As Point
        Return New Point(getX, getY() + getSize.Y)
    End Function

    Public Function getBottomRight() As Point
        Return New Point(getX() + getSize.X, getY() + getSize.Y)
    End Function

    Public Function getCenter() As Point
        Return New Point(getX() + getSize.X \ 2, getY() + getSize.Y \ 2)
    End Function

    Public Function getMin() As Point
        Return min
    End Function
    Public Function getMax() As Point
        Return max
    End Function

    'Beaucoup plus beau et plus facile d'utilser debug...
    Private Sub debug(s As String)
        System.Diagnostics.Debugger.Log(0, "", s & vbNewLine)
    End Sub
End Class