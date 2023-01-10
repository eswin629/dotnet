namespace WebMVC.Models;

public class AbsensiViewModel
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime AbsentStartDate { get; set; }
    public DateTime AbsentEndDate { get; set; }
    public String Location { get; set; }
    public String Description { get; set; }
}
