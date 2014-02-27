
Public Class frmOdeGir
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtOdNo As System.Windows.Forms.TextBox
    Friend WithEvents CmbMusteriler As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNotlar As System.Windows.Forms.TextBox
    Friend WithEvents DtpOdTar As System.Windows.Forms.DateTimePicker
    Friend WithEvents NudOdMik As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnKaydet As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtOdNo = New System.Windows.Forms.TextBox
        Me.CmbMusteriler = New System.Windows.Forms.ComboBox
        Me.TxtNotlar = New System.Windows.Forms.TextBox
        Me.DtpOdTar = New System.Windows.Forms.DateTimePicker
        Me.NudOdMik = New System.Windows.Forms.NumericUpDown
        Me.BtnKaydet = New System.Windows.Forms.Button
        CType(Me.NudOdMik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ödeme Numarasý"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Müsteri Numarasý"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ödeme Tarihi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(8, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ödeme Miktarý"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Notlar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(224, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(224, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(224, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(224, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(224, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = ":"
        '
        'TxtOdNo
        '
        Me.TxtOdNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOdNo.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOdNo.Location = New System.Drawing.Point(248, 16)
        Me.TxtOdNo.Name = "TxtOdNo"
        Me.TxtOdNo.Size = New System.Drawing.Size(224, 24)
        Me.TxtOdNo.TabIndex = 10
        Me.TxtOdNo.Text = ""
        '
        'CmbMusteriler
        '
        Me.CmbMusteriler.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMusteriler.Location = New System.Drawing.Point(248, 48)
        Me.CmbMusteriler.Name = "CmbMusteriler"
        Me.CmbMusteriler.Size = New System.Drawing.Size(440, 24)
        Me.CmbMusteriler.TabIndex = 11
        Me.CmbMusteriler.Text = "Müþteri Seçiniz..."
        '
        'TxtNotlar
        '
        Me.TxtNotlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotlar.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNotlar.Location = New System.Drawing.Point(248, 144)
        Me.TxtNotlar.Multiline = True
        Me.TxtNotlar.Name = "TxtNotlar"
        Me.TxtNotlar.Size = New System.Drawing.Size(440, 56)
        Me.TxtNotlar.TabIndex = 12
        Me.TxtNotlar.Text = ""
        '
        'DtpOdTar
        '
        Me.DtpOdTar.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpOdTar.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpOdTar.Location = New System.Drawing.Point(248, 80)
        Me.DtpOdTar.Name = "DtpOdTar"
        Me.DtpOdTar.TabIndex = 13
        '
        'NudOdMik
        '
        Me.NudOdMik.DecimalPlaces = 2
        Me.NudOdMik.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudOdMik.Location = New System.Drawing.Point(248, 112)
        Me.NudOdMik.Name = "NudOdMik"
        Me.NudOdMik.Size = New System.Drawing.Size(200, 24)
        Me.NudOdMik.TabIndex = 14
        '
        'BtnKaydet
        '
        Me.BtnKaydet.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKaydet.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnKaydet.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnKaydet.Location = New System.Drawing.Point(504, 224)
        Me.BtnKaydet.Name = "BtnKaydet"
        Me.BtnKaydet.Size = New System.Drawing.Size(184, 24)
        Me.BtnKaydet.TabIndex = 15
        Me.BtnKaydet.Text = "KAYDET"
        '
        'frmOdeGir
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(712, 261)
        Me.Controls.Add(Me.BtnKaydet)
        Me.Controls.Add(Me.NudOdMik)
        Me.Controls.Add(Me.DtpOdTar)
        Me.Controls.Add(Me.TxtNotlar)
        Me.Controls.Add(Me.CmbMusteriler)
        Me.Controls.Add(Me.TxtOdNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOdeGir"
        Me.Text = "Ödeme Giriþi ;"
        CType(Me.NudOdMik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "yerel degiskenler"
    Dim Kosul1 As Boolean = False
    Dim Kosul2 As Boolean = False
    Dim Kosul3 As Boolean = False
#End Region

#Region "Kosullar"
    Private Sub NudOdMik_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudOdMik.ValueChanged
        Kosul1 = True
    End Sub

    Private Sub DtpOdTar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpOdTar.ValueChanged
        Kosul2 = True
    End Sub

    Private Sub CmbMusteriler_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMusteriler.SelectedIndexChanged
        If Not CmbMusteriler.SelectedItem = Nothing Then
            Kosul3 = True
        Else
            Kosul3 = False
        End If
    End Sub
#End Region
    'kontrol edilecek

#Region "olaylar"
    Private Sub frmOdeGir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MusteriDoldur.musteridoldur()


    End Sub

    Private Sub BtnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKaydet.Click
        If Not TxtOdNo.Text = Nothing AndAlso Kosul1 = True AndAlso Kosul2 = True AndAlso Kosul3 = True Then
            'Buraya Update sorgusu girilecek.
            MessageBox.Show("Ödemenin ait olduðu fatura bilgilerini güncellemeniz ve Ödendi Bölümünü iþaretlemeniz gerekmektedir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If DialogResult = DialogResult.OK Then
                Dim frmFatGun As New frmFatGun
                frmFatGun.ShowDialog()
                MsgBox("Ýþleminiz tamamlandýysa ilgili formlarý kapatabilirsiniz...")
            End If
        Else

            'Buraya gerekli alanlarla ilgili uyarý girilecek! **bos býrakýlmamasý gereken ilk 4 alan...****************

            'Eðer ödeme numarasý boþ geçilirse yada numara olarak girilmezse..
            If TxtOdNo.Text = "" Or IsNumeric(TxtOdNo.Text) = False Then
                MsgBox("Ödeme numarasýný boþ býraktýnýz yada geçerli bir sayý girmediniz..Kontrol edip tekrar giriniz..", MsgBoxStyle.Exclamation, "Ödeme Numarasý Hatasý")
                TxtOdNo.Focus()
            End If

            '********************************************************************************

            'Eðer müþteri seçilmemiþse..
            If CmbMusteriler.Text = Nothing Then
                MsgBox("Müþteri seçmediniz..Lütfen bir müþteri seçiniz..", MsgBoxStyle.Exclamation, "Müþteri Seçme Hatasý")

                CmbMusteriler.Focus()
            End If

            Exit Sub
        End If
    End Sub

#End Region




End Class
