using MVCPractice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class EmployeeController : Controller
    {
        
        public async System.Threading.Tasks.Task<ActionResult> EmployeeIndex()
        {
            List<EmpModel> empd;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44329/Api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("EmployeeData/GetAllEmpDetails");
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        //var readTask = result.Content.ReadAsAsync<IList<EmpModel>>();
                        var jsonString = await result.Content.ReadAsStringAsync();
                        empd = JsonConvert.DeserializeObject<List<EmpModel>>(jsonString);
                        //readTask.Wait();

                        // Employee= readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        empd = empd = new List<EmpModel>();

                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                }
            ViewBag.EmpCount = empd.Count();
                return View(empd);
        }
        public async System.Threading.Tasks.Task<ActionResult> addEmployee(EmpModel empd)
        {
            if (empd.empid != 0)
            {
                using (var client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(empd);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    var url = "https://localhost:44329/Api/EmployeeData/InsertEmpData";
                    var response = await client.PostAsync(url, data);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        return RedirectToAction("EmployeeIndex");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server Error. Please contact Administrator.");
                    }

                }
                
            }


            return View();
        }
        public ActionResult updateEmployee()
        {
            return View();
        }
        public async System.Threading.Tasks.Task<ActionResult> employeeDetails(int id)
        {
            EmpModel empd = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44329/Api/EmployeeData/");
                //HTTP GET
                var responseTask = client.GetAsync("GetEmpDetails/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonString = await result.Content.ReadAsStringAsync();
                    empd = JsonConvert.DeserializeObject<EmpModel>(jsonString);
                }
                else //web api sent error response 
                {

                    empd = new EmpModel();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(empd);
        }
        public async System.Threading.Tasks.Task<ActionResult> deleteEmployee(int id)
        {
            if (id != 0)
            {
                using (var client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(id);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    var url = "https://localhost:44329/Api/EmployeeData/DeleteEmpData/"+id;
                    var response = await client.PostAsync(url, data);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        return RedirectToAction("EmployeeIndex");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server Error. Please contact Administrator.");
                    }

                }

            }

            return View("EmployeeIndex");
        }
        public ActionResult EmployeeAbout()
        {
            return View();
        }
    }
}