using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DC RID: 220
	[StructLayout(2)]
	public struct EventDebuggerLogExecuteDefaultAction
	{
		// Token: 0x060012E4 RID: 4836 RVA: 0x0005FA08 File Offset: 0x0005DC08
		// Note: this type is marked as 'beforefieldinit'.
		static EventDebuggerLogExecuteDefaultAction()
		{
			Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDebuggerLogExecuteDefaultAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr);
			EventDebuggerLogExecuteDefaultAction.NativeMethodInfoPtr__ctor_Public_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr, 100665980);
			EventDebuggerLogExecuteDefaultAction.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr, 100665981);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0005FA60 File Offset: 0x0005DC60
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDebuggerLogExecuteDefaultAction(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogExecuteDefaultAction.NativeMethodInfoPtr__ctor_Public_Void_EventBase_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0005FA98 File Offset: 0x0005DC98
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogExecuteDefaultAction.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00009464 File Offset: 0x00007664
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr, ref this));
		}

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventBase_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
