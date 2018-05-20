using System;
using System.Collections.Generic;
using Caly.Utils;
using CS.BusinessLayer.Dictionaries;
using CS.BusinessLayer.Interfaces;
using CS.BusinessLayer.Model;

namespace CS.BusinessLayer.Builder
{
    static class ValidatorBuilder
    {/* 
        static Validator Build(BaseObject bo, List<(Func<BaseObject,bool>, string)> funcs)
        {
            Func<BaseObject,bool> f = (x)=> x.ID>0;

        } */

        static Dictionary<Type, Singleton<Validator<Type>>> validators;

        static Singleton<Validator<T>> GetValidator<T>(T bo)
        {
            return null;
        }
        static ValidatorBuilder()
        {
            validators = new Dictionary<Type, Singleton<Validator<Type>>>();

        }

        private static Validator<IdentificatorPF> GetValidatorIdentificatorPF()
        {
            List<(Func<IdentificatorPF, bool>, string)> funcs = new List<(Func<IdentificatorPF, bool>, string)>
            {
                (x=>Caly.Utils.ValidareCNP.Valid(x.CNP.ToString()), "CNP nevalid")
            };
            return new Validator<IdentificatorPF>(funcs);
        }
    }
}