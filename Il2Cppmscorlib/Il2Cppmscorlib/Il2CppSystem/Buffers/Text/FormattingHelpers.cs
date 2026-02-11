using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Buffers.Text
{
	// Token: 0x02000519 RID: 1305
	public static class FormattingHelpers : Object
	{
		// Token: 0x06004FBA RID: 20410 RVA: 0x00172F60 File Offset: 0x00171160
		// Note: this type is marked as 'beforefieldinit'.
		static FormattingHelpers()
		{
			Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers.Text", "FormattingHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr);
			FormattingHelpers.NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr, 100675325);
			FormattingHelpers.NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr, 100675326);
			FormattingHelpers.NativeMethodInfoPtr_CountHexDigits_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr, 100675327);
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x00172FCC File Offset: 0x001711CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1426803, RefRangeEnd = 1426807, XrefRangeStart = 1426802, XrefRangeEnd = 1426803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountDigits(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingHelpers.NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x0017300C File Offset: 0x0017120C
		[CallerCount(0)]
		public unsafe static int CountDigits(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingHelpers.NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x0017304C File Offset: 0x0017124C
		[CallerCount(0)]
		public unsafe static int CountHexDigits(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingHelpers.NativeMethodInfoPtr_CountHexDigits_Public_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		public FormattingHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040040F5 RID: 16629
		private static readonly IntPtr NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt64_0;

		// Token: 0x040040F6 RID: 16630
		private static readonly IntPtr NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt32_0;

		// Token: 0x040040F7 RID: 16631
		private static readonly IntPtr NativeMethodInfoPtr_CountHexDigits_Public_Static_Int32_UInt64_0;
	}
}
