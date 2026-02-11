using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x0200000B RID: 11
	public sealed class TileChangeData : ValueType
	{
		// Token: 0x0600011D RID: 285 RVA: 0x0000522C File Offset: 0x0000342C
		// Note: this type is marked as 'beforefieldinit'.
		static TileChangeData()
		{
			Il2CppClassPointerStore<TileChangeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileChangeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileChangeData>.NativeClassPtr);
			TileChangeData.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileChangeData>.NativeClassPtr, "m_Position");
			TileChangeData.NativeFieldInfoPtr_m_TileAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileChangeData>.NativeClassPtr, "m_TileAsset");
			TileChangeData.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileChangeData>.NativeClassPtr, "m_Color");
			TileChangeData.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileChangeData>.NativeClassPtr, "m_Transform");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002AC6 File Offset: 0x00000CC6
		public TileChangeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002ACF File Offset: 0x00000CCF
		public TileChangeData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileChangeData>.NativeClassPtr))
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000052AC File Offset: 0x000034AC
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002AE1 File Offset: 0x00000CE1
		public unsafe Vector3Int m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileChangeData.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileChangeData.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000052D4 File Offset: 0x000034D4
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002AFC File Offset: 0x00000CFC
		public unsafe Object m_TileAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileChangeData.NativeFieldInfoPtr_m_TileAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileChangeData.NativeFieldInfoPtr_m_TileAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00005304 File Offset: 0x00003504
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002B1B File Offset: 0x00000D1B
		public unsafe Color m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileChangeData.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileChangeData.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000532C File Offset: 0x0000352C
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002B36 File Offset: 0x00000D36
		public unsafe Matrix4x4 m_Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileChangeData.NativeFieldInfoPtr_m_Transform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileChangeData.NativeFieldInfoPtr_m_Transform)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00005354 File Offset: 0x00003554
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002B51 File Offset: 0x00000D51
		public Vector3Int position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000536C File Offset: 0x0000356C
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002B5B File Offset: 0x00000D5B
		public TileBase tile
		{
			get
			{
				return this.m_TileAsset.Cast<TileBase>();
			}
			set
			{
				this.m_TileAsset = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000538C File Offset: 0x0000358C
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002B65 File Offset: 0x00000D65
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000053A4 File Offset: 0x000035A4
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002B6F File Offset: 0x00000D6F
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

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_m_TileAsset;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;
	}
}
