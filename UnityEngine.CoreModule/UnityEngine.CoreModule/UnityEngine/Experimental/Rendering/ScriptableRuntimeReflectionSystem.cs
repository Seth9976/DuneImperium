using System;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000367 RID: 871
	public abstract class ScriptableRuntimeReflectionSystem
	{
		// Token: 0x06002F3C RID: 12092 RVA: 0x000B5B18 File Offset: 0x000B3D18
		public virtual bool TickRealtimeProbes()
		{
			return false;
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00012E4C File Offset: 0x0001104C
		public virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00012E4F File Offset: 0x0001104F
		public void System.IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
