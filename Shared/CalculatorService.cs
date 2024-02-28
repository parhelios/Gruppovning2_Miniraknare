namespace Shared;

public class CalculatorService :ICalculatorService
{

	public List<Values> ValuesList { get; set; }

	public List<Values> GetValuesList()
	{
		return ValuesList;
	}

	public void AddValue(ConvertedValues values)
	{
		throw new NotImplementedException();
	}

	public Result AddValues(ConvertedValues values)
	{
		throw new NotImplementedException();
	}

	public Result SubtractValues(ConvertedValues values)
	{
		throw new NotImplementedException();
	}

	public Result MultiplyValues(ConvertedValues values)
	{
		throw new NotImplementedException();
	}

	public Result DivideValues(ConvertedValues values)
	{
		throw new NotImplementedException();
	}

	public void AddValue(Values values)
	{
		throw new NotImplementedException();
	}

	public Result SubtractValues(Values values)
	{
		throw new NotImplementedException();
	}

	public Result MultiplyValues(Values values)
	{
		throw new NotImplementedException();
	}

	public Result DivideValues(Values values)
	{
		throw new NotImplementedException();
	}

	public Result AddValues(Values values)
	{
		throw new NotImplementedException();
	}
}