<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MP/mpBackEnd.master" AutoEventWireup="true" CodeFile="EditDanhMuc.aspx.cs" Inherits="Admin_EditDanhMuc" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section role="main" class="content-body">
        <header class="page-header">
            <h2>Danh mục</h2>

            <div class="right-wrapper pull-right">
            </div>
        </header>

        <!-- start: page -->
        <div class="row">
            <div class="col-xs-12">
                <section class="panel">
                    <header class="panel-heading">
                        <div class="panel-actions">
                            <a href="#" class="fa fa-caret-down"></a>
                            <a href="#" class="fa fa-times"></a>
                        </div>

                        <h2 class="panel-title">Thêm danh mục</h2>
                    </header>
                    <div class="panel-body">
                        <div class="form-horizontal form-bordered">
                            <div class="form-group">
                                <label class="col-md-2 control-label">Tên danh mục</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" id="ipttendm" runat="server" />
                                </div>
                            </div>



                            <div class="form-group">
                                <label class="col-md-2 control-label">Chi tiết </label>
                                <div class="col-md-10">
                                    <CKEditor:CKEditorControl ID="CKEditordm" BasePath="/ckeditor/" runat="server"></CKEditor:CKEditorControl>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Danh mục chứa</label>
                                <div class="col-md-6">
                                    <asp:DropDownList runat="server" ID="ddldmc" AppendDataBoundItems="true">
                                        <asp:ListItem Value="-1" Text="Chọn danh mục" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label"></label>
                                <div class="col-sm-6">
                                    <div class="checkbox-custom chekbox-primary">
                                        <input id="iptcheck" type="checkbox" runat="server" />
                                        <label for="for-project">Active</label>
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-md-2 control-label"></label>
                                <div class="col-md-3">
                                    <asp:Button Text="Cập nhật" CssClass="btn btn-primary" ID="btnupdatedm" OnClick="btnupdatedm_Click" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </section>
</asp:Content>

