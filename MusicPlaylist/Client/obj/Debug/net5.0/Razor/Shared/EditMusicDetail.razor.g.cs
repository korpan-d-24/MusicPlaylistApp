#pragma checksum "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4d13eca8399dc82e4ddc3f4ba9e6e6e8a11a82"
// <auto-generated/>
#pragma warning disable 1591
namespace MusicPlaylist.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using MusicPlaylist.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using MusicPlaylist.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using MusicPlaylist.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\_Imports.razor"
using MusicPlaylist.Shared;

#line default
#line hidden
#nullable disable
    public partial class EditMusicDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
 if (Song.Id == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3>Add a new Music to playlist</h3>");
#nullable restore
#line 7 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Edit the song ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                       Song.SongName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                 Song

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                 HendeSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "<label>Song Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                Song.SongName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Song.SongName = __value, Song.SongName))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Song.SongName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "<label>Album Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                Song.AlbumName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Song.AlbumName = __value, Song.AlbumName))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Song.AlbumName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "<label>Group Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                Song.GroupName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Song.GroupName = __value, Song.GroupName))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Song.GroupName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "<label>Release Year</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                Song.ReleaseYear

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Song.ReleaseYear = __value, Song.ReleaseYear))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Song.ReleaseYear));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "<label>ULR</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                Song.Url

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Song.Url = __value, Song.Url))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Song.Url));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "<label>Styles</label><br>\r\n        ");
                __Blazor.MusicPlaylist.Client.Shared.EditMusicDetail.TypeInference.CreateInputRadioGroup_0(__builder2, 56, 57, "form-control", 58, 
#nullable restore
#line 35 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                      styleId

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => styleId = __value, styleId)), 60, () => styleId, 61, (__builder3) => {
#nullable restore
#line 36 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
             foreach (var style in MusicService.Styles)
            {

#line default
#line hidden
#nullable disable
                    __Blazor.MusicPlaylist.Client.Shared.EditMusicDetail.TypeInference.CreateInputRadio_1(__builder3, 62, 63, 
#nullable restore
#line 38 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                    style.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.OpenElement(64, "span");
                    __builder3.AddAttribute(65, "style", "padding-left: 5px;");
                    __builder3.AddContent(66, 
#nullable restore
#line 38 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                                                                  style.NameOfStyle

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "<br>");
#nullable restore
#line 39 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.AddMarkupContent(69, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Asus\source\repos\MusicPlaylist\MusicPlaylist\Client\Shared\EditMusicDetail.razor"
                                                                    
    [Parameter]
    public MusicPlaylist.Shared.Music Song { get; set; } = new MusicPlaylist.Shared.Music();
    int styleId = 1;

    protected override async Task OnParametersSetAsync()
    {
        await MusicService.GetStyles();
        styleId = Song.MusicStyle.Id;
    }

    async void HendeSubmit()
    {
        Song.MusicStyle = MusicService.Styles.FirstOrDefault(s => s.Id == styleId);
        await JSRuntime.InvokeVoidAsync("console.log", Song);

        if (Song.Id == 0)
        {
            await MusicService.CreateMusic(Song);
        }

        else
        {
            await MusicService.UpdateMusic(Song, Song.Id);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMusicService MusicService { get; set; }
    }
}
namespace __Blazor.MusicPlaylist.Client.Shared.EditMusicDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputRadioGroup_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591