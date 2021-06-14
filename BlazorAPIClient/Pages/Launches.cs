using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAPIClient.DataServices;
using BlazorAPIClient.DTOs;
using Microsoft.AspNetCore.Components;

namespace BlazorAPIClient.Pages
{
    public partial class Launches
    {
        [Inject]
        ISpaceXDataService SpaceXDataService{get; set;}
        private List<LaunchDto> launches;

        protected override async Task OnInitializedAsync()
        {
            launches = await SpaceXDataService.GetAllLaunches();
        }
    }
}