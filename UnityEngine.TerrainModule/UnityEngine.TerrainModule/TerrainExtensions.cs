using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public static class TerrainExtensions
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00005D04 File Offset: 0x00003F04
		public static void UpdateGIMaterials(Terrain terrain)
		{
			bool flag = terrain.terrainData == null;
			if (flag)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			TerrainExtensions.UpdateGIMaterialsForTerrain(terrain.GetInstanceID(), new Rect(0f, 0f, 1f, 1f));
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005D54 File Offset: 0x00003F54
		public static void UpdateGIMaterials(Terrain terrain, int x, int y, int width, int height)
		{
			bool flag = terrain.terrainData == null;
			if (flag)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			float num = (float)terrain.terrainData.alphamapWidth;
			float num2 = (float)terrain.terrainData.alphamapHeight;
			TerrainExtensions.UpdateGIMaterialsForTerrain(terrain.GetInstanceID(), new Rect((float)x / num, (float)y / num2, (float)width / num, (float)height / num2));
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002D6D File Offset: 0x00000F6D
		public static void UpdateGIMaterialsForTerrain(int terrainInstanceID, Rect uvBounds)
		{
			TerrainExtensions.UpdateGIMaterialsForTerrain_Injected(terrainInstanceID, ref uvBounds);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002D77 File Offset: 0x00000F77
		public static void UpdateGIMaterialsForTerrain_Injected(int terrainInstanceID, ref Rect uvBounds)
		{
			TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegateField(terrainInstanceID, ref uvBounds);
		}

		// Token: 0x040000EB RID: 235
		private static readonly TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegate UpdateGIMaterialsForTerrain_InjectedDelegateField = IL2CPP.ResolveICall<TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegate>("UnityEngine.TerrainExtensions::UpdateGIMaterialsForTerrain_Injected");

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x0600034E RID: 846
		private delegate void UpdateGIMaterialsForTerrain_InjectedDelegate(int terrainInstanceID, IntPtr uvBounds);
	}
}
