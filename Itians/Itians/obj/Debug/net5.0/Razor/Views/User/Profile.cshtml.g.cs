#pragma checksum "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e806fa32f4b2eeaadf064c5b8cb0f13bcf9f968f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#line 1 "C:\Users\Haleem\source\repos\Itians\Itians\Views\_ViewImports.cshtml"
using Itians;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Haleem\source\repos\Itians\Itians\Views\_ViewImports.cshtml"
using Itians.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Haleem\source\repos\Itians\Itians\Views\_ViewImports.cshtml"
using Itians.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Haleem\source\repos\Itians\Itians\Views\_ViewImports.cshtml"
using Itians.Controllers.HelperClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Haleem\source\repos\Itians\Itians\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e806fa32f4b2eeaadf064c5b8cb0f13bcf9f968f", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c000facd82696f7dfe9a0cd5222bb21053d772", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Source/css/UserProfileStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid profile-cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Source/images/profile-cover.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-pic border border-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Source/images/profile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Source/js/UserProfileScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
  
    ViewData["Title"] = @ViewBag.user.Username;
    Layout = "~/Views/Shared/_LayoutMain.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e806fa32f4b2eeaadf064c5b8cb0f13bcf9f968f7243", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"profile-page\">\r\n    <div class=\"container-fluid px-0\">\r\n");
#nullable restore
#line 14 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
         if (ViewBag.user.Cover == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e806fa32f4b2eeaadf064c5b8cb0f13bcf9f968f8802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e806fa32f4b2eeaadf064c5b8cb0f13bcf9f968f10227", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 621, "~/Attachments/Covers/", 621, 21, true);
#nullable restore
#line 23 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
AddHtmlAttributeValue("", 642, ViewBag.user.Cover, 642, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"container mt-5\">\r\n        <div class=\"profile-info\">\r\n            <div class=\"container nameAndPic\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"d-flex\">\r\n");
#nullable restore
#line 34 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                             if (ViewBag.user.Image == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e806fa32f4b2eeaadf064c5b8cb0f13bcf9f968f12656", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e806fa32f4b2eeaadf064c5b8cb0f13bcf9f968f14162", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1545, "~/Attachments/Images/", 1545, 21, true);
#nullable restore
#line 43 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
AddHtmlAttributeValue("", 1566, ViewBag.user.Image, 1566, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2 class=\"align-self-center ms-md-4 text-light\">\r\n                            ");
#nullable restore
#line 47 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                       Write(ViewBag.user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""container company-page"" id=""forLanding"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""company-information mt-5"">
                <div class=""row information"">
                    <div>
                        <h3 class=""border-bottom"">Contact Information</h3>
");
#nullable restore
#line 65 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                         if (ViewBag.user.UserProfile.FormalEmail != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5>\r\n                                <i class=\"fas fa-envelope-square fa-2x contact-icons\"></i>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2554, "\"", 2605, 2);
            WriteAttributeValue("", 2561, "mailto:", 2561, 7, true);
#nullable restore
#line 69 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
WriteAttributeValue("", 2568, ViewBag.user.UserProfile.FormalEmail, 2568, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                   class=\"link-primary\">");
#nullable restore
#line 70 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                   Write(ViewBag.user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n");
#nullable restore
#line 72 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                         if (ViewBag.user.UserProfile.Linkedin != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5>\r\n                                <i class=\"fab fa-linkedin fa-2x me-2 contact-icons\"></i><a class=\"link-dark\"");
            BeginWriteAttribute("href", "\r\n                                    href=\"", 2996, "\"", 3074, 1);
#nullable restore
#line 77 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
WriteAttributeValue("", 3040, ViewBag.user.UserProfile.Linkedin, 3040, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                         Write(ViewBag.user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n");
#nullable restore
#line 79 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                         if (ViewBag.user.UserProfile.Github != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5>\r\n                                <i class=\"fab fa-github-square fa-2x me-2 contact-icons\"></i><a class=\"link-dark\"");
            BeginWriteAttribute("href", "\r\n                                                                                                href=\"", 3411, "\"", 3547, 1);
#nullable restore
#line 84 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
WriteAttributeValue("", 3515, ViewBag.user.UserProfile.Github, 3515, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 84 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                                                                                   Write(ViewBag.user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n");
#nullable restore
#line 86 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <h3 class=\"border-bottom\">About Me</h3>\r\n                        <p>\r\n                            ");
#nullable restore
#line 91 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                       Write(ViewBag.user.UserProfile.AboutMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 93 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                         if (ViewBag.user.UserProfile.Cv != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 4005, "\"", 4057, 2);
            WriteAttributeValue("", 4012, "/User/DownloadCv/", 4012, 17, true);
#nullable restore
#line 95 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
WriteAttributeValue("", 4029, ViewBag.user.UserProfile.Cv, 4029, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Download CV</a>\r\n");
#nullable restore
#line 96 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <h3 class=\"border-bottom\">Salary Information</h3>\r\n                        <ul>\r\n");
#nullable restore
#line 101 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                             if (@ViewBag.user.UserProfile.CurrrentSalary != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>Current Salary: ");
#nullable restore
#line 103 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                               Write(ViewBag.user.UserProfile.CurrrentSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                            \r\n                            \r\n");
#nullable restore
#line 106 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                             if (ViewBag.user.UserProfile.Currency == "1")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span> LE </span>\r\n");
#nullable restore
#line 109 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                            }
                            else if (ViewBag.user.UserProfile.Currency == "2")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span> USD </span>\r\n");
#nullable restore
#line 113 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 116 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                            }
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                             if (ViewBag.user.UserProfile.CurrrentSalary != null)
                            {
                                if (ViewBag.user.UserProfile.IsYearlyMonthly)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>Monthly</li>\r\n");
#nullable restore
#line 123 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>Yearly</li>\r\n");
#nullable restore
#line 127 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                    <div>\r\n                        <h3 class=\"border-bottom\">Experience</h3>\r\n");
#nullable restore
#line 135 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                         foreach (var experience in ViewBag.user.UserProfile.UserExperiences)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"experience mt-3\">\r\n                                <div class=\"d-flex\">\r\n                                    <h4> ");
#nullable restore
#line 139 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                    Write(experience.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                                    <h6 class=\"text-secondary lh-lg ms-2\">at ");
#nullable restore
#line 140 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                        Write(experience.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 143 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                               Write(experience.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                                <div class=""d-flex flex-column flex-lg-column align-items-lg-center"">
                                    <div class=""border border-danger text-danger p-2 rounded m-2"">
                                        From : ");
#nullable restore
#line 147 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                          Write(experience.StartingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" To : ");
#nullable restore
#line 147 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                                               Write(experience.EndingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"border border-danger text-danger p-2 rounded m-2\">\r\n                                        ");
#nullable restore
#line 150 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                   Write(experience.LocationCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 150 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                 Write(experience.LocationState);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 150 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                                             Write(experience.LocationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 154 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <h3 class=\"border-bottom\">Education</h3>\r\n");
#nullable restore
#line 159 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                         foreach (var education in ViewBag.user.UserProfile.UserEducations)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"education mt-3\">\r\n                                <div class=\"d-flex\">\r\n                                    <h4>");
#nullable restore
#line 163 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                   Write(education.Universty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <h6 class=\"text-secondary lh-lg ms-2\">, ");
#nullable restore
#line 164 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                       Write(education.Major);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 167 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                               Write(education.CertificateDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                                <div class=""d-flex flex-column flex-lg-row align-items-lg-center"">
                                    <div class=""border border-danger text-danger p-2 rounded m-2"">
                                        GPA:");
#nullable restore
#line 171 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                       Write(education.Gpa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"border border-danger text-danger p-2 rounded m-2\">\r\n                                        Percentage:");
#nullable restore
#line 174 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                              Write(education.Percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""d-flex flex-column"">
                                    <span class=""border border-danger text-danger p-2 rounded m-2"">From : ");
#nullable restore
#line 178 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                                                     Write(education.StartingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" To : ");
#nullable restore
#line 178 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                                                                                                                                                         Write(education.EndingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 181 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-8\">\r\n            <input id=\"post-author\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 8968, "\"", 8996, 1);
#nullable restore
#line 187 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
WriteAttributeValue("", 8976, ViewBag.user.UserId, 8976, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 188 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
             if (ViewBag.user.UserId == int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div id=""post-area"">
                    <div class=""card mt-5"">
                        <div class=""card-body"">
                            <div>
                                <textarea id=""post-body"" class=""form-control"" rows=""4"" placeholder=""What's on your mind, Name?""></textarea>
                            </div>
                            <div class=""d-flex flex-row-reverse"">
                                <button id=""post-submit"" class=""btn btn-outline-success mt-3"">Post</button>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 202 "C:\Users\Haleem\source\repos\Itians\Itians\Views\User\Profile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"posts\">\r\n");
            WriteLiteral("                <div id=\"post-section\">\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"goUp\" id=\"goUp\">\r\n    <a href=\"#forLanding\"><i class=\"fas fa-chevron-circle-up fa-3x\"></i></a>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e806fa32f4b2eeaadf064c5b8cb0f13bcf9f968f35631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
    $(""#post-submit"").on(""click"", function () {
        // Check Text Area first
        if ($(""#post-body"").val().trim() != """") {
            if ($(""#post-submit"").html() == ""Edit"") {
                $.get(""/User/EditPost"", { id: $(""#carry-edit-post"").val(), body: $(""#post-body"").val() }, function () {
                    /*alert(""Post successfully Edit ^_^"");*/
                    $(""#post-body"").val("""");
                    $(""#post-submit"").html(""Post"");
                    let id = $(""#post-author"").val();
                    $(""#post-section"").load(""/User/LoadPost/"" + id);
                });
            } else {
                let id = $(""#post-author"").val();
                $.get(""/User/AddPost"", { authorId:id , body: $(""#post-body"").val() }, function () {
                    $(""#post-section"").load(""/User/LoadPost/"" + id);
                    $(""#post-body"").val("""");
                });
            }
        } else {
            $(""#post-body"").val("""");
        ");
                WriteLiteral("    $(\"#post-body\").focus();\r\n        }\r\n\r\n    });\r\n    $(window).on(\"load\", function () {\r\n        let id = $(\"#post-author\").val();\r\n        $(\"#post-section\").load(\"/User/LoadPost/\" + id);\r\n    });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591