// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Service.Api.V1.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Service;
    using Microsoft.PowerBI.Service.Api;
    using Microsoft.PowerBI.Service.Api.V1;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A dataset table
    /// </summary>
    public partial class Table
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        /// <param name="name">The table name</param>
        /// <param name="columns">The column schema for this table</param>
        /// <param name="rows">The data rows within this tabe</param>
        public Table(string name, IList<Column> columns, IList<Row> rows = default(IList<Row>))
        {
            Name = name;
            Columns = columns;
            Rows = rows;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the table name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the column schema for this table
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<Column> Columns { get; set; }

        /// <summary>
        /// Gets or sets the data rows within this tabe
        /// </summary>
        [JsonProperty(PropertyName = "rows")]
        public IList<Row> Rows { get; set; }

    }
}