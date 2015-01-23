using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ChiTietHoaDon : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["idhd"] != null)
            {
                int idhd = int.Parse(Request.QueryString["idhd"].ToString());
                gvcthd.DataSource = ns.getAllCTHD(idhd);
                gvcthd.DataBind();
            }
            else
            {

            }
        }
    }
    protected void gvcthd_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        int idhd = int.Parse(Request.QueryString["idhd"].ToString());
        gvcthd.PageIndex = e.NewPageIndex;
        gvcthd.DataSource = ns.getAllCTHD(idhd);
        gvcthd.DataBind();
    }
}