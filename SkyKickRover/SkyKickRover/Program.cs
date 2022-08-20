using SkyKickRover.Enumeration;
using SkyKickRover.Models;
using SkyKickRover.ValueObjects;

Console.WriteLine("Welcome to Sky Kick");
Console.WriteLine("Enter any Key: ");
ConsoleKeyInfo keyPress = Console.ReadKey();
Console.WriteLine("You pressed {0}", keyPress.KeyChar);
var roverDefault = new Rover(new Position(0, 0));
Console.WriteLine("Fisrt Rover land");
Console.WriteLine(roverDefault.GetPosition());
var roverWithCardinal = new Rover(new Position(0, 0), Cardinal.South);

Console.WriteLine("Second Rover land");
Console.WriteLine(roverWithCardinal.GetPosition());
Console.ReadKey();

roverDefault.Move(MovementsEnumeration.Left);
roverWithCardinal.Move(MovementsEnumeration.Right);

Console.WriteLine("Rotate");
Console.WriteLine(roverDefault.GetPosition());
Console.WriteLine(roverWithCardinal.GetPosition());
Console.ReadKey();
