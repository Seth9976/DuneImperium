using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;

namespace dwd.core.match.selection
{
	// Token: 0x02000142 RID: 322
	public class CustomChoiceNode : RootSelection
	{
		// Token: 0x060011E3 RID: 4579 RVA: 0x0005B21C File Offset: 0x0005941C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceNode()
		{
			Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "CustomChoiceNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr);
			CustomChoiceNode.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, "message");
			CustomChoiceNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, "<SelectedNumber>k__BackingField");
			CustomChoiceNode.NativeMethodInfoPtr__ctor_Public_Void_CustomChoiceRequired_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665926);
			CustomChoiceNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665927);
			CustomChoiceNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665928);
			CustomChoiceNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665929);
			CustomChoiceNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665930);
			CustomChoiceNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665931);
			CustomChoiceNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665932);
			CustomChoiceNode.NativeMethodInfoPtr_get_Choices_Public_Virtual_Final_New_get_IList_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665933);
			CustomChoiceNode.NativeMethodInfoPtr_get_SourceEntity_Public_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665934);
			CustomChoiceNode.NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665935);
			CustomChoiceNode.NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665936);
			CustomChoiceNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665937);
			CustomChoiceNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665938);
			CustomChoiceNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr, 100665939);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0005B38C File Offset: 0x0005958C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 871050, RefRangeEnd = 871052, XrefRangeStart = 871048, XrefRangeEnd = 871050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceNode(CustomChoiceRequired message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceNode.NativeMethodInfoPtr__ctor_Public_Void_CustomChoiceRequired_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0005B3EC File Offset: 0x000595EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871052, XrefRangeEnd = 871059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0005B444 File Offset: 0x00059644
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0005B490 File Offset: 0x00059690
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionNode PeekNode(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0005B4DC File Offset: 0x000596DC
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871059, XrefRangeEnd = 871060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0005B524 File Offset: 0x00059724
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871060, XrefRangeEnd = 871061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0005B56C File Offset: 0x0005976C
		[CallerCount(0)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x0005B5A8 File Offset: 0x000597A8
		public unsafe virtual IList<LocalizableText> Choices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceNode.NativeMethodInfoPtr_get_Choices_Public_Virtual_Final_New_get_IList_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x0005B5E8 File Offset: 0x000597E8
		public unsafe EntityID SourceEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceNode.NativeMethodInfoPtr_get_SourceEntity_Public_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0005B628 File Offset: 0x00059828
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x0005B660 File Offset: 0x00059860
		public unsafe virtual Nullable<int> SelectedNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceNode.NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceNode.NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0005B6A8 File Offset: 0x000598A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871061, XrefRangeEnd = 871064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0005B6E8 File Offset: 0x000598E8
		[CallerCount(0)]
		public unsafe virtual void Unselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0005B71C File Offset: 0x0005991C
		[CallerCount(0)]
		public unsafe override string GetKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00008248 File Offset: 0x00006448
		public CustomChoiceNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0005B760 File Offset: 0x00059960
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x00008251 File Offset: 0x00006451
		public new unsafe CustomChoiceRequired message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceNode.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomChoiceRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceNode.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0005B790 File Offset: 0x00059990
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00008270 File Offset: 0x00006470
		public Nullable<int> _SelectedNumber_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNumber_k__BackingField;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CustomChoiceRequired_ISelectionNodeFactory_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_get_Choices_Public_Virtual_Final_New_get_IList_1_LocalizableText_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceEntity_Public_get_EntityID_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0;
	}
}
