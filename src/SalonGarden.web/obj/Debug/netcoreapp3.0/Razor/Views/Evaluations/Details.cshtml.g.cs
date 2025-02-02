#pragma checksum "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ff6aad8765a3ab28699a080004b2a9177de349"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluations_Details), @"mvc.1.0.view", @"/Views/Evaluations/Details.cshtml")]
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
#line 1 "C:\code\SalonGarden\src\SalonGarden.web\Views\_ViewImports.cshtml"
using SalonGarden.Web;

#line default
#line hidden
#line 2 "C:\code\SalonGarden\src\SalonGarden.web\Views\_ViewImports.cshtml"
using SalonGarden.Web.Models;

#line default
#line hidden
#line 3 "C:\code\SalonGarden\src\SalonGarden.web\Views\_ViewImports.cshtml"
using SalonGarden.Web.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ff6aad8765a3ab28699a080004b2a9177de349", @"/Views/Evaluations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa503f2230a4a89a8c019792cc57722661dc77d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalonGarden.Web.Models.EvaluationDetailVIewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            WriteLiteral("\r\n\r\n\r\n<div class=\"border bg-light p-2 mb-2 d-flex\">\r\n    <div> <span class=\"h3\">");
#line 10 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
                      Write(Model.Student.Email);

#line default
#line hidden
            WriteLiteral("</span></div>\r\n    <div class=\"ml-auto\">\r\n        <div class=\" p-2\">\r\n            <span class=\"text-secondary\"> <b>Status: </b>   ");
#line 13 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
                                                       Write(Model.Evaluation.EvaluationStatus.Description);

#line default
#line hidden
            WriteLiteral(@"</span>
        </div>
       
    </div>
</div>

<div class=""mb-2"">
    <div class=""row mb-2"">
        <div class=""col-6"">
            <div class=""border border-bottom-0 bg-light p-1"">
                <b>Created</b>
            </div>
            <div class=""border p-1 bg-white"">
                ");
#line 26 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
           Write(Model.Evaluation.CreationDate.ToShortDateString());

#line default
#line hidden
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <div class=\"border border-bottom-0 bg-light p-1\">\r\n                <b>Educator</b>\r\n            </div>\r\n            <div class=\"border p-1 bg-white\">\r\n                ");
#line 34 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
           Write(Model.Educator.UserName);

#line default
#line hidden
            WriteLiteral(@"

            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-6"">
            <div class=""border border-bottom-0 bg-light  p-1"">
                <b>Technique</b>
            </div>
            <div class=""border  p-1 bg-white"">
                ");
#line 46 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
           Write(Model.Evaluation.Technique.Description);

#line default
#line hidden
            WriteLiteral(@"

            </div>
        </div>
        <div class=""col-6"">
            <div class=""border border-bottom-0 bg-light  p-1"">
                <b>Evaluation Type</b>
            </div>
            <div class=""border  p-1 bg-white"">
                ");
#line 55 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
           Write(Model.Evaluation.EvaluationType.Description);

#line default
#line hidden
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<hr />\r\n\r\n\r\n");
#line 66 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
 foreach (var criteriaGroup in Model.CriteriaGroups.OrderBy(x => x.SequenceNumber))
{

#line default
#line hidden
            WriteLiteral("    <div class=\"border  p-2 mb-2\">\r\n        <h4>");
#line 69 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
       Write(criteriaGroup.Description);

#line default
#line hidden
            WriteLiteral("</h4>\r\n");
#line 70 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
         foreach (var criteria in criteriaGroup.EvaluationCriteria.OrderBy(x => x.SequenceNumber))
        {

#line default
#line hidden
            WriteLiteral("            <div class=\"d-flex mb-2 border bg-light p-2\">\r\n                <div>\r\n                    <span>");
#line 74 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
                     Write(criteria.Description);

#line default
#line hidden
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"ml-auto\">\r\n\r\n                    <span>\r\n                        ");
#line 79 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
                   Write(Model.Evaluation.EvaluationDetailItems.First(x => x.EvaluationCriteriaId == criteria.Id).AllocatedPoints);

#line default
#line hidden
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n");
#line 83 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </div>\r\n");
#line 85 "C:\code\SalonGarden\src\SalonGarden.web\Views\Evaluations\Details.cshtml"
}

#line default
#line hidden
            WriteLiteral("\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ff6aad8765a3ab28699a080004b2a9177de3498324", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalonGarden.Web.Models.EvaluationDetailVIewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
