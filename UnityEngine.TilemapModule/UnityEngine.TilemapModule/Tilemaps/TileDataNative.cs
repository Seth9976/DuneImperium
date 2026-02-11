using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct TileDataNative
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00005050 File Offset: 0x00003250
		// Note: this type is marked as 'beforefieldinit'.
		static TileDataNative()
		{
			Il2CppClassPointerStore<TileDataNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileDataNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr);
			TileDataNative.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_Sprite");
			TileDataNative.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_Color");
			TileDataNative.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_Transform");
			TileDataNative.NativeFieldInfoPtr_m_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_GameObject");
			TileDataNative.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_Flags");
			TileDataNative.NativeFieldInfoPtr_m_ColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_ColliderType");
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002A78 File Offset: 0x00000C78
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, ref this));
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000050F8 File Offset: 0x000032F8
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002A8A File Offset: 0x00000C8A
		public int sprite
		{
			get
			{
				return this.m_Sprite;
			}
			set
			{
				this.m_Sprite = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00005110 File Offset: 0x00003310
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002A94 File Offset: 0x00000C94
		public Color color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				this.m_Color = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00005128 File Offset: 0x00003328
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002A9E File Offset: 0x00000C9E
		public Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			set
			{
				this.m_Transform = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00005140 File Offset: 0x00003340
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002AA8 File Offset: 0x00000CA8
		public int gameObject
		{
			get
			{
				return this.m_GameObject;
			}
			set
			{
				this.m_GameObject = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00005158 File Offset: 0x00003358
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public TileFlags flags
		{
			get
			{
				return this.m_Flags;
			}
			set
			{
				this.m_Flags = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00005170 File Offset: 0x00003370
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002ABC File Offset: 0x00000CBC
		public Tile.ColliderType colliderType
		{
			get
			{
				return this.m_ColliderType;
			}
			set
			{
				this.m_ColliderType = value;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005188 File Offset: 0x00003388
		public static implicit operator TileDataNative(TileData td)
		{
			return new TileDataNative
			{
				sprite = ((td.sprite != null) ? td.sprite.GetInstanceID() : 0),
				color = td.color,
				transform = td.transform,
				gameObject = ((td.gameObject != null) ? td.gameObject.GetInstanceID() : 0),
				flags = td.flags,
				colliderType = td.colliderType
			};
		}

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_m_GameObject;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_m_ColliderType;

		// Token: 0x040000B1 RID: 177
		[FieldOffset(0)]
		public int m_Sprite;

		// Token: 0x040000B2 RID: 178
		[FieldOffset(4)]
		public Color m_Color;

		// Token: 0x040000B3 RID: 179
		[FieldOffset(20)]
		public Matrix4x4 m_Transform;

		// Token: 0x040000B4 RID: 180
		[FieldOffset(84)]
		public int m_GameObject;

		// Token: 0x040000B5 RID: 181
		[FieldOffset(88)]
		public TileFlags m_Flags;

		// Token: 0x040000B6 RID: 182
		[FieldOffset(92)]
		public Tile.ColliderType m_ColliderType;
	}
}
