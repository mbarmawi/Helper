﻿using System;
using System.Collections.Generic;

namespace Helper
{
  public static class Numbers
  {
    private static readonly Random randomNumber = new Random();
    private static readonly object syncLock = new object();


    public static int GetRandomNumber(int min, int max)
    {
      lock (syncLock)
      {
        return (randomNumber).Next(min, max);
      }
    }

    public static int GetRandomNumber() => randomNumber.Next(int.MinValue, int.MaxValue);

    public static int GetRandomNumber(int max) => GetRandomNumber(0, max);

    public static int ToInt(string value) => Utility.Map<int>(value);

    public static double ToDouble(string value) => Utility.Map<double>(value);

    public static string ToBinary(int value) => Convert.ToString(value, 2);

    public static string ToHex(int value) => value.ToString("X");

    /// <summary>
    /// Generate Fibonacci Sequence
    /// </summary>
    /// <param name="maximumValue">Maximum value in the sequence</param>
    /// <returns></returns>
    public static int[] CalcFibonacciSequence(long maximumValue)
    {
      var fibs = new List<int>() { 0, 1 };
      if (maximumValue == 0) return new int[] { 0 };
      if (maximumValue == 1) return fibs.ToArray();
      while ((fibs[fibs.Count - 1] + fibs[fibs.Count - 2]) <= maximumValue)
      {
        fibs.Add(fibs[fibs.Count - 1] + fibs[fibs.Count - 2]);
      }
      return fibs.ToArray();
    }

    public static bool IsEven(int value) => (value % 2) == 0;

    public static bool IsOdd(int value) => (value % 2) != 0;

    /// <summary>
    /// Get decimal number with fixed number after zero depend on the length parameter
    /// </summary>
    /// <param name="value"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public static double ToFixed (double value, int length = 0) => Math.Truncate(value * Math.Pow(10, length)) / Math.Pow(10, length);


  }
}