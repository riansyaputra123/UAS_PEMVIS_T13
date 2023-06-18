<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtWaktu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHari = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtKodeHexa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(867, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.txtWaktu)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtHari)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 65)
        Me.Panel1.TabIndex = 1
        '
        'txtWaktu
        '
        Me.txtWaktu.AutoSize = True
        Me.txtWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaktu.Location = New System.Drawing.Point(563, 33)
        Me.txtWaktu.Name = "txtWaktu"
        Me.txtWaktu.Size = New System.Drawing.Size(47, 18)
        Me.txtWaktu.TabIndex = 5
        Me.txtWaktu.Text = "waktu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Image Encryption"
        '
        'txtHari
        '
        Me.txtHari.AutoSize = True
        Me.txtHari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHari.Location = New System.Drawing.Point(329, 33)
        Me.txtHari.Name = "txtHari"
        Me.txtHari.Size = New System.Drawing.Size(83, 18)
        Me.txtHari.TabIndex = 4
        Me.txtHari.Text = "hari/tanggal"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.btnDownload)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnStart)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtKey)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtResult)
        Me.Panel2.Controls.Add(Me.txtKodeHexa)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnBrowse)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(928, 614)
        Me.Panel2.TabIndex = 2
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDownload.Enabled = False
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDownload.Location = New System.Drawing.Point(566, 497)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(145, 46)
        Me.btnDownload.TabIndex = 17
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.Enabled = False
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(751, 497)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 46)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.SteelBlue
        Me.btnStart.Enabled = False
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStart.Location = New System.Drawing.Point(384, 497)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(145, 46)
        Me.btnStart.TabIndex = 15
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(377, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 37)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Encryption Key"
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.Color.GhostWhite
        Me.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKey.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(384, 396)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(512, 42)
        Me.txtKey.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(377, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(349, 37)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hexa Code (Encryption)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(377, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 37)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hexa Code (Description)"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.LightGray
        Me.txtResult.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtResult.Enabled = False
        Me.txtResult.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(384, 182)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(512, 42)
        Me.txtResult.TabIndex = 10
        '
        'txtKodeHexa
        '
        Me.txtKodeHexa.BackColor = System.Drawing.Color.LightGray
        Me.txtKodeHexa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtKodeHexa.Enabled = False
        Me.txtKodeHexa.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeHexa.Location = New System.Drawing.Point(384, 69)
        Me.txtKodeHexa.Name = "txtKodeHexa"
        Me.txtKodeHexa.ReadOnly = True
        Me.txtKodeHexa.Size = New System.Drawing.Size(512, 42)
        Me.txtKodeHexa.TabIndex = 9
        Me.txtKodeHexa.Text = "#0123456789ABCDEF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(99, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Browse Image"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBrowse.Location = New System.Drawing.Point(104, 497)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(145, 46)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(29, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(326, 402)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(952, 709)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtWaktu As Label
    Friend WithEvents txtHari As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnBrowse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtKodeHexa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKey As TextBox
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnStart As Button
End Class
