using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x0200012A RID: 298
	public static class ExpressionUtils : Object
	{
		// Token: 0x06001165 RID: 4453 RVA: 0x0005AF2C File Offset: 0x0005912C
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionUtils()
		{
			Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "ExpressionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr);
			ExpressionUtils.NativeMethodInfoPtr_ReturnReadOnly_Public_Static_ReadOnlyCollection_1_T_byref_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666593);
			ExpressionUtils.NativeMethodInfoPtr_ReturnObject_Public_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666594);
			ExpressionUtils.NativeMethodInfoPtr_ValidateArgumentTypes_Public_Static_Void_MethodBase_ExpressionType_byref_ReadOnlyCollection_1_Expression_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666595);
			ExpressionUtils.NativeMethodInfoPtr_ValidateArgumentCount_Public_Static_Void_MethodBase_ExpressionType_Int32_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666596);
			ExpressionUtils.NativeMethodInfoPtr_ValidateOneArgument_Public_Static_Expression_MethodBase_ExpressionType_Expression_ParameterInfo_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666597);
			ExpressionUtils.NativeMethodInfoPtr_RequiresCanRead_Public_Static_Void_Expression_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666598);
			ExpressionUtils.NativeMethodInfoPtr_RequiresCanRead_Public_Static_Void_Expression_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666599);
			ExpressionUtils.NativeMethodInfoPtr_TryQuote_Public_Static_Boolean_Type_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666600);
			ExpressionUtils.NativeMethodInfoPtr_GetParametersForValidation_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_MethodBase_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666601);
			ExpressionUtils.NativeMethodInfoPtr_SameElements_Internal_Static_Boolean_byref_IEnumerable_1_T_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666602);
			ExpressionUtils.NativeMethodInfoPtr_SameElementsInCollection_Private_Static_Boolean_ICollection_1_T_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666603);
			ExpressionUtils.NativeMethodInfoPtr_ValidateArgumentCount_Public_Static_Void_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr, 100666604);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0005B04C File Offset: 0x0005924C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1029878, RefRangeEnd = 1029881, XrefRangeStart = 1029872, XrefRangeEnd = 1029878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.MethodInfoStoreGeneric_ReturnReadOnly_Public_Static_ReadOnlyCollection_1_T_byref_IReadOnlyList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				collection = ((intPtr4 == 0) ? null : new IReadOnlyList<T>(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr5) : null;
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0005B0A8 File Offset: 0x000592A8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1029890, RefRangeEnd = 1029916, XrefRangeStart = 1029881, XrefRangeEnd = 1029890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ReturnObject<T>(Object collectionOrT) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionOrT);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.MethodInfoStoreGeneric_ReturnObject_Public_Static_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0005B0E8 File Offset: 0x000592E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1029953, RefRangeEnd = 1029956, XrefRangeStart = 1029916, XrefRangeEnd = 1029953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodParamName);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.NativeMethodInfoPtr_ValidateArgumentTypes_Public_Static_Void_MethodBase_ExpressionType_byref_ReadOnlyCollection_1_Expression_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			arguments = ((intPtr4 == 0) ? null : new ReadOnlyCollection<Expression>(intPtr4));
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0005B168 File Offset: 0x00059368
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1029958, RefRangeEnd = 1029979, XrefRangeStart = 1029956, XrefRangeEnd = 1029958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, Il2CppReferenceArray<ParameterInfo> pis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeKind;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.NativeMethodInfoPtr_ValidateArgumentCount_Public_Static_Void_MethodBase_ExpressionType_Int32_Il2CppReferenceArray_1_ParameterInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0005B1CC File Offset: 0x000593CC
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 1029989, RefRangeEnd = 1030031, XrefRangeStart = 1029979, XrefRangeEnd = 1029989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeKind;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pi);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodParamName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argumentParamName);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.NativeMethodInfoPtr_ValidateOneArgument_Public_Static_Expression_MethodBase_ExpressionType_Expression_ParameterInfo_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0005B278 File Offset: 0x00059478
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 1030032, RefRangeEnd = 1030180, XrefRangeStart = 1030031, XrefRangeEnd = 1030032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequiresCanRead(Expression expression, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.NativeMethodInfoPtr_RequiresCanRead_Public_Static_Void_Expression_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0005B2C0 File Offset: 0x000594C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1030192, RefRangeEnd = 1030199, XrefRangeStart = 1030180, XrefRangeEnd = 1030192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequiresCanRead(Expression expression, string paramName, int idx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.NativeMethodInfoPtr_RequiresCanRead_Public_Static_Void_Expression_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0005B318 File Offset: 0x00059518
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1030220, RefRangeEnd = 1030227, XrefRangeStart = 1030199, XrefRangeEnd = 1030220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryQuote(Type parameterType, ref Expression argument)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameterType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(argument);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.NativeMethodInfoPtr_TryQuote_Public_Static_Boolean_Type_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			argument = ((intPtr4 == 0) ? null : new Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0005B384 File Offset: 0x00059584
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1030234, RefRangeEnd = 1030243, XrefRangeStart = 1030227, XrefRangeEnd = 1030234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterInfo> GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.NativeMethodInfoPtr_GetParametersForValidation_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_MethodBase_ExpressionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0005B3D8 File Offset: 0x000595D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1030251, RefRangeEnd = 1030255, XrefRangeStart = 1030243, XrefRangeEnd = 1030251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.MethodInfoStoreGeneric_SameElements_Internal_Static_Boolean_byref_IEnumerable_1_T_IReadOnlyList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			replacement = ((intPtr4 == 0) ? null : new IEnumerable<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0005B444 File Offset: 0x00059644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1030280, RefRangeEnd = 1030281, XrefRangeStart = 1030255, XrefRangeEnd = 1030280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.MethodInfoStoreGeneric_SameElementsInCollection_Private_Static_Boolean_ICollection_1_T_IReadOnlyList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0005B498 File Offset: 0x00059698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1030284, RefRangeEnd = 1030285, XrefRangeStart = 1030281, XrefRangeEnd = 1030284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateArgumentCount(this LambdaExpression lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionUtils.NativeMethodInfoPtr_ValidateArgumentCount_Public_Static_Void_LambdaExpression_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00007549 File Offset: 0x00005749
		public ExpressionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_ReturnReadOnly_Public_Static_ReadOnlyCollection_1_T_byref_IReadOnlyList_1_T_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_ReturnObject_Public_Static_T_Object_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_ValidateArgumentTypes_Public_Static_Void_MethodBase_ExpressionType_byref_ReadOnlyCollection_1_Expression_String_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_ValidateArgumentCount_Public_Static_Void_MethodBase_ExpressionType_Int32_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_ValidateOneArgument_Public_Static_Expression_MethodBase_ExpressionType_Expression_ParameterInfo_String_String_Int32_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_RequiresCanRead_Public_Static_Void_Expression_String_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_RequiresCanRead_Public_Static_Void_Expression_String_Int32_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_TryQuote_Public_Static_Boolean_Type_byref_Expression_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersForValidation_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_MethodBase_ExpressionType_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_SameElements_Internal_Static_Boolean_byref_IEnumerable_1_T_IReadOnlyList_1_T_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_SameElementsInCollection_Private_Static_Boolean_ICollection_1_T_IReadOnlyList_1_T_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_ValidateArgumentCount_Public_Static_Void_LambdaExpression_0;

		// Token: 0x02000352 RID: 850
		private sealed class MethodInfoStoreGeneric_ReturnReadOnly_Public_Static_ReadOnlyCollection_1_T_byref_IReadOnlyList_1_T_0<T>
		{
			// Token: 0x040012FB RID: 4859
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionUtils.NativeMethodInfoPtr_ReturnReadOnly_Public_Static_ReadOnlyCollection_1_T_byref_IReadOnlyList_1_T_0, Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000353 RID: 851
		private sealed class MethodInfoStoreGeneric_ReturnObject_Public_Static_T_Object_0<T>
		{
			// Token: 0x040012FC RID: 4860
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionUtils.NativeMethodInfoPtr_ReturnObject_Public_Static_T_Object_0, Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000354 RID: 852
		private sealed class MethodInfoStoreGeneric_SameElements_Internal_Static_Boolean_byref_IEnumerable_1_T_IReadOnlyList_1_T_0<T>
		{
			// Token: 0x040012FD RID: 4861
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionUtils.NativeMethodInfoPtr_SameElements_Internal_Static_Boolean_byref_IEnumerable_1_T_IReadOnlyList_1_T_0, Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000355 RID: 853
		private sealed class MethodInfoStoreGeneric_SameElementsInCollection_Private_Static_Boolean_ICollection_1_T_IReadOnlyList_1_T_0<T>
		{
			// Token: 0x040012FE RID: 4862
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionUtils.NativeMethodInfoPtr_SameElementsInCollection_Private_Static_Boolean_ICollection_1_T_IReadOnlyList_1_T_0, Il2CppClassPointerStore<ExpressionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
