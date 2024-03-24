using TP_MVC_NATHAN.Interfaces;


namespace TP_MVC_NATHAN.Implementation
{
    public partial class CustomListView : Form, IView
    {
        private IController _controller;
        private IModel _model;
        public CustomListView(IController controller, IModel model)
        {
            InitializeComponent();
            _controller = controller;
            _model = model;
            model.SetView(this);
        }

        public void SetController(IController controller)
        {
            throw new NotImplementedException();
        }

        public void SetModel(IModel model)
        {
            throw new NotImplementedException();
        }

        public void UpdateView()
        {
            throw new NotImplementedException();
        }

        private void ChangeViexButton_Click(object sender, EventArgs e)
        {

        }

        private void CustomListView_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string name = NametextBox.Text;
            int age = Int32.Parse(AgetextBox.Text);
            string town = TowntextBox.Text;

            _controller.AddClient(name, age, town);
            
        }
    }
}