using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InhocGiftshopRespository
/// </summary>
public interface InhocGiftshopRespository
{
    #region Baner
    IList<Baner> getAllBaner();
    IList<Baner> getBanerTrangthai();
    int insertBaner(string tenbn, string hinhanh, bool trangthai);
    int updateBaner(int idbn, string tenbn, string hinhanh, bool trangthai);
    int updateBanernoIMG(int idbn, string tenbn, bool trangthai);
    int deleteBaner(int idbn);
    int updateTrangThaibn(int idbn, bool trangthai);
    int testTrangthaibn();
    IList<Baner> serachbn(string tenbn);
    #endregion

    #region GioiThieu
    IList<GioiThieu> getAllGioiThieu();
    IList<GioiThieu> getGioiThieuTrangthai();
    GioiThieu getGioiThieubyID(int idgt);
    int insertGioiThieu(string tengt, string noidung, bool trangthai);
    int updateGioiThieu(int idgt, string tengt, string noidung, bool trangthai);
    int deleteGioiThieu(int idgt);
    int updateTrangThaigt(int idgt, bool trangthai);
    IList<GioiThieu> serachgt(string tengt);
    #endregion

    #region KhuyenMai
    IList<KhuyenMai> getAllKhuyenMai();
    IList<KhuyenMai> getKhuyenMaiTrangthai();
    KhuyenMai getKhuyenMaibyID(int idkm);
    int insertKhuyenMai(string tenkm, string chitietkm, DateTime ngaydangkm, DateTime ngaybdkm, DateTime ngayktkm, bool trangthai);
    int updateKhuyenMai(int idkm, string tenkm, string chitietkm, DateTime ngaydangkm, DateTime ngaybdkm, DateTime ngayktkm, bool trangthai);
    int deleteKhuyenMai(int idkm);
    int updateTrangThaikm(int idkm, bool trangthai);
    IList<KhuyenMai> serachkm(string tenkm);
    #endregion

    #region DichVu
    IList<DichVu> getAllDichVu();
    IList<DichVu> getDichVuTrangthai();
    DichVu getDichVubyID(int iddv);
    int insertDichVu(string tendv, string chitietdv, bool trangthai);
    int updateDichVu(int iddv, string tendv, string chitietdv, bool trangthai);
    int deleteDichVu(int iddv);
    int updateTrangThaidv(int iddv, bool trangthai);
    IList<DichVu> serachdv(string tendv);
    #endregion

    #region KhachHang
    IList<KhachHang> getAllKhachHang();
    KhachHang getKhachHangbyID(int id);
    IList<KhachHang> searchkh(string tenkh);
    #endregion

    #region HoaDon
    IList<HoaDon> getAllHoaDon();
    IList<HoaDon> getHoaDonbyEmail(string email);
    #endregion

    #region ChiTietHoaDon
    IList<ChiTietHoaDon> getAllCTHD(int idhd);
    #endregion

    #region DanhMuc
    IList<DanhMuc> getAllDanhMuc();
    IList<DanhMuc> getDanhMucTrangThai();
    IList<DanhMuc> getDanhMucnoIDDMC();
    IList<DanhMuc> getDanhMucIDDMC();
    DanhMuc getDanhMucbyID(int iddm);
    int insertDanhMuc(DanhMuc dm);
    int updateDanhMuc(int iddm, DanhMuc dm);
    int updateDanhMucTrangThai(int iddm, bool Trangthai);
    int deleteDanhMuc(int iddm);
    IList<DanhMuc> searchDM(string tendm);
    #endregion

    #region TuVan
    IList<TuVan> getAllTuVan();
    IList<TuVan> getTuVanTrangThai();
    IList<TuVan> getTuVannoIDTVC();
    IList<TuVan> getTuVanIDTVC();
    TuVan getTuVanbyID(int idtv);
    int insertTuVan(TuVan tv);
    int updateTuVan(TuVan tv);
    int updateTuVanTrangThai(int idtv, bool Trangthai);
    int deleteTuVan(int idtv);
    IList<TuVan> searchTV(string tentv);
    #endregion

    #region HinhAnh
    IList<HinhAnh> getAllHinhAnh();
    IList<HinhAnh> getHinhAnhbyIDSP(int idsp);
    HinhAnh getHinhAnhbyID(int idha);
    int insertHinhAnh(HinhAnh ha);
    int updateHinhAnh(HinhAnh ha);
    int updateHinhAnhTrangThai(int idha, bool trangthai);
    int deleteHinhAnh(int idha);
    int deleteHinhAnhbyIDSP(int idsp);
    int testTrangThaiHinhAnh(int idha, int num);
    #endregion

    #region KichCo

    #endregion

    #region SanPham
    #endregion
}