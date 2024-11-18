﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbConnection
{
	public class SqlDataAccess
	{
		private readonly string _connectionString;

		public SqlDataAccess()
		{
			_connectionString = "Data Source=DESKTOP-J4U66GV\\SQLEXPRESS;Initial Catalog=StudentAdministratorDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
		}

		public SqlConnection GetConnection()
		{
			return new SqlConnection(_connectionString);
		}
	}
}
