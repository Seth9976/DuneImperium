using System;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions.serialized
{
	// Token: 0x0200020F RID: 527
	public class SerializedAction : Object
	{
		// Token: 0x0600163E RID: 5694 RVA: 0x00072BE8 File Offset: 0x00070DE8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAction()
		{
			Il2CppClassPointerStore<SerializedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.serialized", "SerializedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAction>.NativeClassPtr);
			SerializedAction.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAction>.NativeClassPtr, "Context");
			SerializedAction.NativeFieldInfoPtr_Succeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAction>.NativeClassPtr, "Succeeded");
			SerializedAction.NativeFieldInfoPtr_ShouldExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAction>.NativeClassPtr, "ShouldExecute");
			SerializedAction.NativeMethodInfoPtr_GenAction_Protected_Abstract_Virtual_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAction>.NativeClassPtr, 100668372);
			SerializedAction.NativeMethodInfoPtr_GenCompleteAction_Public_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAction>.NativeClassPtr, 100668373);
			SerializedAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAction>.NativeClassPtr, 100668374);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00072C90 File Offset: 0x00070E90
		[CallerCount(0)]
		public unsafe virtual Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAction.NativeMethodInfoPtr_GenAction_Protected_Abstract_Virtual_New_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00072CEC File Offset: 0x00070EEC
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 593277, RefRangeEnd = 593303, XrefRangeStart = 593274, XrefRangeEnd = 593277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action GenCompleteAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAction.NativeMethodInfoPtr_GenCompleteAction_Public_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00072D3C File Offset: 0x00070F3C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0000AB6B File Offset: 0x00008D6B
		public SerializedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x00072D78 File Offset: 0x00070F78
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x0000AB74 File Offset: 0x00008D74
		public unsafe SerializedContext Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAction.NativeFieldInfoPtr_Context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAction.NativeFieldInfoPtr_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x00072DA8 File Offset: 0x00070FA8
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x0000AB93 File Offset: 0x00008D93
		public unsafe bool Succeeded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAction.NativeFieldInfoPtr_Succeeded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAction.NativeFieldInfoPtr_Succeeded)) = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x00072DD0 File Offset: 0x00070FD0
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x0000ABAE File Offset: 0x00008DAE
		public unsafe bool ShouldExecute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAction.NativeFieldInfoPtr_ShouldExecute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAction.NativeFieldInfoPtr_ShouldExecute)) = value;
			}
		}

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeFieldInfoPtr_Context;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeFieldInfoPtr_Succeeded;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeFieldInfoPtr_ShouldExecute;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Abstract_Virtual_New_Action_Match_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_GenCompleteAction_Public_Action_Match_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
