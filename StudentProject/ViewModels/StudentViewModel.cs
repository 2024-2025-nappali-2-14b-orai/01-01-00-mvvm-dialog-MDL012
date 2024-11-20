using CommunityToolkit.Mvvm.ComponentModel;
using StudentProject.Models;
using System.Collections.Generic;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student = new Student();

        [ObservableProperty]
        private List<string> _educationLevels = new EducationLevels().AllEducationLevels;
    }
}
