using FactoryMethodDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Factories
{
    public interface IEntityFactory
    {
       
        T Create<T>(params object[] paramsArray) where T : class, IEntity;
    }
}
