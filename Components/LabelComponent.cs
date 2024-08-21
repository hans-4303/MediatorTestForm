using MediatorTestForm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTestForm.Components
{
	public class LabelComponent
	{
		private IMediator _mediator;

		public LabelComponent (IMediator mediator = null)
		{
			_mediator = mediator;
		}

		// 중재자 설정 메서드 추가
		public void SetMediator (IMediator mediator)
		{
			_mediator = mediator;
		}

		public void DisplayText (string text)
		{
			MessageBox.Show($"Label displays text: {text}");
		}
	}
}
