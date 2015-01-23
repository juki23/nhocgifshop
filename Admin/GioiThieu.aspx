<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MP/mpBackEnd.master" AutoEventWireup="true" CodeFile="GioiThieu.aspx.cs" Inherits="Admin_GioiThieu" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section role="main" class="content-body">
        <header class="page-header">
            <h2>Giới thiệu</h2>

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

                <h2 class="panel-title">Giới thiệu</h2>
            </header>
            <div class="panel-body">
                <div id="datatable-default_wrapper" class="dataTables_wrapper no-footer">
                    <div class="row datatables-header form-inline">
                        <div class="col-sm-12 col-md-9">
                            <a class="btn btn-default" href="insertGioiThieu.aspx">Thêm giới thiệu</a>
                        </div>
                        <div class="col-sm-12 col-md-3">
                            <div class="input-group mb-md">
                                <input id="iptsearchgt" type="text" class="form-control" placeholder="Tìm kiếm..." runat="server" />
                                <span class="input-group-btn">
                                    <asp:Button ID="btnsearchgt" OnClick="btnsearchgt_Click" CssClass="btn btn-default" Text="Tìm" runat="server" />
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="table-responsive">
                        <asp:GridView runat="server" CssClass="table table-bordered table-striped mb-none dataTable no-footer" AutoGenerateColumns="false" ID="gvgioithieu"
                            OnRowDeleting="gvgioithieu_RowDeleting" OnRowEditing="gvgioithieu_RowEditing" OnPageIndexChanging="gvgioithieu_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField HeaderText="Mã">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("IDGT") %>' ID="lblidgt" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Tên">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("TenGT") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Trạng thái">
                                    <ItemTemplate>
                                        <asp:Label Text='<%#Eval("trangthaigt") %>' runat="server" />
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

