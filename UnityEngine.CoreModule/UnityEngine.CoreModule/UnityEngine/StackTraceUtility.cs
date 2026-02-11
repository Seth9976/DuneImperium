using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace UnityEngine
{
	// Token: 0x0200014E RID: 334
	public static class StackTraceUtility : Object
	{
		// Token: 0x06001925 RID: 6437 RVA: 0x000760BC File Offset: 0x000742BC
		// Note: this type is marked as 'beforefieldinit'.
		static StackTraceUtility()
		{
			Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "StackTraceUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr);
			StackTraceUtility.NativeFieldInfoPtr_projectFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, "projectFolder");
			StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100666760);
			StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100666761);
			StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100666762);
			StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100666763);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00076150 File Offset: 0x00074350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667134, XrefRangeEnd = 667153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProjectFolder(string folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00076188 File Offset: 0x00074388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667153, XrefRangeEnd = 667170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractStackTrace()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x000761B4 File Offset: 0x000743B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667170, XrefRangeEnd = 667224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractStringFromExceptionInternal(Object exceptiono, out string message, out string stackTrace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptiono);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			stackTrace = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00076220 File Offset: 0x00074420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 667319, RefRangeEnd = 667321, XrefRangeStart = 667224, XrefRangeEnd = 667319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractFormattedStackTrace(StackTrace stackTrace)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stackTrace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00009D4A File Offset: 0x00007F4A
		public StackTraceUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0007625C File Offset: 0x0007445C
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x00009D53 File Offset: 0x00007F53
		public unsafe static string projectFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0007627C File Offset: 0x0007447C
		public static string ExtractStringFromException(Object exception)
		{
			string text;
			string text2;
			StackTraceUtility.ExtractStringFromExceptionInternal(exception, out text, out text2);
			return String.Concat(text, "\n", text2);
		}

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeFieldInfoPtr_projectFolder;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0;
	}
}
