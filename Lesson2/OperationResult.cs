using System;

namespace Lesson2;

public class OperationResult
{
    public bool Success
    { get; set; }
    public string Message
    { get; set; }
    public int Amount
    { get; set; }
    private OperationResult(bool success, string message, int amount)
    {
        Success = success;
        Message = message;
        Amount = amount;
    }

    public static OperationResult OK(int amount)
    {
        return new OperationResult(true, "Operation succeeded", amount);
    }
     public static OperationResult failure(string message, int amount)
    {
        return new OperationResult(false, message, amount);
    }
}
