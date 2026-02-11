using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x0200004F RID: 79
	public static class NativeMethods : Object
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x0002DE1C File Offset: 0x0002C01C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethods()
		{
			Il2CppClassPointerStore<NativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Microsoft.Win32", "NativeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr);
			NativeMethods.NativeMethodInfoPtr_DuplicateHandle_Public_Static_Boolean_HandleRef_HandleRef_HandleRef_byref_SafeProcessHandle_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100664129);
			NativeMethods.NativeMethodInfoPtr_GetCurrentProcess_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100664130);
			NativeMethods.NativeMethodInfoPtr_GetExitCodeProcess_Public_Static_Boolean_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100664131);
			NativeMethods.NativeMethodInfoPtr_GetExitCodeProcess_Public_Static_Boolean_SafeProcessHandle_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100664132);
			NativeMethods.NativeMethodInfoPtr_GetCurrentProcessId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100664133);
			NativeMethods.NativeMethodInfoPtr_CloseProcess_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100664134);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0002DEC4 File Offset: 0x0002C0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433013, RefRangeEnd = 433014, XrefRangeStart = 433004, XrefRangeEnd = 433013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hSourceProcessHandle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hSourceHandle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hTargetProcess));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwDesiredAccess;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bInheritHandle;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwOptions;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethods.NativeMethodInfoPtr_DuplicateHandle_Public_Static_Boolean_HandleRef_HandleRef_HandleRef_byref_SafeProcessHandle_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			targetHandle = ((intPtr4 == 0) ? null : new SafeProcessHandle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0002DF88 File Offset: 0x0002C188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433015, RefRangeEnd = 433016, XrefRangeStart = 433014, XrefRangeEnd = 433015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetCurrentProcess()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethods.NativeMethodInfoPtr_GetCurrentProcess_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0002DFB8 File Offset: 0x0002C1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433016, XrefRangeEnd = 433017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &exitCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethods.NativeMethodInfoPtr_GetExitCodeProcess_Public_Static_Boolean_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0002E004 File Offset: 0x0002C204
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 433022, RefRangeEnd = 433025, XrefRangeStart = 433017, XrefRangeEnd = 433022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &exitCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethods.NativeMethodInfoPtr_GetExitCodeProcess_Public_Static_Boolean_SafeProcessHandle_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0002E054 File Offset: 0x0002C254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433026, RefRangeEnd = 433028, XrefRangeStart = 433025, XrefRangeEnd = 433026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCurrentProcessId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethods.NativeMethodInfoPtr_GetCurrentProcessId_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0002E084 File Offset: 0x0002C284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433028, XrefRangeEnd = 433029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseProcess(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethods.NativeMethodInfoPtr_CloseProcess_Public_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000374C File Offset: 0x0000194C
		public NativeMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateHandle_Public_Static_Boolean_HandleRef_HandleRef_HandleRef_byref_SafeProcessHandle_Int32_Boolean_Int32_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProcess_Public_Static_IntPtr_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_GetExitCodeProcess_Public_Static_Boolean_IntPtr_byref_Int32_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_GetExitCodeProcess_Public_Static_Boolean_SafeProcessHandle_byref_Int32_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProcessId_Public_Static_Int32_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_CloseProcess_Public_Static_Boolean_IntPtr_0;
	}
}
