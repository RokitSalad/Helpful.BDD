Helpful.BDD
===========

##Example of use##
```c#
class when_some_scenario_is_true : TestBase
{
    private ClassUnderTest _classUnderTest;
    private Exception _caughtException;

    protected override void Given()
    {
        _classUnderTest = new ClassUnderTest();
    }

    protected override void When()
    {
    	try
    	{
    		_classUnderTest.TestMethod();
    	}
    	catch(Exception e)
    	{
    		_caughtException = e;
    	}
    }

    [Then]
    public void there_should_be_no_exceptions_thrown()
    {
    	Assert.That(_caughtException, Is.Null);
    }
}
```

##Notes##
Given() is optional, this is a virtual method so doesn't have to be overridden.

The tests run perfectly fine in NUnit console and Resharper but Resharper 9.0 has a problem seeing the inheritd types (I've been told by JetBrains that this is fixed in 9.1, but I haven't tried it).