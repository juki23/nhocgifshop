using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_insertKhuyenMai : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btninsertkm_Click(object sender, EventArgs e)
    {
        if (ipttenkm.Value == "" || ipttenkm.Value == null)
        {
            Response.Write("<script>alert('ten khuyen mai ko dc de trong')</script>");
        }
        else
        {
            int result = ns.insertKhuyenMai(ipttenkm.Value,CKEditorKM.Text,DateTime.Parse(iptngaydang.Value),DateTime.Parse(iptngaybd.Value),DateTime.Parse(iptngaykt.Value),iptcheck.Checked);
            if (result == 1)
            {
                Response.Write("<script>alert('thanh cong')</script>");
                Response.Redirect("KhuyenMai.aspx");
            }
            else
            {
                Response.Write("<script>alert('that bai')</script>");
            }
        }
    }
    protected void btnresetkm_Click(object sender, EventArgs e)
    {
        ipttenkm.Value = "";
        CKEditorKM.Text = "";
        iptngaybd.Value = "";
        iptngaykt.Value = "";
        iptngaydang.Value = "";
        iptcheck.Checked = false;
    }
}