using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_KhuyenMai : System.Web.UI.Page
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
        gvkhuyenmai.DataSource = ns.getAllKhuyenMai();
        if (Session["pagekm"] != null)
        {
            gvkhuyenmai.PageIndex = int.Parse(Session["pagekm"].ToString());
        }
        gvkhuyenmai.DataBind();
    }
    protected void gvkhuyenmai_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label idkm = (Label)gvkhuyenmai.Rows[e.RowIndex].FindControl("lblidkm");
        int result = ns.deleteKhuyenMai(int.Parse(idkm.Text));
        if (result == 1)
        {
            Response.Write("<script>alert('thanh cong')</script>");
        }
        else
        {
            Response.Write("<script>alert('that bai')</script>");
        }
        loaddata();
    }
    protected void gvkhuyenmai_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label idkm = (Label)gvkhuyenmai.Rows[e.NewEditIndex].FindControl("lblidkm");
        Response.Redirect("EditKhuyenMai.aspx?idkm=" + int.Parse(idkm.Text));
    }
    protected void gvkhuyenmai_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvkhuyenmai.PageIndex = e.NewPageIndex;
        Session["pagekm"] = e.NewPageIndex;
        loaddata();
    }
    protected void btnsearchkh_Click(object sender, EventArgs e)
    {

    }
    protected void lbttrangthaikm_Click(object sender, EventArgs e)
    {
        LinkButton lbt = (LinkButton)sender;
        GridViewRow gv = (GridViewRow)lbt.NamingContainer;
        Label id = (Label)gv.FindControl("lblidkm");
        Response.Write("<script>alert('haha:" + id.Text + "')</script>");
        if (true)
        {
            
        }
    }
}