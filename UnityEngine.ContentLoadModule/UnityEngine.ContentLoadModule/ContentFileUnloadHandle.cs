using System;

namespace Unity.Loading
{
	// Token: 0x02000004 RID: 4
	public struct ContentFileUnloadHandle
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsCompleted
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205D File Offset: 0x0000025D
		public bool WaitForCompletion(int timeoutMs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
