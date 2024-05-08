using patient.Entities;
using patient.Repository;

namespace patient.Services {
    public class PatientService(HopitalContext context) : IPatientService {
        private HopitalContext Context = context;

        public IEnumerable<Patient> GetAllPatients(){
            return this.Context.Patients;
        }

        public IEnumerable<Patient> GetAllPatients(int take, int skip) {
            if (take == 0) {
                take = 5;
            } 

            if(skip == 0) {
                skip = 0;
            }

            return this.Context.Patients.Skip(skip).Take(take);
        }
    }
}
