using System.Reflection;
using Xunit;

namespace Tonestro.Maui.Amplitude.iOS.UsageChecker
{
    public class BindingsTest
    {
        [Fact]
        public void TestInit()
        {
            Assert.NotNull(Amplitude.Instance);
        }

        [Fact]
        public void TestInitWithToken()
        {
            const string apiKey = "asdf";
            Amplitude.Instance.InitializeApiKey(apiKey);
            Assert.Equal(apiKey, Amplitude.Instance.ApiKey);
        }

        public static IEnumerable<object[]> GetAmplitudeMethodsToTest() =>
            BindingTestDataProvider.GetMethodsToTest(Amplitude.Instance);

        // ReSharper disable once InconsistentNaming
        public static IEnumerable<object[]> GetAMPConfigManagerMethodsToTest() =>
            BindingTestDataProvider.GetMethodsToTest(new AMPConfigManager());

        // ReSharper disable once InconsistentNaming
        public static IEnumerable<object[]> GetAMPDatabaseHelperMethodsToTest() =>
            BindingTestDataProvider.GetMethodsToTest(new AMPDatabaseHelper());

        // ReSharper disable once InconsistentNaming
        public static IEnumerable<object[]> GetAMPDeviceInfoMethodsToTest() =>
            BindingTestDataProvider.GetMethodsToTest(new AMPDeviceInfo());

        // ReSharper disable once InconsistentNaming
        public static IEnumerable<object[]> GetAMPIdentifyMethodsToTest() =>
            BindingTestDataProvider.GetMethodsToTest(new AMPIdentify());

        // ReSharper disable once InconsistentNaming
        public static IEnumerable<object[]> GetAMPRevenueMethodsToTest() =>
            BindingTestDataProvider.GetMethodsToTest(new AMPRevenue());

        // ReSharper disable once InconsistentNaming
        public static IEnumerable<object[]> GetAMPTrackingOptionsMethodsToTest() =>
            BindingTestDataProvider.GetMethodsToTest(new AMPTrackingOptions());

        // ReSharper disable once InconsistentNaming
        public static IEnumerable<object[]> GetAMPUtilsMethodsToTest() =>
            BindingTestDataProvider.GetMethodsOfStaticTypeToTest(typeof(AMPUtils));

        // ReSharper disable once InconsistentNaming
        public static IEnumerable<object[]> GetConstantsMethodsToTest() =>
            BindingTestDataProvider.GetMethodsOfStaticTypeToTest(typeof(Constants));

        public static IEnumerable<object[]> GetSessionEventConstantsMethodsToTest() =>
            BindingTestDataProvider.GetMethodsOfStaticTypeToTest(typeof(SessionEventConstants));

        public static IEnumerable<object[]> GetAmplitude_MethodsToTest() =>
            BindingTestDataProvider.GetMethodsOfStaticTypeToTest(typeof(Amplitude_));

        [Fact]
        public void TestDataGenerators()
        {
            GetAMPConfigManagerMethodsToTest();
            GetAMPDatabaseHelperMethodsToTest();
            GetAMPDeviceInfoMethodsToTest();
            GetAMPIdentifyMethodsToTest();
            GetAMPRevenueMethodsToTest();
            GetAMPTrackingOptionsMethodsToTest();

            GetAMPUtilsMethodsToTest();

            GetConstantsMethodsToTest();
            GetSessionEventConstantsMethodsToTest();
            GetAmplitude_MethodsToTest();
            GetAmplitudeMethodsToTest();
        }
        
        [Theory]
        [MemberData(nameof(GetAmplitudeMethodsToTest))]
        public void TestAmplitude_Methods(object instance, MethodInfo method, object[] parameters)
        {
            TestMethod(instance, method, parameters);
        }
        
        [Theory]
        [MemberData(nameof(GetAmplitude_MethodsToTest))]
        public void TestAmplitude_ConstantMethods(object instance, MethodInfo method, object[] parameters)
        {
            TestMethod(instance, method, parameters);
        }

        // ReSharper disable once InconsistentNaming
        [Theory]
        [MemberData(nameof(GetAMPConfigManagerMethodsToTest))]
        public void TestAMPConfigManagerMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        // ReSharper disable once InconsistentNaming
        [Theory]
        [MemberData(nameof(GetAMPDatabaseHelperMethodsToTest))]
        public void TestAMPDatabaseHelperMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        // ReSharper disable once InconsistentNaming
        [Theory]
        [MemberData(nameof(GetAMPDeviceInfoMethodsToTest))]
        public void TestAMPDeviceInfoMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        // ReSharper disable once InconsistentNaming
        [Theory]
        [MemberData(nameof(GetAMPIdentifyMethodsToTest))]
        public void TestAMPIdentifyMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        // ReSharper disable once InconsistentNaming
        [Theory]
        [MemberData(nameof(GetAMPRevenueMethodsToTest))]
        public void TestAMPRevenueMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        // ReSharper disable once InconsistentNaming
        [Theory]
        [MemberData(nameof(GetAMPTrackingOptionsMethodsToTest))]
        public void TestAMPTrackingOptionsMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        [Theory]
        [MemberData(nameof(GetSessionEventConstantsMethodsToTest))]
        public void TestSessionEventConstantsMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        [Theory]
        [MemberData(nameof(GetConstantsMethodsToTest))]
        public void TestConstantsMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        // ReSharper disable once InconsistentNaming
        [Theory]
        [MemberData(nameof(GetAMPUtilsMethodsToTest))]
        public void TestAMPUtilsMethods(object instance, MethodInfo method, object[] parameters) =>
            TestMethod(instance, method, parameters);

        private static void TestMethod(object instance, MethodInfo method, object[] parameters)
        {
            try
            {
                if (method.IsStatic)
                {
                    method.Invoke(null, parameters);
                }
                else if (instance == null)
                {
                    Assert.Fail($"failed to execute method {method} (instance needed for non-static methods)");
                }
                else
                {
                    method.Invoke(instance, parameters);
                }
            }
            catch (Exception e)
            {
                Assert.Fail($"failed to execute method {method} (message: {e.Message})");
            }
        }
    }
}
