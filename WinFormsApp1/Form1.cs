using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindContext _context = new NorthwindContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = _context.Products.ToList();
            dataGridView1.DataSource = _context.Products.Where(x => x.CategoryId == 1).ToList();    
            dataGridView1.DataSource = _context.Products.Where(x => x.CategoryId == 2).OrderByDescending(x => x.UnitPrice).ToList();
        }
    }
}
