using ProductBuilderPattern;

Director director = new();

IBuilder concreteBuilderSimpleProduct = new ConcreteBuilder();
director.CreateSimpleProduct(concreteBuilderSimpleProduct);
Product simpleProductConcreteBuilder = concreteBuilderSimpleProduct.GetResult();
simpleProductConcreteBuilder.Display();

Console.WriteLine(" ---- ");

IBuilder concreteBuilderComplexProduct = new ConcreteBuilder();
director.CreateComplexProduct(concreteBuilderComplexProduct);
Product complexProductConcreteBuilder = concreteBuilderComplexProduct.GetResult();
complexProductConcreteBuilder.Display();

Console.WriteLine(" ---- ");

IFluentBuilder fluentBuilderSimpleProduct = new FluentBuilder();
director.CreateSimpleProduct(fluentBuilderSimpleProduct);
Product simpleProductFluentBuilder = fluentBuilderSimpleProduct.GetResult();
simpleProductFluentBuilder.Display();

Console.WriteLine(" ---- ");

IFluentBuilder fluentBuilderComplexProduct = new FluentBuilder();
director.CreateComplexProduct(fluentBuilderComplexProduct);
Product complexProductFluentBuilder = fluentBuilderComplexProduct.GetResult();
complexProductFluentBuilder.Display();


