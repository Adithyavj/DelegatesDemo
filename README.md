# DelegatesDemo
A demo project to understand the basics of Delegates in C#

Usually we pass in information to a method as variables. In case of a delegate, we can pass information through a method instead of variables.
Delegates essentially pass in method as parameter to functions/methods.

### Func
Func is a generic delegate included in the System namespace. It has zero or more input parameters and one out parameter. The last parameter is considered as an out parameter.

```
namespace System
{    
    public delegate TResult Func<in T, out TResult>(T arg);
}
```

### Action
Action is a delegate type defined in the System namespace. An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value. In other words, an Action delegate can be used with a method that has a void return type.
