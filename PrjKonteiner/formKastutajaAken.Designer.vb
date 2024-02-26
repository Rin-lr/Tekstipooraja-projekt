<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKastutajaAken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Tlen = New System.Windows.Forms.TextBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnStopp = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPoora2 = New System.Windows.Forms.Button()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sisendtekst = New System.Windows.Forms.Label()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.timerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.koikM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Tlen
        '
        Me.Tlen.Location = New System.Drawing.Point(787, 71)
        Me.Tlen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tlen.Name = "Tlen"
        Me.Tlen.Size = New System.Drawing.Size(39, 26)
        Me.Tlen.TabIndex = 43
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn2.Location = New System.Drawing.Point(479, 336)
        Me.Btn2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(184, 31)
        Me.Btn2.TabIndex = 42
        Me.Btn2.Text = "Pööra protseduuriga"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn1.Location = New System.Drawing.Point(479, 216)
        Me.Btn1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(184, 31)
        Me.Btn1.TabIndex = 41
        Me.Btn1.Text = "Pööra funktsiooniga"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Algoritmiline pööramine protseduuriga:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(476, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Algoritmiline pööramine funktsiooniga:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(479, 304)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(373, 26)
        Me.TextBox2.TabIndex = 38
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TextBox1.Location = New System.Drawing.Point(479, 185)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 26)
        Me.TextBox1.TabIndex = 37
        '
        'btnStopp
        '
        Me.btnStopp.Location = New System.Drawing.Point(479, 476)
        Me.btnStopp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(146, 38)
        Me.btnStopp.TabIndex = 36
        Me.btnStopp.Text = "Stop"
        Me.btnStopp.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(298, 476)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(146, 38)
        Me.btnStart.TabIndex = 35
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPoora2
        '
        Me.btnPoora2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPoora2.Location = New System.Drawing.Point(45, 336)
        Me.btnPoora2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPoora2.Name = "btnPoora2"
        Me.btnPoora2.Size = New System.Drawing.Size(184, 31)
        Me.btnPoora2.TabIndex = 34
        Me.btnPoora2.Text = "Pööra protseduuriga"
        Me.btnPoora2.UseVisualStyleBackColor = False
        '
        'btnPoora1
        '
        Me.btnPoora1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPoora1.Location = New System.Drawing.Point(45, 216)
        Me.btnPoora1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.Size = New System.Drawing.Size(184, 31)
        Me.btnPoora1.TabIndex = 33
        Me.btnPoora1.Text = "Pööra funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Pööramine protseduuriga:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Pööramine funktsiooniga:"
        '
        'Sisendtekst
        '
        Me.Sisendtekst.AutoSize = True
        Me.Sisendtekst.Location = New System.Drawing.Point(42, 49)
        Me.Sisendtekst.Name = "Sisendtekst"
        Me.Sisendtekst.Size = New System.Drawing.Size(97, 20)
        Me.Sisendtekst.TabIndex = 30
        Me.Sisendtekst.Text = "Sisendtekst:"
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(45, 304)
        Me.txtValjundTekst2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(373, 26)
        Me.txtValjundTekst2.TabIndex = 29
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(45, 185)
        Me.txtValjundTekst1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(373, 26)
        Me.txtValjundTekst1.TabIndex = 28
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(45, 71)
        Me.txtSisendTekst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(722, 26)
        Me.txtSisendTekst.TabIndex = 27
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 5000
        '
        'koikM
        '
        Me.koikM.Location = New System.Drawing.Point(849, 71)
        Me.koikM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.koikM.Name = "koikM"
        Me.koikM.Size = New System.Drawing.Size(39, 26)
        Me.koikM.TabIndex = 44
        '
        'formKastutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.koikM)
        Me.Controls.Add(Me.Tlen)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnStopp)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnPoora2)
        Me.Controls.Add(Me.btnPoora1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Sisendtekst)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formKastutajaAken"
        Me.Text = "formKastutajaAken"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tlen As TextBox
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnStopp As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnPoora2 As Button
    Friend WithEvents btnPoora1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Sisendtekst As Label
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents timerUuenda As Timer
    Friend WithEvents koikM As TextBox
End Class
