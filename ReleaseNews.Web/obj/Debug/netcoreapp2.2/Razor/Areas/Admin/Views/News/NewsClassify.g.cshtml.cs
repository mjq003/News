#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bcae4900b99295426a1e173afca14ddd988480a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_NewsClassify), @"mvc.1.0.view", @"/Areas/Admin/Views/News/NewsClassify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/News/NewsClassify.cshtml", typeof(AspNetCore.Areas_Admin_Views_News_NewsClassify))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bcae4900b99295426a1e173afca14ddd988480a", @"/Areas/Admin/Views/News/NewsClassify.cshtml")]
    public class Areas_Admin_Views_News_NewsClassify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReleaseNews.Models.Response.ResponseModel>
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
#line 2 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(79, 25, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 1013, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bcae4900b99295426a1e173afca14ddd988480a3305", async() => {
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
    <title>新闻类别</title>
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
            BeginContext(1119, 3398, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bcae4900b99295426a1e173afca14ddd988480a5543", async() => {
                BeginContext(1125, 1051, true);
                WriteLiteral(@"
    <nav class=""Hui-breadcrumb""><i class=""icon-home""></i> 首页 <span class=""c-gray en"">&gt;</span> 新闻中心 <span class=""c-gray en"">&gt;</span> 新闻类别 <a class=""btn btn-success radius r mr-20"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""icon-refresh""></i></a></nav>
    <div class=""pd-20"">
        <div class=""cl pd-5 bg-1 bk-gray mt-20"">
            <span class=""l""><a href=""javascript:;"" onClick=""user_add('550','300','添加新闻类别','/Admin/News/NewsClassifyAdd')"" class=""btn btn-primary radius""><i class=""icon-plus""></i> 添加新闻类别</a></span>

        </div>

        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""80"">ID</th>
                    <th width=""200"">类别名称</th>
                    <th width=""90"">排序</th>
                    <th>备注</th>
                    <th width=""200"">操作</th>
                </tr>
            </th");
                WriteLiteral("ead>\r\n            <tbody>\r\n");
                EndContext();
#line 46 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
                 if (Model.code == 200)
                {
                    

#line default
#line hidden
#line 48 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
                     foreach (var m in Model.data)
                    {

#line default
#line hidden
                BeginContext(2311, 77, true);
                WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td>");
                EndContext();
                BeginContext(2389, 4, false);
#line 51 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
                           Write(m.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2393, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2433, 6, false);
#line 52 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
                           Write(m.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2439, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2479, 6, false);
#line 53 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
                           Write(m.Sort);

#line default
#line hidden
                EndContext();
                BeginContext(2485, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2525, 8, false);
#line 54 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
                           Write(m.Remark);

#line default
#line hidden
                EndContext();
                BeginContext(2533, 106, true);
                WriteLiteral("</td>\r\n                            <td>\r\n                                <a title=\"编辑\" href=\"javascript:;\"");
                EndContext();
                BeginWriteAttribute("onClick", " onClick=\"", 2639, "\"", 2720, 3);
                WriteAttributeValue("", 2649, "user_edit(\'4\',\'550\',\'300\',\'编辑\',\'/Admin/News/NewsClassifyEdit?id=", 2649, 64, true);
#line 56 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
WriteAttributeValue("", 2713, m.Id, 2713, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 2718, "\')", 2718, 2, true);
                EndWriteAttribute();
                BeginContext(2721, 139, true);
                WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\"><i class=\"icon-edit\"></i></a>\r\n                                <a title=\"删除\" href=\"javascript:;\"");
                EndContext();
                BeginWriteAttribute("onClick", " onClick=\"", 2860, "\"", 2887, 3);
                WriteAttributeValue("", 2870, "del(this,\'", 2870, 10, true);
#line 57 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
WriteAttributeValue("", 2880, m.Id, 2880, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 2885, "\')", 2885, 2, true);
                EndWriteAttribute();
                BeginContext(2888, 141, true);
                WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\"><i class=\"icon-trash\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 60 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
                    }

#line default
#line hidden
#line 60 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\NewsClassify.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(3071, 1439, true);
                WriteLiteral(@"
            </tbody>
        </table>
    </div>
    <script type=""text/javascript"" src=""/admin/js/jquery.min.js""></script>
    <script type=""text/javascript"" src=""/admin/layer/layer.min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/pagenav.cn.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.js""></script>
    <script type=""text/javascript"" src=""/admin/plugin/My97DatePicker/WdatePicker.js""></script>
    <script type=""text/javascript"" src=""/admin/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.admin.js""></script>
    <script type=""text/javascript"">
        function del(obj, id) {
            layer.confirm('确认要删除吗？', function (index) {
                $.ajax({
                    type: 'post',
                    async: true,
                    url: '/Admin/News/DelNewsClassify',
                    data: { id: id },
                    success: function (result) {
                        if (result.code == ");
                WriteLiteral(@"200) {
                            layer.msg('已删除!', 1);
                            reload();
                        }
                        else {
                            layer.msg(result.result, 1);
                        }
                    }
                });
            });
        }
        function reload() {
            location.replace(location.href);
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
            BeginContext(4517, 9, true);
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
