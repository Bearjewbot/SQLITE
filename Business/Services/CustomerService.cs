using System.Diagnostics;
using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Entities;
using Data.Interfaces;

namespace Business.Services;

public class CustomerService(ICustomerRepository customerRepository) : ICustomerService
{
    private readonly ICustomerRepository _customerRepository = customerRepository;

    public async Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        var entity =  await _customerRepository.GetAllAsync();

        try
        {
            return entity.Select(CustomerFactory.Map);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null!;
        }
    } 
}