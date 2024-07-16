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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.rbl = New System.Windows.Forms.RadioButton()
        Me.rbp = New System.Windows.Forms.RadioButton()
        Me.txtlahir = New System.Windows.Forms.TextBox()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.Dgtampil = New System.Windows.Forms.DataGridView()
        CType(Me.Dgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA KARYAWAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No HP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Alamat"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(190, 81)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(205, 20)
        Me.txtid.TabIndex = 8
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(190, 119)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(205, 20)
        Me.txtnama.TabIndex = 9
        '
        'rbl
        '
        Me.rbl.AutoSize = True
        Me.rbl.Location = New System.Drawing.Point(190, 159)
        Me.rbl.Name = "rbl"
        Me.rbl.Size = New System.Drawing.Size(68, 17)
        Me.rbl.TabIndex = 10
        Me.rbl.TabStop = True
        Me.rbl.Text = "Laki Laki"
        Me.rbl.UseVisualStyleBackColor = True
        '
        'rbp
        '
        Me.rbp.AutoSize = True
        Me.rbp.Location = New System.Drawing.Point(322, 159)
        Me.rbp.Name = "rbp"
        Me.rbp.Size = New System.Drawing.Size(79, 17)
        Me.rbp.TabIndex = 11
        Me.rbp.TabStop = True
        Me.rbp.Text = "Perempuan"
        Me.rbp.UseVisualStyleBackColor = True
        '
        'txtlahir
        '
        Me.txtlahir.Location = New System.Drawing.Point(190, 197)
        Me.txtlahir.Name = "txtlahir"
        Me.txtlahir.Size = New System.Drawing.Size(205, 20)
        Me.txtlahir.TabIndex = 12
        '
        'dtplahir
        '
        Me.dtplahir.Location = New System.Drawing.Point(190, 243)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(200, 20)
        Me.dtplahir.TabIndex = 13
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(190, 285)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(205, 20)
        Me.txtnohp.TabIndex = 14
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(190, 332)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(318, 57)
        Me.txtalamat.TabIndex = 15
        '
        'cmdtambah
        '
        Me.cmdtambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdtambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdtambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdtambah.Location = New System.Drawing.Point(48, 415)
        Me.cmdtambah.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(87, 38)
        Me.cmdtambah.TabIndex = 16
        Me.cmdtambah.Text = "TAMBAH"
        Me.cmdtambah.UseVisualStyleBackColor = False
        '
        'cmdsimpan
        '
        Me.cmdsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdsimpan.Location = New System.Drawing.Point(157, 415)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(87, 38)
        Me.cmdsimpan.TabIndex = 17
        Me.cmdsimpan.Text = "SIMPAN"
        Me.cmdsimpan.UseVisualStyleBackColor = False
        '
        'cmdbatal
        '
        Me.cmdbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdbatal.Location = New System.Drawing.Point(266, 415)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(87, 38)
        Me.cmdbatal.TabIndex = 18
        Me.cmdbatal.Text = "BATAL"
        Me.cmdbatal.UseVisualStyleBackColor = False
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdupdate.Location = New System.Drawing.Point(371, 415)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(87, 38)
        Me.cmdupdate.TabIndex = 19
        Me.cmdupdate.Text = "UPDATE"
        Me.cmdupdate.UseVisualStyleBackColor = False
        '
        'cmdhapus
        '
        Me.cmdhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdhapus.Location = New System.Drawing.Point(474, 415)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(87, 38)
        Me.cmdhapus.TabIndex = 20
        Me.cmdhapus.Text = "HAPUS"
        Me.cmdhapus.UseVisualStyleBackColor = False
        '
        'cmdkeluar
        '
        Me.cmdkeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdkeluar.Location = New System.Drawing.Point(581, 415)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(87, 38)
        Me.cmdkeluar.TabIndex = 21
        Me.cmdkeluar.Text = "KELUAR"
        Me.cmdkeluar.UseVisualStyleBackColor = False
        '
        'Dgtampil
        '
        Me.Dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgtampil.Location = New System.Drawing.Point(48, 486)
        Me.Dgtampil.Name = "Dgtampil"
        Me.Dgtampil.Size = New System.Drawing.Size(642, 191)
        Me.Dgtampil.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 689)
        Me.Controls.Add(Me.Dgtampil)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.dtplahir)
        Me.Controls.Add(Me.txtlahir)
        Me.Controls.Add(Me.rbp)
        Me.Controls.Add(Me.rbl)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Dgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents rbl As RadioButton
    Friend WithEvents rbp As RadioButton
    Friend WithEvents txtlahir As TextBox
    Friend WithEvents dtplahir As DateTimePicker
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents cmdtambah As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdbatal As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmdhapus As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents Dgtampil As DataGridView
End Class
