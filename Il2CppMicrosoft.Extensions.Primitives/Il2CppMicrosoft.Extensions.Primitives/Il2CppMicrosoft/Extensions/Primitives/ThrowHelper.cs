using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Primitives
{
	// Token: 0x0200000A RID: 10
	public static class ThrowHelper : Object
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002878 File Offset: 0x00000A78
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowHelper()
		{
			Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Primitives.dll", "Microsoft.Extensions.Primitives", "ThrowHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663319);
			ThrowHelper.NativeMethodInfoPtr_GetArgumentName_Private_Static_String_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663320);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000028D0 File Offset: 0x00000AD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273031, RefRangeEnd = 1273033, XrefRangeStart = 1273021, XrefRangeEnd = 1273031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentNullException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002904 File Offset: 0x00000B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273036, RefRangeEnd = 1273037, XrefRangeStart = 1273033, XrefRangeEnd = 1273036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetArgumentName(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArgumentName_Private_Static_String_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021B3 File Offset: 0x000003B3
		public ThrowHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentName_Private_Static_String_ExceptionArgument_0;
	}
}
