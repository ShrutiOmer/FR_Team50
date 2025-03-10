﻿using Microsoft.AspNetCore.Mvc;
using FR_System.Models;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace FR_System.Controllers
{
    public class UserController : Controller
    {
        public ContextDB context;

        public UserController(ContextDB _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return View("Dashboard");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return View();

            else
                return RedirectToAction("Dashboard");
        }
        [HttpPost]
        public IActionResult Login(User ad)
        {
            var x = context.Users.Where(a => a.UserName == ad.UserName && a.Password == ad.Password).FirstOrDefault();

            if (x != null)
            {
                HttpContext.Session.SetString("username", x.UserName);
                HttpContext.Session.SetString("userid", x.UserId.ToString());
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.m = "Wrong User ID or Password";
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return RedirectToAction("Login");
            else
            {
                int id = int.Parse(HttpContext.Session.GetString("userid"));

                var user = context.Users.Find(id);
                if (user == null)
                {
                    ViewBag.m = "ID or UserName not Matched";
                    return RedirectToAction("Login");
                }
                return View(user);
            }
        }

        public IActionResult Register()
        {

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return View();
            else
                return RedirectToAction("Dashboard");
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            ViewBag.regm = "hello";
            if (ModelState.IsValid)
            {
                if (user == null)
                {
                    return NoContent();
                }
                var x = context.Users.Where(a => a.Email == user.Email).FirstOrDefault();
                if (x != null)
                {
                    ViewBag.regm = "User with same Email ID is registered";
                    return View();
                }
                x = context.Users.Where(a => a.UserName == user.UserName).FirstOrDefault();
                if (x != null)
                {
                    ViewBag.regm = "User Name not available";
                    return View();
                }
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("username", String.Empty);
            HttpContext.Session.SetString("userid", String.Empty);
            return RedirectToAction("Index","Home");
        }
    }
}
