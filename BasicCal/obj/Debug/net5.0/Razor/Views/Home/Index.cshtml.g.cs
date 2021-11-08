#pragma checksum "C:\Users\Mero Asebi\Documents\GitHub\Software_Studio\BasicCal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd3d288e06cd4a4e2347d3f53871ec72eebc52e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Mero Asebi\Documents\GitHub\Software_Studio\BasicCal\Views\_ViewImports.cshtml"
using BasicCal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mero Asebi\Documents\GitHub\Software_Studio\BasicCal\Views\_ViewImports.cshtml"
using BasicCal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd3d288e06cd4a4e2347d3f53871ec72eebc52e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524a12cf829170082eed23590d3ee025cdc30221", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n#Display {\r\n  width: 216px;\r\n}\r\n.NumPad button {\r\n  width: 48px;\r\n  margin: 2px;\r\n}\r\n.clear button {\r\n  width: 216px;\r\n}\r\ntable.NumPad {\r\n  margin-left: auto; \r\n  margin-right: auto;\r\n}\r\n</style>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd3d288e06cd4a4e2347d3f53871ec72eebc52e3337", async() => {
                WriteLiteral("\r\n<div class=\"text-center\">  \r\n  <h1>Basic Calculator</h1>\r\n  <input type=\"text\" id=\"Display\" disabled");
                BeginWriteAttribute("value", " value=\"", 324, "\"", 332, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
  <br/>

    <table class=""NumPad"">
      <tr>
        <br/>
        <td><button onclick=""NumPad('1')  "">1</button></td>
        <td><button onclick=""NumPad('2')  "">2</button></td>
        <td><button onclick=""NumPad('3')  "">3</button></td>
        <td><button onclick=""OpePad('%2B')"">+</button></td>
      </tr>
      <tr>
        <td><button onclick=""NumPad('4')  "">4</button></td>
        <td><button onclick=""NumPad('5')  "">5</button></td>
        <td><button onclick=""NumPad('6')  "">6</button></td>
        <td><button onclick=""OpePad('-')  "">-</button></td>
      <tr>
        <td><button onclick=""NumPad('7')  "">7</button></td>
        <td><button onclick=""NumPad('8')  "">8</button></td>
        <td><button onclick=""NumPad('9')  "">9</button></td>
        <td><button onclick=""OpePad('*')  "">*</button></td>
      </tr>
      <tr>
        <td><button onclick=""NumPad('0')  "">0</button></td>
        <td><button onclick=""NumPad('.')  "">.</button></td>
        <td><button onclick=""CalPad( ");
                WriteLiteral(@"  )  "">=</button></td>
        <td><button onclick=""OpePad('/')  "">/</button></td>
       </tr>
    </table>

  <div class=""clear""> 
    <br/>
      <button onclick=""Display.value = '';
                       Cache ='';"">
                       CLEAR
      </button>
      </div>
  </div>
</div>

<script>
  var xmlhttp = new XMLHttpRequest();
  var Display = document.getElementById(""Display"");
  var Cache = 0;

  function NumPad(number) {
    Cache =  Cache + number;
    Display.value = Display.value + number;}

  function OpePad(operator) {
    Cache =  Cache +  operator;
    Display.value = '';}
  
  function CalPad() {
    let send = Cache;
    xmlhttp.open(""GET"", ""https://localhost:5001/Home/CalPad?prop="" + send);
    xmlhttp.onreadystatechange = function () {
      if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
        Display.value = xmlhttp.responseText;}}
    xmlhttp.send();}
</script>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
