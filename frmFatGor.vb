#Region " imports"
Imports System
Imports System.Data
Imports System.Data.OleDb

#End Region

Public Class frmFatGor

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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmbMusteri As System.Windows.Forms.ComboBox
    Friend WithEvents DtpTarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents RbutOncFat As System.Windows.Forms.RadioButton
    Friend WithEvents RbutSonFAt As System.Windows.Forms.RadioButton
    Friend WithEvents TxtFatNo As System.Windows.Forms.TextBox
    Friend WithEvents NudFatTut As System.Windows.Forms.NumericUpDown
    Friend WithEvents RbutTutUst As System.Windows.Forms.RadioButton
    Friend WithEvents RbutTutAlt As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LblTarihinden As System.Windows.Forms.Label
    Friend WithEvents LblNoGir As System.Windows.Forms.Label
    Friend WithEvents LblTutGir As System.Windows.Forms.Label
    Friend WithEvents RbutMusteri As System.Windows.Forms.RadioButton
    Friend WithEvents RbutTarih As System.Windows.Forms.RadioButton
    Friend WithEvents RbutNumara As System.Windows.Forms.RadioButton
    Friend WithEvents RbutTutar As System.Windows.Forms.RadioButton
    Friend WithEvents grpTarBaz As System.Windows.Forms.GroupBox
    Friend WithEvents grpFatTut As System.Windows.Forms.GroupBox
    Friend WithEvents grpFatNo As System.Windows.Forms.GroupBox
    Friend WithEvents grpMustBaz As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.RbutMusteri = New System.Windows.Forms.RadioButton
        Me.RbutTarih = New System.Windows.Forms.RadioButton
        Me.RbutNumara = New System.Windows.Forms.RadioButton
        Me.RbutTutar = New System.Windows.Forms.RadioButton
        Me.CmbMusteri = New System.Windows.Forms.ComboBox
        Me.DtpTarih = New System.Windows.Forms.DateTimePicker
        Me.RbutOncFat = New System.Windows.Forms.RadioButton
        Me.RbutSonFAt = New System.Windows.Forms.RadioButton
        Me.LblTarihinden = New System.Windows.Forms.Label
        Me.grpTarBaz = New System.Windows.Forms.GroupBox
        Me.TxtFatNo = New System.Windows.Forms.TextBox
        Me.LblNoGir = New System.Windows.Forms.Label
        Me.NudFatTut = New System.Windows.Forms.NumericUpDown
        Me.LblTutGir = New System.Windows.Forms.Label
        Me.RbutTutUst = New System.Windows.Forms.RadioButton
        Me.RbutTutAlt = New System.Windows.Forms.RadioButton
        Me.grpFatTut = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.grpFatNo = New System.Windows.Forms.GroupBox
        Me.grpMustBaz = New System.Windows.Forms.GroupBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTarBaz.SuspendLayout()
        CType(Me.NudFatTut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFatTut.SuspendLayout()
        Me.grpFatNo.SuspendLayout()
        Me.grpMustBaz.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGrid1.CaptionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.CaptionText = "DENEME TABLOSU"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGrid1.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGrid1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.DarkRed
        Me.DataGrid1.Location = New System.Drawing.Point(0, 205)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(1016, 464)
        Me.DataGrid1.TabIndex = 0
        '
        'RbutMusteri
        '
        Me.RbutMusteri.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.RbutMusteri.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutMusteri.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RbutMusteri.Location = New System.Drawing.Point(512, 8)
        Me.RbutMusteri.Name = "RbutMusteri"
        Me.RbutMusteri.Size = New System.Drawing.Size(240, 24)
        Me.RbutMusteri.TabIndex = 1
        Me.RbutMusteri.Text = "Müsteri Bazýnda Görüntüle"
        '
        'RbutTarih
        '
        Me.RbutTarih.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.RbutTarih.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutTarih.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RbutTarih.Location = New System.Drawing.Point(760, 8)
        Me.RbutTarih.Name = "RbutTarih"
        Me.RbutTarih.Size = New System.Drawing.Size(248, 24)
        Me.RbutTarih.TabIndex = 2
        Me.RbutTarih.Text = "Tarih Bazýnda Görüntüle"
        '
        'RbutNumara
        '
        Me.RbutNumara.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.RbutNumara.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutNumara.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RbutNumara.Location = New System.Drawing.Point(8, 8)
        Me.RbutNumara.Name = "RbutNumara"
        Me.RbutNumara.Size = New System.Drawing.Size(248, 24)
        Me.RbutNumara.TabIndex = 3
        Me.RbutNumara.Text = "Fatura Numarasýna Göre Görüntüle"
        '
        'RbutTutar
        '
        Me.RbutTutar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.RbutTutar.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutTutar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RbutTutar.Location = New System.Drawing.Point(264, 8)
        Me.RbutTutar.Name = "RbutTutar"
        Me.RbutTutar.Size = New System.Drawing.Size(240, 24)
        Me.RbutTutar.TabIndex = 4
        Me.RbutTutar.Text = "Fatura Tutarýna Göre Görüntüle"
        '
        'CmbMusteri
        '
        Me.CmbMusteri.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CmbMusteri.Location = New System.Drawing.Point(8, 16)
        Me.CmbMusteri.Name = "CmbMusteri"
        Me.CmbMusteri.Size = New System.Drawing.Size(224, 23)
        Me.CmbMusteri.TabIndex = 5
        Me.CmbMusteri.Text = "Müsteri Seçiniz"
        '
        'DtpTarih
        '
        Me.DtpTarih.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpTarih.Location = New System.Drawing.Point(8, 16)
        Me.DtpTarih.Name = "DtpTarih"
        Me.DtpTarih.Size = New System.Drawing.Size(104, 23)
        Me.DtpTarih.TabIndex = 6
        '
        'RbutOncFat
        '
        Me.RbutOncFat.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutOncFat.Location = New System.Drawing.Point(8, 48)
        Me.RbutOncFat.Name = "RbutOncFat"
        Me.RbutOncFat.Size = New System.Drawing.Size(192, 24)
        Me.RbutOncFat.TabIndex = 7
        Me.RbutOncFat.Text = "Önceki Faturalar"
        '
        'RbutSonFAt
        '
        Me.RbutSonFAt.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutSonFAt.Location = New System.Drawing.Point(8, 72)
        Me.RbutSonFAt.Name = "RbutSonFAt"
        Me.RbutSonFAt.Size = New System.Drawing.Size(192, 24)
        Me.RbutSonFAt.TabIndex = 8
        Me.RbutSonFAt.Text = "Sonraki Faturalar"
        '
        'LblTarihinden
        '
        Me.LblTarihinden.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblTarihinden.Location = New System.Drawing.Point(120, 16)
        Me.LblTarihinden.Name = "LblTarihinden"
        Me.LblTarihinden.Size = New System.Drawing.Size(80, 23)
        Me.LblTarihinden.TabIndex = 9
        Me.LblTarihinden.Text = "Tarihinden"
        Me.LblTarihinden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpTarBaz
        '
        Me.grpTarBaz.Controls.Add(Me.DtpTarih)
        Me.grpTarBaz.Controls.Add(Me.RbutOncFat)
        Me.grpTarBaz.Controls.Add(Me.LblTarihinden)
        Me.grpTarBaz.Controls.Add(Me.RbutSonFAt)
        Me.grpTarBaz.Enabled = False
        Me.grpTarBaz.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpTarBaz.Location = New System.Drawing.Point(760, 32)
        Me.grpTarBaz.Name = "grpTarBaz"
        Me.grpTarBaz.Size = New System.Drawing.Size(248, 104)
        Me.grpTarBaz.TabIndex = 10
        Me.grpTarBaz.TabStop = False
        '
        'TxtFatNo
        '
        Me.TxtFatNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtFatNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFatNo.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtFatNo.Location = New System.Drawing.Point(112, 24)
        Me.TxtFatNo.Name = "TxtFatNo"
        Me.TxtFatNo.Size = New System.Drawing.Size(128, 23)
        Me.TxtFatNo.TabIndex = 11
        Me.TxtFatNo.Text = ""
        '
        'LblNoGir
        '
        Me.LblNoGir.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblNoGir.Location = New System.Drawing.Point(8, 24)
        Me.LblNoGir.Name = "LblNoGir"
        Me.LblNoGir.Size = New System.Drawing.Size(104, 23)
        Me.LblNoGir.TabIndex = 12
        Me.LblNoGir.Text = "Numara Girin :"
        Me.LblNoGir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NudFatTut
        '
        Me.NudFatTut.BackColor = System.Drawing.SystemColors.HighlightText
        Me.NudFatTut.DecimalPlaces = 2
        Me.NudFatTut.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.NudFatTut.Location = New System.Drawing.Point(112, 16)
        Me.NudFatTut.Name = "NudFatTut"
        Me.NudFatTut.TabIndex = 13
        '
        'LblTutGir
        '
        Me.LblTutGir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblTutGir.Location = New System.Drawing.Point(8, 16)
        Me.LblTutGir.Name = "LblTutGir"
        Me.LblTutGir.Size = New System.Drawing.Size(104, 23)
        Me.LblTutGir.TabIndex = 14
        Me.LblTutGir.Text = "Tutar Girin :"
        Me.LblTutGir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RbutTutUst
        '
        Me.RbutTutUst.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutTutUst.Location = New System.Drawing.Point(8, 48)
        Me.RbutTutUst.Name = "RbutTutUst"
        Me.RbutTutUst.Size = New System.Drawing.Size(224, 24)
        Me.RbutTutUst.TabIndex = 15
        Me.RbutTutUst.Text = "Girilen tutarýn üstündeki faturalar"
        '
        'RbutTutAlt
        '
        Me.RbutTutAlt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutTutAlt.Location = New System.Drawing.Point(8, 72)
        Me.RbutTutAlt.Name = "RbutTutAlt"
        Me.RbutTutAlt.Size = New System.Drawing.Size(224, 24)
        Me.RbutTutAlt.TabIndex = 16
        Me.RbutTutAlt.Text = "Girilen tutarýn altýndaki faturalar"
        '
        'grpFatTut
        '
        Me.grpFatTut.Controls.Add(Me.NudFatTut)
        Me.grpFatTut.Controls.Add(Me.LblTutGir)
        Me.grpFatTut.Controls.Add(Me.RbutTutUst)
        Me.grpFatTut.Controls.Add(Me.RbutTutAlt)
        Me.grpFatTut.Enabled = False
        Me.grpFatTut.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpFatTut.Location = New System.Drawing.Point(264, 32)
        Me.grpFatTut.Name = "grpFatTut"
        Me.grpFatTut.Size = New System.Drawing.Size(240, 104)
        Me.grpFatTut.TabIndex = 17
        Me.grpFatTut.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 8)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(8, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "GÖRÜNTÜLE"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.Location = New System.Drawing.Point(168, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 32)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "VAZGEÇ"
        '
        'grpFatNo
        '
        Me.grpFatNo.Controls.Add(Me.TxtFatNo)
        Me.grpFatNo.Controls.Add(Me.LblNoGir)
        Me.grpFatNo.Enabled = False
        Me.grpFatNo.Location = New System.Drawing.Point(8, 32)
        Me.grpFatNo.Name = "grpFatNo"
        Me.grpFatNo.Size = New System.Drawing.Size(248, 104)
        Me.grpFatNo.TabIndex = 21
        Me.grpFatNo.TabStop = False
        '
        'grpMustBaz
        '
        Me.grpMustBaz.Controls.Add(Me.CmbMusteri)
        Me.grpMustBaz.Enabled = False
        Me.grpMustBaz.Location = New System.Drawing.Point(512, 32)
        Me.grpMustBaz.Name = "grpMustBaz"
        Me.grpMustBaz.Size = New System.Drawing.Size(240, 104)
        Me.grpMustBaz.TabIndex = 22
        Me.grpMustBaz.TabStop = False
        '
        'frmFatGor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 669)
        Me.Controls.Add(Me.grpMustBaz)
        Me.Controls.Add(Me.grpFatNo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpFatTut)
        Me.Controls.Add(Me.grpTarBaz)
        Me.Controls.Add(Me.RbutNumara)
        Me.Controls.Add(Me.RbutTarih)
        Me.Controls.Add(Me.RbutMusteri)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.RbutTutar)
        Me.Name = "frmFatGor"
        Me.Text = "Fatura Görüntüleme ;"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTarBaz.ResumeLayout(False)
        CType(Me.NudFatTut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFatTut.ResumeLayout(False)
        Me.grpFatNo.ResumeLayout(False)
        Me.grpMustBaz.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    'Bu kýsmý dikkate alma Northwind ý klasörün içine attým ve Customers tablosuna baðlantý oluþturdum..
    'Sadece datagrid de görünüm almak için ve renk ayarlarýný ayarlamak için yaptým.Biz kendi database imize
    'baðlanacaðýz..
    Private Sub FaturaGoruntuleme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MusteriDoldur.musteridoldur()

        'Baðlantýyý adým adým basit þekilde oluþturdum.
        Dim myConn As OleDbConnection
        myConn = New OleDbConnection
        myConn.ConnectionString = _
        "Provider=Microsoft.Jet.oledb.4.0;Data Source=" & Application.StartupPath & "\Northwind.mdb"

        'Sorguyu basit basit adým adým oluþtrudum..
        Dim myCmd As OleDbCommand
        myCmd = New OleDbCommand
        myCmd.Connection = myConn
        myCmd.CommandType = CommandType.Text
        myCmd.CommandText = "Select * From Customers"

        'DataAdapter oluþturdum..
        Dim myDA As New OleDbDataAdapter(myCmd)

        'Dataset oluþturdum.
        Dim myDS As New DataSet("Deneme")

        'DataAdapter ile dataset e tabloyu aktardým..
        myDA.Fill(myDS, "Customers")

        'DataGrid e Dataset i aktardým..
        DataGrid1.DataSource = myDS.Tables(0)

    End Sub

    'Özel sub herhangi bir radio button u týklanýnca aktifleþme iþlemleri yapýyor..
    Private Sub Radio_Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles RbutNumara.CheckedChanged, RbutTutar.CheckedChanged, RbutMusteri.CheckedChanged, RbutTarih.CheckedChanged
        'GroupBox ý olmayan kýsýmlara GroupBox ekledim,tek tek nesneleri kapamak ile uðraþmayalaým diye..
        'GroupBox ý kapatýp açarak nesneleri rahatca kapatýp açarýz..

        'Fatura numarasýna göre görüntüleme seçilirse..
        If RbutNumara.Checked = True Then
            Me.grpFatNo.Enabled = True
        Else
            Me.grpFatNo.Enabled = False
        End If

        'Fatura tutarýna göre görüntüleme seçilirse..
        If RbutTutar.Checked = True Then
            Me.grpFatTut.Enabled = True
        Else
            Me.grpFatTut.Enabled = False
        End If

        'Müþteri bazýnda görüntüleme seçilirse..
        If RbutMusteri.Checked = True Then
            Me.grpMustBaz.Enabled = True
        Else
            Me.grpMustBaz.Enabled = False
        End If

        'Tarih bazýnda görüntüleme seçilirse..
        If RbutTarih.Checked = True Then
            Me.grpTarBaz.Enabled = True
        Else
            Me.grpTarBaz.Enabled = False
        End If
    End Sub
End Class
