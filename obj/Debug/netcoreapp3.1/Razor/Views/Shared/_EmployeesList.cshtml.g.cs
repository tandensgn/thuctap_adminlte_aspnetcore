#pragma checksum "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af52c4bf9c3768663a7e8de8af1315e22ebfd38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmployeesList), @"mvc.1.0.view", @"/Views/Shared/_EmployeesList.cshtml")]
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
#nullable restore
#line 1 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
using AdminLTEASPNETEmployees.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af52c4bf9c3768663a7e8de8af1315e22ebfd38", @"/Views/Shared/_EmployeesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823c98bf635e7ab8ddca3cc7a0ac05155bd37ff0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmployeesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminLTEASPNETEmployees.Dtos.EmployeesReadDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
  
    int ID = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-12"">
    <div class=""card"">
        <div class=""card-header"">
            <div class=""card-tools"">
                <div class=""input-group input-group-sm"">
                    <button class=""btn btn-primary float-right"" data-toggle=""modal""
                            data-target=""#modal-lg-add"">
                        + Add new Employee
                    </button>
                </div>
            </div>
        </div>
        <!-- /.card-header -->
        <div class=""card-body"">
            <table id=""example1"" class=""table table-bordered table-striped"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Avatar</th>
                        <th>Full Name</th>
                        <th>Email</th>
                        <th>Phone</th>
                        <th>Address</th>
                        <th>Password</th>
                        <th");
            BeginWriteAttribute("style", " style=\"", 1091, "\"", 1099, 0);
            EndWriteAttribute();
            WriteLiteral(">Action</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 34 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                     foreach (EmployeesReadDto item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n");
            WriteLiteral("                            <td>\r\n");
#nullable restore
#line 40 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                  ID = ID + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 41 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                           Write(ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"d-flex justify-content-center\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7af52c4bf9c3768663a7e8de8af1315e22ebfd387453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1678, "~/images/", 1678, 9, true);
#nullable restore
#line 46 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
AddHtmlAttributeValue("", 1687, item.EmpAvatar, 1687, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 50 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                           Write(item.EmpFullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                           Write(item.EmpEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                           Write(item.EmpPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                           Write(item.EmpAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td>
                                <button type=""button"" class=""btn btn-info""
                                        data-toggle=""modal""
                                        data-target=""#modal-password""
                                        data-id=""");
#nullable restore
#line 58 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                            Write(item.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    Change
                                </button>
                            </td>
                            <td>
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-warning""
                                            data-toggle=""modal""
                                            data-target=""#modal-edit""
                                            data-id=""");
#nullable restore
#line 67 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                Write(item.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-username=\"");
#nullable restore
#line 68 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                      Write(item.EmpUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-fullname=\"");
#nullable restore
#line 69 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                      Write(item.EmpFullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-email=\"");
#nullable restore
#line 70 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                   Write(item.EmpEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-password=\"");
#nullable restore
#line 71 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                      Write(item.EmpPass);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-phone=\"");
#nullable restore
#line 72 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                   Write(item.EmpPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-address=\"");
#nullable restore
#line 73 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                     Write(item.EmpAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-avatar=\"");
#nullable restore
#line 74 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                    Write(item.EmpAvatar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-role=\"");
#nullable restore
#line 75 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                  Write(item.RoleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                            data-status=\"");
#nullable restore
#line 76 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                    Write(item.EmpStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        Edit\r\n                                    </button>\r\n                                    <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#modal-delete\" data-id=\"");
#nullable restore
#line 79 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                                                                                                                                     Write(item.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        Delete\r\n                                    </button>\r\n                                </div>\r\n\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 87 "D:\ThucTap\CongTyGiao\AdminLTEinASPNETCoreMVC\AdminLTEASPNETEmployees\Views\Shared\_EmployeesList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- /.card-body -->\r\n    </div>\r\n    <!-- /.card -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminLTEASPNETEmployees.Dtos.EmployeesReadDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
