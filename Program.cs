using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Routine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var routine = LoadOrCreateRoutine();

            Application.Run(new RoutineForm(routine));
        }

        static Routine LoadOrCreateRoutine()
        {
            var routinePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "routine.json");

            if(!File.Exists(routinePath))
            {
                return new Routine();
            }

            var routineJson = File.ReadAllText(routinePath);

            var routine = JsonConvert.DeserializeObject<Routine>(routineJson);

            return routine;
        }
    }
}
