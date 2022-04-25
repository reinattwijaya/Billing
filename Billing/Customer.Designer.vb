<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MainMenuData = New System.Windows.Forms.DataGridView()
        Me.button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengumumanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagihanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ubahButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.noCustomer = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cari = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.prevButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.pageNumber = New System.Windows.Forms.NumericUpDown()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.MainMenuData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.pageNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 767)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1827, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(101, 20)
        Me.ToolStripStatusLabel1.Text = "Logged in as :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(1400, 20)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainMenuData
        '
        Me.MainMenuData.AllowUserToAddRows = False
        Me.MainMenuData.AllowUserToDeleteRows = False
        Me.MainMenuData.AllowUserToResizeColumns = False
        Me.MainMenuData.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainMenuData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MainMenuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainMenuData.DefaultCellStyle = DataGridViewCellStyle2
        Me.MainMenuData.Location = New System.Drawing.Point(33, 48)
        Me.MainMenuData.Margin = New System.Windows.Forms.Padding(4)
        Me.MainMenuData.Name = "MainMenuData"
        Me.MainMenuData.ReadOnly = True
        Me.MainMenuData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.MainMenuData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainMenuData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainMenuData.Size = New System.Drawing.Size(1753, 579)
        Me.MainMenuData.TabIndex = 3
        '
        'button
        '
        Me.button.Location = New System.Drawing.Point(581, 180)
        Me.button.Margin = New System.Windows.Forms.Padding(4)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(100, 28)
        Me.button.TabIndex = 4
        Me.button.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.DaftarToolStripMenuItem, Me.CetakToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1827, 28)
        Me.MenuStrip2.TabIndex = 36
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.BackUpDatabaseToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(46, 24)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.RegistrationToolStripMenuItem.Text = "Ubah Password"
        '
        'BackUpDatabaseToolStripMenuItem
        '
        Me.BackUpDatabaseToolStripMenuItem.Name = "BackUpDatabaseToolStripMenuItem"
        Me.BackUpDatabaseToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.BackUpDatabaseToolStripMenuItem.Text = "Back Up Database"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.ExitToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(213, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'DaftarToolStripMenuItem
        '
        Me.DaftarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.TagihanToolStripMenuItem, Me.RateToolStripMenuItem})
        Me.DaftarToolStripMenuItem.Name = "DaftarToolStripMenuItem"
        Me.DaftarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.DaftarToolStripMenuItem.Text = "Daftar"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'TagihanToolStripMenuItem
        '
        Me.TagihanToolStripMenuItem.Name = "TagihanToolStripMenuItem"
        Me.TagihanToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.TagihanToolStripMenuItem.Text = "Tagihan"
        '
        'RateToolStripMenuItem
        '
        Me.RateToolStripMenuItem.Name = "RateToolStripMenuItem"
        Me.RateToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.RateToolStripMenuItem.Text = "Rate"
        '
        'CetakToolStripMenuItem
        '
        Me.CetakToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengumumanToolStripMenuItem, Me.TagihanToolStripMenuItem1})
        Me.CetakToolStripMenuItem.Name = "CetakToolStripMenuItem"
        Me.CetakToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.CetakToolStripMenuItem.Text = "Cetak"
        '
        'PengumumanToolStripMenuItem
        '
        Me.PengumumanToolStripMenuItem.Name = "PengumumanToolStripMenuItem"
        Me.PengumumanToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.PengumumanToolStripMenuItem.Text = "Pengumuman"
        '
        'TagihanToolStripMenuItem1
        '
        Me.TagihanToolStripMenuItem1.Name = "TagihanToolStripMenuItem1"
        Me.TagihanToolStripMenuItem1.Size = New System.Drawing.Size(182, 26)
        Me.TagihanToolStripMenuItem1.Text = "Invoice"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'ubahButton
        '
        Me.ubahButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubahButton.Location = New System.Drawing.Point(1489, 701)
        Me.ubahButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ubahButton.Name = "ubahButton"
        Me.ubahButton.Size = New System.Drawing.Size(97, 43)
        Me.ubahButton.TabIndex = 38
        Me.ubahButton.Text = "Ubah"
        Me.ubahButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 686)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Nomor Customer"
        '
        'noCustomer
        '
        Me.noCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noCustomer.Location = New System.Drawing.Point(209, 682)
        Me.noCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.noCustomer.Name = "noCustomer"
        Me.noCustomer.Size = New System.Drawing.Size(132, 29)
        Me.noCustomer.TabIndex = 41
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(209, 717)
        Me.nama.Margin = New System.Windows.Forms.Padding(4)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(175, 29)
        Me.nama.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 720)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nama"
        '
        'cari
        '
        Me.cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cari.Location = New System.Drawing.Point(408, 702)
        Me.cari.Margin = New System.Windows.Forms.Padding(4)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(100, 44)
        Me.cari.TabIndex = 44
        Me.cari.Text = "Cari"
        Me.cari.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(516, 703)
        Me.reset.Margin = New System.Windows.Forms.Padding(4)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(100, 43)
        Me.reset.TabIndex = 45
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusButton.Image = Global.Billing.My.Resources.Resources.delete11
        Me.hapusButton.Location = New System.Drawing.Point(1622, 700)
        Me.hapusButton.Margin = New System.Windows.Forms.Padding(4)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(115, 44)
        Me.hapusButton.TabIndex = 39
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'tambahButton
        '
        Me.tambahButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahButton.Image = Global.Billing.My.Resources.Resources.plus12
        Me.tambahButton.Location = New System.Drawing.Point(1292, 700)
        Me.tambahButton.Margin = New System.Windows.Forms.Padding(4)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(155, 44)
        Me.tambahButton.TabIndex = 37
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tambahButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'prevButton
        '
        Me.prevButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevButton.Location = New System.Drawing.Point(1689, 627)
        Me.prevButton.Name = "prevButton"
        Me.prevButton.Size = New System.Drawing.Size(32, 28)
        Me.prevButton.TabIndex = 95
        Me.prevButton.Text = "<"
        Me.prevButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(1757, 628)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(29, 28)
        Me.nextButton.TabIndex = 94
        Me.nextButton.Text = ">"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'pageNumber
        '
        Me.pageNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageNumber.Location = New System.Drawing.Point(1715, 627)
        Me.pageNumber.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.pageNumber.Name = "pageNumber"
        Me.pageNumber.Size = New System.Drawing.Size(71, 28)
        Me.pageNumber.TabIndex = 96
        Me.pageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1827, 793)
        Me.Controls.Add(Me.prevButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.pageNumber)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.noCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hapusButton)
        Me.Controls.Add(Me.ubahButton)
        Me.Controls.Add(Me.tambahButton)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MainMenuData)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.button)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.MainMenuData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.pageNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents MainMenuData As DataGridView
    Friend WithEvents button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DaftarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagihanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengumumanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagihanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tambahButton As Button
    Friend WithEvents ubahButton As Button
    Friend WithEvents hapusButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents noCustomer As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cari As Button
    Friend WithEvents reset As Button
    Friend WithEvents BackUpDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents prevButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents pageNumber As NumericUpDown
End Class
