using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineTesting.Models;

namespace OnlineTesting.Areas.admin.Controllers
{
    public class ClassroomsController : BaseController
    {
        private Model_OT db = new Model_OT();

        // GET: admin/Classrooms
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult DsLop()
        {
            try
            {
                var dsLop = (from l in db.Classrooms
                             select new
                             {
                                 Id = l.Classroom_ID,
                                 Tenlop = l.Classroom_Name
                             }).ToList();
                return Json(new { code = 200, dsLop = dsLop, msg = "Lấy danh sách lớp thành công!" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Lấy danh sách lớp thất bại:" + ex.Message, JsonRequestBehavior.AllowGet });
            }
        }

        [HttpPost]
        public JsonResult AddLop(string Idlop, string tenlop)
        {
            try
            {
                var l = new Classroom();
                l.Classroom_ID = Idlop;
                l.Classroom_Name = tenlop;
                db.Classrooms.Add(l);
                db.SaveChanges();
                return Json(new { code = 200, msg = "Thêm lớp mới thành công!" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Thêm lớp mới thất bại. Lỗi:" + ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult ChiTiet(string id)
        {
            try
            {
                var l = db.Classrooms.SingleOrDefault(x => x.Classroom_ID == id);
                return Json(new { code = 200, L = l, msg = " Lấy thông tin chi tiết thành công!" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Lấy thông tin chi thất bại. Lỗi:" + ex.Message }, JsonRequestBehavior.AllowGet);

            }
        }
        [HttpPost]
        public JsonResult CapNhat(string id, string tenLop)
        {
            try
            {
                var l = db.Classrooms.SingleOrDefault(x => x.Classroom_ID == id);
                l.Classroom_Name = tenLop;
                db.SaveChanges();
                return Json(new { code = 200, msg = " Cập nhập lớp thành công thành công!" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = " Cập nhập lớp thành công thất bại:"+ex.Message }, JsonRequestBehavior.AllowGet);

            }
        }
        [HttpPost]
        public JsonResult XoaLop(string id)
        {
            try
            {
                var l = db.Classrooms.SingleOrDefault(x => x.Classroom_ID == id);
                db.Classrooms.Remove(l);
                db.SaveChanges();
                return Json(new { code = 200, msg = " Xoá lớp học thành công!" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Xóa lớp học thất bại. Lỗi:" + ex.Message }, JsonRequestBehavior.AllowGet);

            }
        }
    }
}
