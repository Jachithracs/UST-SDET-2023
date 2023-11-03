using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class FamilyMembers
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<FamilyMembers> Children { get; set; }

        public FamilyMembers(string name, int age)
        {
            Name = name;
            Age = age;
            Children = new List<FamilyMembers>();
        }

        public void AddChild(FamilyMembers child)
        {
            Children.Add(child);
        }
    }

    class FamilyTree
    {
        private FamilyMembers root;

        public FamilyTree(FamilyMembers root)
        {
            this.root = root;
        }

        public void DisplayFamilyTree()
        {
            DisplayFamilyTree(root, 0);
        }

        private void DisplayFamilyTree(FamilyMembers member, int depth)
        {
            string indentation = new string('-', depth * 2);
            Console.WriteLine($"{indentation}{member.Name} (Age: {member.Age})");

            foreach (var child in member.Children)
            {
                DisplayFamilyTree(child, depth + 1);
            }
        }
    }
}

