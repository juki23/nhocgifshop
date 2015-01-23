using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Baner : System.Web.UI.Page
{
    nhocGiftshopRespository rs = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loaddata();
        }
    }
    public void loaddata()
    {
        if (Session["searchbn"] != null)
        {
            gvbaner.DataSource = Session["searchbn"];
            if (Session["pagebn"] != null)
            {
                gvbaner.PageIndex = int.Parse(Session["pagebn"].ToString());
            }
            gvbaner.DataBind();
        }
        else
        {
            gvbaner.DataSource = rs.getAllBaner();
            if (Session["pagebn"] != null)
            {
                gvbaner.PageIndex = int.Parse(Session["pagebn"].ToString());
            }
            gvbaner.DataBind();
        }
    }

    protected void btnresetbn_Click(object sender, EventArgs e)
    {
        ipttenbn.Value = "";
        iptcheck.Checked = false;
    }
    protected void btninsertbn_Click(object sender, EventArgs e)
    {
        string filename = Path.GetFileName(ipthinhanh.PostedFile.FileName);
        ipthinhanh.PostedFile.SaveAs(Server.MapPath("../img/") + filename);
        int result = rs.insertBaner(ipttenbn.Value, filename, iptcheck.Checked);
        if (result == 1)
        {
            Response.Write("<script>alert('thanh cong')</script>");
        }
        loaddata();
    }
    protected void gvbaner_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvbaner.PageIndex = e.NewPageIndex;
        Session["pagebn"] = e.NewPageIndex;
        loaddata();
    }
    protected void gvbaner_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvbaner.EditIndex = e.NewEditIndex;
        loaddata();
    }
    protected void gvbaner_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = (Label)gvbaner.Rows[e.RowIndex].FindControl("lblidbn");
        TextBox tenbn = (TextBox)gvbaner.Rows[e.RowIndex].FindControl("txttenbn");
        FileUpload hinhanh = (FileUpload)gvbaner.Rows[e.RowIndex].FindControl("fuhinhanhbn");
        CheckBox trangthai = (CheckBox)gvbaner.Rows[e.RowIndex].FindControl("cbactive");
        if (hinhanh.HasFile)
        {
            string filename = Path.GetFileName(hinhanh.FileName);
            int result = rs.updateBaner(int.Parse(id.Text), tenbn.Text, filename, trangthai.Checked);
            if (result == 1)
            {
                Response.Write("<script>alert('thanh cong')</script>");
            }
        }
        else
        {
            int result = rs.updateBanernoIMG(int.Parse(id.Text), tenbn.Text, trangthai.Checked);
            if (result == 1)
            {
                Response.Write("<script>alert('thanh cong')</script>");
            }
        }
        gvbaner.EditIndex = -1;
        loaddata();
    }
    protected void gvbaner_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvbaner.EditIndex = -1;
        loaddata();
    }
    protected void gvbaner_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)gvbaner.Rows[e.RowIndex].FindControl("lblidbn");
        int result = rs.deleteBaner(int.Parse(id.Text));
        if (result == 1)
        {
            Response.Write("<script>alert('thanh cong')</script>");
        }
    }
    protected void btnsearchbn_Click1(object sender, EventArgs e)
    {
        if (iptsearchbn.Value == "" || iptsearchbn.Value == null)
        {
            IList<Baner> ls = new List<Baner>();
            ls = rs.getAllBaner();
            Session["searchbn"] = ls;
            gvbaner.DataSource = Session["searchbn"];
            gvbaner.DataBind();
        }
        else
        {
            IList<Baner> ls = new List<Baner>();
            ls = rs.serachbn(iptsearchbn.Value);
            Session["searchbn"] = ls;
            gvbaner.DataSource = Session["searchbn"];
            gvbaner.DataBind();
        }
    }
}