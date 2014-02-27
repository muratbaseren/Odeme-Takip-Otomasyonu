#Region "Imports"
Imports System
Imports System.data
Imports System.Data.OleDb
#End Region
Public Class FrmMusDok
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents RbutOdGecFat As System.Windows.Forms.RadioButton
    Friend WithEvents RbutOdFat As System.Windows.Forms.RadioButton
    Friend WithEvents BtnGoster As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.RbutOdGecFat = New System.Windows.Forms.RadioButton
        Me.RbutOdFat = New System.Windows.Forms.RadioButton
        Me.BtnGoster = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(16, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(376, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Müsteri seçiniz..."
        '
        'RbutOdGecFat
        '
        Me.RbutOdGecFat.Enabled = False
        Me.RbutOdGecFat.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbutOdGecFat.Location = New System.Drawing.Point(16, 53)
        Me.RbutOdGecFat.Name = "RbutOdGecFat"
        Me.RbutOdGecFat.Size = New System.Drawing.Size(376, 24)
        Me.RbutOdGecFat.TabIndex = 1
        Me.RbutOdGecFat.Text = "Müsterinin Ödemesi Gecikmiþ Faturalarýný Göster"
        '
        'RbutOdFat
        '
        Me.RbutOdFat.Enabled = False
        Me.RbutOdFat.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbutOdFat.Location = New System.Drawing.Point(16, 80)
        Me.RbutOdFat.Name = "RbutOdFat"
        Me.RbutOdFat.Size = New System.Drawing.Size(376, 24)
        Me.RbutOdFat.TabIndex = 2
        Me.RbutOdFat.Text = "Müsterinin Ödenmemis Faturalarýný Göster"
        '
        'BtnGoster
        '
        Me.BtnGoster.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnGoster.Enabled = False
        Me.BtnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGoster.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnGoster.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnGoster.Location = New System.Drawing.Point(488, 72)
        Me.BtnGoster.Name = "BtnGoster"
        Me.BtnGoster.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnGoster.Size = New System.Drawing.Size(184, 32)
        Me.BtnGoster.TabIndex = 3
        Me.BtnGoster.Text = "GÖSTER"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 117)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(688, 376)
        Me.DataGrid1.TabIndex = 4
        '
        'FrmMusDok
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(688, 493)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.BtnGoster)
        Me.Controls.Add(Me.RbutOdFat)
        Me.Controls.Add(Me.RbutOdGecFat)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "FrmMusDok"
        Me.Text = "Müþteri Dökümleri"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Tasarim Olaylari"

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        'Combo box dan bir müþteri seçilmezse radiobutonlar pasif olcak..
        If Not ComboBox1.SelectedItem = Nothing Then
            RbutOdFat.Enabled = True
            RbutOdGecFat.Enabled = True
        Else
            RbutOdFat.Enabled = False
            RbutOdGecFat.Enabled = False
        End If
    End Sub

    Private Sub RbutOdFat_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbutOdFat.CheckedChanged, RbutOdGecFat.CheckedChanged

        'Seçilen radio butonu varsa Göster butonu aktif olacak yada seçilen radio buton yoksa göster butonu aktif olmayacak..
        If RbutOdGecFat.Checked = True Then
            BtnGoster.Enabled = True
        ElseIf RbutOdFat.Checked = True Then
            BtnGoster.Enabled = True
        Else
            BtnGoster.Enabled = False
        End If
    End Sub
#End Region

    '******
#Region "Olaylar"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGoster.Click
        If RbutOdGecFat.Checked = True Then
            'combobox1.selecteditem'daki musterinin ödemesi gecikmis faturalarý için select sorgusu yazýlacak bu 
            'now-(fatura tarihi + fatura vadesi)>0 ise gibi bir sorgu ile yapýlacak...
            'ZOR OLAN DA BU ZATEN :((
            'HALLEDERÝZZZZ :)))
        ElseIf RbutOdFat.Checked = True Then

            'combobox1.selecteditem'daki musterinin ödenmemiþ faturalarý için select sorgusu yazýlacak bu 
            '"ödenmis mi? = hayýr" ise gibi bir sorgu ile yapýlacak...

        End If

    End Sub
#End Region


    Private Sub FrmMusDok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MusteriDoldur.musteridoldur()

    End Sub
End Class
