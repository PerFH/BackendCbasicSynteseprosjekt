### Oppgave 2. tolker for robottoppdrag

## programflow
    lese instrukser fra dokument
    sjekke om kommandoen er gyldig
    sjekke om kommandoen er mulig å gjennomføre
    utfør kommando
    send info til logg
    
    mer avansert hvis jeg får tid: logikk som prøver å komme seg til punktet dersom 
    det er en gyldig kommando men noe som hindrer den i å utføre den

## Pseudokode
## class PositionOrientation
public string currentOrientation
{
    oppdater etter hver utført kommando
    return retning
}

public int xPosition
{
    oppdater etter hver utført kommando
    return xposisjon
}

public int yPosition
{
    oppdater etter hver utført kommando
    return yposisjon
}

## class GetCommands
bool fileExists
{
    sjekke om filen i det hele tatt eksisterer
}
private string getFile
{
    return "mission.txt"
}

## class CommandValidation


void giveObjective
    det som ikke blir sendt til feilmelding blir sendt til CommandsToExecute

liste med validCommands

string isValid
{
    hvis kommando eksisterer i listen over godtatte kommandoer, send til commandToExecute 
    ellers, ignorer og send til logg som feilmelding
}



## class CommandExecution
void executeCommand
{
    hvis kommandoen er både gyldig og mulig å gjennomføre så gjennomfører den kommandoen, og sender til logg som info
}

list CommandsToExecute

public Class CommandtoExecute
{
    public string commandType { get; set; }
    public int commandStrength { get; set; }
    publi string commandDirection { get; set; }
}



## bonus

# class Environment

arrays med grenser, og blokkerte koordinater

bool isPossible
    if isValid = true 
    sjekk om kommandoen er mulig å gjennomføre, (eksempel, gyldig kommando, men noe er i veien)
    hvis ikke send feilmelding til logg