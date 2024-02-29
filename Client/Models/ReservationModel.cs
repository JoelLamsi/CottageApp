using System.ComponentModel.DataAnnotations;

namespace Client.Models;

public class ReservationModel 
    {
        [Required, Future(ErrorMessage = "Check In date has to be greater than or equal to today's date"), LessThan(nameof(CheckOutDate))]
        public DateTime CheckInDate { get; set; }
        [Required, Future(ErrorMessage = "Check Out date has to be greater than or equal to today's date"), GreaterThan(nameof(CheckInDate))]
        public DateTime CheckOutDate { get; set; }
        [Required, StringLength(200)]
        public string? FirstName { get; set; }
        [Required, StringLength(200)]
        public string? LastName { get; set; }
        [StringLength(200)]
        public string? Email { get; set; }
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
    }

public class FutureAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        var date = (DateTime)value;
        return date >= DateTime.Now.AddDays(-1);
    }
}

public class GreaterThanAttribute : ValidationAttribute
{
    private readonly string _comparisonProperty;

    public GreaterThanAttribute(string comparisonProperty)
    {
        _comparisonProperty = comparisonProperty;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var property = validationContext.ObjectType.GetProperty(_comparisonProperty);

        if (property is null)
        {
            return new ValidationResult($"Unknown property: {_comparisonProperty}");
        }

        var comparisonValue = property.GetValue(validationContext.ObjectInstance);

        if (value is DateTime dateTime && comparisonValue is DateTime comparisonDateTime)
        {
            if (dateTime <= comparisonDateTime)
            {
                return new ValidationResult($"{validationContext.DisplayName} must be later {_comparisonProperty}");
            }
        }

        return ValidationResult.Success;
    }
}

public class LessThanAttribute : ValidationAttribute
{
    private readonly string _comparisonProperty;

    public LessThanAttribute(string comparisonProperty)
    {
        _comparisonProperty = comparisonProperty;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var property = validationContext.ObjectType.GetProperty(_comparisonProperty);

        if (property is null)
        {
            return new ValidationResult($"Unknown property: {_comparisonProperty}");
        }

        var comparisonValue = property.GetValue(validationContext.ObjectInstance);

        if (value is DateTime dateTime && comparisonValue is DateTime comparisonDateTime)
        {
            if (dateTime >= comparisonDateTime)
            {
                return new ValidationResult($"{validationContext.DisplayName} must be before {_comparisonProperty}");
            }
        }

        return ValidationResult.Success;
    }
}