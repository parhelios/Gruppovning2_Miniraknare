namespace Shared;

public interface ICalculatorService
{
	List<Values> GetValuesList();

	//void AddResult(ConvertedValues values);

	Result AddValues(ConvertedValues values);

	Result SubtractValues(ConvertedValues values);

	Result MultiplyValues(ConvertedValues values);

	Result DivideValues(ConvertedValues values);

}