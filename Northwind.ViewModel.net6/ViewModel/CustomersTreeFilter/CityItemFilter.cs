﻿using BolapanControl.ItemsFilter.Model;
using System;
using System.Collections.Generic;
using System.Windows.Data;
using System.Linq;

namespace Northwind.NET.Sample.ViewModel {
    public class CityItemFilter : CustomerItemFilter, IFilter {
        private bool isCityCompareActive;
        private string? cityCompareTo;
        private readonly Dictionary<CityCustomersTreeItem, CustomerItemFilter> customerFilters = new();
        private readonly CustomerFilterInitializer customerFilterInitializer = new();
        //private CollectionView? collectionViev;

        internal protected CityItemFilter(string key)
            : base(key) {
        }
        public string? CityCompareTo {
            get { return cityCompareTo; }
            set {
                if (cityCompareTo != value) {
                    cityCompareTo = value;
                    isCityCompareActive = !String.IsNullOrEmpty(value);
                    IDisposable? defer = this.FilterPresenter?.DeferRefresh();
                    SendChangesToChild();
                    IsActive = CheckIsActive();
                    //RaiseFilterChanged();
                    RaisePropertyChanged(nameof(CityCompareTo));
                    if (defer != null)
                        defer.Dispose();
                }
            }
        }
        public override void IsMatch(BolapanControl.ItemsFilter.FilterPresenter sender, BolapanControl.ItemsFilter.FilterEventArgs e) {
            if (IsActive && e.Accepted) {
                if (e.Item is CityCustomersTreeItem item) {
                    if (isCityCompareActive)
                        e.Accepted = item.City != null
#pragma warning disable CS8604 // Possible null reference argument.
                            && item.City.Contains(cityCompareTo);
#pragma warning restore CS8604 // Possible null reference argument.
                    if (e.Accepted)
                        e.Accepted = customerFilters[item].Count > 0;
                }
                else
                    e.Accepted = false;
            }
        }
        protected override void OnAttachPresenter(BolapanControl.ItemsFilter.FilterPresenter presenter) {
            if (presenter.CollectionView is CollectionView) {
                collectionView = presenter.CollectionView as CollectionView;
            }
            foreach (CityCustomersTreeItem item in presenter.CollectionView.SourceCollection) {
                if (item.Customers is not null) {
                    BolapanControl.ItemsFilter.FilterPresenter? customersPresenter = BolapanControl.ItemsFilter.FilterPresenter.Get(item.Customers);
                    if (customersPresenter?.TryGetFilter(Key, customerFilterInitializer, out var filter)==true
                        && filter  is CustomerItemFilter customerFilter) {
                        customerFilter.NameCompareTo = NameCompareTo;
                        customerFilter.ContactCompareTo = ContactCompareTo;
                        customerFilters[item] = customerFilter;
                    }
                }
            }

        }
        protected override void OnDetachPresenter(BolapanControl.ItemsFilter.FilterPresenter presenter) {
            customerFilters.Clear();
            collectionView = null;

        }
        protected override void OnIsActiveChanged() {
            base.OnIsActiveChanged();
            if (!IsActive) {
                CityCompareTo = null;
            }
        }
        protected override void SendChangesToChild() {
            foreach (var entry in customerFilters) {
                entry.Value.NameCompareTo = NameCompareTo;
                entry.Value.ContactCompareTo = ContactCompareTo;
            }
        }
        protected override bool CheckIsActive() {
            return isCityCompareActive | base.CheckIsActive();
        }
    }
}
