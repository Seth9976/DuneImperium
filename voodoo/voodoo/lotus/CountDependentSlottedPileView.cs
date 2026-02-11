using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000047 RID: 71
	public class CountDependentSlottedPileView : SlottedPileView
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x00017740 File Offset: 0x00015940
		// Note: this type is marked as 'beforefieldinit'.
		static CountDependentSlottedPileView()
		{
			Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "CountDependentSlottedPileView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr);
			CountDependentSlottedPileView.NativeFieldInfoPtr_countSlotOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr, "countSlotOverrides");
			CountDependentSlottedPileView.NativeFieldInfoPtr_defaultSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr, "defaultSlots");
			CountDependentSlottedPileView.NativeFieldInfoPtr_slotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr, "slotCount");
			CountDependentSlottedPileView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr, 100663816);
			CountDependentSlottedPileView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr, 100663817);
			CountDependentSlottedPileView.NativeMethodInfoPtr_handleSlotCount_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr, 100663818);
			CountDependentSlottedPileView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr, 100663819);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000177FC File Offset: 0x000159FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110312, XrefRangeEnd = 1110324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CountDependentSlottedPileView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00017838 File Offset: 0x00015A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110324, XrefRangeEnd = 1110325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CountDependentSlottedPileView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00017874 File Offset: 0x00015A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110325, XrefRangeEnd = 1110341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void handleSlotCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CountDependentSlottedPileView.NativeMethodInfoPtr_handleSlotCount_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000178C0 File Offset: 0x00015AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110341, XrefRangeEnd = 1110342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountDependentSlottedPileView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountDependentSlottedPileView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00004472 File Offset: 0x00002672
		public CountDependentSlottedPileView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000178FC File Offset: 0x00015AFC
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0000447B File Offset: 0x0000267B
		public unsafe Il2CppReferenceArray<CountDependentSlottedPileView.SlotsForCount> countSlotOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountDependentSlottedPileView.NativeFieldInfoPtr_countSlotOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CountDependentSlottedPileView.SlotsForCount>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountDependentSlottedPileView.NativeFieldInfoPtr_countSlotOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0001792C File Offset: 0x00015B2C
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0000449A File Offset: 0x0000269A
		public unsafe Il2CppReferenceArray<Transform> defaultSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountDependentSlottedPileView.NativeFieldInfoPtr_defaultSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountDependentSlottedPileView.NativeFieldInfoPtr_defaultSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0001795C File Offset: 0x00015B5C
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000044B9 File Offset: 0x000026B9
		public unsafe int slotCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountDependentSlottedPileView.NativeFieldInfoPtr_slotCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountDependentSlottedPileView.NativeFieldInfoPtr_slotCount)) = value;
			}
		}

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_countSlotOverrides;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr_defaultSlots;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeFieldInfoPtr_slotCount;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_handleSlotCount_Protected_Virtual_Void_Int32_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000D0 RID: 208
		[Serializable]
		public class SlotsForCount : global::Il2CppSystem.Object
		{
			// Token: 0x06000AF5 RID: 2805 RVA: 0x0002D494 File Offset: 0x0002B694
			// Note: this type is marked as 'beforefieldinit'.
			static SlotsForCount()
			{
				Il2CppClassPointerStore<CountDependentSlottedPileView.SlotsForCount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CountDependentSlottedPileView>.NativeClassPtr, "SlotsForCount");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountDependentSlottedPileView.SlotsForCount>.NativeClassPtr);
				CountDependentSlottedPileView.SlotsForCount.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountDependentSlottedPileView.SlotsForCount>.NativeClassPtr, "slots");
				CountDependentSlottedPileView.SlotsForCount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountDependentSlottedPileView.SlotsForCount>.NativeClassPtr, 100663820);
			}

			// Token: 0x06000AF6 RID: 2806 RVA: 0x0002D4E8 File Offset: 0x0002B6E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SlotsForCount()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountDependentSlottedPileView.SlotsForCount>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountDependentSlottedPileView.SlotsForCount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000AF7 RID: 2807 RVA: 0x000075F4 File Offset: 0x000057F4
			public SlotsForCount(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0002D524 File Offset: 0x0002B724
			// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x000075FD File Offset: 0x000057FD
			public unsafe Il2CppReferenceArray<Transform> slots
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountDependentSlottedPileView.SlotsForCount.NativeFieldInfoPtr_slots);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountDependentSlottedPileView.SlotsForCount.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040006D6 RID: 1750
			private static readonly IntPtr NativeFieldInfoPtr_slots;

			// Token: 0x040006D7 RID: 1751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
