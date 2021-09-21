using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosFontes
{
    class ClientesDataBase
    {
        public string Cadastrar(Clientes cliente)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\DataBaseForm.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand command = new SqlCommand();
                command.CommandText =
                                 @"INSERT INTO CLIENTES (NOME, CPF, EMAIL, DATA_DE_NASCIMENTO, ESTADO_CIVIL, GENERO, TELEFONE_CELULAR, RUA, NUMERO, BAIRRO, CEP, COMPLEMENTO, CIDADE, UF) VALUES
                                  (@NOME, @CPF, @EMAIL, @DATA_DE_NASCIMENTO, @ESTADO_CIVIL, @GENERO, @TELEFONE_CELULAR, @RUA, @NUMERO, @BAIRRO, @CEP, @COMPLEMENTO, @CIDADE, @UF);
                                  select scope_identity()";

                command.Parameters.AddWithValue("@NOME", cliente.Nome);
                command.Parameters.AddWithValue("@CPF", cliente.CPF);
                command.Parameters.AddWithValue("@EMAIL", cliente.Email);
                command.Parameters.AddWithValue("@DATA_DE_NASCIMENTO", cliente.DataDeNascimento);
                command.Parameters.AddWithValue("@ESTADO_CIVIL", cliente.EstadoCivil);
                command.Parameters.AddWithValue("@GENERO", cliente.Genero);
                command.Parameters.AddWithValue("@TELEFONE_CELULAR", cliente.TelefoneCelular);
                command.Parameters.AddWithValue("@RUA", cliente.Rua);
                command.Parameters.AddWithValue("@NUMERO", cliente.Numero);
                command.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
                command.Parameters.AddWithValue("@CEP", cliente.CEP);
                command.Parameters.AddWithValue("@COMPLEMENTO", cliente.Complemento);
                command.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
                command.Parameters.AddWithValue("@UF", cliente.UF);
                command.Connection = connection;
                try
                {
                    connection.Open();
                    int idGerado = Convert.ToInt32(command.ExecuteScalar());
                    return "Cadastro efetuado com sucesso!";
                }
                catch (Exception ex)
                {
                    return "(Erro) - Não foi possível efetuar o cadastro";
                }
            }
        }

        public string Editar(Clientes cliente)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\DataBaseForm.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand command = new SqlCommand();
                command.CommandText =
                                 @"UPDATE CLIENTES SET NOME = @NOME, EMAIL = @EMAIL, ESTADO_CIVIL = @ESTADO_CIVIL, TELEFONE_CELULAR = @TELEFONE_CELULAR, RUA = @RUA, 
                                 NUMERO = @NUMERO, BAIRRO = @BAIRRO, CEP = @CEP, COMPLEMENTO = @COMPLEMENTO, CIDADE = @CIDADE, UF = @UF
                                    
                                 WHERE ID = @ID";

                command.Parameters.AddWithValue("@NOME", cliente.Nome);
                command.Parameters.AddWithValue("@EMAIL", cliente.Email);
                command.Parameters.AddWithValue("@ESTADO_CIVIL", cliente.EstadoCivil);
                command.Parameters.AddWithValue("@TELEFONE", cliente.TelefoneCelular);
                command.Parameters.AddWithValue("@RUA", cliente.Rua);
                command.Parameters.AddWithValue("@NUMERO", cliente.Numero);
                command.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
                command.Parameters.AddWithValue("@CEP", cliente.CEP);
                command.Parameters.AddWithValue("@COMPLEMENTO", cliente.Complemento);
                command.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
                command.Parameters.AddWithValue("@UF", cliente.UF);
                command.Parameters.AddWithValue("@ID", cliente.ID);
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Alteração efetuada com sucesso!";
                }
                catch (Exception ex)
                {
                    return "(Erro) - Não foi possível efetuar a alteração";
                }
            }
        }

        //A exclusão do cliente só pode ser efetuada caso não tenha nenhuma venda para o cliente! 
        public string Excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection())
            { 
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\DataBaseForm.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand command = new SqlCommand();
                command.CommandText =
                                 @"DELETE FROM CLIENTES WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                command.Connection = connection;
                try
                {
                    connection.Open();
                    int clientesExcluidos = command.ExecuteNonQuery();
                    if (clientesExcluidos == 1)
                    {
                        return "Excluido com sucesso.";
                    }
                    else
                    {
                        return "Não foi possível excluir";
                    }
                }
                catch (Exception ex)
                {
                    return "Erro!";
                }
            }          
        }

        public List<Clientes> ReadClientes()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sérgio\Documents\DataBaseForm.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand command = new SqlCommand();
                command.CommandText =
                    @"SELECT * FROM CLIENTES";
                command.Connection = connection;
                try
                {
                    List<Clientes> clientes = new List<Clientes>();
                    connection.Open();
                    SqlDataReader rdr = (command.ExecuteReader());
                    //Ler enquanto houver registros.
                    while (rdr.Read())
                    {
                        Clientes cliente = new Clientes();
                        cliente.ID = (int)rdr["ID"];
                        cliente.Nome = (string)rdr["NOME"];
                        cliente.CPF = (string)rdr["CPF"];
                        cliente.Email = (string)rdr["EMAIL"];
                        cliente.DataDeNascimento = (DateTime)rdr["DATA_DE_NASCIMENTO"];
                        cliente.EstadoCivil = (string)rdr["ESTADO_CIVIL"];
                        cliente.Genero = (string)rdr["GENERO"];
                        cliente.TelefoneCelular = (string)rdr["TELEFONE_CELULAR"];
                        cliente.Rua = (string)rdr["RUA"];
                        cliente.Numero = (string)rdr["NUMERO"];
                        cliente.Bairro = (string)rdr["BAIRRO"];
                        cliente.CEP = (string)rdr["CEP"];
                        cliente.Complemento = (string)rdr["COMPLEMENTO"];
                        cliente.Cidade = (string)rdr["Cidade"];
                        cliente.UF = (string)rdr["UF"];
                        clientes.Add(cliente);
                    }
                    return clientes; 
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
