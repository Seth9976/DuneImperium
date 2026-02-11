using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000046 RID: 70
	public sealed class ExpressionStringBuilder : ExpressionVisitor
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x000254B8 File Offset: 0x000236B8
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionStringBuilder()
		{
			Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ExpressionStringBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr);
			ExpressionStringBuilder.NativeFieldInfoPtr__out = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, "_out");
			ExpressionStringBuilder.NativeFieldInfoPtr__ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, "_ids");
			ExpressionStringBuilder.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664315);
			ExpressionStringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664316);
			ExpressionStringBuilder.NativeMethodInfoPtr_GetLabelId_Private_Int32_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664317);
			ExpressionStringBuilder.NativeMethodInfoPtr_GetParamId_Private_Int32_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664318);
			ExpressionStringBuilder.NativeMethodInfoPtr_GetId_Private_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664319);
			ExpressionStringBuilder.NativeMethodInfoPtr_Out_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664320);
			ExpressionStringBuilder.NativeMethodInfoPtr_Out_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664321);
			ExpressionStringBuilder.NativeMethodInfoPtr_ExpressionToString_Internal_Static_String_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664322);
			ExpressionStringBuilder.NativeMethodInfoPtr_CatchBlockToString_Internal_Static_String_CatchBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664323);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664324);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664325);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitBinary_FamOrAssem_Virtual_Expression_BinaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664326);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664327);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664328);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitConditional_FamOrAssem_Virtual_Expression_ConditionalExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664329);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitConstant_FamOrAssem_Virtual_Expression_ConstantExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664330);
			ExpressionStringBuilder.NativeMethodInfoPtr_OutMember_Private_Void_Expression_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664331);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitMember_FamOrAssem_Virtual_Expression_MemberExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664332);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitInvocation_FamOrAssem_Virtual_Expression_InvocationExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664333);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitMethodCall_FamOrAssem_Virtual_Expression_MethodCallExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664334);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitNewArray_FamOrAssem_Virtual_Expression_NewArrayExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664335);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitTypeBinary_FamOrAssem_Virtual_Expression_TypeBinaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664336);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitUnary_FamOrAssem_Virtual_Expression_UnaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664337);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664338);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitDefault_FamOrAssem_Virtual_Expression_DefaultExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664339);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitLabel_FamOrAssem_Virtual_Expression_LabelExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664340);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitGoto_FamOrAssem_Virtual_Expression_GotoExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664341);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitLoop_FamOrAssem_Virtual_Expression_LoopExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664342);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664343);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitTry_FamOrAssem_Virtual_Expression_TryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664344);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitIndex_FamOrAssem_Virtual_Expression_IndexExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664345);
			ExpressionStringBuilder.NativeMethodInfoPtr_VisitExtension_FamOrAssem_Virtual_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664346);
			ExpressionStringBuilder.NativeMethodInfoPtr_DumpLabel_Private_Void_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664347);
			ExpressionStringBuilder.NativeMethodInfoPtr_IsBool_Private_Static_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr, 100664348);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000257B8 File Offset: 0x000239B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013165, XrefRangeEnd = 1013171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionStringBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000257F4 File Offset: 0x000239F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 549125, RefRangeEnd = 549132, XrefRangeStart = 549125, XrefRangeEnd = 549132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0002582C File Offset: 0x00023A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013171, XrefRangeEnd = 1013172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLabelId(LabelTarget label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_GetLabelId_Private_Int32_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0002587C File Offset: 0x00023A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParamId(ParameterExpression p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_GetParamId_Private_Int32_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000258CC File Offset: 0x00023ACC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1013188, RefRangeEnd = 1013192, XrefRangeStart = 1013172, XrefRangeEnd = 1013188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetId(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_GetId_Private_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0002591C File Offset: 0x00023B1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1013194, RefRangeEnd = 1013198, XrefRangeStart = 1013192, XrefRangeEnd = 1013194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Out(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_Out_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00025960 File Offset: 0x00023B60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1013200, RefRangeEnd = 1013204, XrefRangeStart = 1013198, XrefRangeEnd = 1013200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Out(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_Out_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000259A0 File Offset: 0x00023BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013213, RefRangeEnd = 1013214, XrefRangeStart = 1013204, XrefRangeEnd = 1013213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpressionToString(Expression node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_ExpressionToString_Internal_Static_String_Expression_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000259DC File Offset: 0x00023BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CatchBlockToString(CatchBlock node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_CatchBlockToString_Internal_Static_String_CatchBlock_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00025A18 File Offset: 0x00023C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013218, RefRangeEnd = 1013219, XrefRangeStart = 1013214, XrefRangeEnd = 1013218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) where T : Expression
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref open;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expressions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref close;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.MethodInfoStoreGeneric_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00025A78 File Offset: 0x00023C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013238, RefRangeEnd = 1013239, XrefRangeStart = 1013219, XrefRangeEnd = 1013238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) where T : Expression
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref open;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expressions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref close;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seperator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.MethodInfoStoreGeneric_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00025AEC File Offset: 0x00023CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013239, XrefRangeEnd = 1013353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitBinary(BinaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitBinary_FamOrAssem_Virtual_Expression_BinaryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00025B3C File Offset: 0x00023D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013353, XrefRangeEnd = 1013363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitParameter(ParameterExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00025B8C File Offset: 0x00023D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013363, XrefRangeEnd = 1013374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitLambda<T>(Expression<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.MethodInfoStoreGeneric_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00025BDC File Offset: 0x00023DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013374, XrefRangeEnd = 1013383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitConditional(ConditionalExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitConditional_FamOrAssem_Virtual_Expression_ConditionalExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00025C2C File Offset: 0x00023E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013383, XrefRangeEnd = 1013388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitConstant(ConstantExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitConstant_FamOrAssem_Virtual_Expression_ConstantExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00025C7C File Offset: 0x00023E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013388, XrefRangeEnd = 1013393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OutMember(Expression instance, MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_OutMember_Private_Void_Expression_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00025CD0 File Offset: 0x00023ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013393, XrefRangeEnd = 1013397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitMember(MemberExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitMember_FamOrAssem_Virtual_Expression_MemberExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00025D20 File Offset: 0x00023F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013397, XrefRangeEnd = 1013404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitInvocation(InvocationExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitInvocation_FamOrAssem_Virtual_Expression_InvocationExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00025D70 File Offset: 0x00023F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013404, XrefRangeEnd = 1013418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitMethodCall(MethodCallExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitMethodCall_FamOrAssem_Virtual_Expression_MethodCallExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00025DC0 File Offset: 0x00023FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013418, XrefRangeEnd = 1013429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitNewArray(NewArrayExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitNewArray_FamOrAssem_Virtual_Expression_NewArrayExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00025E10 File Offset: 0x00024010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013429, XrefRangeEnd = 1013438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitTypeBinary(TypeBinaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitTypeBinary_FamOrAssem_Virtual_Expression_TypeBinaryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00025E60 File Offset: 0x00024060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013438, XrefRangeEnd = 1013492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitUnary(UnaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitUnary_FamOrAssem_Virtual_Expression_UnaryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00025EB0 File Offset: 0x000240B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013492, XrefRangeEnd = 1013516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitBlock(BlockExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00025F00 File Offset: 0x00024100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013516, XrefRangeEnd = 1013521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitDefault(DefaultExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitDefault_FamOrAssem_Virtual_Expression_DefaultExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00025F50 File Offset: 0x00024150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013521, XrefRangeEnd = 1013526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitLabel(LabelExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitLabel_FamOrAssem_Virtual_Expression_LabelExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00025FA0 File Offset: 0x000241A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013526, XrefRangeEnd = 1013546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitGoto(GotoExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitGoto_FamOrAssem_Virtual_Expression_GotoExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00025FF0 File Offset: 0x000241F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013546, XrefRangeEnd = 1013549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitLoop(LoopExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitLoop_FamOrAssem_Virtual_Expression_LoopExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00026040 File Offset: 0x00024240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013549, XrefRangeEnd = 1013559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CatchBlock VisitCatchBlock(CatchBlock node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CatchBlock>(intPtr3) : null;
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00026090 File Offset: 0x00024290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013559, XrefRangeEnd = 1013562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitTry(TryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitTry_FamOrAssem_Virtual_Expression_TryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000260E0 File Offset: 0x000242E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013562, XrefRangeEnd = 1013576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitIndex(IndexExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitIndex_FamOrAssem_Virtual_Expression_IndexExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00026130 File Offset: 0x00024330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013576, XrefRangeEnd = 1013591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitExtension(Expression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_VisitExtension_FamOrAssem_Virtual_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00026180 File Offset: 0x00024380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1013598, RefRangeEnd = 1013600, XrefRangeStart = 1013591, XrefRangeEnd = 1013598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DumpLabel(LabelTarget target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_DumpLabel_Private_Void_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000261C4 File Offset: 0x000243C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1013608, RefRangeEnd = 1013612, XrefRangeStart = 1013600, XrefRangeEnd = 1013608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBool(Expression node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionStringBuilder.NativeMethodInfoPtr_IsBool_Private_Static_Boolean_Expression_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002E56 File Offset: 0x00001056
		public ExpressionStringBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00026208 File Offset: 0x00024408
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00002E5F File Offset: 0x0000105F
		public unsafe StringBuilder _out
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionStringBuilder.NativeFieldInfoPtr__out);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionStringBuilder.NativeFieldInfoPtr__out), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00026238 File Offset: 0x00024438
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00002E7E File Offset: 0x0000107E
		public unsafe Dictionary<Object, int> _ids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionStringBuilder.NativeFieldInfoPtr__ids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionStringBuilder.NativeFieldInfoPtr__ids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeFieldInfoPtr__out;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeFieldInfoPtr__ids;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_GetLabelId_Private_Int32_LabelTarget_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_GetParamId_Private_Int32_ParameterExpression_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Private_Int32_Object_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_Out_Private_Void_String_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_Out_Private_Void_Char_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionToString_Internal_Static_String_Expression_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_CatchBlockToString_Internal_Static_String_CatchBlock_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_String_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_VisitBinary_FamOrAssem_Virtual_Expression_BinaryExpression_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_VisitConditional_FamOrAssem_Virtual_Expression_ConditionalExpression_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstant_FamOrAssem_Virtual_Expression_ConstantExpression_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_OutMember_Private_Void_Expression_MemberInfo_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_VisitMember_FamOrAssem_Virtual_Expression_MemberExpression_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_VisitInvocation_FamOrAssem_Virtual_Expression_InvocationExpression_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_VisitMethodCall_FamOrAssem_Virtual_Expression_MethodCallExpression_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_VisitNewArray_FamOrAssem_Virtual_Expression_NewArrayExpression_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_VisitTypeBinary_FamOrAssem_Virtual_Expression_TypeBinaryExpression_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_VisitUnary_FamOrAssem_Virtual_Expression_UnaryExpression_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_VisitDefault_FamOrAssem_Virtual_Expression_DefaultExpression_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_VisitLabel_FamOrAssem_Virtual_Expression_LabelExpression_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_VisitGoto_FamOrAssem_Virtual_Expression_GotoExpression_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_VisitLoop_FamOrAssem_Virtual_Expression_LoopExpression_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_VisitTry_FamOrAssem_Virtual_Expression_TryExpression_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_VisitIndex_FamOrAssem_Virtual_Expression_IndexExpression_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_VisitExtension_FamOrAssem_Virtual_Expression_Expression_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_DumpLabel_Private_Void_LabelTarget_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_IsBool_Private_Static_Boolean_Expression_0;

		// Token: 0x020001DD RID: 477
		private sealed class MethodInfoStoreGeneric_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_0<T>
		{
			// Token: 0x04000FBA RID: 4026
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionStringBuilder.NativeMethodInfoPtr_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_0, Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001DE RID: 478
		private sealed class MethodInfoStoreGeneric_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_String_0<T>
		{
			// Token: 0x04000FBB RID: 4027
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionStringBuilder.NativeMethodInfoPtr_VisitExpressions_Private_Void_Char_ReadOnlyCollection_1_T_Char_String_0, Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001DF RID: 479
		private sealed class MethodInfoStoreGeneric_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0<T>
		{
			// Token: 0x04000FBC RID: 4028
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionStringBuilder.NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0, Il2CppClassPointerStore<ExpressionStringBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
