using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvPrograms
{
    class SqlPartController
    {
        public readonly string connectionString = "Server=.;Database=TVProgramController; Integrated Security=true;";
        public DataTable LogInUser(string userName, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select UserName,UserPassword from Users where UserName='{userName}' and UserPassword='{password}'";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
        }


        public void SignUp(string username, string usersurname, string email, int age, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"insert into Users(UserName,UserSurname,EMail,Age,UserPassword) values ('{username}','{usersurname}','{email}',{age},'{password}')";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetChannels()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from Channels";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
        }

        public void DeleteChannel(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"delete from Channels where ChannelId={id}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public Channel GetChannelForUpdate(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select * from Channels where ChannelId={id}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Channel channel = new Channel();

                    channel.ChannelId = (int)reader["ChannelId"];
                    channel.ChannelName = reader["ChannelName"].ToString();
                    return channel;
                }
                return null;
            }
        }

        public void InsertChannel(string channelName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"insert into Channels values ('{channelName}')";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void UpdateChannel(int id, string channelName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"update Channels set ChannelName='{channelName}' where ChannelId={id}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        // PROGRAMS PART

        public DataTable GetPrograms()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from Programs";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetByChannelId(int channelId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select p.ProgramId,p.ProgramName,p.StartedAt,p.FinishedAt,p.ChannelId from Programs p, Channels c where p.ChannelId={channelId} and p.ChannelId=c.ChannelId";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
        }

        public void DeleteProgram(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"delete from Programs where ProgramId={id}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public TVPrograms GetProgramForUpdate(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select * from Programs where ProgramId={id}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TVPrograms pr = new TVPrograms();
                    pr.ProgramId = (int)reader["ProgramId"];
                    pr.ProgramName = reader["ProgramName"].ToString();
                    pr.StartedAt = (TimeSpan)reader["StartedAt"];
                    pr.FinishedAt = (TimeSpan)reader["FinishedAt"];
                    pr.ChannelId = (int)reader["ChannelId"];
                    return pr;
                }
                return null;
            }
        }

        public void InsertTVProgram(string programName, TimeSpan startedAt, TimeSpan finishedAt, int channelId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"insert into Programs values ('{programName}','{startedAt}','{finishedAt}',{channelId})";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void UpdateTVProgram(int programId, string programName, TimeSpan startedAt, TimeSpan finishedAt, int channelId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"update Programs set ProgramName='{programName}',StartedAt='{startedAt}',FinishedAt='{finishedAt}',ChannelId={channelId} where ProgramId={programId}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        //HOSTES

        
        public DataTable GetHostes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from Host";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetHostesSurname()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select HostId,HostSurname from Host";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
        }

       
        public string GetHostPicture(int hostid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select HostPicture from Host where HostId={hostid}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Host host = new Host();

                    host.HostPicture = reader["HostPicture"].ToString();
                    return host.HostPicture;

                }
                return null;
            }
        }



        public void DeleteHost(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"delete from Host where HostId={id}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void InsertHost(string hostname,string hostsurname,int age, string pictureDirectory)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"insert into Host values ('{hostname}','{hostsurname}',{age},'{pictureDirectory}')";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public void UpdateHost(int hostId, string hostName,string hostSurname,int age,string pictureDirectory)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"update Host set HostName='{hostName}',HostSurname='{hostSurname}',HostAge={age},HostPicture='{pictureDirectory}' where HostId={hostId}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public Host GetByHostId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select * from Host where HostId={id}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Host host = new Host();
                    host.HostId = (int)reader["HostId"];
                    host.HostName = reader["HostName"].ToString();
                    host.HostSurname = reader["HostSurname"].ToString();
                    host.HostAge = (int)reader["HostAge"];
                    host.HostPicture = reader["HostPicture"].ToString();
                    return host;
                }
                return null;
            }
        }

        //HostProgram

        public DataTable GetHostProgram()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select hp.HostId,hp.ProgramId, h.HostName , p.ProgramName from Host h," +
                    $" Programs p,HostProgram hp where h.HostId=hp.HostId and p.ProgramId = hp.ProgramId";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
        }

        public void DeleteHostProgram(int hostid, int programid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"delete from HostProgram where HostId={hostid} and ProgramId={programid}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public HostTVProgram GetByHostIdProgramId(int hostid, int programid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select hp.HostId,hp.ProgramId, h.HostName , p.ProgramName from Host h, Programs p,HostProgram hp where h.HostId=hp.HostId and p.ProgramId = hp.ProgramId and hp.HostId ={hostid}  and hp.ProgramId = {programid}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    HostTVProgram hostpr = new HostTVProgram();
                    hostpr.HostId = (int)reader["HostId"];
                    hostpr.ProgramId = (int)reader["ProgramId"];
                    hostpr.HostName = reader["HostName"].ToString();
                    hostpr.ProgramName = reader["ProgramName"].ToString();

                    return hostpr;
                }
                return null;
            }
        }


        public void UpdateHostProgram(int selectedhostid, int selectedprogramid, int newhostid, int newprogramid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"update HostProgram set HostId={newhostid},ProgramId={newprogramid} where HostId={selectedhostid} and ProgramId={selectedprogramid}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public void InsertHostProgram(int hostid, int programid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"insert into HostProgram values ({hostid},{programid})";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public DataTable GetByDoubleClickChannel(int channelid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select c.ChannelId,c.ChannelName, p.ProgramName,p.StartedAt,p.FinishedAt, h.HostName, h.HostSurname from Channels c, Programs p, Host h, HostProgram hp where c.ChannelId = p.ChannelId and h.HostId = hp.HostId and p.ProgramId = hp.ProgramId and c.ChannelId ={channelid}";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
        }
        public void DeleteHostProgramIfProgramDelete(int programid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"delete from HostProgram where ProgramId={programid}";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
