﻿using Exrin.Abstraction;
using Exrin.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesla.View;
using Tesla.Wire;
using Xamarin.Forms;

namespace Tesla.Stack
{
    public class MainStack: BaseStack
    {

        public MainStack(INavigationService navigationService, IPageService pageService, IDisplayService displayService)
                                                                    : base(navigationService, displayService, pageService)
        {
            _container = new NavigationContainer() { Page = new NavigationPage() };

        }

        protected override void MapPages()
        {
            _navigationService.Map(nameof(PageLocator.Main.Main), typeof(MainPage));
        }

        protected override void MapViewModels()
        {
            _pageService.Map(typeof(MainPage), typeof(MainViewModel));
        }

        protected override string NavigationStartPageKey
        {
            get
            {
                return nameof(PageLocator.Main.Main);
            }
        }

    }
}