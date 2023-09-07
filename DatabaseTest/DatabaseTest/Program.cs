using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // SQL Server 연결 문자열 (본인의 데이터베이스 정보로 변경)
        string connectionString = "Server=서버주소;Database=데이터베이스이름;User Id=사용자이름;Password=패스워드;";

        // SqlConnection 객체 생성
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // 데이터베이스 연결 열기
                connection.Open();

                // SQL 쿼리 실행
                string sqlQuery = "SELECT * FROM YourTable"; // YourTable은 실제 데이터베이스 테이블 이름으로 변경
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                // 데이터 읽기
                while (reader.Read())
                {
                    Console.WriteLine($"Column1: {reader["Column1"]}, Column2: {reader["Column2"]}");
                }

                // 연결 닫기
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 오류: " + ex.Message);
            }
        }
    }
}
