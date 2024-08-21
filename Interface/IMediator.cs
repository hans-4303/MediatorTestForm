using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTestForm.Interface
{
	/// <summary>
	/// 중재자 인터페이스, 중재자 클래스는 인터페이스를 상속
	/// </summary>
	public interface IMediator
	{
		/// <summary>
		/// 중재자 클래스가 상속하고 구현할 메서드
		/// </summary>
		/// <param name="sender">컴포넌트 등이 가능</param>
		/// <param name="ev">이벤트 값</param>
		void Notify (object sender, string ev);
	}
}
