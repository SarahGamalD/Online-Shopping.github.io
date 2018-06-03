<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="AddNewCategory.aspx.cs" Inherits="shopingPro.admin.AddNewCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group col-md-12">
        <h3 style="font-size: xx-large; font-family: Georgia; font-weight: bold; color: #800000">&nbsp;&nbsp;&nbsp;&nbsp;Categories&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h3>
    </div>
    <div class="content">
        <div class="container">
            <div class="row">
                <div class="form-group col-md-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">

                            <div class="form-group col-md-12">
                                <asp:GridView Height="300px" ID="gv_category" Width="1000px" runat="server" AutoGenerateColumns="False"
                                    DataKeyNames="id" OnRowEditing="gv_category_RowEditing" OnRowUpdating="gv_category_RowUpdating"
                                    BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                                    ForeColor="Black" GridLines="Vertical" OnRowCancelingEdit="gv_category_RowCancelingEdit" OnRowDeleting="gv_category_RowDeleting">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Name">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txt_categoryname" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("name") %>'></asp:Label>
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
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                                <asp:Label runat="server" ID="lbl_cntDelete" ForeColor="Red" Visible="False">this category Contains products</asp:Label>
                                <br />
                                <asp:TextBox ID="txt_newcategory" runat="server" class="form-control " placeholder="CategoryName"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                                &nbsp;
                                <asp:Button ID="btn_newcategory" runat="server" OnClick="btn_newcategory_Click" Text="Add New Category" Width="179px" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
