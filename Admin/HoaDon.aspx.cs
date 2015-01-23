using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HoaDon : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loaddata();
        }
    }
    public void loaddata()
    {
        if (Request.QueryString["idkh"] == null)
        {
            gvhoadon.DataSource = ns.getAllHoaDon();
            if (Session["pagehd"] != null)
            {
                gvhoadon.PageIndex = int.Parse(Session["pagehd"].ToString());
            }
            gvhoadon.DataBind();
        }
        else
        {
            int idkh = int.Parse(Request.QueryString["idkh"].ToString());
            gvhoadon.DataSource = ns.getHoaDonbyEmail(ns.getKhachHangbyID(idkh).Email);
            if (Session["pagehd"] != null)
            {
                gvhoadon.PageIndex = int.Parse(Session["pagehd"].ToString());
            }
            gvhoadon.DataBind();
        }
    }
    protected void gvhoadon_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label idhd = (Label)gvhoadon.Rows[e.NewEditIndex].FindControl("lblidhd");
        Response.Redirect("ChiTietHoaDon.aspx?idhd" + int.Parse(idhd.Text));
    }
    protected void gvhoadon_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvhoadon.PageIndex = e.NewPageIndex;
        Session["pagehd"] = e.NewPageIndex;
        loaddata();
    }
}