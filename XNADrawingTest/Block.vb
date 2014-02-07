Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports System.IO

Public Class Block

    Private x As Integer
    Private y As Integer

    Private pos As Point
    'constructeur
    Sub New(ByVal t As Rectangle, ByVal p As Boolean, ByVal x1 As Integer, ByVal y1 As Integer, ByVal cas As Boolean, ByVal type As Integer)
        Me.PTextureIndex = t
        Me.PPassable = p
        Me.setPos(x1, y1)
        Me.PCassable = cas
        Me.blockTypeP = type
    End Sub
    'texture stuff
    Private textureIndex As Rectangle
    Public Property PTextureIndex() As Rectangle
        Get
            Return textureIndex
        End Get
        Set(ByVal value As Rectangle)
            textureIndex = value
        End Set
    End Property
    'passable
    Private passable As Boolean
    Public Property PPassable() As Boolean
        Get
            Return passable
        End Get
        Set(ByVal value As Boolean)
            passable = value
        End Set
    End Property
    'cassable
    Private cassable As Boolean
    Public Property PCassable() As Boolean
        Get
            Return cassable
        End Get
        Set(ByVal value As Boolean)
            cassable = value
        End Set
    End Property

    Private blockType As Integer
    Public Property blockTypeP() As Integer
        Get
            Return blockType
        End Get
        Set(ByVal value As Integer)
            blockType = value
        End Set
    End Property


    'les Pos
    Public Sub setPos(ByVal x1 As Integer, ByVal y1 As Integer)
        pos = New Point(x1, y1)
    End Sub

    Public Function getPos() As Point
        Return pos
    End Function
End Class