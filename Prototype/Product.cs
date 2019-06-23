using System;
namespace Prototype
{
    public abstract class Product : ICloneable
    {
         public abstract void use(string s);
         public object Clone(){
            return this.MemberwiseClone();
         }

    }
}