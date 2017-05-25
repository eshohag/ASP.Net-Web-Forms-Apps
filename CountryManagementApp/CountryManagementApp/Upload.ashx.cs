using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryManagementApp
{
    /// <summary>
    /// Summary description for Upload
    /// </summary>
    public class Upload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpPostedFile uploads = context.Request.Files["upload"];
            string CKEditorFuncNum = context.Request["CKEditorFuncNum"];
            string file = System.IO.Path.GetFileName(uploads.FileName);
            uploads.SaveAs(context.Server.MapPath(".") + "\\Images\\" + file);
            //provide direct URL here
            string url = "http://localhost/CountryManagementApp/Images/" + file;
            //string url = "http://localhost/CKeditorDemo/Images/"+ file;  
            context.Response.End();  
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}