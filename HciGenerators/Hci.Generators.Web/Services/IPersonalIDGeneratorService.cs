using System.Collections.Generic;

namespace Hci.Generators.Web.Services
{
    public interface IPersonalIdGeneratorService
    {
        List<string> GeneratePersonalIds();
    }
}
