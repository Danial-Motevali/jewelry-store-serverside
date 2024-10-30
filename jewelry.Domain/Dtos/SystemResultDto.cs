
namespace jewerly.Domain.Dtos;

//pls dont waste your time to fill all this only chose the ones that you realy need
public class SystemResultDto<T>
{
    public bool IsSuccess { get; set; }
    public T SingleData { get; set; }
    public List<T> DateList { get; set; }
    public string ExceptionMessage { get; set; }
    public string ErrorMessage { get; set; }
    public int NumberOfChange { get; set; }
}