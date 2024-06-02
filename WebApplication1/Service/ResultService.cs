using WebApplication1.Models;
using WebApplication1.Repository.Interfaces;
using WebApplication1.Service.Interfaces;

namespace WebApplication1.Service
{
    public class ResultService : IResultService
    {
        private readonly IResultRepository _resultRepository;
        public ResultService(IResultRepository resultRepository)
        {
            _resultRepository = resultRepository;
        }

        public void SaveResult(CreateResultModel createModel)
        {
            _resultRepository.Insert(createModel);
        }
    }
}
