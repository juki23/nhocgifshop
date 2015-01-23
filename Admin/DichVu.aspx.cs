using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DichVu : System.Web.UI.Page
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
        gvdichvu.DataSource = ns.getAllDichVu();
        if (Session["pagedv"] != null)
        {
            gvdichvu.PageIndex = int.Parse(Session["pagedv"].ToString());
        }
        gvdichvu.DataBind();
    }
    protected void gvdichvu_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label iddv = (Label)gvdichvu.Rows[e.NewEditIndex].FindControl("lbliddv");
        Response.Redirect("DichVu.aspx?iddv=" + int.Parse(iddv.Text));
    }
    protected void gvdichvu_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvdichvu.PageIndex = e.NewPageIndex;
        Session["pagedv"] = e.NewPageIndex;
        loaddata();
    }
    protected void gvdichvu_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label iddv = (Label)gvdichvu.Rows[e.RowIndex].FindControl("lbliddv");
        int result = ns.deleteDichVu(int.Parse(iddv.Text));
        if (result == 1)
        {
            Response.Write("<script>alert('thanh cong')</script>");
        }
        else
        {
            Response.Write("<script>alert('that bai')</script>");
        }
    }
}