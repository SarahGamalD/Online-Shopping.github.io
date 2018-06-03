<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="productsPage.aspx.cs" Inherits="shopingPro.productsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group col-sm-12">
        <h3 style="font-size: xx-large; font-family: Georgia; font-weight: bold; color: #800000">&nbsp;&nbsp;&nbsp;&nbsp;products&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h3>
    </div>
    <div class="content">
        <div class="container">
            <div class="row">
                <div class="form-group col-md-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">
                            <div class="form-group col-md-6">
                                            <a  runat="server" Text="" href="~/admin/insertproductPage.aspx" >Insert new product</a>
                            </div>
                            <div class="form-group col-md-12">

                                <p style="font-size: xx-large; font-family: Georgia; font-weight: bold; color: #800000">
                                    <asp:TextBox ID="txt_search" runat="server" class="form-control " placeholder="ProductName" OnTextChanged="lb_search_Click"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="lb_search" runat="server" OnClick="lb_search_Click">Search</asp:LinkButton>
                                </p>
                            </div>
                            <div class="form-group col-md-12">
                                <asp:GridView Height="300px" ID="gv_product" Width="1000px" runat="server" AutoGenerateColumns="False"
                                    DataKeyNames="id" OnRowEditing="gv_product_RowEditing" OnRowUpdating="gv_product_RowUpdating"
                                    BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                                    ForeColor="Black" GridLines="Vertical" OnRowCancelingEdit="gv_product_RowCancelingEdit" OnRowDeleting="gv_product_RowDeleting">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="name">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txt_name" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="image">
                                            <EditItemTemplate>
                                                <asp:FileUpload ID="fu_image" runat="server" />
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Image ID="img_productimage" ImageUrl='<%#"../"+ Eval("image") %>' runat="server" Height="150px" Width="150px" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="price">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txt_price" runat="server" Text='<%# Bind("price") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("price") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="offer">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txt_offer" runat="server" Text='<%# Bind("offer") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("offer") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="category">
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddl_category" runat="server">
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("catName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="description">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txt_description" runat="server" Text='<%# Bind("description") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("description") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:CommandField ShowEditButton="True" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="Gray" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>

                            </div>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    </div>
</asp:Content>
