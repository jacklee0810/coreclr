using System;
using System.Runtime.InteropServices;
/// <summary>
/// MarshalAsAttribute.SizeParamIndex [v-minch]
/// </summary>
public class MarshalAsAttributeSizeParamIndex
{
    public static int Main()
    {
        MarshalAsAttributeSizeParamIndex test = new MarshalAsAttributeSizeParamIndex();
        TestLibrary.TestFramework.BeginTestCase("MarshalAsAttribute.SizeParamIndex");
        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }
    #region PositiveTest
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Return the field SizeParamIndex in MarshalAsAttribute class 1");
        try
        {
            short unmanagedType = Int16.MaxValue;
            MarshalAsAttribute myMarshalAsAttribute = new MarshalAsAttribute(unmanagedType);
            short mySizeParamIndex = myMarshalAsAttribute.SizeParamIndex;
            if (mySizeParamIndex != 0)
            {
                TestLibrary.TestFramework.LogError("001", "the ExpectResult is 0 but the ActualResult is " + mySizeParamIndex);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Return the field SizeParamIndex in MarshalAsAttribute class 2");
        try
        {
            MarshalAsAttribute myMarshalAsAttribute = new MarshalAsAttribute(UnmanagedType.Currency);
            short mySizeParamIndex = myMarshalAsAttribute.SizeParamIndex;
            if (mySizeParamIndex != 0)
            {
                TestLibrary.TestFramework.LogError("003", "the ExpectResult is 0 but the ActualResult is " + mySizeParamIndex);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    #endregion

}