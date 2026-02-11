using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.match.selection
{
	// Token: 0x02000143 RID: 323
	public class MulliganChoiceNode : RootSelection
	{
		// Token: 0x060011F7 RID: 4599 RVA: 0x0005B7C0 File Offset: 0x000599C0
		// Note: this type is marked as 'beforefieldinit'.
		static MulliganChoiceNode()
		{
			Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "MulliganChoiceNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr);
			MulliganChoiceNode.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, "message");
			MulliganChoiceNode.NativeFieldInfoPtr_mulliganChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, "mulliganChoice");
			MulliganChoiceNode.NativeMethodInfoPtr__ctor_Public_Void_MulliganChoiceRequired_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665940);
			MulliganChoiceNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665941);
			MulliganChoiceNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665942);
			MulliganChoiceNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665943);
			MulliganChoiceNode.NativeMethodInfoPtr_MakeMulliganChoice_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665944);
			MulliganChoiceNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665945);
			MulliganChoiceNode.NativeMethodInfoPtr_get_MulliganChoice_Public_Virtual_Final_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665946);
			MulliganChoiceNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665947);
			MulliganChoiceNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr, 100665948);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0005B8CC File Offset: 0x00059ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 871050, RefRangeEnd = 871052, XrefRangeStart = 871050, XrefRangeEnd = 871052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulliganChoiceNode(MulliganChoiceRequired message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulliganChoiceNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulliganChoiceNode.NativeMethodInfoPtr__ctor_Public_Void_MulliganChoiceRequired_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0005B92C File Offset: 0x00059B2C
		public unsafe override bool MayCancel
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulliganChoiceNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0005B974 File Offset: 0x00059B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871064, XrefRangeEnd = 871068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulliganChoiceNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0005B9CC File Offset: 0x00059BCC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulliganChoiceNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0005BA18 File Offset: 0x00059C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871068, XrefRangeEnd = 871071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MakeMulliganChoice(bool mulligan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mulligan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulliganChoiceNode.NativeMethodInfoPtr_MakeMulliganChoice_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x0005BA58 File Offset: 0x00059C58
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871071, XrefRangeEnd = 871072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulliganChoiceNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0005BAA0 File Offset: 0x00059CA0
		public unsafe virtual Nullable<bool> MulliganChoice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulliganChoiceNode.NativeMethodInfoPtr_get_MulliganChoice_Public_Virtual_Final_New_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x0005BAD8 File Offset: 0x00059CD8
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871072, XrefRangeEnd = 871073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulliganChoiceNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0005BB20 File Offset: 0x00059D20
		[CallerCount(0)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulliganChoiceNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0000829E File Offset: 0x0000649E
		public MulliganChoiceNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0005BB5C File Offset: 0x00059D5C
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x000082A7 File Offset: 0x000064A7
		public new unsafe MulliganChoiceRequired message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MulliganChoiceNode.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MulliganChoiceRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MulliganChoiceNode.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x0005BB8C File Offset: 0x00059D8C
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000082C6 File Offset: 0x000064C6
		public Nullable<bool> mulliganChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MulliganChoiceNode.NativeFieldInfoPtr_mulliganChoice);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MulliganChoiceNode.NativeFieldInfoPtr_mulliganChoice), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr_mulliganChoice;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MulliganChoiceRequired_ISelectionNodeFactory_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_MakeMulliganChoice_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_get_MulliganChoice_Public_Virtual_Final_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;
	}
}
