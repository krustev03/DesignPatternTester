﻿using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
