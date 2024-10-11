namespace KPIMS.Core.APIResponse.Interfaces
{
    /// <summary>
    /// Interface IBusinessOperationResult
    /// </summary>
    public interface IBusinessOperationResult
    {
        /// <summary>
        /// Gets a value indicating whether the API operation succeeded.
        /// </summary>
        bool Succeeded { get; }

        /// <summary>
        /// Gets the errors generated during the API operation.
        /// </summary>
        IEnumerable<string> Errors { get; }
    }
}
