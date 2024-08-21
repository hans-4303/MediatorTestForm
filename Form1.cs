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

			// ������Ʈ�� ȣ��
			var textBoxComponent = new TextBoxComponent();
			var labelComponent = new LabelComponent();

			// ������ �ν��Ͻ� �����, ������ �ν��Ͻ� ��ü�� �߿��� �� �ƴ϶� ������ �޼���� ������Ʈ�� ������ ��Ī�� �ƴ�
			var mediator = new ConcreteMediator(textBoxComponent, labelComponent);

			// ������ �ν��Ͻ��� ��Ī�� �ؽ�Ʈ�ڽ� ������Ʈ���� �޼��� ȣ��
			// ������Ʈ�� �����ڸ� �˰� ������Ʈ �ν��Ͻ��� �̺�Ʈ Ÿ���� ������ �޼��� ȣ���ϸ� ����
			textBoxComponent.InputText("Hello World To TextBoxComponent");
		}
	}
}
