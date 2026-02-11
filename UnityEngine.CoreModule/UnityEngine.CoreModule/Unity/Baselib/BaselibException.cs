using System;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib
{
	// Token: 0x02000295 RID: 661
	public class BaselibException : Exception
	{
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x00011446 File Offset: 0x0000F646
		public Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode ErrorCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
