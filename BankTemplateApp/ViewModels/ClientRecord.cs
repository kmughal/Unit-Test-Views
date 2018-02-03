using System.Collections;
using System.Collections.Generic;
using System.Web.UI;

namespace BankTemplateApp.ViewModels
{
    public class ClientRecord
    {
        public string FullName { get; }

        public string Address { get; }


        private ClientRecord(string fullname, string address)
        {
            FullName = fullname;
            Address = address;
        }

        public static ClientRecord CreateNewRecord(string fullName, string address) =>
        new ClientRecord(fullName, address);
    }


    public class ClientRecords
    {
        public IEnumerable<ClientRecord> Records { get; }

        private ClientRecords(IEnumerable<ClientRecord> records)
        {
            Records = records;
        }
        public static ClientRecords CreateRecords(IEnumerable<ClientRecord> records) =>
        new ClientRecords(records);

    }
}