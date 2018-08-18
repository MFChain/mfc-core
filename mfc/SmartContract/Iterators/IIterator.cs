using Mfc.SmartContract.Enumerators;
using Mfc.VM;

namespace Mfc.SmartContract.Iterators
{
    internal interface IIterator : IEnumerator
    {
        StackItem Key();
    }
}
