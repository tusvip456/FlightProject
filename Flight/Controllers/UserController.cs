using Flight.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flight.Controllers
{
    public class UserController : Controller
    {
        //private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        // GET: User
        [HttpGet]
        public ActionResult LoginRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            User user = null;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@username", username);
            //    command.Parameters.AddWithValue("@password", password);

            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        user = new User
            //        {
            //            Id = (int)reader["Id"],
            //            Username = reader["Username"].ToString(),
            //            Password = reader["Password"].ToString(),
            //            Email = reader["Email"].ToString(),
            //            PhoneNumber = reader["PhoneNumber"].ToString(),
            //            FullName = reader["FullName"].ToString()
            //        };
            //    }
            //}

            if (user != null)
            {
                // Đăng nhập thành công, bạn có thể lưu thông tin người dùng vào Session hoặc Redirect đến trang khác
                Session["User"] = user;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Tài khoản hoặc mật khẩu không chính xác.";
                return View("LoginRegister");
            }
        }
        [HttpGet]
        public ActionResult ForgetPass()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgetPass(string email)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Liên kết khôi phục mật khẩu đã được gửi đến email của bạn.";
            }
            else
            {
                ViewBag.Message = "Vui lòng kiểm tra lại email của bạn.";
            }

            return View();
        }
    }
}