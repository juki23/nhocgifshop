using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HinhAnh : System.Web.UI.Page
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
        gvhinhanh.DataSource = ns.getAllHinhAnh();
        if (Session["pageha"] != null)
        {
            gvhinhanh.PageIndex = int.Parse(Session["pageha"].ToString());
        }
        gvhinhanh.DataBind();
    }
    protected void gvhinhanh_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvhinhanh.PageIndex = e.NewPageIndex;
        Session["pageha"] = e.NewPageIndex;
        loaddata();
    }
    protected void gvhinhanh_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = gvhinhanh.Rows[e.RowIndex].FindControl("lblidha") as Label;
        int result = ns.deleteHinhAnh(int.Parse(id.Text));
        if (result == 1)
        {
            Response.Write("<script>alert('thanh cong')</script>");
        }
    }
    protected void gvhinhanh_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label id = gvhinhanh.Rows[e.NewEditIndex].FindControl("lblidha") as Label;
        var q = ns.getHinhAnhbyID(int.Parse(id.Text));
        if (q.TrangThaiHA == true)
        {
            int result = ns.updateHinhAnhTrangThai(int.Parse(id.Text), false);
            if (result == 1)
            {
                Response.Write("<script>alert('thanh cong')</script>");
            }
        }
        else
        {
            if (ns.testTrangThaiHinhAnh(int.Parse(id.Text), 1) == 1)
            {
                int result = ns.updateHinhAnhTrangThai(int.Parse(id.Text), true);
                if (result == 1)
                {
                    Response.Write("<script>alert('thanh cong')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('San pham da co hinh anh dc active')</script>");
            }
        }
    }
}