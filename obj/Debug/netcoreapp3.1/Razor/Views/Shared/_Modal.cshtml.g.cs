#pragma checksum "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2cbf3205dd0e2d72525b7fa98300f2ede75525e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Modal), @"mvc.1.0.view", @"/Views/Shared/_Modal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cbf3205dd0e2d72525b7fa98300f2ede75525e", @"/Views/Shared/_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823c98bf635e7ab8ddca3cc7a0ac05155bd37ff0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("edit-e"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add-a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("password-p"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!--  EDIT MODAL -->
<div class=""modal fade"" id=""modal-edit"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Edit </h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2cbf3205dd0e2d72525b7fa98300f2ede75525e5589", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <input type=""text"" hidden class=""form-control"" id=""EmpId"" name=""EmpId"">
                    <div class=""form-group"">
                        <label for=""InputUsername"">User Name</label>
                        <input type=""text"" class=""form-control"" id=""EmpUsername"" name=""EmpUsername"" placeholder=""Enter User Name..."">
                    </div>
                    <div hidden class=""form-group"">
                        <label for=""InputPassword"">Password</label>
                        <input type=""password"" class=""form-control"" id=""EmpPass"" name=""EmpPass"" placeholder=""Password..."">
                    </div>
                    <div class=""form-group"">
                        <label for=""InputFullname"">Full Name</label>
                        <input type=""text"" class=""form-control"" id=""EmpFullname"" name=""EmpFullname"" placeholder=""Full Name..."">
                    </div>
                    <div class=""form-group"">
               ");
                WriteLiteral(@"         <label for=""InputEmail"">Email</label>
                        <input type=""email"" class=""form-control"" id=""EmpEmail"" name=""EmpEmail"" placeholder=""Email..."">
                    </div>
                    <div class=""form-group"">
                        <label for=""InputPhone"">Phone Number</label>
                        <input type=""text"" class=""form-control"" id=""EmpPhone"" name=""EmpPhone"" placeholder=""Phone Number..."">
                    </div>
                    <div class=""form-group"">
                        <label>Address</label>
                        <textarea id=""EmpAddress"" name=""EmpAddress"" class=""form-control"" rows=""2"" placeholder=""Enter Address...""></textarea>
                    </div>

                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label for=""InputAvatar"">Avatar</label>
                                <div class=""input-group"">
                  ");
                WriteLiteral(@"                  <div class=""custom-file"">
                                        <input type=""file"" class=""custom-file-input"" id=""EmpAvatarStream"" name=""EmpAvatarStream"">
                                        <label class=""custom-file-label"" for=""InputFile"">Choose file</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div hidden class=""col-sm-6"">
                            <div class=""form-group"">
                                <label>Status</label>
                                <select id=""EmpStatus"" name=""EmpStatus"" class=""custom-select"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2cbf3205dd0e2d72525b7fa98300f2ede75525e8824", async() => {
                    WriteLiteral("Active");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2cbf3205dd0e2d72525b7fa98300f2ede75525e9874", async() => {
                    WriteLiteral("DeActive");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer justify-content-between"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
");
                WriteLiteral("                    <button id=\"btn-edit\" type=\"submit\" class=\"btn btn-primary\">\r\n                        Save changes\r\n                    </button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_Modal.cshtml"
AddHtmlAttributeValue("", 629, Url.Action("EditEmployee","Admin"), 629, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->
<!-- POPUP MSG EDIT SUCCESS -->
<div class=""modal fade"" id=""modal-default-edit-success"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Edit</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Edit successfully !</p>
            </div>
            <div class=""modal-footer justify-content-end"">
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>





<!-- ADD MODAL -->
<div class=""modal fade"" id=""modal-lg-add"">");
            WriteLiteral(@"
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Add New</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2cbf3205dd0e2d72525b7fa98300f2ede75525e14801", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""card-body"">

                        <input type=""text"" hidden class=""form-control"" id=""EmpId"" name=""EmpId"">
                        <div class=""form-group"">
                            <label for=""InputUsername"">User Name</label>
                            <input type=""text"" class=""form-control"" name=""EmpUsername"" placeholder=""Enter User Name..."">
                        </div>
                        <div class=""form-group"">
                            <label for=""InputPassword"">Password</label>
                            <input type=""password"" class=""form-control"" name=""EmpPass"" placeholder=""Password..."">
                        </div>
                        <div class=""form-group"">
                            <label for=""InputFullname"">Full Name</label>
                            <input type=""text"" class=""form-control"" name=""EmpFullname"" placeholder=""Full Name..."">
                        </div>
                ");
                WriteLiteral(@"        <div class=""form-group"">
                            <label for=""InputEmail"">Email</label>
                            <input type=""email"" class=""form-control"" name=""EmpEmail"" placeholder=""Email..."">
                        </div>
                        <div class=""form-group"">
                            <label for=""InputPhone"">Phone Number</label>
                            <input type=""text"" class=""form-control"" name=""EmpPhone"" placeholder=""Phone Number..."">
                        </div>
                        <div class=""form-group"">
                            <label>Address</label>
                            <textarea name=""EmpAddress"" class=""form-control"" rows=""2"" placeholder=""Enter Address...""></textarea>
                        </div>

                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <!-- text input -->
                                <div class=""form-group"">
                                    ");
                WriteLiteral(@"<label for=""InputAvatar"">Avatar</label>
                                    <div class=""input-group"">
                                        <div class=""custom-file"">
                                            <input type=""file"" class=""custom-file-input"" id=""EmpAvatarStream"" name=""EmpAvatarStream"">
                                            <label class=""custom-file-label"" for=""InputFile"">Choose file</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
                WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""modal-footer justify-content-between"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    <button id=""btn-add"" type=""submit"" class=""btn btn-primary"">
                        Save
                    </button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 116 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_Modal.cshtml"
AddHtmlAttributeValue("", 5653, Url.Action("AddEmployee","Admin"), 5653, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- /.modal -->
<!-- POPUP MSG ADD SUCCESS -->
<div class=""modal fade"" id=""modal-default-add-success"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Add</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Add successfully !</p>
            </div>
            <div class=""modal-footer justify-content-end"">
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>





<!-- DELETE MODAL -->
<div class=""modal fade"" id=""modal-delete"">
    <div class=""modal-dialog modal-sm"">
        <div class=""m");
            WriteLiteral(@"odal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Delete</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                <p>Are you sure to delete?</p>
            </div>
            <div class=""modal-footer justify-content-between"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
");
            WriteLiteral(@"                <button id=""delete-d"" type=""submit"" class=""btn btn-primary"">
                    Delete
                </button>
            </div>

        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->
<!-- POPUP MSG DELETE SUCCESS -->
<div class=""modal fade"" id=""modal-sm-del-success"">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Delete</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                <p>Delete Successfully !</p>
            </div>
            <div class=""modal-footer justify-content-end"">
                <button id=""delete-d"" type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            <");
            WriteLiteral(@"/div>

        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->
<!-- PASSWORD MODAL -->
<div class=""modal fade"" id=""modal-password"">
    <div class=""modal-dialog "">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Change your password</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2cbf3205dd0e2d72525b7fa98300f2ede75525e23632", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <input type=""text"" hidden class=""form-control"" id=""EmpId"" name=""EmpId"">
                    <div class=""form-group row"">
                        <label for=""inputEmail"" class=""col-sm-4 col-form-label"">New password</label>
                        <div class=""col-sm-8"">
                            <input type=""password"" class=""form-control"" id=""EmpPass"" name=""EmpPass"" placeholder=""Password"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""inputEmail"" class=""col-sm-4 col-form-label"">Confirm password</label>
                        <div class=""col-sm-8"">
                            <input type=""password"" class=""form-control"" id=""EmpCofPass"" name=""EmpCofPass"" placeholder=""Confirm password"">
                        </div>
                    </div>
                </div>
                <div class=""modal-footer justify-content-between"">
       ");
                WriteLiteral(@"             <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    <button id=""btn-password"" type=""submit"" class=""btn btn-primary"">
                        Save changes
                    </button>
                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 270 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_Modal.cshtml"
AddHtmlAttributeValue("", 12714, Url.Action("PasswordEmployee","Admin"), 12714, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
