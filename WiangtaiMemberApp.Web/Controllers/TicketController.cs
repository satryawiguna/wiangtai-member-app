using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WiangtaiMemberApp.Web.Controllers;

[Authorize]
public class TicketController : Controller
{
    private readonly ILogger<TicketController> _logger;
    private readonly IMapper _mapper;

    public TicketController(ILogger<TicketController> logger,
        IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }


}