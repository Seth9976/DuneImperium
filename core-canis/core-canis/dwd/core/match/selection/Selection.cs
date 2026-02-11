using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.messages;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.match.selection
{
	// Token: 0x02000148 RID: 328
	public class Selection : MonoBehaviour
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x0005E260 File Offset: 0x0005C460
		// Note: this type is marked as 'beforefieldinit'.
		static Selection()
		{
			Il2CppClassPointerStore<Selection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "Selection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Selection>.NativeClassPtr);
			Selection.NativeFieldInfoPtr_Logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection>.NativeClassPtr, "Logging");
			Selection.NativeFieldInfoPtr__OfferMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection>.NativeClassPtr, "<OfferMessage>k__BackingField");
			Selection.NativeFieldInfoPtr__CurrentOffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection>.NativeClassPtr, "<CurrentOffer>k__BackingField");
			Selection.NativeFieldInfoPtr_SelectionBegan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection>.NativeClassPtr, "SelectionBegan");
			Selection.NativeFieldInfoPtr_SelectionEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection>.NativeClassPtr, "SelectionEnded");
			Selection.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection>.NativeClassPtr, "factory");
			Selection.NativeFieldInfoPtr_choiceResponders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection>.NativeClassPtr, "choiceResponders");
			Selection.NativeMethodInfoPtr_get_OfferMessage_Public_get_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666066);
			Selection.NativeMethodInfoPtr_set_OfferMessage_Protected_set_Void_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666067);
			Selection.NativeMethodInfoPtr_get_CurrentOffer_Public_get_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666068);
			Selection.NativeMethodInfoPtr_set_CurrentOffer_Protected_set_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666069);
			Selection.NativeMethodInfoPtr_get_CurrentChoice_Public_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666070);
			Selection.NativeMethodInfoPtr_HasOfferForPlayer_Public_Virtual_New_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666071);
			Selection.NativeMethodInfoPtr_GetOfferForPlayer_Public_Virtual_New_ISelectionRoot_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666072);
			Selection.NativeMethodInfoPtr_add_SelectionBegan_Public_add_Void_Action_1_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666073);
			Selection.NativeMethodInfoPtr_remove_SelectionBegan_Public_rem_Void_Action_1_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666074);
			Selection.NativeMethodInfoPtr_add_SelectionEnded_Public_add_Void_Action_1_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666075);
			Selection.NativeMethodInfoPtr_remove_SelectionEnded_Public_rem_Void_Action_1_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666076);
			Selection.NativeMethodInfoPtr_Get_Public_Static_Selection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666077);
			Selection.NativeMethodInfoPtr_RegisterResponder_Public_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666078);
			Selection.NativeMethodInfoPtr_UnregisterResponder_Public_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666079);
			Selection.NativeMethodInfoPtr_OverrideFactory_Public_Void_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666080);
			Selection.NativeMethodInfoPtr_BeginOffer_Public_Virtual_New_Void_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666081);
			Selection.NativeMethodInfoPtr_EndOfferSilently_Public_Virtual_New_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666082);
			Selection.NativeMethodInfoPtr_EndOffer_Public_Virtual_New_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666083);
			Selection.NativeMethodInfoPtr_beginListeningToOffer_Protected_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666084);
			Selection.NativeMethodInfoPtr_stopListeningToOffer_Protected_Void_ISelectionRoot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666085);
			Selection.NativeMethodInfoPtr_newChoice_Protected_Void_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666086);
			Selection.NativeMethodInfoPtr_offerSent_Private_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666087);
			Selection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection>.NativeClassPtr, 100666088);
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x0005E4E8 File Offset: 0x0005C6E8
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x0005E528 File Offset: 0x0005C728
		public unsafe SelectionMessage OfferMessage
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_get_OfferMessage_Public_get_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_set_OfferMessage_Protected_set_Void_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0005E56C File Offset: 0x0005C76C
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x0005E5AC File Offset: 0x0005C7AC
		public unsafe ISelectionRoot CurrentOffer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_get_CurrentOffer_Public_get_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_set_CurrentOffer_Protected_set_Void_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0005E5F0 File Offset: 0x0005C7F0
		public unsafe ISelectionNode CurrentChoice
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 872036, RefRangeEnd = 872046, XrefRangeStart = 872033, XrefRangeEnd = 872036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_get_CurrentChoice_Public_get_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0005E630 File Offset: 0x0005C830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 480628, RefRangeEnd = 480631, XrefRangeStart = 480628, XrefRangeEnd = 480631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasOfferForPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selection.NativeMethodInfoPtr_HasOfferForPlayer_Public_Virtual_New_Boolean_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0005E688 File Offset: 0x0005C888
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionRoot GetOfferForPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selection.NativeMethodInfoPtr_GetOfferForPlayer_Public_Virtual_New_ISelectionRoot_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr3) : null;
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0005E6E4 File Offset: 0x0005C8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872046, XrefRangeEnd = 872051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SelectionBegan(Action<ISelectionRoot> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_add_SelectionBegan_Public_add_Void_Action_1_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0005E728 File Offset: 0x0005C928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872051, XrefRangeEnd = 872056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SelectionBegan(Action<ISelectionRoot> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_remove_SelectionBegan_Public_rem_Void_Action_1_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0005E76C File Offset: 0x0005C96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872056, XrefRangeEnd = 872061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SelectionEnded(Action<ISelectionRoot> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_add_SelectionEnded_Public_add_Void_Action_1_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0005E7B0 File Offset: 0x0005C9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872061, XrefRangeEnd = 872066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SelectionEnded(Action<ISelectionRoot> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_remove_SelectionEnded_Public_rem_Void_Action_1_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0005E7F4 File Offset: 0x0005C9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872066, XrefRangeEnd = 872069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Selection Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_Get_Public_Static_Selection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selection>(intPtr3) : null;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0005E828 File Offset: 0x0005CA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872069, XrefRangeEnd = 872084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterResponder<T>(Action<T> responder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.MethodInfoStoreGeneric_RegisterResponder_Public_Void_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0005E86C File Offset: 0x0005CA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872084, XrefRangeEnd = 872106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterResponder<T>(Action<T> responder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.MethodInfoStoreGeneric_UnregisterResponder_Public_Void_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0005E8B0 File Offset: 0x0005CAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideFactory(ISelectionNodeFactory factory)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_OverrideFactory_Public_Void_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0005E8F4 File Offset: 0x0005CAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872106, XrefRangeEnd = 872120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginOffer(SelectionMessage offer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selection.NativeMethodInfoPtr_BeginOffer_Public_Virtual_New_Void_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0005E944 File Offset: 0x0005CB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872120, XrefRangeEnd = 872143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndOfferSilently(AccountID selectionsAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionsAccountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selection.NativeMethodInfoPtr_EndOfferSilently_Public_Virtual_New_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0005E994 File Offset: 0x0005CB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872143, XrefRangeEnd = 872166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndOffer(ISelectionRoot selectionRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selection.NativeMethodInfoPtr_EndOffer_Public_Virtual_New_Void_ISelectionRoot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0005E9E4 File Offset: 0x0005CBE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 872184, RefRangeEnd = 872186, XrefRangeStart = 872166, XrefRangeEnd = 872184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void beginListeningToOffer(ISelectionRoot offer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_beginListeningToOffer_Protected_Void_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0005EA28 File Offset: 0x0005CC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 872204, RefRangeEnd = 872205, XrefRangeStart = 872186, XrefRangeEnd = 872204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void stopListeningToOffer(ISelectionRoot offer, bool silent = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_stopListeningToOffer_Protected_Void_ISelectionRoot_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0005EA78 File Offset: 0x0005CC78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 872260, RefRangeEnd = 872262, XrefRangeStart = 872205, XrefRangeEnd = 872260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void newChoice(ISelectionNode choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_newChoice_Protected_Void_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0005EABC File Offset: 0x0005CCBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283236, RefRangeEnd = 283237, XrefRangeStart = 283236, XrefRangeEnd = 283237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void offerSent(ISelectionRoot selectionRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr_offerSent_Private_Void_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0005EB00 File Offset: 0x0005CD00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 872306, RefRangeEnd = 872307, XrefRangeStart = 872262, XrefRangeEnd = 872306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Selection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00008620 File Offset: 0x00006820
		public Selection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0005EB3C File Offset: 0x0005CD3C
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x00008629 File Offset: 0x00006829
		public unsafe bool Logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_Logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_Logging)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0005EB64 File Offset: 0x0005CD64
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x00008644 File Offset: 0x00006844
		public unsafe SelectionMessage _OfferMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr__OfferMessage_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr__OfferMessage_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0005EB94 File Offset: 0x0005CD94
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x00008663 File Offset: 0x00006863
		public unsafe ISelectionRoot _CurrentOffer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr__CurrentOffer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr__CurrentOffer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0005EBC4 File Offset: 0x0005CDC4
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x00008682 File Offset: 0x00006882
		public unsafe Action<ISelectionRoot> SelectionBegan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_SelectionBegan);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ISelectionRoot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_SelectionBegan), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0005EBF4 File Offset: 0x0005CDF4
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x000086A1 File Offset: 0x000068A1
		public unsafe Action<ISelectionRoot> SelectionEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_SelectionEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ISelectionRoot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_SelectionEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x0005EC24 File Offset: 0x0005CE24
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x000086C0 File Offset: 0x000068C0
		public unsafe ISelectionNodeFactory factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNodeFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x0005EC54 File Offset: 0x0005CE54
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x000086DF File Offset: 0x000068DF
		public unsafe Dictionary<Type, Delegate> choiceResponders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_choiceResponders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Delegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selection.NativeFieldInfoPtr_choiceResponders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeFieldInfoPtr_Logging;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeFieldInfoPtr__OfferMessage_k__BackingField;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr__CurrentOffer_k__BackingField;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_SelectionBegan;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr_SelectionEnded;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr_factory;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr_choiceResponders;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferMessage_Public_get_SelectionMessage_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferMessage_Protected_set_Void_SelectionMessage_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentOffer_Public_get_ISelectionRoot_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentOffer_Protected_set_Void_ISelectionRoot_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentChoice_Public_get_ISelectionNode_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_HasOfferForPlayer_Public_Virtual_New_Boolean_AccountID_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_GetOfferForPlayer_Public_Virtual_New_ISelectionRoot_AccountID_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_add_SelectionBegan_Public_add_Void_Action_1_ISelectionRoot_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_remove_SelectionBegan_Public_rem_Void_Action_1_ISelectionRoot_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_add_SelectionEnded_Public_add_Void_Action_1_ISelectionRoot_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_remove_SelectionEnded_Public_rem_Void_Action_1_ISelectionRoot_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Selection_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_RegisterResponder_Public_Void_Action_1_T_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterResponder_Public_Void_Action_1_T_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_OverrideFactory_Public_Void_ISelectionNodeFactory_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_BeginOffer_Public_Virtual_New_Void_SelectionMessage_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_EndOfferSilently_Public_Virtual_New_Void_AccountID_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_EndOffer_Public_Virtual_New_Void_ISelectionRoot_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_beginListeningToOffer_Protected_Void_ISelectionRoot_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_stopListeningToOffer_Protected_Void_ISelectionRoot_Boolean_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_newChoice_Protected_Void_ISelectionNode_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_offerSent_Private_Void_ISelectionRoot_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D5 RID: 725
		[Serializable]
		public class UnityEventISelectionRoot : UnityEvent<ISelectionRoot>
		{
			// Token: 0x060021B7 RID: 8631 RVA: 0x0000E73C File Offset: 0x0000C93C
			// Note: this type is marked as 'beforefieldinit'.
			static UnityEventISelectionRoot()
			{
				Il2CppClassPointerStore<Selection.UnityEventISelectionRoot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Selection>.NativeClassPtr, "UnityEventISelectionRoot");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Selection.UnityEventISelectionRoot>.NativeClassPtr);
				Selection.UnityEventISelectionRoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection.UnityEventISelectionRoot>.NativeClassPtr, 100666089);
			}

			// Token: 0x060021B8 RID: 8632 RVA: 0x00096984 File Offset: 0x00094B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872030, XrefRangeEnd = 872033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnityEventISelectionRoot()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Selection.UnityEventISelectionRoot>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.UnityEventISelectionRoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021B9 RID: 8633 RVA: 0x0000E770 File Offset: 0x0000C970
			public UnityEventISelectionRoot(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001763 RID: 5987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D6 RID: 726
		[ObfuscatedName("dwd.core.match.selection.Selection+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060021BA RID: 8634 RVA: 0x000969C0 File Offset: 0x00094BC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Selection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Selection>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Selection.__c>.NativeClassPtr);
				Selection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection.__c>.NativeClassPtr, "<>9");
				Selection.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection.__c>.NativeClassPtr, "<>9__33_0");
				Selection.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selection.__c>.NativeClassPtr, "<>9__33_1");
				Selection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection.__c>.NativeClassPtr, 100666091);
				Selection.__c.NativeMethodInfoPtr___ctor_b__33_0_Internal_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection.__c>.NativeClassPtr, 100666092);
				Selection.__c.NativeMethodInfoPtr___ctor_b__33_1_Internal_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selection.__c>.NativeClassPtr, 100666093);
			}

			// Token: 0x060021BB RID: 8635 RVA: 0x00096A64 File Offset: 0x00094C64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Selection.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021BC RID: 8636 RVA: 0x00096AA0 File Offset: 0x00094CA0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__33_0(ISelectionRoot <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.__c.NativeMethodInfoPtr___ctor_b__33_0_Internal_Void_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021BD RID: 8637 RVA: 0x00096AE4 File Offset: 0x00094CE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__33_1(ISelectionRoot <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selection.__c.NativeMethodInfoPtr___ctor_b__33_1_Internal_Void_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021BE RID: 8638 RVA: 0x0000E779 File Offset: 0x0000C979
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000936 RID: 2358
			// (get) Token: 0x060021BF RID: 8639 RVA: 0x00096B28 File Offset: 0x00094D28
			// (set) Token: 0x060021C0 RID: 8640 RVA: 0x0000E782 File Offset: 0x0000C982
			public unsafe static Selection.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Selection.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selection.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Selection.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000937 RID: 2359
			// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00096B50 File Offset: 0x00094D50
			// (set) Token: 0x060021C2 RID: 8642 RVA: 0x0000E794 File Offset: 0x0000C994
			public unsafe static Action<ISelectionRoot> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Selection.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ISelectionRoot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Selection.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000938 RID: 2360
			// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00096B78 File Offset: 0x00094D78
			// (set) Token: 0x060021C4 RID: 8644 RVA: 0x0000E7A6 File Offset: 0x0000C9A6
			public unsafe static Action<ISelectionRoot> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Selection.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ISelectionRoot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Selection.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001764 RID: 5988
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001765 RID: 5989
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04001766 RID: 5990
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x04001767 RID: 5991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001768 RID: 5992
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__33_0_Internal_Void_ISelectionRoot_0;

			// Token: 0x04001769 RID: 5993
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__33_1_Internal_Void_ISelectionRoot_0;
		}

		// Token: 0x020002D7 RID: 727
		private sealed class MethodInfoStoreGeneric_RegisterResponder_Public_Void_Action_1_T_0<T>
		{
			// Token: 0x0400176A RID: 5994
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Selection.NativeMethodInfoPtr_RegisterResponder_Public_Void_Action_1_T_0, Il2CppClassPointerStore<Selection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002D8 RID: 728
		private sealed class MethodInfoStoreGeneric_UnregisterResponder_Public_Void_Action_1_T_0<T>
		{
			// Token: 0x0400176B RID: 5995
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Selection.NativeMethodInfoPtr_UnregisterResponder_Public_Void_Action_1_T_0, Il2CppClassPointerStore<Selection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
