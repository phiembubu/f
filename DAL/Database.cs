using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Net.NetworkInformation;


namespace DAL
{
    public class Connect
    {
        public static SqlConnection Connection()
        {

            string str = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(str);
            return con;

            return null;
        }
    }

    public class Database
    {
        public static string loginDatabase(TaiKhoanDTO taiKhoanDTO)
        {
            string user = null;

            SqlConnection con = Connect.Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tk", taiKhoanDTO.Tk);
            cmd.Parameters.AddWithValue("@mk", taiKhoanDTO.Mk);

            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                con.Close();

            }
            else
            {
                return "Sai tai khoan hoac mat khau";
            }
            return user;
        }
        public static string thempDatabase(PhongDTO phongDTO)
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("themp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tp", phongDTO.TenPhong);
            cmd.Parameters.AddWithValue("@gp", phongDTO.GiaPhong);
            cmd.Parameters.AddWithValue("@tt", phongDTO.TinhTrang);

            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            return "Them thanh cong";
        }
        public static string themhdDatabase(PhongDTO phongDTO)
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("themhopdong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tp", phongDTO.TenPhong);
            cmd.Parameters.AddWithValue("@tn", phongDTO.TienNo);
            cmd.Parameters.AddWithValue("@tk", phongDTO.TenKhach);
            cmd.Parameters.AddWithValue("@nthue", phongDTO.NgayThue);
            cmd.Parameters.AddWithValue("@ntra", phongDTO.NgayTra);
            cmd.Parameters.AddWithValue("@cccd", phongDTO.Cccd);

            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            return "Them thanh cong";
        }
        public static string suapDatabase(PhongDTO phongDTO,int id)
        {

            SqlConnection con = Connect.Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("suap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tp", phongDTO.TenPhong);
            cmd.Parameters.AddWithValue("@gp", phongDTO.GiaPhong);
            cmd.Parameters.AddWithValue("@tt", phongDTO.TinhTrang);
            cmd.Parameters.AddWithValue("@tk", phongDTO.TenKhach);
            cmd.Parameters.AddWithValue("@tn", phongDTO.TienNo);
            cmd.Parameters.AddWithValue("@nthue", phongDTO.NgayThue);
            cmd.Parameters.AddWithValue("@ntra", phongDTO.NgayTra);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            return "Sua thanh cong";
        }

        public static string themcsvcDatabase(csvcDTO csvtDTO)
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("themcsvt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tencsvc", csvtDTO.TenCSVC);
            cmd.Parameters.AddWithValue("@tinhtrangcsvc", csvtDTO.TinhtrangCSVC);
            cmd.Parameters.AddWithValue("@tp", csvtDTO.Tenphong);

            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            return "Them thanh cong";
        }
        public static string suacsvcDatabase(csvcDTO csvtDTO)
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("suacsvt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tencsvc", csvtDTO.TenCSVC);
            cmd.Parameters.AddWithValue("@tinhtrangcsvc", csvtDTO.TinhtrangCSVC);
            cmd.Parameters.AddWithValue("@tp", csvtDTO.Tenphong);
            cmd.Parameters.AddWithValue("@id", csvtDTO.Idcsvc);

            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            return "Them thanh cong";
        }
        public static void xoacsvcDatabase(csvcDTO csvcDTO)
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            string t = string.Format("DELETE FROM CSVC WHERE IDCSVC = '{0}';", csvcDTO.Idcsvc);
            SqlCommand cmd = new SqlCommand(t, con);


            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
        }public static void xoapDatabase (string id)
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            string t = string.Format("DELETE FROM  WHERE IDCSVC = '{0}';", id);
            SqlCommand cmd = new SqlCommand(t, con);


            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
        }

        public static void xoadvDatabase(dvDTO dvDTO)
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            string t = string.Format("DELETE FROM ChiTietDV WHERE idThue = '{0}';", dvDTO.IdThue);
            SqlCommand cmd = new SqlCommand(t, con);


            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
        }
        public static void xoahdDatabase(string mhd)
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            string t = string.Format("DELETE FROM HoaDon WHERE maHoaDon = {0};", mhd);
            SqlCommand cmd = new SqlCommand(t, con);


            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
        }
        public static void xoakDatabase(string idk) 
        {


            SqlConnection con = Connect.Connection();
            con.Open();
            string t = string.Format("DELETE FROM KhachThue WHERE IDKhach = {0};", idk);
            SqlCommand cmd = new SqlCommand(t, con);


            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
        }


        public static string themkDatabase(khachDTO khachDTO)
        {

            try
            {
                SqlConnection con = Connect.Connection();
                con.Open();
                SqlCommand cmd = new SqlCommand("themkhach", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cccd", khachDTO.Cccd);
                cmd.Parameters.AddWithValue("@ten", khachDTO.Tenkhach);
                cmd.Parameters.AddWithValue("@sdt", khachDTO.Sdt);
                cmd.Parameters.AddWithValue("@diachi", khachDTO.Diachi);
                cmd.Parameters.AddWithValue("@gioitinh", khachDTO.Gioitinh);
                cmd.Parameters.AddWithValue("@nghenghiep", khachDTO.Nghenghiep);


                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                return "Them thanh cong";
        }
            catch (Exception ex) { return ex + " \n THEM THAT BAI !!!"; }
}
        public static string suakDatabase(khachDTO khachDTO, int idk)
        {
            try
            {
                SqlConnection con = Connect.Connection();
                con.Open();
                SqlCommand cmd = new SqlCommand("suakhach", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cccd", khachDTO.Cccd);
                cmd.Parameters.AddWithValue("@ten", khachDTO.Tenkhach);
                cmd.Parameters.AddWithValue("@sdt", khachDTO.Sdt);
                cmd.Parameters.AddWithValue("@diachi", khachDTO.Diachi);
                cmd.Parameters.AddWithValue("@gioitinh", khachDTO.Gioitinh);
                cmd.Parameters.AddWithValue("@nghenghiep", khachDTO.Nghenghiep);
                cmd.Parameters.AddWithValue("@idk", idk);


                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                return "Sua thanh cong";
            }
            catch (Exception ex) { return ex + " \n SUA THAT BAI !!!"; }
        }

        public static List<string> loadCombobox()
        {
            List<string> dataList = new List<string>();
            SqlConnection con = Connect.Connection();
            con.Open();
            string strcmd = "select tenPhong from Phong ";
            SqlCommand cmd = new SqlCommand(strcmd, con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataList.Add(reader.GetString(0));

            }
            reader.Close();
            con.Close();

            return dataList;
        }
        public static List<string> loadComboboxhd()
        {
            List<string> dataList = new List<string>();
            SqlConnection con = Connect.Connection();
            con.Open();
            string strcmd = "select DISTINCT tenPhong from ChiTietDV";
            SqlCommand cmd = new SqlCommand(strcmd, con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataList.Add(reader.GetString(0));

            }
            reader.Close();
            con.Close();

            return dataList;
        }

        public static string[] tienDV(string phong)
        {
            string[] dataList = new string[3];
            SqlConnection con = Connect.Connection();
            con.Open();
            string strcmd = "select tienDien, tienNuoc, tienWifi from ChiTietDV where tenPhong ='" + phong + "'";
            SqlCommand cmd = new SqlCommand(strcmd, con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataList[0] = (reader.GetInt32(0)).ToString();
                dataList[1] = (reader.GetInt32(1)).ToString();
                dataList[2] = (reader.GetInt32(2)).ToString();

            }
            reader.Close();
            con.Close();

            return dataList;
        }
        public static string layidthueDatabase(string phong)
        {
            string idthue;
            SqlConnection con = Connect.Connection();
            con.Open();
            string strcmd = "select idThue from ThuePhong where tenPhong ='" + phong + "'";
            SqlCommand cmd = new SqlCommand(strcmd, con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            idthue = (reader.GetInt32(0)).ToString();
            reader.Close();
            con.Close();

            return idthue;
        }

        public static string lhdDatabase(hdDTO hdDTO)
        {
            SqlConnection con = Connect.Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("themhd", con);
            string ngay = string.Format("{0}-{1}-{2}", hdDTO.NgayLap.Year, hdDTO.NgayLap.Month, hdDTO.NgayLap.Day);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tp", hdDTO.TenPhong);
            cmd.Parameters.AddWithValue("@nl", ngay);
            cmd.Parameters.AddWithValue("@ttien", hdDTO.Tongtien);
            cmd.Parameters.AddWithValue("@tt", hdDTO.TrangThai);



            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            return "Them thanh cong";

        }


        public static string suahdDatabase(hdDTO hdDTO,int mhd)
        {
            SqlConnection con = Connect.Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("suahd", con);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tp", hdDTO.TenPhong);
            cmd.Parameters.AddWithValue("@nl", hdDTO.NgayLap);
            cmd.Parameters.AddWithValue("@ttien", hdDTO.Tongtien);
            cmd.Parameters.AddWithValue("@tt", hdDTO.TrangThai);
            cmd.Parameters.AddWithValue("@mhd", mhd);



            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            return "Sua thanh cong";

        }

        public static string themdvDatabase(dvDTO dvDTO)
        {
            try
            {
                SqlConnection con = Connect.Connection();
                con.Open();
                SqlCommand cmd = new SqlCommand("themdv", con);
                string ngay = string.Format("{0}-{1}-{2}", dvDTO.NgayLap.Year, dvDTO.NgayLap.Month, dvDTO.NgayLap.Day);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tp", dvDTO.TenPhong);
                cmd.Parameters.AddWithValue("@nl", ngay);
                cmd.Parameters.AddWithValue("@td", dvDTO.TienDien);
                cmd.Parameters.AddWithValue("@sc", dvDTO.ChiSoDienCu);
                cmd.Parameters.AddWithValue("@sm", dvDTO.ChiSoDienMoi);
                cmd.Parameters.AddWithValue("@tn", dvDTO.TienNuoc);
                cmd.Parameters.AddWithValue("@tw", dvDTO.TienWifi);
                cmd.Parameters.AddWithValue("@snd", dvDTO.SoNguoiSuDung);
                cmd.Parameters.AddWithValue("@id", dvDTO.IdThue);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                return "Them thanh cong";
        }
            catch (Exception e) { return e+" Them That Bai"; }
} 
        public static string suadvDatabase(dvDTO dvDTO)
        {
            try
            {
                SqlConnection con = Connect.Connection();
                con.Open();
                SqlCommand cmd = new SqlCommand("suadv", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tp", dvDTO.TenPhong);
                cmd.Parameters.AddWithValue("@nl", dvDTO.NgayLap);
                cmd.Parameters.AddWithValue("@td", dvDTO.TienDien);
                cmd.Parameters.AddWithValue("@sc", dvDTO.ChiSoDienCu);
                cmd.Parameters.AddWithValue("@sm", dvDTO.ChiSoDienMoi);
                cmd.Parameters.AddWithValue("@tn", dvDTO.TienNuoc);
                cmd.Parameters.AddWithValue("@tw", dvDTO.TienWifi);
                cmd.Parameters.AddWithValue("@snd", dvDTO.SoNguoiSuDung);
                cmd.Parameters.AddWithValue("@id", dvDTO.SoNguoiSuDung);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                return "Sua thanh cong";
        }
            catch (Exception e) { return e+" Sua That Bai"; }
} 

        public static List<string> loadComboboxdv()
        {
            List<string> dataList = new List<string>();
            SqlConnection con = Connect.Connection();
            con.Open();
            string strcmd = "select DISTINCT tenPhong from Phong";
            SqlCommand cmd = new SqlCommand(strcmd, con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataList.Add(reader.GetString(0));

            }
            reader.Close();
            con.Close();

            return dataList;

        }
    }
}
