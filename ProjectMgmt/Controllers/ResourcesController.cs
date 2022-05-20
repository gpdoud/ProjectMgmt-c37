
namespace ProjectMgmt.Controllers {

    public class ResourcesController {

        private ProjectContext _context = new ProjectContext();

        public IEnumerable<Resource> GetAll() {
            return _context.Resources.ToList();
        }
        public Resource? Get(int id) {
            return _context.Resources.Find(id);
        }
        public void Add(Resource Resource) {
            _context.Resources.Add(Resource);
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Add failed!");
        }
        public void Update(Resource Resource) {
            _context.Entry(Resource).State = EntityState.Modified;
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Update failed!");
        }
        public void Delete(int id) {
            var Resource = _context.Resources.Find(id);
            _context.Resources.Remove(Resource!);
            var ra = _context.SaveChanges();
            if (ra != 1) throw new Exception("Delete failed!");
        }
    }
}

