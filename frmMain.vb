Public Class frmMain

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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFatIslemleri As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYeniFat As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFatGorIslem As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFatDok As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMusIslemleri As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYeniMus As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMusSil As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMusGorIslem As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMusDok As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOdeIslem As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYeniOde As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOdeDok As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYardim As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEMail As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHakkinda As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCikis As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuFatIslemleri = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.mnuYeniFat = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.mnuFatGorIslem = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.mnuFatDok = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.mnuMusIslemleri = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.mnuYeniMus = New System.Windows.Forms.MenuItem
        Me.mnuMusSil = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.mnuMusGorIslem = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.mnuMusDok = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.mnuOdeIslem = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.mnuYeniOde = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.mnuOdeDok = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.mnuYardim = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.mnuEMail = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.mnuHakkinda = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.mnuCikis = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFatIslemleri, Me.mnuMusIslemleri, Me.mnuOdeIslem, Me.mnuYardim, Me.mnuCikis})
        '
        'mnuFatIslemleri
        '
        Me.mnuFatIslemleri.Index = 0
        Me.mnuFatIslemleri.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49, Me.mnuYeniFat, Me.MenuItem7, Me.mnuFatGorIslem, Me.MenuItem8, Me.mnuFatDok, Me.MenuItem50})
        Me.mnuFatIslemleri.Text = "&Fatura Islemleri"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 0
        Me.MenuItem49.Text = "-"
        '
        'mnuYeniFat
        '
        Me.mnuYeniFat.Index = 1
        Me.mnuYeniFat.Text = "&Yeni Fatura Girisi"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "-"
        '
        'mnuFatGorIslem
        '
        Me.mnuFatGorIslem.Index = 3
        Me.mnuFatGorIslem.Text = "&Fatura Görüntüleme Islemleri"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "-"
        '
        'mnuFatDok
        '
        Me.mnuFatDok.Index = 5
        Me.mnuFatDok.Text = "&Dökümler"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 6
        Me.MenuItem50.Text = "-"
        '
        'mnuMusIslemleri
        '
        Me.mnuMusIslemleri.Index = 1
        Me.mnuMusIslemleri.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem48, Me.mnuYeniMus, Me.mnuMusSil, Me.MenuItem20, Me.mnuMusGorIslem, Me.MenuItem26, Me.mnuMusDok, Me.MenuItem47})
        Me.mnuMusIslemleri.Text = "&Müsteri Islemleri"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 0
        Me.MenuItem48.Text = "-"
        '
        'mnuYeniMus
        '
        Me.mnuYeniMus.Index = 1
        Me.mnuYeniMus.Text = "&Müsteri Tanimlama - Güncelleme"
        '
        'mnuMusSil
        '
        Me.mnuMusSil.Index = 2
        Me.mnuMusSil.Text = "&Müsteri Silme"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "-"
        '
        'mnuMusGorIslem
        '
        Me.mnuMusGorIslem.Index = 4
        Me.mnuMusGorIslem.Text = "&Müsteri Görüntüleme"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 5
        Me.MenuItem26.Text = "-"
        '
        'mnuMusDok
        '
        Me.mnuMusDok.Index = 6
        Me.mnuMusDok.Text = "&Dökümler"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 7
        Me.MenuItem47.Text = "-"
        '
        'mnuOdeIslem
        '
        Me.mnuOdeIslem.Index = 2
        Me.mnuOdeIslem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem46, Me.mnuYeniOde, Me.MenuItem31, Me.mnuOdeDok, Me.MenuItem45})
        Me.mnuOdeIslem.Text = "&Ödeme Islemleri"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 0
        Me.MenuItem46.Text = "-"
        '
        'mnuYeniOde
        '
        Me.mnuYeniOde.Index = 1
        Me.mnuYeniOde.Text = "&Yeni Ödeme Girisi"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 2
        Me.MenuItem31.Text = "-"
        '
        'mnuOdeDok
        '
        Me.mnuOdeDok.Index = 3
        Me.mnuOdeDok.Text = "&Ödeme Dökümleri"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 4
        Me.MenuItem45.Text = "-"
        '
        'mnuYardim
        '
        Me.mnuYardim.Index = 3
        Me.mnuYardim.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem56, Me.mnuEMail, Me.MenuItem53, Me.mnuHakkinda, Me.MenuItem55})
        Me.mnuYardim.Text = "&Yardim"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 0
        Me.MenuItem56.Text = "-"
        '
        'mnuEMail
        '
        Me.mnuEMail.Index = 1
        Me.mnuEMail.Text = "&E-Mail"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 2
        Me.MenuItem53.Text = "-"
        '
        'mnuHakkinda
        '
        Me.mnuHakkinda.Index = 3
        Me.mnuHakkinda.Text = "&Hakkinda"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 4
        Me.MenuItem55.Text = "-"
        '
        'mnuCikis
        '
        Me.mnuCikis.Index = 4
        Me.mnuCikis.Text = "&ÇIKIÞ"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 429)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.Text = "< < < ÖDEME TAKÝP PROGRAMI > > >"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

#Region "Main Menu Olaylarý - MDI Form Olaylarý"

    'Müþteri dökümleri..
    Private Sub mnuMusDok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMusDok.Click
        Dim frmmusdok As New FrmMusDok
        frmmusdok.MdiParent = Me
        frmmusdok.Show()

    End Sub

    'Yeni ödeme..
    Private Sub mnuYeniOde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYeniOde.Click
        Dim frmodgir As New frmOdeGir
        frmodgir.MdiParent = Me
        frmodgir.Show()
    End Sub

    'Fatura dökümleri..
    Private Sub mnuFatDok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFatDok.Click
        Dim frmfatdok As New frmFatDok
        frmfatdok.MdiParent = Me
        frmfatdok.Show()

    End Sub

    'Yeni fatura..
    Private Sub mnuYeniFat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYeniFat.Click
        'Yeni Fatura menu Item'ýna týklandýðýnda "Yeni Fatura" formu açýlacak..
        Dim YeniFaturaGirisi As New frmYeniFat
        'Bu forma MDIchildren ozelliði verdik
        YeniFaturaGirisi.MdiParent = Me
        YeniFaturaGirisi.Show()

    End Sub

    'Fatura görüntüleme..
    Private Sub mnuFatGorIslem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFatGorIslem.Click
        '"Fatura Goruntuleme" menu Item'ýna týklandýðýnda "Fatura Goruntuleme" formu açýlacak...
        Dim FatGor As New frmFatGor
        FatGor.MdiParent = Me
        'Bu forma MDIchildren ozelliði verdik
        FatGor.Show()
    End Sub

    'Müþteri Tanýmlama..
    Private Sub mnuYeniMus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYeniMus.Click
        Dim MusTan As New frmMusTanimla
        MusTan.MdiParent = Me
        MusTan.Show()

    End Sub

    'Müþteri silme..
    Private Sub mnuMusSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMusSil.Click
        Dim MusSil As New frmMusSil
        MusSil.MdiParent = Me
        MusSil.Show()

    End Sub

    'Programdan çýkýþ iþlemi..
    Private Sub mnuCikis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCikis.Click
        'Kullanýcý ÇIKIÞ  basarsa çýkmak istediðinden emin mi sorulacak...
        DialogResult = MessageBox.Show("Çýkmak istediðinizden emin misiniz?", "ÇIKIÞ", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        'Sonucunda;
        If DialogResult = DialogResult.Yes Then
            'Eðer Evet seçilirse ilk olarak tüm MdiChildren formlar sonlanacak..
            For i As Integer = 0 To Me.MdiChildren.Length - 1
                Me.MdiChildren(0).Close()
            Next
            'Sonrada MdiParent sonlanacak..
            Me.Close()
        Else
            'Eðer hayýr seçilirse hiç biþi yapýlmayacak program akýþýna devam edecek..
        End If
    End Sub

    'Müþteri görüntüleme iþlemleri..
    Private Sub mnuMusGorIslem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMusGorIslem.Click
        Dim frmMusGor As New frmMusGor
        frmMusGor.MdiParent = Me
        frmMusGor.Show()
    End Sub
    'odeme dokumleri...
    Private Sub mnuOdeDok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOdeDok.Click
        Dim frmOdeDok As New frmOdeDok
        frmOdeDok.MdiParent = Me
        frmOdeDok.Show()

    End Sub
#End Region



  
End Class

