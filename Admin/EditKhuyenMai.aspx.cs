using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_EditKhuyenMai : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["idkm"] != null)
            {
                int idkm = int.Parse(Request.QueryString["idkm"].ToString());
                var q = ns.getKhuyenMaibyID(idkm);
                ipttenkm.Value = q.TenKM;
                CKEditorKM.Text = q.ChiTietKM;
                iptngaybd.Value = q.NgayBDKM.ToString();
                iptngaykt.Value = q.NgayKTKM.ToString();
                iptngaydang.Value = q.NgayDangKM.ToString();
                iptcheck.Checked = (bool)q.TrangThaiKM;
            }
            else
            {
                Response.Redirect("KhuyenMai.aspx");
            }
        }
    }
    protected void btnupdatekm_Click(object sender, EventArgs e)
    {
        if (ipttenkm.Value == "" || ipttenkm.Value == null)
        {
            Response.Write("<script>alert('ten khuyen mai ko dc trong')</script>");
        }
        else
        {
            if (Request.QueryString["idkm"] != null)
            {
                int idkm = int.Parse(Request.QueryString["idkm"].ToString());
                int result = ns.updateKhuyenMai(idkm, ipttenkm.Value, CKEditorKM.Text, DateTime.Parse(iptngaydang.Value), DateTime.Parse(iptngaybd.Value), DateTime.Parse(iptngaykt.Value), iptcheck.Checked);
                if (result == 1)
                {
                    Response.Write("<script>alert('thanh cong');window.location.href = KhuyenMai.aspx;</script>");
                }
                else
                {
                    Response.Write("<script>alert('that bai')</script>");
                }
            }
            else
            {
                Response.Redirect("KhuyenMai.aspx");
            }
        }
    }
}