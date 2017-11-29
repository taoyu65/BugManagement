using System.ComponentModel;

namespace BugManagement.Common.OperationResult
{
    [Description("Return result")]
    public enum OperationResultType
    {
        [Description("Operation Success")]
        Success,

        [Description("Nothing has been changed, operation canceled")]
        NoChanged,

        [Description("Parameter Error")]
        ParamError,

        [Description("No Result")]
        Null,

        [Description("No Permission")]
        NoPermission,

        [Description("Warning")]
        Warning,

        [Description("Unknown Exception Occur")]
        Error
    }
}
