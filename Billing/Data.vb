Imports System.Data.OleDb
Imports System.IO

Public Class Data

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As New DataTable()

    Public kode As String

    Private Function Check() As Boolean
        Dim ret As Boolean
        If String.IsNullOrEmpty(noCustomer.Text) Then
            MsgBox("Nomor Customer tidak boleh kosong", MsgBoxStyle.Exclamation, "Data")
            ret = 1
            noCustomer.Focus()
        ElseIf String.IsNullOrEmpty(nama.Text) Then
            MsgBox("Nama tidak boleh kosong", MsgBoxStyle.Exclamation, "Data")
            ret = 1
            nama.Focus()
        ElseIf CheckDataBase() Then
            MsgBox("Nomor customer sudah ada, gunakan yang lain", MsgBoxStyle.Information)
            ret = 1
            noCustomer.Focus()
        Else
            ret = 0
        End If

        Return ret
    End Function

    Private Sub Add()
        Dim sql As String = "INSERT INTO customerDB(NoCustomer, KodeTempat, Nama, HP, Email, SewaAwal, SewaAkhir, Alamat, NIK, KeyBCA, Luas, NoKios, Lantai, NonAktif, Modal, NPWP, Pajak, SaldoPBB) VALUES (@NoCustomer, @KodeTempat, @Nama, @HP, @Email, @SewaAwal, @SewaAkhir, @Alamat, @NIK, @KeyBCA, @Luas, @NoKios, @Lantai, @NonAktif, @Modal, @NPWP, @Pajak, @SaldoPBB)"
        cmd = New OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
        cmd.Parameters.AddWithValue("@KodeTempat", kodetempat.Text)
        cmd.Parameters.AddWithValue("@Nama", nama.Text)
        cmd.Parameters.AddWithValue("@HP", hp.Text)
        cmd.Parameters.AddWithValue("@Email", email.Text)
        cmd.Parameters.Add(New OleDbParameter("@SewaAwal", OleDbType.DBDate))
        cmd.Parameters("@SewaAwal").Value = sewaAwal.Value
        cmd.Parameters.Add(New OleDbParameter("@SewaAkhir", OleDbType.DBDate))
        cmd.Parameters("@SewaAkhir").Value = sewaAkhir.Value
        'cmd.Parameters.AddWithValue("@SewaAwal", sewaAwal.Value)
        'cmd.Parameters.AddWithValue("@SewaAkhir", sewaAkhir.Value)
        cmd.Parameters.AddWithValue("@Alamat", alamat.Text)
        cmd.Parameters.AddWithValue("@NIK", nik.Text)
        cmd.Parameters.AddWithValue("@KeyBCA", keyBCA.Text)
        cmd.Parameters.Add("@Luas", OleDbType.VarChar)
        cmd.Parameters("@Luas").Value = luas.Value
        cmd.Parameters.AddWithValue("@NoKios", noKios.Text)
        cmd.Parameters.AddWithValue("@Lantai", lantai.Text)
        cmd.Parameters.AddWithValue("@NonAktif", nonAktif.Checked)
        cmd.Parameters.AddWithValue("@Modal", modal.Value)
        cmd.Parameters.AddWithValue("@NPWP", NPWP.Text)
        cmd.Parameters.AddWithValue("@Pajak", customerPajak.Checked)
        cmd.Parameters.AddWithValue("@SaldoPBB", saldoPBB.Value)

        Try
            con.Open()

            If cmd.ExecuteNonQuery() > 0 Then
                'MsgBox("Tambah berhasil!", MsgBoxStyle.Information, "Insert")
                cleartxt()
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try

        Customer.button.PerformClick()

    End Sub

    Public Function CheckDataBase() As Boolean
        con.Open()
        Dim SelectQry = "SELECT NoCustomer FROM customerDB WHERE NoCustomer=@NoCustomer"
        Dim ret As Boolean
        ret = 0
        Try
            Dim SampleCommand, SampleCommand2 As New OleDbCommand()
            SampleCommand.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = con
            Dim reader As OleDbDataReader
            reader = SampleCommand.ExecuteReader
            If reader.Read() Then
                ret = 1
            End If

        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        con.Close()
        Return ret
    End Function

    Private Sub cleartxt()
        noCustomer.Text = ""
        kodetempat.Text = ""
        nama.Text = ""
        hp.Text = ""
        email.Text = ""
        sewaAwal.Value = Now
        sewaAkhir.Value = Now
        alamat.Text = ""
        nik.Text = ""
        keyBCA.Text = ""
        luas.Value = 0
        noKios.Text = ""
        lantai.Text = ""
        nonAktif.Checked = 0
        modal.Value = 0
        customerPajak.Checked = 0
        NPWP.Text = ""
        saldoPBB.Value = 0
    End Sub

    Private Sub UpdateDB(name As String)

        Dim sql As String = "UPDATE customerDB SET NoCustomer=@NoCustomer, KodeTempat=@KodeTempat, Nama=@Nama, HP=@HP, Email=@Email, SewaAwal=@SewaAwal, SewaAkhir= @SewaAkhir, Alamat=@Alamat, NIK= @NIK, KeyBCA=@KeyBCA, Luas= @Luas, NoKios=@NoKios, Lantai=@Lantai,  NonAktif= @NonAktif, Modal=@Modal, NPWP=@NPWP, Pajak=@Pajak, SaldoPBB=@SaldoPBB  WHERE NoCustomer=@Kode"
        cmd = New OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
        cmd.Parameters.AddWithValue("@KodeTempat", kodetempat.Text)
        cmd.Parameters.AddWithValue("@Nama", nama.Text)
        cmd.Parameters.AddWithValue("@HP", hp.Text)
        cmd.Parameters.AddWithValue("@Email", email.Text)
        cmd.Parameters.Add(New OleDbParameter("@SewaAwal", OleDbType.DBDate))
        cmd.Parameters("@SewaAwal").Value = sewaAwal.Value
        cmd.Parameters.Add(New OleDbParameter("@SewaAkhir", OleDbType.DBDate))
        cmd.Parameters("@SewaAkhir").Value = sewaAkhir.Value
        'cmd.Parameters.AddWithValue("@SewaAwal", sewaAwal.Value)
        'cmd.Parameters.AddWithValue("@SewaAkhir", sewaAkhir.Value)
        cmd.Parameters.AddWithValue("@Alamat", alamat.Text)
        cmd.Parameters.AddWithValue("@NIK", nik.Text)
        cmd.Parameters.AddWithValue("@KeyBCA", keyBCA.Text)
        cmd.Parameters.Add("@Luas", OleDbType.VarChar)
        cmd.Parameters("@Luas").Value = luas.Value

        cmd.Parameters.AddWithValue("@NoKios", noKios.Text)
        cmd.Parameters.AddWithValue("@Lantai", lantai.Text)
        cmd.Parameters.AddWithValue("@NonAktif", nonAktif.Checked)
        cmd.Parameters.AddWithValue("@Modal", modal.Value)
        cmd.Parameters.AddWithValue("@NPWP", NPWP.Text)
        cmd.Parameters.AddWithValue("@Pajak", customerPajak.Checked)
        cmd.Parameters.AddWithValue("@SaldoPBB", saldoPBB.Value)
        cmd.Parameters.AddWithValue("@Kode", name)


        Try
            con.Open()

            If cmd.ExecuteNonQuery() > 0 Then
                'MsgBox("Update berhasil!", MsgBoxStyle.Information, "Update")
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try

        Customer.button.PerformClick()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If String.IsNullOrEmpty(noCustomer.Text) Then
            MsgBox("Nomor Customer tidak boleh kosong", MsgBoxStyle.Exclamation, "Data")
            noCustomer.Focus()
        ElseIf String.IsNullOrEmpty(nama.Text) Then
            MsgBox("Nama tidak boleh kosong", MsgBoxStyle.Exclamation, "Data")
            nama.Focus()
        Else
            UpdateDB(kode)
            Me.Close()
        End If

    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        If Check() Then

        Else
            Add()
            Me.Close()
        End If

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub berikutTambah_Click(sender As Object, e As EventArgs) Handles berikutTambah.Click
        If Check() Then

        Else
            Add()
        End If
    End Sub

    Private Sub berikutUpdate_Click(sender As Object, e As EventArgs) Handles berikutUpdate.Click
        If String.IsNullOrEmpty(noCustomer.Text) Then
            MsgBox("Nomor Customer tidak boleh kosong", MsgBoxStyle.Exclamation, "Data")
            noCustomer.Focus()
        ElseIf String.IsNullOrEmpty(nama.Text) Then
            MsgBox("Nama tidak boleh kosong", MsgBoxStyle.Exclamation, "Data")
            nama.Focus()
        Else
            UpdateDB(kode)
            cleartxt()
        End If

    End Sub

    Private Sub Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modal.Controls.RemoveAt(0)
        luas.Controls.RemoveAt(0)
        saldoPBB.Controls.RemoveAt(0)
    End Sub

End Class