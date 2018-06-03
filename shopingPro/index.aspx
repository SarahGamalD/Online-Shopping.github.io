<%@ Page Title="" Language="C#" MasterPageFile="~/anon.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="shopingPro.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="allcontain">
        <div class="feturedsection">
            <h1 class="text-center"><span class="bdots" aria-autocomplete="inline">&bullet;</span>F E A T U R E S<span class="carstxt">C A R S</span>&bullet;</h1>
        </div>

        <!-- ________________________Latest Cars Image Thumbnail________________-->
        <div class="grid">
            <div class="row">
                <asp:ListView ID="lv_products" runat="server" DataKeyNames="id" GroupItemCount="3" OnSelectedIndexChanging="lv_products_SelectedIndexChanging" >
                    <GroupTemplate>
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <div class="row">
                            <td class="col-xs-12 col-sm-6 col-md-4 col-lg-3">
                                <div class="txthover">
                                    <img alt="car1" src='<%# Eval("image") %>'>
                                        <div class="txtcontent">
                                            <div class="stars">
                                                <div class="glyphicon glyphicon-star">
                                                </div>
                                                <div class="glyphicon glyphicon-star">
                                                </div>
                                                <div class="glyphicon glyphicon-star">
                                                </div>
                                            </div>
                                            <div class="simpletxt">
                                                <h3 class="name">&#39;<%# Eval("name") %>&#39;</h3>
                                                <p>
                                                    <%# Eval("description") %>
                                                </p>
                                                <h4 class="price"><%# Eval("price") %> €</h4>
                                                <a href='<%# Eval("id", "products.aspx?id={0}") %>'>
                                                    
                                                      READ MORE
                                                </a>
                                                <br>
                                                    <div class="wishtxt">
                                                        <p class="paragraph1">
                                                            <asp:LinkButton class="postnewcar" 
                                                                CommandName="Select" ID="Button1" 
                                                                runat="server" Text="Add to Card" />
                                                             
                                                            <span class="glyphicon glyphicon-heart"></span>
                                                        </p>
                                                        <p class="paragraph2">
                                                            <%# Eval("offer") %> %<span class="icon">
                                                                <img alt="compicon" src="image/compicon.png"></img></span>
                                                        </p>
                                                    </div>
                                                </br>
                                            </div>
                                            <div class="stars2">
                                                <div class="glyphicon glyphicon-star">
                                                </div>
                                                <div class="glyphicon glyphicon-star">
                                                </div>
                                                <div class="glyphicon glyphicon-star">
                                                </div>
                                            </div>
                                        </div>
                                    </img>
                                </div>
                            </td>
                        </div>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table runat="server">
                            <tr runat="server">
                                <td runat="server">
                                    <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                        <tr id="groupPlaceholder" runat="server">
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr runat="server">
                                <td runat="server" style=""></td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <SelectedItemTemplate>
                    </SelectedItemTemplate>
                </asp:ListView>

            </div>
        </div>
    </div>
</asp:Content>
