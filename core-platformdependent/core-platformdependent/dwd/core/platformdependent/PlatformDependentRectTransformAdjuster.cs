using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x02000018 RID: 24
	public class PlatformDependentRectTransformAdjuster : PlatformDependentAdjuster
	{
		// Token: 0x060000BD RID: 189 RVA: 0x000055C8 File Offset: 0x000037C8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentRectTransformAdjuster()
		{
			Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentRectTransformAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster>.NativeClassPtr);
			PlatformDependentRectTransformAdjuster.NativeFieldInfoPtr_PlatformAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster>.NativeClassPtr, "PlatformAdjustments");
			PlatformDependentRectTransformAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster>.NativeClassPtr, 100663386);
			PlatformDependentRectTransformAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster>.NativeClassPtr, 100663387);
			PlatformDependentRectTransformAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster>.NativeClassPtr, 100663388);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005648 File Offset: 0x00003848
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentRectTransformAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005684 File Offset: 0x00003884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239208, XrefRangeEnd = 1239232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentRectTransformAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000056C0 File Offset: 0x000038C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239232, XrefRangeEnd = 1239240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentRectTransformAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentRectTransformAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002552 File Offset: 0x00000752
		public PlatformDependentRectTransformAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000056FC File Offset: 0x000038FC
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000255B File Offset: 0x0000075B
		public unsafe List<PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair> PlatformAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjuster.NativeFieldInfoPtr_PlatformAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjuster.NativeFieldInfoPtr_PlatformAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_PlatformAdjustments;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000039 RID: 57
		[Serializable]
		public class PlatformAdjustmentPair : Object
		{
			// Token: 0x060001E6 RID: 486 RVA: 0x00008800 File Offset: 0x00006A00
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformAdjustmentPair()
			{
				Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster>.NativeClassPtr, "PlatformAdjustmentPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr);
				PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Platform");
				PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr, "Adjustment");
				PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentRectTransformAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr, 100663389);
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00008868 File Offset: 0x00006A68
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformAdjustmentPair(uint platform, PlatformDependentRectTransformAdjustment adjustment)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref platform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentRectTransformAdjustment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x00002E62 File Offset: 0x00001062
			public PlatformAdjustmentPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x000088C4 File Offset: 0x00006AC4
			// (set) Token: 0x060001EA RID: 490 RVA: 0x00002E6B File Offset: 0x0000106B
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060001EB RID: 491 RVA: 0x000088EC File Offset: 0x00006AEC
			// (set) Token: 0x060001EC RID: 492 RVA: 0x00002E86 File Offset: 0x00001086
			public unsafe PlatformDependentRectTransformAdjustment Adjustment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentRectTransformAdjustment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjuster.PlatformAdjustmentPair.NativeFieldInfoPtr_Adjustment), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeFieldInfoPtr_Adjustment;

			// Token: 0x0400010F RID: 271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentRectTransformAdjustment_0;
		}
	}
}
