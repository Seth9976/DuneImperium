using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public sealed class CompositeCollider2D : Collider2D
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00003CF6 File Offset: 0x00001EF6
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00003D08 File Offset: 0x00001F08
		public CompositeCollider2D.GeometryType geometryType
		{
			get
			{
				return CompositeCollider2D.get_geometryTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_geometryTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00003D1B File Offset: 0x00001F1B
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00003D2D File Offset: 0x00001F2D
		public CompositeCollider2D.GenerationType generationType
		{
			get
			{
				return CompositeCollider2D.get_generationTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_generationTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00003D40 File Offset: 0x00001F40
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00003D52 File Offset: 0x00001F52
		public bool useDelaunayMesh
		{
			get
			{
				return CompositeCollider2D.get_useDelaunayMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_useDelaunayMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00003D65 File Offset: 0x00001F65
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00003D77 File Offset: 0x00001F77
		public float vertexDistance
		{
			get
			{
				return CompositeCollider2D.get_vertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_vertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00003D8A File Offset: 0x00001F8A
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003D9C File Offset: 0x00001F9C
		public float edgeRadius
		{
			get
			{
				return CompositeCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00003DAF File Offset: 0x00001FAF
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003DC1 File Offset: 0x00001FC1
		public float offsetDistance
		{
			get
			{
				return CompositeCollider2D.get_offsetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_offsetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public void GenerateGeometry()
		{
			CompositeCollider2D.GenerateGeometryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000BD40 File Offset: 0x00009F40
		public int GetPathPointCount(int index)
		{
			int num = this.pathCount - 1;
			bool flag = index < 0 || index > num;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, num));
			}
			return this.GetPathPointCount_Internal(index);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00003DE6 File Offset: 0x00001FE6
		public int GetPathPointCount_Internal(int index)
		{
			return CompositeCollider2D.GetPathPointCount_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00003DF9 File Offset: 0x00001FF9
		public int pathCount
		{
			get
			{
				return CompositeCollider2D.get_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00003E0B File Offset: 0x0000200B
		public int pointCount
		{
			get
			{
				return CompositeCollider2D.get_pointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000BD94 File Offset: 0x00009F94
		public int GetPath(int index, Il2CppStructArray<Vector2> points)
		{
			bool flag = index < 0 || index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, this.pathCount - 1));
			}
			bool flag2 = points == null;
			if (flag2)
			{
				throw new ArgumentNullException("points");
			}
			return this.GetPathArray_Internal(index, points);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003E1D File Offset: 0x0000201D
		public int GetPathArray_Internal(int index, Il2CppStructArray<Vector2> points)
		{
			return CompositeCollider2D.GetPathArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000BE00 File Offset: 0x0000A000
		public int GetPath(int index, List<Vector2> points)
		{
			bool flag = index < 0 || index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, this.pathCount - 1));
			}
			bool flag2 = points == null;
			if (flag2)
			{
				throw new ArgumentNullException("points");
			}
			return this.GetPathList_Internal(index, points);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003E36 File Offset: 0x00002036
		public int GetPathList_Internal(int index, List<Vector2> points)
		{
			return CompositeCollider2D.GetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x040001D0 RID: 464
		private static readonly CompositeCollider2D.get_geometryTypeDelegate get_geometryTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_geometryTypeDelegate>("UnityEngine.CompositeCollider2D::get_geometryType");

		// Token: 0x040001D1 RID: 465
		private static readonly CompositeCollider2D.set_geometryTypeDelegate set_geometryTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_geometryTypeDelegate>("UnityEngine.CompositeCollider2D::set_geometryType");

		// Token: 0x040001D2 RID: 466
		private static readonly CompositeCollider2D.get_generationTypeDelegate get_generationTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_generationTypeDelegate>("UnityEngine.CompositeCollider2D::get_generationType");

		// Token: 0x040001D3 RID: 467
		private static readonly CompositeCollider2D.set_generationTypeDelegate set_generationTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_generationTypeDelegate>("UnityEngine.CompositeCollider2D::set_generationType");

		// Token: 0x040001D4 RID: 468
		private static readonly CompositeCollider2D.get_useDelaunayMeshDelegate get_useDelaunayMeshDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_useDelaunayMeshDelegate>("UnityEngine.CompositeCollider2D::get_useDelaunayMesh");

		// Token: 0x040001D5 RID: 469
		private static readonly CompositeCollider2D.set_useDelaunayMeshDelegate set_useDelaunayMeshDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_useDelaunayMeshDelegate>("UnityEngine.CompositeCollider2D::set_useDelaunayMesh");

		// Token: 0x040001D6 RID: 470
		private static readonly CompositeCollider2D.get_vertexDistanceDelegate get_vertexDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_vertexDistanceDelegate>("UnityEngine.CompositeCollider2D::get_vertexDistance");

		// Token: 0x040001D7 RID: 471
		private static readonly CompositeCollider2D.set_vertexDistanceDelegate set_vertexDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_vertexDistanceDelegate>("UnityEngine.CompositeCollider2D::set_vertexDistance");

		// Token: 0x040001D8 RID: 472
		private static readonly CompositeCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_edgeRadiusDelegate>("UnityEngine.CompositeCollider2D::get_edgeRadius");

		// Token: 0x040001D9 RID: 473
		private static readonly CompositeCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_edgeRadiusDelegate>("UnityEngine.CompositeCollider2D::set_edgeRadius");

		// Token: 0x040001DA RID: 474
		private static readonly CompositeCollider2D.get_offsetDistanceDelegate get_offsetDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_offsetDistanceDelegate>("UnityEngine.CompositeCollider2D::get_offsetDistance");

		// Token: 0x040001DB RID: 475
		private static readonly CompositeCollider2D.set_offsetDistanceDelegate set_offsetDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_offsetDistanceDelegate>("UnityEngine.CompositeCollider2D::set_offsetDistance");

		// Token: 0x040001DC RID: 476
		private static readonly CompositeCollider2D.GenerateGeometryDelegate GenerateGeometryDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GenerateGeometryDelegate>("UnityEngine.CompositeCollider2D::GenerateGeometry");

		// Token: 0x040001DD RID: 477
		private static readonly CompositeCollider2D.GetPathPointCount_InternalDelegate GetPathPointCount_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathPointCount_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathPointCount_Internal");

		// Token: 0x040001DE RID: 478
		private static readonly CompositeCollider2D.get_pathCountDelegate get_pathCountDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_pathCountDelegate>("UnityEngine.CompositeCollider2D::get_pathCount");

		// Token: 0x040001DF RID: 479
		private static readonly CompositeCollider2D.get_pointCountDelegate get_pointCountDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_pointCountDelegate>("UnityEngine.CompositeCollider2D::get_pointCount");

		// Token: 0x040001E0 RID: 480
		private static readonly CompositeCollider2D.GetPathArray_InternalDelegate GetPathArray_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathArray_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathArray_Internal");

		// Token: 0x040001E1 RID: 481
		private static readonly CompositeCollider2D.GetPathList_InternalDelegate GetPathList_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathList_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathList_Internal");

		// Token: 0x02000152 RID: 338
		public enum GeometryType
		{
			// Token: 0x040002A4 RID: 676
			Outlines,
			// Token: 0x040002A5 RID: 677
			Polygons
		}

		// Token: 0x02000153 RID: 339
		public enum GenerationType
		{
			// Token: 0x040002A7 RID: 679
			Synchronous,
			// Token: 0x040002A8 RID: 680
			Manual
		}

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x060006D0 RID: 1744
		private delegate CompositeCollider2D.GeometryType get_geometryTypeDelegate(IntPtr @this);

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x060006D2 RID: 1746
		private delegate void set_geometryTypeDelegate(IntPtr @this, CompositeCollider2D.GeometryType value);

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x060006D4 RID: 1748
		private delegate CompositeCollider2D.GenerationType get_generationTypeDelegate(IntPtr @this);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x060006D6 RID: 1750
		private delegate void set_generationTypeDelegate(IntPtr @this, CompositeCollider2D.GenerationType value);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x060006D8 RID: 1752
		private delegate bool get_useDelaunayMeshDelegate(IntPtr @this);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x060006DA RID: 1754
		private delegate void set_useDelaunayMeshDelegate(IntPtr @this, bool value);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x060006DC RID: 1756
		private delegate float get_vertexDistanceDelegate(IntPtr @this);

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x060006DE RID: 1758
		private delegate void set_vertexDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x060006E0 RID: 1760
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x060006E2 RID: 1762
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x060006E4 RID: 1764
		private delegate float get_offsetDistanceDelegate(IntPtr @this);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x060006E6 RID: 1766
		private delegate void set_offsetDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x060006E8 RID: 1768
		private delegate void GenerateGeometryDelegate(IntPtr @this);

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x060006EA RID: 1770
		private delegate int GetPathPointCount_InternalDelegate(IntPtr @this, int index);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x060006EC RID: 1772
		private delegate int get_pathCountDelegate(IntPtr @this);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x060006EE RID: 1774
		private delegate int get_pointCountDelegate(IntPtr @this);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x060006F0 RID: 1776
		private delegate int GetPathArray_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x060006F2 RID: 1778
		private delegate int GetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);
	}
}
