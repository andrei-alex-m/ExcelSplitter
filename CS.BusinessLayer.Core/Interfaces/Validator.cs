using CS.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    public class Validator<T> : IValidator where T:BaseObject
    {
        private List<Func<T, (bool, IEnumerable<string>)>> _funcs;

        public Validator()
        {

        }

        public Validator(List<Func<T,(bool, IEnumerable<string>)>> funcs)
        {
            _funcs = funcs;
        }


        public bool IsValid => Validate().Item1;

        public IEnumerable<string> ValidationMessages() => Validate().Item2;

        public (bool, IEnumerable<string>) ValidationStatus =>Validate();

        protected (bool, IEnumerable<string>) Validate()
        {
            bool Item1=true;
            List<string> Item2 = new List<string>();
            _funcs.ForEach(x =>
            {

            });
        }

    }
}
