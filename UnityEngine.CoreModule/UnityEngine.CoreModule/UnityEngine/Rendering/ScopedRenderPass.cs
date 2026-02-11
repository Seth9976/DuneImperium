using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200034B RID: 843
	public struct ScopedRenderPass
	{
		// Token: 0x06002E41 RID: 11841 RVA: 0x000128AE File Offset: 0x00010AAE
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04002A1D RID: 10781
		public ScriptableRenderContext m_Context;
	}
}
