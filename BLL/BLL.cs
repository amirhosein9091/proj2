using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Businessentity;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Channels;
using Microsoft.SqlServer.Server;

namespace BLL
{
    public class BLl
    {
        public List<human> read_human()
        {
           DAl d1 = new DAl();
            return d1.read_human();
        }
        public List<person> read_person()
        {
            DAl d1 = new DAl();
            return d1.read_person();
        }
        public person find(string name)
        {
           DAl d1 = new DAl();
            return d1.find(name);
        }
        public bool save(person p1)
        {
            DAl d1 = new DAl();
            return d1.save(p1);
        }
        public bool saveh(human h1)
        {
            DAl d1 = new DAl();
            return d1.saveh(h1);
        }

        public bool savep(poshak p1)
        {
            DAl d1 = new DAl();
            return d1.savep(p1);
        }
        public bool saveS(sport s1)
        {
            DAl d1 = new DAl();
            return d1.saveS(s1);
        }
        public bool savek(kala k1)
        {
            DAl d1 = new DAl(); 
            return d1.savek(k1);
        }


        public bool register(string name)
        {
            DAl d1 = new DAl();
            return d1.register(name);
        }
        public bool delete(person p1)
        {
            DAl d1 = new DAl();
            return d1.delete(p1);
        }
        public bool deleteh(int idi)
        {
            DAl d1 = new DAl();
            return d1.deleteh(idi);
        }
        public bool deleteh2(string name)
        {
            DAl d1 = new DAl();
            return d1.deleteh2(name);
        }
        public bool check(human h1)
        {
            DAl d1 = new DAl();
            return d1.check(h1);
        }
        public bool check_odd(human h1)
        {
            DAl d1 = new DAl();
            return d1.check_odd(h1);
        }
        public human find_human (string name)
        {
            DAl d1 = new DAl();
            return d1.find_human(name);
        }
        public bool check2(string pass)
        {
            DAl d1 = new DAl();
            return d1.check2(pass);
        }
        public human updateh(int idi)
        {
            DAl d1 = new DAl();
            return d1.updateh(idi);
        }
        public human find_human2(string name)
        {
            DAl d1 = new DAl();
            return d1.find_human2(name);
        }
        public bool edith(human h1, int idi)
        {
            DAl d1 = new DAl();
            return d1.edith(h1,idi);
        }
        public human selecth(string name_id)
        {
            DAl d1= new DAl();
            return d1.selecth(name_id);
        }

        public bool check22(human h1)
        {
            DAl d1 = new DAl();
            return d1.check22(h1);
        
        }
        public bool edit(human h1,int idi) 
        {
            DAl d1=new DAl();
            return d1.edit(h1,idi);
        }
        public bool editk(kala k1)
        {
            DAl d1=new DAl();
            return d1.editk(k1);
        }
        public bool edith2(human h1, string name)
        {
            DAl d1=new DAl();
            return d1.edith2(h1,name);
        }
        public bool editp(poshak p1)
        {
            DAl d1=new DAl();
            return d1.editp(p1);
        }
        public bool edits(sport s1)
        {
            DAl d1=new DAl();
            return d1.edits(s1);
        }
        public List<kala> read_kala()
        {
            DAl d1 = new DAl();
            return d1.read_kala();
        }
        public List<poshak> read_poshak()
        {
            DAl d1 = new DAl();
            return d1.read_poshak();
        }
        public List<sport> read_sport()
        {
            DAl d1 = new DAl();
            return d1.read_sport();
        }
        public kala selectk(int idi)
        {
            DAl d1=new DAl();
            return d1.selectk(idi);
        }
        public sport selects(int idi)
        {
            DAl d1=new DAl();
            return d1.selects(idi);
        }
        public poshak selectp(int idi)
        {
            DAl d1=new DAl();
            return d1.selectp(idi);
        }
        public List<human> search_name_id(string name)
        {
            DAl d1 = new DAl();
            return d1.search_name_id(name);
        }
        public List<human> search_name(string name)
        {
            DAl d1 = new DAl();
            return d1.search_name(name);
        }
        public int read_code_kala()
        {
            DAl d1=new DAl();
            return d1.read_code_kala();
        }

    }
}
