using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Tilemaps
{
	// Token: 0x0200000F RID: 15
	public sealed class TilemapCollider2D : Collider2D
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002C84 File Offset: 0x00000E84
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002C96 File Offset: 0x00000E96
		public bool useDelaunayMesh
		{
			get
			{
				return TilemapCollider2D.get_useDelaunayMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapCollider2D.set_useDelaunayMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002CA9 File Offset: 0x00000EA9
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002CBB File Offset: 0x00000EBB
		public uint maximumTileChangeCount
		{
			get
			{
				return TilemapCollider2D.get_maximumTileChangeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapCollider2D.set_maximumTileChangeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002CCE File Offset: 0x00000ECE
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public float extrusionFactor
		{
			get
			{
				return TilemapCollider2D.get_extrusionFactorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapCollider2D.set_extrusionFactorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002CF3 File Offset: 0x00000EF3
		public bool hasTilemapChanges
		{
			get
			{
				return TilemapCollider2D.get_hasTilemapChangesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002D05 File Offset: 0x00000F05
		public void ProcessTilemapChanges()
		{
			TilemapCollider2D.ProcessTilemapChangesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x040000BF RID: 191
		private static readonly TilemapCollider2D.get_useDelaunayMeshDelegate get_useDelaunayMeshDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_useDelaunayMeshDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_useDelaunayMesh");

		// Token: 0x040000C0 RID: 192
		private static readonly TilemapCollider2D.set_useDelaunayMeshDelegate set_useDelaunayMeshDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.set_useDelaunayMeshDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_useDelaunayMesh");

		// Token: 0x040000C1 RID: 193
		private static readonly TilemapCollider2D.get_maximumTileChangeCountDelegate get_maximumTileChangeCountDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_maximumTileChangeCountDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_maximumTileChangeCount");

		// Token: 0x040000C2 RID: 194
		private static readonly TilemapCollider2D.set_maximumTileChangeCountDelegate set_maximumTileChangeCountDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.set_maximumTileChangeCountDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_maximumTileChangeCount");

		// Token: 0x040000C3 RID: 195
		private static readonly TilemapCollider2D.get_extrusionFactorDelegate get_extrusionFactorDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_extrusionFactorDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_extrusionFactor");

		// Token: 0x040000C4 RID: 196
		private static readonly TilemapCollider2D.set_extrusionFactorDelegate set_extrusionFactorDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.set_extrusionFactorDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_extrusionFactor");

		// Token: 0x040000C5 RID: 197
		private static readonly TilemapCollider2D.get_hasTilemapChangesDelegate get_hasTilemapChangesDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_hasTilemapChangesDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_hasTilemapChanges");

		// Token: 0x040000C6 RID: 198
		private static readonly TilemapCollider2D.ProcessTilemapChangesDelegate ProcessTilemapChangesDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.ProcessTilemapChangesDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::ProcessTilemapChanges");

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600020A RID: 522
		private delegate bool get_useDelaunayMeshDelegate(IntPtr @this);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate void set_useDelaunayMeshDelegate(IntPtr @this, bool value);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate uint get_maximumTileChangeCountDelegate(IntPtr @this);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate void set_maximumTileChangeCountDelegate(IntPtr @this, uint value);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate float get_extrusionFactorDelegate(IntPtr @this);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate void set_extrusionFactorDelegate(IntPtr @this, float value);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate bool get_hasTilemapChangesDelegate(IntPtr @this);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate void ProcessTilemapChangesDelegate(IntPtr @this);
	}
}
