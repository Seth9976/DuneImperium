using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000006 RID: 6
	public static class PlatformHelper : Object
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00005A1C File Offset: 0x00003C1C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformHelper()
		{
			Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "PlatformHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr);
			PlatformHelper.NativeMethodInfoPtr_IsContentHeader_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100663349);
			PlatformHelper.NativeMethodInfoPtr_GetSingleHeaderString_Internal_Static_String_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100663350);
			PlatformHelper.NativeMethodInfoPtr_CreateStreamContent_Internal_Static_StreamContent_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100663351);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005A88 File Offset: 0x00003C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170972, XrefRangeEnd = 1170983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsContentHeader(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_IsContentHeader_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005ACC File Offset: 0x00003CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1170987, RefRangeEnd = 1170988, XrefRangeStart = 1170983, XrefRangeEnd = 1170987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSingleHeaderString(string name, IEnumerable<string> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_GetSingleHeaderString_Internal_Static_String_String_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005B1C File Offset: 0x00003D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170988, XrefRangeEnd = 1170994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_CreateStreamContent_Internal_Static_StreamContent_Stream_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamContent>(intPtr3) : null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002373 File Offset: 0x00000573
		public PlatformHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_IsContentHeader_Internal_Static_Boolean_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetSingleHeaderString_Internal_Static_String_String_IEnumerable_1_String_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_CreateStreamContent_Internal_Static_StreamContent_Stream_CancellationToken_0;
	}
}
