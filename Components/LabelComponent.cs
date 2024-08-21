using MediatorTestForm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTestForm.Components
{
	/// <summary>
	/// 라벨 컴포넌트
	/// </summary>
	public class LabelComponent
	{
		/// <summary>
		/// 인터페이스 타입으로 중재자 정의, 실제 중재자 인스턴스 준비
		/// </summary>
		private IMediator _mediator;

		/// <summary>
		/// 생성자 함수로 중재자 준비
		/// </summary>
		/// <param name="mediator"></param>
		public LabelComponent (IMediator mediator = null)
		{
			_mediator = mediator;
		}

		/// <summary>
		/// 중재자 설정 메서드 추가
		/// </summary>
		/// <param name="mediator"></param>
		public void SetMediator (IMediator mediator)
		{
			_mediator = mediator;
		}

		/// <summary>
		/// 텍스트 출력 메서드
		/// </summary>
		/// <param name="text"></param>
		public void DisplayText (string text)
		{
			MessageBox.Show($"Label displays text: {text}");
		}
	}
}
