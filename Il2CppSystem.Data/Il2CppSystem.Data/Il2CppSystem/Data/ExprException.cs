using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x0200005D RID: 93
	public sealed class ExprException : Object
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
		// Note: this type is marked as 'beforefieldinit'.
		static ExprException()
		{
			Il2CppClassPointerStore<ExprException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ExprException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExprException>.NativeClassPtr);
			ExprException.NativeMethodInfoPtr__Overflow_Private_Static_OverflowException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664778);
			ExprException.NativeMethodInfoPtr__Expr_Private_Static_InvalidExpressionException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664779);
			ExprException.NativeMethodInfoPtr__Syntax_Private_Static_SyntaxErrorException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664780);
			ExprException.NativeMethodInfoPtr__Eval_Private_Static_EvaluateException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664781);
			ExprException.NativeMethodInfoPtr__Eval_Private_Static_EvaluateException_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664782);
			ExprException.NativeMethodInfoPtr_InvokeArgument_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664783);
			ExprException.NativeMethodInfoPtr_NYI_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664784);
			ExprException.NativeMethodInfoPtr_MissingOperand_Public_Static_Exception_OperatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664785);
			ExprException.NativeMethodInfoPtr_MissingOperator_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664786);
			ExprException.NativeMethodInfoPtr_TypeMismatch_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664787);
			ExprException.NativeMethodInfoPtr_FunctionArgumentOutOfRange_Public_Static_Exception_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664788);
			ExprException.NativeMethodInfoPtr_ExpressionTooComplex_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664789);
			ExprException.NativeMethodInfoPtr_UnboundName_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664790);
			ExprException.NativeMethodInfoPtr_InvalidString_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664791);
			ExprException.NativeMethodInfoPtr_UndefinedFunction_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664792);
			ExprException.NativeMethodInfoPtr_SyntaxError_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664793);
			ExprException.NativeMethodInfoPtr_FunctionArgumentCount_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664794);
			ExprException.NativeMethodInfoPtr_MissingRightParen_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664795);
			ExprException.NativeMethodInfoPtr_UnknownToken_Public_Static_Exception_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664796);
			ExprException.NativeMethodInfoPtr_UnknownToken_Public_Static_Exception_Tokens_Tokens_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664797);
			ExprException.NativeMethodInfoPtr_DatatypeConvertion_Public_Static_Exception_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664798);
			ExprException.NativeMethodInfoPtr_DatavalueConvertion_Public_Static_Exception_Object_Type_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664799);
			ExprException.NativeMethodInfoPtr_InvalidName_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664800);
			ExprException.NativeMethodInfoPtr_InvalidDate_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664801);
			ExprException.NativeMethodInfoPtr_NonConstantArgument_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664802);
			ExprException.NativeMethodInfoPtr_InvalidPattern_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664803);
			ExprException.NativeMethodInfoPtr_InWithoutParentheses_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664804);
			ExprException.NativeMethodInfoPtr_InWithoutList_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664805);
			ExprException.NativeMethodInfoPtr_InvalidIsSyntax_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664806);
			ExprException.NativeMethodInfoPtr_Overflow_Public_Static_Exception_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664807);
			ExprException.NativeMethodInfoPtr_ArgumentType_Public_Static_Exception_String_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664808);
			ExprException.NativeMethodInfoPtr_ArgumentTypeInteger_Public_Static_Exception_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664809);
			ExprException.NativeMethodInfoPtr_TypeMismatchInBinop_Public_Static_Exception_Int32_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664810);
			ExprException.NativeMethodInfoPtr_AmbiguousBinop_Public_Static_Exception_Int32_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664811);
			ExprException.NativeMethodInfoPtr_UnsupportedOperator_Public_Static_Exception_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664812);
			ExprException.NativeMethodInfoPtr_InvalidNameBracketing_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664813);
			ExprException.NativeMethodInfoPtr_MissingOperandBefore_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664814);
			ExprException.NativeMethodInfoPtr_TooManyRightParentheses_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664815);
			ExprException.NativeMethodInfoPtr_UnresolvedRelation_Public_Static_Exception_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664816);
			ExprException.NativeMethodInfoPtr_BindFailure_Internal_Static_EvaluateException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664817);
			ExprException.NativeMethodInfoPtr_AggregateArgument_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664818);
			ExprException.NativeMethodInfoPtr_AggregateUnbound_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664819);
			ExprException.NativeMethodInfoPtr_EvalNoContext_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664820);
			ExprException.NativeMethodInfoPtr_ExpressionUnbound_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664821);
			ExprException.NativeMethodInfoPtr_ComputeNotAggregate_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664822);
			ExprException.NativeMethodInfoPtr_FilterConvertion_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664823);
			ExprException.NativeMethodInfoPtr_LookupArgument_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664824);
			ExprException.NativeMethodInfoPtr_InvalidType_Public_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664825);
			ExprException.NativeMethodInfoPtr_InvalidHoursArgument_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664826);
			ExprException.NativeMethodInfoPtr_InvalidMinutesArgument_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664827);
			ExprException.NativeMethodInfoPtr_InvalidTimeZoneRange_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664828);
			ExprException.NativeMethodInfoPtr_MismatchKindandTimeSpan_Public_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664829);
			ExprException.NativeMethodInfoPtr_UnsupportedDataType_Public_Static_Exception_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprException>.NativeClassPtr, 100664830);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002FE44 File Offset: 0x0002E044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904105, XrefRangeEnd = 904110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OverflowException _Overflow(string error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr__Overflow_Private_Static_OverflowException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OverflowException>(intPtr3) : null;
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0002FE88 File Offset: 0x0002E088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904110, XrefRangeEnd = 904115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InvalidExpressionException _Expr(string error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr__Expr_Private_Static_InvalidExpressionException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvalidExpressionException>(intPtr3) : null;
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0002FECC File Offset: 0x0002E0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904115, XrefRangeEnd = 904120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SyntaxErrorException _Syntax(string error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr__Syntax_Private_Static_SyntaxErrorException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SyntaxErrorException>(intPtr3) : null;
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0002FF10 File Offset: 0x0002E110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904120, XrefRangeEnd = 904125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EvaluateException _Eval(string error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr__Eval_Private_Static_EvaluateException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EvaluateException>(intPtr3) : null;
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002FF54 File Offset: 0x0002E154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904125, XrefRangeEnd = 904130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EvaluateException _Eval(string error, Exception innerException)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr__Eval_Private_Static_EvaluateException_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EvaluateException>(intPtr3) : null;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0002FFAC File Offset: 0x0002E1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904130, XrefRangeEnd = 904133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvokeArgument()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvokeArgument_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0002FFE0 File Offset: 0x0002E1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904133, XrefRangeEnd = 904141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NYI(string moreinfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(moreinfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_NYI_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00030024 File Offset: 0x0002E224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904141, XrefRangeEnd = 904153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MissingOperand(OperatorInfo before)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(before);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_MissingOperand_Public_Static_Exception_OperatorInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00030068 File Offset: 0x0002E268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904153, XrefRangeEnd = 904161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MissingOperator(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_MissingOperator_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000300AC File Offset: 0x0002E2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904161, XrefRangeEnd = 904169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeMismatch(string expr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_TypeMismatch_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000300F0 File Offset: 0x0002E2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904169, XrefRangeEnd = 904173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FunctionArgumentOutOfRange(string arg, string func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_FunctionArgumentOutOfRange_Public_Static_Exception_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00030148 File Offset: 0x0002E348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904180, RefRangeEnd = 904181, XrefRangeStart = 904173, XrefRangeEnd = 904180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTooComplex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_ExpressionTooComplex_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0003017C File Offset: 0x0002E37C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 904189, RefRangeEnd = 904191, XrefRangeStart = 904181, XrefRangeEnd = 904189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnboundName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_UnboundName_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000301C0 File Offset: 0x0002E3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904191, XrefRangeEnd = 904199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidString_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00030204 File Offset: 0x0002E404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904207, RefRangeEnd = 904208, XrefRangeStart = 904199, XrefRangeEnd = 904207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UndefinedFunction(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_UndefinedFunction_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00030248 File Offset: 0x0002E448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904208, XrefRangeEnd = 904215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception SyntaxError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_SyntaxError_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0003027C File Offset: 0x0002E47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904223, RefRangeEnd = 904224, XrefRangeStart = 904215, XrefRangeEnd = 904223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FunctionArgumentCount(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_FunctionArgumentCount_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000302C0 File Offset: 0x0002E4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904224, XrefRangeEnd = 904231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MissingRightParen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_MissingRightParen_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000302F4 File Offset: 0x0002E4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904231, XrefRangeEnd = 904244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnknownToken(string token, int position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_UnknownToken_Public_Static_Exception_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00030348 File Offset: 0x0002E548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904244, XrefRangeEnd = 904262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tokExpected;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokCurr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_UnknownToken_Public_Static_Exception_Tokens_Tokens_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000303A4 File Offset: 0x0002E5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904262, XrefRangeEnd = 904270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception DatatypeConvertion(Type type1, Type type2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_DatatypeConvertion_Public_Static_Exception_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000303FC File Offset: 0x0002E5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904270, XrefRangeEnd = 904278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception DatavalueConvertion(Object value, Type type, Exception innerException)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_DatavalueConvertion_Public_Static_Exception_Object_Type_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00030464 File Offset: 0x0002E664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904278, XrefRangeEnd = 904286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidName_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000304A8 File Offset: 0x0002E6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904286, XrefRangeEnd = 904294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidDate(string date)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(date);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidDate_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000304EC File Offset: 0x0002E6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904294, XrefRangeEnd = 904301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NonConstantArgument()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_NonConstantArgument_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00030520 File Offset: 0x0002E720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904301, XrefRangeEnd = 904309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidPattern(string pat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidPattern_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00030564 File Offset: 0x0002E764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904309, XrefRangeEnd = 904316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InWithoutParentheses()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InWithoutParentheses_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00030598 File Offset: 0x0002E798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904316, XrefRangeEnd = 904323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InWithoutList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InWithoutList_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000305CC File Offset: 0x0002E7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904323, XrefRangeEnd = 904330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidIsSyntax()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidIsSyntax_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00030600 File Offset: 0x0002E800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904330, XrefRangeEnd = 904338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception Overflow(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_Overflow_Public_Static_Exception_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00030644 File Offset: 0x0002E844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904338, XrefRangeEnd = 904351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentType(string function, int arg, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_ArgumentType_Public_Static_Exception_String_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000306A8 File Offset: 0x0002E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904351, XrefRangeEnd = 904364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentTypeInteger(string function, int arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_ArgumentTypeInteger_Public_Static_Exception_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000306FC File Offset: 0x0002E8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904376, RefRangeEnd = 904377, XrefRangeStart = 904364, XrefRangeEnd = 904376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeMismatchInBinop(int op, Type type1, Type type2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_TypeMismatchInBinop_Public_Static_Exception_Int32_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00030760 File Offset: 0x0002E960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904377, XrefRangeEnd = 904389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception AmbiguousBinop(int op, Type type1, Type type2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_AmbiguousBinop_Public_Static_Exception_Int32_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000307C4 File Offset: 0x0002E9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904389, XrefRangeEnd = 904401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnsupportedOperator(int op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_UnsupportedOperator_Public_Static_Exception_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00030804 File Offset: 0x0002EA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904401, XrefRangeEnd = 904409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidNameBracketing(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidNameBracketing_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00030848 File Offset: 0x0002EA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904409, XrefRangeEnd = 904417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MissingOperandBefore(string op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_MissingOperandBefore_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0003088C File Offset: 0x0002EA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904417, XrefRangeEnd = 904424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TooManyRightParentheses()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_TooManyRightParentheses_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000308C0 File Offset: 0x0002EAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904424, XrefRangeEnd = 904432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnresolvedRelation(string name, string expr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_UnresolvedRelation_Public_Static_Exception_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00030918 File Offset: 0x0002EB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904432, XrefRangeEnd = 904440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EvaluateException BindFailure(string relationName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_BindFailure_Internal_Static_EvaluateException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EvaluateException>(intPtr3) : null;
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0003095C File Offset: 0x0002EB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904440, XrefRangeEnd = 904447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception AggregateArgument()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_AggregateArgument_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00030990 File Offset: 0x0002EB90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 904455, RefRangeEnd = 904458, XrefRangeStart = 904447, XrefRangeEnd = 904455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception AggregateUnbound(string expr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_AggregateUnbound_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000309D4 File Offset: 0x0002EBD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 904465, RefRangeEnd = 904468, XrefRangeStart = 904458, XrefRangeEnd = 904465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception EvalNoContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_EvalNoContext_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00030A08 File Offset: 0x0002EC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904468, XrefRangeEnd = 904476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionUnbound(string expr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_ExpressionUnbound_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00030A4C File Offset: 0x0002EC4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 904484, RefRangeEnd = 904488, XrefRangeStart = 904476, XrefRangeEnd = 904484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ComputeNotAggregate(string expr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_ComputeNotAggregate_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00030A90 File Offset: 0x0002EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904488, XrefRangeEnd = 904496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FilterConvertion(string expr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_FilterConvertion_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00030AD4 File Offset: 0x0002ECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904496, XrefRangeEnd = 904503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception LookupArgument()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_LookupArgument_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00030B08 File Offset: 0x0002ED08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904503, XrefRangeEnd = 904511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidType(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidType_Public_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00030B4C File Offset: 0x0002ED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904511, XrefRangeEnd = 904518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidHoursArgument()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidHoursArgument_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00030B80 File Offset: 0x0002ED80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904518, XrefRangeEnd = 904525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidMinutesArgument()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidMinutesArgument_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00030BB4 File Offset: 0x0002EDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904525, XrefRangeEnd = 904532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidTimeZoneRange()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_InvalidTimeZoneRange_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00030BE8 File Offset: 0x0002EDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904532, XrefRangeEnd = 904539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MismatchKindandTimeSpan()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_MismatchKindandTimeSpan_Public_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00030C1C File Offset: 0x0002EE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904539, XrefRangeEnd = 904544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnsupportedDataType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprException.NativeMethodInfoPtr_UnsupportedDataType_Public_Static_Exception_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00004C9D File Offset: 0x00002E9D
		public ExprException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr__Overflow_Private_Static_OverflowException_String_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr__Expr_Private_Static_InvalidExpressionException_String_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr__Syntax_Private_Static_SyntaxErrorException_String_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr__Eval_Private_Static_EvaluateException_String_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr__Eval_Private_Static_EvaluateException_String_Exception_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_InvokeArgument_Public_Static_Exception_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_NYI_Public_Static_Exception_String_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_MissingOperand_Public_Static_Exception_OperatorInfo_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_MissingOperator_Public_Static_Exception_String_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_TypeMismatch_Public_Static_Exception_String_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_FunctionArgumentOutOfRange_Public_Static_Exception_String_String_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTooComplex_Public_Static_Exception_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_UnboundName_Public_Static_Exception_String_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_InvalidString_Public_Static_Exception_String_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_UndefinedFunction_Public_Static_Exception_String_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_SyntaxError_Public_Static_Exception_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_FunctionArgumentCount_Public_Static_Exception_String_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_MissingRightParen_Public_Static_Exception_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_UnknownToken_Public_Static_Exception_String_Int32_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_UnknownToken_Public_Static_Exception_Tokens_Tokens_Int32_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_DatatypeConvertion_Public_Static_Exception_Type_Type_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_DatavalueConvertion_Public_Static_Exception_Object_Type_Exception_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_InvalidName_Public_Static_Exception_String_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_InvalidDate_Public_Static_Exception_String_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_NonConstantArgument_Public_Static_Exception_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_InvalidPattern_Public_Static_Exception_String_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_InWithoutParentheses_Public_Static_Exception_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_InWithoutList_Public_Static_Exception_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_InvalidIsSyntax_Public_Static_Exception_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_Overflow_Public_Static_Exception_Type_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentType_Public_Static_Exception_String_Int32_Type_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentTypeInteger_Public_Static_Exception_String_Int32_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_TypeMismatchInBinop_Public_Static_Exception_Int32_Type_Type_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_AmbiguousBinop_Public_Static_Exception_Int32_Type_Type_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_UnsupportedOperator_Public_Static_Exception_Int32_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_InvalidNameBracketing_Public_Static_Exception_String_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_MissingOperandBefore_Public_Static_Exception_String_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_TooManyRightParentheses_Public_Static_Exception_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_UnresolvedRelation_Public_Static_Exception_String_String_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_BindFailure_Internal_Static_EvaluateException_String_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_AggregateArgument_Public_Static_Exception_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_AggregateUnbound_Public_Static_Exception_String_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_EvalNoContext_Public_Static_Exception_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionUnbound_Public_Static_Exception_String_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_ComputeNotAggregate_Public_Static_Exception_String_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_FilterConvertion_Public_Static_Exception_String_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_LookupArgument_Public_Static_Exception_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_InvalidType_Public_Static_Exception_String_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_InvalidHoursArgument_Public_Static_Exception_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_InvalidMinutesArgument_Public_Static_Exception_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_InvalidTimeZoneRange_Public_Static_Exception_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_MismatchKindandTimeSpan_Public_Static_Exception_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_UnsupportedDataType_Public_Static_Exception_Type_0;
	}
}
