using System.Runtime.CompilerServices;
using ProductBuilderPattern;

public class ConcreteBuilder : IBuilder
{
    private Product _product;

    public ConcreteBuilder()
    {
        _product = new Product();
    }

    public void InitializeHeight()
    {
        _product.Height = 10;
    }

    public void InitializeLength()
    {
        _product.Length = 15;
    }

    public void InitializeName()
    {
        _product.Name = "A name";
    }

    public void InitializeWidth()
    {
        _product.Width = 20;
    }

    public void ResetHeight()
    {
        _product.Height = null;
    }

    public void ResetLength()
    {
        _product.Length = null;
    }

    public void ResetName()
    {
        _product.Name = null;
    }

    public void ResetWidth()
    {
       _product.Width = null;
    }

    public Product GetResult() {
        return _product;
    }
}