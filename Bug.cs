public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        //This is where the bug happens
        if (MyProperty == 0)
        {
            //This should never happen based on the constructor
            throw new Exception("Unexpected value");
        }
    }
}