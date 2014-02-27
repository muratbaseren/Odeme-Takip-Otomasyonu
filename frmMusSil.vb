#Region "Imports"
Imports System
Imports System.data
Imports System.Data.OleDb
#End Region

Public Class frmMusSil
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
    Friend WithEvents CmbMusteriler As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSil As System.Windows.Forms.Button
    Friend WithEvents BtnHayir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CmbMusteriler = New System.Windows.Forms.ComboBox
        Me.BtnSil = New System.Windows.Forms.Button
        Me.BtnHayir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CmbMusteriler
        '
        Me.CmbMusteriler.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMusteriler.Location = New System.Drawing.Point(24, 16)
        Me.CmbMusteriler.Name = "CmbMusteriler"
        Me.CmbMusteriler.Size = New System.Drawing.Size(368, 23)
        Me.CmbMusteriler.TabIndex = 0
        Me.CmbMusteriler.Text = "Silmek Ýstediðiniz Müsteriyi Seçiniz..."
        '
        'BtnSil
        '
        Me.BtnSil.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSil.Font = New System.Drawing.Font("Times New Roman", 10.08!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSil.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSil.Location = New System.Drawing.Point(200, 184)
        Me.BtnSil.Name = "BtnSil"
        Me.BtnSil.Size = New System.Drawing.Size(88, 23)
        Me.BtnSil.TabIndex = 3
        Me.BtnSil.Text = "EVET"
        '
        'BtnHayir
        '
        Me.BtnHayir.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnHayir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHayir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnHayir.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnHayir.Location = New System.Drawing.Point(296, 184)
        Me.BtnHayir.Name = "BtnHayir"
        Me.BtnHayir.Size = New System.Drawing.Size(88, 23)
        Me.BtnHayir.TabIndex = 4
        Me.BtnHayir.Text = "HAYIR"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 104)
        Me.Label1.TabIndex = 5
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMusSil
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(407, 222)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHayir)
        Me.Controls.Add(Me.BtnSil)
        Me.Controls.Add(Me.CmbMusteriler)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMusSil"
        Me.Text = "Müþteri Bilgisi Silme"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Olaylar"
    Private Sub MusSil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MusteriDoldur.musteridoldur()

        Label1.Text = "      Seçili Müsteriyi silmeniz durumunda söz konusu musteri ile ilgili bilgilere tekrar ulaþmanýz mümkün olmayacaktýr." & vbCrLf & vbCrLf & "Seçili Müsteriyi silmek istediðinizden eminmisiniz ? "

        '*** elbette... müsteriler databaseden çekilcek... :)
        'Yani SELECT Sorgusu
    End Sub

    Private Sub BtnSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSil.Click
        '****SÝLME ÝÞLEMÝ SORGUSU GÝRÝLECEK ** DELETE ****
    End Sub

    Private Sub BtnHayir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHayir.Click
        '***Eðer silme iþleminden emin deðilse formdan çýkacak***
        Me.Close()
    End Sub
#End Region

End Class
