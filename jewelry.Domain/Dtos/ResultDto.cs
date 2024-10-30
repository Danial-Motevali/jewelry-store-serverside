
namespace jewerly.Domain.Dtos;

public class ResultDto
{
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; }
    public object Data { get; set; }


    public ResultDto Success(object value)
    {
        return new ResultDto() 
        {
            IsSuccess = true,
            Data = value
        };
    }

    public ResultDto Faild(string Error)
    {
        return new ResultDto()
        {
            IsSuccess = false,
            ErrorMessage = Error
        };
    }
}