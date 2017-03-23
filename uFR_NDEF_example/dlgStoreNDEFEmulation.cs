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

namespace uFR_NDEF_example
{
    public partial class dlgStoreNDEFEmulation : Form
    {
        private int tnf;
        private string type;
        private string id;
        private byte[] payload;
        private DL_STATUS _status;
        public DL_STATUS Status { get { return _status; } }

        public dlgStoreNDEFEmulation(int TNF, string Type, string ID, byte[] Payload)
        {
            tnf = TNF;
            type = Type;
            id = ID;
            payload = Payload;
            _status = DL_STATUS.UNKNOWN_ERROR;
            InitializeComponent();
        }

        private void chkUseAAR_CheckedChanged(object sender, EventArgs e)
        {
            eAAR.Enabled = label16.Enabled = chkUseAAR.Checked;
        }
        
        private void btnStore_Click(object sender, EventArgs e)
        {

            byte usf_tnf = (byte)tnf;

            byte[] u_type = System.Text.Encoding.UTF8.GetBytes(type);
            byte usf_type_length = (byte)type.Length;

            byte[] u_id = System.Text.Encoding.UTF8.GetBytes(id);
            byte usf_id_length = (byte)id.Length;

            byte[] u_payload = payload;
            byte usf_payload_length = (byte)payload.Length;

            byte[] u_aar = System.Text.Encoding.UTF8.GetBytes(eAAR.Text);
            byte usf_aar_len = (byte)u_aar.Length;

            if (chkUseAAR.Checked)
                unsafe
                {
                    fixed (byte* usf_type = u_type)
                    fixed (byte* usf_id = u_id)
                    fixed (byte* usf_payload = u_payload)
                    fixed (byte* usf_aar = u_aar)
                    _status = uFCoder.WriteEmulationNdefWithAAR(usf_tnf, usf_type, usf_type_length, 
                             usf_id, usf_id_length, usf_payload, usf_payload_length, usf_aar, usf_aar_len);
                }
            else
                unsafe
                {
                    fixed (byte* usf_type = u_type)
                    fixed (byte* usf_id = u_id)
                    fixed (byte* usf_payload = u_payload)
                    _status = uFCoder.WriteEmulationNdef(usf_tnf, usf_type, usf_type_length,
                             usf_id, usf_id_length, usf_payload, usf_payload_length);
                }
        }
    }
}
