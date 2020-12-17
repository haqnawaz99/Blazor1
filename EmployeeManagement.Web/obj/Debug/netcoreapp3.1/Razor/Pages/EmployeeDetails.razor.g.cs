#pragma checksum "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7626fc2c0c50864268eca9f6874ccaf58486787b"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Programming\VS\Blazor\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
 if (Employee == null || Employee.Department == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 8 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center m-3");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-8");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-header");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h1");
            __builder.AddContent(15, 
#nullable restore
#line 15 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                             Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body text-center");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "class", "card-img-top");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 19 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                    Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n                    ");
            __builder.OpenElement(27, "h4");
            __builder.AddContent(28, "Employee ID : ");
            __builder.AddContent(29, 
#nullable restore
#line 21 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                       Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "h4");
            __builder.AddContent(32, "Email : ");
            __builder.AddContent(33, 
#nullable restore
#line 22 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                 Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "h4");
            __builder.AddContent(36, "Department : ");
            __builder.AddContent(37, 
#nullable restore
#line 23 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                      Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                           Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, 
#nullable restore
#line 25 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                                          ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 27 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                     CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.AddMarkupContent(48, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                    ");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "href", 
#nullable restore
#line 29 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                               $"editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "class", "btn btn-primary m-1");
            __builder.AddContent(52, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.AddMarkupContent(54, "<a href=\"#\" class=\"btn btn-danger\">Delete</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 36 "C:\Programming\VS\Blazor\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
