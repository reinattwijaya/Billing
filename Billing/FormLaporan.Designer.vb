<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.tanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.tipeLaporan = New System.Windows.Forms.ComboBox()
        Me.okButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.lantai1 = New System.Windows.Forms.CheckBox()
        Me.lantai2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(27, 74)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 24)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Tanggal"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(69, 102)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 24)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "s/d"
        '
        'tanggalAwal
        '
        Me.tanggalAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tanggalAwal.Location = New System.Drawing.Point(115, 71)
        Me.tanggalAwal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tanggalAwal.Name = "tanggalAwal"
        Me.tanggalAwal.Size = New System.Drawing.Size(135, 29)
        Me.tanggalAwal.TabIndex = 1
        '
        'tanggalAkhir
        '
        Me.tanggalAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tanggalAkhir.Location = New System.Drawing.Point(116, 105)
        Me.tanggalAkhir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tanggalAkhir.Name = "tanggalAkhir"
        Me.tanggalAkhir.Size = New System.Drawing.Size(133, 29)
        Me.tanggalAkhir.TabIndex = 2
        '
        'tipeLaporan
        '
        Me.tipeLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipeLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipeLaporan.FormattingEnabled = True
        Me.tipeLaporan.Items.AddRange(New Object() {"Rekap", "Pelanggan belum lunas", "Pelanggan sudah lunas", "Pelanggan aktif & non aktif", "Total pembayaran dalam periode", "Rekap PBB", "Pelanggan sudah bayar PBB", "Pelanggan belum bayar PBB"})
        Me.tipeLaporan.Location = New System.Drawing.Point(16, 28)
        Me.tipeLaporan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tipeLaporan.Name = "tipeLaporan"
        Me.tipeLaporan.Size = New System.Drawing.Size(381, 32)
        Me.tipeLaporan.TabIndex = 0
        '
        'okButton
        '
        Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Location = New System.Drawing.Point(171, 161)
        Me.okButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(100, 33)
        Me.okButton.TabIndex = 3
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(299, 160)
        Me.cancelButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(100, 33)
        Me.cancelButton.TabIndex = 4
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'lantai1
        '
        Me.lantai1.AutoSize = True
        Me.lantai1.Enabled = False
        Me.lantai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lantai1.Location = New System.Drawing.Point(299, 74)
        Me.lantai1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lantai1.Name = "lantai1"
        Me.lantai1.Size = New System.Drawing.Size(96, 28)
        Me.lantai1.TabIndex = 104
        Me.lantai1.Text = "Lantai 1"
        Me.lantai1.UseVisualStyleBackColor = True
        '
        'lantai2
        '
        Me.lantai2.AutoSize = True
        Me.lantai2.Enabled = False
        Me.lantai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lantai2.Location = New System.Drawing.Point(299, 105)
        Me.lantai2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lantai2.Name = "lantai2"
        Me.lantai2.Size = New System.Drawing.Size(96, 28)
        Me.lantai2.TabIndex = 105
        Me.lantai2.Text = "Lantai 2"
        Me.lantai2.UseVisualStyleBackColor = True
        '
        'FormLaporan
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 212)
        Me.Controls.Add(Me.lantai2)
        Me.Controls.Add(Me.lantai1)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.tipeLaporan)
        Me.Controls.Add(Me.tanggalAkhir)
        Me.Controls.Add(Me.tanggalAwal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tanggalAwal As DateTimePicker
    Friend WithEvents tanggalAkhir As DateTimePicker
    Friend WithEvents tipeLaporan As ComboBox
    Friend WithEvents okButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents lantai1 As CheckBox
    Friend WithEvents lantai2 As CheckBox
End Class
