//Description
//Middle Earth is about to go to war. The forces of good will have many battles with the forces of evil.
//Different races will certainly be involved. Each race has a certain worth when battling against others. On the side of good we have the following races, with their associated worth:
//Hobbits: 1
//Men: 2
//Elves: 3
//Dwarves: 3
//Eagles: 4
//Wizards: 10
//On the side of evil we have:
//Orcs: 1
//Men: 2
//Wargs: 2
//Goblins: 2
//Uruk Hai: 3
//Trolls: 5
//Wizards: 10
//Although weather, location, supplies and valor play a part in any battle, if you add up the worth of the side of good and compare it with the worth of the side of evil,
//the side with the larger worth will tend to win.
//Thus, given the count of each of the races on the side of good, followed by the count of each of the races on the side of evil, determine which side wins.
//Input:
//The function will be given two parameters. Each parameter will be a string of multiple integers separated by a single space.
//Each string will contain the count of each race on the side of good and evil.
//The first parameter will contain the count of each race on the side of good in the following order:
//Hobbits, Men, Elves, Dwarves, Eagles, Wizards.
//The second parameter will contain the count of each race on the side of evil in the following order:
//Orcs, Men, Wargs, Goblins, Uruk Hai, Trolls, Wizards.
//All values are non-negative integers. The resulting sum of the worth for each side will not exceed the limit of a 32-bit integer.
//Output:
//Return "Battle Result: Good triumphs over Evil" if good wins, "Battle Result: Evil eradicates all trace of Good"
//if evil wins, or "Battle Result: No victor on this battle field" if it ends in a tie.

Console.WriteLine(GoodVsEvil("0 0 0 0 0 10 1", "0 1 1 1 1 0 0"));
Console.WriteLine(GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0 1"));
Console.WriteLine(GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
Console.WriteLine(GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));

static string GoodVsEvil(string good, string evil)
{
    const int HobbitsPower = 1, MenPower = 2, ElvesPower = 3, DwarvesPower = 3, EaglesPower = 4, WizardsPower = 10;
    const int OrcsPower = 1, WargsPower = 2, GoblinsPower = 2, UrukHaiPower = 3, TrollsPower = 5;
    var goodForcesPower = new List<int>() { HobbitsPower, MenPower, ElvesPower, DwarvesPower, EaglesPower, WizardsPower };
    var evilForcesPower = new List<int>() { OrcsPower, MenPower, WargsPower, GoblinsPower, UrukHaiPower, TrollsPower, WizardsPower };

    var goodForcesAmount = ForcesToList(good);
    if (goodForcesAmount.Count != 6)
    {
        return "Invalid good forces amount";
    }

    var evilForcesAmount = ForcesToList(evil);
    if (evilForcesAmount.Count != 7)
    {
        return "Invalid evil forces amount";
    }

    if (ForcesCount(goodForcesAmount, goodForcesPower) == ForcesCount(evilForcesAmount, evilForcesPower))
    {
        return "Battle Result: No victor on this battle field";
    }
    return ForcesCount(goodForcesAmount, goodForcesPower) > ForcesCount(evilForcesAmount, evilForcesPower)
        ? "Battle Result: Good triumphs over Evil" 
        : "Battle Result: Evil eradicates all trace of Good";
}

static List<int> ForcesToList(string forces) => forces.Split(" ").Select(x => int.Parse(x)).ToList();

static int ForcesCount(List<int> forcesList, List<int> racesPower)
{ 
    var sum = 0;
    var counter = 0;
    foreach (var item in forcesList)
    {
        if (item != 0)
        {
            sum += item * racesPower[counter];
        }
        counter++;
    }
    return sum;
}