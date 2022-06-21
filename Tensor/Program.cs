﻿using System;
using System.Collections.Generic;

namespace Tensor
{
    public enum Axis3D
    {
        NONE,
        X,
        Y,
        Z
    }
    public enum CubeSides
    {
        UP,
        FRONT,
        RIGHT,
        BOTTOM,
        BACK,
        LEFT
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                TensorCube<int?> cube = new TensorCube<int?>(3);

                cube.InitializeWithSameValueAndRandomHollows(1, 2);

                Console.WriteLine(cube.ToStringAsCube());
                Console.WriteLine();

                Console.WriteLine(cube.ToStringCubeSides());
                Console.WriteLine();

                cube.PrintAllSidesHollowsToConsole();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Tensor<int> t1 = new Tensor<int>(2, new TensorItem<int>(2, 1, 0, 2)
                                                  , new TensorItem<int>(2, 2, 0, 1));
                Tensor<int> t2 = new Tensor<int>(2, new TensorItem<int>(2, 3, 0, 2)
                                                  , new TensorItem<int>(2, 4, 2, 1));

                Console.WriteLine("\nTensor 1");
                Console.WriteLine(t1);
                Console.WriteLine("Tensor 2");
                Console.WriteLine(t2);
                Console.WriteLine("Tensor sum: ");

                Console.WriteLine(t1 + t2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}