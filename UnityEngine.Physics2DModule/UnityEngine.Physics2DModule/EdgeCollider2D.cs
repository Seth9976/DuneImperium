using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200001D RID: 29
	public sealed class EdgeCollider2D : Collider2D
	{
		// Token: 0x06000360 RID: 864 RVA: 0x000039FC File Offset: 0x00001BFC
		public void Reset()
		{
			EdgeCollider2D.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00003A0E File Offset: 0x00001C0E
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00003A20 File Offset: 0x00001C20
		public float edgeRadius
		{
			get
			{
				return EdgeCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00003A33 File Offset: 0x00001C33
		public int edgeCount
		{
			get
			{
				return EdgeCollider2D.get_edgeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00003A45 File Offset: 0x00001C45
		public int pointCount
		{
			get
			{
				return EdgeCollider2D.get_pointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000B854 File Offset: 0x00009A54
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00003A57 File Offset: 0x00001C57
		public Il2CppStructArray<Vector2> points
		{
			get
			{
				IntPtr intPtr = EdgeCollider2D.get_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				EdgeCollider2D.set_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003A6F File Offset: 0x00001C6F
		public int GetPoints(List<Vector2> points)
		{
			return EdgeCollider2D.GetPointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00003A87 File Offset: 0x00001C87
		public bool SetPoints(List<Vector2> points)
		{
			return EdgeCollider2D.SetPointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00003A9F File Offset: 0x00001C9F
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00003AB1 File Offset: 0x00001CB1
		public bool useAdjacentStartPoint
		{
			get
			{
				return EdgeCollider2D.get_useAdjacentStartPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_useAdjacentStartPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00003AC4 File Offset: 0x00001CC4
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00003AD6 File Offset: 0x00001CD6
		public bool useAdjacentEndPoint
		{
			get
			{
				return EdgeCollider2D.get_useAdjacentEndPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_useAdjacentEndPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000B880 File Offset: 0x00009A80
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00003AE9 File Offset: 0x00001CE9
		public Vector2 adjacentStartPoint
		{
			get
			{
				Vector2 vector;
				this.get_adjacentStartPoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_adjacentStartPoint_Injected(ref value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000B898 File Offset: 0x00009A98
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00003AF3 File Offset: 0x00001CF3
		public Vector2 adjacentEndPoint
		{
			get
			{
				Vector2 vector;
				this.get_adjacentEndPoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_adjacentEndPoint_Injected(ref value);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00003AFD File Offset: 0x00001CFD
		public void get_adjacentStartPoint_Injected(out Vector2 ret)
		{
			EdgeCollider2D.get_adjacentStartPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00003B10 File Offset: 0x00001D10
		public void set_adjacentStartPoint_Injected(ref Vector2 value)
		{
			EdgeCollider2D.set_adjacentStartPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003B23 File Offset: 0x00001D23
		public void get_adjacentEndPoint_Injected(out Vector2 ret)
		{
			EdgeCollider2D.get_adjacentEndPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00003B36 File Offset: 0x00001D36
		public void set_adjacentEndPoint_Injected(ref Vector2 value)
		{
			EdgeCollider2D.set_adjacentEndPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001AB RID: 427
		private static readonly EdgeCollider2D.ResetDelegate ResetDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.ResetDelegate>("UnityEngine.EdgeCollider2D::Reset");

		// Token: 0x040001AC RID: 428
		private static readonly EdgeCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_edgeRadiusDelegate>("UnityEngine.EdgeCollider2D::get_edgeRadius");

		// Token: 0x040001AD RID: 429
		private static readonly EdgeCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_edgeRadiusDelegate>("UnityEngine.EdgeCollider2D::set_edgeRadius");

		// Token: 0x040001AE RID: 430
		private static readonly EdgeCollider2D.get_edgeCountDelegate get_edgeCountDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_edgeCountDelegate>("UnityEngine.EdgeCollider2D::get_edgeCount");

		// Token: 0x040001AF RID: 431
		private static readonly EdgeCollider2D.get_pointCountDelegate get_pointCountDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_pointCountDelegate>("UnityEngine.EdgeCollider2D::get_pointCount");

		// Token: 0x040001B0 RID: 432
		private static readonly EdgeCollider2D.get_pointsDelegate get_pointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_pointsDelegate>("UnityEngine.EdgeCollider2D::get_points");

		// Token: 0x040001B1 RID: 433
		private static readonly EdgeCollider2D.set_pointsDelegate set_pointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_pointsDelegate>("UnityEngine.EdgeCollider2D::set_points");

		// Token: 0x040001B2 RID: 434
		private static readonly EdgeCollider2D.GetPointsDelegate GetPointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.GetPointsDelegate>("UnityEngine.EdgeCollider2D::GetPoints");

		// Token: 0x040001B3 RID: 435
		private static readonly EdgeCollider2D.SetPointsDelegate SetPointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.SetPointsDelegate>("UnityEngine.EdgeCollider2D::SetPoints");

		// Token: 0x040001B4 RID: 436
		private static readonly EdgeCollider2D.get_useAdjacentStartPointDelegate get_useAdjacentStartPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_useAdjacentStartPointDelegate>("UnityEngine.EdgeCollider2D::get_useAdjacentStartPoint");

		// Token: 0x040001B5 RID: 437
		private static readonly EdgeCollider2D.set_useAdjacentStartPointDelegate set_useAdjacentStartPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_useAdjacentStartPointDelegate>("UnityEngine.EdgeCollider2D::set_useAdjacentStartPoint");

		// Token: 0x040001B6 RID: 438
		private static readonly EdgeCollider2D.get_useAdjacentEndPointDelegate get_useAdjacentEndPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_useAdjacentEndPointDelegate>("UnityEngine.EdgeCollider2D::get_useAdjacentEndPoint");

		// Token: 0x040001B7 RID: 439
		private static readonly EdgeCollider2D.set_useAdjacentEndPointDelegate set_useAdjacentEndPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_useAdjacentEndPointDelegate>("UnityEngine.EdgeCollider2D::set_useAdjacentEndPoint");

		// Token: 0x040001B8 RID: 440
		private static readonly EdgeCollider2D.get_adjacentStartPoint_InjectedDelegate get_adjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_adjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_adjacentStartPoint_Injected");

		// Token: 0x040001B9 RID: 441
		private static readonly EdgeCollider2D.set_adjacentStartPoint_InjectedDelegate set_adjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_adjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_adjacentStartPoint_Injected");

		// Token: 0x040001BA RID: 442
		private static readonly EdgeCollider2D.get_adjacentEndPoint_InjectedDelegate get_adjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_adjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_adjacentEndPoint_Injected");

		// Token: 0x040001BB RID: 443
		private static readonly EdgeCollider2D.set_adjacentEndPoint_InjectedDelegate set_adjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_adjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_adjacentEndPoint_Injected");

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x06000686 RID: 1670
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x06000688 RID: 1672
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x0600068A RID: 1674
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x0600068C RID: 1676
		private delegate int get_edgeCountDelegate(IntPtr @this);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x0600068E RID: 1678
		private delegate int get_pointCountDelegate(IntPtr @this);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x06000690 RID: 1680
		private delegate IntPtr get_pointsDelegate(IntPtr @this);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x06000692 RID: 1682
		private delegate void set_pointsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x06000694 RID: 1684
		private delegate int GetPointsDelegate(IntPtr @this, IntPtr points);

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x06000696 RID: 1686
		private delegate bool SetPointsDelegate(IntPtr @this, IntPtr points);

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x06000698 RID: 1688
		private delegate bool get_useAdjacentStartPointDelegate(IntPtr @this);

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x0600069A RID: 1690
		private delegate void set_useAdjacentStartPointDelegate(IntPtr @this, bool value);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x0600069C RID: 1692
		private delegate bool get_useAdjacentEndPointDelegate(IntPtr @this);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x0600069E RID: 1694
		private delegate void set_useAdjacentEndPointDelegate(IntPtr @this, bool value);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x060006A0 RID: 1696
		private delegate void get_adjacentStartPoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x060006A2 RID: 1698
		private delegate void set_adjacentStartPoint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x060006A4 RID: 1700
		private delegate void get_adjacentEndPoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x060006A6 RID: 1702
		private delegate void set_adjacentEndPoint_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
