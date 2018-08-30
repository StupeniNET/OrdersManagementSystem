﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Infrastructure.Base;
using Prism.Commands;
using Prism.Regions;

namespace Dashboard.CustomerStatistics
{
    public class CustomerStatsViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        public CustomerStatsViewModel(IRegionManager regionManager)
        {
            Title = "Customers";
        }

        #region Commands
        #endregion
    }
}