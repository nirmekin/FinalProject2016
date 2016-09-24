﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Class for dealing with diffrents excepptions from the libary
 */
namespace Final_Project
{
    public class WeatherDataServiceException : Exception
    {
        public WeatherDataServiceException()
        {

        }

        public WeatherDataServiceException(string message) : base(message)
        {

        }

        public WeatherDataServiceException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
