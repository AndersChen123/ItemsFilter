﻿// ****************************************************************************
// <author>mishkin Ivan</author>
// <email>Mishkin_Ivan@mail.ru</email>
// <date>28.01.2015</date>
// <project>ItemsFilter</project>
// <license> GNU General Public License version 3 (GPLv3) </license>
// ****************************************************************************
using System.ComponentModel;

namespace BolapanControl.ItemsFilter.Model {
    /// <summary>
    /// Base class for filter that use property of item.
    /// </summary>
    public abstract class PropertyFilter : Filter/*, IPropertyFilter*/
    {
#pragma warning disable IDE0052 // Remove unread private members
        private readonly ItemPropertyInfo _propertyInfo;
#pragma warning restore IDE0052 // Remove unread private members
        protected PropertyFilter(ItemPropertyInfo propertyInfo) : base(((PropertyDescriptor)(propertyInfo.Descriptor)).GetValue) {
            _propertyInfo = propertyInfo;
        }
        ///// <summary>
        ///// Gets the property info whose property name is filtered.
        ///// </summary>
        ///// <value>The property info.</value>
        //public ItemPropertyInfo PropertyInfo {
        //    get { return _propertyInfo; }
        //    protected set {
        //        _propertyInfo = value;
        //    }
        //}
    }
}
