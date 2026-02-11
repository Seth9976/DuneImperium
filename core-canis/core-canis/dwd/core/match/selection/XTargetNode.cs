using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection
{
	// Token: 0x02000158 RID: 344
	public class XTargetNode : TargetInfoNode
	{
		// Token: 0x06001424 RID: 5156 RVA: 0x00065344 File Offset: 0x00063544
		// Note: this type is marked as 'beforefieldinit'.
		static XTargetNode()
		{
			Il2CppClassPointerStore<XTargetNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "XTargetNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr);
			XTargetNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, "targetInfo");
			XTargetNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, "<SelectedNumber>k__BackingField");
			XTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_XTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666355);
			XTargetNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666356);
			XTargetNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666357);
			XTargetNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666358);
			XTargetNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666359);
			XTargetNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666360);
			XTargetNode.NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666361);
			XTargetNode.NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666362);
			XTargetNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666363);
			XTargetNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666364);
			XTargetNode.NativeMethodInfoPtr_get_Min_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666365);
			XTargetNode.NativeMethodInfoPtr_get_Max_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666366);
			XTargetNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr, 100666367);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000654A0 File Offset: 0x000636A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTargetNode(ISelectionNodeFactory factory, XTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTargetNode>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_XTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00065558 File Offset: 0x00063758
		public unsafe override bool satisfied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874610, XrefRangeEnd = 874611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTargetNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000655A0 File Offset: 0x000637A0
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000655DC File Offset: 0x000637DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874611, XrefRangeEnd = 874618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TargetResponse getResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTargetNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x00065628 File Offset: 0x00063828
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874618, XrefRangeEnd = 874619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTargetNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00065670 File Offset: 0x00063870
		[CallerCount(0)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTargetNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x000656AC File Offset: 0x000638AC
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x000656E4 File Offset: 0x000638E4
		public unsafe virtual Nullable<int> SelectedNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0006572C File Offset: 0x0006392C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874619, XrefRangeEnd = 874622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0006576C File Offset: 0x0006396C
		[CallerCount(0)]
		public unsafe virtual void Unselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x000657A0 File Offset: 0x000639A0
		public unsafe virtual int Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr_get_Min_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x000657DC File Offset: 0x000639DC
		public unsafe virtual int Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr_get_Max_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00065818 File Offset: 0x00063A18
		[CallerCount(0)]
		public unsafe virtual ISelectionNode PeekNode(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00008DED File Offset: 0x00006FED
		public XTargetNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00065864 File Offset: 0x00063A64
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x00008DF6 File Offset: 0x00006FF6
		public new unsafe XTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00065894 File Offset: 0x00063A94
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x00008E15 File Offset: 0x00007015
		public Nullable<int> _SelectedNumber_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNumber_k__BackingField;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_XTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0;
	}
}
