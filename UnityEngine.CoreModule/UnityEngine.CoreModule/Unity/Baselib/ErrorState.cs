using System;
using System.Runtime.InteropServices;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib
{
	// Token: 0x02000294 RID: 660
	public struct ErrorState
	{
		// Token: 0x06002C6F RID: 11375 RVA: 0x000B2638 File Offset: 0x000B0838
		public void ThrowIfFailed()
		{
			bool flag = this.ErrorCode > Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode.Success;
			if (flag)
			{
				throw new BaselibException(this);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x0001142C File Offset: 0x0000F62C
		public Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode ErrorCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00011439 File Offset: 0x0000F639
		public string Explain([Optional] Unity.Baselib.LowLevel.Binding.Baselib_ErrorState_ExplainVerbosity verbosity)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
