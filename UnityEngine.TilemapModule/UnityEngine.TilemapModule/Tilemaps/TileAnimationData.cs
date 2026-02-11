using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x0200000C RID: 12
	public sealed class TileAnimationData : ValueType
	{
		// Token: 0x06000130 RID: 304 RVA: 0x000053BC File Offset: 0x000035BC
		// Note: this type is marked as 'beforefieldinit'.
		static TileAnimationData()
		{
			Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileAnimationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr);
			TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimatedSprites");
			TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimationSpeed");
			TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimationStartTime");
			TileAnimationData.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_Flags");
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002B79 File Offset: 0x00000D79
		public TileAnimationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002B82 File Offset: 0x00000D82
		public TileAnimationData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr))
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000543C File Offset: 0x0000363C
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002B94 File Offset: 0x00000D94
		public unsafe Il2CppReferenceArray<Sprite> m_AnimatedSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000546C File Offset: 0x0000366C
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002BB3 File Offset: 0x00000DB3
		public unsafe float m_AnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00005494 File Offset: 0x00003694
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002BCE File Offset: 0x00000DCE
		public unsafe float m_AnimationStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000054BC File Offset: 0x000036BC
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002BE9 File Offset: 0x00000DE9
		public unsafe TileAnimationFlags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000054E4 File Offset: 0x000036E4
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002C04 File Offset: 0x00000E04
		public Il2CppReferenceArray<Sprite> animatedSprites
		{
			get
			{
				return this.m_AnimatedSprites;
			}
			set
			{
				this.m_AnimatedSprites = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000054FC File Offset: 0x000036FC
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002C0E File Offset: 0x00000E0E
		public float animationSpeed
		{
			get
			{
				return this.m_AnimationSpeed;
			}
			set
			{
				this.m_AnimationSpeed = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00005514 File Offset: 0x00003714
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002C18 File Offset: 0x00000E18
		public float animationStartTime
		{
			get
			{
				return this.m_AnimationStartTime;
			}
			set
			{
				this.m_AnimationStartTime = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000552C File Offset: 0x0000372C
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002C22 File Offset: 0x00000E22
		public TileAnimationFlags flags
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

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedSprites;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationSpeed;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationStartTime;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;
	}
}
