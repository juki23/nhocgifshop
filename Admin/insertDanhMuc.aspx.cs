using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_insertDanhMuc : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddldmc.DataSource = ns.getDanhMucnoIDDMC();
            ddldmc.DataTextField = "TenDM";
            ddldmc.DataValueField = "IDDM";
            ddldmc.DataBind();
        }
    }
    protected void btninsertdm_Click(object sender, EventArgs e)
    {
        if (ipttendm.Value == "" || ipttendm.Value == null)
        {
            Response.Write("<script>alert('Khong duoc thieu ten dm');</script>");
        }
        else
        {
            if (ddldmc.SelectedValue == "-1")
            {
                DanhMuc dm = new DanhMuc();
                dm.TenDM = ipttendm.Value;
                dm.ChiTietDM = CKEditorDM.Text;
                dm.TrangThaiDM = iptcheck.Checked;
                int result = ns.insertDanhMuc(dm);
                if (result == 1)
                {
                    Response.Write("<script>alert('thanh cong');window.location.href = 'DanhMuc.aspx';</script>");
                }
            }
            else
            {
                DanhMuc dm = new DanhMuc();
                dm.TenDM = ipttendm.Value;
                dm.ChiTietDM = CKEditorDM.Text;
                dm.IDDMC = int.Parse(ddldmc.SelectedValue);
                dm.TrangThaiDM = iptcheck.Checked;
                int result = ns.insertDanhMuc(dm);
                if (result == 1)
                {
                    Response.Write("<script>alert('thanh cong');window.location.href = 'DanhMuc.aspx';</script>");
                }
            }

        }
    }
    protected void btnresetdm_Click(object sender, EventArgs e)
    {
        ipttendm.Value = "";
        CKEditorDM.Text = "";
        ddldmc.SelectedValue = "-1";
        iptcheck.Checked = false;
    }
}