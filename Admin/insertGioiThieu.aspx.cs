using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_insertGioiThieu : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btninsertgt_Click(object sender, EventArgs e)
    {
        if (ipttengt.Value == "" || ipttengt.Value == null)
        {
            Response.Write("<script>alert('Khong duoc thieu ten gt')</script>");
        }
        else
        {
            int result = ns.insertGioiThieu(ipttengt.Value, CKEditorGT.Text, iptcheck.Checked);
            if (result == 1)
            {
                Response.Write("<script>alert('thanh cong')</script>");
                Response.Redirect("GioiThieu.aspx");
            }
        }
    }
    protected void btnresetgt_Click(object sender, EventArgs e)
    {
        ipttengt.Value = "";
        CKEditorGT.Text = "";
        iptcheck.Checked = false;
    }
}