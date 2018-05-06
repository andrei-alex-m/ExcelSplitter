using System;
using Caly.Utils.Enums;

namespace Caly.Utils
{
    public static class CNP
    {
        public static bool Valid(string cnp)
        {
            if (cnp.Length != 13)

                return false;

            const string a = "279146358279";

            long j = 0;

            if (!long.TryParse(cnp, out j))

                return false;

            long suma = 0;

            for (int i = 0; i < 12; i++)

                suma += long.Parse(cnp.Substring(i, 1)) * long.Parse(a.Substring(i, 1));

            long rest = suma - 11 * (int)(suma / 11);

            rest = rest == 10 ?

           1 : rest;

            if (long.Parse(cnp.Substring(12, 1)) != rest)

                return false;

            return true;

        }
        public static Sex SexFromCNP(string CNP)
        {
            switch (CNP[0])
            {
                case '1':
                    return Sex.M;
                case '2':
                    return Sex.F;
                default:
                    throw new ArgumentOutOfRangeException("CNP Invalid");
            }
        }
    }
}
