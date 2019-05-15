#region Using Directives
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using General;
//using YadSaraGeneral;
//using YadSaraBL.Security;
//using Resources;
//using YadSaraBL.NihulMaarechet;
//using YadSaraBL.NihulTorim;
using System.Text;
using System.IO;
#endregion Using Directives

public partial class MyLogin : Page
{
    protected void btnToPdf_Click(object sender, EventArgs e)
    {

        //convert the HTML that works with IronPDF version 4.4.9 and with updated version is not works. 
        string urlCheckWorkHtml = "~/Work.html";
        Stream stStream = OpenFile(urlCheckWorkHtml);//webClient.OpenRead(strUrlStart + strUrl);
        StreamReader srReader = new StreamReader(stStream);
        string strReport = srReader.ReadToEnd();
        stStream.Close();

        var Renderer = new IronPdf.HtmlToPdf();
        var PDF = Renderer.RenderHtmlAsPdf(strReport);
        string OutputPath = "~/ResultPDF/Work.pdf";
        PDF.SaveAs(OutputPath);



        //convert the new HTML  
        string urlCheckHtml = "~/myFile.html";
        Stream stStream1 = OpenFile(urlCheckHtml);//webClient.OpenRead(strUrlStart + strUrl);
        StreamReader srReader1 = new StreamReader(stStream1);
        string strReport1 = srReader1.ReadToEnd();
        stStream1.Close();

        var Renderer1 = new IronPdf.HtmlToPdf();
        var PDF1 = Renderer.RenderHtmlAsPdf(strReport1);
        string OutputPath1 = "~/ResultPDF/myFile.pdf";
        PDF1.SaveAs(OutputPath1);

        string myStringVariable = "The Converted Files Saved successfuly";
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
    }
}
