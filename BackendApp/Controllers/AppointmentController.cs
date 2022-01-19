using BackendApp.Controllers.Models;
using BackendApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers;

[Route("/[controller]")]
[ApiController]
public class AppointmentController
{
    private readonly Context _context;

    public AppointmentController(Context context)
    {
        _context = context;
    }

    public async Task<ActionResult> Post(AppointmentModel appointmentModel)
    {
        var appointment = new Appointment
        {
            Contact = appointmentModel.Contact,
            Message = appointmentModel.Message,
            Name = appointmentModel.Name
        };

        _context.Appointments.Add(appointment);

        await _context.SaveChangesAsync();

        return new OkResult();
    }
}