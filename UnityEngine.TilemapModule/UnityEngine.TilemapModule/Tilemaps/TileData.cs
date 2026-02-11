using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct TileData
	{
		// Token: 0x060000FD RID: 253 RVA: 0x00004CD4 File Offset: 0x00002ED4
		// Note: this type is marked as 'beforefieldinit'.
		static TileData()
		{
			Il2CppClassPointerStore<TileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileData>.NativeClassPtr);
			TileData.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Sprite");
			TileData.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Color");
			TileData.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Transform");
			TileData.NativeFieldInfoPtr_m_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_GameObject");
			TileData.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Flags");
			TileData.NativeFieldInfoPtr_m_ColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_ColliderType");
			TileData.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "Default");
			TileData.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663341);
			TileData.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663342);
			TileData.NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663343);
			TileData.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663344);
			TileData.NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663345);
			TileData.NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663346);
			TileData.NativeMethodInfoPtr_CreateDefault_Private_Static_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663347);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004FA8 File Offset: 0x000031A8
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00004E1C File Offset: 0x0000301C
		public unsafe Sprite sprite
		{
			get
			{
				return Object.ForceLoadFromInstanceID(this.m_Sprite).TryCast<Sprite>();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268970, XrefRangeEnd = 1268975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004FCC File Offset: 0x000031CC
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00004E54 File Offset: 0x00003054
		public unsafe Color color
		{
			get
			{
				return this.m_Color;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00004FE4 File Offset: 0x000031E4
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00004E88 File Offset: 0x00003088
		public unsafe Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004FFC File Offset: 0x000031FC
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00004EBC File Offset: 0x000030BC
		public unsafe GameObject gameObject
		{
			get
			{
				return Object.ForceLoadFromInstanceID(this.m_GameObject).TryCast<GameObject>();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268975, XrefRangeEnd = 1268980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00005020 File Offset: 0x00003220
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00004EF4 File Offset: 0x000030F4
		public unsafe TileFlags flags
		{
			get
			{
				return this.m_Flags;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00005038 File Offset: 0x00003238
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00004F28 File Offset: 0x00003128
		public unsafe Tile.ColliderType colliderType
		{
			get
			{
				return this.m_ColliderType;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 403825, RefRangeEnd = 403834, XrefRangeStart = 403825, XrefRangeEnd = 403834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004F5C File Offset: 0x0000315C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268980, XrefRangeEnd = 1268985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TileData CreateDefault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_CreateDefault_Private_Static_TileData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002A58 File Offset: 0x00000C58
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileData>.NativeClassPtr, ref this));
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00004F8C File Offset: 0x0000318C
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002A6A File Offset: 0x00000C6A
		public unsafe static TileData Default
		{
			get
			{
				TileData tileData;
				IL2CPP.il2cpp_field_static_get_value(TileData.NativeFieldInfoPtr_Default, (void*)(&tileData));
				return tileData;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TileData.NativeFieldInfoPtr_Default, (void*)(&value));
			}
		}

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_m_GameObject;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_m_ColliderType;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Private_Static_TileData_0;

		// Token: 0x040000A5 RID: 165
		[FieldOffset(0)]
		public int m_Sprite;

		// Token: 0x040000A6 RID: 166
		[FieldOffset(4)]
		public Color m_Color;

		// Token: 0x040000A7 RID: 167
		[FieldOffset(20)]
		public Matrix4x4 m_Transform;

		// Token: 0x040000A8 RID: 168
		[FieldOffset(84)]
		public int m_GameObject;

		// Token: 0x040000A9 RID: 169
		[FieldOffset(88)]
		public TileFlags m_Flags;

		// Token: 0x040000AA RID: 170
		[FieldOffset(92)]
		public Tile.ColliderType m_ColliderType;
	}
}
