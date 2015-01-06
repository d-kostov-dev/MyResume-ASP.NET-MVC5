﻿namespace MyResume.Web.Areas.Administration.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using MyResume.Infrastructure.Mapping;
    using MyResume.Models;
    using MyResume.Web.Areas.Administration.Models.Base;
    
    
    public class AddEditCourseInputModel : BaseModel, IMapFrom<Course>
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Institution { get; set; }

        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }
    }
}