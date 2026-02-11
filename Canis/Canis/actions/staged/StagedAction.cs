using System;
using Canis.actions.serialized;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.staged
{
	// Token: 0x0200020C RID: 524
	public class StagedAction : Action
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x0007254C File Offset: 0x0007074C
		// Note: this type is marked as 'beforefieldinit'.
		static StagedAction()
		{
			Il2CppClassPointerStore<StagedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.staged", "StagedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StagedAction>.NativeClassPtr);
			StagedAction.NativeFieldInfoPtr__Committed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, "<Committed>k__BackingField");
			StagedAction.NativeMethodInfoPtr_get_Committed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668357);
			StagedAction.NativeMethodInfoPtr_set_Committed_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668358);
			StagedAction.NativeMethodInfoPtr__ctor_Protected_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668359);
			StagedAction.NativeMethodInfoPtr_Stage_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668360);
			StagedAction.NativeMethodInfoPtr_Rollback_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668361);
			StagedAction.NativeMethodInfoPtr_Commit_Public_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668362);
			StagedAction.NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668363);
			StagedAction.NativeMethodInfoPtr_undo_Protected_Virtual_Final_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668364);
			StagedAction.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668365);
			StagedAction.NativeMethodInfoPtr_MakeSerializedStagedAction_Public_Abstract_Virtual_New_SerializedStagedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedAction>.NativeClassPtr, 100668366);
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00072658 File Offset: 0x00070858
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x00072694 File Offset: 0x00070894
		public unsafe virtual bool Committed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StagedAction.NativeMethodInfoPtr_get_Committed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StagedAction.NativeMethodInfoPtr_set_Committed_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000726D4 File Offset: 0x000708D4
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StagedAction(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StagedAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StagedAction.NativeMethodInfoPtr__ctor_Protected_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00072720 File Offset: 0x00070920
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Staging> Stage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StagedAction.NativeMethodInfoPtr_Stage_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Staging>>(intPtr3) : null;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0007276C File Offset: 0x0007096C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Staging> Rollback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StagedAction.NativeMethodInfoPtr_Rollback_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Staging>>(intPtr3) : null;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000727B8 File Offset: 0x000709B8
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Commit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StagedAction.NativeMethodInfoPtr_Commit_Public_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00072804 File Offset: 0x00070A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593255, XrefRangeEnd = 593262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StagedAction.NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00072844 File Offset: 0x00070A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593262, XrefRangeEnd = 593269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> undo(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StagedAction.NativeMethodInfoPtr_undo_Protected_Virtual_Final_IEnumerable_1_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00072894 File Offset: 0x00070A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StagedAction.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000728E4 File Offset: 0x00070AE4
		[CallerCount(0)]
		public unsafe virtual SerializedStagedAction MakeSerializedStagedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StagedAction.NativeMethodInfoPtr_MakeSerializedStagedAction_Public_Abstract_Virtual_New_SerializedStagedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStagedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0000AB1A File Offset: 0x00008D1A
		public StagedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00072940 File Offset: 0x00070B40
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x0000AB23 File Offset: 0x00008D23
		public unsafe bool _Committed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StagedAction.NativeFieldInfoPtr__Committed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StagedAction.NativeFieldInfoPtr__Committed_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeFieldInfoPtr__Committed_k__BackingField;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_get_Committed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_set_Committed_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_Stage_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_Rollback_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_Final_IEnumerable_1_Action_Context_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStagedAction_Public_Abstract_Virtual_New_SerializedStagedAction_Match_0;
	}
}
