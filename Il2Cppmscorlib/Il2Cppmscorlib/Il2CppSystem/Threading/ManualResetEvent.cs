using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200018A RID: 394
	public sealed class ManualResetEvent : EventWaitHandle
	{
		// Token: 0x06001A02 RID: 6658 RVA: 0x0000846E File Offset: 0x0000666E
		// Note: this type is marked as 'beforefieldinit'.
		static ManualResetEvent()
		{
			Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ManualResetEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr);
			ManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr, 100667842);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x000A05B0 File Offset: 0x0009E7B0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1351602, RefRangeEnd = 1351618, XrefRangeStart = 1351588, XrefRangeEnd = 1351602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEvent(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x000084A7 File Offset: 0x000066A7
		public ManualResetEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
