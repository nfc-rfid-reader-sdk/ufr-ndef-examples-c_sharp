using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uFCoderMulti;

// Select URI Abbreviation

namespace uFR_NDEF_example
{
    public partial class frmTestNDEF : Form
    {
        string msg; // global message variable

        // print message
        private void prn()
        {
            dbgInfo.AppendText(msg);
            dbgInfo.AppendText(Environment.NewLine);
        }

        private void prn_st(string f, DL_STATUS status)
        {
            msg = f + " : " + status;
            prn();
        }

        public frmTestNDEF()
        {
            InitializeComponent();

            ComboBox1.SelectedIndex = 1;
        }

        private void bOpenReader_Click(object sender, EventArgs e)
        {
            DL_STATUS status;

            status = uFCoder.ReaderOpen();

            if (status == DL_STATUS.UFR_OK)
            {
                msg = "Reader connected";
            }
            else
            {
                msg = "Reader did not connect";
            }

            labelOpenStatus.Text = msg;

            prn();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // EditUriText.Text = ComboBox1.Text;
        }

        private byte[] SubByteArray(byte[] sourceArray, int out_len)
        {
            byte[] truncArray = new byte[out_len];
            Array.Copy(sourceArray, truncArray, truncArray.Length);
            return truncArray;
        }

        private void bRdNDEF_Click(object sender, EventArgs e)
        {
            //ndef_record_struct ndef_record;
            //unsigned char record_data[1000];
            int record_nr;
            DL_STATUS result = DL_STATUS.UNKNOWN_ERROR;

            //byte tlv_type;
            //uint record_length;
            //ushort bytes_read;

            byte[] type = new byte[256];
            byte[] id = new byte[256];
            byte[] payload = new byte[1000];

            byte type_length, id_length, tnf;
            uint payload_length;

            record_nr = Convert.ToInt32(EditRecordNr.Text);

            unsafe
            {
                fixed (byte* f_type = type)
                fixed (byte* f_id = id)
                fixed (byte* f_payload = payload)

                    result = uFCoder.read_ndef_record(1, (byte)record_nr, &tnf, f_type, &type_length, f_id, &id_length, f_payload, &payload_length);
            }

            prn_st("read_ndef_record", result);

            switch (result)
            {
                case DL_STATUS.UFR_OK:

                    string str_payload = System.Text.Encoding.UTF8.GetString(SubByteArray(payload, (int)payload_length));
                    EditUriText.Text = str_payload;

                    string str_type = System.Text.Encoding.UTF8.GetString(SubByteArray(type, (int)type_length));
                    LabelRecordType.Text = "NDEF record type: " + str_type;

                    string str_tnf = System.Convert.ToString(tnf);
                    LabelTnf.Text = "TNF: " + str_tnf;

                    //---------------------------------------------------------------------------

                    msg = "OK";

                    break;

                case DL_STATUS.UFR_WRONG_NDEF_CARD_FORMAT:

                    msg = "NDEF format error";

                    break;

                case DL_STATUS.UFR_NDEF_MESSAGE_NOT_FOUND:

                    msg = "NDEF message not found";

                    break;

                default:

                    msg = "Error: " + result;

                    break;
            }

            prn();

        }

        private void bWrNDEF_Click(object sender, EventArgs e)
        {
            DL_STATUS result = DL_STATUS.UNKNOWN_ERROR;

            //byte i, j;
            //byte tlv_type;
            //uint record_length;
            //ushort bytes_read;

            byte type_length, id_length, tnf;
            uint payload_length;
            byte card_formated;

            byte[] type = new byte[256];
            byte[] id = new byte[256];
            byte[] payload = new byte[1000];
            //memset(type, 0, 256);
            //memset(id, 0, 256);
            //memset(payload, 0, 1000);

            /*
            tnf = 1;
            type[0] = (byte) 'T';
            type_length = 1;
            id_length = 0;

            for (j = 0; j < 3; j++)
                for (i = 0; i < 200; i++)
                    payload[j * 200 + i] = i;
            payload_length = 600;

             * 
             * 
             */

            // payload[0]= 1;
            //  sprintf((char *)&payload[1], "d-logic.net");
            //  payload_length = 12;

            // write URI !
            tnf = 1;
            type[0] = (byte)'U';
            type_length = 1;
            id_length = 0;
            payload[0] = 1;

            // copy &payload[1], "d-logic.net");
            payload_length = (uint)EditUriText.Text.Length + 1;

            // byte[] utf8 = System.Text.Encoding.UTF8.GetBytes(EditUriText.Text);

            for (int i = 0; i < EditUriText.Text.Length; i++)
            {
                payload[i + 1] = (byte)EditUriText.Text[i];
            }

            unsafe
            {
                fixed (byte* f_type = type)
                fixed (byte* f_id = id)
                fixed (byte* f_payload = payload)
                    result = uFCoder.write_ndef_record(1, &tnf, f_type, &type_length, f_id, &id_length, f_payload, &payload_length, &card_formated);
            }

            prn_st("write_ndef_record", result);
        }

        private void bGetCnt_Click(object sender, EventArgs e)
        {
            DL_STATUS result = DL_STATUS.UNKNOWN_ERROR;

            byte message_cnt = 0;
            byte record_cnt = 0;
            byte empty_record_cnt = 0;

            byte[] record_cnt_array = new byte[100];

            unsafe
            {
                fixed (byte* pData = record_cnt_array)
                    result = uFCoder.get_ndef_record_count(&message_cnt, &record_cnt, pData, &empty_record_cnt);

            }

            prn_st("get_ndef_record_count", result);

            if (result == DL_STATUS.UFR_OK)
            {
                LabelTnf.Text = "TNF:";
                LabelRecordType.Text = "NDEF record type:";
                LabelMessageCnt.Text = "Message Counter: " + message_cnt;
                LabelRecordCnt.Text = "Record Counter: " + record_cnt;
                LabelEmptyMessage.Text = "Empty Message Counter: " + empty_record_cnt;
            }
        }



        private void bEraseLast_Click(object sender, EventArgs e)
        {
            DL_STATUS result;

            result = uFCoder.erase_last_ndef_record(1);

            prn_st("erase_last_ndef_record", result);
        }

        private void bEraseAll_Click(object sender, EventArgs e)
        {
            DL_STATUS result;

            result = uFCoder.erase_all_ndef_records(1);

            prn_st("erase_all_ndef_records", result);
        }

        private void bCardInit_Click(object sender, EventArgs e)
        {
            DL_STATUS result;

            result = uFCoder.ndef_card_initialization();

            prn_st("ndef_card_initialization", result);
        }
    }

}
