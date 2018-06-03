<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="shopingPro.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<div class="content">
        <div class="container">
            <div class="row">
                <div class="form-group col-md-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">
                            
                          
                             <div class="form-group col-md-12">
                                    <asp:TextBox ID="txt_address" runat="server" class="form-control" ValidationGroup="save"  placeholder="Order Address" OnTextChanged="btn_confirm_Click"></asp:TextBox>
                               
                                 <asp:RequiredFieldValidator ControlToValidate="txt_address" ValidationGroup="save" ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                 
                                <asp:Label ID="lbl_empty" runat="server"></asp:Label>
                            </div>
                             <div class="form-group col-md-6">
                                   <asp:Button ID="btn_confirm" ValidationGroup="save" runat="server"
                                    Text="Confirm" class="btn btn-primary pull-right" OnClick="btn_confirm_Click"   />
                            </div>
                            <div class="form-group col-md-12">
                                <asp:GridView ID="gv_cart" runat="server" AutoGenerateColumns="False" DataKeyNames="detailid" OnRowDeleting="gv_cart_RowDeleting" OnRowCommand="gv_cart_RowCommand" Width="500px">
                                 <Columns>
                                     <asp:TemplateField>
                                         <EditItemTemplate>
                                             <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("image") %>'></asp:TextBox>
                                         </EditItemTemplate>
                                         <ItemTemplate>
                                             <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' />
                                         </ItemTemplate>
                                         <ControlStyle Height="150px" Width="150px" />
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Name">
                                         <EditItemTemplate>
                                             <asp:Label ID="Label2" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                                         </EditItemTemplate>
                                         <ItemTemplate>
                                             <asp:Label ID="Label1" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                                         </ItemTemplate>
                                         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="price">
                                         <EditItemTemplate>
                                             <asp:Label ID="Label1" runat="server" Text='<%# Eval("orderedPrice") %>'></asp:Label>
                                         </EditItemTemplate>
                                         <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Text='<%# Bind("orderedPrice") %>'></asp:Label>
                                         </ItemTemplate>
                                         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Quantity">
                                         <EditItemTemplate>
                                             <asp:TextBox ID="txt_editq" runat="server" Text='<%# Bind("quantity") %>'></asp:TextBox>
                                         </EditItemTemplate>
                                         <ItemTemplate>
                                            
                                             <asp:TextBox ID="txt_name" runat="server" Text='<%# Bind("quantity") %>' TextMode="Number" Width="50px"></asp:TextBox>
                                         </ItemTemplate>
                                         <ItemStyle Width="30px" />
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="subtotal">
                                         <ItemTemplate>
                                             <asp:Label ID="lbl_sub" runat="server" ></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField ShowHeader="False">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" Text="update"></asp:LinkButton>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField ShowHeader="False">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="remove"></asp:LinkButton>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                 </Columns>
                       
                    </asp:GridView>

                            </div>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    </div>
</asp:Content>
