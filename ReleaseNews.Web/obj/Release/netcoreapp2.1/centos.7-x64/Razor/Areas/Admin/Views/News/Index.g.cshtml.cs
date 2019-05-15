#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5196f916ac86172dcfb5cdea901c30ad59569025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/News/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_News_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5196f916ac86172dcfb5cdea901c30ad59569025", @"/Areas/Admin/Views/News/Index.cshtml")]
    public class Areas_Admin_Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReleaseNews.Models.Response.ResponseModel>
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
#line 2 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(79, 25, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 1013, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "482b95f1df5645c7a32b539fd7bd7779", async() => {
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
    <title>新闻管理</title>
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
            BeginContext(1119, 6748, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7527b2169ef54a17965e672d444ea618", async() => {
                BeginContext(1125, 528, true);
                WriteLiteral(@"
    <nav class=""Hui-breadcrumb""><i class=""icon-home""></i> 首页 <span class=""c-gray en"">&gt;</span> 新闻中心 <span class=""c-gray en"">&gt;</span> 新闻管理 <a class=""btn btn-success radius r mr-20"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""icon-refresh""></i></a></nav>
    <div class=""pd-20"">
        <div class=""text-c"">
            新闻类别:
            <select class=""select"" id=""classifyId"" name=""classifyId"">
                <option value=""0"">选择一个新闻类别</option>
");
                EndContext();
#line 34 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\Index.cshtml"
                 if (Model.code == 200)
                {
                    

#line default
#line hidden
#line 36 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\Index.cshtml"
                     foreach (var classify in Model.data)
                    {

#line default
#line hidden
                BeginContext(1795, 31, true);
                WriteLiteral("                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1826, "\"", 1846, 1);
#line 38 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\Index.cshtml"
WriteAttributeValue("", 1834, classify.Id, 1834, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1847, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1849, 13, false);
#line 38 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\Index.cshtml"
                                                Write(classify.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1862, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 39 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\Index.cshtml"
                    }

#line default
#line hidden
#line 39 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Areas\Admin\Views\News\Index.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(1915, 5945, true);
                WriteLiteral(@"            </select>
            &nbsp;
            <input type=""text"" class=""input-text"" style=""width:250px"" placeholder=""输入新闻标题"" id=""keyword"" name=""keyword"">&nbsp;<button type=""button"" class=""btn btn-success"" onclick=""search()""><i class=""icon-search""></i> 搜新闻</button>

        </div>
        <div class=""cl pd-5 bg-1 bk-gray mt-20"">
            <span class=""l"">
                <a href=""javascript:;"" onClick=""user_add('550','700','添加新闻','/Admin/News/NewsAdd')"" class=""btn btn-primary radius""><i class=""icon-plus""></i> 添加新闻</a>
            </span>

        </div>
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""80"">ID</th>
                    <th width=""100"">类别名称</th>
                    <th width=""300"">标题</th>
                    <th>内容</th>
                    <th width=""150"">发布日期</th>
                    <th width=""200"">备注</th>
                    <th width=""100""");
                WriteLiteral(@">操作</th>
                </tr>
            </thead>
            <tbody id=""news_contents""></tbody>
        </table>
        <div id=""pageNav"" class=""pageNav""></div>
    </div>
    <script type=""text/javascript"" src=""/admin/js/jquery.min.js""></script>
    <script type=""text/javascript"" src=""/admin/layer/layer.min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/pagenav.cn.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.js""></script>
    <script type=""text/javascript"" src=""/admin/plugin/My97DatePicker/WdatePicker.js""></script>
    <script type=""text/javascript"" src=""/admin/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.admin.js""></script>
    <script type=""text/javascript"">
        var pageSize = 15;
        var pageIndex = 1;
        var currentPageCount = 0;
        var classifyId = 0;
        var keyword = """";
        var lastPage = 1;
        window.onload = (function () {
            // optional set
  ");
                WriteLiteral(@"          pageNav.pre = ""&lt;上一页"";
            pageNav.next = ""下一页&gt;"";
            getNews(pageIndex, pageSize, classifyId, keyword);
        });
        $('.table-sort').dataTable({
            ""lengthMenu"": false,//显示数量选择
            ""bFilter"": false,//过滤功能
            ""bPaginate"": false,//翻页信息
            ""bInfo"": false,//数量信息
            ""aaSorting"": [[1, ""desc""]],//默认第几个排序
            ""bStateSave"": true,//状态保存
            ""aoColumnDefs"": [
                //{""bVisible"": false, ""aTargets"": [ 3 ]} //控制列的隐藏显示
                { ""orderable"": false, ""aTargets"": [0, 1, 2, 3, 4, 5, 6, 7] }// 制定列不参与排序
            ]
        });
        function search() {
            var classifyId = $(""#classifyId"").val();
            var keyword = $(""#keyword"").val();
            pageIndex = 1;
            getNews(pageIndex, pageSize, classifyId, keyword);
        }
        function getNews(pageIndex, pageSize, classifyId, keyword) {
            $.ajax({
                type: 'get',
                asy");
                WriteLiteral(@"nc: true,
                url: '/Admin/News/GetNews',
                data: { pageIndex: pageIndex, pageSize: pageSize, classifyId: classifyId, keyword: keyword },
                success: function (result) {
                    currentPageCount = result.data.length;//当前页的新闻数量
                    var totalPage = parseInt(result.total / pageSize + 1);//总页数
                    // p,当前页码,pn,总页面
                    pageNav.fn = function (p, pn) {
                        $(""#pageinfo"").text(""当前页:"" + p + "" 总页: "" + totalPage);
                        if (p != lastPage)
                            getNews(p, pageSize, classifyId, keyword)
                    };
                    pageNav.go(pageIndex, totalPage);
                    $(""#news_contents"").empty();
                    for (var i = 0; i < result.data.length; i++) {
                        var trData = result.data[i];
                        var tr = '<tr class=""text-c""><td>' + trData.id + '</td><td>' + trData.classifyName + '</td><td>' + ");
                WriteLiteral(@"trData.title + '</td><td>' + trData.contents + '</td><td>' + trData.publishDate + '</td><td>' + trData.remark + '</td><td class=""f-14 user-manage""><a title=""删除"" href=""javascript:;"" onClick=""del(this,' + trData.id + ')"" class=""ml-5"" style=""text-decoration:none""><i class=""icon-trash""></i></a></td></tr>';
                        $(""#news_contents"").append(tr);
                    }
                    lastPage = pageIndex;
                }
            });
        }
        //删除新闻
        function del(obj, id) {
            layer.confirm('确认要删除吗？', function (index) {
                //$(obj).parents(""tr"").remove();
                //layer.msg('已删除!', 1);
                $.ajax({
                    type: 'post',
                    async: true,
                    url: '/Admin/News/DelNews',
                    data: { id: id },
                    success: function (result) {
                        if (result.code == 200) {
                            layer.msg('已删除!', 1);
                 ");
                WriteLiteral(@"           if (currentPageCount == 1) {
                                if (pageIndex == 1) {
                                    reload();
                                } else {
                                    getNews(pageIndex - 1, pageSize, classifyId, keyword);
                                }
                            } else {
                                getNews(pageIndex, pageSize, classifyId, keyword);
                                //$(obj).parents(""tr"").remove();
                            }
                        } else {
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
            BeginContext(7867, 9, true);
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
