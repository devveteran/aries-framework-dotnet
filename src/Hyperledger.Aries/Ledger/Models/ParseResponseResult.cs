namespace Hyperledger.Aries.Ledger.Models
{
    
    /// <summary>Parse response result.</summary>
    public class ParseResponseResult
    {
        /// <summary>Gets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; private set; }

        /// <summary>Gets the object json.</summary>
        /// <value>The object json.</value>
        public string ObjectJson { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResponseResult" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="objectJson">Object json.</param>
        internal ParseResponseResult(string id, string objectJson)
        {
            this.Id = id;
            this.ObjectJson = objectJson;
        }
    }
}
