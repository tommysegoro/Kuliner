using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kuliner.Core.Repositories
{
    public class DataContext : IDisposable
    {
        public DataContext(string connectionString)
        {
            //this.dataContext = new TinsCookingDataContext(connectionString);
            this.dataContext = new KulinerEntities();
            this.entities = new List<IEntity>();
        }

        #region "Class Variables"
        private KulinerEntities dataContext;
        private List<IEntity> entities;
        private bool _disposed;
        #endregion

        #region "Properties"
        public KulinerEntities Entities
        {
            get { return this.dataContext; }
        }
        #endregion

        #region "Methods"

        public void SubmitChanges()
        {
            foreach (IEntity entity in this.entities)
            {
                if (String.IsNullOrEmpty(entity.OldRowVersion.ToString()))
                    throw new OldRowVersionEmptyException();

                if (entity.OldRowVersion != entity.NewRowVersion)
                    throw new ConcurrencyControlException();
                else
                    entity.NewRowVersion += 1;
            }

            this.dataContext.SaveChanges();
        }

        public void UpdateOnSubmit(IEntity entity)
        {
            this.entities.Add(entity);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);


        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                //db.Dispose();
                this.dataContext.Dispose();
            }

            _disposed = true;
        }

        #endregion
    }
}
