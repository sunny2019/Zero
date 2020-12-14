using System;
using System.Collections;
using System.Collections.Generic;

[IFix.CustomBridge]
public static class AdditionalBridge
{
    static List<Type> bridge = new List<Type>()
    {
        typeof(IEnumerator)
    };
}