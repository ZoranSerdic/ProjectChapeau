using ChapeauService;
namespace ChapeauUI
{
    public partial class ChapeauDesktopUI : Form
    {
        public ChapeauDesktopUI()
        {
            InitializeComponent();

            PaymentService paymentService = new PaymentService();
            paymentService.GenerateBill(2, 200);
        }
    }
}