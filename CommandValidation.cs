using System.ComponentModel.DataAnnotations;
using System.Data;
public class CommandValidation
{

    void giveObjective()
    {
        det som ikke blir sendt til feilmelding blir sendt til CommandsToExecute
    }

    liste med validCommands


    string comandValidation()
    {
        hvis kommando eksisterer i listen over godtatte kommandoer, send til commandToExecute
    ellers, ignorer og send til logg som feilmelding
    return command;
    }
}