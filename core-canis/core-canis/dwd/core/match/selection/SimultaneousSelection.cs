using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;

namespace dwd.core.match.selection
{
	// Token: 0x0200014C RID: 332
	public class SimultaneousSelection : Selection
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x00060270 File Offset: 0x0005E470
		// Note: this type is marked as 'beforefieldinit'.
		static SimultaneousSelection()
		{
			Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "SimultaneousSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr);
			SimultaneousSelection.NativeFieldInfoPtr_playerSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, "playerSelections");
			SimultaneousSelection.NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_AccountID_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, 100666147);
			SimultaneousSelection.NativeMethodInfoPtr_HasOfferForPlayer_Public_Virtual_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, 100666148);
			SimultaneousSelection.NativeMethodInfoPtr_GetOfferForPlayer_Public_Virtual_ISelectionRoot_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, 100666149);
			SimultaneousSelection.NativeMethodInfoPtr_get_PlayerSelections_Public_get_Dictionary_2_AccountID_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, 100666150);
			SimultaneousSelection.NativeMethodInfoPtr_BeginOffer_Public_Virtual_Void_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, 100666151);
			SimultaneousSelection.NativeMethodInfoPtr_EndOfferSilently_Public_Virtual_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, 100666152);
			SimultaneousSelection.NativeMethodInfoPtr_EndOffer_Public_Virtual_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, 100666153);
			SimultaneousSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, 100666154);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00060354 File Offset: 0x0005E554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 872836, RefRangeEnd = 872837, XrefRangeStart = 872821, XrefRangeEnd = 872836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountID GetAccountIDForSelectionRoot(ISelectionRoot root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelection.NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_AccountID_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000603A4 File Offset: 0x0005E5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872837, XrefRangeEnd = 872841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasOfferForPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelection.NativeMethodInfoPtr_HasOfferForPlayer_Public_Virtual_Boolean_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000603FC File Offset: 0x0005E5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872841, XrefRangeEnd = 872844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionRoot GetOfferForPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelection.NativeMethodInfoPtr_GetOfferForPlayer_Public_Virtual_ISelectionRoot_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr3) : null;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00060458 File Offset: 0x0005E658
		public unsafe Dictionary<AccountID, ISelectionRoot> PlayerSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelection.NativeMethodInfoPtr_get_PlayerSelections_Public_get_Dictionary_2_AccountID_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, ISelectionRoot>>(intPtr3) : null;
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00060498 File Offset: 0x0005E698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872844, XrefRangeEnd = 872861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BeginOffer(SelectionMessage offer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelection.NativeMethodInfoPtr_BeginOffer_Public_Virtual_Void_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000604E8 File Offset: 0x0005E6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872861, XrefRangeEnd = 872887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndOfferSilently(AccountID selectionsAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionsAccountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelection.NativeMethodInfoPtr_EndOfferSilently_Public_Virtual_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00060538 File Offset: 0x0005E738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872887, XrefRangeEnd = 872915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndOffer(ISelectionRoot selectionRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelection.NativeMethodInfoPtr_EndOffer_Public_Virtual_Void_ISelectionRoot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00060588 File Offset: 0x0005E788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872915, XrefRangeEnd = 872923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimultaneousSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000087F2 File Offset: 0x000069F2
		public SimultaneousSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x000605C4 File Offset: 0x0005E7C4
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x000087FB File Offset: 0x000069FB
		public unsafe Dictionary<AccountID, ISelectionRoot> playerSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelection.NativeFieldInfoPtr_playerSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, ISelectionRoot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelection.NativeFieldInfoPtr_playerSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_playerSelections;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_AccountID_ISelectionRoot_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_HasOfferForPlayer_Public_Virtual_Boolean_AccountID_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_GetOfferForPlayer_Public_Virtual_ISelectionRoot_AccountID_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerSelections_Public_get_Dictionary_2_AccountID_ISelectionRoot_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_BeginOffer_Public_Virtual_Void_SelectionMessage_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_EndOfferSilently_Public_Virtual_Void_AccountID_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_EndOffer_Public_Virtual_Void_ISelectionRoot_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DC RID: 732
		[ObfuscatedName("dwd.core.match.selection.SimultaneousSelection+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x060021DF RID: 8671 RVA: 0x000971E4 File Offset: 0x000953E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<SimultaneousSelection.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimultaneousSelection>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousSelection.__c__DisplayClass0_0>.NativeClassPtr);
				SimultaneousSelection.__c__DisplayClass0_0.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousSelection.__c__DisplayClass0_0>.NativeClassPtr, "root");
				SimultaneousSelection.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection.__c__DisplayClass0_0>.NativeClassPtr, 100666155);
				SimultaneousSelection.__c__DisplayClass0_0.NativeMethodInfoPtr__GetAccountIDForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelection.__c__DisplayClass0_0>.NativeClassPtr, 100666156);
			}

			// Token: 0x060021E0 RID: 8672 RVA: 0x0009724C File Offset: 0x0009544C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousSelection.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelection.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E1 RID: 8673 RVA: 0x00097288 File Offset: 0x00095488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872820, XrefRangeEnd = 872821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAccountIDForSelectionRoot_b__0(KeyValuePair<AccountID, ISelectionRoot> ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ps));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelection.__c__DisplayClass0_0.NativeMethodInfoPtr__GetAccountIDForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021E2 RID: 8674 RVA: 0x0000E84A File Offset: 0x0000CA4A
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x060021E3 RID: 8675 RVA: 0x000972DC File Offset: 0x000954DC
			// (set) Token: 0x060021E4 RID: 8676 RVA: 0x0000E853 File Offset: 0x0000CA53
			public unsafe ISelectionRoot root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelection.__c__DisplayClass0_0.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelection.__c__DisplayClass0_0.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400177A RID: 6010
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x0400177B RID: 6011
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400177C RID: 6012
			private static readonly IntPtr NativeMethodInfoPtr__GetAccountIDForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_ISelectionRoot_0;
		}
	}
}
