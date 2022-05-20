
namespace ProjectMgmt.Controllers {

    public class ProjectsController {

        private ProjectContext _context = new ProjectContext();

        public IEnumerable<Project> GetAll() {
            return _context.Projects.ToList();
        }
        public Project? Get(int id) {
            return _context.Projects.Find(id);
        }
        public void Add(Project project) {
            _context.Projects.Add(project);
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Add failed!");
        }
        public void Update(Project project) {
            _context.Entry(project).State = EntityState.Modified;
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Update failed!");
        }
        public void Delete(int id) {
            var project = _context.Projects.Find(id);
            _context.Projects.Remove(project!);
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Delete failed!");
        }
    }
}

