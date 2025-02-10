using OODPrinciples.Composition;
using OODPrinciples.DIP;
using OODPrinciples.Interface;
using OODPrinciples.LSP;

Square square = new Square();
square.Width = 6;
square.Height = 9;

IEmailSender emailSender = new HTMLEmailSender();
Membership membership = new Membership(emailSender);


Electronics electronics = new Electronics();
electronics.Name = "Scanner";
electronics.Price = 20000;
electronics.GetPriceAfterDiscount(20);


void Start(IPowerSwitch item)
{

}
void Connect(IUSB item)
{
    //Many codes
    item.Connect();
}

