using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000016 RID: 22
	public static class SafeStringArrayHelper : Object
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00009240 File Offset: 0x00007440
		// Note: this type is marked as 'beforefieldinit'.
		static SafeStringArrayHelper()
		{
			Il2CppClassPointerStore<SafeStringArrayHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "SafeStringArrayHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeStringArrayHelper>.NativeClassPtr);
			SafeStringArrayHelper.NativeMethodInfoPtr_SerialiseStringArraySafe_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringArrayHelper>.NativeClassPtr, 100663515);
			SafeStringArrayHelper.NativeMethodInfoPtr_DeserialiseStringArraySafe_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringArrayHelper>.NativeClassPtr, 100663516);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00009298 File Offset: 0x00007498
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1052436, RefRangeEnd = 1052439, XrefRangeStart = 1052419, XrefRangeEnd = 1052436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerialiseStringArraySafe(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringArrayHelper.NativeMethodInfoPtr_SerialiseStringArraySafe_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000092D4 File Offset: 0x000074D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1052475, RefRangeEnd = 1052478, XrefRangeStart = 1052439, XrefRangeEnd = 1052475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray DeserialiseStringArraySafe(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringArrayHelper.NativeMethodInfoPtr_DeserialiseStringArraySafe_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002C60 File Offset: 0x00000E60
		public SafeStringArrayHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_SerialiseStringArraySafe_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_DeserialiseStringArraySafe_Public_Static_Il2CppStringArray_String_0;
	}
}
