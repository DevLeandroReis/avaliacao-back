﻿namespace ClienteApi.Application.Services
{
    public class Result
    {
        public bool IsSuccess { get; }
        public string? Error { get; }

        private Result(bool isSuccess, string? error = null)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result Success()
        {
            return new Result(true);
        }

        public static Result Failure(string error)
        {
            return new Result(false, error);
        }
    }
}
