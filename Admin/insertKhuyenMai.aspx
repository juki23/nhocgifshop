<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MP/mpBackEnd.master" AutoEventWireup="true" CodeFile="insertKhuyenMai.aspx.cs" Inherits="Admin_insertKhuyenMai" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
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
        <div class="row">
            <div class="col-xs-12">
                <section class="panel">
                    <header class="panel-heading">
                        <div class="panel-actions">
                            <a href="#" class="fa fa-caret-down"></a>
                            <a href="#" class="fa fa-times"></a>
                        </div>

                        <h2 class="panel-title">Thêm Khuyến mãi</h2>
                    </header>
                    <div class="panel-body">
                        <div class="form-horizontal form-bordered">
                            <div class="form-group">
                                <label class="col-md-2 control-label">Tên Khuyến mãi</label>
                                <div class="col-md-6">
                                    <input type="text" class="form-control" id="ipttenkm" runat="server" />
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Chi tiết Khuyến mãi </label>
                                <div class="col-md-10">
                                    <CKEditor:CKEditorControl ID="CKEditorKM" BasePath="/ckeditor/" runat="server"></CKEditor:CKEditorControl>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Ngày đăng</label>
                                <div class="col-md-6">
                                    <input type="text" id="iptngaydang" data-plugin-datepicker class="form-control" runat="server" />
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Ngày bắt đầu</label>
                                <div class="col-md-6">
                                    <input type="text" id="iptngaybd" data-plugin-datepicker class="form-control" runat="server" />
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Ngày kết thúc</label>
                                <div class="col-md-6">
                                    <input type="text" id="iptngaykt" data-plugin-datepicker class="form-control" runat="server" />
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
                                    <asp:Button Text="Insert" CssClass="btn btn-primary" ID="btninsertkm" OnClick="btninsertkm_Click" runat="server" />
                                    <asp:Button Text="Reset" CssClass="btn btn-default" ID="btnresetkm" OnClick="btnresetkm_Click" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </section>
    <div class="datepicker datepicker-dropdown dropdown-menu datepicker-orient-left datepicker-orient-bottom" style="display: block; top: 2670px; left: 635.25px; z-index: 10;">
        <div class="datepicker-days" style="display: block;">
            <table class=" table-condensed">
                <thead>
                    <tr>
                        <th class="prev" style="visibility: visible;">«</th>
                        <th colspan="5" class="datepicker-switch">January 2015</th>
                        <th class="next" style="visibility: visible;">»</th>
                    </tr>
                    <tr>
                        <th class="dow">Su</th>
                        <th class="dow">Mo</th>
                        <th class="dow">Tu</th>
                        <th class="dow">We</th>
                        <th class="dow">Th</th>
                        <th class="dow">Fr</th>
                        <th class="dow">Sa</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td class="old day">28</td>
                        <td class="old day">29</td>
                        <td class="old day">30</td>
                        <td class="old day">31</td>
                        <td class="day">1</td>
                        <td class="day">2</td>
                        <td class="day">3</td>
                    </tr>
                    <tr>
                        <td class="day">4</td>
                        <td class="day">5</td>
                        <td class="day">6</td>
                        <td class="day">7</td>
                        <td class="day">8</td>
                        <td class="day">9</td>
                        <td class="day">10</td>
                    </tr>
                    <tr>
                        <td class="day">11</td>
                        <td class="day">12</td>
                        <td class="day">13</td>
                        <td class="day">14</td>
                        <td class="day">15</td>
                        <td class="day">16</td>
                        <td class="day">17</td>
                    </tr>
                    <tr>
                        <td class="day">18</td>
                        <td class="day">19</td>
                        <td class="day">20</td>
                        <td class="day">21</td>
                        <td class="day">22</td>
                        <td class="day">23</td>
                        <td class="day">24</td>
                    </tr>
                    <tr>
                        <td class="day">25</td>
                        <td class="day">26</td>
                        <td class="day">27</td>
                        <td class="day">28</td>
                        <td class="day">29</td>
                        <td class="day">30</td>
                        <td class="day">31</td>
                    </tr>
                    <tr>
                        <td class="new day">1</td>
                        <td class="new day">2</td>
                        <td class="new day">3</td>
                        <td class="new day">4</td>
                        <td class="new day">5</td>
                        <td class="new day">6</td>
                        <td class="new day">7</td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <th colspan="7" class="today" style="display: none;">Today</th>
                    </tr>
                    <tr>
                        <th colspan="7" class="clear" style="display: none;">Clear</th>
                    </tr>
                </tfoot>
            </table>
        </div>
        <div class="datepicker-months" style="display: none;">
            <table class="table-condensed">
                <thead>
                    <tr>
                        <th class="prev" style="visibility: visible;">«</th>
                        <th colspan="5" class="datepicker-switch">2015</th>
                        <th class="next" style="visibility: visible;">»</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td colspan="7"><span class="month">Jan</span><span class="month">Feb</span><span class="month">Mar</span><span class="month">Apr</span><span class="month">May</span><span class="month">Jun</span><span class="month">Jul</span><span class="month">Aug</span><span class="month">Sep</span><span class="month">Oct</span><span class="month">Nov</span><span class="month">Dec</span></td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <th colspan="7" class="today" style="display: none;">Today</th>
                    </tr>
                    <tr>
                        <th colspan="7" class="clear" style="display: none;">Clear</th>
                    </tr>
                </tfoot>
            </table>
        </div>
        <div class="datepicker-years" style="display: none;">
            <table class="table-condensed">
                <thead>
                    <tr>
                        <th class="prev" style="visibility: visible;">«</th>
                        <th colspan="5" class="datepicker-switch">2010-2019</th>
                        <th class="next" style="visibility: visible;">»</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td colspan="7"><span class="year old">2009</span><span class="year">2010</span><span class="year">2011</span><span class="year">2012</span><span class="year">2013</span><span class="year">2014</span><span class="year">2015</span><span class="year">2016</span><span class="year">2017</span><span class="year">2018</span><span class="year">2019</span><span class="year new">2020</span></td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <th colspan="7" class="today" style="display: none;">Today</th>
                    </tr>
                    <tr>
                        <th colspan="7" class="clear" style="display: none;">Clear</th>
                    </tr>
                </tfoot>
            </table>
        </div>
    </div>
</asp:Content>

