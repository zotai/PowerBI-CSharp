// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Reports.
    /// </summary>
    public static partial class ReportsExtensions
    {
            /// <summary>
            /// Gets a list of reports available within the specified workspace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            public static ODataResponseListReport GetReports(this IReports operations, string collectionName, string workspaceId)
            {
                return Task.Factory.StartNew(s => ((IReports)s).GetReportsAsync(collectionName, workspaceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of reports available within the specified workspace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListReport> GetReportsAsync(this IReports operations, string collectionName, string workspaceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReportsWithHttpMessagesAsync(collectionName, workspaceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}