// MIT License
// Copyright Eraware

using Eraware.Modules.ApiLogger.Services;
using Eraware.Modules.ApiLogger.ViewModels;
using NSwag.Annotations;
using System.Net;
using System.Web.Http;

namespace Eraware.Modules.ApiLogger.Controllers
{
    /// <summary>
    /// Provides localization related web services.
    /// </summary>
    public class LocalizationController : ModuleApiController
    {
        private readonly ILocalizationService localizationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationController"/> class.
        /// </summary>
        /// <param name="localizationService">The service to localize resources.</param>
        public LocalizationController(ILocalizationService localizationService)
        {
            this.localizationService = localizationService;
        }

        /// <summary>
        /// Gets localization keys and values.
        /// </summary>
        /// <returns><see cref="LocalizationViewModel"/>.</returns>
        [HttpGet]
        [AllowAnonymous]
        [SwaggerResponse(
            HttpStatusCode.OK,
            typeof(LocalizationViewModel),
            Description = "OK")]
        public IHttpActionResult GetLocalization()
        {
            return this.Ok(this.localizationService.ViewModel);
        }
    }
}