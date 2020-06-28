﻿using System;

namespace Algorithms.Common
{
    public static class Comparers
    {
        /// <summary>
        /// Determines if a specific value is a number.
        /// </summary>
        /// <returns><c>true</c> if the value is a number; otherwise, <c>false</c>.</returns>
        /// <param name="value">Value.</param>
        /// <typeparam name="T">The Type of value.</typeparam>
        public static bool IsNumber<T>(this T value)
        {
            switch (value)
            {
                case sbyte _:
                case byte _:
                case short _:
                case ushort _:
                case int _:
                case uint _:
                case long _:
                case ulong _:
                case float _:
                case double _:
                case decimal _:
                    return true;
                default:
                    return false;
            }
        }


        /// <summary>
        /// Determines if firstValue is equals to the specified secondValue.
        /// </summary>
        /// <returns><c>true</c> if firstValue is equals to the specified secondValue; otherwise, <c>false</c>.</returns>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <typeparam name="T">The Type of values.</typeparam>
        public static bool IsEqualTo<T>(this T firstValue, T secondValue) where T : IComparable<T>
        {
            return firstValue.Equals(secondValue);
        }


        /// <summary>
        /// Determines if thisValue is greater than the specified otherValue.
        /// </summary>
        /// <returns><c>true</c> if thisValue is greater than the specified otherValue; otherwise, <c>false</c>.</returns>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <typeparam name="T">The Type of values.</typeparam>
        public static bool IsGreaterThan<T>(this T firstValue, T secondValue) where T : IComparable<T>
        {
            return firstValue.CompareTo(secondValue) > 0;
        }


        /// <summary>
        /// Determines if thisValue is less than the specified otherValue.
        /// </summary>
        /// <returns><c>true</c> if thisValue is less than the specified otherValue; otherwise, <c>false</c>.</returns>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <typeparam name="T">The Type of values.</typeparam>
        public static bool IsLessThan<T>(this T firstValue, T secondValue) where T : IComparable<T>
        {
            return firstValue.CompareTo(secondValue) < 0;
        }

    }

}
