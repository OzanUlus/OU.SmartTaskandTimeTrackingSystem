﻿namespace SmartTaskandTimeTrackingSystem.Shared.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true) { }

        public SuccessResult(string message) : base(true, message) { }

    }
}
