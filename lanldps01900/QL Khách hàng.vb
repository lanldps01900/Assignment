Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKhachHang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=lanldps01900.mssql.somee.com;packet size=4096;user id=lanfix113_SQLLogin_1;pwd=fl5a17ibrj;data source=lanldps01900.mssql.somee.com;persist security info=False;initial catalog=lanldps01900"
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connection As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KhachHang values(@MaKH,@TenKH,@NgaySinh,@SoThoai,@DiaChi)"
        Dim save As SqlCommand = New SqlCommand(query, connection)
        connection.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập MKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập TKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenKH.Focus()
                    If txtNgaySinh.Text = "" Then
                        MessageBox.Show("Bạn chưa NS", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNgaySinh.Focus()
                        If txtSoThoai.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập ST", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                            save.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                            save.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text)
                            save.Parameters.AddWithValue("@SoThoai", txtSoThoai.Text)
                            save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Thêm thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaKH.Text = Nothing
                            txtTenKH.Text = Nothing
                            txtNgaySinh.Text = Nothing
                            txtSoThoai.Text = Nothing
                            txtDiaChi.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select KhachHang.MaKH as 'Mã khách hàng',KhachHang.TenKH as 'Tên khách hàng', KhachHang.NgaySinh as 'NgaySinh', KhachHang.SoDT as 'Số Thoại',KhachHang.DiaChi as 'Địa Chỉ' from KhachHang ", connection)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", conn)

        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select KhachHang.MaKH as 'Mã khách hàng',KhachHang.TenKH as 'Tên khách hàng', KhachHang.NgaySinh as 'NgaySinh', KhachHang.SoDT as 'Số Thoại',KhachHang.DiaChi as 'Địa Chỉ' from KhachHang ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim click As Integer = dgvKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvKH.Item(0, click).Value
        txtTenKH.Text = dgvKH.Item(1, click).Value
        txtNgaySinh.Text = dgvKH.Item(2, click).Value
        txtSoThoai.Text = dgvKH.Item(3, click).Value
        txtDiaChi.Text = dgvKH.Item(4, click).Value
    End Sub

    Private Sub bntXoa_Click(sender As Object, e As EventArgs) Handles bntXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim delquery As String = "delete from KhachHang where MaKH=@MaKH delete from KhachHang where MaKH=@MaKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMaKH.Text = Nothing
                    txtTenKH.Text = Nothing
                    txtNgaySinh.Text = Nothing
                    txtNgaySinh.Text = Nothing
                    txtSoThoai.Text = Nothing
                    txtDiaChi.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập Sai", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select KhachHang.MaKH as 'Mã khách hàng',KhachHang.TenKH as 'Tên khách hàng', KhachHang.NgaySinh as 'NgaySinh', KhachHang.SoDT as 'Số Thoại',KhachHang.DiaChi as 'Địa Chỉ' from KhachHang ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KhachHang set MaKH=@MaKH, TenKH=@TenKH, NgaySinh=@NgaySinh,SoDT=@SoDT,DiaChi=@DiaChi where MaKH=@MaKH "
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenKH.Focus()
                    If txtNgaySinh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Nuoc SX", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNgaySinh.Focus()
                        If txtSoThoai.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else

                        End If
                    End If
                    addupdate.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                    addupdate.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                    addupdate.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text)
                    addupdate.Parameters.AddWithValue("@SoDT", txtSoThoai.Text)
                    addupdate.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                    addupdate.ExecuteNonQuery()
                    conn.Close() 'đóng kết nối
                    MessageBox.Show("Sữa thành công")
                    txtMaKH.Text = Nothing
                    txtTenKH.Text = Nothing
                    txtNgaySinh.Text = Nothing
                    txtSoThoai.Text = Nothing
                    txtDiaChi.Text = Nothing
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select KhachHang.MaKH as 'Mã khách hàng',KhachHang.TenKH as 'Tên khách hàng', KhachHang.NgaySinh as 'NgaySinh', KhachHang.SoDT as 'Số Thoại',KhachHang.DiaChi as 'Địa Chỉ' from KhachHang ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub
End Class