using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public abstract class HandleEvent<T>
    {
        protected List<T> _events = new List<T>();
        public abstract HandleEvent<T> AddEvent(T battleEvent);
        public abstract HandleEvent<T> AddEventCollection(T[] battleEvent);
        public abstract Task Execute();
    }
}
