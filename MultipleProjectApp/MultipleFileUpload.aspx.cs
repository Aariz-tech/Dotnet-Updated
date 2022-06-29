using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

namespace MultipleProjectApp
{
    public partial class MultipleFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabMsg.Text = "";
        }

        protected void Btnupload_Click(object sender, EventArgs e)
        {
            String filePath = Path.GetExtension(FileUpload1.FileName);
            if(filePath != ".jpg" && filePath != ".png" && filePath != ".gif")
            {
                LabMsg.Text = "Only .jpg .gif .png are allowed";
                LabMsg.ForeColor = Color.Red;
            }
            else
            {
                foreach(HttpPostedFile postedFile in FileUpload1.PostedFiles)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    postedFile.SaveAs(Server.MapPath("~/Images/")+ fileName);
                }
                LabMsg.ForeColor= Color.Green;
                LabMsg.Text = String.Format("{0} selected images are saved",FileUpload1.PostedFiles.Count);
            }
        }
    }
}