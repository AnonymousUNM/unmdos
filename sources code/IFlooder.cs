
using System;

namespace unmdosx
{
	interface IFlooder
	{
		#region Properties
		int Delay       { get; set; }
		bool IsFlooding { get; set; }
		#endregion

		#region Methods
		void Start();
		void Stop();
		#endregion
	}
}
