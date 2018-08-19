using System;

namespace TKMW.AzureCoreFizzBuzz.Interfaces
{
    public interface INumberProvider
    {
        bool Next();
        int TheNumber { get; }
        void Reset();
    }
}
