#pragma checksum "C:\Users\swetha\source\repos\MVC\CRUDUsingApi\View\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d2568c4a5fe30e5e4e9b5b7628e46ecb901b2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.View_Index), @"mvc.1.0.view", @"/View/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d2568c4a5fe30e5e4e9b5b7628e46ecb901b2a", @"/View/Index.cshtml")]
    #nullable restore
    public class View_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\swetha\source\repos\MVC\CRUDUsingApi\View\Index.cshtml"
  
    ViewBag.Title = "FriendView";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2>Friends View</h2>
<style>
    #mydiv {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        z-index: 1000;
        background-color: grey;
        opacity: .8;
    }

    .ajax-loader {
        position: absolute;
        left: 50%;
        top: 50%;
        margin-left: -32px; /* -1 * image width / 2 */
        margin-top: -32px; /* -1 * image height / 2 */
        display: block;
    }
</style>
<div data-ng-app data-ng-controller=""friendController"" class=""container"">
    <strong class=""error"">{{ error }}</strong>
    <div id=""mydiv"" data-ng-show=""loading"">
        <img src=""Images/ajax-loader.gif"" class=""ajax-loader"" />
    </div>
    <p data-ng-hide=""addMode""><a data-ng-click=""toggleAdd()"" href=""javascript:;"" class=""btn btn-primary"">Add New</a></p>
    <form name=""addFriend"" data-ng-show=""addMode"" style=""width:600px;margin:0px auto;"">
        <label>FirstName:</label><input type=""text"" data-ng-model=""newfriend.F");
            WriteLiteral(@"irstName"" required />
        <label>LastName:</label><input type=""text"" data-ng-model=""newfriend.LastName"" required />
        <label>Address:</label><input type=""text"" data-ng-model=""newfriend.Address"" required />
        <label>City:</label><input type=""text"" data-ng-model=""newfriend.City"" required />
        <label>PostalCode:</label><input type=""text"" data-ng-model=""newfriend.PostalCode"" required />
        <label>Country:</label><input type=""text"" data-ng-model=""newfriend.Country"" required />
        <label>Notes:</label><input type=""text"" data-ng-model=""newfriend.Notes"" required />
        <br />
        <br />
        <input type=""submit"" value=""Add"" data-ng-click=""add()"" data-ng-disabled=""!addFriend.$valid"" class=""btn btn-primary"" />
        <input type=""button"" value=""Cancel"" data-ng-click=""toggleAdd()"" class=""btn btn-primary"" />
        <br /><br />
    </form>
    <table class=""table table-bordered table-hover"" style=""width:800px"">
        <tr>
            <th>#</th>
            <t");
            WriteLiteral(@"d>FirstName</td>
            <th>LastName</th>
            <th>Address</th>
            <th>City</th>
            <th>PostalCode</th>
            <th>Country</th>
            <th>Notes</th>
        </tr>

        <tr data-ng-repeat=""friend in friends"">
            <td><strong data-ng-hide=""friend.editMode"">{{ friend.FriendId }}</strong></td>
            <td>
                <p data-ng-hide=""friend.editMode"">{{ friend.FirstName }}</p>
                <input data-ng-show=""friend.editMode"" type=""text"" data-ng-model=""friend.FirstName"" />
            </td>
            <td>
                <p data-ng-hide=""friend.editMode"">{{ friend.LastName }}</p>
                <input data-ng-show=""friend.editMode"" type=""text"" data-ng-model=""friend.LastName"" />
            </td>
            <td>
                <p data-ng-hide=""friend.editMode"">{{ friend.Address }}</p>
                <input data-ng-show=""friend.editMode"" type=""text"" data-ng-model=""friend.Address"" />
            </td>
            <td>
   ");
            WriteLiteral(@"             <p data-ng-hide=""friend.editMode"">{{ friend.City }}</p>
                <input data-ng-show=""friend.editMode"" type=""text"" data-ng-model=""friend.City"" />
            </td>
            <td>
                <p data-ng-hide=""friend.editMode"">{{ friend.PostalCode }}</p>
                <input data-ng-show=""friend.editMode"" type=""text"" data-ng-model=""friend.PostalCode"" />
            </td>
            <td>
                <p data-ng-hide=""friend.editMode"">{{ friend.Country }}</p>
                <input data-ng-show=""friend.editMode"" type=""text"" data-ng-model=""friend.Country"" />
            </td>
            <td>
                <p data-ng-hide=""friend.editMode"">{{ friend.Notes }}</p>
                <input data-ng-show=""friend.editMode"" type=""text"" data-ng-model=""friend.Notes"" />
            </td>
            <td>
                <p data-ng-hide=""friend.editMode""><a data-ng-click=""toggleEdit(friend)"" href=""javascript:;"">Edit</a> | <a data-ng-click=""deletefriend(friend)"" href=""javascript");
            WriteLiteral(@":;"">Delete</a></p>
                <p data-ng-show=""friend.editMode""><a data-ng-click=""save(friend)"" href=""javascript:;"">Save</a> | <a data-ng-click=""toggleEdit(friend)"" href=""javascript:;"">Cancel</a></p>
            </td>
        </tr>
    </table>
    <hr />

</div> 
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6d2568c4a5fe30e5e4e9b5b7628e46ecb901b2a7769", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
