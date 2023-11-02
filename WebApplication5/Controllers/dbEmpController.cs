using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using System.Net;
using System.Data.Entity;
using System.Web.Security;
using PagedList;

namespace WebApplication5.Controllers
{
    [Authorize]
    public class dbEmpController : Controller
    {
        dbEmpEntities db = new dbEmpEntities();
        dbEmpEntities bp = new dbEmpEntities();
        dbEmpEntities bt = new dbEmpEntities();
        otherEntities le = new otherEntities();
        maaEntities ma = new maaEntities();
        otherEntities wa = new otherEntities();
        otherEntities g = new otherEntities();
        int pageSize = 5;
        // GET: dbEmp
        public ActionResult Index5(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var lists = db.Tablemy1Tables1101661.OrderBy(m => m.Id).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tablemy1Tables1101661 emp = db.Tablemy1Tables1101661.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy1Tables1101661 emp)
        {
            if (ModelState.IsValid)
            {
                db.Tablemy1Tables1101661.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index5");
            }
            return View(emp);
        }
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy1Tables1101661 emp = db.Tablemy1Tables1101661.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy1Tables1101661 emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index5");
            }
            return View(emp);
        }
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy1Tables1101661 emp = db.Tablemy1Tables1101661.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int Id)
        {
            Tablemy1Tables1101661 emp = db.Tablemy1Tables1101661.Find(Id);
            db.Tablemy1Tables1101661.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index5");
        }
        public ActionResult Query()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQuery(String Album)
        {
            if (Album == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = db.Tablemy1Tables1101661.Where(m => m.Album == Album);
            return View(Qresult.ToList());
        }
        public ActionResult SelectQuery()
        {
            var Qresult = db.Tablemy1Tables1101661.ToList();
            return View(Qresult);
        }
        [HttpPost]
        public ActionResult MySelQuery(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = db.Tablemy1Tables1101661.Where(m => m.Id.ToString() == Id);
            return View(Qresult.ToList());
        }
        public ActionResult First()
        {
            List<Card> cards = new List<Card>
            {
                new Card{Name="SEVENTEEN",Brief="每月9,117,540名觀眾",Photo="1156178.jpg",WikiUrl="Index5"},
                new Card{Name="BLACKPINK",Brief="每月25,102,043名觀眾",Photo="1270570.jpg",WikiUrl="Index2"},
                new Card{Name="BTS",Brief="每月37,336,312名觀眾",Photo="127057.jpg",WikiUrl="Index3"},
                new Card{Name="MAMAMOO",Brief="每月3,230,088名觀眾",Photo="54.jpg",WikiUrl="Index6"},
                new Card{Name="TREASURE",Brief="每月4,126,208名觀眾",Photo="09.jpeg",WikiUrl="Index7"},
                new Card{Name="(G)I-DLE",Brief="每月8,919,417名觀眾",Photo="13.jpg",WikiUrl="Index8"}
            };
            return View(cards);
        }
        public ActionResult Index2(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var lists = db.Tablemy2Tables1101661.OrderBy(m => m.Id).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            return View(result);
        }
        public ActionResult Details2(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tablemy2Tables1101661 em = bp.Tablemy2Tables1101661.Find(Id);
            if (em == null)
            {
                return HttpNotFound();
            }
            return View(em);
        }
        public ActionResult Create2()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create2([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy2Tables1101661 em)
        {
            if (ModelState.IsValid)
            {
                bp.Tablemy2Tables1101661.Add(em);
                bp.SaveChanges();
                return RedirectToAction("Index2");
            }
            return View(em);
        }
        public ActionResult Edit2(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy2Tables1101661 em = bp.Tablemy2Tables1101661.Find(Id);
            if (em == null)
            {
                return HttpNotFound();
            }
            return View(em);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit2([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy2Tables1101661 em)
        {
            if (ModelState.IsValid)
            {
                bp.Entry(em).State = EntityState.Modified;
                bp.SaveChanges();
                return RedirectToAction("Index2");
            }
            return View(em);
        }
        public ActionResult Delete2(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy2Tables1101661 em = bp.Tablemy2Tables1101661.Find(Id);
            if (em == null)
            {
                return HttpNotFound();
            }
            return View(em);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete2(int Id)
        {
            Tablemy2Tables1101661 em = bp.Tablemy2Tables1101661.Find(Id);
            bp.Tablemy2Tables1101661.Remove(em);
            bp.SaveChanges();
            return RedirectToAction("Index2");
        }
        public ActionResult Query2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQuery2(String Album)
        {
            if (Album == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult2 = bp.Tablemy2Tables1101661.Where(m => m.Album == Album);
            return View(Qresult2.ToList());
        }
        public ActionResult SelectQuery2()
        {
            var Qresult2 = bp.Tablemy2Tables1101661.ToList();
            return View(Qresult2);
        }
        [HttpPost]
        public ActionResult MySelQuery2(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult2 = bp.Tablemy2Tables1101661.Where(m => m.Id.ToString() == Id);
            return View(Qresult2.ToList());
        }
        public ActionResult Index3(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var lists = db.Tablemy3Tables1101661.OrderBy(m => m.Id).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            return View(result);
        }
        public ActionResult Details3(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tablemy3Tables1101661 emd = bt.Tablemy3Tables1101661.Find(Id);
            if (emd == null)
            {
                return HttpNotFound();
            }
            return View(emd);
        }
        public ActionResult Create3()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create3([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy3Tables1101661 emd)
        {
            if (ModelState.IsValid)
            {
                bt.Tablemy3Tables1101661.Add(emd);
                bt.SaveChanges();
                return RedirectToAction("Index3");
            }
            return View(emd);
        }
        public ActionResult Edit3(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy3Tables1101661 emd = bt.Tablemy3Tables1101661.Find(Id);
            if (emd == null)
            {
                return HttpNotFound();
            }
            return View(emd);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit3([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy3Tables1101661 emd)
        {
            if (ModelState.IsValid)
            {
                bp.Entry(emd).State = EntityState.Modified;
                bp.SaveChanges();
                return RedirectToAction("Index3");
            }
            return View(emd);
        }
        public ActionResult Delete3(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy3Tables1101661 emd = bt.Tablemy3Tables1101661.Find(Id);
            if (emd == null)
            {
                return HttpNotFound();
            }
            return View(emd);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete3(int Id)
        {
            Tablemy3Tables1101661 emd = bt.Tablemy3Tables1101661.Find(Id);
            bt.Tablemy3Tables1101661.Remove(emd);
            bt.SaveChanges();
            return RedirectToAction("Index3");
        }
        public ActionResult Query3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQuery3(String Album)
        {
            if (Album == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult3 = bt.Tablemy3Tables1101661.Where(m => m.Album == Album);
            return View(Qresult3.ToList());
        }
        public ActionResult SelectQuery3()
        {
            var Qresult3 = bt.Tablemy3Tables1101661.ToList();
            return View(Qresult3);
        }
        [HttpPost]
        public ActionResult MySelQuery3(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult3 = bt.Tablemy3Tables1101661.Where(m => m.Id.ToString() == Id);
            return View(Qresult3.ToList());
        }
        public ActionResult Create4()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create4([Bind(Include = "Id,Password")] Tablemy4Tables1101661 emt)
        {
            if (ModelState.IsValid)
            {
                le.Tablemy4Tables1101661.Add(emt);
                le.SaveChanges();
                return RedirectToAction("Index4");
            }
            return View(emt);
        }
        public ActionResult Index4(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var lists = db.Tablemy4Tables1101661.OrderBy(m => m.Id).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult Details4(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tablemy4Tables1101661 emt = le.Tablemy4Tables1101661.Find(Id);
            if (emt == null)
            {
                return HttpNotFound();
            }
            return View(emt);
        }



        public ActionResult Delete4(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy4Tables1101661 emt = le.Tablemy4Tables1101661.Find(Id);
            if (emt == null)
            {
                return HttpNotFound();
            }
            return View(emt);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete4(int Id)
        {
            Tablemy4Tables1101661 emt = le.Tablemy4Tables1101661.Find(Id);
            le.Tablemy4Tables1101661.Remove(emt);
            le.SaveChanges();
            return RedirectToAction("Index4");
        }
        public ActionResult Index6(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var lists = ma.Tablemy5Tables1101661.OrderBy(m => m.Id).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult Details6(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tablemy5Tables1101661 ema = ma.Tablemy5Tables1101661.Find(Id);
            if (ema == null)
            {
                return HttpNotFound();
            }
            return View(ema);
        }
        public ActionResult Create6()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create6([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy5Tables1101661 ema)
        {
            if (ModelState.IsValid)
            {
                ma.Tablemy5Tables1101661.Add(ema);
                ma.SaveChanges();
                return RedirectToAction("Index6");
            }
            return View(ema);
        }
        public ActionResult Edit6(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy5Tables1101661 ema = ma.Tablemy5Tables1101661.Find(Id);
            if (ema == null)
            {
                return HttpNotFound();
            }
            return View(ema);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit6([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy5Tables1101661 ema)
        {
            if (ModelState.IsValid)
            {
                ma.Entry(ema).State = EntityState.Modified;
                ma.SaveChanges();
                return RedirectToAction("Index6");
            }
            return View(ema);
        }
        public ActionResult Delete6(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy5Tables1101661 ema = ma.Tablemy5Tables1101661.Find(Id);
            if (ema == null)
            {
                return HttpNotFound();
            }
            return View(ema);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete6(int Id)
        {
            Tablemy5Tables1101661 ema = ma.Tablemy5Tables1101661.Find(Id);
            ma.Tablemy5Tables1101661.Remove(ema);
            ma.SaveChanges();
            return RedirectToAction("Index6");
        }
        public ActionResult Query6()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQuery6(String Album)
        {
            if (Album == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresultss = ma.Tablemy5Tables1101661.Where(m => m.Album == Album);
            return View(Qresultss.ToList());
        }
        public ActionResult SelectQuery6()
        {
            var Qresultss= ma.Tablemy5Tables1101661.ToList();
            return View(Qresultss);
        }
        [HttpPost]
        public ActionResult MySelQuery6(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresultss = ma.Tablemy5Tables1101661.Where(m => m.Id.ToString() == Id);
            return View(Qresultss.ToList());
        }
        public ActionResult Index7(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var lists = wa.Tablemy7Tables1101661.OrderBy(m => m.Id).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult Details7(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tablemy7Tables1101661 emw = wa.Tablemy7Tables1101661.Find(Id);
            if (emw == null)
            {
                return HttpNotFound();
            }
            return View(emw);
        }
        public ActionResult Create7()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create7([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy7Tables1101661 emw)
        {
            if (ModelState.IsValid)
            {
                wa.Tablemy7Tables1101661.Add(emw);
                wa.SaveChanges();
                return RedirectToAction("Index7");
            }
            return View(emw);
        }
        public ActionResult Edit7(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy7Tables1101661 emw = wa.Tablemy7Tables1101661.Find(Id);
            if (emw == null)
            {
                return HttpNotFound();
            }
            return View(emw);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit7([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy7Tables1101661 emw)
        {
            if (ModelState.IsValid)
            {
                wa.Entry(emw).State = EntityState.Modified;
                wa.SaveChanges();
                return RedirectToAction("Index7");
            }
            return View(emw);
        }
        public ActionResult Delete7(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy7Tables1101661 emw = wa.Tablemy7Tables1101661.Find(Id);
            if (emw == null)
            {
                return HttpNotFound();
            }
            return View(emw);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete7(int Id)
        {
            Tablemy7Tables1101661 emw = wa.Tablemy7Tables1101661.Find(Id);
            wa.Tablemy7Tables1101661.Remove(emw);
            wa.SaveChanges();
            return RedirectToAction("Index7");
        }
        public ActionResult Query7()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQuery7(String Album)
        {
            if (Album == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresultsss = wa.Tablemy7Tables1101661.Where(m => m.Album == Album);
            return View(Qresultsss.ToList());
        }
        public ActionResult SelectQuery7()
        {
            var Qresultsss = wa.Tablemy7Tables1101661.ToList();
            return View(Qresultsss);
        }
        [HttpPost]
        public ActionResult MySelQuery7(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresultsss = wa.Tablemy7Tables1101661.Where(m => m.Id.ToString() == Id);
            return View(Qresultsss.ToList());
        }
        public ActionResult Index8(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var lists = g.Tablemy8Tables1101661.OrderBy(m => m.Id).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult Details8(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tablemy8Tables1101661 emg = g.Tablemy8Tables1101661.Find(Id);
            if (emg == null)
            {
                return HttpNotFound();
            }
            return View(emg);
        }
        public ActionResult Create8()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create8([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy8Tables1101661 emg)
        {
            if (ModelState.IsValid)
            {
                g.Tablemy8Tables1101661.Add(emg);
                g.SaveChanges();
                return RedirectToAction("Index8");
            }
            return View(emg);
        }
        public ActionResult Edit8(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy8Tables1101661 emg = g.Tablemy8Tables1101661.Find(Id);
            if (emg == null)
            {
                return HttpNotFound();
            }
            return View(emg);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit8([Bind(Include = "Id,Song,Singer,Album, Clickthroughrate,Time")] Tablemy8Tables1101661 emg)
        {
            if (ModelState.IsValid)
            {
                g.Entry(emg).State = EntityState.Modified;
                g.SaveChanges();
                return RedirectToAction("Index8");
            }
            return View(emg);
        }
        public ActionResult Delete8(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供歌曲編號!");
            }
            Tablemy8Tables1101661 emg = g.Tablemy8Tables1101661.Find(Id);
            if (emg == null)
            {
                return HttpNotFound();
            }
            return View(emg);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete8(int Id)
        {
            Tablemy8Tables1101661 emg = g.Tablemy8Tables1101661.Find(Id);
            g.Tablemy8Tables1101661.Remove(emg);
            g.SaveChanges();
            return RedirectToAction("Index8");
        }
        public ActionResult Query8()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQuery8(String Album)
        {
            if (Album == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresultg = g.Tablemy8Tables1101661.Where(m => m.Album == Album);
            return View(Qresultg.ToList());
        }
        public ActionResult SelectQuery8()
        {
            var Qresultg = g.Tablemy8Tables1101661.ToList();
            return View(Qresultg);
        }
        [HttpPost]
        public ActionResult MySelQuery8(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresultg = g.Tablemy8Tables1101661.Where(m => m.Id.ToString() == Id);
            return View(Qresultg.ToList());
        }
        [AllowAnonymous]
        public ActionResult index()
        {
            FormsAuthentication.SignOut();
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult index(int? Id, String Password)
        {
            FormsAuthentication.SignOut();
            //檢查是否有員工Id的判斷，因為資料表沒有帳號跟密碼所以用Id跟Name取代，之後自己改
            if (Id == null && Password == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = le.Tablemy4Tables1101661.Where(m => m.Id == Id && m.Password == Password);
            if (Qresult.Count() == 0)
            {
                ViewBag.Err = "帳密錯誤!";
            }
            else
            {
                FormsAuthentication.RedirectFromLoginPage(Password, true);
                return RedirectToAction("First");
            }
            return View();
        }

    }

}