///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\Shared\WoTemplateMenuLayoutPartialBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

using System.Net.Http.Json;

namespace WasmUnitModel_proj.Themes
{
    
    public partial class WoThemeSwitcher<TApp>
    {

        #region Ciclo de vida

        /// <summary>
        /// Carga desde el local storage los temas y el tema actual
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            try
            {
                Themes resTem = await LocalStorage.GetItemAsync<Themes>("themes");
                if (resTem != null)
                {
                    _themes = resTem.themes;
                }
            }
            catch (Exception)
            {
                //error
            }

            try
            {
                _currentTheme = await LocalStorage.GetItemAsync<Theme>("theme");
                if (_currentTheme != null)
                {
                    ChangeTheme(_currentTheme);
                }
            }
            catch (Exception ex)
            {
                //error
            }
        }

        #endregion Ciclo de vida


        #region Temas

        /// <summary>
        /// Tema actual
        /// </summary>
        private Theme _currentTheme = new Theme();

        /// <summary>
        /// Lista de temas
        /// </summary>
        private List<Theme> _themes = new List<Theme>();

        /// <summary>
        /// Metodo que se detona al seleccionar un nuevo tema.
        /// Detona el js que actualiza el link del tema
        /// </summary>
        /// <param name="newTheme"></param>
        /// <returns></returns>
        private async Task ChangeTheme(Theme newTheme)
        {
            if (newTheme != null)
            {
                _currentTheme = newTheme;
                await LocalStorage.SetItemAsync("theme", newTheme);
                var themeChange = await JSRuntime.InvokeAsync<object>("themeChanger.changeCss", new object[1] { newTheme.cssCdn });
            }
        }

        #endregion Temas

        #region Carga de los temas

        /// <summary>
        /// Carga los temas desde el local storage y en caso de no existir una vercion los descarga
        /// </summary>
        /// <returns></returns>
        private async Task LoadThemes()
        {
            try
            {
                Themes resTem = await LocalStorage.GetItemAsync<Themes>("themes");
                if (resTem != null)
                {
                    _themes = resTem.themes;
                }
                else
                {
                    await DownloadThemes();
                }
            }
            catch (Exception)
            {
                //error
            }

            StateHasChanged();
        }

        /// <summary>
        /// Descarga los temas desde el api de bootswatch
        /// </summary>
        /// <returns></returns>
        public async Task DownloadThemes()
        {
            HttpClient themesClient = new HttpClient();
            Themes? response = await themesClient.GetFromJsonAsync<Themes>("https://bootswatch.com/api/4.json");

            if (response != null)
            {
                _themes = response.themes;
            }
        }

        #endregion Carga de los temas

    }

    #region Clases del tema

    /// <summary>
    /// Clase principal del tema: Es la representacion de lo que debuelve el api de bootswatch
    /// </summary>
    public class Themes
    {
        public string version { get; set; } = string.Empty;
        public List<Theme> themes { get; set; } = new List<Theme>();
    }

    public class Theme
    {
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string thumbnail { get; set; } = string.Empty;
        public string preview { get; set; } = string.Empty;
        public string css { get; set; } = string.Empty;
        public string cssMin { get; set; } = string.Empty;
        public string cssCdn { get; set; } = string.Empty;
        public string scss { get; set; } = string.Empty;
        public string scssVariables { get; set; } = string.Empty;
    }

    #endregion Clases del tema

}

 

