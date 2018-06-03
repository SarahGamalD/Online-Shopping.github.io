<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="orderdetails.aspx.cs" Inherits="shopingPro.admin.orderdetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bottommenu">


        <div class="content">
            <div class="container">
                <div class="row">
                    <div class="col-sm-8">
                        <div class="contact-form mr-t-30 mr-b-30">
                            <h5 class="bold-font primary mr-t-30 mr-b-30">ALL Orders</h5>
                            <div class="status alert alert-success" style="display: none"></div>
                            <div id="main-contact-form" class="contact-form row">
                                <asp:GridView ID="gv_orderdetails" runat="server" AutoGenerateColumns="False" DataKeyNames="orderId" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="5" ForeColor="Black" GridLines="Horizontal" Width="150%">
                                    <Columns>
                                        <asp:BoundField DataField="name" HeaderText="Product" />
                                        <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                                        <asp:TemplateField HeaderText="Price">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("price") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("price") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                    <SortedDescendingHeaderStyle BackColor="#242121" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="contact-info mr-t-30 mr-b-30">
                            <ul class="social-icons list-inline">
                                <li><a href="#" class="hvr-buzz-out"><span class="fa fa-facebook-square"></span></a></li>
                                <li><a href="#" class="hvr-buzz-out"><span class="fa fa-twitter-square"></span></a></li>
                                <li><a href="#" class="hvr-buzz-out"><span class="fa fa-youtube-square"></span></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <ul class="nav nav-tabs bottomlinks">
            <li role="presentation"></li>

        </ul>

    </div>


</asp:Content>

