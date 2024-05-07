using Microsoft.Extensions.Logging;
using patient.Entities;

namespace patient.Services {
    public interface IPatientService {
        public IEnumerable<Patient> GetAllPatients();

    }
}
