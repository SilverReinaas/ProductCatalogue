using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace Open.Aids {
    public class GetSolution {
        public static AppDomain Domain => AppDomain.CurrentDomain;
        public static List<Assembly> Assemblies => Domain.GetAssemblies().ToList();
        public static Assembly Assembly(string name) {
            return Safe.Run(() => System.Reflection.Assembly.Load(name), null);
        }
        public static List<Type> Classes(string name) {
            return Safe.Run(() => {
                var a = Assembly(name);
                return a.GetTypes().ToList();
            }, new List<Type>());
        }
        public static List<string> ClassesNames(string name) {
            return Safe.Run(() => {
                var a = Classes(name);
                return a.Select(t => t.FullName).ToList();
            }, new List<string>());
        }
        public static string Name => 
            Safe.Run(() => {
                var n = GetClass.Namespace(typeof(GetSolution));
                return GetString.Head(n, '.');
            }, string.Empty);
    }
}
