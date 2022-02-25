﻿// ****************************************************************************
// <author>mishkin Ivan</author>
// <email>Mishkin_Ivan@mail.ru</email>
// <date>28.01.2015</date>
// <project>ItemsFilter</project>
// <license> GNU General Public License version 3 (GPLv3) </license>
// ****************************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace BolapanControl.ItemsFilter.Model {
    public class FiltersCollection {
        private readonly Dictionary<Type, Filter> dictionary = new();
        private readonly FilterPresenter parent;
        internal FiltersCollection(FilterPresenter parent) {
            this.parent = parent;
        }
        internal bool ContainsKey(Type filterKey) {
            return dictionary.ContainsKey(filterKey);
        }
        internal Filter this[Type key] {
            get {
                return (Filter)dictionary[key];
            }
            set {
                var defer = parent.DeferRefresh();
                Filter filter;
                if (dictionary.ContainsKey(key)) {
                    filter = (Filter)dictionary[key];
                    filter.Detach(parent);
                }
                dictionary[key] = filter = value;
                filter.Attach(parent);
                defer.Dispose();
            }
        }
        internal void Remove(Type key) {
            if (dictionary.ContainsKey(key)) {
                var defer = parent.DeferRefresh();
                Filter filter = (Filter)dictionary[key];
                filter.Detach(parent);
                dictionary.Remove(key);
                defer.Dispose();
            }
        }
        //internal void Remove(Filter filter) {
        //    var key = dictionary.FirstOrDefault(kvp => kvp.Value == filter).Key;
        //    if (key != null) {
        //        dictionary.Remove(key);

        //    };
        //}
        public IEnumerable<Filter> Filters {
            get {
                var enumerator = dictionary.Values.GetEnumerator();
                while (enumerator.MoveNext())
                    yield return (Filter)enumerator.Current;
            }
        }

        public int Count {
            get {
                return dictionary.Count;
            }
        }
    }
}
