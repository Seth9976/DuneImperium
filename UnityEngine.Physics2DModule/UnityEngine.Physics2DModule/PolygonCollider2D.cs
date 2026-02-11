using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public sealed class PolygonCollider2D : Collider2D
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00003BC6 File Offset: 0x00001DC6
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003BD8 File Offset: 0x00001DD8
		public bool useDelaunayMesh
		{
			get
			{
				return PolygonCollider2D.get_useDelaunayMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PolygonCollider2D.set_useDelaunayMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00003BEB File Offset: 0x00001DEB
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003BFD File Offset: 0x00001DFD
		public bool autoTiling
		{
			get
			{
				return PolygonCollider2D.get_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PolygonCollider2D.set_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00003C10 File Offset: 0x00001E10
		public int GetTotalPointCount()
		{
			return PolygonCollider2D.GetTotalPointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000BA28 File Offset: 0x00009C28
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00003C22 File Offset: 0x00001E22
		public Il2CppStructArray<Vector2> points
		{
			get
			{
				IntPtr intPtr = PolygonCollider2D.get_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				PolygonCollider2D.set_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00003C3A File Offset: 0x00001E3A
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00003C4C File Offset: 0x00001E4C
		public int pathCount
		{
			get
			{
				return PolygonCollider2D.get_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PolygonCollider2D.set_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000BA54 File Offset: 0x00009C54
		public Il2CppStructArray<Vector2> GetPath(int index)
		{
			bool flag = index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Path {0} does not exist.", index));
			}
			bool flag2 = index < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Path {0} does not exist; negative path index is invalid.", index));
			}
			return this.GetPath_Internal(index);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		public Il2CppStructArray<Vector2> GetPath_Internal(int index)
		{
			IntPtr intPtr = PolygonCollider2D.GetPath_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		public void SetPath(int index, Il2CppStructArray<Vector2> points)
		{
			bool flag = index < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Negative path index {0} is invalid.", index));
			}
			this.SetPath_Internal(index, points);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00003C5F File Offset: 0x00001E5F
		public void SetPath_Internal(int index, Il2CppStructArray<Vector2> points)
		{
			PolygonCollider2D.SetPath_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000BB1C File Offset: 0x00009D1C
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

		// Token: 0x0600038F RID: 911 RVA: 0x00003C78 File Offset: 0x00001E78
		public int GetPathList_Internal(int index, List<Vector2> points)
		{
			return PolygonCollider2D.GetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000BB88 File Offset: 0x00009D88
		public void SetPath(int index, List<Vector2> points)
		{
			bool flag = index < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Negative path index {0} is invalid.", index));
			}
			this.SetPathList_Internal(index, points);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00003C91 File Offset: 0x00001E91
		public void SetPathList_Internal(int index, List<Vector2> points)
		{
			PolygonCollider2D.SetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00003CAA File Offset: 0x00001EAA
		public void CreatePrimitive(int sides)
		{
			this.CreatePrimitive(sides, Vector2.one, Vector2.zero);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00003CBF File Offset: 0x00001EBF
		public void CreatePrimitive(int sides, Vector2 scale)
		{
			this.CreatePrimitive(sides, scale, Vector2.zero);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000BBC0 File Offset: 0x00009DC0
		public void CreatePrimitive(int sides, Vector2 scale, Vector2 offset)
		{
			bool flag = sides < 3;
			if (flag)
			{
				Debug.LogWarning("Cannot create a 2D polygon primitive collider with less than two sides.", this);
			}
			else
			{
				bool flag2 = scale.x <= 0f || scale.y <= 0f;
				if (flag2)
				{
					Debug.LogWarning("Cannot create a 2D polygon primitive collider with an axis scale less than or equal to zero.", this);
				}
				else
				{
					this.CreatePrimitive_Internal(sides, scale, offset, true);
				}
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public void CreatePrimitive_Internal(int sides, Vector2 scale, Vector2 offset, bool autoRefresh)
		{
			this.CreatePrimitive_Internal_Injected(sides, ref scale, ref offset, autoRefresh);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003CDF File Offset: 0x00001EDF
		public void CreatePrimitive_Internal_Injected(int sides, ref Vector2 scale, ref Vector2 offset, bool autoRefresh)
		{
			PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), sides, ref scale, ref offset, autoRefresh);
		}

		// Token: 0x040001C2 RID: 450
		private static readonly PolygonCollider2D.get_useDelaunayMeshDelegate get_useDelaunayMeshDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_useDelaunayMeshDelegate>("UnityEngine.PolygonCollider2D::get_useDelaunayMesh");

		// Token: 0x040001C3 RID: 451
		private static readonly PolygonCollider2D.set_useDelaunayMeshDelegate set_useDelaunayMeshDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_useDelaunayMeshDelegate>("UnityEngine.PolygonCollider2D::set_useDelaunayMesh");

		// Token: 0x040001C4 RID: 452
		private static readonly PolygonCollider2D.get_autoTilingDelegate get_autoTilingDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_autoTilingDelegate>("UnityEngine.PolygonCollider2D::get_autoTiling");

		// Token: 0x040001C5 RID: 453
		private static readonly PolygonCollider2D.set_autoTilingDelegate set_autoTilingDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_autoTilingDelegate>("UnityEngine.PolygonCollider2D::set_autoTiling");

		// Token: 0x040001C6 RID: 454
		private static readonly PolygonCollider2D.GetTotalPointCountDelegate GetTotalPointCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetTotalPointCountDelegate>("UnityEngine.PolygonCollider2D::GetTotalPointCount");

		// Token: 0x040001C7 RID: 455
		private static readonly PolygonCollider2D.get_pointsDelegate get_pointsDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_pointsDelegate>("UnityEngine.PolygonCollider2D::get_points");

		// Token: 0x040001C8 RID: 456
		private static readonly PolygonCollider2D.set_pointsDelegate set_pointsDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_pointsDelegate>("UnityEngine.PolygonCollider2D::set_points");

		// Token: 0x040001C9 RID: 457
		private static readonly PolygonCollider2D.get_pathCountDelegate get_pathCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_pathCountDelegate>("UnityEngine.PolygonCollider2D::get_pathCount");

		// Token: 0x040001CA RID: 458
		private static readonly PolygonCollider2D.set_pathCountDelegate set_pathCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_pathCountDelegate>("UnityEngine.PolygonCollider2D::set_pathCount");

		// Token: 0x040001CB RID: 459
		private static readonly PolygonCollider2D.GetPath_InternalDelegate GetPath_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetPath_InternalDelegate>("UnityEngine.PolygonCollider2D::GetPath_Internal");

		// Token: 0x040001CC RID: 460
		private static readonly PolygonCollider2D.SetPath_InternalDelegate SetPath_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.SetPath_InternalDelegate>("UnityEngine.PolygonCollider2D::SetPath_Internal");

		// Token: 0x040001CD RID: 461
		private static readonly PolygonCollider2D.GetPathList_InternalDelegate GetPathList_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetPathList_InternalDelegate>("UnityEngine.PolygonCollider2D::GetPathList_Internal");

		// Token: 0x040001CE RID: 462
		private static readonly PolygonCollider2D.SetPathList_InternalDelegate SetPathList_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.SetPathList_InternalDelegate>("UnityEngine.PolygonCollider2D::SetPathList_Internal");

		// Token: 0x040001CF RID: 463
		private static readonly PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegate CreatePrimitive_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegate>("UnityEngine.PolygonCollider2D::CreatePrimitive_Internal_Injected");

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x060006B4 RID: 1716
		private delegate bool get_useDelaunayMeshDelegate(IntPtr @this);

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x060006B6 RID: 1718
		private delegate void set_useDelaunayMeshDelegate(IntPtr @this, bool value);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x060006B8 RID: 1720
		private delegate bool get_autoTilingDelegate(IntPtr @this);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x060006BA RID: 1722
		private delegate void set_autoTilingDelegate(IntPtr @this, bool value);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x060006BC RID: 1724
		private delegate int GetTotalPointCountDelegate(IntPtr @this);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x060006BE RID: 1726
		private delegate IntPtr get_pointsDelegate(IntPtr @this);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x060006C0 RID: 1728
		private delegate void set_pointsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x060006C2 RID: 1730
		private delegate int get_pathCountDelegate(IntPtr @this);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x060006C4 RID: 1732
		private delegate void set_pathCountDelegate(IntPtr @this, int value);

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x060006C6 RID: 1734
		private delegate IntPtr GetPath_InternalDelegate(IntPtr @this, int index);

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x060006C8 RID: 1736
		private delegate void SetPath_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x060006CA RID: 1738
		private delegate int GetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x060006CC RID: 1740
		private delegate void SetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x060006CE RID: 1742
		private delegate void CreatePrimitive_Internal_InjectedDelegate(IntPtr @this, int sides, IntPtr scale, IntPtr offset, bool autoRefresh);
	}
}
