using Mfc.VM;
using System;

namespace Mfc.SmartContract.Enumerators
{
    internal interface IEnumerator : IDisposable, IInteropInterface
    {
        bool Next();
        StackItem Value();
    }
}
