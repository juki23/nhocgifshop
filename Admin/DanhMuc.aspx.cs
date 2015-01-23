using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DanhMuc : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadata();
        }
    }
    public void loadata()
    {
        gvdanhmuc.DataSource = ns.getAllDanhMuc();
        if (Session["pagedm"] != null)
        {
            gvdanhmuc.PageIndex = int.Parse(Session["pagedm"].ToString());
        }
        gvdanhmuc.DataBind();
    }
    protected void gvdanhmuc_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvdanhmuc.PageIndex = e.NewPageIndex;
        Session["pagedm"] = e.NewPageIndex;
        loadata();

    }
    protected void gvdanhmuc_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)gvdanhmuc.Rows[e.RowIndex].FindControl("lbliddm");
        int result = ns.deleteDanhMuc(int.Parse(id.Text));
        if (result == 1)
        {
            Response.Write("<script>alert('thanh cong')</script>");
        }
        loadata();
    }
    protected void gvdanhmuc_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label id = (Label)gvdanhmuc.Rows[e.NewEditIndex].FindControl("lbliddm");
        Response.Redirect("EditDanhMuc.aspx?iddm=" + int.Parse(id.Text));
    }
}