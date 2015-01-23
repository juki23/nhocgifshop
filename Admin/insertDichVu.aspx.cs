using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_insertDichVu : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btninsertdv_Click(object sender, EventArgs e)
    {
        if (ipttendv.Value == "" || ipttendv.Value == null)
        {
            Response.Write("<script>alert('ten dv ko dc de trong')</script>");
        }
        else
        {
            int result = ns.insertDichVu(ipttendv.Value, CKEditorDV.Text, iptcheck.Checked);
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
    protected void btnresetdv_Click(object sender, EventArgs e)
    {
        ipttendv.Value = "";
        CKEditorDV.Text = "";
        iptcheck.Checked = false;
    }
}