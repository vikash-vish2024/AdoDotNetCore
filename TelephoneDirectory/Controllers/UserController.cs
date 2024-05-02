using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Models;

namespace TelephoneDirectory.Controllers
{
    public class UserController : Controller
    {
        List<User> userlist = new List<User>()
        {
            new User {UserId = 1,UserName = "vikash",MobileNumbers =  "7978234234",Address = "Hyderbad"},
            new User {UserId = 2,UserName = "Avinash",MobileNumbers = "6762547624",Address = "Hyderbad"},
            new User {UserId = 3,UserName = "Suryansh",MobileNumbers = "7924843242",Address = "Hyderbad"},
            new User {UserId = 4,UserName = "Banurekha",MobileNumbers = "7932443242",Address = "Chennai" },
            new User {UserId = 5,UserName = "Banurekha",MobileNumbers = "7945543242",Address = "Chennai"}

        };


        public IActionResult GetAllUser()
        {
            return View(userlist);
        }

        public IActionResult GetById(int userid)
        {
            var user = userlist[userid];
            return View(user);
        }

        public IActionResult DisplayUserWithMMN()
        {
           
            var usersWithMultipleNumbers = userlist.GroupBy(u => u.UserName)
                                                .Where(g => g.Select(u => u.MobileNumbers).Distinct().Count() > 1)
                                                .SelectMany(g => g)
                                                .Distinct()
                                                .ToList();
            return View(usersWithMultipleNumbers);
          
        }

        //public IActionResult Search(string mobileNumber)
        //{
        //    var user = userlist.Where(u => u.MobileNumbers.Contains(mobileNumber)).ToList();
        //    if (user.Any())
        //    {
        //        return View("GetAllUser", userlist);
        //    }
        //    else
        //    {
        //        ViewBag.ErrorMessage = "No user found with the provided mobile number.";
        //        return View("GetAllUser", userlist);
        //    }
        //}
        public ActionResult Search(string mno)
        {
            var user = userlist.FirstOrDefault(u => u.MobileNumbers.Contains(mno));
            return View(user);
        }

        //public IActionResult Update(int userId)
        //{
        //    var user = userlist.Find(u => u.UserId == userId);
        //    if (user != null)
        //    {
        //        return View(user);
        //    }
        //    else
        //    {
        //        return View("NotFound");
        //    }
        //}

        //[HttpPost]
        //public IActionResult Update(User updUser)
        //{
        //    var user = userlist.Find(u => u.UserId == updUser.UserId);
        //    if (user != null)
        //    {
        //        user.UserName = updUser.UserName;
        //        user.MobileNumbers = updUser.MobileNumbers;
        //        user.Address = updUser.Address;
        //        return RedirectToAction("GetAllUser");
        //    }
        //    else
        //    {
        //        return View("NotFound");
        //    }
        //}

        public IActionResult SearchbyMN(string mno)
        {
            var user = userlist.FirstOrDefault(u => u.MobileNumbers==mno);
            if (user != null)
            {
                return View(new List<User> { user });
            }
            else
            {
                return NotFound();
               
            }
        }
        public IActionResult Edit(int id)
        {
            // Find the user by ID
            var user = userlist.FirstOrDefault(u => u.UserId == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user); 
        }

        [HttpPost]
        public IActionResult Edit(User model)
        {
       
            var existingUser = userlist.FirstOrDefault(u => u.UserId == model.UserId);
            if (existingUser != null)
            {
                existingUser.UserName = model.UserName;
                existingUser.MobileNumbers = model.MobileNumbers;
                return RedirectToAction("Edit", new { id = model.UserId });
            }
            return NotFound();
          
        }
    }
}
