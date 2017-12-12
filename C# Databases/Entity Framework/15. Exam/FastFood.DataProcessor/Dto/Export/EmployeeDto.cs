namespace FastFood.DataProcessor.Dto.Export
{
    public class EmployeeDto
    {
        public string Name { get; set; }

        public OrderImportDto[] Orders { get; set; }

        public decimal TotalMade { get; set; }
    }
}
