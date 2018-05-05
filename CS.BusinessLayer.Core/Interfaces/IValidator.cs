using System.Collections.Generic;

namespace CS.BusinessLayer.Interfaces
{
    public interface IValidator
    {
        bool IsValid { get; }
        (bool, IEnumerable<string>) ValidationStatus { get; }

        IEnumerable<string> ValidationMessages();
    }
}