namespace Shared;

public class CalculatorService :ICalculatorService
{

	public List<Result> ResultsList { get; set; }

	public List<Result> GetValuesList()
	{
		return ResultsList;
	}

	public void AddResult(Result result)
	{
		ResultsList.Add(result);
	}

	public Result AddValues(ConvertedValues values)
	{
		var result = new Result();
		result.Value = values.Value1 + values.Value2;

		return result;

	}

	public Result SubtractValues(ConvertedValues values)
	{
		var result = new Result();
		result.Value = values.Value1 - values.Value2;

		return result;
	}

	public Result MultiplyValues(ConvertedValues values)
	{
		var result = new Result();
		result.Value = values.Value1 * values.Value2;

		return result;
	}

	public Result DivideValues(ConvertedValues values)
	{
		var result = new Result();
		result.Value = values.Value1 / values.Value2;

		return result;
	}

}