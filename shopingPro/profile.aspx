<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="shopingPro.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="content">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">
                           
                            <div class="col-md-12 form-group" style="left: 122px; top: 0px; width: 992px; font-family: Arial; font-size: 16px;"> 
                                
                                Your Image: <asp:Image ID="img_profile" runat="server"  Height="150px"></asp:Image>

                            </div>
                           
                            <div class="col-md-12 form-group" style="left: 122px; top: 0px; width: 992px; font-family: Arial; font-size: 16px;"> 
                                
                                FirstName: <asp:Label ID="lbl_fname" runat="server" ForeColor="Red"  Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>

                            </div>
                           
                            <div class="col-md-12 form-group" style="left: 120px; top: 0px; width: 994px; font-family: Arial; font-size: 16px;"> 
                                
                                LastName: <asp:Label ID="lbl_lname" runat="server"  ForeColor="Red" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>

                            </div>
                            <div class="col-md-12 form-group" style="left: 119px; top: 0px; width: 1047px; margin-left: 0px; font-size: 16px; font-family: Arial;"> 
                               UserName: <asp:Label ID="lbl_uname" runat="server" ForeColor="Red" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>

                            </div>
                            <div class="col-md-12 form-group" style="left: 118px; top: 3px; width: 1045px; font-size: 16px; font-family: Arial;"> 
                                &nbsp; 
                                E_mail&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp; <asp:Label ID="lbl_mail" runat="server" ForeColor="Red" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>

                            </div>
                             <div class="col-md-12 form-group" style="left: 116px; top: 0px; width: 1044px; font-size: 16px; font-family: Arial;">
                                &nbsp;
                                Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp; <asp:Label ID="lbl_phone" runat="server" ForeColor="Red" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>

                            </div>
                            <div class="form-group col-md-12 " style="left: 111px; top: 0px; width: 1003px; font-size: 16px; font-family: Arial;">
                                &nbsp; Address&nbsp;&nbsp; :&nbsp; <asp:Label ID="lbl_address"   runat="server" ForeColor="Red" Font-Bold="True" Font-Size="Large"></asp:Label>
                            </div>
                           <div class="form-group col-md-6" style="left: 112px; top: 0px; width: 634px; font-size: 16px; font-family: Arial;">
                               &nbsp;
                               BirthDate&nbsp; : <asp:Label ID="lbl_birthdate" runat="server" ForeColor="Red"  Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4" style="left: 0px; top: 0px">
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
