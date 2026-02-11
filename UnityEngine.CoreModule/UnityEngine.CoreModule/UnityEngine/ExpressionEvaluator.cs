using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200007F RID: 127
	public class ExpressionEvaluator : Object
	{
		// Token: 0x06000663 RID: 1635 RVA: 0x0002AB30 File Offset: 0x00028D30
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionEvaluator()
		{
			Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExpressionEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr);
			ExpressionEvaluator.NativeFieldInfoPtr_s_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "s_Random");
			ExpressionEvaluator.NativeFieldInfoPtr_s_Operators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "s_Operators");
			ExpressionEvaluator.NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664066);
			ExpressionEvaluator.NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664067);
			ExpressionEvaluator.NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664068);
			ExpressionEvaluator.NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664069);
			ExpressionEvaluator.NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664070);
			ExpressionEvaluator.NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664071);
			ExpressionEvaluator.NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664072);
			ExpressionEvaluator.NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664073);
			ExpressionEvaluator.NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664074);
			ExpressionEvaluator.NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664075);
			ExpressionEvaluator.NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664076);
			ExpressionEvaluator.NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664077);
			ExpressionEvaluator.NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664078);
			ExpressionEvaluator.NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664079);
			ExpressionEvaluator.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664080);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0002ACB4 File Offset: 0x00028EB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 647933, RefRangeEnd = 647938, XrefRangeStart = 647917, XrefRangeEnd = 647933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Evaluate<T>(string expression, out T value, out ExpressionEvaluator.Expression delayed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr3 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0<T>.Pointer, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr6 = intPtr;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			}
			IntPtr intPtr7 = intPtr3;
			delayed = ((intPtr7 == 0) ? null : new ExpressionEvaluator.Expression(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0002AD68 File Offset: 0x00028F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 648008, RefRangeEnd = 648010, XrefRangeStart = 647938, XrefRangeEnd = 648008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EvaluateTokens<T>(Il2CppStringArray tokens, ref T value, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0002ADF0 File Offset: 0x00028FF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 648094, RefRangeEnd = 648099, XrefRangeStart = 648010, XrefRangeEnd = 648094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EvaluateDouble(Il2CppStringArray tokens, ref double value, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0002AE5C File Offset: 0x0002905C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648186, RefRangeEnd = 648187, XrefRangeStart = 648099, XrefRangeEnd = 648186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InfixToRPN(Il2CppStringArray tokens)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0002AEA0 File Offset: 0x000290A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648195, RefRangeEnd = 648196, XrefRangeStart = 648187, XrefRangeEnd = 648195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NeedToPop(Stack<string> operatorStack, ExpressionEvaluator.Operator newOperator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operatorStack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newOperator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0002AEF4 File Offset: 0x000290F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648258, RefRangeEnd = 648259, XrefRangeStart = 648196, XrefRangeEnd = 648258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ExpressionToTokens(string expression, out bool hasVariables)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasVariables;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0002AF48 File Offset: 0x00029148
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 648261, RefRangeEnd = 648264, XrefRangeStart = 648259, XrefRangeEnd = 648261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCommand(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002AF8C File Offset: 0x0002918C
		[CallerCount(0)]
		public unsafe static bool IsVariable(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0002AFD0 File Offset: 0x000291D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 648268, RefRangeEnd = 648270, XrefRangeStart = 648264, XrefRangeEnd = 648268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDelayedFunction(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0002B014 File Offset: 0x00029214
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 648278, RefRangeEnd = 648282, XrefRangeStart = 648270, XrefRangeEnd = 648278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOperator(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0002B058 File Offset: 0x00029258
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 648289, RefRangeEnd = 648294, XrefRangeStart = 648282, XrefRangeEnd = 648289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExpressionEvaluator.Operator TokenToOperator(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionEvaluator.Operator>(intPtr3) : null;
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0002B09C File Offset: 0x0002929C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648322, RefRangeEnd = 648323, XrefRangeStart = 648294, XrefRangeEnd = 648322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PreFormatExpression(string expression)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002B0D8 File Offset: 0x000292D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648323, XrefRangeEnd = 648341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray FixUnaryOperators(Il2CppStringArray tokens)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0002B11C File Offset: 0x0002931C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648395, RefRangeEnd = 648396, XrefRangeStart = 648341, XrefRangeEnd = 648395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double EvaluateOp(Il2CppStructArray<double> values, ExpressionEvaluator.Op op, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0002B188 File Offset: 0x00029388
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 648508, RefRangeEnd = 648512, XrefRangeStart = 648396, XrefRangeEnd = 648508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse<T>(string expression, out T result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref result;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_TryParse_Private_Static_Boolean_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000048C1 File Offset: 0x00002AC1
		public ExpressionEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0002B218 File Offset: 0x00029418
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x000048CA File Offset: 0x00002ACA
		public unsafe static ExpressionEvaluator.PcgRandom s_Random
		{
			get
			{
				ExpressionEvaluator.PcgRandom pcgRandom;
				IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Random, (void*)(&pcgRandom));
				return pcgRandom;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Random, (void*)(&value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0002B234 File Offset: 0x00029434
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x000048D8 File Offset: 0x00002AD8
		public unsafe static Dictionary<string, ExpressionEvaluator.Operator> s_Operators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Operators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ExpressionEvaluator.Operator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Operators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0002B25C File Offset: 0x0002945C
		public static bool Evaluate<T>(string expression, out T value)
		{
			ExpressionEvaluator.Expression expression2;
			return ExpressionEvaluator.Evaluate<T>(expression, out value, out expression2);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000048EA File Offset: 0x00002AEA
		public static void SetRandomState(uint state)
		{
			ExpressionEvaluator.s_Random = new ExpressionEvaluator.PcgRandom((ulong)state, 0UL);
		}

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_s_Random;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr_s_Operators;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0;

		// Token: 0x0200049C RID: 1180
		public class Expression : Object
		{
			// Token: 0x0600322E RID: 12846 RVA: 0x000B8784 File Offset: 0x000B6984
			// Note: this type is marked as 'beforefieldinit'.
			static Expression()
			{
				Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "Expression");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr);
				ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, "rpnTokens");
				ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, "hasVariables");
				ExpressionEvaluator.Expression.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664082);
				ExpressionEvaluator.Expression.NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664083);
				ExpressionEvaluator.Expression.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664084);
				ExpressionEvaluator.Expression.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664085);
				ExpressionEvaluator.Expression.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664086);
			}

			// Token: 0x0600322F RID: 12847 RVA: 0x000B883C File Offset: 0x000B6A3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 647873, RefRangeEnd = 647874, XrefRangeStart = 647845, XrefRangeEnd = 647873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Expression(string expression)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Expression.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003230 RID: 12848 RVA: 0x000B8888 File Offset: 0x000B6A88
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 647892, RefRangeEnd = 647896, XrefRangeStart = 647874, XrefRangeEnd = 647892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Evaluate<T>(ref T value, int index = 0, int count = 1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Expression.MethodInfoStoreGeneric_Evaluate_Public_Boolean_byref_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06003231 RID: 12849 RVA: 0x000B890C File Offset: 0x000B6B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 647896, XrefRangeEnd = 647902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003232 RID: 12850 RVA: 0x000B8964 File Offset: 0x000B6B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003233 RID: 12851 RVA: 0x000B89AC File Offset: 0x000B6BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 647902, XrefRangeEnd = 647905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06003234 RID: 12852 RVA: 0x00013BC3 File Offset: 0x00011DC3
			public Expression(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x06003235 RID: 12853 RVA: 0x000B89F0 File Offset: 0x000B6BF0
			// (set) Token: 0x06003236 RID: 12854 RVA: 0x00013BCC File Offset: 0x00011DCC
			public unsafe Il2CppStringArray rpnTokens
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x06003237 RID: 12855 RVA: 0x000B8A20 File Offset: 0x000B6C20
			// (set) Token: 0x06003238 RID: 12856 RVA: 0x00013BEB File Offset: 0x00011DEB
			public unsafe bool hasVariables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables)) = value;
				}
			}

			// Token: 0x04002B6B RID: 11115
			private static readonly IntPtr NativeFieldInfoPtr_rpnTokens;

			// Token: 0x04002B6C RID: 11116
			private static readonly IntPtr NativeFieldInfoPtr_hasVariables;

			// Token: 0x04002B6D RID: 11117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

			// Token: 0x04002B6E RID: 11118
			private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0;

			// Token: 0x04002B6F RID: 11119
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04002B70 RID: 11120
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04002B71 RID: 11121
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02000BE0 RID: 3040
			private sealed class MethodInfoStoreGeneric_Evaluate_Public_Boolean_byref_T_Int32_Int32_0<T>
			{
				// Token: 0x04002DD4 RID: 11732
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.Expression.NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0, Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x0200049D RID: 1181
		[StructLayout(2)]
		public struct PcgRandom
		{
			// Token: 0x06003239 RID: 12857 RVA: 0x000B8A48 File Offset: 0x000B6C48
			// Note: this type is marked as 'beforefieldinit'.
			static PcgRandom()
			{
				Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "PcgRandom");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr);
				ExpressionEvaluator.PcgRandom.NativeFieldInfoPtr_increment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, "increment");
				ExpressionEvaluator.PcgRandom.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, "state");
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664087);
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_GetUInt_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664088);
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664089);
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664090);
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_Step_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664091);
			}

			// Token: 0x0600323A RID: 12858 RVA: 0x000B8B00 File Offset: 0x000B6D00
			[CallerCount(0)]
			public unsafe PcgRandom(ulong state = 0UL, ulong sequence = 0UL)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600323B RID: 12859 RVA: 0x000B8B40 File Offset: 0x000B6D40
			[CallerCount(0)]
			public unsafe uint GetUInt()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_GetUInt_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600323C RID: 12860 RVA: 0x000B8B70 File Offset: 0x000B6D70
			[CallerCount(0)]
			public unsafe static uint RotateRight(uint v, int rot)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600323D RID: 12861 RVA: 0x000B8BBC File Offset: 0x000B6DBC
			[CallerCount(0)]
			public unsafe static uint XshRr(ulong s)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600323E RID: 12862 RVA: 0x000B8BFC File Offset: 0x000B6DFC
			[CallerCount(0)]
			public unsafe void Step()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_Step_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600323F RID: 12863 RVA: 0x00013C06 File Offset: 0x00011E06
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, ref this));
			}

			// Token: 0x04002B72 RID: 11122
			private static readonly IntPtr NativeFieldInfoPtr_increment;

			// Token: 0x04002B73 RID: 11123
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04002B74 RID: 11124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

			// Token: 0x04002B75 RID: 11125
			private static readonly IntPtr NativeMethodInfoPtr_GetUInt_Public_UInt32_0;

			// Token: 0x04002B76 RID: 11126
			private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0;

			// Token: 0x04002B77 RID: 11127
			private static readonly IntPtr NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0;

			// Token: 0x04002B78 RID: 11128
			private static readonly IntPtr NativeMethodInfoPtr_Step_Private_Void_0;

			// Token: 0x04002B79 RID: 11129
			[FieldOffset(0)]
			public readonly ulong increment;

			// Token: 0x04002B7A RID: 11130
			[FieldOffset(8)]
			public ulong state;
		}

		// Token: 0x0200049E RID: 1182
		public enum Op
		{
			// Token: 0x04002B7C RID: 11132
			Add,
			// Token: 0x04002B7D RID: 11133
			Sub,
			// Token: 0x04002B7E RID: 11134
			Mul,
			// Token: 0x04002B7F RID: 11135
			Div,
			// Token: 0x04002B80 RID: 11136
			Mod,
			// Token: 0x04002B81 RID: 11137
			Neg,
			// Token: 0x04002B82 RID: 11138
			Pow,
			// Token: 0x04002B83 RID: 11139
			Sqrt,
			// Token: 0x04002B84 RID: 11140
			Sin,
			// Token: 0x04002B85 RID: 11141
			Cos,
			// Token: 0x04002B86 RID: 11142
			Tan,
			// Token: 0x04002B87 RID: 11143
			Floor,
			// Token: 0x04002B88 RID: 11144
			Ceil,
			// Token: 0x04002B89 RID: 11145
			Round,
			// Token: 0x04002B8A RID: 11146
			Rand,
			// Token: 0x04002B8B RID: 11147
			Linear
		}

		// Token: 0x0200049F RID: 1183
		public enum Associativity
		{
			// Token: 0x04002B8D RID: 11149
			Left,
			// Token: 0x04002B8E RID: 11150
			Right
		}

		// Token: 0x020004A0 RID: 1184
		public class Operator : Object
		{
			// Token: 0x06003240 RID: 12864 RVA: 0x000B8C24 File Offset: 0x000B6E24
			// Note: this type is marked as 'beforefieldinit'.
			static Operator()
			{
				Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "Operator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr);
				ExpressionEvaluator.Operator.NativeFieldInfoPtr_op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, "op");
				ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, "precedence");
				ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, "associativity");
				ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, "inputs");
				ExpressionEvaluator.Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, 100664092);
			}

			// Token: 0x06003241 RID: 12865 RVA: 0x000B8CB4 File Offset: 0x000B6EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 647905, XrefRangeEnd = 647906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Operator(ExpressionEvaluator.Op op, int precedence, int inputs, ExpressionEvaluator.Associativity associativity)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref op;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precedence;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputs;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref associativity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003242 RID: 12866 RVA: 0x00013C18 File Offset: 0x00011E18
			public Operator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x06003243 RID: 12867 RVA: 0x000B8D28 File Offset: 0x000B6F28
			// (set) Token: 0x06003244 RID: 12868 RVA: 0x00013C21 File Offset: 0x00011E21
			public unsafe ExpressionEvaluator.Op op
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_op);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_op)) = value;
				}
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x06003245 RID: 12869 RVA: 0x000B8D50 File Offset: 0x000B6F50
			// (set) Token: 0x06003246 RID: 12870 RVA: 0x00013C3C File Offset: 0x00011E3C
			public unsafe int precedence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence)) = value;
				}
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x06003247 RID: 12871 RVA: 0x000B8D78 File Offset: 0x000B6F78
			// (set) Token: 0x06003248 RID: 12872 RVA: 0x00013C57 File Offset: 0x00011E57
			public unsafe ExpressionEvaluator.Associativity associativity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity)) = value;
				}
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x06003249 RID: 12873 RVA: 0x000B8DA0 File Offset: 0x000B6FA0
			// (set) Token: 0x0600324A RID: 12874 RVA: 0x00013C72 File Offset: 0x00011E72
			public unsafe int inputs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs)) = value;
				}
			}

			// Token: 0x04002B8F RID: 11151
			private static readonly IntPtr NativeFieldInfoPtr_op;

			// Token: 0x04002B90 RID: 11152
			private static readonly IntPtr NativeFieldInfoPtr_precedence;

			// Token: 0x04002B91 RID: 11153
			private static readonly IntPtr NativeFieldInfoPtr_associativity;

			// Token: 0x04002B92 RID: 11154
			private static readonly IntPtr NativeFieldInfoPtr_inputs;

			// Token: 0x04002B93 RID: 11155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0;
		}

		// Token: 0x020004A1 RID: 1185
		[ObfuscatedName("UnityEngine.ExpressionEvaluator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600324B RID: 12875 RVA: 0x000B8DC8 File Offset: 0x000B6FC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr);
				ExpressionEvaluator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, "<>9");
				ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, "<>9__14_0");
				ExpressionEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, 100664094);
				ExpressionEvaluator.__c.NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, 100664095);
			}

			// Token: 0x0600324C RID: 12876 RVA: 0x000B8E44 File Offset: 0x000B7044
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600324D RID: 12877 RVA: 0x000B8E80 File Offset: 0x000B7080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 647906, XrefRangeEnd = 647917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExpressionToTokens_b__14_0(string f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.__c.NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600324E RID: 12878 RVA: 0x00013C8D File Offset: 0x00011E8D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x0600324F RID: 12879 RVA: 0x000B8ED0 File Offset: 0x000B70D0
			// (set) Token: 0x06003250 RID: 12880 RVA: 0x00013C96 File Offset: 0x00011E96
			public unsafe static ExpressionEvaluator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpressionEvaluator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x06003251 RID: 12881 RVA: 0x000B8EF8 File Offset: 0x000B70F8
			// (set) Token: 0x06003252 RID: 12882 RVA: 0x00013CA8 File Offset: 0x00011EA8
			public unsafe static Func<string, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B94 RID: 11156
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002B95 RID: 11157
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04002B96 RID: 11158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B97 RID: 11159
			private static readonly IntPtr NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0;
		}

		// Token: 0x020004A2 RID: 1186
		private sealed class MethodInfoStoreGeneric_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0<T>
		{
			// Token: 0x04002B98 RID: 11160
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004A3 RID: 1187
		private sealed class MethodInfoStoreGeneric_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0<T>
		{
			// Token: 0x04002B99 RID: 11161
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004A4 RID: 1188
		private sealed class MethodInfoStoreGeneric_TryParse_Private_Static_Boolean_String_byref_T_0<T>
		{
			// Token: 0x04002B9A RID: 11162
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004A5 RID: 1189
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
