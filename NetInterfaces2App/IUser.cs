using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetInterfaces2App
{
    interface IUser<T>
    {
        T Id { get; }
        string Name { set; get; }

        void Print();
    }

    class User<T> : IUser<T>
    {
        public T Id => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
