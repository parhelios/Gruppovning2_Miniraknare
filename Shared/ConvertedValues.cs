using System.ComponentModel.DataAnnotations;

namespace Shared;

public class ConvertedValues
{
	[Required]
	public double Value1 { get; set; }
	[Required]
	public double Value2 { get; set; }
}