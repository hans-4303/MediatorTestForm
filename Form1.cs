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

			// 컴포넌트들 호출
			var textBoxComponent = new TextBoxComponent();
			var labelComponent = new LabelComponent();

			// 중재자 인스턴스 만들기, 중재자 인스턴스 자체가 중요한 게 아니라 생성자 메서드로 컴포넌트와 중재자 매칭이 됐다
			var mediator = new ConcreteMediator(textBoxComponent, labelComponent);

			// 중재자 인스턴스와 매칭된 텍스트박스 컴포넌트에서 메서드 호출
			// 컴포넌트가 중재자를 알고 컴포넌트 인스턴스와 이벤트 타입을 중재자 메서드 호출하며 전달
			textBoxComponent.InputText("Hello World To TextBoxComponent");
		}
	}
}
