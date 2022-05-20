
using ProjectMgmt.Controllers;
using ProjectMgmt.Models;

Console.WriteLine("Project Management");

var prjCtrl = new ProjectsController();

var project = new Project() {
    Id = 0, Description = "1st Project", ActualHours = 0, EstimatedHours = 10, PercentComplete = 0, Status = "NEW"
};

prjCtrl.Add(project);

var resCtrl = new ResourcesController();

var programmer = new Resource() {
    Id = 0, Name = "Programmer 1", HoursPerDay = 5, ProjectId = 1
};

resCtrl.Add(programmer);

var wrkCtrl = new WorksController();

var work1 = new Work() {
    Id = 0, Description = "Project Kickoff", HoursWorked = 4, ResourceId = 1
};

wrkCtrl.Add(work1);

var work2 = new Work() {
    Id = 0, Description = "Scrum standup", HoursWorked = 1, ResourceId = 1
};

wrkCtrl.Add(work2);
