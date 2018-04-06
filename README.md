# QuanLyDangKyHocPhan

Đây là phần mềm ứng dụng đăng ký học phần.

** Kết nối db: 
Step 1: Tools -> connect to Database
Step 2: Chọn Microsoft SQL Server
Step 3: Trong ô Select name: gõ dấu "." -> Tới ô Select or enter a database name -> Chọn db cần kết nối -> OK
Step 4: Sau khi kết nối thành công, chọn vào db đó để hiển thị properties -> Copy toàn bộ dữ liệu "Data Source=.;Initial Catalog=db_QuanLyDangKyHocPhan;Integrated Security=True" 
trong connectionStrings và paste vào trong dòng lệnh trong file app.config bên dưới
	<connectionStrings>
		<add connectionString="Data Source=.;Initial Catalog=db_QuanLyDangKyHocPhan;Integrated Security=True" name="connectionSQL"></add>
    </connectionStrings>

** Click chuột phải vào references -> add references -> framework -> Chọn System.Configuration -> OK