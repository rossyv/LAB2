using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;



namespace MVCLaboratorio.Controllers
{
    public class videoController : Controller
    {
        //
        // GET: /video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
     

        public ActionResult create(int idvideo,
                                   string titulo,
                                   int repro,
                                   string url)

        {
            //guardar el video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));
            parametros.Add(new SqlParameter("titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("sp_video_insertar",
                                          CommandType.StoredProcedure, parametros);
            return RedirectToAction("index" , "video");
        }

        public ActionResult delete()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Delete(int idvideo)
        {
            return View();
        }

        public ActionResult edit(int idvideo,
                                 string titulo,
                                  int repro,
                                  string url)
        {
            return View();
        }
        




    }
}
