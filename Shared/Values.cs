using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Values
{
	[Required]
	public string Value1 { get; set; }
	[Required]
	public string Value2 { get; set; }
}