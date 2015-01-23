<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MP/mpBackEnd.master" AutoEventWireup="true" CodeFile="ChiTietHoaDon.aspx.cs" Inherits="Admin_ChiTietHoaDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section role="main" class="content-body">
        <header class="page-header">
            <h2>Chi tiết hóa đơn</h2>

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

                <h2 class="panel-title">Chi tiết hóa đơn</h2>
            </header>
            <div class="panel-body">
                <div id="datatable-default_wrapper" class="dataTables_wrapper no-footer">
                    <div class="row datatables-header form-inline">
                        <div class="col-sm-12 col-md-9">
                        </div>
                        <div class="col-sm-12 col-md-3">
                            <div id="datatable-default_filter" class="dataTables_filter">
                                <label style="width: 100%">
                                    <input type="search" class="form-control" placeholder="Search" aria-controls="datatable-default" /></label>
                            </div>
                        </div>
                    </div>
                    <div class="table-responsive">
                        <asp:GridView runat="server" CssClass="table table-bordered table-striped mb-none dataTable no-footer" AutoGenerateColumns="false" ID="gvcthd"
                            OnPageIndexChanging="gvcthd_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField HeaderText="Mã">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("IDCTHD") %>' ID="lblidhd" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Mã hóa đơn">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("IDHD") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sản phẩm">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("SanPham.TenSP") %>' ID="lblemail" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Kích cở">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("KichCo.KichCo1") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Gía">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("Gia") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Số lượng">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("Soluong") %>' runat="server" />
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

