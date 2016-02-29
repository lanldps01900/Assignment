<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSoThoai = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.bntXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKH
        '
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(26, 187)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(464, 150)
        Me.dgvKH.TabIndex = 18
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(86, 120)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(163, 20)
        Me.txtDiaChi.TabIndex = 13
        '
        'txtSoThoai
        '
        Me.txtSoThoai.Location = New System.Drawing.Point(86, 93)
        Me.txtSoThoai.Name = "txtSoThoai"
        Me.txtSoThoai.Size = New System.Drawing.Size(163, 20)
        Me.txtSoThoai.TabIndex = 14
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(86, 68)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(163, 20)
        Me.txtNgaySinh.TabIndex = 15
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(86, 44)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(163, 20)
        Me.txtTenKH.TabIndex = 16
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(86, 21)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(163, 20)
        Me.txtMaKH.TabIndex = 17
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(391, 154)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(99, 27)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(269, 154)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(99, 27)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'bntXoa
        '
        Me.bntXoa.Location = New System.Drawing.Point(150, 154)
        Me.bntXoa.Name = "bntXoa"
        Me.bntXoa.Size = New System.Drawing.Size(99, 27)
        Me.bntXoa.TabIndex = 11
        Me.bntXoa.Text = "Xóa"
        Me.bntXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(26, 154)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(99, 27)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(23, 123)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Địa Chỉ :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(23, 96)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Số ĐT :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(23, 71)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(62, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Ngày Sinh :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(23, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Tên KH :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(23, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Mã KH :"
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.lanldps01900.My.Resources.Resources.galaxy_s3_wallpaper_1920x1080
        Me.ClientSize = New System.Drawing.Size(535, 346)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtSoThoai)
        Me.Controls.Add(Me.txtNgaySinh)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.bntXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmKhachHang"
        Me.Text = "QL Khách hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgvKH As System.Windows.Forms.DataGridView
    Private WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Private WithEvents txtSoThoai As System.Windows.Forms.TextBox
    Private WithEvents txtNgaySinh As System.Windows.Forms.TextBox
    Private WithEvents txtTenKH As System.Windows.Forms.TextBox
    Private WithEvents txtMaKH As System.Windows.Forms.TextBox
    Private WithEvents btnThoat As System.Windows.Forms.Button
    Private WithEvents btnSua As System.Windows.Forms.Button
    Private WithEvents bntXoa As System.Windows.Forms.Button
    Private WithEvents btnThem As System.Windows.Forms.Button
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
