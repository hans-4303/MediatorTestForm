using MediatorTestForm.Components;
using MediatorTestForm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTestForm.EntityMediator
{
	/// <summary>
	/// 중재자 클래스 정의, 중재자 인터페이스 상속받음
	/// </summary>
	public class ConcreteMediator : IMediator
	{
		/// <summary>
		/// 컴포넌트들을 멤버로 정의
		/// </summary>
		private TextBoxComponent _textBoxComponent;
		private LabelComponent _labelComponent;

		/// <summary>
		/// 생성자 메서드에 받을 컴포넌트를 정의 가능, 멤버로 받아오기
		/// </summary>
		/// <param name="textBoxComponent"></param>
		/// <param name="labelComponent"></param>
		public ConcreteMediator (TextBoxComponent textBoxComponent, LabelComponent labelComponent)
		{
			_textBoxComponent = textBoxComponent;
			_textBoxComponent.SetMediator(this);

			_labelComponent = labelComponent;
			_labelComponent.SetMediator(this);
		}

		/// <summary>
		/// <para>Notify 메서드, 중재자 객체를 통해 호출 가능하도록 정의</para>
		/// <para>
		///		이벤트 파라미터의 값에 따라 메시지 박스를 띄운 뒤
		///		라벨 컴포넌트 인스턴스의 DisplayText 메서드를 호출함
		///		따라서 중재자만 인스턴스를 알고 있으면 되고
		///		텍스트 박스 컴포넌트와 라벨 컴포넌트는 서로를 인지하지 못함
		/// </para>
		/// </summary>
		/// <param name="sender">메시지를 보내는 컴포넌트</param>
		/// <param name="ev">어떤 이벤트라고 정의 가능한 파라미터</param>
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
