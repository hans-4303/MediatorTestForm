using MediatorTestForm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTestForm.Components
{
	/// <summary>
	/// 텍스트 박스 컴포넌트
	/// </summary>
	public class TextBoxComponent
	{
		/// <summary>
		/// 인터페이스 타입으로 중재자 정의, 중재자 객체 받을 준비
		/// </summary>
		private IMediator _mediator;

		/// <summary>
		/// 생성자 메서드로 중재자 받는 시도
		/// </summary>
		/// <param name="mediator"></param>
		public TextBoxComponent(IMediator mediator = null)
		{
			_mediator = mediator;
		}

		/// <summary>
		/// 중재자 설정 메서드를 추가, 중재자 객체 받기 가능
		/// </summary>
		/// <param name="mediator"></param>
		public void SetMediator (IMediator mediator)
		{
			_mediator = mediator;
		}

		/// <summary>
		/// 텍스트 입력 메서드, 처리 후 중재자에게 현 컴포넌트와 이벤트 전달
		/// </summary>
		/// <param name="text"></param>
		public void InputText (string text)
		{
			MessageBox.Show($"TextBox received text: {text}");
			_mediator?.Notify(this, "TextInput");
		}
	}
}
