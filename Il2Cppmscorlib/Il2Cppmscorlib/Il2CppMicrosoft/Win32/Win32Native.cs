using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000045 RID: 69
	public static class Win32Native : Object
	{
		// Token: 0x060003E0 RID: 992 RVA: 0x00034FA8 File Offset: 0x000331A8
		// Note: this type is marked as 'beforefieldinit'.
		static Win32Native()
		{
			Il2CppClassPointerStore<Win32Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "Win32Native");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Native>.NativeClassPtr);
			Win32Native.NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663882);
			Win32Native.NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663883);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00035000 File Offset: 0x00033200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1281043, RefRangeEnd = 1281046, XrefRangeStart = 1281039, XrefRangeEnd = 1281043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(int hr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00035038 File Offset: 0x00033238
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1281046, RefRangeEnd = 1281052, XrefRangeStart = 1281046, XrefRangeEnd = 1281046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MakeHRFromErrorCode(int errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00003771 File Offset: 0x00001971
		public Win32Native(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0;
	}
}
