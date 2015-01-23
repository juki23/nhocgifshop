using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_GioiThieu : System.Web.UI.Page
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
        if (Session["searchgt"] != null)
        {
            gvgioithieu.DataSource = Session["searchgt"];
            if (Session["pagegt"] != null)
            {
                gvgioithieu.PageIndex = int.Parse(Session["pagegt"].ToString());
            }
            gvgioithieu.DataBind();
        }
        else
        {
            gvgioithieu.DataSource = ns.getAllGioiThieu();
            if (Session["pagegt"] != null)
            {
                gvgioithieu.PageIndex = int.Parse(Session["pagegt"].ToString());
            }
            gvgioithieu.DataBind();
        }

    }
    protected void gvgioithieu_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)gvgioithieu.Rows[e.RowIndex].FindControl("lblidgt");
        int result = ns.deleteGioiThieu(int.Parse(id.Text));
        if (result == 1)
        {
            Response.Write("<script>alert('thanh cong')</script>");
        }
    }
    protected void gvgioithieu_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label id = (Label)gvgioithieu.Rows[e.NewEditIndex].FindControl("lblidgt");
        Response.Redirect("EditGioiThieu.aspx?idgt=" + int.Parse(id.Text));
    }
    protected void gvgioithieu_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvgioithieu.PageIndex = e.NewPageIndex;
        Session["pagegt"] = e.NewPageIndex;
        loadata();
    }
    protected void btnsearchgt_Click(object sender, EventArgs e)
    {
        if (iptsearchgt.Value == "" || iptsearchgt.Value == null)
        {
            IList<GioiThieu> ls = new List<GioiThieu>();
            ls = ns.getAllGioiThieu();
            Session["searchgt"] = ls;
            gvgioithieu.DataSource = Session["searchgt"];
            gvgioithieu.DataBind();
        }
        else
        {
            IList<GioiThieu> ls = new List<GioiThieu>();
            ls = ns.serachgt(iptsearchgt.Value);
            Session["searchgt"] = ls;
            gvgioithieu.DataSource = Session["searchgt"];
            gvgioithieu.DataBind();
        }
    }
}