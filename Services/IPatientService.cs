using Microsoft.Extensions.Logging;
using patient.Entities;

namespace patient.Services {
    public interface IPatientService {
        public IEnumerable<Patient> GetAllPatients();
        public IEnumerable<Patient> GetAllPatients(int take, int skip);
    }
}
