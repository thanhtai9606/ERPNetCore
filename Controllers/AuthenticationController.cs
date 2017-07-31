using System;
using System.Linq;
using ERPNetCore.Core;
using ERPNetCore.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ERPNetCore.Controllers
{
    public class AuthenticationController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork(new Models.ERPDatabaseContext());
        OperationResult operationResult = new OperationResult();
        const string LoginID = "_LoginID";
        const string FullName = "_FullName";
        const string Username = "_Username";
        const string Avatar = "_Avatar";
        public JsonResult getAll()
        {
            var rep = unitOfWork.HRRepository.EmployeeRepository.GetAll();

            var eventList = from e in rep
                            select new
                            {
                                BusinessEntityID = e.BusinessEntityId,
                                NationalIDNumber = e.NationalIdnumber,
                                EmpCode = e.EmpCode,
                                Position = e.Position,
                                Level = e.Level,
                                MaritalStatus = e.MaritalStatus,
                                Gender = e.Gender,
                                HireDate = e.HireDate.ToString(),
                                BirthDate = e.BirthDate.ToString(),//.ToShortDateString(),
                                JobTitle = e.JobTitle,
                                Avatar = e.Avatar

                            };
            // phải trả về eventList.FirstOrDefault(); vì eventList.ToArray(); trả về một list
            var rows = eventList.ToList();
            return Json(rows);
        }

        public OperationResult Validate(string Username, string Password)
        {
            try
            {
                var user = unitOfWork.HRRepository.EmployeeRepository.FindBy(x => x.EmpCode == Username && x.BusinessEntity.Password.PasswordHash == Password).FirstOrDefault();
                var person = unitOfWork.HRRepository.PersonRepository.FindBy(x=>x.BusinessEntityId == user.BusinessEntityId).FirstOrDefault();
                if (user != null)
                {

                    HttpContext.Session.SetString(LoginID, user.BusinessEntityId.ToString());
                    HttpContext.Session.SetString(FullName, person.FirstName);
                    HttpContext.Session.SetString(Username, user.EmpCode);
                    HttpContext.Session.SetString(Avatar, user.Avatar);

                    /*                
                    Session["LoginID"] = user.BusinessEntityId;                    
                    Session["FullName"] = user.BusinessEntity.FirstName;
                    Session["Username"] = user.EmpCode;
                    Session["Avatar"] = user.Avatar;
                     */
                    operationResult.Success = true;
                    operationResult.Message = "Đăng nhập thành công!";
                }
                else
                {
                    operationResult.Success = false;
                    operationResult.Message = "Tên đăng nhập hoặc mật khẩu không đúng!";
                }


            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = "Somethings wrong here " + ex.ToString();
            }

            return operationResult;

        }
        public JsonResult ValidateLogin(string Username, string Password)
        {
            operationResult = Validate(Username, Password);
            if (operationResult.Success)
            {
                return Json(new
                {
                    statusCode = 200,
                    status = operationResult.Message,

                });

            }
            else
            {
                return Json(new
                {
                    statusCode = 400,
                    status = operationResult.Message,

                });

            }
        }      
        public ActionResult Logout()
        {
            /*/
            Session["LoginID"] = null;
            Session["FullName"] = null;
            Session["Username"] = null;
            Session["Avatar"] = null;
            */
            HttpContext.Session.SetString(LoginID, null);
            HttpContext.Session.SetString(FullName, null);
            HttpContext.Session.SetString(Username, null);
            HttpContext.Session.SetString(Avatar, null);
            return RedirectToAction("Login");
        }
        public ActionResult NotificationAuthorize()
        {
            return View();
        }

    }
}