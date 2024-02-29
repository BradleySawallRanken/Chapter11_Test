using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11_Test
{
    public partial class frmCardStore : Form
    {
        private const decimal BirthdayBaseCost = 2.50m;
        private const decimal AnniversaryBaseCost = 3.00m;
        private const decimal CongratulationsBaseCost = 2.75m;

        private decimal selectedOccasionCost;
        private decimal selectedStyleCost;
        private decimal totalCost;

        private Dictionary<string, string> styleImages = new Dictionary<string, string>();
        public frmCardStore()
        {
            InitializeComponent();
            InitializeStyleImages();

            txtCustomMessage.Enabled = false;
        }
        private void InitializeStyleImages()
        {
            styleImages.Add("Tree", "\"C:\\Users\\sawal\\Desktop\\The Ranken File\\Finished Homework\\Chapter11_Test\\Images\\Tree.jpg\"");
            styleImages.Add("Mountain", "\"C:\\Users\\sawal\\Desktop\\The Ranken File\\Finished Homework\\Chapter11_Test\\Images\\Mountain.jpg\"");
            styleImages.Add("Big Chungus", "\"C:\\Users\\sawal\\Desktop\\The Ranken File\\Finished Homework\\Chapter11_Test\\Images\\Big_Chungus.jpg\"");
        }

        private void frmCardStore_Load(object sender, EventArgs e)
        {
            occasionComboBox.Items.AddRange(new string[] { "Birthday", "Anniversary", "Congratulations" });

            styleComboBox.Items.AddRange(styleImages.Keys.ToArray());

            occasionComboBox.SelectedIndex = 0;
            styleComboBox.SelectedIndex = 0;

            UpdateBaseCosts();
        }

        private void UpdateBaseCosts()
        {
            if (occasionComboBox.SelectedItem != null && styleComboBox.SelectedItem != null)
            {
                switch (occasionComboBox.SelectedItem.ToString())
                {
                    case "Birthday":
                        selectedOccasionCost = BirthdayBaseCost;
                        break;
                    case "Anniversary":
                        selectedOccasionCost = AnniversaryBaseCost;
                        break;
                    case "Congratulations":
                        selectedOccasionCost = CongratulationsBaseCost;
                        break;
                    default:
                        selectedOccasionCost = 0m;
                        break;
                }

                selectedStyleCost = (styleComboBox.SelectedIndex + 1) * 1.50m;
            }

            UpdateTotalCost();

            UpdatePreviewImage();
        }

        private void UpdateTotalCost()
        {
            totalCost = selectedOccasionCost + selectedStyleCost;

            if (envelopeCheckBox.Checked)
                totalCost += 0.25m;

            if (stampCheckBox.Checked)
                totalCost += 0.50m;

            if (messageCheckBox.Checked)
                totalCost += 0.30m;

            lblCost.Text = $"Cost: ${totalCost:F2}";
        }

        private void UpdatePreviewImage()
        {
            if (styleComboBox.SelectedItem != null)
            {
                string selectedStyle = styleComboBox.SelectedItem.ToString();

                if (styleImages.TryGetValue(selectedStyle, out string imagePath))
                {
                    previewPictureBox.ImageLocation = imagePath;
                }
            }
        }

        private void envelopeCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void stampCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void messageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (messageCheckBox.Checked)
            {
                txtCustomMessage.Enabled = true;
            }
            else
            {
                txtCustomMessage.Enabled = false;
                txtCustomMessage.Clear();
                lblCardPreview.Text = string.Empty;
            }

            UpdateTotalCost();
        }

        private void styleComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateBaseCosts();
        }

        private void occasionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateBaseCosts();
        }

        private void frmCardStore_Load_1(object sender, EventArgs e)
        {

        }
    }
}
