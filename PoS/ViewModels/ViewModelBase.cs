﻿using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using PoS.BL.Service;
using PoS.Dal.Mdl;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using CommonServiceLocator;
using Unity;

namespace PoS.ViewModels
{
    public class ViewModelBase : BindableBase, INotifyPropertyChanged
    {
        private IDialogCoordinator _dialog;

        #region Property
        private bool _isEnabled;
        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    NotifyPropertyChanged("IsEnabled");
                }
            }
        }

        private IRegionManager regionManager;
        public IRegionManager RegionManager
        {
            get
            {
                return regionManager;
            }
            private set
            {
                this.SetProperty<IRegionManager>(ref this.regionManager, value);
            }
        }

        private IEventAggregator eventAggregator;
        public IEventAggregator EventAggregator
        {
            get
            {
                return eventAggregator;
            }
            private set
            {
                this.SetProperty<IEventAggregator>(ref this.eventAggregator, value);
            }
        }

        private IUnityContainer unityContainer;
        public IUnityContainer Container
        {
            get
            {
                return unityContainer;
            }
            private set
            {
                this.SetProperty<IUnityContainer>(ref this.unityContainer, value);
            }
        }

        private ISecurityService securityService;
        public ISecurityService SecurityService
        {
            get
            {
                return securityService;
            }

            private set
            {
                this.SetProperty<ISecurityService>(ref this.securityService, value);
            }
        }
        #endregion

        #region Flyout
        protected void ShowFlyout(string iFlyoutName)
        {
            var region = regionManager.Regions.ToList().Find(s => s.Name == "FlyoutControlRegion");

            if (region != null)
            {
                var flyout = region.Views.FirstOrDefault(s => s is Flyout && ((Flyout)s).Name == iFlyoutName) as Flyout;

                if (flyout != null)
                {
                    flyout.IsOpen = !flyout.IsOpen;
                }
            }
        }
        #endregion

        #region Constructor
        public ViewModelBase()
        {
            this.RegionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            this.EventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            this.SecurityService = ServiceLocator.Current.GetInstance<ISecurityService>();
            this.Container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            _dialog = DialogCoordinator.Instance;
        }
        #endregion

        #region Methods

        protected async void ShowMessage(string iMessage)
        {
            await ((MetroWindow)Container.Resolve<Window>("MainShell")).ShowMessageAsync("PoS", iMessage);
        }

        protected async void ShowMessage(string iMessage, MessageDialogStyle style = MessageDialogStyle.Affirmative)
        {
            await ((MetroWindow)Container.Resolve<Window>("MainShell")).ShowMessageAsync("PoS", iMessage, style);
        }

        protected bool IsLogin(out User oUserModel)
        {
            bool oLogin = true;

            oUserModel = null;

            oUserModel = ServiceLocator.Current.GetInstance<User>();

            if (oUserModel == null || oUserModel.Id == 0)
            {
                oLogin = false;
            }

            return oLogin;
        }
        #endregion

        #region Property Event
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string iPropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(iPropertyName));
            }
        }
        #endregion
    }
}
