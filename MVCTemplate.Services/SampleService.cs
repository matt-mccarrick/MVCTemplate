using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTemplate.Domain.Sample;

namespace MVCTemplate.Services
{
    public class SampleService : ISampleService
    {
        private readonly ISampleRepository _sampleRepository;
        public SampleService(ISampleRepository sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }
    }
}
