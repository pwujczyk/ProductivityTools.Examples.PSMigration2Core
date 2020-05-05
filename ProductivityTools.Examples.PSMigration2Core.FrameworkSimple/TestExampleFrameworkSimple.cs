using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Examples.PSMigration2Core.FrameworkSimple
{
    [Cmdlet(VerbsDiagnostic.Test, "FrameworkSimple")]
    public class TestExampleFrameworkSimple : System.Management.Automation.PSCmdlet
    {
        protected override void ProcessRecord()
        {
            Console.WriteLine("This is powershell module written in [.NET Framework 8.0]");
            base.ProcessRecord();
        }
    }
}
