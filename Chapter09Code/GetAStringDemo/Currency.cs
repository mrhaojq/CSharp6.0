﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GetAStringDemo
{
    struct Currency
    {
        public uint Dollars;
        public ushort Cents;

        public Currency(uint dollars, ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        public override string ToString() => $"${Dollars}.{Cents,2:00}";

        public static string GetCurrencyUnit() => "Dollar";

        public static explicit operator Currency(float value)
        {
            checked
            {
                uint dollars = (uint)value;
                ushort cents = (ushort)((value - dollars) * 100);
                return new Currency(dollars, cents);
            }
        }

        public static implicit operator float (Currency value)=>
            new Currency(value,0);

        public static implicit operator uint(Currency value) => value.Dollars;
    }
}
