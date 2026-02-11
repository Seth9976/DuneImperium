using System;
using Google.Apis.Discovery;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Requests.Parameters
{
	// Token: 0x02000017 RID: 23
	public static class ParameterValidator : Object
	{
		// Token: 0x060000DC RID: 220 RVA: 0x000075E8 File Offset: 0x000057E8
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterValidator()
		{
			Il2CppClassPointerStore<ParameterValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Requests.Parameters", "ParameterValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterValidator>.NativeClassPtr);
			ParameterValidator.NativeMethodInfoPtr_ValidateRegex_Public_Static_Boolean_IParameter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterValidator>.NativeClassPtr, 100663433);
			ParameterValidator.NativeMethodInfoPtr_ValidateParameter_Public_Static_Boolean_IParameter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterValidator>.NativeClassPtr, 100663434);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007640 File Offset: 0x00005840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210981, XrefRangeEnd = 1210986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateRegex(IParameter param, string paramValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterValidator.NativeMethodInfoPtr_ValidateRegex_Public_Static_Boolean_IParameter_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007694 File Offset: 0x00005894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210993, RefRangeEnd = 1210994, XrefRangeStart = 1210986, XrefRangeEnd = 1210993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateParameter(IParameter parameter, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterValidator.NativeMethodInfoPtr_ValidateParameter_Public_Static_Boolean_IParameter_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000024D6 File Offset: 0x000006D6
		public ParameterValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRegex_Public_Static_Boolean_IParameter_String_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_ValidateParameter_Public_Static_Boolean_IParameter_String_0;
	}
}
