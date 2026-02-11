using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android
{
	// Token: 0x02000015 RID: 21
	public class DownloadAssetPackAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00002B50 File Offset: 0x00000D50
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002B5D File Offset: 0x00000D5D
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00002B68 File Offset: 0x00000D68
		public float progress
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00002B75 File Offset: 0x00000D75
		public Il2CppStringArray downloadedAssetPacks
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00002B82 File Offset: 0x00000D82
		public Il2CppStringArray downloadFailedAssetPacks
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002B8F File Offset: 0x00000D8F
		public void OnUpdate(AndroidAssetPackInfo info)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000090 RID: 144
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
