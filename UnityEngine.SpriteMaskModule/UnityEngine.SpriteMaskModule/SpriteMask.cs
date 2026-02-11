using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public sealed class SpriteMask : Renderer
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002059 File Offset: 0x00000259
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000206B File Offset: 0x0000026B
		public int frontSortingLayerID
		{
			get
			{
				return SpriteMask.get_frontSortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_frontSortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002090 File Offset: 0x00000290
		public int frontSortingOrder
		{
			get
			{
				return SpriteMask.get_frontSortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_frontSortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020A3 File Offset: 0x000002A3
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020B5 File Offset: 0x000002B5
		public int backSortingLayerID
		{
			get
			{
				return SpriteMask.get_backSortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_backSortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020C8 File Offset: 0x000002C8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020DA File Offset: 0x000002DA
		public int backSortingOrder
		{
			get
			{
				return SpriteMask.get_backSortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_backSortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020ED File Offset: 0x000002ED
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020FF File Offset: 0x000002FF
		public float alphaCutoff
		{
			get
			{
				return SpriteMask.get_alphaCutoffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_alphaCutoffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000236C File Offset: 0x0000056C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002112 File Offset: 0x00000312
		public Sprite sprite
		{
			get
			{
				IntPtr intPtr = SpriteMask.get_spriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				SpriteMask.set_spriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000213C File Offset: 0x0000033C
		public bool isCustomRangeActive
		{
			get
			{
				return SpriteMask.get_isCustomRangeActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_isCustomRangeActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000214F File Offset: 0x0000034F
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002161 File Offset: 0x00000361
		public SpriteSortPoint spriteSortPoint
		{
			get
			{
				return SpriteMask.get_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteMask.set_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002398 File Offset: 0x00000598
		public Bounds GetSpriteBounds()
		{
			Bounds bounds;
			this.GetSpriteBounds_Injected(out bounds);
			return bounds;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002174 File Offset: 0x00000374
		public void GetSpriteBounds_Injected(out Bounds ret)
		{
			SpriteMask.GetSpriteBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000003 RID: 3
		private static readonly SpriteMask.get_frontSortingLayerIDDelegate get_frontSortingLayerIDDelegateField = IL2CPP.ResolveICall<SpriteMask.get_frontSortingLayerIDDelegate>("UnityEngine.SpriteMask::get_frontSortingLayerID");

		// Token: 0x04000004 RID: 4
		private static readonly SpriteMask.set_frontSortingLayerIDDelegate set_frontSortingLayerIDDelegateField = IL2CPP.ResolveICall<SpriteMask.set_frontSortingLayerIDDelegate>("UnityEngine.SpriteMask::set_frontSortingLayerID");

		// Token: 0x04000005 RID: 5
		private static readonly SpriteMask.get_frontSortingOrderDelegate get_frontSortingOrderDelegateField = IL2CPP.ResolveICall<SpriteMask.get_frontSortingOrderDelegate>("UnityEngine.SpriteMask::get_frontSortingOrder");

		// Token: 0x04000006 RID: 6
		private static readonly SpriteMask.set_frontSortingOrderDelegate set_frontSortingOrderDelegateField = IL2CPP.ResolveICall<SpriteMask.set_frontSortingOrderDelegate>("UnityEngine.SpriteMask::set_frontSortingOrder");

		// Token: 0x04000007 RID: 7
		private static readonly SpriteMask.get_backSortingLayerIDDelegate get_backSortingLayerIDDelegateField = IL2CPP.ResolveICall<SpriteMask.get_backSortingLayerIDDelegate>("UnityEngine.SpriteMask::get_backSortingLayerID");

		// Token: 0x04000008 RID: 8
		private static readonly SpriteMask.set_backSortingLayerIDDelegate set_backSortingLayerIDDelegateField = IL2CPP.ResolveICall<SpriteMask.set_backSortingLayerIDDelegate>("UnityEngine.SpriteMask::set_backSortingLayerID");

		// Token: 0x04000009 RID: 9
		private static readonly SpriteMask.get_backSortingOrderDelegate get_backSortingOrderDelegateField = IL2CPP.ResolveICall<SpriteMask.get_backSortingOrderDelegate>("UnityEngine.SpriteMask::get_backSortingOrder");

		// Token: 0x0400000A RID: 10
		private static readonly SpriteMask.set_backSortingOrderDelegate set_backSortingOrderDelegateField = IL2CPP.ResolveICall<SpriteMask.set_backSortingOrderDelegate>("UnityEngine.SpriteMask::set_backSortingOrder");

		// Token: 0x0400000B RID: 11
		private static readonly SpriteMask.get_alphaCutoffDelegate get_alphaCutoffDelegateField = IL2CPP.ResolveICall<SpriteMask.get_alphaCutoffDelegate>("UnityEngine.SpriteMask::get_alphaCutoff");

		// Token: 0x0400000C RID: 12
		private static readonly SpriteMask.set_alphaCutoffDelegate set_alphaCutoffDelegateField = IL2CPP.ResolveICall<SpriteMask.set_alphaCutoffDelegate>("UnityEngine.SpriteMask::set_alphaCutoff");

		// Token: 0x0400000D RID: 13
		private static readonly SpriteMask.get_spriteDelegate get_spriteDelegateField = IL2CPP.ResolveICall<SpriteMask.get_spriteDelegate>("UnityEngine.SpriteMask::get_sprite");

		// Token: 0x0400000E RID: 14
		private static readonly SpriteMask.set_spriteDelegate set_spriteDelegateField = IL2CPP.ResolveICall<SpriteMask.set_spriteDelegate>("UnityEngine.SpriteMask::set_sprite");

		// Token: 0x0400000F RID: 15
		private static readonly SpriteMask.get_isCustomRangeActiveDelegate get_isCustomRangeActiveDelegateField = IL2CPP.ResolveICall<SpriteMask.get_isCustomRangeActiveDelegate>("UnityEngine.SpriteMask::get_isCustomRangeActive");

		// Token: 0x04000010 RID: 16
		private static readonly SpriteMask.set_isCustomRangeActiveDelegate set_isCustomRangeActiveDelegateField = IL2CPP.ResolveICall<SpriteMask.set_isCustomRangeActiveDelegate>("UnityEngine.SpriteMask::set_isCustomRangeActive");

		// Token: 0x04000011 RID: 17
		private static readonly SpriteMask.get_spriteSortPointDelegate get_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteMask.get_spriteSortPointDelegate>("UnityEngine.SpriteMask::get_spriteSortPoint");

		// Token: 0x04000012 RID: 18
		private static readonly SpriteMask.set_spriteSortPointDelegate set_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteMask.set_spriteSortPointDelegate>("UnityEngine.SpriteMask::set_spriteSortPoint");

		// Token: 0x04000013 RID: 19
		private static readonly SpriteMask.GetSpriteBounds_InjectedDelegate GetSpriteBounds_InjectedDelegateField = IL2CPP.ResolveICall<SpriteMask.GetSpriteBounds_InjectedDelegate>("UnityEngine.SpriteMask::GetSpriteBounds_Injected");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000019 RID: 25
		private delegate int get_frontSortingLayerIDDelegate(IntPtr @this);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600001B RID: 27
		private delegate void set_frontSortingLayerIDDelegate(IntPtr @this, int value);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600001D RID: 29
		private delegate int get_frontSortingOrderDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600001F RID: 31
		private delegate void set_frontSortingOrderDelegate(IntPtr @this, int value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000021 RID: 33
		private delegate int get_backSortingLayerIDDelegate(IntPtr @this);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000023 RID: 35
		private delegate void set_backSortingLayerIDDelegate(IntPtr @this, int value);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000025 RID: 37
		private delegate int get_backSortingOrderDelegate(IntPtr @this);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000027 RID: 39
		private delegate void set_backSortingOrderDelegate(IntPtr @this, int value);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000029 RID: 41
		private delegate float get_alphaCutoffDelegate(IntPtr @this);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600002B RID: 43
		private delegate void set_alphaCutoffDelegate(IntPtr @this, float value);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600002D RID: 45
		private delegate IntPtr get_spriteDelegate(IntPtr @this);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600002F RID: 47
		private delegate void set_spriteDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000031 RID: 49
		private delegate bool get_isCustomRangeActiveDelegate(IntPtr @this);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000033 RID: 51
		private delegate void set_isCustomRangeActiveDelegate(IntPtr @this, bool value);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate SpriteSortPoint get_spriteSortPointDelegate(IntPtr @this);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000037 RID: 55
		private delegate void set_spriteSortPointDelegate(IntPtr @this, SpriteSortPoint value);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000039 RID: 57
		private delegate void GetSpriteBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
