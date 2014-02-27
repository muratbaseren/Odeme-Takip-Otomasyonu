#Region "imports"
Imports System
Imports System.Data
Imports System.Data.OleDb
#End Region

Public Class frmMusTanimla
    Inherits System.Windows.Forms.Form

    '////////////////////////////////
    'Diðer TASARIMLARI SANA BIRAKIYORUM!!! :))
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtMusNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSirAdi As System.Windows.Forms.TextBox
    Friend WithEvents TxtIlgKisiAd As System.Windows.Forms.TextBox
    Friend WithEvents TxtIlgKisiSoyadi As System.Windows.Forms.TextBox
    Friend WithEvents TxtMusTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtMusBolge As System.Windows.Forms.TextBox
    Friend WithEvents TxtMusSehir As System.Windows.Forms.TextBox
    Friend WithEvents BtnEkle As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GbIslemSec As System.Windows.Forms.GroupBox
    Friend WithEvents RbutGuncelle As System.Windows.Forms.RadioButton
    Friend WithEvents RbutTanimla As System.Windows.Forms.RadioButton
    Friend WithEvents CmbMusSec As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMusTanimla))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtMusNo = New System.Windows.Forms.TextBox
        Me.TxtSirAdi = New System.Windows.Forms.TextBox
        Me.TxtIlgKisiAd = New System.Windows.Forms.TextBox
        Me.TxtIlgKisiSoyadi = New System.Windows.Forms.TextBox
        Me.TxtMusTel = New System.Windows.Forms.TextBox
        Me.TxtMusBolge = New System.Windows.Forms.TextBox
        Me.TxtMusSehir = New System.Windows.Forms.TextBox
        Me.BtnEkle = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GbIslemSec = New System.Windows.Forms.GroupBox
        Me.RbutTanimla = New System.Windows.Forms.RadioButton
        Me.RbutGuncelle = New System.Windows.Forms.RadioButton
        Me.CmbMusSec = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GbIslemSec.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(16, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Müsteri Numarasý"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(16, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Þirket Adý"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(16, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ýlgili Kiþi Adý"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(16, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ýlgili Kiþi Soyadý"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(16, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefon Numarasý"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(16, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bölge / Semt"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(16, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Þehir"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtMusNo
        '
        Me.TxtMusNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMusNo.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMusNo.Location = New System.Drawing.Point(189, 192)
        Me.TxtMusNo.Name = "TxtMusNo"
        Me.TxtMusNo.Size = New System.Drawing.Size(189, 24)
        Me.TxtMusNo.TabIndex = 8
        Me.TxtMusNo.Text = ""
        '
        'TxtSirAdi
        '
        Me.TxtSirAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSirAdi.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSirAdi.Location = New System.Drawing.Point(189, 232)
        Me.TxtSirAdi.Name = "TxtSirAdi"
        Me.TxtSirAdi.Size = New System.Drawing.Size(189, 24)
        Me.TxtSirAdi.TabIndex = 9
        Me.TxtSirAdi.Text = ""
        '
        'TxtIlgKisiAd
        '
        Me.TxtIlgKisiAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIlgKisiAd.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIlgKisiAd.Location = New System.Drawing.Point(189, 272)
        Me.TxtIlgKisiAd.Name = "TxtIlgKisiAd"
        Me.TxtIlgKisiAd.Size = New System.Drawing.Size(189, 24)
        Me.TxtIlgKisiAd.TabIndex = 10
        Me.TxtIlgKisiAd.Text = ""
        '
        'TxtIlgKisiSoyadi
        '
        Me.TxtIlgKisiSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIlgKisiSoyadi.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIlgKisiSoyadi.Location = New System.Drawing.Point(189, 312)
        Me.TxtIlgKisiSoyadi.Name = "TxtIlgKisiSoyadi"
        Me.TxtIlgKisiSoyadi.Size = New System.Drawing.Size(189, 24)
        Me.TxtIlgKisiSoyadi.TabIndex = 11
        Me.TxtIlgKisiSoyadi.Text = ""
        '
        'TxtMusTel
        '
        Me.TxtMusTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMusTel.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMusTel.Location = New System.Drawing.Point(189, 352)
        Me.TxtMusTel.Name = "TxtMusTel"
        Me.TxtMusTel.Size = New System.Drawing.Size(189, 24)
        Me.TxtMusTel.TabIndex = 12
        Me.TxtMusTel.Text = ""
        '
        'TxtMusBolge
        '
        Me.TxtMusBolge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMusBolge.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMusBolge.Location = New System.Drawing.Point(189, 392)
        Me.TxtMusBolge.Name = "TxtMusBolge"
        Me.TxtMusBolge.Size = New System.Drawing.Size(189, 24)
        Me.TxtMusBolge.TabIndex = 13
        Me.TxtMusBolge.Text = ""
        '
        'TxtMusSehir
        '
        Me.TxtMusSehir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMusSehir.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMusSehir.Location = New System.Drawing.Point(189, 432)
        Me.TxtMusSehir.Name = "TxtMusSehir"
        Me.TxtMusSehir.Size = New System.Drawing.Size(189, 24)
        Me.TxtMusSehir.TabIndex = 14
        Me.TxtMusSehir.Text = ""
        '
        'BtnEkle
        '
        Me.BtnEkle.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEkle.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnEkle.Location = New System.Drawing.Point(8, 16)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(208, 32)
        Me.BtnEkle.TabIndex = 22
        Me.BtnEkle.Text = "Müsteriyi Veritabanýna Ekle"
        Me.BtnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckBox1.Location = New System.Drawing.Point(14, 472)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(371, 24)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Bilgiler Doðru Girilmiþtir."
        '
        'GbIslemSec
        '
        Me.GbIslemSec.Controls.Add(Me.RbutTanimla)
        Me.GbIslemSec.Controls.Add(Me.RbutGuncelle)
        Me.GbIslemSec.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbIslemSec.ForeColor = System.Drawing.Color.DarkRed
        Me.GbIslemSec.Location = New System.Drawing.Point(16, 8)
        Me.GbIslemSec.Name = "GbIslemSec"
        Me.GbIslemSec.Size = New System.Drawing.Size(376, 100)
        Me.GbIslemSec.TabIndex = 24
        Me.GbIslemSec.TabStop = False
        Me.GbIslemSec.Text = "Lütfen Ýþlem Seçiniz"
        '
        'RbutTanimla
        '
        Me.RbutTanimla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbutTanimla.Location = New System.Drawing.Point(8, 64)
        Me.RbutTanimla.Name = "RbutTanimla"
        Me.RbutTanimla.Size = New System.Drawing.Size(320, 24)
        Me.RbutTanimla.TabIndex = 1
        Me.RbutTanimla.Text = "Yeni Müsteri Tanýmlama"
        '
        'RbutGuncelle
        '
        Me.RbutGuncelle.Checked = True
        Me.RbutGuncelle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbutGuncelle.Location = New System.Drawing.Point(8, 32)
        Me.RbutGuncelle.Name = "RbutGuncelle"
        Me.RbutGuncelle.Size = New System.Drawing.Size(320, 24)
        Me.RbutGuncelle.TabIndex = 0
        Me.RbutGuncelle.TabStop = True
        Me.RbutGuncelle.Text = "Müsteri Bilgisi Güncelleme"
        '
        'CmbMusSec
        '
        Me.CmbMusSec.Location = New System.Drawing.Point(7, 16)
        Me.CmbMusSec.Name = "CmbMusSec"
        Me.CmbMusSec.Size = New System.Drawing.Size(364, 24)
        Me.CmbMusSec.TabIndex = 25
        Me.CmbMusSec.Text = "Müsteri Seçiniz..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnEkle)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(14, 504)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 64)
        Me.Panel1.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmbMusSec)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(14, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 56)
        Me.Panel2.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(245, 504)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(140, 64)
        Me.Panel3.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "VAZGEÇ"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(175, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 25)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = ":"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(175, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = ":"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(175, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 25)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(175, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 25)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(175, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 25)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(175, 392)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 25)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = ":"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(175, 432)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 25)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = ":"
        '
        'frmMusTanimla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(406, 582)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GbIslemSec)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtMusSehir)
        Me.Controls.Add(Me.TxtMusBolge)
        Me.Controls.Add(Me.TxtMusTel)
        Me.Controls.Add(Me.TxtIlgKisiSoyadi)
        Me.Controls.Add(Me.TxtIlgKisiAd)
        Me.Controls.Add(Me.TxtSirAdi)
        Me.Controls.Add(Me.TxtMusNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMusTanimla"
        Me.Text = "Yeni Müsteri Tanýmlama Sayfasý"
        Me.GbIslemSec.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '*****
#Region "TASARIM olaylari"
    Private Sub TxtMusTel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMusTel.Leave
        '**Telefon numarasý alanýna sayý dýþýnda deðer girilmemsi için code**
        If Not IsNumeric(TxtMusTel.Text) Then
            MsgBox("Lütfen Telefon Numarasýný doðru Giriniz")
            TxtMusTel.Text = Nothing
        Else
            '**telefon numarasýnýn 11 den cok rakkam almamasý icin yazýlan code**
            If Not TxtMusTel.Text.Length > 11 Then
            Else
                MsgBox("Lütfen Telefon Numarasýný doðru Giriniz")
                TxtMusTel.Text = Nothing
            End If
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            BtnEkle.Enabled = True
        Else
            '****** Buraya zorunlu database alanlarý
            ' belirlendikten sonra onlara uygun aktiflik koþullarý gireceðiz... :! ******

            BtnEkle.Enabled = False
        End If
    End Sub
    Private Sub TumButonlariAktiflestir()
        '**paneller vasýtasýyla button ve cmbox'ý bu code dýþýnda býraktým.. kýsaltabilirsen yap.. benim aklýma gelmedi biþi :((**
        For Each control As Control In Me.Controls
            control.Enabled = True
        Next
    End Sub

    Private Sub Rbut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbutGuncelle.CheckedChanged, RbutTanimla.CheckedChanged
        '**iþlem seçme bölümü aktiflik özelliklerinin duzenlenmesi**
        'Eðer müþteri guncelleme seçilirse..
        If RbutGuncelle.Checked = True Then
            CmbMusSec.Enabled = True
            TumButonlariAktiflestir()
            TxtMusNo.ReadOnly = True
            'Eðer yeni müþteri ekleme seçilirse..
        ElseIf RbutTanimla.Checked = True Then
            CmbMusSec.Enabled = False
            TumButonlariAktiflestir()
            TxtMusNo.ReadOnly = False

        Else
            '**iþlem seçilmediðinde tum buttonlar iþlem dýþý olsun mu :P**
        End If


    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


    Private Sub MusTanimla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MusteriDoldur.musteridoldur()

        '    '****SELECT SORGUSU GÝRÝLECEK ****
        '???? doðrumuyum ???? Doðrusun :)
    End Sub

    Private Sub CmbMusSec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMusSec.SelectedIndexChanged
        'tüm textboxlar doldurulacak...
        '    '****SELECT SORGUSU GÝRÝLECEK ****
        '???? doðrumuyum ???? Doðrusun :)

    End Sub
End Class
