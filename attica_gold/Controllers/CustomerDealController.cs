﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attica_gold.Controllers
{
    public class CustomerDealController : Controller
    {
        // GET: CustomerDeal
        public ActionResult Login()
        {
            return View();
        }
        //OTPValidation
        public ActionResult OTPValidation()
        {
            return View();
        }
        //DocumentSubmit
        public ActionResult DocumentSubmit()
        {
            return View();
        }
        public ActionResult SubmitForm()
        {
            return View();
        }
        public ActionResult Receipt()
        {
            return View();
        }
        public ActionResult FeedbackForm()
        {
            return View();
        }
    }
}