using System;
using boardgames.menus.prompts;
using boardgames.utils;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000EC RID: 236
	public class WormWaitingForPlayersPromptBehaviour : WaitingForPlayersPromptBehaviour
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x0003805C File Offset: 0x0003625C
		// Note: this type is marked as 'beforefieldinit'.
		static WormWaitingForPlayersPromptBehaviour()
		{
			Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormWaitingForPlayersPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr);
			WormWaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, "iapStoreBehaviour");
			WormWaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_productUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, "productUtils");
			WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_CanStartEarly_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, 100664736);
			WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_OwnershipRequirementsMet_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, 100664737);
			WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, 100664738);
			WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_PopulateDefaultMetadata_Public_Virtual_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, 100664739);
			WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, 100664740);
			WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__get_OwnershipRequirementsMet_b__3_0_Private_Boolean_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, 100664741);
			WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__PopulateDefaultMetadata_b__7_0_Private_Boolean_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, 100664742);
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00038140 File Offset: 0x00036340
		public unsafe override bool CanStartEarly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701657, XrefRangeEnd = 701658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_CanStartEarly_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00038188 File Offset: 0x00036388
		public unsafe override bool OwnershipRequirementsMet
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701658, XrefRangeEnd = 701678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_OwnershipRequirementsMet_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x000381D0 File Offset: 0x000363D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701678, XrefRangeEnd = 701687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0003820C File Offset: 0x0003640C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701687, XrefRangeEnd = 701730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateDefaultMetadata(Dictionary<string, string> joinMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joinMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_PopulateDefaultMetadata_Public_Virtual_Void_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0003825C File Offset: 0x0003645C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701730, XrefRangeEnd = 701731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWaitingForPlayersPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00038298 File Offset: 0x00036498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701731, XrefRangeEnd = 701735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_OwnershipRequirementsMet_b__3_0(Set requiredSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requiredSet;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__get_OwnershipRequirementsMet_b__3_0_Private_Boolean_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000382E4 File Offset: 0x000364E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701735, XrefRangeEnd = 701749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PopulateDefaultMetadata_b__7_0(PieceColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__PopulateDefaultMetadata_b__7_0_Private_Boolean_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000077EA File Offset: 0x000059EA
		public WormWaitingForPlayersPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00038330 File Offset: 0x00036530
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000077F3 File Offset: 0x000059F3
		public unsafe IAPStoreBehaviour iapStoreBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00038360 File Offset: 0x00036560
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00007812 File Offset: 0x00005A12
		public unsafe ProductUtils productUtils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_productUtils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_productUtils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_productUtils;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_get_CanStartEarly_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnershipRequirementsMet_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_PopulateDefaultMetadata_Public_Virtual_Void_Dictionary_2_String_String_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr__get_OwnershipRequirementsMet_b__3_0_Private_Boolean_Set_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr__PopulateDefaultMetadata_b__7_0_Private_Boolean_PieceColor_0;

		// Token: 0x02000350 RID: 848
		[ObfuscatedName("worm.match.prompts.behaviours.WormWaitingForPlayersPromptBehaviour+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600224A RID: 8778 RVA: 0x00080540 File Offset: 0x0007E740
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr);
				WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "c");
				WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664743);
				WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__PopulateDefaultMetadata_b__1_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664744);
			}

			// Token: 0x0600224B RID: 8779 RVA: 0x000805A8 File Offset: 0x0007E7A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600224C RID: 8780 RVA: 0x000805E4 File Offset: 0x0007E7E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701653, XrefRangeEnd = 701657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PopulateDefaultMetadata_b__1(SubscriptionProvider s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__PopulateDefaultMetadata_b__1_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600224D RID: 8781 RVA: 0x00013396 File Offset: 0x00011596
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x0600224E RID: 8782 RVA: 0x00080634 File Offset: 0x0007E834
			// (set) Token: 0x0600224F RID: 8783 RVA: 0x0001339F File Offset: 0x0001159F
			public unsafe PieceColor c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x040013BC RID: 5052
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040013BD RID: 5053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013BE RID: 5054
			private static readonly IntPtr NativeMethodInfoPtr__PopulateDefaultMetadata_b__1_Internal_Boolean_SubscriptionProvider_0;
		}
	}
}
