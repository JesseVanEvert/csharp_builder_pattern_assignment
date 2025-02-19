using ProductBuilderPattern;

 public interface IFluentBuilder {
     IFluentBuilder InitializeName();
     IFluentBuilder InitializeWidth();
     IFluentBuilder InitializeHeight();
     IFluentBuilder InitializeLength();

     IFluentBuilder ResetName();
     IFluentBuilder ResetWidth();
     IFluentBuilder ResetHeight();
     IFluentBuilder ResetLength();

     Product GetResult();
}