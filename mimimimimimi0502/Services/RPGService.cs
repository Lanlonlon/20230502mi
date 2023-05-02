namespace mimimimimimi0502.Services;

public class RPGService
{

    public static IList<RPG> database;

    public RPGService()
    {
        database = new List<RPG>();
        database.Add(new RPG(){id = 0,name = "Rr",lv = 5});
        database.Add(new RPG(){id = 1,name = "Mm",lv = 20});
        database.Add(new RPG(){id = 2,name = "Ff",lv = 60});
        database.Add(new RPG(){id = 3,name = "Ss",lv = 10});
        database.Add(new RPG(){id = 4,name = "Ll",lv = 45});
        database.Add(new RPG(){id = 5,name = "Cc",lv = 99});
        database.Add(new RPG(){id = 6,name = "Dd",lv = 80});
        database.Add(new RPG(){id = 7,name = "Re",lv = 999});
    }
    
    public List<RPG> List()
    {
        List<RPG> result = null;

        var db  = from d in database
            select d;

        if (db.Any())
        {
            result = db.ToList();
        }

        return result;
    }


    public RPG Get(int id)
    {
        RPG result = null;

        var db  = from d in database 
            where d.id == id
        select d;

        if (db.Any())
        {
            result = db.First();
        }

        return result;
    }
    
    //POST/CREATE  新增
    public RPG Cteate(RPG rpg)
    {
        RPG result = null;

        rpg.id = database.Max(x => x.id) + 1;  //修正id

        database.Add(rpg);

        return result;
    }
}