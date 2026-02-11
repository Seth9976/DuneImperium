using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000531 RID: 1329
	public static class Win32Marshal : Object
	{
		// Token: 0x06005179 RID: 20857 RVA: 0x0017B380 File Offset: 0x00179580
		// Note: this type is marked as 'beforefieldinit'.
		static Win32Marshal()
		{
			Il2CppClassPointerStore<Win32Marshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Win32Marshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Marshal>.NativeClassPtr);
			Win32Marshal.NativeMethodInfoPtr_GetExceptionForLastWin32Error_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Marshal>.NativeClassPtr, 100675693);
			Win32Marshal.NativeMethodInfoPtr_GetExceptionForWin32Error_Internal_Static_Exception_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Marshal>.NativeClassPtr, 100675694);
			Win32Marshal.NativeMethodInfoPtr_MakeHRFromErrorCode_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Marshal>.NativeClassPtr, 100675695);
			Win32Marshal.NativeMethodInfoPtr_TryMakeWin32ErrorCodeFromHR_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Marshal>.NativeClassPtr, 100675696);
			Win32Marshal.NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Marshal>.NativeClassPtr, 100675697);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x0017B414 File Offset: 0x00179614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430051, XrefRangeEnd = 1430056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetExceptionForLastWin32Error(string path = "")
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Marshal.NativeMethodInfoPtr_GetExceptionForLastWin32Error_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x0017B458 File Offset: 0x00179658
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1430084, RefRangeEnd = 1430088, XrefRangeStart = 1430056, XrefRangeEnd = 1430084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetExceptionForWin32Error(int errorCode, string path = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Marshal.NativeMethodInfoPtr_GetExceptionForWin32Error_Internal_Static_Exception_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x0017B4AC File Offset: 0x001796AC
		[CallerCount(0)]
		public unsafe static int MakeHRFromErrorCode(int errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Marshal.NativeMethodInfoPtr_MakeHRFromErrorCode_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x0017B4EC File Offset: 0x001796EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430088, RefRangeEnd = 1430089, XrefRangeStart = 1430088, XrefRangeEnd = 1430088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryMakeWin32ErrorCodeFromHR(int hr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Marshal.NativeMethodInfoPtr_TryMakeWin32ErrorCodeFromHR_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x0017B52C File Offset: 0x0017972C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430089, XrefRangeEnd = 1430090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(int errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Marshal.NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x0001D13D File Offset: 0x0001B33D
		public Win32Marshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004273 RID: 17011
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionForLastWin32Error_Internal_Static_Exception_String_0;

		// Token: 0x04004274 RID: 17012
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionForWin32Error_Internal_Static_Exception_Int32_String_0;

		// Token: 0x04004275 RID: 17013
		private static readonly IntPtr NativeMethodInfoPtr_MakeHRFromErrorCode_Internal_Static_Int32_Int32_0;

		// Token: 0x04004276 RID: 17014
		private static readonly IntPtr NativeMethodInfoPtr_TryMakeWin32ErrorCodeFromHR_Internal_Static_Int32_Int32_0;

		// Token: 0x04004277 RID: 17015
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0;
	}
}
