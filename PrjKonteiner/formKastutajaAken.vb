Public Class formKastutajaAken
    'Kõigi peale sisendi textboxi on disabled'
    Private Sub Allboxes(ByVal box As Control)
        txtSisendTekst.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        txtValjundTekst1.Enabled = False
        txtValjundTekst2.Enabled = False
        Tlen.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Allboxes(Me)
    End Sub


    Private Sub btnPoora1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnPoora1.Click
        'Objekti loomine'
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Viitame uuele objektile'
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'omistame väärtuse'
        pooraja.strTekst = txtSisendTekst.Text
        'väärtustame tekstivälja'
        txtValjundTekst1.Text = pooraja.pooraTekst()

    End Sub

    Private Sub btnPoora2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnPoora2.Click
        'Objekti loomine'
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Viitame uuele objektile'
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'omistame väärtuse'
        pooraja.teisendaTekst(txtSisendTekst.Text)
        'väärtustame tekstivälja'
        txtValjundTekst2.Text = pooraja.strTekst
    End Sub

    Private Sub timerUuenda_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles timerUuenda.Tick
        'Objekti loomine'
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Viitame uuele objektile'
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'omistame väärtuse'
        pooraja.strTekst = txtSisendTekst.Text
        'väärtustame tekstivälja'
        txtValjundTekst1.Text = pooraja.pooraTekst()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnStart.Click
        'Timer start'
        timerUuenda.Enabled = True
        'Keelab korduvat vajutamist?'
        btnStart.Enabled = False
        btnStopp.Enabled = True

    End Sub

    Private Sub btnStopp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnStopp.Click
        'Timer stopp'
        timerUuenda.Enabled = False
        'Keelab korduvat vajutamist?'
        btnStart.Enabled = True
        btnStopp.Enabled = False

    End Sub

    Private Function Counter(ByVal value As String) As Integer
        'Initialize the counter for specific letters
        Dim letterCount As Integer = 0

        'täishäälikud
        Dim vowels As String = "oOaAeEiIuUõÕüÜöÖäÄ"

        'Loop
        For Each c As Char In value
            If vowels.Contains(c) Then
                'Increment the counter
                letterCount += 1
            End If
        Next

        Return letterCount
    End Function

    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged
        'Get the input
        Dim value As String = txtSisendTekst.Text

        'Calculate the count of specific letters using the function
        Dim letter As Integer = Counter(value)

        'Output (TLen)
        Tlen.Text = letter.ToString()
    End Sub

    'Btn1 ja Btn2 on nuppud.'
    'TextBox1 ja TextBox2 on outputkastid'

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Btn1.Click
        'Objekti loomine'
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Viitame uuele objektile'
        pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja

        'omistame väärtuse'
        pooraja.strTekst = txtSisendTekst.Text
        'väärtustame tekstivälja'
        TextBox1.Text = pooraja.pooraTekst()

    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Btn2.Click

        'Objekti loomine'
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Viitame uuele objektile'
        pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja
        'omistame väärtuse'
        pooraja.teisendaTekst(txtSisendTekst.Text)
        'väärtustame tekstivälja'
        TextBox2.Text = pooraja.strTekst
    End Sub

End Class
