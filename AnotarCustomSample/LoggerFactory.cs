﻿
// ReSharper disable UnusedTypeParameter
public class LoggerFactory
{
    public static Logger GetLogger<T>()
    {
        return new Logger();
    }
}