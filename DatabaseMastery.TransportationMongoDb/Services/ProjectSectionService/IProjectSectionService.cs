using DatabaseMastery.TransportationMongoDb.Dtos.ProjectSectionDtos;

namespace DatabaseMastery.TransportationMongoDb.Services.ProjectSectionService
{
    public interface IProjectSectionService
    {
        Task<List<ResultProjectSectionDto>> GetAllProjectSectionAsync();

        Task CreateProjectSectionAsync(CreateProjectSectionDto createProjectSectionDto);
        Task UpdateProjectSectionAsync(UpdateProjectSectionDto updateProjectSectionDto);

        Task<GetProjectSectionByIdDto> GetProjectSectionByIdAsync(string id);

        Task DeleteProjectSectionAsync(string id);
    }
}
