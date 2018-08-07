using System;
using System.Collections.Generic;

namespace NSB.Domain.Core.Commands
{
    public class CommandResult
    {
        public bool Success { get; private set; }
        public ICollection<Exception> Errors { get; } = new List<Exception>();

        public CommandResult (bool success = false)
        {
            Success = Success;
        }
    }
}