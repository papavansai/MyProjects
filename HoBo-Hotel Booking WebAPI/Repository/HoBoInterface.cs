using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoBoWebApi.Models;

namespace HoBoWebApi.Repository
{
    public interface HoBoInterface
    {
       List<HoBoM> getAllDetails();
        string insertIntoTable(HoBoM m);
        string editTable(HoBoM m);
        string deleteFromTable(int id);

    }
    public class HoboClass : HoBoInterface
    {
        HoBoDbEntities db = new HoBoDbEntities();

        string HoBoInterface.deleteFromTable(int id)
        {
            var abc = db.Admin_Dashboard.Where(f => f.S_No==id).FirstOrDefault();
            if (abc != null)
            {

                db.Admin_Dashboard.Remove(abc);
                db.SaveChanges();
                return "deleted";

            }
            else { return "not deleted"; }
        }

        string HoBoInterface.editTable(HoBoM m)
        {
            var edit = db.Admin_Dashboard.Where(f => f.S_No == m.S_No).FirstOrDefault();
            if(edit != null)
            {
                edit.Hotel = m.Hotel;
                edit.Price = m.Price;
                edit.Guests = m.Guests;
            }
            db.SaveChanges();
            db.Dispose();
            return "Updated";
        }

        List<HoBoM> HoBoInterface.getAllDetails()
        {
            List<HoBoM> getDetails = db.Admin_Dashboard.Select(s => new HoBoM()
            {
                S_No = s.S_No,
                Hotel = s.Hotel,
                Arrival = s.Arrival,
                Departure = s.Departure,
                Type = s.Type,
                Guests = s.Guests,
                Price = s.Price
            }).ToList<HoBoM>();
            db.Dispose();
            return getDetails;
        }

        string HoBoInterface.insertIntoTable(HoBoM m)
        {
            var insert = db.Admin_Dashboard.Where(s => s.S_No == m.S_No).FirstOrDefault();
            if (insert == null)
            {
                db.Admin_Dashboard.Add(new Admin_Dashboard
                {
                    S_No = m.S_No,
                    Hotel = m.Hotel,
                    Arrival = m.Arrival,
                    Departure = m.Departure,
                    Type = m.Type,
                    Guests = m.Guests,
                    Price = m.Price
                });
     
                //append.teamsize++;
                db.SaveChanges();
                db.Dispose();
                return "Insertion completed!";
            }
            else
            {
                insert.Hotel = m.Hotel;
                insert.Arrival = m.Arrival;
                insert.Departure = m.Departure;
                insert.Type = m.Type;
                insert.Price = m.Price;
                insert.Guests = m.Guests;
                db.SaveChanges();
                db.Dispose();
                return "Edit Completed";
            }
        }
    }
}
