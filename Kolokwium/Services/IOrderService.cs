namespace Kolokwium.Services;

using Kolokwium.DTOs;

public interface IOrderService
{
    Task<WashingMachinesDTO> GetWashingMachinesOrders();
    Task<CustomerOrderDTO> AddNewWashingMachine();
}