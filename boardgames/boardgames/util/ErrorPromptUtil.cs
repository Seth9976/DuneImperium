using System;
using dwd.core;
using dwd.core.ui.prompt.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.util
{
	// Token: 0x02000107 RID: 263
	public static class ErrorPromptUtil : Object
	{
		// Token: 0x06000CC4 RID: 3268 RVA: 0x00039728 File Offset: 0x00037928
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorPromptUtil()
		{
			Il2CppClassPointerStore<ErrorPromptUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.util", "ErrorPromptUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorPromptUtil>.NativeClassPtr);
			ErrorPromptUtil.NativeMethodInfoPtr_DisplayPrompt_Public_Static_DisplayGenericPrompt_ErrorInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorPromptUtil>.NativeClassPtr, 100665294);
			ErrorPromptUtil.NativeMethodInfoPtr_DisplayPrompt_Public_Static_DisplayGenericPrompt_ErrorInfo_String_ModalScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorPromptUtil>.NativeClassPtr, 100665295);
			ErrorPromptUtil.NativeMethodInfoPtr_GetExceptionLocKey_Public_Static_String_ErrorInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorPromptUtil>.NativeClassPtr, 100665296);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00039794 File Offset: 0x00037994
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 995820, RefRangeEnd = 995824, XrefRangeStart = 995816, XrefRangeEnd = 995820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DisplayGenericPrompt DisplayPrompt(this ErrorInfo errorInfo, string fallbackLocKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(errorInfo));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fallbackLocKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorPromptUtil.NativeMethodInfoPtr_DisplayPrompt_Public_Static_DisplayGenericPrompt_ErrorInfo_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr3) : null;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000397F0 File Offset: 0x000379F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995846, RefRangeEnd = 995847, XrefRangeStart = 995824, XrefRangeEnd = 995846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DisplayGenericPrompt DisplayPrompt(this ErrorInfo errorInfo, string fallbackLocKey, ModalScope scope)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(errorInfo));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fallbackLocKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scope);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorPromptUtil.NativeMethodInfoPtr_DisplayPrompt_Public_Static_DisplayGenericPrompt_ErrorInfo_String_ModalScope_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr3) : null;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00039860 File Offset: 0x00037A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995851, RefRangeEnd = 995852, XrefRangeStart = 995847, XrefRangeEnd = 995851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetExceptionLocKey(this ErrorInfo errorInfo, string fallbackLocKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(errorInfo));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fallbackLocKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorPromptUtil.NativeMethodInfoPtr_GetExceptionLocKey_Public_Static_String_ErrorInfo_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00007E68 File Offset: 0x00006068
		public ErrorPromptUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_DisplayPrompt_Public_Static_DisplayGenericPrompt_ErrorInfo_String_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_DisplayPrompt_Public_Static_DisplayGenericPrompt_ErrorInfo_String_ModalScope_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionLocKey_Public_Static_String_ErrorInfo_String_0;
	}
}
