// Generated by `wit-bindgen` 0.34.0. DO NOT EDIT!
// <auto-generated />
#nullable enable

using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace ExampleWorld;

public partial class ExampleWorldImpl : IExampleWorld {

    public static int Add(int x, int y) {
        var r = ExampleWorld.exports.ExampleWorld.Add(x, y);
        if (r ==42) {
            Console.WriteLine("It's the answer to life, the universe, and everything");
        }
        return r;
    }

}
