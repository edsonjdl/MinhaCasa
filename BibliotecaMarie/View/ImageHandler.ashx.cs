using BibliotecaMarie.Controller.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BibliotecaMarie.View
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        BibliotecaMarieDataContext db = new BibliotecaMarieDataContext();

        public void ProcessRequest(HttpContext context)
        {
            string imageid = context.Request.QueryString["ImID"];
            Stream strm = Display(imageid);
            byte[] buffer = new byte[4096];
            int byteseq = strm.Read(buffer, 0, 4096);
            while (byteseq > 0)
            {
                context.Response.OutputStream.Write(buffer, 0, byteseq);
                byteseq = strm.Read(buffer, 0, 4096);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        //This method is for Fetch image file...
        public Stream Display(string ImId)
        {
            var ss = (from s in db.Imagems where s.IdImagem == Convert.ToInt32(ImId) select s).First();
            return new MemoryStream(ss.imagem1.ToArray());
        }
    }
}