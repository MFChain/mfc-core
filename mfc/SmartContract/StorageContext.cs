using Mfc.VM;

namespace Mfc.SmartContract
{
    internal class StorageContext : IInteropInterface
    {
        public UInt160 ScriptHash;
        public bool IsReadOnly;

        public byte[] ToArray()
        {
            return ScriptHash.ToArray();
        }
    }
}
