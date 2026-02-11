using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000008 RID: 8
	public static class ThrowHelper : Object
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002CFC File Offset: 0x00000EFC
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowHelper()
		{
			Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "System", "ThrowHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
			ThrowHelper.NativeMethodInfoPtr_ThrowIfNull_Internal_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663303);
			ThrowHelper.NativeMethodInfoPtr_Throw_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663304);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002D54 File Offset: 0x00000F54
		[CallerCount(0)]
		public unsafe static void ThrowIfNull(Object argument, string paramName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowIfNull_Internal_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002D9C File Offset: 0x00000F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263801, XrefRangeEnd = 1263806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Throw(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_Throw_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002154 File Offset: 0x00000354
		public ThrowHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfNull_Internal_Static_Void_Object_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Static_Void_String_0;
	}
}
