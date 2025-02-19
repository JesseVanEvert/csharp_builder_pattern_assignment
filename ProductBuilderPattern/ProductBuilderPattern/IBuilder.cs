using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductBuilderPattern
{
    public interface IBuilder
    {
         void InitializeName();
         void InitializeWidth();
         void InitializeHeight();
         void InitializeLength();

         void ResetName();
         void ResetWidth();
         void ResetHeight();
         void ResetLength();

         Product GetResult();

    }
}
