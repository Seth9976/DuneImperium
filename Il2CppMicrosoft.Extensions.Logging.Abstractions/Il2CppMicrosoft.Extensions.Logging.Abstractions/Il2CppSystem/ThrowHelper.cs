using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000009 RID: 9
	public static class ThrowHelper : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002B4C File Offset: 0x00000D4C
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowHelper()
		{
			Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "System", "ThrowHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
			ThrowHelper.NativeMethodInfoPtr_ThrowIfNull_Internal_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663305);
			ThrowHelper.NativeMethodInfoPtr_Throw_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002BA4 File Offset: 0x00000DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264448, RefRangeEnd = 1264449, XrefRangeStart = 1264448, XrefRangeEnd = 1264448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000021 RID: 33 RVA: 0x00002BEC File Offset: 0x00000DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264449, XrefRangeEnd = 1264454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000022 RID: 34 RVA: 0x000021AA File Offset: 0x000003AA
		public ThrowHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfNull_Internal_Static_Void_Object_String_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Static_Void_String_0;
	}
}
