<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MP/mpBackEnd.master" AutoEventWireup="true" CodeFile="insertTuVan.aspx.cs" Inherits="Admin_insertTuVan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section role="main" class="content-body">
        <header class="page-header">
            <h2>Tư vấn</h2>

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

                        <h2 class="panel-title">Thêm tư vấn</h2>
                    </header>
                    <div class="panel-body">
                        <div class="form-horizontal form-bordered">
                            <div class="form-group">
                                <label class="col-md-2 control-label">Tên tư vấn</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" id="ipttentv" runat="server" />
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Tư vấn chứa</label>
                                <div class="col-md-6">
                                    <asp:DropDownList runat="server" ID="ddltvc" AppendDataBoundItems="true" CssClass="form-control">
                                        <asp:ListItem Value="-1">Chọn tư vấn</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label"></label>
                                <div class="col-sm-6">
                                    <div class="checkbox-custom chekbox-primary">
                                        <input id="iptcheck" type="checkbox" runat="server" />
                                        <label for="for-project">Trạng thái</label>
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-md-2 control-label"></label>
                                <div class="col-md-3">
                                    <asp:Button Text="Insert" CssClass="btn btn-primary" ID="btninserttv" OnClick="btninserttv_Click" runat="server" />
                                    <asp:Button Text="Reset" CssClass="btn btn-default" ID="btnresettv" OnClick="btnresettv_Click" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </section>
</asp:Content>

