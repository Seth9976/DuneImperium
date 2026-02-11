using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000185 RID: 389
	public sealed class AutoResetEvent : EventWaitHandle
	{
		// Token: 0x060019EF RID: 6639 RVA: 0x0000841A File Offset: 0x0000661A
		// Note: this type is marked as 'beforefieldinit'.
		static AutoResetEvent()
		{
			Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AutoResetEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr);
			AutoResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr, 100667829);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0009FEE0 File Offset: 0x0009E0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1351502, RefRangeEnd = 1351503, XrefRangeStart = 1351501, XrefRangeEnd = 1351502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoResetEvent(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00008453 File Offset: 0x00006653
		public AutoResetEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
