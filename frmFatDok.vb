#Region "Imports"
Imports System
Imports System.data
Imports System.Data.OleDb
#End Region

Public Class frmFatDok
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
    Friend WithEvents BtnGoster As System.Windows.Forms.Button
    Friend WithEvents RbutOdFat As System.Windows.Forms.RadioButton
    Friend WithEvents RbutOdGecFat As System.Windows.Forms.RadioButton
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.BtnGoster = New System.Windows.Forms.Button
        Me.RbutOdFat = New System.Windows.Forms.RadioButton
        Me.RbutOdGecFat = New System.Windows.Forms.RadioButton
        Me.grp1 = New System.Windows.Forms.GroupBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 127)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(696, 408)
        Me.DataGrid1.TabIndex = 1
        '
        'BtnGoster
        '
        Me.BtnGoster.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnGoster.Enabled = False
        Me.BtnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGoster.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnGoster.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnGoster.Location = New System.Drawing.Point(456, 56)
        Me.BtnGoster.Name = "BtnGoster"
        Me.BtnGoster.Size = New System.Drawing.Size(184, 25)
        Me.BtnGoster.TabIndex = 2
        Me.BtnGoster.Text = "GÖSTER"
        '
        'RbutOdFat
        '
        Me.RbutOdFat.Location = New System.Drawing.Point(16, 32)
        Me.RbutOdFat.Name = "RbutOdFat"
        Me.RbutOdFat.Size = New System.Drawing.Size(264, 25)
        Me.RbutOdFat.TabIndex = 3
        Me.RbutOdFat.Text = "Ödenmemiþ Faturalarý Göster"
        '
        'RbutOdGecFat
        '
        Me.RbutOdGecFat.Location = New System.Drawing.Point(16, 56)
        Me.RbutOdGecFat.Name = "RbutOdGecFat"
        Me.RbutOdGecFat.Size = New System.Drawing.Size(264, 25)
        Me.RbutOdGecFat.TabIndex = 4
        Me.RbutOdGecFat.Text = "Ödemesi Gecikmiþ Faturalarý Göster"
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.RbutOdGecFat)
        Me.grp1.Controls.Add(Me.RbutOdFat)
        Me.grp1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp1.Location = New System.Drawing.Point(16, 16)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(360, 100)
        Me.grp1.TabIndex = 5
        Me.grp1.TabStop = False
        '
        'frmFatDok
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(696, 535)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.BtnGoster)
        Me.Controls.Add(Me.DataGrid1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "frmFatDok"
        Me.Text = "Fatura Dökümleri ;"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Tasarým Olaylari"
    Private Sub Rbut_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbutOdFat.CheckedChanged, RbutOdGecFat.CheckedChanged

        'Seçilmiþ radio buton yoksa göster butonu pasif olcak..
        If RbutOdFat.Checked = True Then
            BtnGoster.Enabled = True
        ElseIf RbutOdGecFat.Checked = True Then
            BtnGoster.Enabled = True
        Else
            BtnGoster.Enabled = False
        End If
    End Sub
#End Region

#Region "Olaylar"
    Private Sub BtnGoster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGoster.Click
        If RbutOdFat.Checked = True Then
            'Sadece tüm ödenmemiþ faturalarý gosterecek SELECT Sorgusu Yazýlacak...
        ElseIf RbutOdGecFat.Checked = True Then
            'Sadece ödemesi gecikmiþ faturalarý göserecek SELECT sorgusu yazýlacak....
        Else
            Exit Sub
        End If

    End Sub

#End Region

End Class
