using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x02000010 RID: 16
	public class PlatformDependentGridLayoutAdjuster : PlatformDependentAdjuster
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000042B4 File Offset: 0x000024B4
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentGridLayoutAdjuster()
		{
			Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentGridLayoutAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster>.NativeClassPtr);
			PlatformDependentGridLayoutAdjuster.NativeFieldInfoPtr_PlatformAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster>.NativeClassPtr, "PlatformAdjustments");
			PlatformDependentGridLayoutAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster>.NativeClassPtr, 100663347);
			PlatformDependentGridLayoutAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster>.NativeClassPtr, 100663348);
			PlatformDependentGridLayoutAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster>.NativeClassPtr, 100663349);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004334 File Offset: 0x00002534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238891, XrefRangeEnd = 1238921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentGridLayoutAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004370 File Offset: 0x00002570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238921, XrefRangeEnd = 1238945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentGridLayoutAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000043AC File Offset: 0x000025AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238945, XrefRangeEnd = 1238953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentGridLayoutAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentGridLayoutAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000022B3 File Offset: 0x000004B3
		public PlatformDependentGridLayoutAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000043E8 File Offset: 0x000025E8
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000022BC File Offset: 0x000004BC
		public unsafe List<PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair> PlatformAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjuster.NativeFieldInfoPtr_PlatformAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjuster.NativeFieldInfoPtr_PlatformAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_PlatformAdjustments;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000034 RID: 52
		[Serializable]
		public class PlatformGridAdjustmentPair : Object
		{
			// Token: 0x060001CF RID: 463 RVA: 0x00008404 File Offset: 0x00006604
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformGridAdjustmentPair()
			{
				Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster>.NativeClassPtr, "PlatformGridAdjustmentPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair>.NativeClassPtr);
				PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair>.NativeClassPtr, "Platform");
				PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair.NativeFieldInfoPtr_Adjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair>.NativeClassPtr, "Adjustment");
				PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentGridLayoutAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair>.NativeClassPtr, 100663350);
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x0000846C File Offset: 0x0000666C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformGridAdjustmentPair(uint platform, PlatformDependentGridLayoutAdjustment adjustment)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref platform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentGridLayoutAdjustment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x00002D99 File Offset: 0x00000F99
			public PlatformGridAdjustmentPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x000084C8 File Offset: 0x000066C8
			// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002DA2 File Offset: 0x00000FA2
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060001D4 RID: 468 RVA: 0x000084F0 File Offset: 0x000066F0
			// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002DBD File Offset: 0x00000FBD
			public unsafe PlatformDependentGridLayoutAdjustment Adjustment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair.NativeFieldInfoPtr_Adjustment);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentGridLayoutAdjustment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjuster.PlatformGridAdjustmentPair.NativeFieldInfoPtr_Adjustment), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000102 RID: 258
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x04000103 RID: 259
			private static readonly IntPtr NativeFieldInfoPtr_Adjustment;

			// Token: 0x04000104 RID: 260
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentGridLayoutAdjustment_0;
		}
	}
}
