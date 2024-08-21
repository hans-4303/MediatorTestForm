using MediatorTestForm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTestForm.Components
{
	public class TextBoxComponent
	{
		private IMediator _mediator;

		public TextBoxComponent(IMediator mediator = null)
		{
			_mediator = mediator;
		}

		// 중재자 설정 메서드 추가
		public void SetMediator (IMediator mediator)
		{
			_mediator = mediator;
		}

		public void InputText (string text)
		{
			MessageBox.Show($"TextBox received text: {text}");
			_mediator?.Notify(this, "TextInput");
		}
	}
}
