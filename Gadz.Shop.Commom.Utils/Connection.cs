using System;
using System.Data.SqlClient;

namespace Gadz.Shop.Commom.Utils {
    public class Connection
    {
        string _connectionString = string.Empty;
        string _server = "";
        string _database = "";
        string _uid = "";
        string _pwd = "";
        bool _trusted = false;

        SqlConnection _conn;
        public SqlDataReader rec;

        public string Sql { get; set; }

        public string ConnectionString{

            get { return _connectionString; }
            set {

                string[] _itens;

                _connectionString = value.ToLower(); 
                
                _itens = ConnectionString.Split(';');

                foreach(string _iten in _itens){
                    if (_iten.StartsWith("data source")) {
                        this.Servidor = _iten.Substring(12, _iten.Length - 12);
                        continue;
                    }

                    if (_iten.StartsWith("initial catalog")) {
                        this.BancoDeDados = _iten.Substring(16, _iten.Length - 16);
                        continue;
                    }

                    if (_iten.StartsWith("user id")) {
                        this.Usuario = _iten.Substring(8, _iten.Length - 8);
                        continue;
                    }

                    if (_iten.StartsWith("password")) {
                        this.Senha = _iten.Substring(9, _iten.Length - 9);
                        continue;
                    }
                }
            }
        }

        public string Servidor{

            get {return _server;}
            set 
            {
                _server = value.ToString();
            }
        }

        public string BancoDeDados{
            get { return _database; }
            set{
                _database = value.ToString();
            }
        }

        public string Usuario { 
            get { return _uid; } 
            set 
            {
                _uid = value.ToString();
                _connectionString = String.Format("Server={0};Database={1};User Id={2};Password={3};",_server,_database,_uid,_pwd);
            }
        }

        public string Senha { 
            get { return _pwd; } 
            set { 
                _pwd = value.ToString();
                _connectionString = String.Format("data source={0};initial catalog={1};user id={2};password={3};", _server, _database, _uid, _pwd).ToLower();
            } 
        }

        public bool trusted{
            get { return _trusted; }
            set {
                _trusted = value;
            }
        }

        public bool Abrir(){

            _conn = new SqlConnection(ConnectionString);

            try{
                _conn.Open();
                return true;
            }catch(SqlException e){
               // MessageBox.Show(null, "Falha ao conectar-se com o banco de dados.\n\n" + e.Message , Program.Name, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Abrir(string connectionstring){
            ConnectionString = connectionstring;
            return this.Abrir();
        }

        public bool Fechar(){
            try {
                if (_conn != null)
                    _conn.Close();

                _conn.Dispose();

                return true;
            }
            catch {
                return false;
            }
            finally {
            }
        }

        public SqlConnection connection{
            get { return _conn; }
        }

        public SqlDataReader ExecuteReader(string sql){

            SqlCommand cmd;

            this.Sql = sql;

            cmd = new SqlCommand(sql, this.connection);

            try {
                return cmd.ExecuteReader();
            }
            catch {
                return null;
            }
            finally {
                cmd.Dispose();
            }
        }

        public bool ExecuteNonQuery(string sql){

            SqlCommand cmd;

            this.Sql = sql;

            cmd = new SqlCommand(sql, this.connection);

            try {
                cmd.ExecuteNonQuery();
                return true;
            } catch {
                return false;
            } finally {
                cmd.Dispose();
            }
        }
    }
}