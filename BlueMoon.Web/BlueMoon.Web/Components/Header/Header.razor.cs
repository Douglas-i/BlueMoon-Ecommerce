using Microsoft.AspNetCore.Components;

namespace BlueMoon.Web.Components.Header
{
    public partial class Header
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        private void OpenPdfInNewTab()
        {
            var pdfUrl = "/catalogo";
            // Abrir la URL en una nueva pestaña
            NavigationManager.NavigateTo(pdfUrl, true);
        }
        private void Home()
        {
            var pdfUrl = "/";
            // Abrir la URL en una nueva pestaña
            NavigationManager.NavigateTo(pdfUrl, true);
        }
        private void Contact()
        {
            var pdfUrl = "/contacto";
            // Abrir la URL en una nueva pestaña
            NavigationManager.NavigateTo(pdfUrl, true);
        }
    }
}
