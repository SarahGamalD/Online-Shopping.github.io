<%@ Page Title="" Language="C#" MasterPageFile="~/anon.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="shopingPro.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <h5 class="bold-font primary mr-t-30 mr-b-30">You Can Login Now</h5>
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">

                            <div class="form-group col-md-12">

                                <asp:TextBox ID="txt_name" class="form-control " runat="server" placeholder="Email or user name"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator2" ValidationGroup="login"
                                    runat="server" ControlToValidate="txt_name" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="col-md-12 form-group">
                                <asp:TextBox ID="txt_password" class="form-control" placeholder="Your Password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="login"
                                    ControlToValidate="txt_password" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-12 ">
                                <asp:CheckBox ID="ck_rember" runat="server" Text="remeber me" />
                                &nbsp;<asp:Label ID="lbl_status" runat="server" ForeColor="Red"></asp:Label>

                            </div>
                            <div class="form-group col-md-6">
                                <asp:Button ID="btn_login" ValidationGroup="login" runat="server"
                                    Text="login" class="btn btn-primary pull-right" OnClick="btn_login_Click" />
                            </div>
                            <div class="form-group col-md-6">
                                <a href="forgetpassword.aspx" style="margin-left: 10px;">Forget Password</a>
                            </div>
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
