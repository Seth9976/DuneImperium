using System;

namespace UnityEngine.Android
{
	// Token: 0x02000017 RID: 23
	public class RequestToUseMobileDataAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00002BDB File Offset: 0x00000DDB
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00002BF3 File Offset: 0x00000DF3
		public AndroidAssetPackUseMobileDataRequestResult result
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002C00 File Offset: 0x00000E00
		public void OnResult(AndroidAssetPackUseMobileDataRequestResult result)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
