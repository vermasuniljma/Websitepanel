﻿using System;
using WebsitePanel.WebDavPortal.Models.Common;

namespace WebsitePanel.WebDavPortal.Models
{
    public class ErrorModel
    {
        public int HttpStatusCode { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}