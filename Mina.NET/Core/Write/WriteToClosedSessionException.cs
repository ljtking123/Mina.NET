﻿using System;
using System.Collections.Generic;

namespace Mina.Core.Write
{
    /// <summary>
    /// An exception which is thrown when one or more write operations were
    /// attempted on a closed session.
    /// </summary>
    [Serializable]
    public class WriteToClosedSessionException : WriteException
    {
        public WriteToClosedSessionException(IWriteRequest request)
            : base(request)
        { }

        public WriteToClosedSessionException(IEnumerable<IWriteRequest> requests)
            : base(requests)
        { }

        protected WriteToClosedSessionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
