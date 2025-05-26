using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_AppDev
{
    class StringProcessing : AbstractStringProcessing
    {
        private string s;
        private int n;
        public string encodeResult = "";
        public int[] outputCodeResult = new int[0];
        public int[] inputCodeResult = new int[0];
        private Dictionary<char, int> ascii_dict = new Dictionary<char, int>{};
        public List<char> ascii_list = new List<char>{};
        public override string S
        {
            set
            {
                if (value.Length > 40 || value.Length < 1 || value != value.ToUpper() || !value.All(char.IsLetter))
                {
                    throw new Exception("String S's length must be from 1 to 40 and must be capital letters only");
                }
                else
                {
                    s = value;
                }
            }
            get
            {
                return s;
            }
        }

        public override int N
        {
            set
            {
                if (Convert.ToString(value).Any(char.IsLetter) || value < -25 || value > 25)
                {
                    throw new Exception("N must be from -25 to 25");
                }
                else
                {
                    n = value;
                }
            }
            get
            {
                return n;
            }
        }

        public StringProcessing(string S, int N)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\CourseworkAppDevWinForms\CourseworkAppDevWinForms\AsciiCode.mdf;Integrated Security=True");
            conn.Open();
            string query = "SELECT * FROM ascii_code";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                ascii_dict.Add(Convert.ToChar(row["char"]), Convert.ToInt16(row["number"]));
                ascii_list.Add(Convert.ToChar(row["char"]));
            }
            conn.Close();
            this.S = S;
            this.N = N;
        }

        public override void Encode()
        {
            List<char> sliced_ascii;
            if (n < 0)
            {
                n += ascii_list.Count;
            }
            sliced_ascii = ascii_list.GetRange(n, ascii_list.Count - n);
            sliced_ascii.AddRange(ascii_list.GetRange(0, n));
            foreach (char c in s)
            {
                for (int i = 0; i < sliced_ascii.Count; i++)
                {
                    if (c == ascii_list[i])
                    {
                        encodeResult += sliced_ascii[i];
                        break;
                    }
                }
            }

        }

        public override string Print()
        {
            return encodeResult;
        }

        public override string InputCode()
        {
            Array.Resize(ref inputCodeResult, s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                inputCodeResult[i] = ascii_dict[s[i]];
            }
            return string.Join(", ",inputCodeResult);
        }

        public override string OutputCode()
        {
            Array.Resize(ref outputCodeResult, encodeResult.Length);
            for (int i = 0; i < encodeResult.Length; i++)
            {
                outputCodeResult[i] = ascii_dict[encodeResult[i]];
            }
            return string.Join(", ", outputCodeResult);
        }

        public override string Sort()
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}
