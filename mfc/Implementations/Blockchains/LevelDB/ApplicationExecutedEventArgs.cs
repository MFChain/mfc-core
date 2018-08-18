using Mfc.Core;
using System;

namespace Mfc.Implementations.Blockchains.LevelDB
{
    public class ApplicationExecutedEventArgs : EventArgs
    {
        public Transaction Transaction { get; internal set; }
        public ApplicationExecutionResult[] ExecutionResults { get; internal set; }
    }
}
