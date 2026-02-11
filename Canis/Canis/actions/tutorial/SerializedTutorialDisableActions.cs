using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions.tutorial
{
	// Token: 0x020001FB RID: 507
	public class SerializedTutorialDisableActions : SerializedAction
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x000700B8 File Offset: 0x0006E2B8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTutorialDisableActions()
		{
			Il2CppClassPointerStore<SerializedTutorialDisableActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.tutorial", "SerializedTutorialDisableActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTutorialDisableActions>.NativeClassPtr);
			SerializedTutorialDisableActions.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTutorialDisableActions>.NativeClassPtr, "Actions");
			SerializedTutorialDisableActions.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTutorialDisableActions>.NativeClassPtr, 100668141);
			SerializedTutorialDisableActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTutorialDisableActions>.NativeClassPtr, 100668142);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00070124 File Offset: 0x0006E324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591296, XrefRangeEnd = 591301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedTutorialDisableActions.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00070180 File Offset: 0x0006E380
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTutorialDisableActions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTutorialDisableActions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTutorialDisableActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0000A593 File Offset: 0x00008793
		public SerializedTutorialDisableActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x000701BC File Offset: 0x0006E3BC
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x0000A59C File Offset: 0x0000879C
		public unsafe Il2CppStringArray Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTutorialDisableActions.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTutorialDisableActions.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
