using FluentValidation.Results;
using NSB.Domain.Core.Models;

namespace NSB.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public ValidationResult ValidationResult;
        public abstract bool IsValid();
    }
}