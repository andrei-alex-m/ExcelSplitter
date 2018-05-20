using CS.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    public class Validator<T>
    {
        public T bo { get; set; }
        private List<(Func<T, bool>, string)> _funcs;
        public Validator(List<(Func<T, bool>, string)> funcs)
        {
            _funcs = funcs;
        }
        public Validator()
        {

        }

        public bool IsValid => Validate().Item1;

        public IEnumerable<string> ValidationMessages() => Validate().Item2;

        public (bool, IEnumerable<string>) ValidationStatus => Validate();

        protected (bool, IEnumerable<string>) Validate()
        {

            bool Item1 = true;
            List<string> Item2 = new List<string>();

            if (null == bo || null == _funcs)
                return (Item1, Item2);

            _funcs.ForEach(x =>
            {
                var z = x.Item1(bo);
                if (!z)
                {
                    Item1 = false;
                    Item2.Add(x.Item2);
                };
            });

            return (Item1, Item2);
        }

    }
}
