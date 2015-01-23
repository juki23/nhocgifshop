using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_KhachHang : System.Web.UI.Page
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
        gvkhachhang.DataSource = ns.getAllKhachHang();
        if (Session["pagekh"] != null)
        {
            gvkhachhang.PageIndex = int.Parse(Session["pagekh"].ToString());
        }
        gvkhachhang.DataBind();
    }
    protected void gvkhachhang_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvkhachhang.PageIndex = e.NewPageIndex;
        Session["pagekh"] = e.NewPageIndex;
        loaddata();
    }
    protected void gvkhachhang_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label id = (Label)gvkhachhang.Rows[e.NewEditIndex].FindControl("lblidkh");
        Response.Redirect("HoaDon.aspx?idkh=" + int.Parse(id.Text));
    }
}