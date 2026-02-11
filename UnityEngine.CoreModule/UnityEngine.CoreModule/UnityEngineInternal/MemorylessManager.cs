using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal
{
	// Token: 0x0200028F RID: 655
	public class MemorylessManager
	{
		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x000B2620 File Offset: 0x000B0820
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x00011401 File Offset: 0x0000F601
		public static MemorylessMode depthMemorylessMode
		{
			get
			{
				return MemorylessManager.GetFramebufferDepthMemorylessMode();
			}
			set
			{
				MemorylessManager.SetFramebufferDepthMemorylessMode(value);
			}
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0001140B File Offset: 0x0000F60B
		public static MemorylessMode GetFramebufferDepthMemorylessMode()
		{
			return MemorylessManager.GetFramebufferDepthMemorylessModeDelegateField();
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00011417 File Offset: 0x0000F617
		public static void SetFramebufferDepthMemorylessMode(MemorylessMode mode)
		{
			MemorylessManager.SetFramebufferDepthMemorylessModeDelegateField(mode);
		}

		// Token: 0x040027BA RID: 10170
		private static readonly MemorylessManager.GetFramebufferDepthMemorylessModeDelegate GetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.GetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::GetFramebufferDepthMemorylessMode");

		// Token: 0x040027BB RID: 10171
		private static readonly MemorylessManager.SetFramebufferDepthMemorylessModeDelegate SetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.SetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::SetFramebufferDepthMemorylessMode");

		// Token: 0x02000AAD RID: 2733
		// (Invoke) Token: 0x06003E73 RID: 15987
		private delegate MemorylessMode GetFramebufferDepthMemorylessModeDelegate();

		// Token: 0x02000AAE RID: 2734
		// (Invoke) Token: 0x06003E75 RID: 15989
		private delegate void SetFramebufferDepthMemorylessModeDelegate(MemorylessMode mode);
	}
}
