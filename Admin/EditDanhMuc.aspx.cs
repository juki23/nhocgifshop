using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_EditDanhMuc : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["iddm"] != null)
            {
                ddldmc.DataSource = ns.getDanhMucnoIDDMC();
                ddldmc.DataTextField = "TenDM";
                ddldmc.DataValueField = "IDDM";
                ddldmc.DataBind();

                var q = ns.getDanhMucbyID(int.Parse(Request.QueryString["iddm"].ToString()));
                ipttendm.Value = q.TenDM;
                CKEditordm.Text = q.ChiTietDM;
                ddldmc.SelectedValue = q.IDDMC.ToString();
                iptcheck.Checked = (bool)q.TrangThaiDM;
            }
            else
            {
                Response.Redirect("DanhMuc.aspx");
            }
        }
    }
    protected void btnupdatedm_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["iddm"] != null)
        {
            if (ipttendm.Value == "" || ipttendm.Value == null)
            {
                Response.Write("<script>alert('Khong duoc thieu ten dm')</script>");
            }
            else
            {
                if (ddldmc.SelectedValue == "-1")
                {
                    DanhMuc dm = new DanhMuc();
                    dm.TenDM = ipttendm.Value;
                    dm.ChiTietDM = CKEditordm.Text;
                    dm.TrangThaiDM = iptcheck.Checked;
                    int result = ns.updateDanhMuc(int.Parse(Request.QueryString["iddm"].ToString()), dm);
                    if (result == 1)
                    {
                        Response.Write("<script>alert('thanh cong');window.location.href = 'DanhMuc.aspx';</script>");
                    }
                }
                else
                {
                    DanhMuc dm = new DanhMuc();
                    dm.TenDM = ipttendm.Value;
                    dm.ChiTietDM = CKEditordm.Text;
                    dm.IDDMC = int.Parse(ddldmc.SelectedValue);
                    dm.TrangThaiDM = iptcheck.Checked;
                    int result = ns.updateDanhMuc(int.Parse(Request.QueryString["iddm"].ToString()), dm);
                    if (result == 1)
                    {
                        Response.Write("<script>alert('thanh cong');window.location.href = 'DanhMuc.aspx';</script>");
                    }
                }
            }
        }
        else
        {
            Response.Redirect("DanhMuc.aspx");
        }
    }
}