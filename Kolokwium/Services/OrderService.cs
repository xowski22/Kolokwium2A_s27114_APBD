using Kolokwium.DTOs;
using Microsoft.EntityFrameworkCore;
using Kolokwium.Data;

namespace Kolokwium.Services;

public class OrderService : IOrderService
{
    private readonly DatabaseContext _context;

    public OrderService(DatabaseContext context)
    {
        _context = context;
    }
    
    public async Task<WashingMachinesDTO> GetWashingMachinesOrders()
    {
        var washingMachine = await _context.WashingMachines
            .Select(c => new CustomerOrderDTO
            {
                firstName = c.firstName,
                lastName = c.lastName
                phoneNumber = c.phoneNumber,
                purchaches =
                {
                    
                }
            })
        
    }
    
    public async Task<CustomerOrderDTO> AddNewWashingMachine()
    {
        throw new NotImplementedException();
    }
}