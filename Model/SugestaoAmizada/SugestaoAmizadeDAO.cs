using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Login_Register.Model.SugestaoAmizada;
using MySql.Data.MySqlClient;

public class SugestaoAmizadeDAO
{
    private DatabaseService dbService;

    public SugestaoAmizadeDAO(DatabaseService dbService)
    {
        this.dbService = dbService;
    }
    public List<string> ObterNomesSugestoes(int idUsuarioOrigem)
    {
        List<string> nomes = new List<string>();
        using (MySqlConnection conn = dbService.GetConnection())
        {
            conn.Open();
            string query = @"SELECT u.nome 
                         FROM sugestoes_amizade sa
                         JOIN usuarios u ON sa.id_usuario_destino = u.id
                         WHERE sa.id_usuario_origem = @idOrigem";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idOrigem", idUsuarioOrigem);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nomes.Add(reader.GetString(0));
                    }
                }
            }
        }
        return nomes;
    }


}

