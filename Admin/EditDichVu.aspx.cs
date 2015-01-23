using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_EditDichVu : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["iddv"] != null)
            {
                int iddv = int.Parse(Request.QueryString["iddv"].ToString());
                var q = ns.getDichVubyID(iddv);
                ipttendv.Value = q.TenDV;
                CKEditorDV.Text = q.ChiTietDV;
                iptcheck.Checked = (bool)q.TrangThai;
            }
        }
    }
    protected void btnupdatedv_Click(object sender, EventArgs e)
    {
        if (ipttendv.Value == "" || ipttendv.Value == null)
        {
            Response.Write("<script>alert('ten dv ko dc de trong')</script>");
        }
        else
        {
            int iddv = int.Parse(Request.QueryString["iddv"].ToString());
            int result = ns.updateDichVu(iddv, ipttendv.Value, CKEditorDV.Text, iptcheck.Checked);
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
}