using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DA RID: 218
	[StructLayout(2)]
	public struct EventDebuggerLogCall
	{
		// Token: 0x060012DC RID: 4828 RVA: 0x0005F888 File Offset: 0x0005DA88
		// Note: this type is marked as 'beforefieldinit'.
		static EventDebuggerLogCall()
		{
			Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDebuggerLogCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr);
			EventDebuggerLogCall.NativeMethodInfoPtr__ctor_Public_Void_Delegate_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr, 100665976);
			EventDebuggerLogCall.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr, 100665977);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDebuggerLogCall(Delegate callback, EventBase evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogCall.NativeMethodInfoPtr__ctor_Public_Void_Delegate_EventBase_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0005F928 File Offset: 0x0005DB28
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogCall.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00009440 File Offset: 0x00007640
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr, ref this));
		}

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_EventBase_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
