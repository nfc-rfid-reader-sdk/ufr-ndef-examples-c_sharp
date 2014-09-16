﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uFCoderMulti;

namespace uFR_NDEF_example
{
    public partial class Form2 : Form
    {
        bool reader_state;

        public Form2()
        {
            InitializeComponent();
        }

        private void prn_status(DL_STATUS status, string ok_text)
        {
            string msg;

            if (status == DL_STATUS.UFR_OK)
            {
                msg = " OK - " + ok_text;
            }
            else
            {
                msg = " Error: " + status;
            }

            // prn
            statusResult.Text = msg;
        }

        private DL_STATUS reader_open()
        {
            uint reader_type;
            byte[] reader_sn = new byte[8];
            uint dll_ver;
            byte dll_major_ver;
            byte dll_minor_ver;
            ushort dll_build;
            byte fw_major_ver;
            byte fw_minor_ver;
            byte fw_build;
            byte hw_major;
            byte hw_minor;

            DL_STATUS status;

            //-------------------------------------------------------
            // uFR DLL
            dll_ver = uFCoder.GetDllVersion();
            dll_major_ver = (byte)dll_ver;
            dll_minor_ver = (byte)(dll_ver >> 8);
            dll_build = (byte)(dll_ver >> 16);

            DevInfoDLL.Text = " DLL " + (dll_major_ver) + "." + (dll_minor_ver) +
                  "." + (dll_build);

            //-------------------------------------------------------
            status = uFCoder.ReaderOpen();
            if (status != DL_STATUS.UFR_OK)
            {
                return status;
            }

            //-------------------------------------------------------
            unsafe
            {
                fixed (byte* f_rdsn = reader_sn)
                    status = uFCoder.GetReaderSerialDescription(f_rdsn);
            }

            unsafe
            {
                status |= uFCoder.GetReaderType(&reader_type);

                status |= uFCoder.GetReaderHardwareVersion(&hw_major, &hw_minor);

                status |= uFCoder.GetReaderFirmwareVersion(&fw_major_ver, &fw_minor_ver);

                status |= uFCoder.GetBuildNumber(&fw_build);
            }

            if (status != DL_STATUS.UFR_OK)
            {
                statusReader.Text = " Not connected";
                reader_state = false;
                return status;
            }

            //-------------------------------------------------------

            statusReader.Text = " CONNECTED ";

            reader_state = true;

            DevInfoSN.Text = " SN : " + System.Text.Encoding.UTF8.GetString(reader_sn);
            DevInfoHW.Text = " HW : " + (int)hw_major + "." + hw_minor;

            DevInfoFW.Text = " FW : " + (fw_major_ver) + "." +
                                    (fw_minor_ver) + "." +
                                    (fw_build);

            return DL_STATUS.UFR_OK;
        }

        private void reader_open_do()
        {
            statusReader.Text = " CONNECTED ";

            reader_state = true;

            panelReader.BackColor = Color.LimeGreen; // LIME

            if (tabControl1.Enabled == false)
            {
                tabControl1.Enabled = true;
                //BtREAD->SetFocus();
            }

            statusResult.Text = DL_STATUS.UFR_OK.ToString();
        }

        private void reader_close_do()
        {
            statusReader.Text = " Not connected";
            reader_state = false;

            panelReader.BackColor = Color.Red;

            DevInfoSN.Text = " SN:";
            DevInfoHW.Text = " HW:";
            DevInfoFW.Text = " FW:";

            tabControl1.Enabled = false;
        }

        private void bOpenReader_Click(object sender, EventArgs e)
        {
            DL_STATUS status;

            panelReader.BackColor = Color.DarkRed;
            statusResult.Text = "Bitte warten...";
            this.Update();

            status = reader_open();

            if (status == DL_STATUS.UFR_OK)
            {
                reader_open_do();
            }
            else
            {
                reader_close_do();
            }
        }

        private void bCloseReader_Click(object sender, EventArgs e)
        {
            reader_close_do();
        }

        private void bCardInit_Click(object sender, EventArgs e)
        {
            DL_STATUS status;

            status = uFCoder.ndef_card_initialization();

            prn_status(status, "Initialized");

        }

        private void bCardClear_Click(object sender, EventArgs e)
        {
            /*
             * 
            DL_STATUS status;

     

byte addressingmode,
                address, authmode;
byte      sectortrailer[16]={0xff,0xff,0xff,0xff,0xff,0xff,0xff,0x07,0x80,0x69,0xff,0xff,0xff,0xff,0xff,0xff};
//byte      NFCKey[6] ={0xd3,0xf7,0xd3,0xf7,0xd3,0xf7};
//byte      MADKey[6] ={0xa0,0xa1,0xa2,0xa3,0xa4,0xa5};
byte      DEFKey[6] ={0xff,0xff,0xff,0xff,0xff,0xff};
byte      data[752];
ushort bw;
           int i;
           uint res;


        addressingmode=0x01;
        address=0x00;
        authmode=0x61;




       res= SectorTrailerWriteUnsafe_PK(addressingmode,address,
     sectortrailer,authmode,DEFKey);



        for (i=1  ;i<16; i++)
                {res= SectorTrailerWriteUnsafe_PK(addressingmode,i,
     sectortrailer,authmode,DEFKey);
        res=res+res;
        }


            for (i=0  ;i<data_len+1; i++)
        {data[i]=0x00;

         }

       res = LinearWrite_PK(data,0,data_len,&bw,authmode,DEFKey);
        ShowMessage("Card erased ");



            prn_status(status, "Card erased");
             * */

            MessageBox.Show("Card erased - NOT IMPLEMENTED !!!");
        }

        private void bEraseAllRec_Click(object sender, EventArgs e)
        {
            DL_STATUS status;

            status = uFCoder.erase_all_ndef_records(1);

            prn_status(status, "Erased All");
        }

        private void bEraseLastRec_Click(object sender, EventArgs e)
        {
            DL_STATUS status;

            status = uFCoder.erase_last_ndef_record(1);

            prn_status(status, "Erased");
        }

        private DLOGIC_CARD_TYPE getcardtype()
        {
            DL_STATUS status;
            byte cardtype_val = 0;
            DLOGIC_CARD_TYPE cardtype;

            unsafe
            {
                status = uFCoder.GetDlogicCardType(&cardtype_val);
            }

            if (status != DL_STATUS.UFR_OK)
            {
                cardtype_val = 0;
            }

            cardtype = (DLOGIC_CARD_TYPE)cardtype_val;

            return cardtype;
        }

        private int getcardlen(DLOGIC_CARD_TYPE cardtype)
        {
            int data_len;

            switch (cardtype)
            {
                case DLOGIC_CARD_TYPE.DL_MIFARE_MINI:
                    data_len = 320;
                    break;
                case DLOGIC_CARD_TYPE.DL_MIFARE_CLASSIC_1K:
                    data_len = 752;
                    break;
                case DLOGIC_CARD_TYPE.DL_NTAG_213:
                    data_len = 752;
                    break;
                case DLOGIC_CARD_TYPE.DL_MIFARE_CLASSIC_4K:
                    data_len = 3356;
                    break;
                case DLOGIC_CARD_TYPE.DL_MIFARE_CLASSIC_4k:
                    data_len = 3356;
                    break;
                case DLOGIC_CARD_TYPE.DL_MIFARE_ULTRALIGHT:
                    data_len = 48;
                    break;
                case DLOGIC_CARD_TYPE.DL_MIFARE_ULTRALIGHT_C:
                    data_len = 144;
                    break;
                case DLOGIC_CARD_TYPE.DL_NTAG_203:
                    data_len = 144;
                    break;

                default:
                    data_len = 0;
                    break;

            }

            return data_len;
        }


        private void get_record_count()
        {

        }

        private byte[] SubByteArray(byte[] sourceArray, int out_len)
        {
            byte[] truncArray = new byte[out_len];
            Array.Copy(sourceArray, truncArray, truncArray.Length);
            return truncArray;
        }

        private void bReadCard_Click(object sender, EventArgs e)
        {
            DL_STATUS result = DL_STATUS.UNKNOWN_ERROR;
            byte tlv_type;
            uint record_length;
            ushort bytes_read;

            byte[] type = new byte[256];
            byte[] id = new byte[256];
            byte[] payload = new byte[1000];
            byte type_length, id_length, tnf;
            byte record_nr, j;
            byte message_cnt, record_cnt, empty_record_cnt;
            byte[] record_cnt_array = new byte[100];
            DLOGIC_CARD_TYPE cardtype;
            string ct;
            int card_len;

            txtPayload.Clear();

            cardtype = getcardtype();
            // trim DL
            // _ to spc
            ct = String.Format("[{0:X}]", (int)cardtype);
            ct += " " + cardtype.ToString();

            card_len = getcardlen(cardtype);


            if (cardtype == DLOGIC_CARD_TYPE.DL_NO_CARD)
            {
                statusResult.Text = ct;

                return;
            }

            NdefInfoCardType.Text = ct;

            unsafe
            {
                fixed (byte* pData = record_cnt_array)
                    result = uFCoder.get_ndef_record_count(&message_cnt, &record_cnt, pData, &empty_record_cnt);

            }

            prn_status(result, "Read record count");

            if (result != DL_STATUS.UFR_OK)
            {
                return;
            }

            NdefInfoMsgs.Text = "Msgs : " + message_cnt;
            NdefInfoRecs.Text = "Recs : " + record_cnt;
            NdefInfoEmpty.Text = "Empty: " + empty_record_cnt;





            // init table !
            SG1.Rows.Clear();
            txtPayload.Text = "Palyload:";

            // configure fixed row 

            //if (SG1.RowCount < 2) SG1.RowCount = 2;
            //SG1.FixedRows = 1;

            //memset(record_cnt_array, 0, 100);






            //SG1.RowCount = record_cnt + 1;

            //for (i = 1; i < SG1.RowCount + 1; i++)
            //{
            //    for (j = 0; j < SG1.ColCount + 1; j++)
            //        SG1.Cells[j][i] = "";
            //}

            //SG1.Repaint();

            //PB1->Max = record_cnt * 10;
            //PB1->Position = 0;


























            //ndef_record_struct ndef_record;
            //unsigned char record_data[1000];
            //byte tlv_type;
            //uint record_length;
            //ushort bytes_read;

            uint payload_length;







            for (record_nr = 1; record_nr < record_cnt + 1; record_nr++)
            {
                //read_payload_length = 0;
                //memset(type, 0, 256);
                //memset(id, 0, 256);
                //memset(read_payload, 0, 1000);
                //Application->ProcessMessages();

                unsafe
                {
                    fixed (byte* f_type = type)
                    fixed (byte* f_id = id)
                    fixed (byte* f_payload = payload)

                        result = uFCoder.read_ndef_record(1, (byte)record_nr, &tnf, f_type, &type_length, f_id, &id_length, f_payload, &payload_length);
                }


                if (result != DL_STATUS.UFR_OK)
                {
                    if (result == DL_STATUS.UFR_WRONG_NDEF_CARD_FORMAT)
                        statusResult.Text = " NDEF format error";
                    else if (result == DL_STATUS.UFR_NDEF_MESSAGE_NOT_FOUND)
                        statusResult.Text = " NDEF message not found";
                    else
                        statusResult.Text = " Error: " + result;

                    break;
                }

                string str_payload = System.Text.Encoding.UTF8.GetString(SubByteArray(payload, (int)payload_length));
                string str_type = System.Text.Encoding.UTF8.GetString(SubByteArray(type, (int)type_length));
                string str_tnf = "TNF: " + System.Convert.ToString(tnf);
                //---------------------------------------------------------------------------

                string[] row = { record_nr.ToString(), str_type.ToString(), payload_length.ToString(), str_payload };

                SG1.Rows.Add(row);

                //gridReader.Rows[idx].SetValues(ufr.get_info());

                //PB1->Position = (1 + i) * 10;


                NdefInfoTNF.Text = str_tnf;

                statusResult.Text = " Reading " + record_nr + "/" + record_cnt;

            }  //for i

            //SG1.RowCount--;
            SG1.Update();
            //PB1->Position = 0;

            statusResult.Text = "Reading DONE!";

            if (message_cnt == 0 && empty_record_cnt == 0)
            {
                statusResult.Text = "Card must be formatted first!";
            }
            else
            {
                if (message_cnt == 1 && empty_record_cnt == 1)
                {
                    statusResult.Text = "NFC formatted! Ready for use...";
                }
            }

        }

        private void SG1_SelectionChanged(object sender, EventArgs e)
        {
            if (SG1.CurrentRow.Index + 1 == SG1.RowCount)
            {
                txtPayload.Text = "Payload:";
            }
            else
            {
                txtPayload.Text = SG1.CurrentRow.Cells[3].Value.ToString();
            }
        }

    }
}
