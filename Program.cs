List<Monster> monsterList = new List<Monster>()
{
    new Monster("Gromp", 100, false),
    new Monster("Cranky", 120, true),
    new Monster("CoffeeSpiller", 35, false) };



var monsterNames = (from Monster in monsterList
select Monster.Name);
foreach (var Monster in monsterNames)
Console.WriteLine(Monster);



List<string> names = monsterList.Select(x => x.Name).ToList();
names.ForEach(x => Console.WriteLine(x));



monsterList.Select(x => x.Name).ToList().ForEach(x => Console.WriteLine(x));// Uppgift 1



var names2 = monsterList.Select(x => x.Name).ToList();
names2.ForEach(x => Console.WriteLine(x));




var monsterHealth = (from Monster in monsterList
where (Monster.Health > 50)
select Monster.Name);
foreach (var Monster in monsterHealth)
Console.WriteLine(Monster);



var monsterHealth2 = monsterList.Where(x => x.Health > 50).Select(x => x.Name).ToList();
monsterHealth2.ForEach(x => Console.WriteLine(x));



monsterList.Where(x => x.Health > 50).Select(x => x.Name).ToList().ForEach(x => Console.WriteLine(x));




monsterList.Where(x => x.isDead).Select(x => x.Name).ToList().ForEach(x => Console.WriteLine(x));



monsterList.Select(x => x.Name)
            .OrderBy(x => x)
            .ToList()
            .ForEach(x => Console.WriteLine(x));



class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }
    public bool isDead { get; set; }



    public Monster(string name, int health, bool isDead)
    {
        Name = name;
        Health = health;
        this.isDead = isDead;
    }
}