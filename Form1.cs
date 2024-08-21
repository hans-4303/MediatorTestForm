using MaterialSkin;
using MaterialSkin.Controls;
using MediatorTestForm.Components;
using MediatorTestForm.EntityMediator;

namespace MediatorTestForm
{
	public partial class Form1 : MaterialForm
	{
		public Form1 ()
		{
			InitializeComponent();

			var textBoxComponent = new TextBoxComponent();
			var labelComponent = new LabelComponent();

			var mediator = new ConcreteMediator(textBoxComponent, labelComponent);

			textBoxComponent.InputText("Hello World To TextBoxComponent");
		}
	}
}
