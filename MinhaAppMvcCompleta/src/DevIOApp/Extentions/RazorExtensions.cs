using Microsoft.AspNetCore.Mvc.Razor;

namespace DevIOApp.Extentions
{
    public static class RazorExtensions
    {
        public static string FormatoDocumento(this RazorPage page,int tipoPessoa, string documento)
        {
            return tipoPessoa == 1 ?
                Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00") :
                Convert.ToUInt64(documento).ToString(@"00\.000\.000\/0000\-00");
        }
    }
}
