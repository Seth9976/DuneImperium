using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x02000020 RID: 32
	public class PlatformDependentTransformAdjuster : PlatformDependentAdjuster
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00006618 File Offset: 0x00004818
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentTransformAdjuster()
		{
			Il2CppClassPointerStore<PlatformDependentTransformAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentTransformAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTransformAdjuster>.NativeClassPtr);
			PlatformDependentTransformAdjuster.NativeFieldInfoPtr_PlatformAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTransformAdjuster>.NativeClassPtr, "PlatformAdjustments");
			PlatformDependentTransformAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformAdjuster>.NativeClassPtr, 100663414);
			PlatformDependentTransformAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformAdjuster>.NativeClassPtr, 100663415);
			PlatformDependentTransformAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformAdjuster>.NativeClassPtr, 100663416);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006698 File Offset: 0x00004898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239513, XrefRangeEnd = 1239543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTransformAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000066D4 File Offset: 0x000048D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239543, XrefRangeEnd = 1239567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTransformAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006710 File Offset: 0x00004910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239567, XrefRangeEnd = 1239575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentTransformAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTransformAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTransformAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000289F File Offset: 0x00000A9F
		public PlatformDependentTransformAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000674C File Offset: 0x0000494C
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000028A8 File Offset: 0x00000AA8
		public unsafe List<PlatformDependentTransformAdjuster.PlatformAdjustmentPair> PlatformAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjuster.NativeFieldInfoPtr_PlatformAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentTransformAdjuster.PlatformAdjustmentPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjuster.NativeFieldInfoPtr_PlatformAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_PlatformAdjustments;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003D RID: 61
		[Serializable]
		public class PlatformAdjustmentPair : Object
		{
			// Token: 0x06000203 RID: 515 RVA: 0x00008CC0 File Offset: 0x00006EC0
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformAdjustmentPair()
			{
				Il2CppClassPointerStore<PlatformDependentTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentTransformAdjuster>.NativeClassPtr, "PlatformAdjustmentPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr);
				PlatformDependentTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Platform");
				PlatformDependentTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Adjustment");
				PlatformDependentTransformAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentTransformAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr, 100663417);
			}

			// Token: 0x06000204 RID: 516 RVA: 0x00008D28 File Offset: 0x00006F28
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformAdjustmentPair(uint platform, PlatformDependentTransformAdjustment adjustment)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref platform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTransformAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentTransformAdjustment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000205 RID: 517 RVA: 0x00002F6E File Offset: 0x0000116E
			public PlatformAdjustmentPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000206 RID: 518 RVA: 0x00008D84 File Offset: 0x00006F84
			// (set) Token: 0x06000207 RID: 519 RVA: 0x00002F77 File Offset: 0x00001177
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000208 RID: 520 RVA: 0x00008DAC File Offset: 0x00006FAC
			// (set) Token: 0x06000209 RID: 521 RVA: 0x00002F92 File Offset: 0x00001192
			public unsafe PlatformDependentTransformAdjustment Adjustment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentTransformAdjustment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400011A RID: 282
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeFieldInfoPtr_Adjustment;

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentTransformAdjustment_0;
		}
	}
}
