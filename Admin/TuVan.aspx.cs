using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_TuVan : System.Web.UI.Page
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
        gvtuvan.DataSource = ns.getAllTuVan();
        if (Session["pagetv"] != null)
        {
            gvtuvan.PageIndex = int.Parse(Session["pagetv"].ToString());
        }
        gvtuvan.DataBind();
    }
    protected void gvtuvan_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label idtv = (Label)gvtuvan.Rows[e.RowIndex].FindControl("lblidtv");
        int result = ns.deleteTuVan(int.Parse(idtv.Text));
        if (result == 1)
        {
            Response.Write("<script>alert('thanh cong')</script>");
        }
        loaddata();
    }
    protected void gvtuvan_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label idtv = (Label)gvtuvan.Rows[e.NewEditIndex].FindControl("lblidtv");
        Response.Redirect("EditTuVan.aspx?idtv=" + int.Parse(idtv.Text));
    }
    protected void gvtuvan_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvtuvan.PageIndex = e.NewPageIndex;
        Session["pagetv"] = e.NewPageIndex;
        loaddata();
    }
}