﻿using System;
using Caliburn.Micro;

namespace Features.CrossPlatform.ViewModels
{
    public class MenuViewModel : Screen
    {
        private readonly INavigationService navigationService;

        public MenuViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            Features = new BindableCollection<FeatureViewModel>
            {
                new FeatureViewModel("Binding Conventions", "Binding view model properties to your view.", typeof(BindingsViewModel)),
                new FeatureViewModel("Action Conventions", "Wiring view events to view model methods.", typeof(ActionsViewModel)),
                new FeatureViewModel("Coroutines", "Using IEnumerable<IResult>", typeof(CoroutineViewModel)),
                new FeatureViewModel("Execute", "Using Execute to execute code on the UI thread.", typeof(ExecuteViewModel)),
                new FeatureViewModel("Event Aggregator", "Send events between uncoupled view models.", typeof(EventAggregationViewModel))
                // Event aggregator
                // Simple Container
                // Conductors
                // View location
                // Key binding
                // Action bubbling

            };
        }

        public BindableCollection<FeatureViewModel> Features { get; }

        public void ShowFeature(FeatureViewModel feature)
        {
            navigationService.NavigateToViewModel(feature.ViewModel);
        }
    }
}