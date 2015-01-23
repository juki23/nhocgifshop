<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MP/mpBackEnd.master" AutoEventWireup="true" CodeFile="DichVu.aspx.cs" Inherits="Admin_DichVu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section role="main" class="content-body">
        <header class="page-header">
            <h2>Dịch vụ</h2>

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

                <h2 class="panel-title">Dịch vụ</h2>
            </header>
            <div class="panel-body">
                <div id="datatable-default_wrapper" class="dataTables_wrapper no-footer">
                    <div class="row datatables-header form-inline">
                        <div class="col-sm-12 col-md-9">
                            <a class="btn btn-default" href="insertGioiThieu.aspx">Thêm dịch vụ</a>
                        </div>
                        <div class="col-sm-12 col-md-3">
                            <div id="datatable-default_filter" class="dataTables_filter">
                                <label style="width:100%">
                                    <input type="search" class="form-control" placeholder="Search" aria-controls="datatable-default" /></label>
                            </div>
                        </div>
                    </div>
                    <div class="table-responsive">
                        <asp:GridView runat="server" PageSize="2" CssClass="table table-bordered table-striped mb-none dataTable no-footer" AutoGenerateColumns="false" ID="gvdichvu"
                            OnRowDeleting="gvdichvu_RowDeleting" OnRowEditing="gvdichvu_RowEditing" OnPageIndexChanging="gvdichvu_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField HeaderText="Mã">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("IDDV") %>' ID="lbliddv" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Tên">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("TenDV") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Trạng thái">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("trangthai") %>' runat="server" />
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

