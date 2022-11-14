using demo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Service
{
    public class SomeService : ITransientService, IScopedService, ISingletonService

    {
        Guid ID;

        public SomeService()
        {
            ID = Guid.NewGuid();
        }

        public Guid GetID()
        {
            //throw new NotImplementedException();
            return ID;
        }


    }
}
