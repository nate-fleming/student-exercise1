using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var chickenMonkey = new Exercise("ChickenMonkey", "JS");
            var employees = new Exercise("Company Employees", "C#");
            var stocks = new Exercise("Stock Exchange", "C#");
            var dailyJournal = new Exercise("Daily Journal", "React");

            var cohort32 = new Cohort("Cohort 32");
            var cohort28 = new Cohort("Cohort 28");
            var cohort34 = new Cohort("Cohort 34");

            var deep = new Student("Deep", "Patel", "DP", cohort32);
            var joey = new Student("Joey", "Driscoll", "JD", cohort32);
            var jason = new Student("Jason", "Collum", "JC", cohort28);
            var collin = new Student("Collin", "Sandlin", "CS", cohort28);
            var dan = new Student("Dan", "Storm", "DS", cohort34);
            var sean = new Student("Sean", "Glavin", "SG", cohort34);

            var adam = new Instructor()
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "ADM",
                CohortName = cohort32,
                Specialty = "Type Script"
            };

            var bryan = new Instructor()
            {
                FirstName = "Bryan",
                LastName = "Neilson",
                SlackHandle = "BRYN",
                CohortName = cohort34,
                Specialty = "High Fives"
            };

            var steve = new Instructor()
            {
                FirstName = "Steve",
                LastName = "Brownlee",
                SlackHandle = "STV",
                CohortName = cohort28,
                Specialty = "Coach"
            };

            adam.AddExercise(deep, employees);
            adam.AddExercise(deep, stocks);
            bryan.AddExercise(deep, chickenMonkey);
            bryan.AddExercise(deep, dailyJournal);
            steve.AddExercise(deep, employees);
            steve.AddExercise(deep, stocks);

            adam.AddExercise(joey, employees);
            adam.AddExercise(joey, stocks);
            bryan.AddExercise(joey, chickenMonkey);
            bryan.AddExercise(joey, dailyJournal);
            steve.AddExercise(joey, employees);
            steve.AddExercise(joey, stocks);

            adam.AddExercise(jason, employees);
            adam.AddExercise(jason, stocks);
            bryan.AddExercise(jason, chickenMonkey);
            bryan.AddExercise(jason, dailyJournal);
            steve.AddExercise(jason, employees);
            steve.AddExercise(jason, stocks);

            adam.AddExercise(collin, employees);
            adam.AddExercise(collin, stocks);
            bryan.AddExercise(collin, chickenMonkey);
            bryan.AddExercise(collin, dailyJournal);
            steve.AddExercise(collin, employees);
            steve.AddExercise(collin, stocks);

            adam.AddExercise(dan, employees);
            adam.AddExercise(dan, stocks);
            bryan.AddExercise(dan, chickenMonkey);
            bryan.AddExercise(dan, dailyJournal);
            steve.AddExercise(dan, employees);
            steve.AddExercise(dan, stocks);

            adam.AddExercise(sean, employees);
            adam.AddExercise(sean, stocks);
            bryan.AddExercise(sean, chickenMonkey);
            bryan.AddExercise(sean, dailyJournal);
            steve.AddExercise(sean, employees);
            steve.AddExercise(sean, stocks);

            var students = new List<Student>();
            var exercises = new List<Exercise>();

            students.Add(deep);
            students.Add(joey);
            students.Add(jason);
            students.Add(collin);
            students.Add(dan);
            students.Add(sean);

            exercises.Add(chickenMonkey);
            exercises.Add(employees);
            exercises.Add(stocks);
            exercises.Add(dailyJournal);

            // foreach (Student student in students)
            // {
            //     Console.WriteLine($"{student.FirstName} {student.LastName} is working on:");
            //     student.ShowExercises();
            //     Console.WriteLine("");
            // }

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine($"These students are working on {exercise.Name}:");

                foreach (Student student in students)
                {
                    if (student.Exercises.Contains(exercise))
                    {
                        Console.WriteLine($"{student.FirstName}");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
