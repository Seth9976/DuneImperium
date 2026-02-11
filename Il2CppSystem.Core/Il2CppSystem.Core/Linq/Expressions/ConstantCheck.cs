using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200003C RID: 60
	public static class ConstantCheck : Object
	{
		// Token: 0x06000370 RID: 880 RVA: 0x00021020 File Offset: 0x0001F220
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantCheck()
		{
			Il2CppClassPointerStore<ConstantCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ConstantCheck");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantCheck>.NativeClassPtr);
			ConstantCheck.NativeMethodInfoPtr_AnalyzeTypeIs_Internal_Static_AnalyzeTypeIsResult_TypeBinaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantCheck>.NativeClassPtr, 100664146);
			ConstantCheck.NativeMethodInfoPtr_AnalyzeTypeIs_Private_Static_AnalyzeTypeIsResult_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantCheck>.NativeClassPtr, 100664147);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00021078 File Offset: 0x0001F278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012098, RefRangeEnd = 1012100, XrefRangeStart = 1012096, XrefRangeEnd = 1012098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalyzeTypeIsResult AnalyzeTypeIs(TypeBinaryExpression typeIs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeIs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantCheck.NativeMethodInfoPtr_AnalyzeTypeIs_Internal_Static_AnalyzeTypeIsResult_TypeBinaryExpression_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000210BC File Offset: 0x0001F2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012118, RefRangeEnd = 1012119, XrefRangeStart = 1012100, XrefRangeEnd = 1012118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalyzeTypeIsResult AnalyzeTypeIs(Expression operand, Type testType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operand);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(testType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantCheck.NativeMethodInfoPtr_AnalyzeTypeIs_Private_Static_AnalyzeTypeIsResult_Expression_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002CC6 File Offset: 0x00000EC6
		public ConstantCheck(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_AnalyzeTypeIs_Internal_Static_AnalyzeTypeIsResult_TypeBinaryExpression_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_AnalyzeTypeIs_Private_Static_AnalyzeTypeIsResult_Expression_Type_0;
	}
}
