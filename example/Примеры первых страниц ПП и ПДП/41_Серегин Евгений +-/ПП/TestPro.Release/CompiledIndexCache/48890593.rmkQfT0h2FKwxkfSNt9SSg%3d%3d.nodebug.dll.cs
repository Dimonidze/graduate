using Raven.Abstractions;
using Raven.Database.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using Raven.Database.Linq.PrivateExtensions;
using Lucene.Net.Documents;
using System.Globalization;
using System.Text.RegularExpressions;
using Raven.Database.Indexing;

public class Index_Auto_TestInfos_BySubject : Raven.Database.Linq.AbstractViewGenerator
{
	public Index_Auto_TestInfos_BySubject()
	{
		this.ViewText = @"from doc in docs.TestInfos
select new {
	Subject = doc.Subject
}";
		this.ForEntityNames.Add("TestInfos");
		this.AddMapDefinition(docs => 
			from doc in ((IEnumerable<dynamic>)docs)
			where string.Equals(doc["@metadata"]["Raven-Entity-Name"], "TestInfos", System.StringComparison.InvariantCultureIgnoreCase)
			select new {
				Subject = doc.Subject,
				__document_id = doc.__document_id
			});
		this.AddField("Subject");
		this.AddField("__document_id");
		this.AddQueryParameterForMap("Subject");
		this.AddQueryParameterForMap("__document_id");
		this.AddQueryParameterForReduce("Subject");
		this.AddQueryParameterForReduce("__document_id");
	}
}
