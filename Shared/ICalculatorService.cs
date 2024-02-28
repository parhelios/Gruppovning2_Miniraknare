namespace Shared;

public interface ICalculatorService
{
	List<Values> GetValuesList();

	void AddValue(Values values);

	Result MultiplyValues(Values values);

	Result AddValues(Values values);
}