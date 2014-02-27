#Region "Imports"
Imports System
Imports System.data
Imports System.Data.OleDb
#End Region

Public Class frmMusGor
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
    Friend WithEvents RbutAd As System.Windows.Forms.RadioButton
    Friend WithEvents RbutNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbutSehir As System.Windows.Forms.RadioButton
    Friend WithEvents BtnSirala As System.Windows.Forms.Button
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RbutAd = New System.Windows.Forms.RadioButton
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.RbutNo = New System.Windows.Forms.RadioButton
        Me.RbutSehir = New System.Windows.Forms.RadioButton
        Me.BtnSirala = New System.Windows.Forms.Button
        Me.grp1 = New System.Windows.Forms.GroupBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RbutAd
        '
        Me.RbutAd.BackColor = System.Drawing.SystemColors.Control
        Me.RbutAd.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutAd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbutAd.Location = New System.Drawing.Point(14, 16)
        Me.RbutAd.Name = "RbutAd"
        Me.RbutAd.Size = New System.Drawing.Size(288, 24)
        Me.RbutAd.TabIndex = 0
        Me.RbutAd.Text = "Müsterileri Adýna Göre Sýrala"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 118)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(719, 352)
        Me.DataGrid1.TabIndex = 4
        '
        'RbutNo
        '
        Me.RbutNo.BackColor = System.Drawing.SystemColors.Control
        Me.RbutNo.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbutNo.Location = New System.Drawing.Point(14, 40)
        Me.RbutNo.Name = "RbutNo"
        Me.RbutNo.Size = New System.Drawing.Size(288, 24)
        Me.RbutNo.TabIndex = 1
        Me.RbutNo.Text = "Müþterileri Numarasýna Göre Sýrala"
        '
        'RbutSehir
        '
        Me.RbutSehir.BackColor = System.Drawing.SystemColors.Control
        Me.RbutSehir.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RbutSehir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbutSehir.Location = New System.Drawing.Point(14, 64)
        Me.RbutSehir.Name = "RbutSehir"
        Me.RbutSehir.Size = New System.Drawing.Size(288, 24)
        Me.RbutSehir.TabIndex = 3
        Me.RbutSehir.Text = "Müsterileri Þehrine Göre Sýrala"
        '
        'BtnSirala
        '
        Me.BtnSirala.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnSirala.Enabled = False
        Me.BtnSirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSirala.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnSirala.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSirala.Location = New System.Drawing.Point(504, 40)
        Me.BtnSirala.Name = "BtnSirala"
        Me.BtnSirala.Size = New System.Drawing.Size(192, 32)
        Me.BtnSirala.TabIndex = 5
        Me.BtnSirala.Text = "SIRALA"
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.RbutSehir)
        Me.grp1.Controls.Add(Me.RbutAd)
        Me.grp1.Controls.Add(Me.RbutNo)
        Me.grp1.Location = New System.Drawing.Point(7, 8)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(315, 96)
        Me.grp1.TabIndex = 6
        Me.grp1.TabStop = False
        '
        'frmMusGor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(719, 470)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.BtnSirala)
        Me.Controls.Add(Me.DataGrid1)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "frmMusGor"
        Me.Text = "Müþteri Görüntüle ;"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbutAd.CheckedChanged, RbutNo.CheckedChanged, RbutSehir.CheckedChanged
        If RbutAd.Checked = True Then
            BtnSirala.Enabled = True
        ElseIf RbutSehir.Checked = True Then
            BtnSirala.Enabled = True
        ElseIf RbutNo.Checked = True Then
            BtnSirala.Enabled = True
        Else
            BtnSirala.Enabled = False

        End If

    End Sub

    Private Sub BtnSirala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSirala.Click

        'Müsteriler ile birlikte ilgili musteriye ait faturalarýnda alt tablo olarak gösterimi yapýlmalýdýr.
        If RbutAd.Checked = True Then
            'Müsterileri adýna göre sýralayacak select sorgusu girilecek***

        ElseIf RbutSehir.Checked = True Then
            'Müsterileri sehrine göre sýralayacak select sorgusu girilecek***
        ElseIf RbutNo.Checked = True Then
            'Müsterileri numarasýna göre sýralayacak select sorgusu girilecek***
        Else
            Exit Sub
        End If
    End Sub
End Class
