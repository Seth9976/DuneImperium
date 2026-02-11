using System;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200032C RID: 812
	[Serializable]
	public struct CreateSceneParameters
	{
		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x000B4A80 File Offset: 0x000B2C80
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x0001272F File Offset: 0x0001092F
		public LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			set
			{
				this.m_LocalPhysicsMode = value;
			}
		}

		// Token: 0x040029AA RID: 10666
		public LocalPhysicsMode m_LocalPhysicsMode;
	}
}
