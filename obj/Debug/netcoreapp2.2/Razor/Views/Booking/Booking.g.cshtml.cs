#pragma checksum "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d25b45a783dbb9135f3288ed921d913f6dc3a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Booking), @"mvc.1.0.view", @"/Views/Booking/Booking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Booking.cshtml", typeof(AspNetCore.Views_Booking_Booking))]
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
#line 1 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\_ViewImports.cshtml"
using Booking2;

#line default
#line hidden
#line 2 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\_ViewImports.cshtml"
using Booking2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d25b45a783dbb9135f3288ed921d913f6dc3a82", @"/Views/Booking/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"893c7a3bfe66389ea8f1866abc9f04e301048235", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking2.Models.BookAroom>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
  
    ViewData["Title"] = "Index";

    var time = DateTime.Now;
    var backgroundColor = "#FF0000";
    var roomAvaible = "Upptaget";
    if (Model.CurrentBooking == null)
        {
            roomAvaible = "Ledigt";
            backgroundColor = "#2EFE2E";
        }
    

#line default
#line hidden
            BeginContext(327, 83, true);
            WriteLiteral("\r\n\r\n<style type=\"text/css\">\r\n    <!--\r\n    .Available {\r\n        background-color: ");
            EndContext();
            BeginContext(411, 15, false);
#line 20 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                     Write(backgroundColor);

#line default
#line hidden
            EndContext();
            BeginContext(426, 146, true);
            WriteLiteral(";\r\n        width: 250px;\r\n        padding: 25px;\r\n    }\r\n\r\n    h1 {\r\n        font-size: 30px;\r\n        margin: 24px;\r\n    }\r\n\r\n    -->\r\n</style>\r\n");
            EndContext();
#line 32 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
 if (Model.Name == "Disk")
{

#line default
#line hidden
            BeginContext(603, 29, true);
            WriteLiteral("    <h2>Booking</h2>\r\n    <p>");
            EndContext();
            BeginContext(633, 4, false);
#line 35 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
  Write(time);

#line default
#line hidden
            EndContext();
            BeginContext(637, 103, true);
            WriteLiteral("</p>\r\n    <div>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(741, 40, false);
#line 40 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(781, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(837, 36, false);
#line 43 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(873, 89, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div class=\"Available\">\r\n        <h1>");
            EndContext();
            BeginContext(963, 11, false);
#line 48 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
       Write(roomAvaible);

#line default
#line hidden
            EndContext();
            BeginContext(974, 21, true);
            WriteLiteral("</h1>\r\n        <h5>\r\n");
            EndContext();
#line 50 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
             if (Model.CurrentBooking == null)
            {
                

#line default
#line hidden
            BeginContext(1080, 19, true);
            WriteLiteral("ingen bokning finns");
            EndContext();
#line 52 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                                                
            }
            else
            {
                

#line default
#line hidden
            BeginContext(1178, 8, true);
            WriteLiteral("Ledig i ");
            EndContext();
            BeginContext(1187, 21, false);
#line 56 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                         Write(Model.FreeMinutesLeft);

#line default
#line hidden
            EndContext();
#line 56 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                                                           
            }

#line default
#line hidden
            BeginContext(1232, 27, true);
            WriteLiteral("        </h5>\r\n    </div>\r\n");
            EndContext();
#line 60 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
     if (Model.GetIsBusy() == true)
    {

#line default
#line hidden
            BeginContext(1303, 46, true);
            WriteLiteral("        <h1>Snabb-Bokad</h1>\r\n        <h4>\r\n\r\n");
            EndContext();
#line 65 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
             foreach (var next in Model.MeetingOftoDay)
            {
                

#line default
#line hidden
            BeginContext(1444, 14, false);
#line 67 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                 Write(next.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1462, 12, false);
#line 67 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                                   Write(next.EndDate);

#line default
#line hidden
            EndContext();
#line 67 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                                                            
            }

#line default
#line hidden
            BeginContext(1498, 15, true);
            WriteLiteral("        </h4>\r\n");
            EndContext();
            BeginContext(1522, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1530, 279, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d25b45a783dbb9135f3288ed921d913f6dc3a829421", async() => {
                BeginContext(1556, 34, true);
                WriteLiteral("\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1590, "\"", 1622, 1);
#line 72 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 1598, Model.CurrentBooking.Id, 1598, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1623, 47, true);
                WriteLiteral(" name=\"Id\" />\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1670, "\"", 1691, 1);
#line 73 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 1678, Model.RoomId, 1678, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1692, 110, true);
                WriteLiteral(" name=\"roomId\" />\r\n            <input type=\"submit\" value=\"Ångra bokning\" class=\"btn btn-default\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1809, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(1837, 99, true);
            WriteLiteral("        <h4>Snabb-boka</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n");
            EndContext();
#line 84 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                 if (Model.FreeMinutesLeft >= 30 || Model.FreeMinutesLeft == null)
                {

#line default
#line hidden
            BeginContext(2039, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2061, "\"", 2172, 1);
#line 86 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 2068, Url.Action("SpeedBook", "Booking", new { minutes = SpeedbookingChoices.Thirty, roomId = Model.RoomId }), 2068, 104, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2173, 37, true);
            WriteLiteral(" class=\"btn btn-default\">30 min</a>\r\n");
            EndContext();
#line 87 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2270, 77, true);
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-default disabled\">30 min</a>\r\n");
            EndContext();
#line 91 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                }

#line default
#line hidden
            BeginContext(2366, 37, true);
            WriteLiteral("            </dt>\r\n            <dd>\r\n");
            EndContext();
#line 94 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                 if (Model.FreeMinutesLeft >= 60 || Model.FreeMinutesLeft == null)
                {

#line default
#line hidden
            BeginContext(2506, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2528, "\"", 2638, 1);
#line 96 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 2535, Url.Action("SpeedBook", "Booking", new { minutes = SpeedbookingChoices.Sixty, roomId = Model.RoomId }), 2535, 103, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2639, 37, true);
            WriteLiteral(" class=\"btn btn-default\">60 min</a>\r\n");
            EndContext();
#line 97 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2736, 77, true);
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-default disabled\">60 min</a>\r\n");
            EndContext();
#line 101 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                }

#line default
#line hidden
            BeginContext(2832, 37, true);
            WriteLiteral("            </dd>\r\n            <dt>\r\n");
            EndContext();
#line 104 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                 if (Model.FreeMinutesLeft >= 90 || Model.FreeMinutesLeft == null)
                {

#line default
#line hidden
            BeginContext(2972, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2994, "\"", 3105, 1);
#line 106 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 3001, Url.Action("SpeedBook", "Booking", new { minutes = SpeedbookingChoices.Ninety, roomId = Model.RoomId }), 3001, 104, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3106, 37, true);
            WriteLiteral(" class=\"btn btn-default\">90 min</a>\r\n");
            EndContext();
#line 107 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3203, 77, true);
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-default disabled\">90 min</a>\r\n");
            EndContext();
#line 111 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                }

#line default
#line hidden
            BeginContext(3299, 37, true);
            WriteLiteral("            </dt>\r\n            <dd>\r\n");
            EndContext();
#line 114 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                 if (Model.FreeMinutesLeft >= 120 || Model.FreeMinutesLeft == null)
                {

#line default
#line hidden
            BeginContext(3440, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3462, "\"", 3583, 1);
#line 116 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 3469, Url.Action("SpeedBook", "Booking", new { minutes = SpeedbookingChoices.OneHundredTwenty, roomId = Model.RoomId }), 3469, 114, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3584, 38, true);
            WriteLiteral(" class=\"btn btn-default\">120 min</a>\r\n");
            EndContext();
#line 117 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3682, 78, true);
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-default disabled\">120 min</a>\r\n");
            EndContext();
#line 121 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                }

#line default
#line hidden
            BeginContext(3779, 34, true);
            WriteLiteral("            </dd>\r\n        </dl>\r\n");
            EndContext();
#line 124 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"

    }

#line default
#line hidden
            BeginContext(3822, 51, true);
            WriteLiteral("    <br />\r\n    <h4>Kommande möten</h4>\r\n    <h4>\r\n");
            EndContext();
#line 129 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
         foreach (var next in Model.Bookings)
        {
            if (next.StartDate >= DateTime.Now)
            {
                

#line default
#line hidden
            BeginContext(4018, 14, false);
#line 133 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                 Write(next.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(4032, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(4036, 12, false);
#line 133 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                                   Write(next.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(4048, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(4051, 13, false);
#line 133 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                                                  Write(next.UserName);

#line default
#line hidden
            EndContext();
#line 133 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
                                                                            
            }

        }

#line default
#line hidden
            BeginContext(4101, 11, true);
            WriteLiteral("    </h4>\r\n");
            EndContext();
#line 138 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(4124, 103, true);
            WriteLiteral("    <h2>Booking</h2>\r\n    <div>\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4228, 40, false);
#line 145 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4268, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4324, 36, false);
#line 148 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4360, 89, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <h4>Går ej att snabb boka!</h4>\r\n    </div>\r\n");
            EndContext();
#line 153 "C:\Users\Bamb75\source\repos\Booking2\Booking2\Views\Booking\Booking.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking2.Models.BookAroom> Html { get; private set; }
    }
}
#pragma warning restore 1591
