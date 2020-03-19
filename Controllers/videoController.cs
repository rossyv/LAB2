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
            ViewData["video"] = BaseHelper.ejecutarConsulta("sp_mostrar", CommandType.StoredProcedure);
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
            //ELIMINAR VIDEO 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));
            BaseHelper.ejecutarSentencia("sp_eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("index", "video");
        }
        public ActionResult edit()
        {
            return View();
        }
        [HttpPost]

        public ActionResult edit(int idvideo,
                                 string titulo,
                                  int repro,
                                  string url)
        {
            //editar
             List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));
            parametros.Add(new SqlParameter("titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("sp_editar" , CommandType.StoredProcedure, parametros);
            return RedirectToAction("index", "video");
 
        
        }
        




    }
}
