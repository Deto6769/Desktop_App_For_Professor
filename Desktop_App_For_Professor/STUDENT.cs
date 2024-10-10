using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//to read sql db


namespace Desktop_App_For_Professor
{
    internal class STUDENT
    {
        MY_DB db = new MY_DB();
        //gxk220025 create function to add a new student to database
        public bool insertStudent(String std_first, String std_last, String std_user, Int64 std_id, String std_email)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO student_info(std_first, std_last, std_username, std_id, std_mail) VALUES (@fn,@ln,@usr,@sid,@smail)", db.getConnection);

            //@fn,@ln,@usr,@sid,@smail
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = std_first;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = std_last;
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = std_user;
            command.Parameters.Add("@sid", MySqlDbType.Int64).Value = std_id;
            command.Parameters.Add("@smail", MySqlDbType.VarChar).Value = std_email;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }


            return true;
        }
    }
}
