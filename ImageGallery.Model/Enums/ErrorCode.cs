using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGallery.Model.Enums
{
    public enum ErrorCode : int
    {
        Success = 20000,
        BadRequest = 40000,
        Unauthorized = 40100,
        Forbidden = 40300,
        NotFound = 40400,
        InternalServerError = 50000
    }
}