////////////////////////////////////////////////////////////////////////////////
//  File:   DB.cs                                                             //
//  Author: Mark Buckner                                                      //
//  Create: April 16, 2017                                                    //
////////////////////////////////////////////////////////////////////////////////
//  Class SQLiteDB                                                            //
//      This class maintains a connection to a SQLite database using the      //
//      Singleton design pattern (ensure there is only one connection to the  //
//      SQLite database file).                                                //
//  Class DatabaseException                                                   //
//      This class manages exceptions thrown from the SQLiteDB class.         //
////////////////////////////////////////////////////////////////////////////////

// =============================================================================
// ===                              Installation                             ===
// =============================================================================
// === 1. Download the DB.cs file.                                           ===
// === 2. In Visual Studio, under the Solution Explorer pane (usually on the ===
// ===    right), right-click on the project --> Add --> Existing Item...,   ===
// ===    navigate to the DB.cs file (alternatively, simply use the CTRL + D ===
// ===    keyboard shortcut).                                                ===
// === 3. From the file menu, click Tools --> NuGet Package Manager -->      ===
// ===    Package Manager Console. From the Package Manager Console pane,    ===
// ===    enter the following command from the PM prompt:                    ===
// ===      PM> Install-Package System.Data.SQLite                           ===
// =============================================================================

// -----------------------------------------------------------------------------
// ---                                 Usage                                 ---
// -----------------------------------------------------------------------------
// --- 1. Define the file path (and name) of the SQLite database file.       ---
// ---      E.g., SQLiteDB.DatabasePath = "c:\database\sql.db";              ---
// ---      E.g., SQLiteDB.DatabasePath = "sql.db";                          ---
// --- 2. Create an object of the SQLiteDB class.                            ---
// ---      E.g., SQLiteDB db = SQLiteDB.GetInstance;                        ---
// --- 3. Use the NonSelectQuery() method for DDL statements (CREATE, DROP,  ---
// ---    ALTER) and non-SELECT DML statements (INSERT, UPDATE, DELETE).     ---
// ---    This method returns the number of rows affected (if any).          ---
// ---      E.g., db.NonSelectQuery("DROP TABLE mytable;");                  ---
// ---      E.g., db.NonSelectQuery("DELETE FROM mytable WHERE id = 100;");  ---
// --- 4. Use the SelectQuery() method for SELECT statements. This method    ---
// ---    returns a dataset object containing a table consisting of the      ---
// ---    selected rows and columns.                                         ---
// ---      E.g., DataSet ds = db.SelectQuery("SELECT * FROM mytable;",      ---
// ---                                        "mytable");                    ---
// --- 5. Use the CloseConnection() method to ensure the database connection ---
// ---    is properly terminated.                                            ---
// -----------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.SQLite;

namespace DB {

    /// <summary>
    /// The SQLiteDB class is used to establish a single connection to a SQLite database file.
    /// </summary>
    public class SQLiteDB {

        private static SQLiteDB m_instance = null;
        private static String m_databasePath = "";

        private bool m_isClosed = true;
        private SQLiteConnection m_SQLiteConnection = new SQLiteConnection();


        /// <summary>
        /// Private no-argument constructor used to establish a connection to the database (and enforces the Singleton pattern).
        /// </summary>
        private SQLiteDB() {
            String connectionString = "Data Source=" + m_databasePath + ";Version=3;";

            try {
                m_SQLiteConnection.ConnectionString = connectionString;
                m_SQLiteConnection.Open();
                m_isClosed = false;
            } catch (SQLiteException ex) {
                throw new DatabaseException(ex.Message);
            } catch (Exception ex) {
                throw new DatabaseException(ex.Message);
            } // END try
        } // END SQLiteDB no-arg constructor


        /// <summary>
        /// Gets or sets the absolute or relative database file path.
        /// <para>Usage: SQLiteDB.DatabasePath = "c:\database\sql.db";</para>
        /// <para>Usage: SQLiteDB.DatabasePath = "sql.db";</para> 
        /// </summary>
        public static string DatabasePath {
            get {
                return m_databasePath;
            } // END get
            set {
                value = value.Trim();

                // If the database path has not been set or an instance of the class has not be instantiated
                if (m_databasePath == "" || m_instance == null) {
                    m_databasePath = value;
                } else {
                    throw new DatabaseException("The database file path cannot be changed once the connection is established.");
                } // END if
            } // End set
        } // END DatabasePath property


        /// <summary>
        /// Returns an instance of the SQLiteDB class.
        /// <para>Usage: SQLiteDB db = SQLiteDB.GetInstance();</para>
        /// </summary>
        public static SQLiteDB GetInstance {
            get {
                // If the database path has not been set
                if (m_databasePath == "") {
                    throw new DatabaseException("The database file path is not set. Set the path before requesting an instance.");
                } else {
                    m_instance = new SQLiteDB();
                } // END if

                return m_instance;
            } // END get
        } // END getInstance property


        /// <summary>
        /// Internal procedure used to ensure a connection to the database is open.
        /// </summary>
        private void OpenConnection() {
            if (m_isClosed == true) {
                m_SQLiteConnection.Open();
                m_isClosed = false;
            } // END if
        } // END OpenConnection() procedure


        /// <summary>
        /// Query the database using a non-SELECT query (e.g., CREATE, DROP, ALTER, INSERT, UPDATE, and DELETE), returning the number of rows affected (if any).
        /// </summary>
        /// <param name="queryString">A complete SQL statement</param>
        /// <returns>Number of rows affected (if any)</returns>
        public int NonSelectQuery(String queryString) {
            Console.WriteLine(queryString);

            try {
                this.OpenConnection();
                
                SQLiteCommand dbCommand = new SQLiteCommand(queryString, m_SQLiteConnection);

                return dbCommand.ExecuteNonQuery();
            } catch (SQLiteException ex) {
                throw new DatabaseException(ex.Message);
            } catch (Exception ex) {
                throw new DatabaseException(ex.Message);
            } // END try
        } // END NonSelectQuery() function


        /// <summary>
        /// Query the database using a SELECT query, returning a dataset containing the results of the SELECT query.
        /// </summary>
        /// <param name="queryString">A complete SQL SELECT statement</param>
        /// <param name="resultSetTableName">The name used to reference the result set table</param>
        /// <returns>A dataset containing the results of the SELECT query</returns>
        public DataSet SelectQuery(String queryString, String resultSetTableName) {
            DataSet ds = null;

            try {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();

                this.CloseConnection();

                adapter.SelectCommand = new SQLiteCommand(queryString, m_SQLiteConnection);
                ds = new DataSet();
                adapter.Fill(ds, resultSetTableName);
            } catch (SQLiteException ex) {
                throw new DatabaseException(ex.Message);
            } catch (ArgumentException ex) {
                throw new DatabaseException(ex.Message);
            } catch (Exception ex) {
                throw new DatabaseException(ex.Message);
            } // END try

            return ds;
        } // END SelectQuery() function


        /// <summary>
        /// Closes the database connection.
        /// </summary>
        public void CloseConnection() {
            m_SQLiteConnection.Close();
            m_isClosed = true;
        } // END CloseConnection() procedure

    } // END SQLiteDB class

    
    /// <summary>
    /// Custom exception class for the SQLiteDB class.
    /// </summary>
    public class DatabaseException : Exception {
        public DatabaseException(String message) : base(message) { }
    } // END DatabaseException class

} // END DB namespace