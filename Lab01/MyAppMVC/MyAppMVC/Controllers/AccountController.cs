﻿using Microsoft.AspNetCore.Mvc;
using MyAppMVC.Models;

namespace MyAppMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                     Id = 1,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 2,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/2.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 3,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/3.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 4,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/4.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 5,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/2.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 6,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                     Id = 1,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 2,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/2.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 3,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/3.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 4,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/4.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 5,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/3.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 6,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
            };
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);

            ViewBag.account = account;
            return View();
        }

    }
}