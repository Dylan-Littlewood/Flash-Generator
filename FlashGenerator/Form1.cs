

using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FlashGenerator
{
    public partial class Form1 : Form
    {
        private string FlashFilePath = string.Empty;
        private string FlashFileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
            Config.Initialize(System.IO.Directory.GetCurrentDirectory() + "\\Config.xml");
            cb_manufacturer.DataSource = Config.Get.Manufacturers;
            cb_brand.DataSource = Config.Get.Brands;
            cb_manufacturer.DisplayMember = "Name";
            cb_brand.DisplayMember = "Name";
            cb_manufacturer.SelectedIndex = -1;
            cb_brand.SelectedIndex = -1;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tb_SKU.Text))
            {
                tb_SKU.Focus();
                Utils.Error("SKU should not be left blank!");
                return false;
            }
            if (cb_manufacturer.SelectedIndex == -1)
            {
                cb_manufacturer.Focus();
                Utils.Error("Manufaturer should not be left blank!");
                return false;
            }
            if (cb_brand.SelectedIndex == -1)
            {
                cb_brand.Focus();
                Utils.Error("Brand should not be left blank!");
                return false;
            }
            if (FlashFilePath == string.Empty)
            {
                Utils.Error("Please select a Flash File");
                return false;
            }
            return true;
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) { return; }

            Manufacturer selectedManufacturer = Config.Get.Manufacturers.Find((maufacturer) => maufacturer.Name == cb_manufacturer.Text) ?? throw new Exception();
            string outputFlashPath = Config.Get.FlashOutputPath + "\\" + cb_brand.Text + "\\" + tb_SKU.Text;
            string outputOA3Path = Config.Get.OA3OutputPath + "\\" + tb_SKU.Text;

            string flashInfo =
                "Flash File: " + "\n" + FlashFileName + "\n\n" +
                "Manufacturer: " + "\n" + cb_manufacturer.Text + "\n\n" +
                "Branding: " + "\n" + cb_brand.Text + "\n\n" +
                "Target Path: " + outputFlashPath + "\n\n" +
                "Is This Correct?";

            if (!Utils.Question(flashInfo, "Do You Wish To Continue?")) { return; }

            DirectoryInfo flashSource = new DirectoryInfo(selectedManufacturer.FlashPath);
            DirectoryInfo flashTarget = new DirectoryInfo(outputFlashPath);
            DirectoryInfo oa3Source = new DirectoryInfo(selectedManufacturer.OA3Path);
            DirectoryInfo oa3Target = new DirectoryInfo(outputOA3Path);
            FileInfo FlashFileSource = new FileInfo(FlashFilePath);

            if (Directory.Exists(outputFlashPath))
            {
                if (!Utils.Warning("This flash already exists, do you wish to continue?\n\n(this will delete the original files)"))
                {
                    return;
                }
                Directory.Delete(outputFlashPath, true);
            }

            Utils.CopyDirectory(flashSource, flashTarget);
            Utils.CopyFile(FlashFileSource, flashTarget);
            Utils.CreateBatchFile(outputFlashPath, FlashFileName);
            Utils.UpdateBatchFile(outputFlashPath, FlashFileName);

            if (!Utils.CheckDirectoryContains(oa3Source, oa3Target))
            {
                if (Directory.Exists(outputOA3Path))
                {
                    if (!Utils.Warning("The OA3 tools for this motherboard do not match the example folder, do you wish to fix these now?\n\n(this will delete the original files)"))
                    {
                        return;
                    }
                    Directory.Delete(outputOA3Path, true);
                }
                else
                {
                    if (!Utils.Question("The OA3 tools for this motherboard are not set up,\ndo you wish to set these up now?", "OA3 Tools"))
                    {
                        return;
                    }
                }
                Utils.CopyDirectory(oa3Source, oa3Target);
            }
        }

        private void btn_SelectFlash_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                openFileDialog.Filter = "flash files (*.cap)|*.cap|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    l_FlashFile.Text = openFileDialog.SafeFileName;
                    FlashFileName = openFileDialog.SafeFileName;
                    FlashFilePath = openFileDialog.FileName;
                }
                else
                {
                    FlashFilePath = string.Empty;
                    FlashFileName = string.Empty;
                    l_FlashFile.Text = "No Flash Selected";
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutDialog = new About();
            aboutDialog.ShowDialog();
            // TODO: Setup the about infomation.
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsDialog = new Settings();
            settingsDialog.ShowDialog();
        }

        private void manufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit manufacturersDialog = new Edit(Edit.EditTarget.Manufaturers);
            manufacturersDialog.ShowDialog();
        }

        private void brandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit brandDialog = new Edit(Edit.EditTarget.Brands);
            brandDialog.ShowDialog();
        }

    }
}