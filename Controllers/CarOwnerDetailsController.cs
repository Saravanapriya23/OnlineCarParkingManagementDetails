using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCarParkingManagementDetails.Entity;
using OnlineCarParkingManagementDetails.Repository;

namespace OnlineCarParkingManagementDetails.Controllers
{
    public class CarOwnerDetailsController : Controller
    {
        // GET: CarOwnerDetails
        CarOwnerDetailsRepository carownerdetails;
        public CarOwnerDetailsController()
        {
            carownerdetails = new CarOwnerDetailsRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<CarOwnerDetails> carOwnerDetails = carownerdetails.GetCarOwnerDetails();
            return View(carownerdetails);
        }
        public ActionResult Display()
        {
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult SignUp(CarOwnerDetails carOwnerInfo)
        {
            CarOwnerDetailsRepository.SignUp(carOwnerInfo);
            return View();
        }
    }
}