#pragma checksum "C:\Users\11600438\Desktop\School2018-19\PROGADV_.Net\VoorbeeldOplossingen\OdeToFoodVB\OdeToFood\OdeToFood\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51703e521ebe79ffdaf52eb053830c6a91582181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/AccessDenied.cshtml", typeof(OdeToFood.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), null)]
namespace OdeToFood.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\11600438\Desktop\School2018-19\PROGADV_.Net\VoorbeeldOplossingen\OdeToFoodVB\OdeToFood\OdeToFood\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\11600438\Desktop\School2018-19\PROGADV_.Net\VoorbeeldOplossingen\OdeToFoodVB\OdeToFood\OdeToFood\Areas\Identity\Pages\_ViewImports.cshtml"
using OdeToFood.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\11600438\Desktop\School2018-19\PROGADV_.Net\VoorbeeldOplossingen\OdeToFoodVB\OdeToFood\OdeToFood\Areas\Identity\Pages\_ViewImports.cshtml"
using OdeToFood.Data.DomainClasses;

#line default
#line hidden
#line 1 "C:\Users\11600438\Desktop\School2018-19\PROGADV_.Net\VoorbeeldOplossingen\OdeToFoodVB\OdeToFood\OdeToFood\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using OdeToFood.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51703e521ebe79ffdaf52eb053830c6a91582181", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f1bd192c8423e8dc31c9d83d8175032c30c2f3", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb65491856902b7fa476dc457f7f3e6d4366424", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\11600438\Desktop\School2018-19\PROGADV_.Net\VoorbeeldOplossingen\OdeToFoodVB\OdeToFood\OdeToFood\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
            BeginContext(82, 40, true);
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(123, 17, false);
#line 8 "C:\Users\11600438\Desktop\School2018-19\PROGADV_.Net\VoorbeeldOplossingen\OdeToFoodVB\OdeToFood\OdeToFood\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(140, 91, true);
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">You do not have access to this resource.</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
