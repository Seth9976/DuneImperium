using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000056 RID: 86
	public static class NotImplemented : Object
	{
		// Token: 0x060004FA RID: 1274 RVA: 0x00003A11 File Offset: 0x00001C11
		// Note: this type is marked as 'beforefieldinit'.
		static NotImplemented()
		{
			Il2CppClassPointerStore<NotImplemented>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "NotImplemented");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotImplemented>.NativeClassPtr);
			NotImplemented.NativeMethodInfoPtr_ByDesignWithMessage_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplemented>.NativeClassPtr, 100664177);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0002F300 File Offset: 0x0002D500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433651, XrefRangeEnd = 433655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ByDesignWithMessage(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplemented.NativeMethodInfoPtr_ByDesignWithMessage_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00003A4A File Offset: 0x00001C4A
		public NotImplemented(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_ByDesignWithMessage_Internal_Static_Exception_String_0;
	}
}
