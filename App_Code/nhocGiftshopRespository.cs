using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for nhocGiftshopRespository
/// </summary>
public sealed class nhocGiftshopRespository : InhocGiftshopRespository
{
    nhocgiftshopdbDataContext ns = new nhocgiftshopdbDataContext();
    #region Baner
    public IList<Baner> getAllBaner()
    {
        return ns.Baners.ToList();
    }
    public IList<Baner> getBanerTrangthai()
    {
        return ns.Baners.Where(x => x.TrangThaiBN == true).ToList();
    }
    public int insertBaner(string tenbn, string hinhanh, bool trangthai)
    {
        Baner bn = new Baner();
        bn.TenBN = tenbn;
        bn.HinhAnh = hinhanh;
        bn.TrangThaiBN = trangthai;
        ns.Baners.InsertOnSubmit(bn);
        ns.SubmitChanges();
        return 1;
    }
    public int updateBaner(int idbn, string tenbn, string hinhanh, bool trangthai)
    {
        var q = (from a in ns.Baners
                 where a.IDBN == idbn
                 select a).SingleOrDefault();
        q.TenBN = tenbn;
        q.HinhAnh = hinhanh;
        q.TrangThaiBN = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int updateBanernoIMG(int idbn, string tenbn, bool trangthai)
    {
        var q = (from a in ns.Baners
                 where a.IDBN == idbn
                 select a).SingleOrDefault();
        q.TenBN = tenbn;
        q.TrangThaiBN = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int deleteBaner(int idbn)
    {
        var q = (from a in ns.Baners
                 where a.IDBN == idbn
                 select a).SingleOrDefault();
        ns.Baners.DeleteOnSubmit(q);
        ns.SubmitChanges();
        return 1;
    }
    public int updateTrangThaibn(int idbn, bool trangthai)
    {
        var q = (from a in ns.Baners
                 where a.IDBN == idbn
                 select a).SingleOrDefault();
        q.TrangThaiBN = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int testTrangthaibn()
    {
        var q = (from a in ns.Baners
                 where a.TrangThaiBN == true
                 select a).Count();
        if (q < 5)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    public IList<Baner> serachbn(string tenbn)
    {
        var q = from a in ns.Baners
                where a.TenBN.Contains(tenbn)
                select a;
        return q.ToList();
    }
    #endregion

    #region GioiThieu
    public IList<GioiThieu> getAllGioiThieu()
    {
        return ns.GioiThieus.ToList();
    }
    public IList<GioiThieu> getGioiThieuTrangthai()
    {
        return ns.GioiThieus.Where(x => x.TrangThaiGT == true).ToList();
    }
    public GioiThieu getGioiThieubyID(int idgt)
    {
        var q = (from a in ns.GioiThieus
                 where a.IDGT == idgt
                 select a).SingleOrDefault();
        return q;
    }

    public int insertGioiThieu(string tengt, string noidung, bool trangthai)
    {
        GioiThieu gt = new GioiThieu();
        gt.TenGT = tengt;
        gt.ChiTietGT = noidung;
        gt.TrangThaiGT = trangthai;
        ns.GioiThieus.InsertOnSubmit(gt);
        ns.SubmitChanges();
        return 1;
    }
    public int updateGioiThieu(int idgt, string tengt, string noidung, bool trangthai)
    {
        var q = (from a in ns.GioiThieus
                 where a.IDGT == idgt
                 select a).SingleOrDefault();
        q.TenGT = tengt;
        q.ChiTietGT = noidung;
        q.TrangThaiGT = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int deleteGioiThieu(int idgt)
    {
        var q = (from a in ns.GioiThieus
                 where a.IDGT == idgt
                 select a).SingleOrDefault();
        ns.GioiThieus.DeleteOnSubmit(q);
        ns.SubmitChanges();
        return 1;
    }
    public int updateTrangThaigt(int idgt, bool trangthai)
    {
        var q = (from a in ns.GioiThieus
                 where a.IDGT == idgt
                 select a).SingleOrDefault();
        q.TrangThaiGT = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public IList<GioiThieu> serachgt(string tengt)
    {
        var q = from a in ns.GioiThieus
                where a.TenGT.Contains(tengt)
                select a;
        return q.ToList();
    }
    #endregion

    #region KhuyenMai
    public IList<KhuyenMai> getAllKhuyenMai()
    {
        return ns.KhuyenMais.ToList();
    }
    public IList<KhuyenMai> getKhuyenMaiTrangthai()
    {
        return ns.KhuyenMais.Where(x => x.TrangThaiKM == true).ToList();
    }
    public KhuyenMai getKhuyenMaibyID(int idkm)
    {
        var q = (from a in ns.KhuyenMais
                 where a.IDKM == idkm
                 select a).SingleOrDefault();
        return q;
    }
    public int insertKhuyenMai(string tenkm, string chitietkm, DateTime ngaydangkm, DateTime ngaybdkm, DateTime ngayktkm, bool trangthai)
    {
        KhuyenMai km = new KhuyenMai();
        km.TenKM = tenkm;
        km.ChiTietKM = chitietkm;
        km.NgayDangKM = ngaydangkm;
        km.NgayBDKM = ngaybdkm;
        km.NgayKTKM = ngayktkm;
        km.TrangThaiKM = trangthai;
        ns.KhuyenMais.InsertOnSubmit(km);
        ns.SubmitChanges();
        return 1;
    }
    public int updateKhuyenMai(int idkm, string tenkm, string chitietkm, DateTime ngaydangkm, DateTime ngaybdkm, DateTime ngayktkm, bool trangthai)
    {
        var q = (from a in ns.KhuyenMais
                 where a.IDKM == idkm
                 select a).SingleOrDefault();
        q.TenKM = tenkm;
        q.ChiTietKM = chitietkm;
        q.NgayDangKM = ngaydangkm;
        q.NgayBDKM = ngaybdkm;
        q.NgayKTKM = ngayktkm;
        q.TrangThaiKM = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int deleteKhuyenMai(int idkm)
    {
        var q = (from a in ns.KhuyenMais
                 where a.IDKM == idkm
                 select a).SingleOrDefault();
        ns.KhuyenMais.DeleteOnSubmit(q);
        ns.SubmitChanges();
        return 1;
    }
    public int updateTrangThaikm(int idkm, bool trangthai)
    {
        var q = (from a in ns.KhuyenMais
                 where a.IDKM == idkm
                 select a).SingleOrDefault();
        q.TrangThaiKM = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public IList<KhuyenMai> serachkm(string tenkm)
    {
        var q = from a in ns.KhuyenMais
                where a.TenKM.Contains(tenkm)
                select a;
        return q.ToList();
    }
    #endregion

    #region DichVu
    public IList<DichVu> getAllDichVu()
    {
        return ns.DichVus.ToList();
    }
    public IList<DichVu> getDichVuTrangthai()
    {
        return ns.DichVus.Where(x => x.TrangThai == true).ToList();
    }
    public DichVu getDichVubyID(int iddv)
    {
        var q = (from a in ns.DichVus
                 where a.IDDV == iddv
                 select a).SingleOrDefault();
        return q;
    }
    public int insertDichVu(string tendv, string chitietdv, bool trangthai)
    {
        DichVu dv = new DichVu();
        dv.TenDV = tendv;
        dv.ChiTietDV = chitietdv;
        dv.TrangThai = trangthai;
        ns.DichVus.InsertOnSubmit(dv);
        ns.SubmitChanges();
        return 1;
    }
    public int updateDichVu(int iddv, string tendv, string chitietdv, bool trangthai)
    {
        var q = (from a in ns.DichVus
                 where a.IDDV == iddv
                 select a).SingleOrDefault();
        q.TenDV = tendv;
        q.ChiTietDV = chitietdv;
        q.TrangThai = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int deleteDichVu(int iddv)
    {
        var q = (from a in ns.DichVus
                 where a.IDDV == iddv
                 select a).SingleOrDefault();
        ns.DichVus.DeleteOnSubmit(q);
        ns.SubmitChanges();
        return 1;
    }
    public int updateTrangThaidv(int iddv, bool trangthai)
    {
        var q = (from a in ns.DichVus
                 where a.IDDV == iddv
                 select a).SingleOrDefault();
        q.TrangThai = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public IList<DichVu> serachdv(string tendv)
    {
        var q = from a in ns.DichVus
                where a.TenDV.Contains(tendv)
                select a;
        return q.ToList();
    }
    #endregion

    #region KhachHang
    public IList<KhachHang> getAllKhachHang()
    {
        return ns.KhachHangs.ToList();
    }
    public KhachHang getKhachHangbyID(int id)
    {
        var q = (from a in ns.KhachHangs
                 where a.IDKH == id
                 select a).SingleOrDefault();
        return q;
    }
    public IList<KhachHang> searchkh(string tenkh)
    {
        var q = from a in ns.KhachHangs
                where a.TenKH.Contains(tenkh)
                select a;
        return q.ToList();
    }
    #endregion

    #region HoaDon
    public IList<HoaDon> getAllHoaDon()
    {
        return ns.HoaDons.ToList();
    }
    public IList<HoaDon> getHoaDonbyEmail(string email)
    {
        var q = from a in ns.HoaDons
                where a.Email == email
                select a;
        return q.ToList();
    }
    #endregion

    #region ChiTietHoaDon
    public IList<ChiTietHoaDon> getAllCTHD(int idhd)
    {
        return ns.ChiTietHoaDons.Where(x => x.IDHD == idhd).ToList();
    }
    #endregion

    #region DanhMuc
    public IList<DanhMuc> getAllDanhMuc()
    {
        return ns.DanhMucs.ToList();
    }
    public IList<DanhMuc> getDanhMucTrangThai()
    {
        return ns.DanhMucs.Where(x => x.TrangThaiDM == true).ToList();
    }
    public IList<DanhMuc> getDanhMucnoIDDMC()
    {
        return ns.DanhMucs.Where(x => x.IDDMC == null).ToList();
    }
    public IList<DanhMuc> getDanhMucIDDMC()
    {
        return ns.DanhMucs.Where(x => x.IDDMC != null).ToList();
    }
    public DanhMuc getDanhMucbyID(int iddm)
    {
        return ns.DanhMucs.Where(x => x.IDDM == iddm).SingleOrDefault();
    }
    public int insertDanhMuc(DanhMuc dm)
    {
        ns.DanhMucs.InsertOnSubmit(dm);
        ns.SubmitChanges();
        return 1;
    }
    public int updateDanhMuc(int iddm, DanhMuc dm)
    {
        var q = (from a in ns.DanhMucs
                 where a.IDDM == iddm
                 select a).SingleOrDefault();
        q.TenDM = dm.TenDM;
        q.ChiTietDM = dm.ChiTietDM;
        if (dm.IDDMC != null)
        {
            q.IDDMC = dm.IDDMC;
        }
        q.TrangThaiDM = dm.TrangThaiDM;
        ns.SubmitChanges();
        return 1;
    }
    public int updateDanhMucTrangThai(int iddm, bool Trangthai)
    {
        var q = (from a in ns.DanhMucs
                 where a.IDDM == iddm
                 select a).SingleOrDefault();
        q.TrangThaiDM = Trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int deleteDanhMuc(int iddm)
    {
        var q = (from a in ns.DanhMucs
                 where a.IDDM == iddm
                 select a).SingleOrDefault();
        ns.DanhMucs.DeleteOnSubmit(q);
        ns.SubmitChanges();
        return 1;
    }
    public IList<DanhMuc> searchDM(string tendm)
    {
        var q = from a in ns.DanhMucs
                where a.TenDM.Contains(tendm)
                select a;
        return q.ToList();
    }
    #endregion

    #region TuVan
    public IList<TuVan> getAllTuVan()
    {
        return ns.TuVans.ToList();
    }
    public IList<TuVan> getTuVanTrangThai()
    {
        return ns.TuVans.Where(x => x.TrangThaiTV == true).ToList();
    }
    public IList<TuVan> getTuVannoIDTVC()
    {
        return ns.TuVans.Where(x => x.IDTV == null).ToList();
    }
    public IList<TuVan> getTuVanIDTVC()
    {
        return ns.TuVans.Where(x => x.IDTVC != null).ToList();
    }
    public TuVan getTuVanbyID(int idtv)
    {
        return ns.TuVans.Where(x => x.IDTV == idtv).SingleOrDefault();
    }
    public int insertTuVan(TuVan tv)
    {
        ns.TuVans.InsertOnSubmit(tv);
        ns.SubmitChanges();
        return 1;
    }
    public int updateTuVan(TuVan tv)
    {
        var q = (from a in ns.TuVans
                 where a.IDTV == tv.IDTV
                 select a).SingleOrDefault();
        q.TenTV = tv.TenTV;
        if (tv.IDTVC != null)
        {
            q.IDTVC = tv.IDTVC;
        }
        q.TrangThaiTV = tv.TrangThaiTV;
        ns.SubmitChanges();
        return 1;
    }
    public int updateTuVanTrangThai(int idtv, bool Trangthai)
    {
        var q = (from a in ns.TuVans
                 where a.IDTV == idtv
                 select a).SingleOrDefault();
        q.TrangThaiTV = Trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int deleteTuVan(int idtv)
    {
        var q = (from a in ns.TuVans
                 where a.IDTV == idtv
                 select a).SingleOrDefault();
        ns.TuVans.DeleteOnSubmit(q);
        ns.SubmitChanges();
        return 1;
    }
    public IList<TuVan> searchTV(string tentv)
    {
        var q = from a in ns.TuVans
                where a.TenTV.Contains(tentv)
                select a;
        return q.ToList();
    }
    #endregion

    #region HinhAnh
    public IList<HinhAnh> getAllHinhAnh()
    {
        return ns.HinhAnhs.ToList();
    }
    public IList<HinhAnh> getHinhAnhbyIDSP(int idsp)
    {
        return ns.HinhAnhs.Where(x => x.IDSP == idsp).ToList();
    }
    public HinhAnh getHinhAnhbyID(int idha)
    {
        return ns.HinhAnhs.Where(x => x.IDHA == idha).SingleOrDefault();
    }
    public int insertHinhAnh(HinhAnh ha)
    {
        ns.HinhAnhs.InsertOnSubmit(ha);
        ns.SubmitChanges();
        return 1;
    }
    public int updateHinhAnh(HinhAnh ha)
    {
        var q = (from a in ns.HinhAnhs
                 where a.IDHA == ha.IDHA
                 select a).SingleOrDefault();
        if (ha.IDSP != null)
        {
            q.IDSP = ha.IDSP;
        }
        q.URL = ha.URL;
        q.TrangThaiHA = ha.TrangThaiHA;
        ns.SubmitChanges();
        return 1;
    }
    public int updateHinhAnhTrangThai(int idha, bool trangthai)
    {
        var q = (from a in ns.HinhAnhs
                 where a.IDHA == idha
                 select a).SingleOrDefault();
        q.TrangThaiHA = trangthai;
        ns.SubmitChanges();
        return 1;
    }
    public int deleteHinhAnh(int idha)
    {
        var q = (from a in ns.HinhAnhs
                 where a.IDHA == idha
                 select a).SingleOrDefault();
        ns.HinhAnhs.DeleteOnSubmit(q);
        ns.SubmitChanges();
        return 1;
    }
    public int deleteHinhAnhbyIDSP(int idsp)
    {
        var q = from a in ns.HinhAnhs
                where a.IDSP == idsp
                select a;
        ns.HinhAnhs.DeleteAllOnSubmit(q);
        ns.SubmitChanges();
        return 1;
    }
    public int testTrangThaiHinhAnh(int idha, int num)
    {
        var q = (from a in ns.HinhAnhs
                 where a.IDHA == idha
                 select a).SingleOrDefault();
        var w = from a in ns.HinhAnhs
                where a.IDSP == q.IDSP && a.TrangThaiHA == true
                select a;
        if (w.Count() >= num)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
    #endregion

    #region KichCo

    #endregion

    #region SanPham
    #endregion
}