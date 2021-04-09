﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace MedicalMonitoring
{
	public class Database
	{
		//private static String scon = @"datasource=localhost;port=3306;username=root;password=admin;database=iothealthdatabase";
		private static String scon = @"datasource=localhost;port=3306;username=root;password=root;database=health";

		public static MySqlConnection Connection
		{
			get
			{
				MySqlConnection connection = new MySqlConnection(scon);
				connection.Open();
				return connection;
			}
		}

		public static DataTable GetDataTable(MySqlCommand command)
		{
			using (MySqlDataAdapter a = new MySqlDataAdapter())
			{
				a.SelectCommand = command;
				DataTable table = new DataTable();
				a.Fill(table);
				return table;
			}
		}

		public static Object[] CheckDoctorLogin(String username, String password)
		{
			using (var con = Connection)
			{
				using(var cmd=con.CreateCommand())
				{
					cmd.CommandText = "select doctorid, name from doctor where username=@username and passwordhash=password(@password)";
					cmd.Parameters.AddWithValue("@username", username);
					cmd.Parameters.AddWithValue("@password", password);

					DataTable table = GetDataTable(cmd);
					if (table.Rows.Count == 0) return null;

					int? doctorid = table.Rows[0]["doctorid"] as int?;
					String name = table.Rows[0]["name"] as String;

					return new object[] { doctorid, name };
				}
			}
		}

		public static Object[] CheckPatientLogin(String username, String password)
		{
			using (var con = Connection)
			{
				using (var cmd = con.CreateCommand())
				{
					cmd.CommandText = "select patientid, name from patient where username=@username and passwordhash=password(@password)";
					cmd.Parameters.AddWithValue("@username", username);
					cmd.Parameters.AddWithValue("@password", password);

					DataTable table = GetDataTable(cmd);
					if (table.Rows.Count == 0) return null;

					int? patientid = table.Rows[0]["patientid"] as int?;
					String name = table.Rows[0]["name"] as String;

					String token = GenerateToken();
					cmd.CommandText = "update patient set token=@token where patientid=@patientid";
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@token", token);
					cmd.Parameters.AddWithValue("@patientid", patientid);
					cmd.ExecuteNonQuery();

					return new object[] { patientid, name, token };
				}
			}
		}

		public static String GenerateToken()
		{
			Random random = new Random();
			StringBuilder sb=new StringBuilder();
			for(int i=0;i<10;i++)
			{
				int type = random.Next(3);
				switch(type)
				{
					case 0:
						sb.Append((char)random.Next(48, 58)); break;
					case 1:
						sb.Append((char)random.Next(65, 91)); break;
					case 2:
						sb.Append((char)random.Next(97, 123)); break;
				}
			}
			return sb.ToString();
		}
	}
}