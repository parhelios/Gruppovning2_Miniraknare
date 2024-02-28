namespace Shared;

public class CalculatorService :ICalculatorService
{

	public List<Values> ValuesList { get; set; }

	public List<Values> GetValuesList()
	{
		return ValuesList;
	}

	public void AddValue(Values result)
	{
		ValuesList.Add(result);
	}

	public Result MultiplyValues(Values values)
	{
		throw new NotImplementedException();
	}

	public Result AddValues(Values values)
	{
		throw new NotImplementedException();
	}
}