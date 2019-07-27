using CDRManagement.DataAccess.AsterNet.Manager.Event;

namespace CDRManagement.DataAccess.AsterNet.Manager.Action
{
    /// <summary>
    ///     The ManagerActionResponse is implemented by ManagerActions that
    ///     return their result in a custom ManagerResponse<br />
    ///     The response type that indicates that Asterisk is finished is returned by the
    ///     ActionCompleteResponseClass property.
    /// </summary>
    /// <seealso cref="ResponseEvent" />
    public abstract class ManagerActionResponse : ManagerAction
    {
        /// <summary>
        ///     Returns the response type that indicates that Asterisk is finished sending response for this action.
        /// </summary>
        /// <seealso cref="AsterNET.Manager.Response" />
        public abstract object ActionCompleteResponseClass();
    }
}