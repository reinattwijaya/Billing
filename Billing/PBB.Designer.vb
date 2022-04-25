<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PBB
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
        Me.nama = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.noCustomer = New System.Windows.Forms.ComboBox()
        Me.namaPemilik = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.noKwitansi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.luas = New System.Windows.Forms.NumericUpDown()
        Me.noKios = New System.Windows.Forms.TextBox()
        Me.lantai = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.biayaPBB = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.printPBB = New System.Windows.Forms.Button()
        Me.saldo = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.bayar = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lunas = New System.Windows.Forms.CheckBox()
        Me.denda = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.sist = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tahun = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.simpanTambah = New System.Windows.Forms.Button()
        Me.simpanTutup = New System.Windows.Forms.Button()
        Me.cetakSemua = New System.Windows.Forms.Button()
        Me.PBBbayar = New System.Windows.Forms.CheckBox()
        Me.SISTbayar = New System.Windows.Forms.CheckBox()
        CType(Me.luas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biayaPBB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.denda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nama
        '
        Me.nama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.nama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.FormattingEnabled = True
        Me.nama.Location = New System.Drawing.Point(222, 67)
        Me.nama.Margin = New System.Windows.Forms.Padding(4)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(216, 32)
        Me.nama.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Nomor Customer"
        '
        'noCustomer
        '
        Me.noCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.noCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.noCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noCustomer.FormattingEnabled = True
        Me.noCustomer.Location = New System.Drawing.Point(222, 32)
        Me.noCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.noCustomer.Name = "noCustomer"
        Me.noCustomer.Size = New System.Drawing.Size(216, 32)
        Me.noCustomer.TabIndex = 5
        '
        'namaPemilik
        '
        Me.namaPemilik.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaPemilik.Location = New System.Drawing.Point(222, 103)
        Me.namaPemilik.Margin = New System.Windows.Forms.Padding(4)
        Me.namaPemilik.Name = "namaPemilik"
        Me.namaPemilik.Size = New System.Drawing.Size(216, 29)
        Me.namaPemilik.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(33, 106)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 24)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Nama Akte"
        '
        'noKwitansi
        '
        Me.noKwitansi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noKwitansi.Location = New System.Drawing.Point(222, 183)
        Me.noKwitansi.Margin = New System.Windows.Forms.Padding(4)
        Me.noKwitansi.Name = "noKwitansi"
        Me.noKwitansi.Size = New System.Drawing.Size(216, 29)
        Me.noKwitansi.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "No Kwitansi"
        '
        'tanggal
        '
        Me.tanggal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tanggal.Location = New System.Drawing.Point(222, 217)
        Me.tanggal.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(216, 28)
        Me.tanggal.TabIndex = 10
        Me.tanggal.Value = New Date(2020, 6, 11, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(33, 221)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 24)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Tanggal Kwitansi"
        '
        'luas
        '
        Me.luas.DecimalPlaces = 2
        Me.luas.Enabled = False
        Me.luas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luas.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.luas.Location = New System.Drawing.Point(222, 316)
        Me.luas.Margin = New System.Windows.Forms.Padding(4)
        Me.luas.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.luas.Name = "luas"
        Me.luas.Size = New System.Drawing.Size(107, 29)
        Me.luas.TabIndex = 13
        '
        'noKios
        '
        Me.noKios.Enabled = False
        Me.noKios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noKios.Location = New System.Drawing.Point(222, 283)
        Me.noKios.Margin = New System.Windows.Forms.Padding(4)
        Me.noKios.Name = "noKios"
        Me.noKios.Size = New System.Drawing.Size(105, 29)
        Me.noKios.TabIndex = 12
        '
        'lantai
        '
        Me.lantai.Enabled = False
        Me.lantai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lantai.Location = New System.Drawing.Point(222, 250)
        Me.lantai.Margin = New System.Windows.Forms.Padding(4)
        Me.lantai.Name = "lantai"
        Me.lantai.Size = New System.Drawing.Size(105, 29)
        Me.lantai.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 318)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 24)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Luas (M2)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(34, 286)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 24)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "No. Kios"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(34, 253)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 24)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Lantai"
        '
        'subtotal
        '
        Me.subtotal.Enabled = False
        Me.subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.subtotal.InterceptArrowKeys = False
        Me.subtotal.Location = New System.Drawing.Point(222, 380)
        Me.subtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.subtotal.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(172, 29)
        Me.subtotal.TabIndex = 15
        Me.subtotal.ThousandsSeparator = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 383)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 24)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Sub Total"
        '
        'biayaPBB
        '
        Me.biayaPBB.Enabled = False
        Me.biayaPBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biayaPBB.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.biayaPBB.InterceptArrowKeys = False
        Me.biayaPBB.Location = New System.Drawing.Point(222, 348)
        Me.biayaPBB.Margin = New System.Windows.Forms.Padding(4)
        Me.biayaPBB.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.biayaPBB.Name = "biayaPBB"
        Me.biayaPBB.Size = New System.Drawing.Size(172, 29)
        Me.biayaPBB.TabIndex = 14
        Me.biayaPBB.ThousandsSeparator = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 351)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 24)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Biaya PBB"
        '
        'printPBB
        '
        Me.printPBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printPBB.Location = New System.Drawing.Point(678, 445)
        Me.printPBB.Margin = New System.Windows.Forms.Padding(4)
        Me.printPBB.Name = "printPBB"
        Me.printPBB.Size = New System.Drawing.Size(212, 57)
        Me.printPBB.TabIndex = 24
        Me.printPBB.Text = "Cetak PBB"
        Me.printPBB.UseVisualStyleBackColor = True
        '
        'saldo
        '
        Me.saldo.Enabled = False
        Me.saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.saldo.InterceptArrowKeys = False
        Me.saldo.Location = New System.Drawing.Point(222, 511)
        Me.saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.saldo.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.saldo.Minimum = New Decimal(New Integer() {276447232, 23283, 0, -2147483648})
        Me.saldo.Name = "saldo"
        Me.saldo.Size = New System.Drawing.Size(172, 29)
        Me.saldo.TabIndex = 19
        Me.saldo.ThousandsSeparator = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(34, 513)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 24)
        Me.Label28.TabIndex = 125
        Me.Label28.Text = "Saldo PBB"
        '
        'bayar
        '
        Me.bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bayar.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.bayar.InterceptArrowKeys = False
        Me.bayar.Location = New System.Drawing.Point(222, 545)
        Me.bayar.Margin = New System.Windows.Forms.Padding(4)
        Me.bayar.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.bayar.Minimum = New Decimal(New Integer() {276447232, 23283, 0, -2147483648})
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(172, 29)
        Me.bayar.TabIndex = 20
        Me.bayar.ThousandsSeparator = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(38, 547)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 24)
        Me.Label27.TabIndex = 127
        Me.Label27.Text = "Bayar"
        '
        'lunas
        '
        Me.lunas.AutoSize = True
        Me.lunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lunas.Location = New System.Drawing.Point(222, 582)
        Me.lunas.Margin = New System.Windows.Forms.Padding(4)
        Me.lunas.Name = "lunas"
        Me.lunas.Size = New System.Drawing.Size(93, 29)
        Me.lunas.TabIndex = 21
        Me.lunas.Text = "Lunas"
        Me.lunas.UseVisualStyleBackColor = True
        '
        'denda
        '
        Me.denda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.denda.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.denda.InterceptArrowKeys = False
        Me.denda.Location = New System.Drawing.Point(222, 413)
        Me.denda.Margin = New System.Windows.Forms.Padding(4)
        Me.denda.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.denda.Name = "denda"
        Me.denda.Size = New System.Drawing.Size(172, 29)
        Me.denda.TabIndex = 16
        Me.denda.ThousandsSeparator = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(34, 413)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 24)
        Me.Label26.TabIndex = 132
        Me.Label26.Text = "Denda"
        '
        'sist
        '
        Me.sist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sist.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.sist.InterceptArrowKeys = False
        Me.sist.Location = New System.Drawing.Point(222, 445)
        Me.sist.Margin = New System.Windows.Forms.Padding(4)
        Me.sist.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.sist.Name = "sist"
        Me.sist.Size = New System.Drawing.Size(172, 29)
        Me.sist.TabIndex = 17
        Me.sist.ThousandsSeparator = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(34, 447)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 24)
        Me.Label25.TabIndex = 131
        Me.Label25.Text = "SIST"
        '
        'total
        '
        Me.total.Enabled = False
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.total.InterceptArrowKeys = False
        Me.total.Location = New System.Drawing.Point(222, 478)
        Me.total.Margin = New System.Windows.Forms.Padding(4)
        Me.total.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(172, 29)
        Me.total.TabIndex = 18
        Me.total.ThousandsSeparator = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(34, 480)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 24)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Total"
        '
        'tahun
        '
        Me.tahun.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tahun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tahun.FormattingEnabled = True
        Me.tahun.Location = New System.Drawing.Point(221, 148)
        Me.tahun.Margin = New System.Windows.Forms.Padding(4)
        Me.tahun.Name = "tahun"
        Me.tahun.Size = New System.Drawing.Size(122, 32)
        Me.tahun.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(33, 152)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 24)
        Me.Label18.TabIndex = 136
        Me.Label18.Text = "Tahun"
        '
        'simpanTambah
        '
        Me.simpanTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpanTambah.Location = New System.Drawing.Point(678, 283)
        Me.simpanTambah.Margin = New System.Windows.Forms.Padding(4)
        Me.simpanTambah.Name = "simpanTambah"
        Me.simpanTambah.Size = New System.Drawing.Size(212, 53)
        Me.simpanTambah.TabIndex = 22
        Me.simpanTambah.Text = "Simpan && Tambah"
        Me.simpanTambah.UseVisualStyleBackColor = True
        '
        'simpanTutup
        '
        Me.simpanTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpanTutup.Location = New System.Drawing.Point(678, 369)
        Me.simpanTutup.Margin = New System.Windows.Forms.Padding(4)
        Me.simpanTutup.Name = "simpanTutup"
        Me.simpanTutup.Size = New System.Drawing.Size(212, 50)
        Me.simpanTutup.TabIndex = 23
        Me.simpanTutup.Text = "Simpan && Tutup"
        Me.simpanTutup.UseVisualStyleBackColor = True
        '
        'cetakSemua
        '
        Me.cetakSemua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cetakSemua.Location = New System.Drawing.Point(678, 525)
        Me.cetakSemua.Margin = New System.Windows.Forms.Padding(4)
        Me.cetakSemua.Name = "cetakSemua"
        Me.cetakSemua.Size = New System.Drawing.Size(212, 57)
        Me.cetakSemua.TabIndex = 137
        Me.cetakSemua.Text = "Cetak Rekap"
        Me.cetakSemua.UseVisualStyleBackColor = True
        '
        'PBBbayar
        '
        Me.PBBbayar.AutoSize = True
        Me.PBBbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBBbayar.Location = New System.Drawing.Point(410, 348)
        Me.PBBbayar.Margin = New System.Windows.Forms.Padding(4)
        Me.PBBbayar.Name = "PBBbayar"
        Me.PBBbayar.Size = New System.Drawing.Size(136, 29)
        Me.PBBbayar.TabIndex = 138
        Me.PBBbayar.Text = "bayar PBB"
        Me.PBBbayar.UseVisualStyleBackColor = True
        '
        'SISTbayar
        '
        Me.SISTbayar.AutoSize = True
        Me.SISTbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SISTbayar.Location = New System.Drawing.Point(410, 442)
        Me.SISTbayar.Margin = New System.Windows.Forms.Padding(4)
        Me.SISTbayar.Name = "SISTbayar"
        Me.SISTbayar.Size = New System.Drawing.Size(144, 29)
        Me.SISTbayar.TabIndex = 139
        Me.SISTbayar.Text = "bayar SIST"
        Me.SISTbayar.UseVisualStyleBackColor = True
        '
        'PBB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 657)
        Me.Controls.Add(Me.SISTbayar)
        Me.Controls.Add(Me.PBBbayar)
        Me.Controls.Add(Me.cetakSemua)
        Me.Controls.Add(Me.simpanTutup)
        Me.Controls.Add(Me.simpanTambah)
        Me.Controls.Add(Me.tahun)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.denda)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.sist)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lunas)
        Me.Controls.Add(Me.bayar)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.saldo)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.printPBB)
        Me.Controls.Add(Me.biayaPBB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.luas)
        Me.Controls.Add(Me.noKios)
        Me.Controls.Add(Me.lantai)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.noKwitansi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.namaPemilik)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.noCustomer)
        Me.Name = "PBB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PBB"
        CType(Me.luas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biayaPBB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.denda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nama As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents noCustomer As ComboBox
    Friend WithEvents namaPemilik As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents noKwitansi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents luas As NumericUpDown
    Friend WithEvents noKios As TextBox
    Friend WithEvents lantai As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents subtotal As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents biayaPBB As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents printPBB As Button
    Friend WithEvents saldo As NumericUpDown
    Friend WithEvents Label28 As Label
    Friend WithEvents bayar As NumericUpDown
    Friend WithEvents Label27 As Label
    Friend WithEvents lunas As CheckBox
    Friend WithEvents denda As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents sist As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents total As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents tahun As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents simpanTambah As Button
    Friend WithEvents simpanTutup As Button
    Friend WithEvents cetakSemua As Button
    Friend WithEvents PBBbayar As CheckBox
    Friend WithEvents SISTbayar As CheckBox
End Class
