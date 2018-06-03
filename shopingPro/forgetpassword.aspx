<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="forgetpassword.aspx.cs" Inherits="shopingPro.forgetpassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="content">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <h5 class="bold-font primary mr-t-30 mr-b-30">
                            Forgot your password?
No problem!
We will send you an email to reset your password. Just enter the same email address you used for registration . We will send you an email with instructions for resetting your password.


                        </h5>
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row" >

                            <div class="form-group col-md-12">

                                <asp:TextBox ID="txt_mail" class="form-control " runat="server" placeholder="Email "></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator2" ValidationGroup="forget"
                                    runat="server" ControlToValidate="txt_mail" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-12 ">
                                &nbsp;<asp:Label ID="lbl_status"   runat="server" ForeColor="Red"></asp:Label>
                            </div>
                            
                            <div class="form-group col-md-6">
                                <asp:Button ID="btn_forget" ValidationGroup="forget" runat="server"
                                    Text="send Mail" class="btn btn-primary pull-right" OnClick="btn_forget_Click"  />
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
