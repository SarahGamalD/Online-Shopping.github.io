<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="shopingPro.readmore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <h5 class="bold-font primary mr-t-30 mr-b-30">Product Details</h5>
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">
                            <asp:DetailsView ControlStyle-CssClass="form-group col-md-12" ID="DV_Product" runat="server" AutoGenerateRows="False" CellPadding="3" DataKeyNames="id">
                                <Fields>
                                    <asp:TemplateField  ControlStyle-CssClass="form-control  col-md-12" HeaderText="Product Name">

                                        <ItemTemplate>
                                            <asp:Label ID="Label1" ControlStyle-CssClass="form-control  col-md-9" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Catogry" ControlStyle-CssClass="form-control  col-md-3">
                                        
                                        <ItemTemplate>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("CatogryName") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Description" ControlStyle-CssClass="form-control  col-md-3">
                                        
                                        <ItemTemplate>
                                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("description") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Price Before Offer" ControlStyle-CssClass="form-control  col-md-3">
                                        
                                        <ItemTemplate>
                                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("PriceBeforeOffer") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField  HeaderText="Price After Offer" ControlStyle-CssClass="form-control  col-md-3">
                                        
                                        <ItemTemplate>
                                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("PriceAfterOffer") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:ImageField DataAlternateTextField="ProductName" DataImageUrlField="image" >
                                        <ControlStyle Height="300px" Width="300px" />
                                        <ItemStyle BorderStyle="None" Height="200px" Width="200px" />
                                    </asp:ImageField>
                                </Fields>
                            </asp:DetailsView>
                            <br />
                            <table class="nav-justified">
                                <tr>
                                    <td>Add Quanitity</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox class="form-control " Width="150px" runat="server" Text="1" ID="txt_cart" TextMode="Number"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_cart" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                                        <asp:RangeValidator ControlToValidate="txt_cart" MinimumValue="1" MaximumValue="10" ID="RangeValidator1" runat="server" ErrorMessage="not valid" ForeColor="Red" Type="Integer"></asp:RangeValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button runat="server" Text="Add To Cart" ID="btn_cart" class="btn btn-primary pull-right" OnClick="btn_cart_Click" />
                                    </td>
                                </tr>
                            </table>
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
