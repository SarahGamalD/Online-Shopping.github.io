<%@ Page Title="" Language="C#" MasterPageFile="~//adminMaster.Master" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="shopingPro.admin.order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="content">
        <div class="container">
            <div class="row">
                <div class="col-sm-8">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <h5 class="bold-font primary mr-t-30 mr-b-30">ALL Orders</h5>
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row" >
                            <asp:MultiView ID="adminorder_view" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <asp:GridView ID="gv_order" runat="server" AutoGenerateColumns="False" DataKeyNames="id" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="5" ForeColor="Black" GridLines="Horizontal" OnRowCommand="gv_order_RowCommand" Width="150%">
             <Columns>
                 <asp:HyperLinkField DataTextField="id"   HeaderText="Order"  DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/admin/orderdetails.aspx?orderId={0}" />
                 <asp:TemplateField HeaderText="Name">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("FullName") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label2" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="LastModifiedDate">
                     <EditItemTemplate>
                         <asp:Label ID="Label10" runat="server" Text='<%# Bind("LastModifiedDate") %>'></asp:Label>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label11" runat="server" Text='<%# Bind("LastModifiedDate") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField ShowHeader="False">
                     <ItemTemplate>
                         <asp:Button ID="LinkButton1" runat="server" CausesValidation="false" commandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName='<%# Bind("status") %>' Text='<%# Bind("OrderStatus") %>' />
                     </ItemTemplate>
                     <ControlStyle BackColor="#333333" BorderStyle="None" ForeColor="White" />
                 </asp:TemplateField>
                 <asp:TemplateField ShowHeader="False">
                     <ItemTemplate>
                         <asp:Button ID="LinkButton2" runat="server" CausesValidation="False" commandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="Delete Order" OnClientClick="return confirm('Do you want to delete?')" Text="Delete Order" />
                     </ItemTemplate>
                     <ControlStyle BackColor="#333333" BorderStyle="None" ForeColor="White" />
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
        </asp:View>
    </asp:MultiView>
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



		
</asp:Content>
