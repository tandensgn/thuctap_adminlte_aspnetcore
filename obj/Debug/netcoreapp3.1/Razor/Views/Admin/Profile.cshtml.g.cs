#pragma checksum "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4afb12a62162fa2971e8e98cef6c0f54d3b8b156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Profile), @"mvc.1.0.view", @"/Views/Admin/Profile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\_ViewImports.cshtml"
using AdminLTEASPNETEmployees;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\_ViewImports.cshtml"
using AdminLTEASPNETEmployees.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afb12a62162fa2971e8e98cef6c0f54d3b8b156", @"/Views/Admin/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823c98bf635e7ab8ddca3cc7a0ac05155bd37ff0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminLTEASPNETEmployees.Dtos.EmployeesReadDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-user-img img-fluid img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/TanDen_Logo_a105.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px;width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("edit-admin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("edit-adminpass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Profile</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">User Profile</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-3"">

                    <!-- Profile Image -->
                    <div class=""card card-primary card-outline"">
                        <div class=""card-body box-profile"">
    ");
            WriteLiteral("                        <div class=\"text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4afb12a62162fa2971e8e98cef6c0f54d3b8b1568141", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <h3 class=\"profile-username text-center\">");
#nullable restore
#line 40 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
                                                                Write(Model.EmpFullname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                            <p class=""text-muted text-center"">Admin</p>



                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                    <!-- About Me Box -->
                    <!-- /.card -->
                </div>
                <!-- /.col -->
                <div class=""col-md-9"">
                    <div class=""card"">
                        <div class=""card-header p-2"">
                            <ul class=""nav nav-pills"">
                                <li class=""nav-item""><a class=""active nav-link"" href=""#settings"" data-toggle=""tab"">Information</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""#password"" data-toggle=""tab"">Password</a></li>
                            </ul>
                        </div><!-- /.card-header -->
                        <div class=""card-body"">
                            <div class=""tab-content"">


     ");
            WriteLiteral("                           <div class=\" active tab-pane\" id=\"settings\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4afb12a62162fa2971e8e98cef6c0f54d3b8b15611035", async() => {
                WriteLiteral(@"
                                        <div class=""form-group row"">
                                            <label for=""inputName"" class=""col-sm-2 col-form-label"">Full Name:</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""FullName"" name=""FullName""");
                BeginWriteAttribute("value", " value=\"", 3207, "\"", 3233, 1);
#nullable restore
#line 71 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 3215, Model.EmpFullname, 3215, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputName"" class=""col-sm-2 col-form-label"">User Name:</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""UserName"" name=""UserName""");
                BeginWriteAttribute("value", " value=\"", 3712, "\"", 3738, 1);
#nullable restore
#line 77 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 3720, Model.EmpUsername, 3720, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputEmail"" class=""col-sm-2 col-form-label"">Email:</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""Email"" name=""Email""");
                BeginWriteAttribute("value", " value=\"", 4209, "\"", 4232, 1);
#nullable restore
#line 83 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 4217, Model.EmpEmail, 4217, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputExperience"" class=""col-sm-2 col-form-label"">Phone:</label>
                                            <div class=""col-sm-10"">
                                                <input type=""number"" class=""form-control"" id=""Phone"" name=""Phone""");
                BeginWriteAttribute("value", " value=\"", 4709, "\"", 4732, 1);
#nullable restore
#line 89 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 4717, Model.EmpPhone, 4717, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputSkills"" class=""col-sm-2 col-form-label"">Address:</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""Address"" name=""Address""");
                BeginWriteAttribute("value", " value=\"", 5209, "\"", 5234, 1);
#nullable restore
#line 95 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 5217, Model.EmpAddress, 5217, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label class=""col-sm-2 col-form-label"" for=""exampleInputFile"">Avatar:</label>
                                            <div class=""col-sm-10"">
                                                <div class=""custom-file"">
                                                    <input type=""file"" class=""custom-file-input"" name=""AvatarStream"">
                                                    <label class=""custom-file-label"" for=""exampleInputFile"">Choose file</label>
                                                </div>

                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <div class=""offset-sm-2 col-sm-10"">
                           ");
                WriteLiteral("                     <button type=\"submit\" id=\"btn-edit\" class=\"btn btn-danger\">Save Changes</button>\r\n                                            </div>\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 67 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
AddHtmlAttributeValue("", 2782, Url.Action("EditAdmin","Admin"), 2782, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"tab-pane\" id=\"password\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4afb12a62162fa2971e8e98cef6c0f54d3b8b15619059", async() => {
                WriteLiteral(@"
                                        <div class=""form-group row"">
                                            <label for=""inputName"" class=""col-sm-2 col-form-label"">Current password</label>
                                            <div class=""col-sm-10"">
                                                <input type=""password"" class=""form-control"" id=""oldpass"" name=""currentPassword"" placeholder=""Current password "">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputEmail"" class=""col-sm-2 col-form-label"">New Password</label>
                                            <div class=""col-sm-10"">
                                                <input type=""password"" class=""form-control"" id=""newpass"" name=""newPassword"" placeholder=""Password"">
                                            </div>
                                  ");
                WriteLiteral(@"      </div>
                                        <div class=""form-group row"">
                                            <label for=""inputEmail"" class=""col-sm-2 col-form-label"">Confirm password</label>
                                            <div class=""col-sm-10"">
                                                <input type=""password"" class=""form-control"" id=""confirmpass"" name=""confirmPassword"" placeholder=""Confirm password"">
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <button type=""submit"" id=""btn-pass"" class=""btn btn-danger"">Save Changes</button>
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 117 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Admin\Profile.cshtml"
AddHtmlAttributeValue("", 6743, Url.Action("PasswordEmployee","Admin"), 6743, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <!-- /.tab-pane -->
                            </div>
                            <!-- /.tab-content -->
                        </div><!-- /.card-body -->
                    </div>
                    <!-- /.nav-tabs-custom -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>

<div class=""modal fade"" id=""modal-admin"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Thông báo</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Chỉnh xửa thông tin thành công</p>
            </");
            WriteLiteral(@"div>
            <div class=""modal-footer justify-content-end"">

                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        //Datemask dd/mm/yyyy
        $('#datemask').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' })
        $('[data-mask]').inputmask()

        $('#edit-admin').submit(function (e) {
            e.preventDefault();

            $('#edit-admin').validate({
                rules: {
                    
                    FullName: {
                        required: true,
                    },
                    UserName: {
                        required: true,
                        minlength: 6
                    },
                    Email: {
                        required: true,
                        email: true,
                    },
                    Phone: {
                        required: true,
                        minlength: 10,
                        maxlength: 10,
                        digits: true
                    },
                    Address: {
                        required: true
                    },



  ");
                WriteLiteral(@"              },
                messages: {
                    FullName: {
                        required: ""Nhập họ và tên đầy đủ""
                    },
                    UserName: {
                        required: ""Nhập tên đăng nhập"",
                        minlength: ""Tên đăng nhập phải dài hơn 6 ký tự""
                    },
                    Email: {
                        required: ""Nhập Email"",
                        email: ""Nhập email phù hợp""
                    },
                    Phone: {
                        required: ""Nhập số điện thoại"",
                        minlength: ""Số điện thoại phải có 10 số hợp lệ"",
                        maxlength: ""Số điện thoại phải có 10 số hợp lệ"",
                        digits: ""Số điện thoại phải có 10 số hợp lệ""
                    },
                    Address: {
                        required: ""Nhập địa chỉ""
                    },
                },
                errorElement: 'span',
                errorPla");
                WriteLiteral(@"cement: function (error, element) {
                    error.addClass('invalid-feedback');
                    element.closest('.form-group').append(error);
                }


            });
            if ($('#edit-admin').valid()) {
                var data = new FormData(this);
                $("".modal-footer #btn-edit"").attr(""disabled"", true);

                $("".modal-footer #btn-edit"").prepend('<span class=""spinner-border spinner-border-sm mr-1"" role=""status"" aria-hidden=""true""></span>')

                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: data,
                    cache: false,
                    contentType: false,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader(""XSRF-TOKEN"",
                            $('input:hidden[name=""__RequestVerificationToken""]').val());
                    },
                    processData: false,
                    success");
                WriteLiteral(@": function (response) {
                        $("".modal-footer #btn-edit"").attr(""disabled"", false);
                        $('.modal-footer #btn-edit .spinner-border').remove()
                        var a = JSON.parse(response);
                        if (a.IsSuccess == true) {
                            $(""#edit-adminpass input"").val("""");
                            defaultModal($(""#modal-admin""), a.Message);
                            $(""#modal-admin"").modal('show');
                        } else {
                            defaultModal($(""#modal-admin""), a.Message);
                            $(""#modal-admin"").modal('show');
                        }

                    },
                    error: function (xhr, error, status) {
                        //console.log(error, status);
                        Toast.fire({
                            icon: 'error',
                            title: 'Chỉnh sửa thông tin không thành công!!'
                        })
          ");
                WriteLiteral(@"          }
                });
            }


        });
        $('#edit-adminpass').submit(function (e) {
            e.preventDefault();
            $('#edit-adminpass').validate({
                rules: {

                    oldpass: {
                        required: true,
                        minlength: 6
                    },
                    newpass: {
                        required: true,
                        minlength: 6
                    },
                    confirmpass: {
                        required: true,
                        minlength: 6,
                        equalTo: ""#newpass""
                    },




                },
                messages: {

                    oldpass: {
                        required: ""Nhập mật khẩu"",
                        minlength: ""Mật khẩu phải có ít nhất 6 ký tự""
                    },
                    newpass: {
                        required: ""Nhập mật khẩu"",
                       ");
                WriteLiteral(@" minlength: ""Mật khẩu phải có ít nhất 6 ký tự""
                    },
                    confirmpass: {
                        equalTo: ""Xác nhận mật khẩu không đúng""
                    },
                },
                errorElement: 'span',
                errorPlacement: function (error, element) {
                    error.addClass('invalid-feedback');
                    element.closest('.form-group').append(error);
                }


            });
            if ($('#edit-adminpass').valid()) {
                var data = new FormData(this);
                $("".modal-footer #btn-pass"").attr(""disabled"", true);

                $("".modal-footer #btn-pass"").prepend('<span class=""spinner-border spinner-border-sm mr-1"" role=""status"" aria-hidden=""true""></span>')

                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: data,
                    cache: false,
                    contentType: false,
        ");
                WriteLiteral(@"            beforeSend: function (xhr) {
                        xhr.setRequestHeader(""XSRF-TOKEN"",
                            $('input:hidden[name=""__RequestVerificationToken""]').val());
                    },
                    processData: false,
                    success: function (response) {
                        $("".modal-footer #btn-pass"").attr(""disabled"", false);
                        $('.modal-footer #btn-pass .spinner-border').remove()
                        var a = JSON.parse(response);
                        if (a.IsSuccess == true) {
                            $(""#edit-adminpass input"").val("""");

                            defaultModal($(""#modal-admin""), a.Message);
                            $(""#modal-admin"").modal('show');
                        } else {

                        }

                    },
                    error: function (xhr, error, status) {
                        //console.log(error, status);
                        Toast.fire({
      ");
                WriteLiteral("                      icon: \'error\',\r\n                            title: \'Chỉnh sửa thông tin không thành công!!\'\r\n                        })\r\n                    }\r\n                });\r\n            }\r\n\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminLTEASPNETEmployees.Dtos.EmployeesReadDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
