Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Dim warna As Color
    Dim img1, img2 As Bitmap
    Dim n, n1 As Int64
    Dim hasil, hasil1, kode, kode1, data, data1, newHasil, newHasil1, textHexa, textHexaHasil As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data1 = txtKodeHexa.Text
        newHasil1 = ""
        Enkripsi1()
        txtResult.Text = newHasil1
    End Sub

    Private Sub Enkripsi1()
        n1 = Len(data1)
        For l = 1 To n1
            hasil1 = Mid(data1, l, 1)
            If hasil1 <> "#" Then
                If hasil1 = "A" Then
                    hasil1 = 10
                ElseIf hasil1 = "B" Then
                    hasil1 = 11
                ElseIf hasil1 = "C" Then
                    hasil1 = 12
                ElseIf hasil1 = "D" Then
                    hasil1 = 13
                ElseIf hasil1 = "E" Then
                    hasil1 = 14
                ElseIf hasil1 = "F" Then
                    hasil1 = 15
                End If

                kode1 = (Val(hasil1) + Val(txtKey.Text)) Mod 16

                If kode1 = 10 Then
                    kode1 = "A"
                ElseIf kode1 = 11 Then
                    kode1 = "B"
                ElseIf kode1 = 12 Then
                    kode1 = "C"
                ElseIf kode1 = 13 Then
                    kode1 = "D"
                ElseIf kode1 = 14 Then
                    kode1 = "E"
                ElseIf kode1 = 15 Then
                    kode1 = "F"
                End If
            Else
                kode1 = hasil1
            End If
            newHasil1 = newHasil1 + kode1
        Next
    End Sub


    Private Sub Enkripsi()
        n = Len(data)
        For i = 1 To n
            hasil = Mid(data, i, 1)
            If hasil <> "#" Then
                If hasil = "A" Then
                    hasil = 10
                ElseIf hasil = "B" Then
                    hasil = 11
                ElseIf hasil = "C" Then
                    hasil = 12
                ElseIf hasil = "D" Then
                    hasil = 13
                ElseIf hasil = "E" Then
                    hasil = 14
                ElseIf hasil = "F" Then
                    hasil = 15
                End If

                kode = (Val(hasil) + Val(txtKey.Text)) Mod 16

                If kode = 10 Then
                    kode = "A"
                ElseIf kode = 11 Then
                    kode = "B"
                ElseIf kode = 12 Then
                    kode = "C"
                ElseIf kode = 13 Then
                    kode = "D"
                ElseIf kode = 14 Then
                    kode = "E"
                ElseIf kode = 15 Then
                    kode = "F"
                End If
            Else
                kode = hasil
            End If
            newHasil = newHasil + kode
        Next
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtKey.Text = "" Then
            MessageBox.Show("Key Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            img1 = PictureBox1.Image
            img2 = New Bitmap(img1.Width, img1.Height)

            For y = 0 To (img1.Height - 1)
                For x = 0 To (img2.Width - 1)
                    warna = img1.GetPixel(x, y)

                    textHexa = ColorTranslator.ToHtml(Color.FromArgb(warna.R, warna.G, warna.B))
                    data = textHexa
                    Enkripsi()
                    textHexaHasil = newHasil
                    warna = ColorTranslator.FromHtml(textHexaHasil)

                    img2.SetPixel(x, y, warna)
                    newHasil = ""
                Next
            Next

            PictureBox1.Image = img2

            btnBrowse.Enabled = False
            btnDownload.Enabled = True
            btnClear.Enabled = True
            btnStart.Enabled = True

            newHasil1 = ""
            data1 = txtResult.Text
            Enkripsi1()
            txtResult.Text = newHasil1
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If PictureBox1.Image IsNot Nothing Then
            SaveFileDialog1.Filter = "PNG Image|*.png"
            SaveFileDialog1.Title = "Downloading Encryption Image"
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim savePath As String = SaveFileDialog1.FileName
                PictureBox1.Image.Save(savePath)
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        PictureBox1.Image = Nothing
        txtKey.Text = ""
        txtResult.Text = ""
        btnDownload.Enabled = False
        btnClear.Enabled = False
        btnStart.Enabled = False
        btnBrowse.Enabled = True
        data1 = txtKodeHexa.Text
        newHasil1 = ""
        Enkripsi1()
        txtResult.Text = newHasil1
    End Sub


    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Crimson
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtHari.Text = Format(Now, "dddd dd MMMM yyyy")
        txtWaktu.Text = Format(Now, "hh:mm:ss")
    End Sub

    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub FormInput_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub FormInput_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Images Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Gambar yang akan di Enkripsi"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim imagePath As String = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(imagePath)
            btnClear.Enabled = True
            btnStart.Enabled = True
            btnDownload.Enabled = False
            btnBrowse.Enabled = False
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub txtKey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKey.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
