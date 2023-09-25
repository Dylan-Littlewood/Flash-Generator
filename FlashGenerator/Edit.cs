namespace FlashGenerator
{
    public partial class Edit : Form
    {
        public enum EditTarget { Manufaturers, Brands }
        private EditTarget m_Target;
        public Edit(EditTarget editTarget)
        {
            InitializeComponent();
            m_Target = editTarget;
            this.Text = "Edit - " + m_Target.ToString();
            l_Title.Text = m_Target.ToString();
            if (m_Target == EditTarget.Manufaturers)
            {
                lb_Edit.DataSource = Config.Get.Manufacturers;
                lb_Edit.DisplayMember = "Name";
            }
            if (m_Target == EditTarget.Brands)
            {
                lb_Edit.DataSource = Config.Get.Brands;
                lb_Edit.DisplayMember = "Name";
            }
        }
    }
}
