using MediatorTestForm.Components;
using MediatorTestForm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTestForm.EntityMediator
{
	public class ConcreteMediator : IMediator
	{
		private TextBoxComponent _textBoxComponent;
		private LabelComponent _labelComponent;

		public ConcreteMediator (TextBoxComponent textBoxComponent, LabelComponent labelComponent)
		{
			_textBoxComponent = textBoxComponent;
			_textBoxComponent.SetMediator(this);

			_labelComponent = labelComponent;
			_labelComponent.SetMediator(this);
		}

		public void Notify (object sender, string ev)
		{
			if (ev == "TextInput")
			{
				MessageBox.Show("Mediator processing TextInput event.");
				_labelComponent.DisplayText("Processed Text from TextBox");
			}
		}
	}
}
