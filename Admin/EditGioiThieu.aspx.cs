using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditGioiThieu : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["idgt"] != null)
            {
                var q = ns.getGioiThieubyID(int.Parse(Request.QueryString["idgt"].ToString()));
                ipttengt.Value = q.TenGT;
                CKEditorGT.Text = q.ChiTietGT;
                iptcheck.Checked = (bool)q.TrangThaiGT;
            }
            else
            {
                Response.Redirect("GioiThieu.aspx");
            }
        }
    }
    protected void btnupdategt_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["idgt"] != null)
        {
            if (ipttengt.Value == "" || ipttengt.Value == null)
            {
                Response.Write("<script>alert('Khong duoc thieu ten gt')</script>");
            }
            else
            {
                int result = ns.updateGioiThieu(int.Parse(Request.QueryString["idgt"].ToString()), ipttengt.Value, CKEditorGT.Text, iptcheck.Checked);
                if (result == 1)
                {
                    Response.Write("<script>alert('thanh cong')</script>");
                    Response.Redirect("GioiThieu.aspx");
                }
            }
        }
        else
        {
            Response.Redirect("GioiThieu.aspx");
        }
    }
}