using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class TerrainCollider : Collider
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020B0 File Offset: 0x000002B0
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000207F File Offset: 0x0000027F
		public TerrainData terrainData
		{
			get
			{
				IntPtr intPtr = TerrainCollider.get_terrainDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainData>(intPtr2) : null;
			}
			set
			{
				TerrainCollider.set_terrainDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020DC File Offset: 0x000002DC
		public RaycastHit Raycast(Ray ray, float maxDistance, bool hitHoles, ref bool hasHit)
		{
			RaycastHit raycastHit;
			this.Raycast_Injected(ref ray, maxDistance, hitHoles, ref hasHit, out raycastHit);
			return raycastHit;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020F8 File Offset: 0x000002F8
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, bool hitHoles)
		{
			bool flag = false;
			hitInfo = this.Raycast(ray, maxDistance, hitHoles, ref flag);
			return flag;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002097 File Offset: 0x00000297
		public void Raycast_Injected(ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret)
		{
			TerrainCollider.Raycast_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref ray, maxDistance, hitHoles, ref hasHit, out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly TerrainCollider.get_terrainDataDelegate get_terrainDataDelegateField = IL2CPP.ResolveICall<TerrainCollider.get_terrainDataDelegate>("UnityEngine.TerrainCollider::get_terrainData");

		// Token: 0x04000002 RID: 2
		private static readonly TerrainCollider.set_terrainDataDelegate set_terrainDataDelegateField = IL2CPP.ResolveICall<TerrainCollider.set_terrainDataDelegate>("UnityEngine.TerrainCollider::set_terrainData");

		// Token: 0x04000003 RID: 3
		private static readonly TerrainCollider.Raycast_InjectedDelegate Raycast_InjectedDelegateField = IL2CPP.ResolveICall<TerrainCollider.Raycast_InjectedDelegate>("UnityEngine.TerrainCollider::Raycast_Injected");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000008 RID: 8
		private delegate IntPtr get_terrainDataDelegate(IntPtr @this);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000A RID: 10
		private delegate void set_terrainDataDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000C RID: 12
		private delegate void Raycast_InjectedDelegate(IntPtr @this, IntPtr ray, float maxDistance, bool hitHoles, IntPtr hasHit, [Out] IntPtr ret);
	}
}
