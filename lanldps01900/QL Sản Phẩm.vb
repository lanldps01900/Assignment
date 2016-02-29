Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=lanldps01900.mssql.somee.com;packet size=4096;user id=lanfix113_SQLLogin_1;pwd=fl5a17ibrj;data source=lanldps01900.mssql.somee.com;persist security info=False;initial catalog=lanldps01900"
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", conn)

        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã sản phẩm',SanPham.TenSP as 'Tên sản phẩm', SanPham.NuocSX as 'Nước SX', SanPham.SoLuong as 'Số Lượng',SanPham.DonGia as 'Đơn Giá' from SanPham ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSP.DataSource = db.DefaultView




    End Sub

    Private Sub dgvSP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSP.CellContentClick
        Dim click As Integer = dgvSP.CurrentCell.RowIndex
        txtMaSP.Text = dgvSP.Item(0, click).Value
        txtTenSP.Text = dgvSP.Item(1, click).Value
        txtNuocSX.Text = dgvSP.Item(2, click).Value
        txtSoLuong.Text = dgvSP.Item(3, click).Value
        txtDonGia.Text = dgvSP.Item(4, click).Value
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connection As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SanPham values(@MaSP,@TenSP,@NuocSX,@SoLuong,@DonGia)"
        Dim save As SqlCommand = New SqlCommand(query, connection)
        connection.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenSP.Focus()
                    If txtNuocSX.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập NSX", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNuocSX.Focus()
                        If txtSoLuong.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                            save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
                            save.Parameters.AddWithValue("@NuocSX", txtNuocSX.Text)
                            save.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
                            save.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Thêm thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaSP.Text = Nothing
                            txtNuocSX.Text = Nothing
                            txtSoLuong.Text = Nothing
                            txtTenSP.Text = Nothing
                            txtDonGia.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã sản phẩm',SanPham.TenSP as 'Tên sản phẩm', SanPham.NuocSX as 'Nước SX', SanPham.SoLuong as 'Số Lượng',SanPham.DonGia as 'Đơn Giá' from SanPham ", connection)
        db.Clear()
        refesh.Fill(db)
        dgvSP.DataSource = db.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connection As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim delquery As String = "delete from SanPham where MaSP=@MaSP delete from SanPham where MaSP=@MaSP"
        Dim delete As SqlCommand = New SqlCommand(delquery, connection)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        connection.Open()
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaSP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                    delete.ExecuteNonQuery()
                    connection.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMaSP.Text = Nothing
                    txtTenSP.Text = Nothing
                    txtNuocSX.Text = Nothing
                    txtSoLuong.Text = Nothing
                    txtDonGia.Text = Nothing
                    txtMaSP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã sản phẩm',SanPham.TenSP as 'Tên sản phẩm', SanPham.NuocSX as 'Nước SX', SanPham.SoLuong as 'Số Lượng',SanPham.DonGia as 'Đơn Giá' from SanPham ", connection)
        db.Clear()
        refesh.Fill(db)
        dgvSP.DataSource = db.DefaultView
    End Sub
   


    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim connection As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SanPham set MaSP=@MaSP, TenSP=@TenSP, NuocSX=@NuocSX,SoLuong=@SoLuong,DonGia=@DonGia where MaSP=@MaSP "
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, connection)
        connection.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenSP.Focus()
                    If txtNuocSX.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Nuoc SX", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNuocSX.Focus()
                        If txtSoLuong.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                           
                            End If
                        End If
                        addupdate.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                        addupdate.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
                        addupdate.Parameters.AddWithValue("@NuocSX", txtNuocSX.Text)
                        addupdate.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
                        addupdate.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
                        addupdate.ExecuteNonQuery()
                    connection.Close() 'đóng kết nối
                        MessageBox.Show("Sữa thành công")
                        txtMaSP.Text = Nothing
                        txtTenSP.Text = Nothing
                        txtNuocSX.Text = Nothing
                        txtDonGia.Text = Nothing
                        txtSoLuong.Text = Nothing
                        End If
                    End If


        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã sản phẩm',SanPham.TenSP as 'Tên sản phẩm', SanPham.NuocSX as 'Nước SX', SanPham.SoLuong as 'Số Lượng',SanPham.DonGia as 'Đơn Giá' from SanPham ", connection)
        db.Clear()
        refesh.Fill(db)
        dgvSP.DataSource = db.DefaultView
    End Sub


    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class
