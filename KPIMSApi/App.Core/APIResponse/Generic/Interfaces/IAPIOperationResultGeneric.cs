using KPIMS.Core.APIResponse.Interfaces;

namespace KPIMS.Core.APIResponse.Generic.Interfaces
{
    public interface IAPIOperationResultGeneric<out T> : IAPIOperationResult
    {
        /// <summary>
        /// Gets the result returned by the operation.
        /// </summary>
        T Result { get; }
    }
}
