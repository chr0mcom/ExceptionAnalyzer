﻿#region Usings

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

#endregion

[assembly: InternalsVisibleTo("ExceptionAnalyzer.Tests")]

namespace ExceptionAnalyzer.Models
{
	internal class InternalAnalyzedException
	{
		[JsonProperty("errorAnalysis")] internal string ErrorAnalysis { get; set; }

		[JsonProperty("userMessage")] internal string UserMessage { get; set; }

		[JsonProperty("developerDetails")] internal string DeveloperDetails { get; set; }

		[JsonProperty("solutions")] internal List<string> Solutions { get; set; }
	}
}