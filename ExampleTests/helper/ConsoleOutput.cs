using System;
using System.IO;
using System.Linq;

namespace gamedev.helper
{
  public class ConsoleOutput : IDisposable
  {
    private StringWriter stringWriter;
    private TextWriter originalOutput;

    public ConsoleOutput()
    {
      stringWriter = new StringWriter();
      originalOutput = Console.Out;
      Console.SetOut(stringWriter);
    }

    public override string ToString()
    {
      return stringWriter.ToString();
    }
    
    public string[] GetOuput()
    {
      string[] console = stringWriter.ToString().Split("\n");
      return console.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    }

    public void Dispose()
    {
      Console.SetOut(originalOutput);
      stringWriter.Dispose();
    }
  }
}
