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
            //Handle this exception or investigate why it's happening            Console.WriteLine("Unexpected value: 0");
            //Instead of throwing an exception, we're adding handling
        }
        else
        {
            //The code to be executed if MyProperty is not 0
        }
    }
}