using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class GridLayout : Behaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002248 File Offset: 0x00000448
		// Note: this type is marked as 'beforefieldinit'.
		static GridLayout()
		{
			Il2CppClassPointerStore<GridLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GridModule.dll", "UnityEngine", "GridLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridLayout>.NativeClassPtr);
			GridLayout.NativeMethodInfoPtr_DoNothing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayout>.NativeClassPtr, 100663297);
			GridLayout.get_cellLayoutDelegateField = IL2CPP.ResolveICall<GridLayout.get_cellLayoutDelegate>("UnityEngine.GridLayout::get_cellLayout");
			GridLayout.get_cellSwizzleDelegateField = IL2CPP.ResolveICall<GridLayout.get_cellSwizzleDelegate>("UnityEngine.GridLayout::get_cellSwizzle");
			GridLayout.get_cellSize_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.get_cellSize_InjectedDelegate>("UnityEngine.GridLayout::get_cellSize_Injected");
			GridLayout.get_cellGap_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.get_cellGap_InjectedDelegate>("UnityEngine.GridLayout::get_cellGap_Injected");
			GridLayout.GetBoundsLocal_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.GetBoundsLocal_InjectedDelegate>("UnityEngine.GridLayout::GetBoundsLocal_Injected");
			GridLayout.GetBoundsLocalOriginSize_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.GetBoundsLocalOriginSize_InjectedDelegate>("UnityEngine.GridLayout::GetBoundsLocalOriginSize_Injected");
			GridLayout.CellToLocal_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.CellToLocal_InjectedDelegate>("UnityEngine.GridLayout::CellToLocal_Injected");
			GridLayout.LocalToCell_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.LocalToCell_InjectedDelegate>("UnityEngine.GridLayout::LocalToCell_Injected");
			GridLayout.CellToLocalInterpolated_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.CellToLocalInterpolated_InjectedDelegate>("UnityEngine.GridLayout::CellToLocalInterpolated_Injected");
			GridLayout.LocalToCellInterpolated_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.LocalToCellInterpolated_InjectedDelegate>("UnityEngine.GridLayout::LocalToCellInterpolated_Injected");
			GridLayout.CellToWorld_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.CellToWorld_InjectedDelegate>("UnityEngine.GridLayout::CellToWorld_Injected");
			GridLayout.WorldToCell_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.WorldToCell_InjectedDelegate>("UnityEngine.GridLayout::WorldToCell_Injected");
			GridLayout.LocalToWorld_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.LocalToWorld_InjectedDelegate>("UnityEngine.GridLayout::LocalToWorld_Injected");
			GridLayout.WorldToLocal_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.WorldToLocal_InjectedDelegate>("UnityEngine.GridLayout::WorldToLocal_Injected");
			GridLayout.GetLayoutCellCenter_InjectedDelegateField = IL2CPP.ResolveICall<GridLayout.GetLayoutCellCenter_InjectedDelegate>("UnityEngine.GridLayout::GetLayoutCellCenter_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002370 File Offset: 0x00000570
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoNothing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayout.NativeMethodInfoPtr_DoNothing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public GridLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000023A4 File Offset: 0x000005A4
		public Vector3 cellSize
		{
			get
			{
				Vector3 vector;
				this.get_cellSize_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000023BC File Offset: 0x000005BC
		public Vector3 cellGap
		{
			get
			{
				Vector3 vector;
				this.get_cellGap_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002059 File Offset: 0x00000259
		public GridLayout.CellLayout cellLayout
		{
			get
			{
				return GridLayout.get_cellLayoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000206B File Offset: 0x0000026B
		public GridLayout.CellSwizzle cellSwizzle
		{
			get
			{
				return GridLayout.get_cellSwizzleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023D4 File Offset: 0x000005D4
		public Bounds GetBoundsLocal(Vector3Int cellPosition)
		{
			Bounds bounds;
			this.GetBoundsLocal_Injected(ref cellPosition, out bounds);
			return bounds;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023EC File Offset: 0x000005EC
		public Bounds GetBoundsLocal(Vector3 origin, Vector3 size)
		{
			return this.GetBoundsLocalOriginSize(origin, size);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002408 File Offset: 0x00000608
		public Bounds GetBoundsLocalOriginSize(Vector3 origin, Vector3 size)
		{
			Bounds bounds;
			this.GetBoundsLocalOriginSize_Injected(ref origin, ref size, out bounds);
			return bounds;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002424 File Offset: 0x00000624
		public Vector3 CellToLocal(Vector3Int cellPosition)
		{
			Vector3 vector;
			this.CellToLocal_Injected(ref cellPosition, out vector);
			return vector;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000243C File Offset: 0x0000063C
		public Vector3Int LocalToCell(Vector3 localPosition)
		{
			Vector3Int vector3Int;
			this.LocalToCell_Injected(ref localPosition, out vector3Int);
			return vector3Int;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002454 File Offset: 0x00000654
		public Vector3 CellToLocalInterpolated(Vector3 cellPosition)
		{
			Vector3 vector;
			this.CellToLocalInterpolated_Injected(ref cellPosition, out vector);
			return vector;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000246C File Offset: 0x0000066C
		public Vector3 LocalToCellInterpolated(Vector3 localPosition)
		{
			Vector3 vector;
			this.LocalToCellInterpolated_Injected(ref localPosition, out vector);
			return vector;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002484 File Offset: 0x00000684
		public Vector3 CellToWorld(Vector3Int cellPosition)
		{
			Vector3 vector;
			this.CellToWorld_Injected(ref cellPosition, out vector);
			return vector;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000249C File Offset: 0x0000069C
		public Vector3Int WorldToCell(Vector3 worldPosition)
		{
			Vector3Int vector3Int;
			this.WorldToCell_Injected(ref worldPosition, out vector3Int);
			return vector3Int;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000024B4 File Offset: 0x000006B4
		public Vector3 LocalToWorld(Vector3 localPosition)
		{
			Vector3 vector;
			this.LocalToWorld_Injected(ref localPosition, out vector);
			return vector;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000024CC File Offset: 0x000006CC
		public Vector3 WorldToLocal(Vector3 worldPosition)
		{
			Vector3 vector;
			this.WorldToLocal_Injected(ref worldPosition, out vector);
			return vector;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024E4 File Offset: 0x000006E4
		public Vector3 GetLayoutCellCenter()
		{
			Vector3 vector;
			this.GetLayoutCellCenter_Injected(out vector);
			return vector;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000207D File Offset: 0x0000027D
		public void get_cellSize_Injected(out Vector3 ret)
		{
			GridLayout.get_cellSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002090 File Offset: 0x00000290
		public void get_cellGap_Injected(out Vector3 ret)
		{
			GridLayout.get_cellGap_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020A3 File Offset: 0x000002A3
		public void GetBoundsLocal_Injected(ref Vector3Int cellPosition, out Bounds ret)
		{
			GridLayout.GetBoundsLocal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref cellPosition, out ret);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020B7 File Offset: 0x000002B7
		public void GetBoundsLocalOriginSize_Injected(ref Vector3 origin, ref Vector3 size, out Bounds ret)
		{
			GridLayout.GetBoundsLocalOriginSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref origin, ref size, out ret);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020CC File Offset: 0x000002CC
		public void CellToLocal_Injected(ref Vector3Int cellPosition, out Vector3 ret)
		{
			GridLayout.CellToLocal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref cellPosition, out ret);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020E0 File Offset: 0x000002E0
		public void LocalToCell_Injected(ref Vector3 localPosition, out Vector3Int ret)
		{
			GridLayout.LocalToCell_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref localPosition, out ret);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020F4 File Offset: 0x000002F4
		public void CellToLocalInterpolated_Injected(ref Vector3 cellPosition, out Vector3 ret)
		{
			GridLayout.CellToLocalInterpolated_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref cellPosition, out ret);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002108 File Offset: 0x00000308
		public void LocalToCellInterpolated_Injected(ref Vector3 localPosition, out Vector3 ret)
		{
			GridLayout.LocalToCellInterpolated_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref localPosition, out ret);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000211C File Offset: 0x0000031C
		public void CellToWorld_Injected(ref Vector3Int cellPosition, out Vector3 ret)
		{
			GridLayout.CellToWorld_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref cellPosition, out ret);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002130 File Offset: 0x00000330
		public void WorldToCell_Injected(ref Vector3 worldPosition, out Vector3Int ret)
		{
			GridLayout.WorldToCell_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPosition, out ret);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002144 File Offset: 0x00000344
		public void LocalToWorld_Injected(ref Vector3 localPosition, out Vector3 ret)
		{
			GridLayout.LocalToWorld_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref localPosition, out ret);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002158 File Offset: 0x00000358
		public void WorldToLocal_Injected(ref Vector3 worldPosition, out Vector3 ret)
		{
			GridLayout.WorldToLocal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPosition, out ret);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000216C File Offset: 0x0000036C
		public void GetLayoutCellCenter_Injected(out Vector3 ret)
		{
			GridLayout.GetLayoutCellCenter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_DoNothing_Private_Void_0;

		// Token: 0x04000002 RID: 2
		private static readonly GridLayout.get_cellLayoutDelegate get_cellLayoutDelegateField;

		// Token: 0x04000003 RID: 3
		private static readonly GridLayout.get_cellSwizzleDelegate get_cellSwizzleDelegateField;

		// Token: 0x04000004 RID: 4
		private static readonly GridLayout.get_cellSize_InjectedDelegate get_cellSize_InjectedDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly GridLayout.get_cellGap_InjectedDelegate get_cellGap_InjectedDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly GridLayout.GetBoundsLocal_InjectedDelegate GetBoundsLocal_InjectedDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly GridLayout.GetBoundsLocalOriginSize_InjectedDelegate GetBoundsLocalOriginSize_InjectedDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly GridLayout.CellToLocal_InjectedDelegate CellToLocal_InjectedDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly GridLayout.LocalToCell_InjectedDelegate LocalToCell_InjectedDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly GridLayout.CellToLocalInterpolated_InjectedDelegate CellToLocalInterpolated_InjectedDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly GridLayout.LocalToCellInterpolated_InjectedDelegate LocalToCellInterpolated_InjectedDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly GridLayout.CellToWorld_InjectedDelegate CellToWorld_InjectedDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly GridLayout.WorldToCell_InjectedDelegate WorldToCell_InjectedDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly GridLayout.LocalToWorld_InjectedDelegate LocalToWorld_InjectedDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly GridLayout.WorldToLocal_InjectedDelegate WorldToLocal_InjectedDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly GridLayout.GetLayoutCellCenter_InjectedDelegate GetLayoutCellCenter_InjectedDelegateField;

		// Token: 0x02000004 RID: 4
		public enum CellLayout
		{
			// Token: 0x0400001C RID: 28
			Rectangle,
			// Token: 0x0400001D RID: 29
			Hexagon,
			// Token: 0x0400001E RID: 30
			Isometric,
			// Token: 0x0400001F RID: 31
			IsometricZAsY
		}

		// Token: 0x02000005 RID: 5
		public enum CellSwizzle
		{
			// Token: 0x04000021 RID: 33
			XYZ,
			// Token: 0x04000022 RID: 34
			XZY,
			// Token: 0x04000023 RID: 35
			YXZ,
			// Token: 0x04000024 RID: 36
			YZX,
			// Token: 0x04000025 RID: 37
			ZXY,
			// Token: 0x04000026 RID: 38
			ZYX
		}

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate GridLayout.CellLayout get_cellLayoutDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000037 RID: 55
		private delegate GridLayout.CellSwizzle get_cellSwizzleDelegate(IntPtr @this);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000039 RID: 57
		private delegate void get_cellSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600003B RID: 59
		private delegate void get_cellGap_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600003D RID: 61
		private delegate void GetBoundsLocal_InjectedDelegate(IntPtr @this, IntPtr cellPosition, [Out] IntPtr ret);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600003F RID: 63
		private delegate void GetBoundsLocalOriginSize_InjectedDelegate(IntPtr @this, IntPtr origin, IntPtr size, [Out] IntPtr ret);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000041 RID: 65
		private delegate void CellToLocal_InjectedDelegate(IntPtr @this, IntPtr cellPosition, [Out] IntPtr ret);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000043 RID: 67
		private delegate void LocalToCell_InjectedDelegate(IntPtr @this, IntPtr localPosition, [Out] IntPtr ret);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000045 RID: 69
		private delegate void CellToLocalInterpolated_InjectedDelegate(IntPtr @this, IntPtr cellPosition, [Out] IntPtr ret);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000047 RID: 71
		private delegate void LocalToCellInterpolated_InjectedDelegate(IntPtr @this, IntPtr localPosition, [Out] IntPtr ret);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000049 RID: 73
		private delegate void CellToWorld_InjectedDelegate(IntPtr @this, IntPtr cellPosition, [Out] IntPtr ret);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600004B RID: 75
		private delegate void WorldToCell_InjectedDelegate(IntPtr @this, IntPtr worldPosition, [Out] IntPtr ret);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600004D RID: 77
		private delegate void LocalToWorld_InjectedDelegate(IntPtr @this, IntPtr localPosition, [Out] IntPtr ret);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600004F RID: 79
		private delegate void WorldToLocal_InjectedDelegate(IntPtr @this, IntPtr worldPosition, [Out] IntPtr ret);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000051 RID: 81
		private delegate void GetLayoutCellCenter_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
