using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasyFeedback.Models;

namespace TasyFeedback.Controllers
{
    public class ErrorController
    {
        public bool Delete(Error o)
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
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }

        public bool Delete(int Id)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    var temp = db.Error.FirstOrDefault(x => x.ErrorId == Id);
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
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }

        public bool InsertOne(Error o)
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
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }

        public bool InsertRange(List<Error> lista)
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
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }

        public List<Error> SelectAll()
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Error.ToList();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return null;
        }

        public List<Error> SelectMany(int cantidad)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Error.Take(cantidad).ToList();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return null;
        }

        public Error SelectOne(int Id)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Error.FirstOrDefault(x => x.ErrorId == Id);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return null;
        }

        public List<Error> SelectOneOverList(int Id)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Error.Where(x => x.ErrorId == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return null;
        }

        public bool Update(Error o)
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
                System.Windows.Forms.MessageBox.Show("Error en" + "@" + GetType().Name + "\n" + ex.ToString());
            }
            return false;
        }
        public List<Error> FiltrarVsDescrip(string SearchText)
        {
            try
            {
                using (var db = new TasyFbContext())
                {
                    return db.Error
                        .Where(x => x.Descripcion.Contains(SearchText.Trim())).Take(50).ToList();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en ErrorController: " + ex.ToString());
            }

            return null;
        }

    }
}
