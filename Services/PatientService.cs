using patient.Entities;
using patient.Repository;

namespace patient.Services {
    public class PatientService(HopitalContext context) : IPatientService {
        private HopitalContext Context = context;

        public IEnumerable<Patient> GetAllPatients(){
            return this.Context.Patients;
        }
    }
}
