using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public sealed class Grid : GridLayout
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000025A0 File Offset: 0x000007A0
		public Vector3 GetCellCenterLocal(Vector3Int position)
		{
			return base.CellToLocalInterpolated(position + base.GetLayoutCellCenter());
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000025CC File Offset: 0x000007CC
		public Vector3 GetCellCenterWorld(Vector3Int position)
		{
			return base.LocalToWorld(base.CellToLocalInterpolated(position + base.GetLayoutCellCenter()));
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000025FC File Offset: 0x000007FC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000217F File Offset: 0x0000037F
		public new Vector3 cellSize
		{
			get
			{
				Vector3 vector;
				this.get_cellSize_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_cellSize_Injected(ref value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002614 File Offset: 0x00000814
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002189 File Offset: 0x00000389
		public new Vector3 cellGap
		{
			get
			{
				Vector3 vector;
				this.get_cellGap_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_cellGap_Injected(ref value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002193 File Offset: 0x00000393
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000021A5 File Offset: 0x000003A5
		public new GridLayout.CellLayout cellLayout
		{
			get
			{
				return Grid.get_cellLayoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Grid.set_cellLayoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000021B8 File Offset: 0x000003B8
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000021CA File Offset: 0x000003CA
		public new GridLayout.CellSwizzle cellSwizzle
		{
			get
			{
				return Grid.get_cellSwizzleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Grid.set_cellSwizzleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000262C File Offset: 0x0000082C
		public static Vector3 Swizzle(GridLayout.CellSwizzle swizzle, Vector3 position)
		{
			Vector3 vector;
			Grid.Swizzle_Injected(swizzle, ref position, out vector);
			return vector;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002644 File Offset: 0x00000844
		public static Vector3 InverseSwizzle(GridLayout.CellSwizzle swizzle, Vector3 position)
		{
			Vector3 vector;
			Grid.InverseSwizzle_Injected(swizzle, ref position, out vector);
			return vector;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021DD File Offset: 0x000003DD
		public new void get_cellSize_Injected(out Vector3 ret)
		{
			Grid.get_cellSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021F0 File Offset: 0x000003F0
		public void set_cellSize_Injected(ref Vector3 value)
		{
			Grid.set_cellSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002203 File Offset: 0x00000403
		public new void get_cellGap_Injected(out Vector3 ret)
		{
			Grid.get_cellGap_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002216 File Offset: 0x00000416
		public void set_cellGap_Injected(ref Vector3 value)
		{
			Grid.set_cellGap_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002229 File Offset: 0x00000429
		public static void Swizzle_Injected(GridLayout.CellSwizzle swizzle, ref Vector3 position, out Vector3 ret)
		{
			Grid.Swizzle_InjectedDelegateField(swizzle, ref position, out ret);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002238 File Offset: 0x00000438
		public static void InverseSwizzle_Injected(GridLayout.CellSwizzle swizzle, ref Vector3 position, out Vector3 ret)
		{
			Grid.InverseSwizzle_InjectedDelegateField(swizzle, ref position, out ret);
		}

		// Token: 0x04000011 RID: 17
		private static readonly Grid.get_cellLayoutDelegate get_cellLayoutDelegateField = IL2CPP.ResolveICall<Grid.get_cellLayoutDelegate>("UnityEngine.Grid::get_cellLayout");

		// Token: 0x04000012 RID: 18
		private static readonly Grid.set_cellLayoutDelegate set_cellLayoutDelegateField = IL2CPP.ResolveICall<Grid.set_cellLayoutDelegate>("UnityEngine.Grid::set_cellLayout");

		// Token: 0x04000013 RID: 19
		private static readonly Grid.get_cellSwizzleDelegate get_cellSwizzleDelegateField = IL2CPP.ResolveICall<Grid.get_cellSwizzleDelegate>("UnityEngine.Grid::get_cellSwizzle");

		// Token: 0x04000014 RID: 20
		private static readonly Grid.set_cellSwizzleDelegate set_cellSwizzleDelegateField = IL2CPP.ResolveICall<Grid.set_cellSwizzleDelegate>("UnityEngine.Grid::set_cellSwizzle");

		// Token: 0x04000015 RID: 21
		private static readonly Grid.get_cellSize_InjectedDelegate get_cellSize_InjectedDelegateField = IL2CPP.ResolveICall<Grid.get_cellSize_InjectedDelegate>("UnityEngine.Grid::get_cellSize_Injected");

		// Token: 0x04000016 RID: 22
		private static readonly Grid.set_cellSize_InjectedDelegate set_cellSize_InjectedDelegateField = IL2CPP.ResolveICall<Grid.set_cellSize_InjectedDelegate>("UnityEngine.Grid::set_cellSize_Injected");

		// Token: 0x04000017 RID: 23
		private static readonly Grid.get_cellGap_InjectedDelegate get_cellGap_InjectedDelegateField = IL2CPP.ResolveICall<Grid.get_cellGap_InjectedDelegate>("UnityEngine.Grid::get_cellGap_Injected");

		// Token: 0x04000018 RID: 24
		private static readonly Grid.set_cellGap_InjectedDelegate set_cellGap_InjectedDelegateField = IL2CPP.ResolveICall<Grid.set_cellGap_InjectedDelegate>("UnityEngine.Grid::set_cellGap_Injected");

		// Token: 0x04000019 RID: 25
		private static readonly Grid.Swizzle_InjectedDelegate Swizzle_InjectedDelegateField = IL2CPP.ResolveICall<Grid.Swizzle_InjectedDelegate>("UnityEngine.Grid::Swizzle_Injected");

		// Token: 0x0400001A RID: 26
		private static readonly Grid.InverseSwizzle_InjectedDelegate InverseSwizzle_InjectedDelegateField = IL2CPP.ResolveICall<Grid.InverseSwizzle_InjectedDelegate>("UnityEngine.Grid::InverseSwizzle_Injected");

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000053 RID: 83
		private delegate GridLayout.CellLayout get_cellLayoutDelegate(IntPtr @this);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000055 RID: 85
		private delegate void set_cellLayoutDelegate(IntPtr @this, GridLayout.CellLayout value);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000057 RID: 87
		private delegate GridLayout.CellSwizzle get_cellSwizzleDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000059 RID: 89
		private delegate void set_cellSwizzleDelegate(IntPtr @this, GridLayout.CellSwizzle value);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600005B RID: 91
		private delegate void get_cellSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600005D RID: 93
		private delegate void set_cellSize_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x0600005F RID: 95
		private delegate void get_cellGap_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000061 RID: 97
		private delegate void set_cellGap_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000063 RID: 99
		private delegate void Swizzle_InjectedDelegate(GridLayout.CellSwizzle swizzle, IntPtr position, [Out] IntPtr ret);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000065 RID: 101
		private delegate void InverseSwizzle_InjectedDelegate(GridLayout.CellSwizzle swizzle, IntPtr position, [Out] IntPtr ret);
	}
}
