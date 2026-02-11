using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006F RID: 111
	public static class ValidationUtils : Object
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x00004EB6 File Offset: 0x000030B6
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationUtils()
		{
			Il2CppClassPointerStore<ValidationUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "ValidationUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationUtils>.NativeClassPtr);
			ValidationUtils.NativeMethodInfoPtr_ArgumentNotNull_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationUtils>.NativeClassPtr, 100665138);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0003ED44 File Offset: 0x0003CF44
		[CallerCount(133)]
		[CachedScanResults(RefRangeStart = 746594, RefRangeEnd = 746727, XrefRangeStart = 746589, XrefRangeEnd = 746594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ArgumentNotNull(Object value, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationUtils.NativeMethodInfoPtr_ArgumentNotNull_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00004EEF File Offset: 0x000030EF
		public ValidationUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentNotNull_Public_Static_Void_Object_String_0;
	}
}
