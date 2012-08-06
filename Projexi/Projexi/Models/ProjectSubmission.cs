using System;
using System.ComponentModel.DataAnnotations;

namespace Projexi.Models {
    public class ProjectSubmission {
        [Required]
        [Display(Name="Project Name")]
        public string ProjectName { get; set; }

        [Required]
        [Display(Name = "Requested By")]
        public string RequestedBy { get; set; }

        [Required]
        [Display(Name = "Details and Dimensions")]
        [DataType(DataType.MultilineText)]
        public string DetailsAndDimensions { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Deadline")]
        public DateTime Deadline { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "I would like to see first proof by")]
        public DateTime FirstProofDate { get; set; }

        [Display(Name = "Additional Comments")]
        [DataType(DataType.MultilineText)]
        public string AdditionalComments { get; set; }

        [Required]
        [Display(Name = "Key Objective/Call to Action")]
        public string KeyObjective { get; set; }

        [Required]
        [Display(Name = "Key Graphics Needed")]
        [DataType(DataType.MultilineText)]
        public string KeyGraphicsNeeded { get; set; }

        [Required]
        [Display(Name = "Target Audience")]
        public string TargetAudience { get; set; }

        public bool IsValid() {
            return !string.IsNullOrEmpty(ProjectName) &&
                !string.IsNullOrEmpty(RequestedBy) &&
                !string.IsNullOrEmpty(DetailsAndDimensions) &&
                !string.IsNullOrEmpty(KeyObjective) &&
                !string.IsNullOrEmpty(KeyGraphicsNeeded) &&
                !string.IsNullOrEmpty(TargetAudience);
        }
    }
}