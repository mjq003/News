#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb4aa2cf38c4e4b590dde8b122cf92df99d5b55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_NewsAdd), @"mvc.1.0.view", @"/Areas/Admin/Views/News/NewsAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/News/NewsAdd.cshtml", typeof(AspNetCore.Areas_Admin_Views_News_NewsAdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb4aa2cf38c4e4b590dde8b122cf92df99d5b55", @"/Areas/Admin/Views/News/NewsAdd.cshtml")]
    public class Areas_Admin_Views_News_NewsAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReleaseNews.Models.Response.ResponseModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(79, 25, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 1013, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fb4aa2cf38c4e4b590dde8b122cf92df99d5b553265", async() => {
                BeginContext(110, 1000, true);
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
    <!--[if IE 7]>
    <link href=""/admin/font/font-awesome-ie7.min.css"" rel=""stylesheet"" type=""text/css"" />
    <![endif]-->
    <title>添加新闻</title>
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
            BeginContext(1117, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1119, 3296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fb4aa2cf38c4e4b590dde8b122cf92df99d5b555503", async() => {
                BeginContext(1125, 869, true);
                WriteLiteral(@"
    <div class=""pd-20"">
        <div class=""Huiform"">
            <form method=""post"" enctype=""multipart/form-data"" id=""addForm"">
                <table class=""table table-bg"">
                    <tbody>
                        <tr>
                            <th width=""300"" class=""text-r""><span class=""c-red"">*</span> 新闻标题：</th>
                            <td>
                                <input type=""text"" style=""width:300px"" class=""input-text"" value="""" placeholder="""" id=""Title"" name=""Title"" datatype=""*2-16"" nullmsg=""新闻标题不能为空"">
                            </td>
                        </tr>
                        <tr>
                            <th class=""text-r""><span class=""c-red"">*</span> 新闻类别：</th>
                            <td>
                                <select class=""select"" id=""NewsClassifyId"" name=""NewsClassifyId"">
");
                EndContext();
#line 43 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                     if (Model.code == 200)
                                    {
                                        

#line default
#line hidden
#line 45 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                         foreach (var classify in Model.data)
                                        {

#line default
#line hidden
                BeginContext(2216, 51, true);
                WriteLiteral("                                            <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2267, "\"", 2287, 1);
#line 47 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
WriteAttributeValue("", 2275, classify.Id, 2275, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2288, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2290, 13, false);
#line 47 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                                                    Write(classify.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2303, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 48 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                        }

#line default
#line hidden
#line 48 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                         
                                    }

#line default
#line hidden
                BeginContext(2396, 2012, true);
                WriteLiteral(@"                                </select>
                            </td>
                        </tr>
                        <tr>
                            <th class=""text-r"">新闻图片：</th>
                            <td><input type=""file"" class=""img"" name=""img"" multiple datatype=""*2-120"" nullmsg=""新闻图片不能为空""></td>
                        </tr>
                        <tr>
                            <th class=""text-r"">新闻内容：</th>
                            <td><textarea class=""input-text"" name=""Contents"" id=""Contents"" style=""height:400px;width:350px;""></textarea></td>
                        </tr>
                        <tr>
                            <th></th>
                            <td><button class=""btn btn-success radius"" type=""button"" onclick=""add()""><i class=""icon-ok""></i> 确定</button></td>
                        </tr>
                    </tbody>
                </table>
            </form>
        </div>
    </div>
    <script type=""text/javascript"" src=""/admin/js/jquery.");
                WriteLiteral(@"min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/Validform_v5.3.2_min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.admin.js""></script>
    <script type=""text/javascript"">
        $("".Huiform"").Validform();
        function add() {
            var formData = new FormData(document.getElementById(""addForm""));
            $.ajax({
                type: 'post',
                async: false,
                cache: false,
                contentType: false,
                processData: false,
                url: '/Admin/News/AddNews',
                data: formData,
                success: function (data) {
                    if (data.code == 200) {
                        parent.reload();
                    } else {
                        alert(data.result);
                    }
                }
            });
        }
    </script>

");
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
            BeginContext(4415, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReleaseNews.Models.Response.ResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
