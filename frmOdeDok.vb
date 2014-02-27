Public Class frmOdeDok
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbutMusteri As System.Windows.Forms.RadioButton
    Friend WithEvents CmbMusteriler As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RbutNumara As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnGoruntule As System.Windows.Forms.Button
    Friend WithEvents BtnVazgec As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DtpTarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNumara As System.Windows.Forms.TextBox
    Friend WithEvents RbutTarih As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbMusteriler = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DtpTarih = New System.Windows.Forms.DateTimePicker
        Me.RbutMusteri = New System.Windows.Forms.RadioButton
        Me.RbutNumara = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtNumara = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.BtnGoruntule = New System.Windows.Forms.Button
        Me.BtnVazgec = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.RbutTarih = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbMusteriler)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CmbMusteriler
        '
        Me.CmbMusteriler.Location = New System.Drawing.Point(8, 16)
        Me.CmbMusteriler.Name = "CmbMusteriler"
        Me.CmbMusteriler.Size = New System.Drawing.Size(200, 21)
        Me.CmbMusteriler.TabIndex = 0
        Me.CmbMusteriler.Text = "Müsteri Seçiniz..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.DtpTarih)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(232, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 88)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(192, 32)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Ödeme Sýralamasý için Baþlangýç Tarihi Seçiniz..."
        '
        'DtpTarih
        '
        Me.DtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpTarih.Location = New System.Drawing.Point(16, 56)
        Me.DtpTarih.Name = "DtpTarih"
        Me.DtpTarih.Size = New System.Drawing.Size(192, 20)
        Me.DtpTarih.TabIndex = 0
        '
        'RbutMusteri
        '
        Me.RbutMusteri.Location = New System.Drawing.Point(24, 24)
        Me.RbutMusteri.Name = "RbutMusteri"
        Me.RbutMusteri.Size = New System.Drawing.Size(200, 16)
        Me.RbutMusteri.TabIndex = 3
        Me.RbutMusteri.Text = "Müsteri Bazýnda Ödemeleri Göster"
        '
        'RbutNumara
        '
        Me.RbutNumara.Location = New System.Drawing.Point(456, 24)
        Me.RbutNumara.Name = "RbutNumara"
        Me.RbutNumara.Size = New System.Drawing.Size(200, 16)
        Me.RbutNumara.TabIndex = 5
        Me.RbutNumara.Text = "Numara Bazýnda Ödemeleri Göster"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtNumara)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(448, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 88)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'TxtNumara
        '
        Me.TxtNumara.Location = New System.Drawing.Point(8, 56)
        Me.TxtNumara.Name = "TxtNumara"
        Me.TxtNumara.Size = New System.Drawing.Size(192, 20)
        Me.TxtNumara.TabIndex = 3
        Me.TxtNumara.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(8, 16)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(192, 32)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Ödeme No Giriniz..."
        '
        'BtnGoruntule
        '
        Me.BtnGoruntule.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnGoruntule.Enabled = False
        Me.BtnGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGoruntule.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGoruntule.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnGoruntule.Location = New System.Drawing.Point(440, 144)
        Me.BtnGoruntule.Name = "BtnGoruntule"
        Me.BtnGoruntule.Size = New System.Drawing.Size(104, 23)
        Me.BtnGoruntule.TabIndex = 6
        Me.BtnGoruntule.Text = "GÖRÜNTÜLE"
        '
        'BtnVazgec
        '
        Me.BtnVazgec.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVazgec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnVazgec.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnVazgec.Location = New System.Drawing.Point(560, 144)
        Me.BtnVazgec.Name = "BtnVazgec"
        Me.BtnVazgec.Size = New System.Drawing.Size(104, 23)
        Me.BtnVazgec.TabIndex = 7
        Me.BtnVazgec.Text = "VAZGEÇ"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 182)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(680, 392)
        Me.DataGrid1.TabIndex = 8
        '
        'RbutTarih
        '
        Me.RbutTarih.Location = New System.Drawing.Point(240, 24)
        Me.RbutTarih.Name = "RbutTarih"
        Me.RbutTarih.Size = New System.Drawing.Size(184, 16)
        Me.RbutTarih.TabIndex = 4
        Me.RbutTarih.Text = "Tarih Bazýnda Ödemeleri Göster"
        '
        'frmOdeDok
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 574)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.BtnVazgec)
        Me.Controls.Add(Me.BtnGoruntule)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RbutTarih)
        Me.Controls.Add(Me.RbutMusteri)
        Me.Controls.Add(Me.RbutNumara)
        Me.Name = "frmOdeDok"
        Me.Text = "Ödeme Dökümü"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbutMusteri.CheckedChanged, RbutNumara.CheckedChanged, RbutTarih.CheckedChanged

        If RbutMusteri.Checked = True Then
            BtnGoruntule.Enabled = True
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If

        If RbutTarih.Checked = True Then
            GroupBox2.Enabled = True
            BtnGoruntule.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If

        If RbutNumara.Checked = True Then
            GroupBox3.Enabled = True
            BtnGoruntule.Enabled = True
        Else
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub frmOdeDok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MusteriDoldur.musteridoldur()



    End Sub
End Class
