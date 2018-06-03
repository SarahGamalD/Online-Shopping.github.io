<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="userorders.aspx.cs" Inherits="shopingPro.userorders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bottommenu">

        <ul class="nav nav-tabs bottomlinks">
            <li role="presentation">

                <asp:MultiView runat="server" ID="mv_show" ActiveViewIndex="0">
                    <asp:View runat="server" ID="allorder">
                        <asp:Button runat="server" Text="SavedOrders" ID="btn_confirm" BackColor="#333333" BorderStyle="None" ForeColor="White" OnClick="btn_confirm_Click"></asp:Button>
                        <asp:Button runat="server" Text="ConfirmedOrders" ID="btn_con" BackColor="#333333" BorderStyle="None" ForeColor="White" OnClick="btn_con_Click"></asp:Button>

                        <asp:GridView ID="gv_order" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Style="margin-left: 0px" Width="743px" DataKeyNames="id">
                            <Columns>
                                <asp:TemplateField HeaderText="Order">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("id", "~/admin/orderdetails.aspx?orderId={0}") %>' Text='<%# Eval("id") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="UserName">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("FullName") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="LastModifiedData">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("lastmodifieddate") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("lastmodifieddate") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Status">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("status") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("orderStatus") %>'></asp:Label>
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




                    </asp:View>

                    <asp:View runat="server" ID="confirmorder">
                        <asp:Button runat="server" Text="AllOrders" ID="btn_all" BackColor="#333333" BorderStyle="None" ForeColor="White" OnClick="btn_all_Click"></asp:Button>

                        <asp:GridView ID="gv_confirm" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowCommand="gv_confirm_RowCommand" Style="margin-left: 0px" Width="743px" DataKeyNames="id">
                            <Columns>
                                <asp:TemplateField HeaderText="Order">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("id", "~/admin/orderdetails.aspx?orderId={0}") %>' Text='<%# Eval("id") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="UserName">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("FullName") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="LastModifiedData">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("lastmodifieddate") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("lastmodifieddate") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Confirm" ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="Confirm Order" OnClientClick="return confirm('Do you want to confirm this order?')" Text="Confirm Order" />
                                    </ItemTemplate>
                                    <ControlStyle BackColor="#333333" BorderStyle="None" ForeColor="White" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Cancled" ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" CausesValidation="False" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="cancle Order" OnClientClick="return confirm('Do you want to delete this order?')" Text="Cancle Order"></asp:Button>
                                    </ItemTemplate>
                                    <ControlStyle BackColor="#333333" BorderStyle="None" ForeColor="White" />
                                    <ItemStyle BorderStyle="None" />
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


                    <asp:View runat="server" ID="confirm">
                        <asp:Button runat="server" Text="AllOrders" ID="btn_all2" BackColor="#333333" BorderStyle="None" ForeColor="White" OnClick="btn_all2_Click"></asp:Button>

                        <asp:GridView ID="gv_confirmd" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Style="margin-left: 0px" Width="743px" DataKeyNames="id" OnRowCommand="gv_confirmd_RowCommand">
                            <Columns>
                                <asp:TemplateField HeaderText="Order">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("id", "~/admin/orderdetails.aspx?orderId={0}") %>' Text='<%# Eval("id") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="UserName">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("FullName") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="LastModifiedData">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("lastmodifieddate") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("lastmodifieddate") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Status">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("status") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("orderStatus") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Cancled" ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" CausesValidation="False" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="cancle Order" OnClientClick="return confirm('Do you want to delete this order?')" Text="Cancle Order"></asp:Button>
                                    </ItemTemplate>
                                    <ControlStyle BackColor="#333333" BorderStyle="None" ForeColor="White" />
                                    <ItemStyle BorderStyle="None" />
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

            </li>
        </ul>
    </div>

</asp:Content>
