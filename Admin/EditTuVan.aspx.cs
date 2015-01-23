using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_EditTuVan : System.Web.UI.Page
{
    nhocGiftshopRespository ns = new nhocGiftshopRespository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["idtv"] != null)
            {
                ddltvc.DataSource = ns.getTuVannoIDTVC();
                ddltvc.DataTextField = "TenTV";
                ddltvc.DataValueField = "IDTV";
                ddltvc.DataBind();

                int idtv = int.Parse(Request.QueryString["idtv"].ToString());
                var q = ns.getTuVanbyID(idtv);
                ipttentv.Value = q.TenTV;
                ddltvc.SelectedValue = q.IDTVC.ToString();
                iptcheck.Checked = (bool)q.TrangThaiTV;
            }
            else
            {
                Response.Redirect("TuVan.aspx");
            }
        }
    }
    protected void btnupdatetv_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["idtv"] != null)
        {
            if (ipttentv.Value == "" || ipttentv.Value == null)
            {
                Response.Write("<script>alert('Khong duoc thieu ten dm')</script>");
            }
            else
            {
                if (ddltvc.SelectedValue == "-1")
                {
                    TuVan tv = new TuVan();
                    tv.IDTV = int.Parse(Request.QueryString["idtv"].ToString());
                    tv.TenTV = ipttentv.Value;
                    tv.TrangThaiTV = iptcheck.Checked;
                    int result = ns.updateTuVan(tv);
                    if (result == 1)
                    {
                        Response.Write("<script>alert('thanh cong');window.location.href = 'TuVan.aspx';</script>");
                    }
                }
                else
                {
                    TuVan tv = new TuVan();
                    tv.IDTV = int.Parse(Request.QueryString["idtv"].ToString());
                    tv.TenTV = ipttentv.Value;
                    tv.IDTVC = int.Parse(ddltvc.SelectedValue);
                    tv.TrangThaiTV = iptcheck.Checked;
                    int result = ns.updateTuVan(tv);
                    if (result == 1)
                    {
                        Response.Write("<script>alert('thanh cong');window.location.href = 'TuVan.aspx';</script>");
                    }
                }
            }
        }
        else
        {
            Response.Redirect("TuVan.aspx");
        }
    }
}