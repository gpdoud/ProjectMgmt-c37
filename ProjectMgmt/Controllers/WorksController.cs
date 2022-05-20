
namespace ProjectMgmt.Controllers {

    public class WorksController {

        private ProjectContext _context = new ProjectContext();

        public IEnumerable<Work> GetAll() {
            return _context.Works.ToList();
        }
        public Work? Get(int id) {
            return _context.Works.Find(id);
        }
        public void Add(Work work) {
            _context.Works.Add(work);
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Add failed!");
            // add the work hours to the project
            var res = _context.Resources.Find(work.ResourceId);
            var prj = _context.Projects.Find(res!.ProjectId);
            prj!.ActualHours += work.HoursWorked;
            ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Project work hours update failed!");
        }
        public void Update(Work work) {
            _context.Entry(work).State = EntityState.Modified;
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Update failed!");
        }
        public void Delete(int id) {
            var work = _context.Works.Find(id);
            _context.Works.Remove(work!);
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Delete failed!");
        }
    }
}

