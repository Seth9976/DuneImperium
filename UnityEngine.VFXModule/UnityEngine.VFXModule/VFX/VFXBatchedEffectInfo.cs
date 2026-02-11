using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x02000005 RID: 5
	public sealed class VFXBatchedEffectInfo : ValueType
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00003E4C File Offset: 0x0000204C
		// Note: this type is marked as 'beforefieldinit'.
		static VFXBatchedEffectInfo()
		{
			Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXBatchedEffectInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr);
			VFXBatchedEffectInfo.NativeFieldInfoPtr_vfxAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "vfxAsset");
			VFXBatchedEffectInfo.NativeFieldInfoPtr_activeBatchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "activeBatchCount");
			VFXBatchedEffectInfo.NativeFieldInfoPtr_inactiveBatchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "inactiveBatchCount");
			VFXBatchedEffectInfo.NativeFieldInfoPtr_activeInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "activeInstanceCount");
			VFXBatchedEffectInfo.NativeFieldInfoPtr_unbatchedInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "unbatchedInstanceCount");
			VFXBatchedEffectInfo.NativeFieldInfoPtr_totalInstanceCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "totalInstanceCapacity");
			VFXBatchedEffectInfo.NativeFieldInfoPtr_maxInstancePerBatchCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "maxInstancePerBatchCapacity");
			VFXBatchedEffectInfo.NativeFieldInfoPtr_totalGPUSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "totalGPUSizeInBytes");
			VFXBatchedEffectInfo.NativeFieldInfoPtr_totalCPUSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "totalCPUSizeInBytes");
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000246A File Offset: 0x0000066A
		public VFXBatchedEffectInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002473 File Offset: 0x00000673
		public VFXBatchedEffectInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003F30 File Offset: 0x00002130
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002485 File Offset: 0x00000685
		public unsafe VisualEffectAsset vfxAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_vfxAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualEffectAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_vfxAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003F60 File Offset: 0x00002160
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000024A4 File Offset: 0x000006A4
		public unsafe uint activeBatchCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_activeBatchCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_activeBatchCount)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003F88 File Offset: 0x00002188
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000024BF File Offset: 0x000006BF
		public unsafe uint inactiveBatchCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_inactiveBatchCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_inactiveBatchCount)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003FB0 File Offset: 0x000021B0
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000024DA File Offset: 0x000006DA
		public unsafe uint activeInstanceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_activeInstanceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_activeInstanceCount)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003FD8 File Offset: 0x000021D8
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000024F5 File Offset: 0x000006F5
		public unsafe uint unbatchedInstanceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_unbatchedInstanceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_unbatchedInstanceCount)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004000 File Offset: 0x00002200
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002510 File Offset: 0x00000710
		public unsafe uint totalInstanceCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_totalInstanceCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_totalInstanceCapacity)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00004028 File Offset: 0x00002228
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000252B File Offset: 0x0000072B
		public unsafe uint maxInstancePerBatchCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_maxInstancePerBatchCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_maxInstancePerBatchCapacity)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004050 File Offset: 0x00002250
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002546 File Offset: 0x00000746
		public unsafe ulong totalGPUSizeInBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_totalGPUSizeInBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_totalGPUSizeInBytes)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004078 File Offset: 0x00002278
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002561 File Offset: 0x00000761
		public unsafe ulong totalCPUSizeInBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_totalCPUSizeInBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXBatchedEffectInfo.NativeFieldInfoPtr_totalCPUSizeInBytes)) = value;
			}
		}

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_vfxAsset;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_activeBatchCount;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_inactiveBatchCount;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_activeInstanceCount;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_unbatchedInstanceCount;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_totalInstanceCapacity;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_maxInstancePerBatchCapacity;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_totalGPUSizeInBytes;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_totalCPUSizeInBytes;
	}
}
