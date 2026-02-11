using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B5 RID: 437
	public class InternalException : SystemException
	{
		// Token: 0x06001B00 RID: 6912 RVA: 0x0000B962 File Offset: 0x00009B62
		// Note: this type is marked as 'beforefieldinit'.
		static InternalException()
		{
			Il2CppClassPointerStore<InternalException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "InternalException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalException>.NativeClassPtr);
			InternalException.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalException>.NativeClassPtr, 100667484);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00085FB4 File Offset: 0x000841B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474436, RefRangeEnd = 474437, XrefRangeStart = 474418, XrefRangeEnd = 474436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalException.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0000B99B File Offset: 0x00009B9B
		public InternalException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
