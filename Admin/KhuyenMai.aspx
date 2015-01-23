<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MP/mpBackEnd.master" AutoEventWireup="true" CodeFile="KhuyenMai.aspx.cs" Inherits="Admin_KhuyenMai" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section role="main" class="content-body">
        <header class="page-header">
            <h2>Khuyến mãi</h2>

            <div class="right-wrapper pull-right">
            </div>
        </header>

        <!-- start: page -->

        <section class="panel">
            <header class="panel-heading">
                <div class="panel-actions">
                    <a href="#" class="fa fa-caret-down"></a>
                    <a href="#" class="fa fa-times"></a>
                </div>

                <h2 class="panel-title">Khuyến mãi</h2>
            </header>
            <div class="panel-body">
                <div id="datatable-default_wrapper" class="dataTables_wrapper no-footer">
                    <div class="row datatables-header form-inline">
                        <div class="col-sm-12 col-md-9">
                            <a class="btn btn-default" href="insertKhuyenMai.aspx">Thêm khuyến mãi</a>
                        </div>
                        <div class="col-sm-12 col-md-3">
                            <div class="input-group mb-md">
                                <input id="iptsearchkh" type="text" class="form-control" placeholder="Tìm kiếm..." runat="server" />
                                <span class="input-group-btn">
                                    <asp:Button ID="btnsearchkh" OnClick="btnsearchkh_Click" CssClass="btn btn-default" Text="Tìm" runat="server" />
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="table-responsive">
                        <asp:GridView runat="server" PageSize="2" AllowPaging="true" CssClass="table table-bordered table-striped mb-none dataTable no-footer" AutoGenerateColumns="false" ID="gvkhuyenmai"
                            OnRowDeleting="gvkhuyenmai_RowDeleting" OnRowEditing="gvkhuyenmai_RowEditing" OnPageIndexChanging="gvkhuyenmai_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField HeaderText="Mã">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("IDKM") %>' ID="lblidkm" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Tên">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("Tenkm") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ngày đăng">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("ngaydangkm","{0:dd/MM/yyyy}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ngày bắt đầu">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("ngaybdkm","{0:dd/MM/yyyy}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ngày kết thúc">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("ngayktkm","{0:dd/MM/yyyy}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Trạng thái">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbttrangthaikm" OnClick="lbttrangthaikm_Click" Text='<%#Eval("trangthaikm") == "true".Trim() ? "Ẩn" : "Hiện" %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="#">
                                    <ItemTemplate>
                                        <asp:LinkButton Text="Sửa" CommandName="Edit" runat="server" />
                                        <asp:LinkButton Text="Xóa" CommandName="Delete" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                    <div class="row datatables-footer">
                    </div>
                </div>
            </div>
        </section>
        <!-- end: page -->
    </section>
</asp:Content>

