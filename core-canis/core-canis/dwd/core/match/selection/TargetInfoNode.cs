using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection
{
	// Token: 0x02000157 RID: 343
	public class TargetInfoNode : SelectionNode
	{
		// Token: 0x0600140C RID: 5132 RVA: 0x00064C54 File Offset: 0x00062E54
		// Note: this type is marked as 'beforefieldinit'.
		static TargetInfoNode()
		{
			Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "TargetInfoNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr);
			TargetInfoNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, "targetInfo");
			TargetInfoNode.NativeFieldInfoPtr_mayCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, "mayCancel");
			TargetInfoNode.NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, "kind");
			TargetInfoNode.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, "attributes");
			TargetInfoNode.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666338);
			TargetInfoNode.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666339);
			TargetInfoNode.NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666340);
			TargetInfoNode.NativeMethodInfoPtr_enter_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666341);
			TargetInfoNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666342);
			TargetInfoNode.NativeMethodInfoPtr_get_satisfied_Protected_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666343);
			TargetInfoNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666344);
			TargetInfoNode.NativeMethodInfoPtr_GetResponse_Public_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666345);
			TargetInfoNode.NativeMethodInfoPtr_getResponse_Protected_Abstract_Virtual_New_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666346);
			TargetInfoNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666347);
			TargetInfoNode.NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666348);
			TargetInfoNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666349);
			TargetInfoNode.NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666350);
			TargetInfoNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, 100666351);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00064DEC File Offset: 0x00062FEC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 874580, RefRangeEnd = 874594, XrefRangeStart = 874544, XrefRangeEnd = 874580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetInfoNode(ISelectionNodeFactory factory, TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string kind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInfoNode.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00064EA4 File Offset: 0x000630A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 874597, RefRangeEnd = 874598, XrefRangeStart = 874594, XrefRangeEnd = 874597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetInfoNode(ISelectionNodeFactory factory, TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInfoNode.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00064F48 File Offset: 0x00063148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874598, XrefRangeEnd = 874601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInfoNode.NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00064F88 File Offset: 0x00063188
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInfoNode.NativeMethodInfoPtr_enter_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x00064FD4 File Offset: 0x000631D4
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInfoNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x00065010 File Offset: 0x00063210
		public unsafe virtual bool satisfied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInfoNode.NativeMethodInfoPtr_get_satisfied_Protected_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00065058 File Offset: 0x00063258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874601, XrefRangeEnd = 874604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInfoNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x000650A4 File Offset: 0x000632A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 874604, RefRangeEnd = 874605, XrefRangeStart = 874604, XrefRangeEnd = 874604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInfoNode.NativeMethodInfoPtr_GetResponse_Public_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x000650E4 File Offset: 0x000632E4
		[CallerCount(0)]
		public unsafe virtual TargetResponse getResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInfoNode.NativeMethodInfoPtr_getResponse_Protected_Abstract_Virtual_New_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00065130 File Offset: 0x00063330
		public unsafe override bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInfoNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00065178 File Offset: 0x00063378
		public unsafe override LocalizableTextVariables Prompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInfoNode.NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x000651C4 File Offset: 0x000633C4
		public unsafe override ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874605, XrefRangeEnd = 874610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInfoNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00065210 File Offset: 0x00063410
		public unsafe AccountID AccountID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInfoNode.NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00065250 File Offset: 0x00063450
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInfoNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00008D6C File Offset: 0x00006F6C
		public TargetInfoNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x00065294 File Offset: 0x00063494
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x00008D75 File Offset: 0x00006F75
		public unsafe TargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInfoNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInfoNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x000652C4 File Offset: 0x000634C4
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00008D94 File Offset: 0x00006F94
		public unsafe bool mayCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInfoNode.NativeFieldInfoPtr_mayCancel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInfoNode.NativeFieldInfoPtr_mayCancel)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x000652EC File Offset: 0x000634EC
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x00008DAF File Offset: 0x00006FAF
		public unsafe string kind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInfoNode.NativeFieldInfoPtr_kind);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInfoNode.NativeFieldInfoPtr_kind), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00065314 File Offset: 0x00063514
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x00008DCE File Offset: 0x00006FCE
		public unsafe ReadOnlyAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInfoNode.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInfoNode.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeFieldInfoPtr_mayCancel;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeFieldInfoPtr_kind;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_enter_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_get_satisfied_Protected_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_TargetResponse_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_getResponse_Protected_Abstract_Virtual_New_TargetResponse_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0;

		// Token: 0x020002E2 RID: 738
		[ObfuscatedName("dwd.core.match.selection.TargetInfoNode+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600222A RID: 8746 RVA: 0x00097FE8 File Offset: 0x000961E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TargetInfoNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoNode>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoNode.__c>.NativeClassPtr);
				TargetInfoNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoNode.__c>.NativeClassPtr, "<>9");
				TargetInfoNode.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoNode.__c>.NativeClassPtr, "<>9__3_0");
				TargetInfoNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode.__c>.NativeClassPtr, 100666353);
				TargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoNode.__c>.NativeClassPtr, 100666354);
			}

			// Token: 0x0600222B RID: 8747 RVA: 0x00098064 File Offset: 0x00096264
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInfoNode.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInfoNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600222C RID: 8748 RVA: 0x000980A0 File Offset: 0x000962A0
			[CallerCount(0)]
			public unsafe bool __ctor_b__3_0(TargetInformation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600222D RID: 8749 RVA: 0x0000EA53 File Offset: 0x0000CC53
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x0600222E RID: 8750 RVA: 0x000980F0 File Offset: 0x000962F0
			// (set) Token: 0x0600222F RID: 8751 RVA: 0x0000EA5C File Offset: 0x0000CC5C
			public unsafe static TargetInfoNode.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TargetInfoNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInfoNode.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TargetInfoNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000954 RID: 2388
			// (get) Token: 0x06002230 RID: 8752 RVA: 0x00098118 File Offset: 0x00096318
			// (set) Token: 0x06002231 RID: 8753 RVA: 0x0000EA6E File Offset: 0x0000CC6E
			public unsafe static Func<TargetInformation, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TargetInfoNode.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TargetInfoNode.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017A6 RID: 6054
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040017A7 RID: 6055
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040017A8 RID: 6056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017A9 RID: 6057
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_TargetInformation_0;
		}
	}
}
