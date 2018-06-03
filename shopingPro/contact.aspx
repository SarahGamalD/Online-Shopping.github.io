<%@ Page Title="" Language="C#" MasterPageFile="~/anon.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="shopingPro.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="allcontain">
        <div class="contact">
            <div class="newslettercontent">
                <div class="leftside">
                    <div class="contact-form">
                        <h1>Contact Us</h1>
                        <div class="form-group group-coustume">
                                <asp:TextBox ID="txt_name" class="form-control name-form " runat="server" placeholder="Your Name"></asp:TextBox>
                           
                            <asp:RequiredFieldValidator class=" col-md-1" ID="RequiredFieldValidator2" ValidationGroup="send"
                                    runat="server" ControlToValidate="txt_name" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                
                            <asp:TextBox  ID="txt_email" class="form-control email-form" placeholder="Your Email" runat="server" ></asp:TextBox>
                                <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" SetFocusOnError="true"  ControlToValidate="txt_email" ValidationExpression="/^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]{2,6}$/" Display="Dynamic" ValidationGroup="send" />                                
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="send"
                                    ControlToValidate="txt_email" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                            <asp:TextBox ID="txt_subject" class="form-control subject-form" runat="server" placeholder="Subject" ></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="send"
                                    ControlToValidate="txt_subject" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                                         <asp:TextBox ID="txt_question" runat="server" class="message-form" placeholder="Your Question" Width="100%" TextMode="MultiLine" Rows="4" ></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="send"
                                    ControlToValidate="txt_question" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                                 <asp:Button ID="Button1" class="btn btn-default btn-submit" runat="server" OnClick="Button1_Click" Text="Send" />

                        </div>
                    </div>
                </div>
                <!--<div class="google-maps">
                 <div id="googleMap"></div>

                </div>-->
                <div class="google-maps">

                    <div id="googleMap">
                        <iframe width="100%" height="100%"
                            src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d12811.596018960434!2d31.00978599400792!3d30.55961099156692!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2seg!4v1494249613038"
                            frameborder="0" style="border: 0" allowfullscreen></iframe>
                    </div>
                </div>

            </div>

        </div>
    </div>
</asp:Content>
