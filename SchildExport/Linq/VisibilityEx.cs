using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Linq
{
    /// <summary>
    /// LINQ extensions for filtering only visible entities.
    /// </summary>
    public static class VisibilityEx
    {
        public static IEnumerable<T> WhereIsVisible<T>(this IEnumerable<T> items)
             where T : IHasVisibility
        {
            return items.Where(x => x.IsVisible);
        }

        public static IEnumerable<StudyGroup> RemoveInvisibleGrades(this IEnumerable<StudyGroup> studyGroups)
        {
            return studyGroups
                .Select(studyGroup =>
                {
                    studyGroup.Grades = studyGroup.Grades.WhereIsVisible().ToList();
                    return studyGroup;
                });
        }

        public static IEnumerable<Teacher> RemoveInvisibleSubjects(this IEnumerable<Teacher> teachers)
        {
            return teachers
                .Select(teacher =>
                {
                    teacher.Subjects = teacher.Subjects.WhereIsVisible().ToList();
                    return teacher;
                });
        }

        public static IEnumerable<StudentPrivacy> RemoveInvisiblePrivacyCategories(this IEnumerable<StudentPrivacy> studentPrivacies)
        {
            return studentPrivacies
                .Select(privacy =>
                {
                    privacy.Approved = privacy.Approved.WhereIsVisible().ToList();
                    privacy.NotApproved = privacy.NotApproved.WhereIsVisible().ToList();
                    return privacy;
                });
        }

        public static IEnumerable<Grade> RemoveInvisibleTeachers(this IEnumerable<Grade> grades)
        {
            return grades
                .Select(grade =>
                {
                    grade.Teacher = grade.Teacher != null && grade.Teacher.IsVisible ? grade.Teacher : null;
                    grade.SubstituteTeacher = grade.SubstituteTeacher != null && grade.SubstituteTeacher.IsVisible ? grade.SubstituteTeacher : null;
                    return grade;
                });
        }

        public static IEnumerable<Tuition> RemoveInvisibleTeachers(this IEnumerable<Tuition> tuitions)
        {
            return tuitions
                .Select(tuition =>
                {
                    tuition.TeacherRef = tuition.TeacherRef != null && tuition.TeacherRef.IsVisible ? tuition.TeacherRef : null;
                    tuition.AdditionalTeachersRef = tuition.AdditionalTeachersRef.WhereIsVisible().ToList();
                    return tuition;
                });
        }

        public static IEnumerable<Tuition> WhereStudyGroupIsVisible(this IEnumerable<Tuition> tuitions)
        {
            return tuitions
                .Where(tuition => tuition.StudyGroupRef != null && tuition.StudyGroupRef.IsVisible);
        }
    }
}
