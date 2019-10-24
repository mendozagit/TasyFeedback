using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasyFeedback.Models;

namespace TasyFeedback.Controllers
{
    public class ConfiguracionController
    {
        public bool Delete(Configuracion o)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    db.Entry(o).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }

        public bool Delete(int Id)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    var temp = db.Configuracion.FirstOrDefault(x => x.ConfiguracionId == Id);
                    if (temp != null)
                    {
                        db.Remove(temp);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }

        public bool InsertOne(Configuracion o)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    db.Add(o);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }

        public bool InsertRange(List<Configuracion> lista)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    db.AddRange(lista);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }

        public List<Configuracion> SelectAll()
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Configuracion.ToList();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return null;
        }

        public List<Configuracion> SelectMany(int cantidad)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Configuracion.Take(cantidad).ToList();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return null;
        }

        public Configuracion SelectOne(int Id)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Configuracion.FirstOrDefault(x => x.ConfiguracionId == Id);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return null;
        }

        public List<Configuracion> SelectOneOverList(int Id)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Configuracion.Where(x => x.ConfiguracionId == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return null;
        }

        public bool Update(Configuracion o)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    db.Entry(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Configuracion en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }
    }
}
