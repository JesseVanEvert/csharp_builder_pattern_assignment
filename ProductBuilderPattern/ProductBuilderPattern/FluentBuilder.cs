using ProductBuilderPattern;

public class FluentBuilder : IFluentBuilder
{   
    private Product _product;

    public FluentBuilder()
    {
        _product = new Product();   
    }

    public Product GetResult()
    {
        return _product;
    }

    public IFluentBuilder InitializeHeight()
    {
        _product.Height = 5;
        return this;
    }

    public IFluentBuilder InitializeLength()
    {
        _product.Length = 5;
        return this;
    }

    public IFluentBuilder InitializeName()
    {
        _product.Name = "Fluent product";
        return this;
    }

    public IFluentBuilder InitializeWidth()
    {
        _product.Width = 5;
        return this;
    }

    public IFluentBuilder ResetHeight()
    {
        _product.Height = null;
        return this;
    }

    public IFluentBuilder ResetLength()
    {
        _product.Length = null;
        return this;
    }

    public IFluentBuilder ResetName()
    {
        _product.Name = null;
        return this;
    }

    public IFluentBuilder ResetWidth()
    {
        _product.Width = null;
        return this;
    }
}