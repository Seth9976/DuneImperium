using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200051E RID: 1310
	public static class Error : Object
	{
		// Token: 0x06004FF2 RID: 20466 RVA: 0x00174138 File Offset: 0x00172338
		// Note: this type is marked as 'beforefieldinit'.
		static Error()
		{
			Il2CppClassPointerStore<Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Error>.NativeClassPtr);
			Error.NativeMethodInfoPtr_GetStreamIsClosed_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100675373);
			Error.NativeMethodInfoPtr_GetEndOfFile_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100675374);
			Error.NativeMethodInfoPtr_GetReadNotSupported_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100675375);
			Error.NativeMethodInfoPtr_GetWriteNotSupported_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100675376);
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x001741B8 File Offset: 0x001723B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1427212, RefRangeEnd = 1427216, XrefRangeStart = 1427206, XrefRangeEnd = 1427212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetStreamIsClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_GetStreamIsClosed_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x001741EC File Offset: 0x001723EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427216, XrefRangeEnd = 1427222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetEndOfFile()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_GetEndOfFile_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x00174220 File Offset: 0x00172420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427228, RefRangeEnd = 1427229, XrefRangeStart = 1427222, XrefRangeEnd = 1427228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetReadNotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_GetReadNotSupported_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00174254 File Offset: 0x00172454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427235, RefRangeEnd = 1427236, XrefRangeStart = 1427229, XrefRangeEnd = 1427235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetWriteNotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_GetWriteNotSupported_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x0001CA0C File Offset: 0x0001AC0C
		public Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004126 RID: 16678
		private static readonly IntPtr NativeMethodInfoPtr_GetStreamIsClosed_Internal_Static_Exception_0;

		// Token: 0x04004127 RID: 16679
		private static readonly IntPtr NativeMethodInfoPtr_GetEndOfFile_Internal_Static_Exception_0;

		// Token: 0x04004128 RID: 16680
		private static readonly IntPtr NativeMethodInfoPtr_GetReadNotSupported_Internal_Static_Exception_0;

		// Token: 0x04004129 RID: 16681
		private static readonly IntPtr NativeMethodInfoPtr_GetWriteNotSupported_Internal_Static_Exception_0;
	}
}
