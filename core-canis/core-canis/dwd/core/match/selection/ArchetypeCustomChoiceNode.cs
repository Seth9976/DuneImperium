using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.readonlyWrappers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x02000141 RID: 321
	public class ArchetypeCustomChoiceNode : RootSelection
	{
		// Token: 0x060011CB RID: 4555 RVA: 0x0005AB88 File Offset: 0x00058D88
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeCustomChoiceNode()
		{
			Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "ArchetypeCustomChoiceNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr);
			ArchetypeCustomChoiceNode.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, "message");
			ArchetypeCustomChoiceNode.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, "buttons");
			ArchetypeCustomChoiceNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, "<SelectedNumber>k__BackingField");
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeCustomChoiceRequired_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665910);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665911);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665912);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665913);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665914);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665915);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665916);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665917);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665918);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665919);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_Buttons_Public_Virtual_Final_New_get_IReadOnlyList_1_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665920);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665921);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665922);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665923);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665924);
			ArchetypeCustomChoiceNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr, 100665925);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0005AD34 File Offset: 0x00058F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871026, RefRangeEnd = 871027, XrefRangeStart = 870990, XrefRangeEnd = 871026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoiceNode(ArchetypeCustomChoiceRequired message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoiceNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeCustomChoiceRequired_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x0005AD94 File Offset: 0x00058F94
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871027, XrefRangeEnd = 871028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0005ADD0 File Offset: 0x00058FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871028, XrefRangeEnd = 871035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0005AE28 File Offset: 0x00059028
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0005AE74 File Offset: 0x00059074
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x0005AEC0 File Offset: 0x000590C0
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871035, XrefRangeEnd = 871036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0005AF08 File Offset: 0x00059108
		public unsafe override bool MayCancel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871036, XrefRangeEnd = 871041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0005AF50 File Offset: 0x00059150
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871041, XrefRangeEnd = 871042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0005AF98 File Offset: 0x00059198
		[CallerCount(0)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0005AFD4 File Offset: 0x000591D4
		public unsafe virtual EntityID SourceEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0005B014 File Offset: 0x00059214
		public unsafe virtual IReadOnlyList<ReadOnlyAttributes> Buttons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_Buttons_Public_Virtual_Final_New_get_IReadOnlyList_1_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ReadOnlyAttributes>>(intPtr3) : null;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0005B054 File Offset: 0x00059254
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0005B08C File Offset: 0x0005928C
		public unsafe virtual Nullable<int> SelectedNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0005B0D4 File Offset: 0x000592D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 871045, RefRangeEnd = 871048, XrefRangeStart = 871042, XrefRangeEnd = 871045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0005B114 File Offset: 0x00059314
		[CallerCount(0)]
		public unsafe virtual void Unselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0005B148 File Offset: 0x00059348
		[CallerCount(0)]
		public unsafe override string GetKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x000081D3 File Offset: 0x000063D3
		public ArchetypeCustomChoiceNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0005B18C File Offset: 0x0005938C
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x000081DC File Offset: 0x000063DC
		public new unsafe ArchetypeCustomChoiceRequired message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceNode.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceNode.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0005B1BC File Offset: 0x000593BC
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x000081FB File Offset: 0x000063FB
		public unsafe ReadOnlyList<ReadOnlyAttributes> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceNode.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<ReadOnlyAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceNode.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0005B1EC File Offset: 0x000593EC
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x0000821A File Offset: 0x0000641A
		public Nullable<int> _SelectedNumber_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNumber_k__BackingField;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArchetypeCustomChoiceRequired_ISelectionNodeFactory_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_Int32_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_Virtual_Final_New_get_IReadOnlyList_1_ReadOnlyAttributes_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0;
	}
}
