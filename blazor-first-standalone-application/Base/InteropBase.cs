using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;
using Microsoft.AspNetCore.Blazor.Components;

namespace blazorfirststandaloneapplication.Base
{
    public class InteropBase : BlazorComponent
    {
        public Action CallLoadDataAboutUsers(string parameter = "ExampleData")
        {
            return () =>
            {
                if (RegisteredFunction.Invoke<bool>("loadDataAboutUsers", parameter))
                {
                    Console.WriteLine("End sucessfully");
                }
                else
                {
                    Console.WriteLine("End failed");
                }

                //Object serialized to json:
                RegisteredFunction.Invoke<bool>("loadDataAboutUsers", new { exampleProperty = "Example Data" });
            };
        }

        public static void ExampleDotNetMethod(string text)
        {
            Console.WriteLine($"DUMP! Method executed from javascript and invoked text from JS: {text}");
        }
    }
}
