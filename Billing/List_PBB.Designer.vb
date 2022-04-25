<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List_PBB
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Invoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.List_PBBData = New System.Windows.Forms.DataGridView()
        Me.tanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.tanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lunas = New System.Windows.Forms.CheckBox()
        Me.cariButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.ubah = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.prevButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.pageNumber = New System.Windows.Forms.NumericUpDown()
        Me.MenuStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.List_PBBData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pageNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.DaftarToolStripMenuItem, Me.CetakToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1827, 28)
        Me.MenuStrip2.TabIndex = 37
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
        Me.CetakToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengumumanToolStripMenuItem, Me.Invoice})
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
        'Invoice
        '
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Size = New System.Drawing.Size(182, 26)
        Me.Invoice.Text = "Invoice"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 797)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1827, 26)
        Me.StatusStrip1.TabIndex = 38
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
        'List_PBBData
        '
        Me.List_PBBData.AllowUserToAddRows = False
        Me.List_PBBData.AllowUserToDeleteRows = False
        Me.List_PBBData.AllowUserToResizeColumns = False
        Me.List_PBBData.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.List_PBBData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.List_PBBData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.List_PBBData.DefaultCellStyle = DataGridViewCellStyle4
        Me.List_PBBData.Location = New System.Drawing.Point(16, 59)
        Me.List_PBBData.Margin = New System.Windows.Forms.Padding(4)
        Me.List_PBBData.Name = "List_PBBData"
        Me.List_PBBData.ReadOnly = True
        Me.List_PBBData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.List_PBBData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.List_PBBData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.List_PBBData.Size = New System.Drawing.Size(1795, 580)
        Me.List_PBBData.TabIndex = 39
        '
        'tanggalAwal
        '
        Me.tanggalAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tanggalAwal.Location = New System.Drawing.Point(225, 709)
        Me.tanggalAwal.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggalAwal.Name = "tanggalAwal"
        Me.tanggalAwal.Size = New System.Drawing.Size(155, 29)
        Me.tanggalAwal.TabIndex = 76
        Me.tanggalAwal.Value = New Date(2020, 6, 7, 0, 0, 0, 0)
        '
        'tanggalAkhir
        '
        Me.tanggalAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tanggalAkhir.Location = New System.Drawing.Point(225, 741)
        Me.tanggalAkhir.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggalAkhir.Name = "tanggalAkhir"
        Me.tanggalAkhir.Size = New System.Drawing.Size(155, 29)
        Me.tanggalAkhir.TabIndex = 77
        Me.tanggalAkhir.Value = New Date(2020, 6, 7, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 715)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 742)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 24)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "s/d"
        '
        'lunas
        '
        Me.lunas.AutoSize = True
        Me.lunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lunas.Location = New System.Drawing.Point(469, 677)
        Me.lunas.Margin = New System.Windows.Forms.Padding(4)
        Me.lunas.Name = "lunas"
        Me.lunas.Size = New System.Drawing.Size(88, 28)
        Me.lunas.TabIndex = 80
        Me.lunas.Text = "Lunas"
        Me.lunas.UseVisualStyleBackColor = True
        '
        'cariButton
        '
        Me.cariButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cariButton.Location = New System.Drawing.Point(465, 725)
        Me.cariButton.Margin = New System.Windows.Forms.Padding(4)
        Me.cariButton.Name = "cariButton"
        Me.cariButton.Size = New System.Drawing.Size(100, 44)
        Me.cariButton.TabIndex = 81
        Me.cariButton.Text = "Cari"
        Me.cariButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusButton.Image = Global.Billing.My.Resources.Resources.delete11
        Me.hapusButton.Location = New System.Drawing.Point(1649, 719)
        Me.hapusButton.Margin = New System.Windows.Forms.Padding(4)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(128, 46)
        Me.hapusButton.TabIndex = 84
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'tambahButton
        '
        Me.tambahButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahButton.Image = Global.Billing.My.Resources.Resources.plus12
        Me.tambahButton.Location = New System.Drawing.Point(1361, 720)
        Me.tambahButton.Margin = New System.Windows.Forms.Padding(4)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(141, 44)
        Me.tambahButton.TabIndex = 82
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'button
        '
        Me.button.Location = New System.Drawing.Point(938, 599)
        Me.button.Margin = New System.Windows.Forms.Padding(4)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(100, 28)
        Me.button.TabIndex = 85
        Me.button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 682)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 24)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Nama Customer"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(225, 677)
        Me.nama.Margin = New System.Windows.Forms.Padding(4)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(209, 29)
        Me.nama.TabIndex = 87
        '
        'ubah
        '
        Me.ubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubah.Location = New System.Drawing.Point(1527, 720)
        Me.ubah.Margin = New System.Windows.Forms.Padding(4)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(100, 44)
        Me.ubah.TabIndex = 88
        Me.ubah.Text = "Ubah"
        Me.ubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ubah.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(573, 725)
        Me.reset.Margin = New System.Windows.Forms.Padding(4)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(100, 44)
        Me.reset.TabIndex = 89
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'prevButton
        '
        Me.prevButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevButton.Location = New System.Drawing.Point(1714, 638)
        Me.prevButton.Name = "prevButton"
        Me.prevButton.Size = New System.Drawing.Size(32, 28)
        Me.prevButton.TabIndex = 98
        Me.prevButton.Text = "<"
        Me.prevButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(1782, 639)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(29, 28)
        Me.nextButton.TabIndex = 97
        Me.nextButton.Text = ">"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'pageNumber
        '
        Me.pageNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageNumber.Location = New System.Drawing.Point(1740, 638)
        Me.pageNumber.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.pageNumber.Name = "pageNumber"
        Me.pageNumber.Size = New System.Drawing.Size(71, 28)
        Me.pageNumber.TabIndex = 99
        Me.pageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'List_PBB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 823)
        Me.Controls.Add(Me.prevButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.pageNumber)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hapusButton)
        Me.Controls.Add(Me.tambahButton)
        Me.Controls.Add(Me.cariButton)
        Me.Controls.Add(Me.lunas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tanggalAkhir)
        Me.Controls.Add(Me.tanggalAwal)
        Me.Controls.Add(Me.List_PBBData)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.button)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "List_PBB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List PBB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.List_PBBData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pageNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Invoice As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents List_PBBData As DataGridView
    Friend WithEvents tanggalAwal As DateTimePicker
    Friend WithEvents tanggalAkhir As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lunas As CheckBox
    Friend WithEvents cariButton As Button
    Friend WithEvents hapusButton As Button
    Friend WithEvents tambahButton As Button
    Friend WithEvents button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents ubah As Button
    Friend WithEvents reset As Button
    Friend WithEvents BackUpDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents prevButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents pageNumber As NumericUpDown
End Class
