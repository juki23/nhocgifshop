using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_insertTuVan : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddltvc.DataSource = ns.getTuVannoIDTVC();
            ddltvc.DataTextField = "TenTV";
            ddltvc.DataValueField = "IDTV";
            ddltvc.DataBind();
        }
    }
    protected void btninserttv_Click(object sender, EventArgs e)
    {
        if (ipttentv.Value == "" || ipttentv.Value == null)
        {
            Response.Write("<script>alert('Khong duoc thieu ten dm');</script>");
        }
        else
        {
            if (ddltvc.SelectedValue == "-1")
            {
                TuVan tv = new TuVan();
                tv.TenTV = ipttentv.Value;
                tv.TrangThaiTV = iptcheck.Checked;
                int result = ns.insertTuVan(tv);
                if (result == 1)
                {
                    Response.Write("<script>alert('thanh cong');window.location.href = 'TuVan.aspx';</script>");
                }
            }
            else
            {
                TuVan tv = new TuVan();
                tv.TenTV = ipttentv.Value;
                tv.IDTVC = int.Parse(ddltvc.SelectedValue);
                tv.TrangThaiTV = iptcheck.Checked;
                int result = ns.insertTuVan(tv);
                if (result == 1)
                {
                    Response.Write("<script>alert('thanh cong');window.location.href = 'TuVan.aspx';</script>");
                }
            }

        }
    }
    protected void btnresettv_Click(object sender, EventArgs e)
    {
        ipttentv.Value = "";
        ddltvc.SelectedValue = "-1";
        iptcheck.Checked = false;
    }
}