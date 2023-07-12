using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Prueba.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace Prueba.Controllers
{
    public class AccessController : Controller
    {

        static string cadena = "Server=MARINA\\SQLEXPRESS;Database=UCaninoDB;Trusted_Connection=True;TrustServerCertificate=True;";


        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }

        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(Usuario oUsuario)
        {
            bool registrado;
            string mensaje;

            if (UsuarioYaExiste(oUsuario.Name))
            {
                ViewData["Mensaje"] = "El usuario ya existe. Por favor, elija otro nombre de usuario.";
                return View();
            }

            using (SqlConnection cn = new SqlConnection(cadena))
            {

                SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", cn);
                cmd.Parameters.AddWithValue("Name", oUsuario.Name);
                cmd.Parameters.AddWithValue("Pswd", oUsuario.Pswd);
                cmd.Parameters.Add("Registrado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                cmd.ExecuteNonQuery();

                registrado = Convert.ToBoolean(cmd.Parameters["Registrado"].Value);
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();


            }

            ViewData["Mensaje"] = mensaje;

            if (registrado)
            {
                return RedirectToAction("Login", "Access");
            }
            else
            {
                return View();
            }

        }

        [HttpPost]
        public ActionResult Login(Usuario oUsuario)
        {

            using (SqlConnection cn = new SqlConnection(cadena))
            {

                SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", cn);
                cmd.Parameters.AddWithValue("Name", oUsuario.Name);
                cmd.Parameters.AddWithValue("Pswd", oUsuario.Pswd);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                oUsuario.Id = Convert.ToInt32(cmd.ExecuteScalar());

            }
            

            if (oUsuario.Id != 0)
            {
                string usuarioJson = JsonConvert.SerializeObject(oUsuario);
                HttpContext.Session.SetString("usuario", usuarioJson);
                return RedirectToAction("Index", "ABMStock");
            }
            else
            {
                ViewData["Mensaje"] = "usuario no encontrado";
                return View();
            }


        }

        private bool UsuarioYaExiste(string name)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_VerificarUsuarioExistente", cn);
                cmd.Parameters.AddWithValue("Name", name);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

    }


   

}
