﻿namespace MyResume.Web.Areas.Administration.Models.Base
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BaseModel
    {
        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}