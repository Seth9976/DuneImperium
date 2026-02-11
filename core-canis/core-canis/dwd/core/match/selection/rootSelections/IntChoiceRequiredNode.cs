using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.messages;

namespace dwd.core.match.selection.rootSelections
{
	// Token: 0x0200015A RID: 346
	public class IntChoiceRequiredNode : RootSelection
	{
		// Token: 0x0600145E RID: 5214 RVA: 0x00066160 File Offset: 0x00064360
		// Note: this type is marked as 'beforefieldinit'.
		static IntChoiceRequiredNode()
		{
			Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection.rootSelections", "IntChoiceRequiredNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr);
			IntChoiceRequiredNode.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, "message");
			IntChoiceRequiredNode.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, "selected");
			IntChoiceRequiredNode.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, "<Version>k__BackingField");
			IntChoiceRequiredNode.NativeMethodInfoPtr__ctor_Public_Void_IntChoiceRequired_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666385);
			IntChoiceRequiredNode.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666386);
			IntChoiceRequiredNode.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666387);
			IntChoiceRequiredNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666388);
			IntChoiceRequiredNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666389);
			IntChoiceRequiredNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666390);
			IntChoiceRequiredNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666391);
			IntChoiceRequiredNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666392);
			IntChoiceRequiredNode.NativeMethodInfoPtr_get_SourceEntity_Public_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666393);
			IntChoiceRequiredNode.NativeMethodInfoPtr_get_MinAmount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666394);
			IntChoiceRequiredNode.NativeMethodInfoPtr_get_MaxAmount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666395);
			IntChoiceRequiredNode.NativeMethodInfoPtr_Select_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666396);
			IntChoiceRequiredNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666397);
			IntChoiceRequiredNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr, 100666398);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x000662E4 File Offset: 0x000644E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 871050, RefRangeEnd = 871052, XrefRangeStart = 871050, XrefRangeEnd = 871052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntChoiceRequiredNode(IntChoiceRequired message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntChoiceRequiredNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequiredNode.NativeMethodInfoPtr__ctor_Public_Void_IntChoiceRequired_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00066344 File Offset: 0x00064544
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x00066380 File Offset: 0x00064580
		public unsafe virtual ulong Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequiredNode.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequiredNode.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000663C0 File Offset: 0x000645C0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntChoiceRequiredNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0006640C File Offset: 0x0006460C
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequiredNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00066448 File Offset: 0x00064648
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874755, XrefRangeEnd = 874756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntChoiceRequiredNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x00066490 File Offset: 0x00064690
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874756, XrefRangeEnd = 874757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntChoiceRequiredNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000664D8 File Offset: 0x000646D8
		[CallerCount(0)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntChoiceRequiredNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x00066514 File Offset: 0x00064714
		public unsafe EntityID SourceEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequiredNode.NativeMethodInfoPtr_get_SourceEntity_Public_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00066554 File Offset: 0x00064754
		public unsafe int MinAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequiredNode.NativeMethodInfoPtr_get_MinAmount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x00066590 File Offset: 0x00064790
		public unsafe int MaxAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequiredNode.NativeMethodInfoPtr_get_MaxAmount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x000665CC File Offset: 0x000647CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874757, XrefRangeEnd = 874762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequiredNode.NativeMethodInfoPtr_Select_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0006660C File Offset: 0x0006480C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874762, XrefRangeEnd = 874769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntChoiceRequiredNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00066664 File Offset: 0x00064864
		[CallerCount(0)]
		public unsafe override string GetKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntChoiceRequiredNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00008F85 File Offset: 0x00007185
		public IntChoiceRequiredNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x000666A8 File Offset: 0x000648A8
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00008F8E File Offset: 0x0000718E
		public new unsafe IntChoiceRequired message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequiredNode.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntChoiceRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequiredNode.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x000666D8 File Offset: 0x000648D8
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x00008FAD File Offset: 0x000071AD
		public Nullable<int> selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequiredNode.NativeFieldInfoPtr_selected);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequiredNode.NativeFieldInfoPtr_selected), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00066708 File Offset: 0x00064908
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x00008FDB File Offset: 0x000071DB
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequiredNode.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequiredNode.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntChoiceRequired_ISelectionNodeFactory_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceEntity_Public_get_EntityID_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_get_MinAmount_Public_get_Int32_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxAmount_Public_get_Int32_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0;
	}
}
