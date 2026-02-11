using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions.staged
{
	// Token: 0x0200020D RID: 525
	public class SerializedStagedAction : SerializedAction
	{
		// Token: 0x06001633 RID: 5683 RVA: 0x00072968 File Offset: 0x00070B68
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedStagedAction()
		{
			Il2CppClassPointerStore<SerializedStagedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.staged", "SerializedStagedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedStagedAction>.NativeClassPtr);
			SerializedStagedAction.NativeFieldInfoPtr_Committed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedStagedAction>.NativeClassPtr, "Committed");
			SerializedStagedAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStagedAction>.NativeClassPtr, 100668367);
			SerializedStagedAction.NativeMethodInfoPtr_GenStagedAction_Protected_Abstract_Virtual_New_IStagedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStagedAction>.NativeClassPtr, 100668368);
			SerializedStagedAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStagedAction>.NativeClassPtr, 100668369);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x000729E8 File Offset: 0x00070BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593269, XrefRangeEnd = 593274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedStagedAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00072A38 File Offset: 0x00070C38
		[CallerCount(0)]
		public unsafe virtual IStagedAction GenStagedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedStagedAction.NativeMethodInfoPtr_GenStagedAction_Protected_Abstract_Virtual_New_IStagedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStagedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00072A94 File Offset: 0x00070C94
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedStagedAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedStagedAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedStagedAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0000AB3E File Offset: 0x00008D3E
		public SerializedStagedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00072AD0 File Offset: 0x00070CD0
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x0000AB47 File Offset: 0x00008D47
		public unsafe bool Committed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStagedAction.NativeFieldInfoPtr_Committed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStagedAction.NativeFieldInfoPtr_Committed)) = value;
			}
		}

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_Committed;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_GenStagedAction_Protected_Abstract_Virtual_New_IStagedAction_Match_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
