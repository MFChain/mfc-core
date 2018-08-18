using Mfc.IO;
using Mfc.IO.Caching;

namespace Mfc.UnitTests
{
    public class TestMetaDataCache<T> : MetaDataCache<T> where T : class, ISerializable, new()
    {
        public TestMetaDataCache()
            : base(null)
        {
        }

        protected override T TryGetInternal()
        {
            return null;
        }
    }
}
