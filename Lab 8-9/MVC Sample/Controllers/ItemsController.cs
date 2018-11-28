using Dapper;
using MVC_Sample.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sample.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            var result = GetData();
            return View(result);
        }

        // GET: Items/Details/5
        public ActionResult Details(int id)
        {
            Item result = GetData(id);
            return View(result);
        }


        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private List<Item> GetData()
        {
            string connString = "Data Source=405-prof;Initial Catalog=test;Integrated Security=True;";
            List<Item> result;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                result = conn.Query<Item>("Select * FROM Items").ToList();
            }
            return result;
        }

        private Item GetData(int id)
        {
            string connString = "Data Source=405-prof;Initial Catalog=test;Integrated Security=True;";
            Item result;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                result = conn.QueryFirst<Item>("Select * FROM Items where id=@id", new {  id });
            }
            return result;
        }
    }
}
