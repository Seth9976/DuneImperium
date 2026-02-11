using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Linq.Expressions;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x0200012B RID: 299
	public static class ExpressionVisitorUtils : Object
	{
		// Token: 0x06001173 RID: 4467 RVA: 0x0005B4D0 File Offset: 0x000596D0
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionVisitorUtils()
		{
			Il2CppClassPointerStore<ExpressionVisitorUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "ExpressionVisitorUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionVisitorUtils>.NativeClassPtr);
			ExpressionVisitorUtils.NativeMethodInfoPtr_VisitBlockExpressions_Public_Static_Il2CppReferenceArray_1_Expression_ExpressionVisitor_BlockExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitorUtils>.NativeClassPtr, 100666605);
			ExpressionVisitorUtils.NativeMethodInfoPtr_VisitParameters_Public_Static_Il2CppReferenceArray_1_ParameterExpression_ExpressionVisitor_IParameterProvider_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitorUtils>.NativeClassPtr, 100666606);
			ExpressionVisitorUtils.NativeMethodInfoPtr_VisitArguments_Public_Static_Il2CppReferenceArray_1_Expression_ExpressionVisitor_IArgumentProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitorUtils>.NativeClassPtr, 100666607);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0005B53C File Offset: 0x0005973C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1030294, RefRangeEnd = 1030296, XrefRangeStart = 1030285, XrefRangeEnd = 1030294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Expression> VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(block);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitorUtils.NativeMethodInfoPtr_VisitBlockExpressions_Public_Static_Il2CppReferenceArray_1_Expression_ExpressionVisitor_BlockExpression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr3) : null;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0005B594 File Offset: 0x00059794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1030318, RefRangeEnd = 1030319, XrefRangeStart = 1030296, XrefRangeEnd = 1030318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterExpression> VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(callerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitorUtils.NativeMethodInfoPtr_VisitParameters_Public_Static_Il2CppReferenceArray_1_ParameterExpression_ExpressionVisitor_IParameterProvider_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterExpression>>(intPtr3) : null;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0005B5FC File Offset: 0x000597FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1030338, RefRangeEnd = 1030342, XrefRangeStart = 1030319, XrefRangeEnd = 1030338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Expression> VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitorUtils.NativeMethodInfoPtr_VisitArguments_Public_Static_Il2CppReferenceArray_1_Expression_ExpressionVisitor_IArgumentProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr3) : null;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00007552 File Offset: 0x00005752
		public ExpressionVisitorUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_VisitBlockExpressions_Public_Static_Il2CppReferenceArray_1_Expression_ExpressionVisitor_BlockExpression_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_VisitParameters_Public_Static_Il2CppReferenceArray_1_ParameterExpression_ExpressionVisitor_IParameterProvider_String_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_VisitArguments_Public_Static_Il2CppReferenceArray_1_Expression_ExpressionVisitor_IArgumentProvider_0;
	}
}
