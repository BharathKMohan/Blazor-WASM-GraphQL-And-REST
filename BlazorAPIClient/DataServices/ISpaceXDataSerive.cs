using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAPIClient.DTOs;

namespace BlazorAPIClient.DataServices
{
    public interface ISpaceXDataService
    {
        Task<List<LaunchDto>> GetAllLaunches();
    }
}