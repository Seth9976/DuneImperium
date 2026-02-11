using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Loading
{
	// Token: 0x02000006 RID: 6
	public static class ContentLoadInterface
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000208A File Offset: 0x0000028A
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002096 File Offset: 0x00000296
		public static float IntegrationTimeMS
		{
			get
			{
				return ContentLoadInterface.get_IntegrationTimeMSDelegateField();
			}
			set
			{
				ContentLoadInterface.set_IntegrationTimeMSDelegateField(value);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A4 File Offset: 0x000002A4
		public static float GetIntegrationTimeMS()
		{
			return ContentLoadInterface.IntegrationTimeMS;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020BC File Offset: 0x000002BC
		public static void SetIntegrationTimeMS(float integrationTimeMS)
		{
			bool flag = integrationTimeMS <= 0f;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("integrationTimeMS", "integrationTimeMS was out of range. Must be greater than zero.");
			}
			ContentLoadInterface.IntegrationTimeMS = integrationTimeMS;
		}

		// Token: 0x0400000E RID: 14
		private static readonly ContentLoadInterface.get_IntegrationTimeMSDelegate get_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<ContentLoadInterface.get_IntegrationTimeMSDelegate>("Unity.Loading.ContentLoadInterface::get_IntegrationTimeMS");

		// Token: 0x0400000F RID: 15
		private static readonly ContentLoadInterface.set_IntegrationTimeMSDelegate set_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<ContentLoadInterface.set_IntegrationTimeMSDelegate>("Unity.Loading.ContentLoadInterface::set_IntegrationTimeMS");

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000009 RID: 9
		private delegate float get_IntegrationTimeMSDelegate();

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600000B RID: 11
		private delegate void set_IntegrationTimeMSDelegate(float value);
	}
}
