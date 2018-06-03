<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="editprofile.aspx.cs" Inherits="shopingPro.editprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <h5 class="bold-font primary mr-t-30 mr-b-30">&nbsp;</h5>
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">

                            <div class="form-group col-md-12">
                                Firstname:
                                <asp:TextBox ID="txt_fname" class="form-control " runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator2" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_fname" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-12">
                                Lastname:
                                <asp:TextBox ID="txt_lname" class="form-control " runat="server" style="margin-left: 79" ></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator3" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_lname" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-12">
                                Username:
                                <asp:TextBox ID="txt_userName" class="form-control " runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator4" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_userName" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                &nbsp;<asp:Label ID="lbl_userNameStatus"   runat="server" ForeColor="Red"></asp:Label>

                            </div>
                            <div class="form-group col-md-12">
                                E_mail:
                                <asp:TextBox ID="txt_email" class="form-control " runat="server" placeholder="Email"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator5" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_email" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                &nbsp;<asp:Label ID="lbl_emailState"   runat="server" ForeColor="Red"></asp:Label>

                            </div>
                            <div class="form-group col-md-12">
                                Address:
                                <asp:TextBox ID="txt_address" class="form-control " runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator6" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_address" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-12">
                                Phone:
                                <asp:TextBox ID="txt_phone"  TextMode="Number" class="form-control " runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator7" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_phone" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </div>
                               <div class="form-group col-md-12">
                                   Image:
                                   <asp:FileUpload ID="fu_img" runat="server" />
                            </div>
                            <%--<div class="form-group col-md-12">
                                BirthDate:
                                <asp:TextBox ID="txt_date" TextMode="Date" class="form-control " runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator8" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_phone" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>--%>
                           
                            
                            <div class="form-group col-md-12 ">
                                &nbsp;<asp:Label ID="lbl_status"   runat="server" ForeColor="Red"></asp:Label>
                            </div>
                           <div class="form-group col-md-6">
                                <asp:Button ID="btn_edit" ValidationGroup="edit" runat="server"
                                    Text="edit" class="btn btn-primary pull-right" OnClick="btn_edit_Click"  />
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
