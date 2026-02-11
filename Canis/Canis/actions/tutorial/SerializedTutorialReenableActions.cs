using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions.tutorial
{
	// Token: 0x020001FD RID: 509
	public class SerializedTutorialReenableActions : SerializedAction
	{
		// Token: 0x06001585 RID: 5509 RVA: 0x00070488 File Offset: 0x0006E688
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTutorialReenableActions()
		{
			Il2CppClassPointerStore<SerializedTutorialReenableActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.tutorial", "SerializedTutorialReenableActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTutorialReenableActions>.NativeClassPtr);
			SerializedTutorialReenableActions.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTutorialReenableActions>.NativeClassPtr, "Actions");
			SerializedTutorialReenableActions.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTutorialReenableActions>.NativeClassPtr, 100668156);
			SerializedTutorialReenableActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTutorialReenableActions>.NativeClassPtr, 100668157);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000704F4 File Offset: 0x0006E6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591364, XrefRangeEnd = 591369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedTutorialReenableActions.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00070550 File Offset: 0x0006E750
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTutorialReenableActions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTutorialReenableActions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTutorialReenableActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0000A5F2 File Offset: 0x000087F2
		public SerializedTutorialReenableActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x0007058C File Offset: 0x0006E78C
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x0000A5FB File Offset: 0x000087FB
		public unsafe Il2CppStringArray Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTutorialReenableActions.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTutorialReenableActions.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
