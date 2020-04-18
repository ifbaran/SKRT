using BusinessLogicLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace BusinessLogicLayer
{
    public class RoomModule
        //:BaseClass<Room>
    {
        //DataAccessLayer.DAL dal;
        //public RoomModule()
        //{
        //    dal = new DataAccessLayer.DAL();
        //}
        //public int Insert(Room room)
        //{
        //    cmd = new SqlCommand("INSERT INTO Room Values(@RoomName,@RoomCapacity)");
        //    cmd.Parameters.Add("@RoomName", SqlDbType.NVarChar).Value = room.Name;
        //    cmd.Parameters.Add("@RoomCapacity", SqlDbType.Int).Value = room.Capacity;
        //    result = dal.AddDeleteEdit(cmd);
        //    return result;
        //}

        //public int Update(Room room)
        //{
        //    cmd = new SqlCommand("Update Room Set (@RoomName,@RoomCapacity)");
        //    cmd.Parameters.Add("@RoomName", SqlDbType.NVarChar).Value = room.Name;
        //    cmd.Parameters.Add("@RoomCapacity", SqlDbType.Int).Value = room.Capacity;
        //    result = dal.AddDeleteEdit(cmd);
        //    return result;
        //}

        //public int Delete(int id)
        //{
        //    cmd = new SqlCommand("Delete from Room where RoomID = @id");
        //    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        //    result = dal.AddDeleteEdit(cmd);
        //    return result;
        //}
        //public DataTable GetRoom()
        //{
        //    string query = "Select * from Room";
        //    DataTable rooms = dal.ShowDataInGridView(query);
        //    return rooms;
        //}
    }
}
