using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentProject.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student = new Student();

        [ObservableProperty]
        private List<string> _educationLevels = new EducationLevels().AllEducationLevels;

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        [ObservableProperty]
        private Student _selSelectedStudent = new Student();

        public StudentViewModel()
        {
            Student.BirthsDay = System.DateTime.Now.AddYears(-40);
        }

        [RelayCommand]
        public void DoSave(Student student)
        {
            if(Student.EducationLevel != "")
            {
                Students.Add(student);
                
                Student = new Student();
                Student.EducationLevel = "";
                Student.BirthsDay = System.DateTime.Now.AddYears(-40);
                OnPropertyChanged(nameof(Student));
            }
        }

        [RelayCommand]
        public void DoNew()
        {
            Student = new Student();
            Student.EducationLevel = "";
            Student.BirthsDay = System.DateTime.Now.AddYears(-40);
            OnPropertyChanged(nameof(Student));
        }

        [RelayCommand]
        public void DoDelete(Student student)
        {
            Students.Remove(student);
            Student = new Student();
            Student.EducationLevel = "";
            Student.BirthsDay = System.DateTime.Now.AddYears(-40);
            OnPropertyChanged(nameof(Student));
        }
    }
}
