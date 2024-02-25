Public Interface ITeisendused
    Property intAlgus As Integer 'txti esimene sümboli ASCII koodi jaoks'
    Property intLopp As Integer 'viimase sümboli jaoks'
    Property strTekst As String 'Input, sisestatud txt'

    Function pooraTekst() As String
    Sub teisendaTekst(ByRef strSisendTekst As String)

End Interface
