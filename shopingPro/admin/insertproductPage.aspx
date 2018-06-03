<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="insertproductPage.aspx.cs" Inherits="shopingPro.insertproductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group col-sm-12">
    <h3 style="font-size: xx-large; font-family: Georgia; font-weight: bold; color: #800000">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Insert New Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h3>
        </div>
    <div class="content">
        <div class="container">
            <div class="row">
                <div class="form-group col-md-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <div class="status alert alert-success" style="display: none"></div>
                       <div id="main-contact-form" class="contact-form row" >

                            <div class="form-group col-md-12">
                                
                                 <asp:TextBox ID="txt_productname" class="form-control " runat="server" placeholder="ProductName"></asp:TextBox>
   
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="#990000" ControlToValidate="txt_productname">*</asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:FileUpload ID="fu_productimage" class="form-control " runat="server"  placeholder="ProductImage"/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="#990000" ControlToValidate="fu_productimage">*</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-12 ">
                                <asp:TextBox ID="txt_productprice" class="form-control " runat="server" placeholder="ProductPrice"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="#990000" ControlToValidate="txt_productprice">*</asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-12 ">
                              <asp:TextBox ID="txt_productoffer" class="form-control " runat="server" placeholder="ProductOffer"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="#990000" ControlToValidate="txt_productoffer">*</asp:RequiredFieldValidator>           

                            </div>
                            <div class="form-group col-md-12 ">
                               <asp:DropDownList ID="ddl_category" class="form-control " runat="server" >
                               </asp:DropDownList>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="#990000" ControlToValidate="ddl_category">*</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-12 ">
                               <asp:TextBox ID="txt_productdescription" class="form-control " runat="server" placeholder="ProductDescription"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="#990000" ControlToValidate="txt_productdescription">*</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-6">
                                 <asp:Button ID="btn_add" runat="server" OnClick="btn_add_click" style="width: 39px" Text="Add" />
                            </div>
                        </div>
                </div>            
                </div>
                </div>
            </div>
        </div>
    
</asp:Content>
