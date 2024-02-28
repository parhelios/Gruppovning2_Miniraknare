namespace Shared;

public interface ICalculatorService
{
	List<Result> GetValuesList();

	void AddResult(Result result);

	Result AddValues(ConvertedValues values);

	Result SubtractValues(ConvertedValues values);

	Result MultiplyValues(ConvertedValues values);

	Result DivideValues(ConvertedValues values);

}