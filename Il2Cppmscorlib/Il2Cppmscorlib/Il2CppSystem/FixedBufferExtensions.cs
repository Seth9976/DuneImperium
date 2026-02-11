using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200010F RID: 271
	public static class FixedBufferExtensions : Object
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x0007DEDC File Offset: 0x0007C0DC
		// Note: this type is marked as 'beforefieldinit'.
		static FixedBufferExtensions()
		{
			Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FixedBufferExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr);
			FixedBufferExtensions.NativeMethodInfoPtr_GetStringFromFixedBuffer_Internal_Static_String_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr, 100666485);
			FixedBufferExtensions.NativeMethodInfoPtr_GetFixedBufferStringLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr, 100666486);
			FixedBufferExtensions.NativeMethodInfoPtr_FixedBufferEqualsString_Internal_Static_Boolean_ReadOnlySpan_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr, 100666487);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0007DF48 File Offset: 0x0007C148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1333663, RefRangeEnd = 1333665, XrefRangeStart = 1333655, XrefRangeEnd = 1333663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringFromFixedBuffer(this ReadOnlySpan<char> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferExtensions.NativeMethodInfoPtr_GetStringFromFixedBuffer_Internal_Static_String_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0007DF8C File Offset: 0x0007C18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333665, XrefRangeEnd = 1333669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFixedBufferStringLength(this ReadOnlySpan<char> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferExtensions.NativeMethodInfoPtr_GetFixedBufferStringLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0007DFD4 File Offset: 0x0007C1D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1333675, RefRangeEnd = 1333677, XrefRangeStart = 1333669, XrefRangeEnd = 1333675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FixedBufferEqualsString(this ReadOnlySpan<char> span, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferExtensions.NativeMethodInfoPtr_FixedBufferEqualsString_Internal_Static_Boolean_ReadOnlySpan_1_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00006070 File Offset: 0x00004270
		public FixedBufferExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_GetStringFromFixedBuffer_Internal_Static_String_ReadOnlySpan_1_Char_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_GetFixedBufferStringLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_FixedBufferEqualsString_Internal_Static_Boolean_ReadOnlySpan_1_Char_String_0;
	}
}
