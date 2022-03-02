﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ItemsFilter.net6.Test.Model {
    public enum StateEnum  {
        State1,
        State2
    }

    internal class EnumContentElement:ContentElement {
        public static readonly DependencyProperty StateEnumProp = DependencyProperty.Register(
nameof(State), typeof(StateEnum),
typeof(EnumContentElement)
);

        public StateEnum State {
            get => (StateEnum)GetValue(StateEnumProp);
            set => SetValue(StateEnumProp, value);
        }
    }
}
