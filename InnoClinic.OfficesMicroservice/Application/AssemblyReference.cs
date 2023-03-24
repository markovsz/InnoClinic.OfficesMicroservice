using System.Reflection;

namespace Application
{
    public static class AssemblyReference
    {
        public static Assembly Assembly => Assembly.GetExecutingAssembly();
    }
}
