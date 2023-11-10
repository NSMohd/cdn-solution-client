using CDNsolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace CDNsolution.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _context;

        // GET: UserController

        public async Task<ActionResult> Index()
        {
            List<User> users = new List<User>();    
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:5217/api/Users"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject<List<User>>(apiResponse);
                }
            }
            return View(users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        public async Task<ActionResult<User>> Create(User _user)
        {
            try
            {
                string codeResponse; 
                using (var client = new HttpClient())
                {
                    using (var response = await client.PostAsJsonAsync("http://localhost:5217/api/Users", _user))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        codeResponse = apiResponse;
                    }
                }
                //if (codeResponse == StatusCodes.Status200OK)
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult<User>> Edit(int id)
        {
            User users = new User();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:5217/api/Users" + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject<User>(apiResponse);
                }
            }

            return View(users);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<User>> Edit(int id, User _user)
        {
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
            string codeResponse;
            using (var client = new HttpClient())
            {
                using (var response = await client.PutAsJsonAsync("http://localhost:5217/api/Users" + "/" + id, _user))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    codeResponse = apiResponse;
                }
            }

            return RedirectToAction("Index");
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult<User>> Delete(int id, User _user)
        {
            User users = new User();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:5217/api/Users" + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject<User>(apiResponse);
                }
            }

            return View(users);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<User>> Delete(int id)
        {
            string codeResponse;
            using (var client = new HttpClient())
            {
                using (var response = await client.DeleteAsync("http://localhost:5217/api/Users" + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    codeResponse = apiResponse;
                }
            }

            return RedirectToAction("Index");
        }
    }
}
