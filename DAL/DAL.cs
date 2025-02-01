using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businessentity;
using System.Data.Entity;
using System.IO;
using System.Data;

namespace DAL
{
    public class DAl
    {

        public List<human> read_human()
        {
            Db db = new Db();
            var q = from i in db.humen select i;
            return q.ToList();

        }
        public List<person> read_person()
        {
            Db db = new Db();
            var q = from i in db.persons select i;
            return q.ToList();
        }
        public person find(string name)
        {
            Db db = new Db();
            var q = (from i in db.persons where i.name == name select i).FirstOrDefault();
            return q;
        }
        public bool save(person p1)
        {
            Db db = new Db();
            db.persons.Add(p1);
            db.SaveChanges();
            return true;


        }
        public bool saveh(human h1)
        {
            Db db = new Db();
            db.humen.Add(h1);
            db.SaveChanges();
            return true;


        }
        public bool saveS(sport s1)
        {
            Db db = new Db();
            db.sport.Add(s1);
            db.SaveChanges();
            return true;


        }
        public bool savep(poshak p1)
        {
            Db db = new Db();
            db.poshak.Add(p1);
            db.SaveChanges();
            return true;


        }
        public bool savek(kala k1)
        {
            Db db = new Db();
            db.kalas.Add(k1);
            db.SaveChanges();
            return true;


        }
        public bool register(string name)
        {
            Db db = new Db();
            var q = from i in db.persons where i.name == name select i;
            if (q.Any())
            {
                return true;
            }
            return false;
        }
        public bool delete(person p1)
        {
            Db db = new Db();
            var q = (from i in db.persons where i.name == p1.name && i.password == p1.password select i).FirstOrDefault();
            db.persons.Remove(q);
            db.SaveChanges();
            return true;
        }
        public bool deleteh( int idi)
        {
            Db db = new Db();
            var q = (from i in db.humen where i.id == idi select i).FirstOrDefault();
            db.humen.Remove(q);
             db.SaveChanges();
            return true;
            
        }
        public bool deleteh2(string name)
        {
            Db db = new Db();
            var q = (from i in db.humen where i.name_id == name select i).FirstOrDefault();
            db.humen.Remove(q);
            db.SaveChanges();
            return true;

        }
        public bool check(human h1)
        {
            Db db = new Db();
            var q = from i in db.humen where i.name_id == h1.name_id select i;
            if (q.Any())
            {
                return true;
            }
            return false;
        }
        public bool check2(string pass)
        {
            Db db=new Db();
            var q = from i in db.humen where i.password == pass select i;
            if (q.Any())
            {
                return true;
            }
            return false;
        }
        public bool check_odd(human h1)
        {
            Db db = new Db();
            var q = from i in db.persons where i.name == h1.name && i.password != h1.password select i;
            if (q.Any())
            {
                return true;
            }
            else
                return false;
        }
        public human find_human(string name)
        {
            Db db = new Db();
            var q = from i in db.humen where i.name_id == name select i;
            return q.FirstOrDefault();
        }
        public human find_human2(string name)
        {
            Db db = new Db();
            var q = from i in db.humen where i.name == name select i;
            return q.FirstOrDefault();
        }
        public human updateh(int idi)
        {
            Db db = new Db();
            var q = (from i in db.humen where i.id == idi select i).FirstOrDefault();
            return q;
        }
        public human selecth(string name_id)
        {
            var db = new Db();
            var q = (from i in db.humen where i.name_id == name_id select i).FirstOrDefault();
            return q;

        }
        public kala selectk(int idi)
        {
            var db = new Db();
            var q = (from i in db.kalas where i.id == idi select i).FirstOrDefault();
            return q;

        }
        public poshak selectp(int idi)
        {
            var db = new Db();
            var q = (from i in db.poshak where i.id == idi select i).FirstOrDefault();
            return q;

        }
        public sport selects(int idi)
        {
            var db = new Db();
            var q = (from i in db.sport where i.id == idi select i).FirstOrDefault();
            return q;

        }
        public bool check22(human h1)
        {
            Db db = new Db();
            var q = (from i in db.humen where i.name_id == h1.name_id && i.password == h1.password select i).FirstOrDefault();

            if (q==null) 
            {
                return false;
            }
            return true;
        }
        public bool edits(sport s1)
        {
            Db db = new Db();
            var q = db.sport.FirstOrDefault(i => i.name==s1.name);
            if (q != null)
            {
                q.name= s1.name;
                q.size= s1.size;
                q.color= s1.color;
                q.number= s1.number;
                q.bprice= s1.bprice;
                q.sprice= s1.sprice;
                q.type= s1.type;
                q.goal= s1.goal;
                db.SaveChanges();
                return true;
            }
            return false;

        }
        public bool editp(poshak p1)
        {
            Db db = new Db();
            var q = db.poshak.FirstOrDefault(i => i.name==p1.name);
            if (q != null)
            {
                q.name = p1.name;
                q.size = p1.size;
                q.color = p1.color;
                q.number = p1.number;
                q.bprice = p1.bprice;
                q.sprice = p1.sprice;
                q.type = p1.type;
                q.goal= p1.goal;
                db.SaveChanges();
                return true;
            }
            return false;

        }
        public bool editk(kala k1)
        {
            Db db = new Db();
            var q = db.kalas.FirstOrDefault(i => i.name==k1.name);
            if (q != null)
            {
                q.name = k1.name;
                q.size = k1.size;
                q.color = k1.color;
                q.number = k1.number;
                q.bprice = k1.bprice;
                q.sprice = k1.sprice;
                q.type = k1.type;
                db.SaveChanges();
                return true;
            }
            return false;

        }
        public bool edith(human h1,int idi)
        {
            Db db=new Db();
            var q = db.humen.FirstOrDefault(i => i.id == idi);
            if (q != null)
            {
                q.name_id = h1.name_id;
                q.password = h1.password;
                q.name= h1.name;
                q.family= h1.family;
                q.code= h1.code;
                q.phone= h1.phone;
                q.gender= h1.gender;
                q.birthd= h1.birthd;
                q.registerd= h1.registerd;
                q.address= h1.address;
                q.photo= h1.photo;
                db.SaveChanges();
                return true;
            }
            return false;

        }
        public bool edith2(human h1,string name)
        {
            Db db = new Db();
            var q = db.humen.FirstOrDefault(i => i.name == name);
            if (q != null)
            {
                q.name_id = h1.name_id;
                q.password = h1.password;
                q.name = h1.name;
                q.family = h1.family;
                q.code = h1.code;
                q.phone = h1.phone;
                q.gender = h1.gender;
                q.birthd = h1.birthd;
                q.registerd = h1.registerd;
                q.address = h1.address;
                q.photo = h1.photo;
                db.SaveChanges();
                return true;
            }
            return false;

        }
        public bool edit(human h1,int idi) 
        {
            Db db=new Db();
			var humanToUpdate = db.humen.FirstOrDefault(i => i.id == idi);
			if (humanToUpdate != null)
			{
				humanToUpdate.name_id = h1.name_id;
				humanToUpdate.password = h1.password;
				db.SaveChanges();
                return true;
			}
            return false;
		}
        public List<kala> read_kala()
        {
            Db db = new Db();
            var q = from i in db.kalas select i;
            return q.ToList();

        }
        public List<sport> read_sport()
        {
            Db db = new Db();
            var q = from i in db.sport select i;
            return q.ToList();

        }
        public List<poshak> read_poshak()
        {
            Db db = new Db();
            var q = from i in db.poshak select i;
            return q.ToList();

        }
        public List<human> search_name_id(string name)
        {
            Db db = new Db();
            var q = from i in db.humen where i.name_id.Contains(name) select i;
            return q.ToList();
        }
        public List<human> search_name(string name)
        {
            Db db = new Db();
            var q = from i in db.humen where i.name.Contains(name) select i;
            return q.ToList();
        }
        

    }
}
