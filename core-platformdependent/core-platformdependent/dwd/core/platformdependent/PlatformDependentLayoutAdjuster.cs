using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x02000013 RID: 19
	public class PlatformDependentLayoutAdjuster : PlatformDependentAdjuster
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00004C08 File Offset: 0x00002E08
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentLayoutAdjuster()
		{
			Il2CppClassPointerStore<PlatformDependentLayoutAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentLayoutAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster>.NativeClassPtr);
			PlatformDependentLayoutAdjuster.NativeFieldInfoPtr_PlatformAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster>.NativeClassPtr, "PlatformAdjustments");
			PlatformDependentLayoutAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster>.NativeClassPtr, 100663369);
			PlatformDependentLayoutAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster>.NativeClassPtr, 100663370);
			PlatformDependentLayoutAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster>.NativeClassPtr, 100663371);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004C88 File Offset: 0x00002E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239052, XrefRangeEnd = 1239082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentLayoutAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239082, XrefRangeEnd = 1239106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentLayoutAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004D00 File Offset: 0x00002F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239106, XrefRangeEnd = 1239114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentLayoutAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentLayoutAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000239B File Offset: 0x0000059B
		public PlatformDependentLayoutAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004D3C File Offset: 0x00002F3C
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000023A4 File Offset: 0x000005A4
		public unsafe List<PlatformDependentLayoutAdjuster.PlatformAdjustmentPair> PlatformAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjuster.NativeFieldInfoPtr_PlatformAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentLayoutAdjuster.PlatformAdjustmentPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjuster.NativeFieldInfoPtr_PlatformAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_PlatformAdjustments;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000037 RID: 55
		[Serializable]
		public class PlatformAdjustmentPair : Object
		{
			// Token: 0x060001D8 RID: 472 RVA: 0x000085C8 File Offset: 0x000067C8
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformAdjustmentPair()
			{
				Il2CppClassPointerStore<PlatformDependentLayoutAdjuster.PlatformAdjustmentPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster>.NativeClassPtr, "PlatformAdjustmentPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster.PlatformAdjustmentPair>.NativeClassPtr);
				PlatformDependentLayoutAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Platform");
				PlatformDependentLayoutAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Adjustment");
				PlatformDependentLayoutAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentLayoutAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster.PlatformAdjustmentPair>.NativeClassPtr, 100663372);
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x00008630 File Offset: 0x00006830
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformAdjustmentPair(uint platform, PlatformDependentLayoutAdjustment adjustment)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentLayoutAdjuster.PlatformAdjustmentPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref platform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentLayoutAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentLayoutAdjustment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001DA RID: 474 RVA: 0x00002DDC File Offset: 0x00000FDC
			public PlatformAdjustmentPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060001DB RID: 475 RVA: 0x0000868C File Offset: 0x0000688C
			// (set) Token: 0x060001DC RID: 476 RVA: 0x00002DE5 File Offset: 0x00000FE5
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060001DD RID: 477 RVA: 0x000086B4 File Offset: 0x000068B4
			// (set) Token: 0x060001DE RID: 478 RVA: 0x00002E00 File Offset: 0x00001000
			public unsafe PlatformDependentLayoutAdjustment Adjustment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentLayoutAdjustment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeFieldInfoPtr_Adjustment;

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentLayoutAdjustment_0;
		}
	}
}
