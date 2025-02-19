using ProductBuilderPattern;

public class Director {

    public void CreateSimpleProduct(IBuilder builder)
    {
        builder.InitializeName();
    }

    public void CreateComplexProduct(IBuilder builder)
    {
        builder.InitializeHeight();
        builder.InitializeWidth();
        builder.InitializeLength();
    }
    public void CreateSimpleProduct(IFluentBuilder builder)
    {
        builder.InitializeName();
    }

    public void CreateComplexProduct(IFluentBuilder builder)
    {
        builder.InitializeHeight()
               .InitializeWidth()
               .InitializeLength();
    }
}