<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtNuocSX = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSP
        '
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(12, 188)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.Size = New System.Drawing.Size(529, 152)
        Me.dgvSP.TabIndex = 18
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(335, 155)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(90, 29)
        Me.btnThoat.TabIndex = 14
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(225, 155)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(90, 29)
        Me.btnSua.TabIndex = 15
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(120, 155)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(90, 29)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(12, 155)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(90, 29)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(76, 116)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(249, 20)
        Me.txtDonGia.TabIndex = 9
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(76, 88)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(249, 20)
        Me.txtSoLuong.TabIndex = 10
        '
        'txtNuocSX
        '
        Me.txtNuocSX.Location = New System.Drawing.Point(76, 60)
        Me.txtNuocSX.Name = "txtNuocSX"
        Me.txtNuocSX.Size = New System.Drawing.Size(249, 20)
        Me.txtNuocSX.TabIndex = 11
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(76, 33)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(249, 20)
        Me.txtTenSP.TabIndex = 12
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(76, 6)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(249, 20)
        Me.txtMaSP.TabIndex = 13
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 119)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(50, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Đơn giá :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 91)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(55, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Số lượng :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 63)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Nước SX :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 36)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(49, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Tên SP :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(45, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Mã SP :"
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.lanldps01900.My.Resources.Resources.ios_7_galaxy_wallpaper_1366x768
        Me.ClientSize = New System.Drawing.Size(558, 342)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtNuocSX)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmSanPham"
        Me.Text = "QL Sản phẩm"
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgvSP As System.Windows.Forms.DataGridView
    Private WithEvents btnThoat As System.Windows.Forms.Button
    Private WithEvents btnSua As System.Windows.Forms.Button
    Private WithEvents btnXoa As System.Windows.Forms.Button
    Private WithEvents btnThem As System.Windows.Forms.Button
    Private WithEvents txtDonGia As System.Windows.Forms.TextBox
    Private WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Private WithEvents txtNuocSX As System.Windows.Forms.TextBox
    Private WithEvents txtTenSP As System.Windows.Forms.TextBox
    Private WithEvents txtMaSP As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
