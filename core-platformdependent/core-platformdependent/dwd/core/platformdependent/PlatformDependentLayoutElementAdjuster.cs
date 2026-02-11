using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x02000015 RID: 21
	public class PlatformDependentLayoutElementAdjuster : PlatformDependentAdjuster
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00004F34 File Offset: 0x00003134
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentLayoutElementAdjuster()
		{
			Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentLayoutElementAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster>.NativeClassPtr);
			PlatformDependentLayoutElementAdjuster.NativeFieldInfoPtr_PlatformAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster>.NativeClassPtr, "PlatformAdjustments");
			PlatformDependentLayoutElementAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster>.NativeClassPtr, 100663376);
			PlatformDependentLayoutElementAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster>.NativeClassPtr, 100663377);
			PlatformDependentLayoutElementAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004FB4 File Offset: 0x000031B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239120, XrefRangeEnd = 1239150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentLayoutElementAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004FF0 File Offset: 0x000031F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239150, XrefRangeEnd = 1239174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentLayoutElementAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000502C File Offset: 0x0000322C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239174, XrefRangeEnd = 1239182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentLayoutElementAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentLayoutElementAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002406 File Offset: 0x00000606
		public PlatformDependentLayoutElementAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00005068 File Offset: 0x00003268
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000240F File Offset: 0x0000060F
		public unsafe List<PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair> PlatformAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjuster.NativeFieldInfoPtr_PlatformAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjuster.NativeFieldInfoPtr_PlatformAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_PlatformAdjustments;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000038 RID: 56
		[Serializable]
		public class PlatformAdjustmentPair : Object
		{
			// Token: 0x060001DF RID: 479 RVA: 0x000086E4 File Offset: 0x000068E4
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformAdjustmentPair()
			{
				Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster>.NativeClassPtr, "PlatformAdjustmentPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair>.NativeClassPtr);
				PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Platform");
				PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Adjustment");
				PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentLayoutElementAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair>.NativeClassPtr, 100663379);
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x0000874C File Offset: 0x0000694C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformAdjustmentPair(uint platform, PlatformDependentLayoutElementAdjustment adjustment)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref platform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentLayoutElementAdjustment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x00002E1F File Offset: 0x0000101F
			public PlatformAdjustmentPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060001E2 RID: 482 RVA: 0x000087A8 File Offset: 0x000069A8
			// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002E28 File Offset: 0x00001028
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x000087D0 File Offset: 0x000069D0
			// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002E43 File Offset: 0x00001043
			public unsafe PlatformDependentLayoutElementAdjustment Adjustment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentLayoutElementAdjustment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeFieldInfoPtr_Adjustment;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentLayoutElementAdjustment_0;
		}
	}
}
