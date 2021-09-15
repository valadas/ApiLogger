// MIT License
// Copyright Eraware
using Eraware.Modules.ApiLogger.ViewModels;

namespace Eraware.Modules.ApiLogger.Services
{
    /// <summary>
    /// Provides strongly typed localization services for this module.
    /// </summary>
    public interface ILocalizationService
    {
        /// <summary>
        /// Gets viewmodel that strongly types all resource keys.
        /// </summary>
        LocalizationViewModel ViewModel { get; }
    }
}