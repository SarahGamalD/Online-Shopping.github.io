<%@ Page Title="" Language="C#" MasterPageFile="~/anon.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="shopingPro.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        <h5 class="bold-font primary mr-t-30 mr-b-30">You Can Login Now</h5>
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">

                            <div class="form-group col-md-6">

                                <asp:TextBox ID="txt_fname" class="form-control " runat="server" placeholder="First Name"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator2" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_fname" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-6">

                                <asp:TextBox ID="txt_lname" class="form-control " runat="server" placeholder="Last Name"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator3" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_lname" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-6">

                                <asp:TextBox ID="txt_userName" class="form-control " runat="server" placeholder="UserName"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator4" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_userName" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                &nbsp;<asp:Label ID="lbl_userNameStatus"   runat="server" ForeColor="Red"></asp:Label>

                            </div>
                            <div class="form-group col-md-6">

                                <asp:TextBox ID="txt_email" class="form-control " runat="server" placeholder="Email"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator5" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_email" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="mail is not in right formate" ControlToValidate="txt_email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="register"></asp:RegularExpressionValidator>
                                &nbsp;<asp:Label ID="lbl_emailState"   runat="server" ForeColor="Red"></asp:Label>

                            </div>
                            <div class="form-group col-md-6">

                                <asp:TextBox ID="txt_address" class="form-control " runat="server" placeholder="Address"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator6" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_address" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-6">

                                <asp:TextBox ID="txt_phone"  TextMode="Number" class="form-control " runat="server" placeholder="Phone"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator7" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_phone" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </div>
                               <div class="form-group col-md-6">
                                   <asp:FileUpload ID="fu_img" runat="server" />
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator9" ValidationGroup="register"
                                    runat="server" ControlToValidate="fu_img" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-6">

                                <asp:TextBox ID="txt_date" TextMode="Date" class="form-control " runat="server" placeholder="Birth Date"></asp:TextBox>
                                <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator8" ValidationGroup="register"
                                    runat="server" ControlToValidate="txt_date" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="col-md-6 form-group"> 
                                <asp:TextBox ID="txt_password" TextMode="Password" class="form-control" placeholder="Your Password" runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="register"
                                    ControlToValidate="txt_password" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                             <div class="col-md-6 form-group">
                                <asp:TextBox ID="txt_comPas"  class="form-control" placeholder="Comfirm Password" runat="server" TextMode="Password"></asp:TextBox>
                                 <asp:CompareValidator ID="CompareValidator1"  runat="server" ErrorMessage="not Matched" ControlToCompare="txt_password" ControlToValidate="txt_comPas" ValidationGroup="register"></asp:CompareValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ValidationGroup="register"
                                    ControlToValidate="txt_comPas" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-6 ">
                                &nbsp;<asp:Label ID="lbl_status"   runat="server" ForeColor="Red"></asp:Label>
                            </div>
                           <div class="form-group col-md-6">
                                <asp:Button ID="btn_register" ValidationGroup="register" runat="server"
                                    Text="register" class="btn btn-primary pull-right" OnClick="btn_register_Click"  />
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
