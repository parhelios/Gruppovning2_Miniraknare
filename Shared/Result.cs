using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Result
{
	[Required]
	public double OutputResult { get; set; }
}