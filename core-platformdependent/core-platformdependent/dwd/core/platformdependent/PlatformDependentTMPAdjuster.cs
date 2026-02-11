using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x0200001E RID: 30
	public class PlatformDependentTMPAdjuster : PlatformDependentAdjuster
	{
		// Token: 0x06000100 RID: 256 RVA: 0x0000615C File Offset: 0x0000435C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentTMPAdjuster()
		{
			Il2CppClassPointerStore<PlatformDependentTMPAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentTMPAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTMPAdjuster>.NativeClassPtr);
			PlatformDependentTMPAdjuster.NativeFieldInfoPtr_PlatformAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjuster>.NativeClassPtr, "PlatformAdjustments");
			PlatformDependentTMPAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTMPAdjuster>.NativeClassPtr, 100663407);
			PlatformDependentTMPAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTMPAdjuster>.NativeClassPtr, 100663408);
			PlatformDependentTMPAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTMPAdjuster>.NativeClassPtr, 100663409);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000061DC File Offset: 0x000043DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239443, XrefRangeEnd = 1239473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTMPAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006218 File Offset: 0x00004418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239473, XrefRangeEnd = 1239497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTMPAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006254 File Offset: 0x00004454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239497, XrefRangeEnd = 1239505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentTMPAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTMPAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTMPAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002788 File Offset: 0x00000988
		public PlatformDependentTMPAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00006290 File Offset: 0x00004490
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002791 File Offset: 0x00000991
		public unsafe List<PlatformDependentTMPAdjuster.PlatformAdjustmentPair> PlatformAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjuster.NativeFieldInfoPtr_PlatformAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentTMPAdjuster.PlatformAdjustmentPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjuster.NativeFieldInfoPtr_PlatformAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_PlatformAdjustments;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003C RID: 60
		[Serializable]
		public class PlatformAdjustmentPair : Object
		{
			// Token: 0x060001FC RID: 508 RVA: 0x00008BA4 File Offset: 0x00006DA4
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformAdjustmentPair()
			{
				Il2CppClassPointerStore<PlatformDependentTMPAdjuster.PlatformAdjustmentPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentTMPAdjuster>.NativeClassPtr, "PlatformAdjustmentPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTMPAdjuster.PlatformAdjustmentPair>.NativeClassPtr);
				PlatformDependentTMPAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Platform");
				PlatformDependentTMPAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Adjustment");
				PlatformDependentTMPAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentTMPAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTMPAdjuster.PlatformAdjustmentPair>.NativeClassPtr, 100663410);
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00008C0C File Offset: 0x00006E0C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformAdjustmentPair(uint platform, PlatformDependentTMPAdjustment adjustment)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTMPAdjuster.PlatformAdjustmentPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref platform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTMPAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentTMPAdjustment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00002F2B File Offset: 0x0000112B
			public PlatformAdjustmentPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060001FF RID: 511 RVA: 0x00008C68 File Offset: 0x00006E68
			// (set) Token: 0x06000200 RID: 512 RVA: 0x00002F34 File Offset: 0x00001134
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000201 RID: 513 RVA: 0x00008C90 File Offset: 0x00006E90
			// (set) Token: 0x06000202 RID: 514 RVA: 0x00002F4F File Offset: 0x0000114F
			public unsafe PlatformDependentTMPAdjustment Adjustment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentTMPAdjustment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000117 RID: 279
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x04000118 RID: 280
			private static readonly IntPtr NativeFieldInfoPtr_Adjustment;

			// Token: 0x04000119 RID: 281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentTMPAdjustment_0;
		}
	}
}
