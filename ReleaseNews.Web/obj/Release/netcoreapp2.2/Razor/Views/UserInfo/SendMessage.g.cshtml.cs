#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a96e6e21f3950e9d8c4ba8a46b28ee710660bf91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInfo_SendMessage), @"mvc.1.0.view", @"/Views/UserInfo/SendMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserInfo/SendMessage.cshtml", typeof(AspNetCore.Views_UserInfo_SendMessage))]
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
#line 1 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\_ViewImports.cshtml"
using ReleaseNews.Web;

#line default
#line hidden
#line 2 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\_ViewImports.cshtml"
using ReleaseNews.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96e6e21f3950e9d8c4ba8a46b28ee710660bf91", @"/Views/UserInfo/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5b9b23ede2d135d1779d349fb893e872c87ab0", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInfo_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\SendMessage.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 25, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(54, 1431, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96e6e21f3950e9d8c4ba8a46b28ee710660bf914927", async() => {
                BeginContext(60, 1418, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""renderer"" content=""webkit|ie-comp|ie-stand"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"" />
    <meta http-equiv=""Cache-Control"" content=""no-siteapp"" />
    <!--[if lt IE 9]>
    <script type=""text/javascript"" src=""/admin/js/html5.js""></script>
    <script type=""text/javascript"" src=""/admin/js/respond.min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/PIE_IE678.js""></script>
    <![endif]-->
    <link type=""text/css"" rel=""stylesheet"" href=""/admin/css/H-ui.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""/admin/css/H-ui.admin.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""/admin/font/font-awesome.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/nprogress.css"">
    <link rel=""stylesheet"" type=");
                WriteLiteral(@"""text/css"" href=""/css/style.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/font-awesome.min.css"">
    <link rel=""apple-touch-icon-precomposed"" href=""/images/icon.png"">
    <link rel=""shortcut icon"" href=""/images/favicon.ico"">
    <!--[if IE 7]>
    <link href=""font/font-awesome-ie7.min.css"" rel=""stylesheet"" type=""text/css"" />
    <![endif]-->
    <title>添加Banner</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1485, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1487, 2363, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96e6e21f3950e9d8c4ba8a46b28ee710660bf917650", async() => {
                BeginContext(1493, 70, true);
                WriteLiteral("\r\n    <div class=\"pd-20\">\r\n        <div class=\"Huiform\">\r\n            ");
                EndContext();
                BeginContext(1563, 1057, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96e6e21f3950e9d8c4ba8a46b28ee710660bf918112", async() => {
                    BeginContext(1626, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(1645, 52, false);
#line 36 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\SendMessage.cshtml"
           Write(Html.Hidden("SendMessageUserId", ViewData["UserId"]));

#line default
#line hidden
                    EndContext();
                    BeginContext(1697, 226, true);
                    WriteLiteral("\r\n                <table class=\"table table-bg\">\r\n                    <tbody>\r\n                        <tr>\r\n                            <th class=\"text-r\"></th>\r\n                            <td><label style=\"font-size:15px;\">");
                    EndContext();
                    BeginContext(1924, 20, false);
#line 41 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\SendMessage.cshtml"
                                                          Write(ViewData["UserName"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1944, 669, true);
                    WriteLiteral(@"</label></td>
                        </tr>
                        <tr>
                            <th class=""text-r"">消息内容：</th>
                            <td><textarea class=""input-text"" name=""Message"" id=""Message"" style=""height:200px;width:300px;""></textarea></td>
                        </tr>
                        <tr>
                            <th></th>
                            <td><button class=""btn btn-default btn-search"" type=""button"" onclick=""sendMessage()"" style=""margin-left:80px; width:150px;""><i class=""icon-ok""></i> 确定</button></td>
                        </tr>
                    </tbody>
                </table>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2620, 1223, true);
                WriteLiteral(@"
        </div>
    </div>
    <script type=""text/javascript"" src=""/admin/js/jquery.min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/Validform_v5.3.2_min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.admin.js""></script>
    <script type=""text/javascript"">
        $("".Huiform"").Validform();
        function sendMessage() {
            var formData = new FormData(document.getElementById(""addForm""));
            $.ajax({
                type: 'post',
                async: false,
                cache: false,
                contentType: false,
                processData: false,
                url: '/UserInfo/AddUserSendMessage',
                data: formData,
                success: function (data) {
                    if (data.code == 200) {
                        alert(data.result);
                        parent.reload();
                    } else {
                   ");
                WriteLiteral("     alert(data.result);\r\n                    }\r\n                }\r\n            });\r\n        }\r\n        function reload() {\r\n            location.replace(location.href);\r\n        }\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3850, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
