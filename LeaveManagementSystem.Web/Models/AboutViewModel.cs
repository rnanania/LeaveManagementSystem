namespace LeaveManagementSystem.Web.Models;

public class AboutViewModel
{
    public string AppName { get; set; } = "Leave Management System";
    public string Version { get; set; } = "1.0.0";
    public string Description { get; set; } = "A web application for managing employee leave requests and approvals.";
    public string ContactEmail { get; set; } = "admin@example.com";
}
