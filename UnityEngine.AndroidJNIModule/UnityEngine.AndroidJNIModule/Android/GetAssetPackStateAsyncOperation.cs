using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android
{
	// Token: 0x02000016 RID: 22
	public class GetAssetPackStateAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00002B9C File Offset: 0x00000D9C
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00002BA9 File Offset: 0x00000DA9
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00002BB4 File Offset: 0x00000DB4
		public ulong size
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002BC1 File Offset: 0x00000DC1
		public Il2CppReferenceArray<AndroidAssetPackState> states
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002BCE File Offset: 0x00000DCE
		public void OnResult(ulong size, Il2CppReferenceArray<AndroidAssetPackState> states)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
