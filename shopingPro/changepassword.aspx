<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="changepassword.aspx.cs" Inherits="shopingPro.changepassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="contact-form mr-t-30 mr-b-30">
                        
                        <div class="status alert alert-success" style="display: none"></div>
                        <div id="main-contact-form" class="contact-form row">
                            <div class="col-md-12 form-group"> 
                                <asp:TextBox ID="txt_oldpass" TextMode="Password" class="form-control" placeholder="old Password" runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="register"
                                    ControlToValidate="txt_oldpass" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                           
                            <div class="col-md-12 form-group"> 
                                <asp:TextBox ID="txt_password" TextMode="Password" class="form-control" placeholder="new Password" runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="register"
                                    ControlToValidate="txt_password" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                             <div class="col-md-12 form-group">
                                <asp:TextBox ID="txt_comPas"  class="form-control" placeholder="Comfirm Password" runat="server" TextMode="Password"></asp:TextBox>
                                 <asp:CompareValidator ID="CompareValidator1"  runat="server" ErrorMessage="not Matched" ControlToCompare="txt_password" ControlToValidate="txt_comPas" ValidationGroup="register"></asp:CompareValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ValidationGroup="register"
                                    ControlToValidate="txt_comPas" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group col-md-12 ">
                                &nbsp;<asp:Label ID="lbl_status"   runat="server" ForeColor="Red"></asp:Label>
                            </div>
                           <div class="form-group col-md-6">
                                <asp:Button ID="btn_save" ValidationGroup="save" runat="server"
                                    Text="save" class="btn btn-primary pull-right" OnClick="btn_save_Click"  />
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
