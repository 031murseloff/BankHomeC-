﻿namespace CostomerException;

public class InputException:Exception
{
    public InputException() { }
    public InputException(string message) : base(message) { }
}