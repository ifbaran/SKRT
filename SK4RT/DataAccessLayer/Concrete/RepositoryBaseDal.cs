using System; // KEY DÜŞ KEY DÜŞ KEY DÜŞ
using DataAccessLayer.Abstract;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entities.Abstract;
using DataAccessLayer.Context;

namespace DataAccessLayer.Concrete
{
    public class RepositoryBaseDal<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using (SK4RTContext context = new SK4RTContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (SK4RTContext context = new SK4RTContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (SK4RTContext context = new SK4RTContext() )
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (SK4RTContext context = new SK4RTContext() )
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetOne()
        {
            throw new NotImplementedException();
        }

        

        //private readonly SqlConnection _connection;
        //private readonly string connectionString = "Data Source = .; initial catalog = SK4RT; Integrated Security = true";
        //private int _returnInt;
        //public RepositoryBaseDal()
        //{
        //    _connection = new SqlConnection(connectionString);
        //}

        //private void GetConnectionStatus()
        //{
        //    if (_connection.State == ConnectionState.Closed)
        //        _connection.Open();
        //    else _connection.Close();
        //}

        //public int AddDeleteUpdate(string query)
        //{
        //    using (SqlCommand command = new SqlCommand(query, _connection))
        //    {
        //        GetConnectionStatus();
        //        command.CommandText = query;
        //        command.CommandType = CommandType.Text;
        //        _returnInt = command.ExecuteNonQuery();
        //        GetConnectionStatus();
        //        return _returnInt;
        //    }
        //}

        //public DataTable GetAll(string query)
        //{
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _connection);
        //    DataSet dataSet = new DataSet();
        //    dataAdapter.Fill(dataSet);
        //    DataTable dataTable = dataSet.Tables[0];
        //    GetConnectionStatus();
        //    return dataTable;
        //}

        //public TEntity GetOne(string query)
        //{
        //    throw new System.NotImplementedException();
        //}

    }
}