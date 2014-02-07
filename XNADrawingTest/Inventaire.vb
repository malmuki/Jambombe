Public Class Inventaire

    Private inventaire(8) As Integer 'index: 0 = terre, 1 = rock, 2 = wood, 3 = plank, 4 = ironblock, 5 = coal, 6 = ironore, 7 = copperore
    Private oven As Integer
    Private workbench As Integer = 1
    Private outil As Integer ' 0 = etablit, 1 = un four
    Private selectedItem As Integer

    Public Sub New()
        For i = 0 To inventaire.Length - 1
            inventaire(i) = 0
        Next
        outil = 1
        selectedItem = 0
    End Sub

    Public Sub New(ByVal items() As Integer, ByVal tool As Integer)
        For i = 0 To inventaire.Length
            inventaire(i) = items(i)
        Next
        outil = tool
    End Sub

    Public Function getTool() As Microsoft.Xna.Framework.Rectangle
        Select Case outil
            Case 0
                Return New Microsoft.Xna.Framework.Rectangle(0 * BLOCK_SIZE, 2 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
            Case 1
                Return New Microsoft.Xna.Framework.Rectangle(6 * BLOCK_SIZE, 1 * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE)
        End Select
    End Function

    Public Sub setIndex(ByVal i As Integer)
        selectedItem = i
    End Sub
    Public Function getIndex() As Integer
        If Not toolIsSelectedP Then
            Return selectedItem
        Else
            If outil = 0 Then
                Return 10
            Else
                Return 9
            End If
        End If

    End Function

    Public Function getNbItemX(ByVal i As Integer) As Integer
        If i < 9 Then
            Return inventaire(i)
        ElseIf outil = 0 Then
            Return workbench
        Else
            Return oven
        End If


    End Function
    Public Sub setNbItemX(ByVal i As Integer, ByVal c As Integer) 'index, changement /pour l'inventaire only
        If i < 9 Then
            inventaire(i) += c
        ElseIf outil = 0 Then
            workbench += c
        Else
            oven += c
        End If
    End Sub
    Public Sub setNbItemX(ByVal c As Integer, ByVal b As Boolean) 'pour outil, true = oven/false = workbench
        If b Then
            oven += c
        Else
            workbench += c
        End If
    End Sub
    Public Function getTableauInventaire() As Integer()
        Return inventaire
    End Function
    Public Sub toggleOutil()
        If outil = 0 Then
            outil = 1
        ElseIf outil = 1 Then
            outil = 0
        End If
    End Sub

    Public Sub interation()


    End Sub
    Public Property outilP() As Integer
        Get
            Return outil
        End Get
        Set(ByVal value As Integer)
            outil = value
        End Set
    End Property
    Public Property ovenP() As Integer
        Get
            Return oven
        End Get
        Set(ByVal value As Integer)
            oven = value
        End Set
    End Property
    Public Property workbenchP() As Integer
        Get
            Return workbench
        End Get
        Set(ByVal value As Integer)
            workbench = value
        End Set
    End Property
    Public ReadOnly Property nbOutilP() As Integer
        Get
            If outil = 0 Then
                Return workbench
            ElseIf outil = 1 Then
                Return oven
            End If
        End Get

    End Property
    Private toolIsSelected As Boolean = False
    Public Property toolIsSelectedP() As Boolean
        Get
            Return toolIsSelected
        End Get
        Set(ByVal value As Boolean)
            toolIsSelected = value
        End Set
    End Property

End Class