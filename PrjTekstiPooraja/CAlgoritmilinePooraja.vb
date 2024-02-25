Public Class CAlgoritmilinePooraja
    Implements ITeisendused
    'Klassi atribuudid'
    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String

    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSymbol
        End Get
        Set(value As Integer)
            intAlgusSymbol = value 'väärtuse seadistamine'
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol
        End Get
        Set(value As Integer)
            intLoppSymbol = value
        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTekst = value
        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) _
        Implements ITeisendused.teisendaTekst
        Dim reversedInput As New System.Text.StringBuilder()
        'tagant ette
        For i As Integer = strSisendTekst.Length - 1 To 0 Step -1
            reversedInput.Append(strSisendTekst(i))
        Next
        strPooratavTekst = reversedInput.ToString()
    End Sub


    Private Function pooraTekst() As String _
        Implements ITeisendused.pooraTekst
        Dim reversedInput As New System.Text.StringBuilder()

        'tagant ette
        For i = strPooratavTekst.Length - 1 To 0 Step -1
            reversedInput.Append(strPooratavTekst(i))
        Next

        Return reversedInput.ToString()
    End Function

End Class
