using System;
using Canis.attributes;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x0200014A RID: 330
	public class SelectionNode : Object
	{
		// Token: 0x060012C8 RID: 4808 RVA: 0x0005EDB8 File Offset: 0x0005CFB8
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionNode()
		{
			Il2CppClassPointerStore<SelectionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "SelectionNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr);
			SelectionNode.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, "children");
			SelectionNode.NativeFieldInfoPtr__Root_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, "<Root>k__BackingField");
			SelectionNode.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, "<Parent>k__BackingField");
			SelectionNode.NativeMethodInfoPtr_get_Root_Public_Virtual_Final_New_get_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666102);
			SelectionNode.NativeMethodInfoPtr_set_Root_Protected_set_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666103);
			SelectionNode.NativeMethodInfoPtr_get_Parent_Public_Virtual_Final_New_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666104);
			SelectionNode.NativeMethodInfoPtr_set_Parent_Private_set_Void_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666105);
			SelectionNode.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666106);
			SelectionNode.NativeMethodInfoPtr_get_Children_Public_Virtual_Final_New_get_IEnumerable_1_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666107);
			SelectionNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Abstract_Virtual_New_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666108);
			SelectionNode.NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666109);
			SelectionNode.NativeMethodInfoPtr_get_MayCancel_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666110);
			SelectionNode.NativeMethodInfoPtr_get_MayAdvance_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666111);
			SelectionNode.NativeMethodInfoPtr_get_HasClearableState_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666112);
			SelectionNode.NativeMethodInfoPtr_ClearState_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666113);
			SelectionNode.NativeMethodInfoPtr_get_Prompt_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666114);
			SelectionNode.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666115);
			SelectionNode.NativeMethodInfoPtr_get_Kind_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666116);
			SelectionNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr, 100666117);
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0005EF64 File Offset: 0x0005D164
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x0005EFA4 File Offset: 0x0005D1A4
		public unsafe virtual ISelectionRoot Root
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNode.NativeMethodInfoPtr_get_Root_Public_Virtual_Final_New_get_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNode.NativeMethodInfoPtr_set_Root_Protected_set_Void_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x0005EFE8 File Offset: 0x0005D1E8
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x0005F028 File Offset: 0x0005D228
		public unsafe virtual ISelectionNode Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNode.NativeMethodInfoPtr_get_Parent_Public_Virtual_Final_New_get_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNode.NativeMethodInfoPtr_set_Parent_Private_set_Void_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0005F06C File Offset: 0x0005D26C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 872343, RefRangeEnd = 872348, XrefRangeStart = 872333, XrefRangeEnd = 872343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionNode(ISelectionNodeFactory factory, ISelectionRoot root, ISelectionNode parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNode.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x0005F0DC File Offset: 0x0005D2DC
		public unsafe virtual IEnumerable<ISelectionNode> Children
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNode.NativeMethodInfoPtr_get_Children_Public_Virtual_Final_New_get_IEnumerable_1_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ISelectionNode>>(intPtr3) : null;
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0005F11C File Offset: 0x0005D31C
		[CallerCount(0)]
		public unsafe virtual ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Abstract_Virtual_New_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0005F168 File Offset: 0x0005D368
		[CallerCount(0)]
		public unsafe virtual void Enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x0005F1B4 File Offset: 0x0005D3B4
		public unsafe virtual bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_get_MayCancel_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x0005F1FC File Offset: 0x0005D3FC
		public unsafe virtual bool MayAdvance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_get_MayAdvance_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0005F244 File Offset: 0x0005D444
		public unsafe virtual bool HasClearableState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_get_HasClearableState_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0005F28C File Offset: 0x0005D48C
		[CallerCount(0)]
		public unsafe virtual void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_ClearState_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0005F2C8 File Offset: 0x0005D4C8
		public unsafe virtual LocalizableTextVariables Prompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_get_Prompt_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x0005F314 File Offset: 0x0005D514
		public unsafe virtual ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x0005F360 File Offset: 0x0005D560
		public unsafe virtual string Kind
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 872348, RefRangeEnd = 872349, XrefRangeStart = 872348, XrefRangeEnd = 872348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNode.NativeMethodInfoPtr_get_Kind_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0005F398 File Offset: 0x0005D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872349, XrefRangeEnd = 872351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00008726 File Offset: 0x00006926
		public SelectionNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x0005F3DC File Offset: 0x0005D5DC
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x0000872F File Offset: 0x0000692F
		public unsafe List<ISelectionNode> children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNode.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISelectionNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNode.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x0005F40C File Offset: 0x0005D60C
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x0000874E File Offset: 0x0000694E
		public unsafe ISelectionRoot _Root_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNode.NativeFieldInfoPtr__Root_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNode.NativeFieldInfoPtr__Root_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0005F43C File Offset: 0x0005D63C
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x0000876D File Offset: 0x0000696D
		public unsafe ISelectionNode _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNode.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNode.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeFieldInfoPtr__Root_k__BackingField;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_get_Root_Public_Virtual_Final_New_get_ISelectionRoot_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_set_Root_Protected_set_Void_ISelectionRoot_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_Final_New_get_ISelectionNode_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_ISelectionNode_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_Virtual_Final_New_get_IEnumerable_1_ISelectionNode_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Abstract_Virtual_New_ISelectionNode_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_GetKind_Protected_Virtual_New_String_0;
	}
}
