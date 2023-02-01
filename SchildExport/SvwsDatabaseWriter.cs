using LinqToDB;
using LinqToDB.Data;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public class SvwsDatabaseWriter : ISvwsDatabaseWriter
    {
        public void Configure(string host, int port, string database, string username, string password, bool enableTrace)
        {
            if (enableTrace)
            {
                DataConnection.TurnTraceSwitchOn();
                DataConnection.WriteTraceLine = (message, displayName, level) => { Console.WriteLine($"{message} {displayName}"); };
            }

            DataConnection.DefaultSettings = new DatabaseSettings(host, port, database, username, password);
        }

        public async Task InsertOrUpdateLernplattformAsync(Lernplattform lernplattform)
        {
            using var connection = new SvwsConnection();

            if (lernplattform.Id != default)
            {
                await connection.UpdateAsync(lernplattform);
            }
            else
            {
                await connection.InsertAsync(lernplattform);
                lernplattform.Id = await connection.SvwsAutoIncrements.Where(x => x.Tabelle == Lernplattform.TableName).Select(x => x.MaxId).FirstOrDefaultAsync();
            }
        }

        public async Task InsertOrUpdateLernplattformZustimmungenBulkAsync(IEnumerable<KindLernplattform> zustimmungen)
        {
            using var connection = new SvwsConnection();

            try
            {
                await connection.BeginTransactionAsync();

                foreach (var zustimmung in zustimmungen)
                {
                    if (zustimmung.Zugangsdaten != null)
                    {
                        var zugangsdaten = zustimmung.Zugangsdaten;

                        if (zugangsdaten.Id == default)
                        {
                            await connection.InsertAsync(zugangsdaten);
                            zugangsdaten.Id = await connection.SvwsAutoIncrements.Where(x => x.Tabelle == LernplattformZugangsdaten.TableName).Select(x => x.MaxId).FirstOrDefaultAsync();

                            zustimmung.ZugangsdatenId = zugangsdaten.Id;
                        }
                        else
                        {
                            await connection.UpdateAsync(zugangsdaten);
                        }
                    }

                    await connection.InsertOrReplaceAsync(zustimmung);
                }

                await connection.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await connection.RollbackTransactionAsync();
                throw ex;
            }
        }
    }
}