namespace Tonestro.Maui.Amplitude.iOS.UsageChecker;

public static class BindingTestDataProvider
{
    public static IEnumerable<object[]> GetMethodsOfStaticTypeToTest(Type typeToTest)
    {
        return GetMethodsToTest(typeToTest, null);
    }

    public static IEnumerable<object[]> GetMethodsToTest<TType>(TType instance) where TType : class
    {
        return GetMethodsToTest(typeof(TType), instance);
    }

    private static IEnumerable<object[]> GetMethodsToTest(Type typeToTest, object instance)
    {
        List<object[]> ret = new List<object[]>();
        var methodsQuery = typeToTest.GetMethods()
            .Where(m => m.IsPublic)
            .Where(m => m.DeclaringType == typeToTest);
        if (instance == null)
        {
            methodsQuery = methodsQuery.Where(m => m.Name != "get_ClassHandle");
        }

        var methods = methodsQuery.ToList();
        if (methods.Count == 0)
        {
            throw new ArgumentException($"type {typeToTest} has no methods to test");
        }

        foreach (var method in methods)
        {
            var parameters = method.GetParameters().Select(p =>
            {
                Type pType = p.ParameterType;
                var ctor = pType.GetConstructor(Type.EmptyTypes);

                if (ctor != null)
                {
                    return ctor.Invoke(new object[] { });
                }

                if (pType == typeof(string))
                {
                    return $"b-{Guid.NewGuid()}";
                }

                if (pType == typeof(bool))
                {
                    return true;
                }

                if (pType == typeof(long))
                {
                    return -1L;
                }

                if (pType == typeof(NSNumber))
                {
                    return new NSNumber(-2);
                }

                if (pType == typeof(nint))
                {
                    return (nint) (-3);
                }

                if (pType == typeof(int))
                {
                    return (int) (-4);
                }

                if (pType == typeof(AMPAdSupportBlock))
                {
                    return (AMPAdSupportBlock) (() => "a");
                }

                if (pType == typeof(AMPLocationInfoBlock))
                {
                    return (AMPLocationInfoBlock) (() => new NSDictionary(new NSString("a"), new NSString("b")));
                }

                if (pType == typeof(Action))
                {
                    return (Action) (() => { });
                }

                throw new ArgumentException($"parameter type not supported: {pType} (method: {method})");
            }).ToArray();
            ret.Add(new object[] {instance, method, parameters});
        }

        return ret;
    }
}