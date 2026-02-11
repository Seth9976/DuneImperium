using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000048 RID: 72
	public class ExpressionVisitor : Object
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00026268 File Offset: 0x00024468
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionVisitor()
		{
			Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ExpressionVisitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr);
			ExpressionVisitor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664349);
			ExpressionVisitor.NativeMethodInfoPtr_Visit_Public_Virtual_New_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664350);
			ExpressionVisitor.NativeMethodInfoPtr_Visit_Public_ReadOnlyCollection_1_Expression_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664351);
			ExpressionVisitor.NativeMethodInfoPtr_VisitArguments_Private_Il2CppReferenceArray_1_Expression_IArgumentProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664352);
			ExpressionVisitor.NativeMethodInfoPtr_VisitParameters_Private_Il2CppReferenceArray_1_ParameterExpression_IParameterProvider_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664353);
			ExpressionVisitor.NativeMethodInfoPtr_Visit_Public_Static_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664354);
			ExpressionVisitor.NativeMethodInfoPtr_VisitAndConvert_Public_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664355);
			ExpressionVisitor.NativeMethodInfoPtr_VisitAndConvert_Public_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664356);
			ExpressionVisitor.NativeMethodInfoPtr_VisitBinary_FamOrAssem_Virtual_New_Expression_BinaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664357);
			ExpressionVisitor.NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_New_Expression_BlockExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664358);
			ExpressionVisitor.NativeMethodInfoPtr_VisitConditional_FamOrAssem_Virtual_New_Expression_ConditionalExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664359);
			ExpressionVisitor.NativeMethodInfoPtr_VisitConstant_FamOrAssem_Virtual_New_Expression_ConstantExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664360);
			ExpressionVisitor.NativeMethodInfoPtr_VisitDefault_FamOrAssem_Virtual_New_Expression_DefaultExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664361);
			ExpressionVisitor.NativeMethodInfoPtr_VisitExtension_FamOrAssem_Virtual_New_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664362);
			ExpressionVisitor.NativeMethodInfoPtr_VisitGoto_FamOrAssem_Virtual_New_Expression_GotoExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664363);
			ExpressionVisitor.NativeMethodInfoPtr_VisitInvocation_FamOrAssem_Virtual_New_Expression_InvocationExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664364);
			ExpressionVisitor.NativeMethodInfoPtr_VisitLabelTarget_Protected_Virtual_New_LabelTarget_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664365);
			ExpressionVisitor.NativeMethodInfoPtr_VisitLabel_FamOrAssem_Virtual_New_Expression_LabelExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664366);
			ExpressionVisitor.NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_New_Expression_Expression_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664367);
			ExpressionVisitor.NativeMethodInfoPtr_VisitLoop_FamOrAssem_Virtual_New_Expression_LoopExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664368);
			ExpressionVisitor.NativeMethodInfoPtr_VisitMember_FamOrAssem_Virtual_New_Expression_MemberExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664369);
			ExpressionVisitor.NativeMethodInfoPtr_VisitIndex_FamOrAssem_Virtual_New_Expression_IndexExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664370);
			ExpressionVisitor.NativeMethodInfoPtr_VisitMethodCall_FamOrAssem_Virtual_New_Expression_MethodCallExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664371);
			ExpressionVisitor.NativeMethodInfoPtr_VisitNewArray_FamOrAssem_Virtual_New_Expression_NewArrayExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664372);
			ExpressionVisitor.NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_New_Expression_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664373);
			ExpressionVisitor.NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_New_CatchBlock_CatchBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664374);
			ExpressionVisitor.NativeMethodInfoPtr_VisitTry_FamOrAssem_Virtual_New_Expression_TryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664375);
			ExpressionVisitor.NativeMethodInfoPtr_VisitTypeBinary_FamOrAssem_Virtual_New_Expression_TypeBinaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664376);
			ExpressionVisitor.NativeMethodInfoPtr_VisitUnary_FamOrAssem_Virtual_New_Expression_UnaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664377);
			ExpressionVisitor.NativeMethodInfoPtr_ValidateUnary_Private_Static_UnaryExpression_UnaryExpression_UnaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664378);
			ExpressionVisitor.NativeMethodInfoPtr_ValidateBinary_Private_Static_BinaryExpression_BinaryExpression_BinaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664379);
			ExpressionVisitor.NativeMethodInfoPtr_ValidateChildType_Private_Static_Void_Type_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr, 100664380);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00026518 File Offset: 0x00024718
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionVisitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00026554 File Offset: 0x00024754
		[CallerCount(0)]
		public unsafe virtual Expression Visit(Expression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_Visit_Public_Virtual_New_Expression_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000265B0 File Offset: 0x000247B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013640, RefRangeEnd = 1013641, XrefRangeStart = 1013612, XrefRangeEnd = 1013640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.NativeMethodInfoPtr_Visit_Public_ReadOnlyCollection_1_Expression_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00026600 File Offset: 0x00024800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013641, XrefRangeEnd = 1013642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Expression> VisitArguments(IArgumentProvider nodes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.NativeMethodInfoPtr_VisitArguments_Private_Il2CppReferenceArray_1_Expression_IArgumentProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00026650 File Offset: 0x00024850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013643, RefRangeEnd = 1013644, XrefRangeStart = 1013642, XrefRangeEnd = 1013643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ParameterExpression> VisitParameters(IParameterProvider nodes, string callerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(callerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.NativeMethodInfoPtr_VisitParameters_Private_Il2CppReferenceArray_1_ParameterExpression_IParameterProvider_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterExpression>>(intPtr3) : null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000266B4 File Offset: 0x000248B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013664, RefRangeEnd = 1013665, XrefRangeStart = 1013644, XrefRangeEnd = 1013664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementVisitor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.MethodInfoStoreGeneric_Visit_Public_Static_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_Func_2_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr3) : null;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0002670C File Offset: 0x0002490C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1013671, RefRangeEnd = 1013674, XrefRangeStart = 1013665, XrefRangeEnd = 1013671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T VisitAndConvert<T>(T node, string callerName) where T : Expression
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = node;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref node;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(callerName);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.MethodInfoStoreGeneric_VisitAndConvert_Public_T_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000267A0 File Offset: 0x000249A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013693, RefRangeEnd = 1013694, XrefRangeStart = 1013674, XrefRangeEnd = 1013693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(callerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.MethodInfoStoreGeneric_VisitAndConvert_Public_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr3) : null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00026804 File Offset: 0x00024A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013694, XrefRangeEnd = 1013703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitBinary(BinaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitBinary_FamOrAssem_Virtual_New_Expression_BinaryExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00026860 File Offset: 0x00024A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013709, RefRangeEnd = 1013710, XrefRangeStart = 1013703, XrefRangeEnd = 1013709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitBlock(BlockExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_New_Expression_BlockExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000268BC File Offset: 0x00024ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013714, RefRangeEnd = 1013715, XrefRangeStart = 1013710, XrefRangeEnd = 1013714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitConditional(ConditionalExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitConditional_FamOrAssem_Virtual_New_Expression_ConditionalExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00026918 File Offset: 0x00024B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitConstant(ConstantExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitConstant_FamOrAssem_Virtual_New_Expression_ConstantExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00026974 File Offset: 0x00024B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitDefault(DefaultExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitDefault_FamOrAssem_Virtual_New_Expression_DefaultExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000269D0 File Offset: 0x00024BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitExtension(Expression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitExtension_FamOrAssem_Virtual_New_Expression_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00026A2C File Offset: 0x00024C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013715, XrefRangeEnd = 1013719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitGoto(GotoExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitGoto_FamOrAssem_Virtual_New_Expression_GotoExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00026A88 File Offset: 0x00024C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013719, XrefRangeEnd = 1013720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitInvocation(InvocationExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitInvocation_FamOrAssem_Virtual_New_Expression_InvocationExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00026AE4 File Offset: 0x00024CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LabelTarget VisitLabelTarget(LabelTarget node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitLabelTarget_Protected_Virtual_New_LabelTarget_LabelTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr3) : null;
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00026B40 File Offset: 0x00024D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013720, XrefRangeEnd = 1013724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitLabel(LabelExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitLabel_FamOrAssem_Virtual_New_Expression_LabelExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00026B9C File Offset: 0x00024D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013727, RefRangeEnd = 1013728, XrefRangeStart = 1013724, XrefRangeEnd = 1013727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitLambda<T>(Expression<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.MethodInfoStoreGeneric_VisitLambda_FamOrAssem_Virtual_New_Expression_Expression_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00026BF8 File Offset: 0x00024DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013728, XrefRangeEnd = 1013732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitLoop(LoopExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitLoop_FamOrAssem_Virtual_New_Expression_LoopExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00026C54 File Offset: 0x00024E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013732, XrefRangeEnd = 1013736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitMember(MemberExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitMember_FamOrAssem_Virtual_New_Expression_MemberExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00026CB0 File Offset: 0x00024EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013736, XrefRangeEnd = 1013737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitIndex(IndexExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitIndex_FamOrAssem_Virtual_New_Expression_IndexExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00026D0C File Offset: 0x00024F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013737, XrefRangeEnd = 1013738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitMethodCall(MethodCallExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitMethodCall_FamOrAssem_Virtual_New_Expression_MethodCallExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00026D68 File Offset: 0x00024F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013738, XrefRangeEnd = 1013749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitNewArray(NewArrayExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitNewArray_FamOrAssem_Virtual_New_Expression_NewArrayExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00026DC4 File Offset: 0x00024FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitParameter(ParameterExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_New_Expression_ParameterExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00026E20 File Offset: 0x00025020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013749, XrefRangeEnd = 1013758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual CatchBlock VisitCatchBlock(CatchBlock node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_New_CatchBlock_CatchBlock_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CatchBlock>(intPtr3) : null;
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00026E7C File Offset: 0x0002507C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013758, XrefRangeEnd = 1013772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitTry(TryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitTry_FamOrAssem_Virtual_New_Expression_TryExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00026ED8 File Offset: 0x000250D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013772, XrefRangeEnd = 1013778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitTypeBinary(TypeBinaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitTypeBinary_FamOrAssem_Virtual_New_Expression_TypeBinaryExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00026F34 File Offset: 0x00025134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013778, XrefRangeEnd = 1013788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression VisitUnary(UnaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionVisitor.NativeMethodInfoPtr_VisitUnary_FamOrAssem_Virtual_New_Expression_UnaryExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00026F90 File Offset: 0x00025190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013788, XrefRangeEnd = 1013793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(before);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(after);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.NativeMethodInfoPtr_ValidateUnary_Private_Static_UnaryExpression_UnaryExpression_UnaryExpression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnaryExpression>(intPtr3) : null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00026FE8 File Offset: 0x000251E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013802, RefRangeEnd = 1013803, XrefRangeStart = 1013793, XrefRangeEnd = 1013802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(before);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(after);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.NativeMethodInfoPtr_ValidateBinary_Private_Static_BinaryExpression_BinaryExpression_BinaryExpression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BinaryExpression>(intPtr3) : null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00027040 File Offset: 0x00025240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1013806, RefRangeEnd = 1013810, XrefRangeStart = 1013803, XrefRangeEnd = 1013806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateChildType(Type before, Type after, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(before);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(after);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionVisitor.NativeMethodInfoPtr_ValidateChildType_Private_Static_Void_Type_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002E9D File Offset: 0x0000109D
		public ExpressionVisitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_Visit_Public_Virtual_New_Expression_Expression_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_Visit_Public_ReadOnlyCollection_1_Expression_ReadOnlyCollection_1_Expression_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_VisitArguments_Private_Il2CppReferenceArray_1_Expression_IArgumentProvider_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_VisitParameters_Private_Il2CppReferenceArray_1_ParameterExpression_IParameterProvider_String_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_Visit_Public_Static_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_Func_2_T_T_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_VisitAndConvert_Public_T_T_String_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_VisitAndConvert_Public_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_String_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_VisitBinary_FamOrAssem_Virtual_New_Expression_BinaryExpression_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_New_Expression_BlockExpression_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_VisitConditional_FamOrAssem_Virtual_New_Expression_ConditionalExpression_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstant_FamOrAssem_Virtual_New_Expression_ConstantExpression_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_VisitDefault_FamOrAssem_Virtual_New_Expression_DefaultExpression_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_VisitExtension_FamOrAssem_Virtual_New_Expression_Expression_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_VisitGoto_FamOrAssem_Virtual_New_Expression_GotoExpression_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_VisitInvocation_FamOrAssem_Virtual_New_Expression_InvocationExpression_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_VisitLabelTarget_Protected_Virtual_New_LabelTarget_LabelTarget_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_VisitLabel_FamOrAssem_Virtual_New_Expression_LabelExpression_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_New_Expression_Expression_1_T_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_VisitLoop_FamOrAssem_Virtual_New_Expression_LoopExpression_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_VisitMember_FamOrAssem_Virtual_New_Expression_MemberExpression_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_VisitIndex_FamOrAssem_Virtual_New_Expression_IndexExpression_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_VisitMethodCall_FamOrAssem_Virtual_New_Expression_MethodCallExpression_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_VisitNewArray_FamOrAssem_Virtual_New_Expression_NewArrayExpression_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_New_Expression_ParameterExpression_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_New_CatchBlock_CatchBlock_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_VisitTry_FamOrAssem_Virtual_New_Expression_TryExpression_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_VisitTypeBinary_FamOrAssem_Virtual_New_Expression_TypeBinaryExpression_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_VisitUnary_FamOrAssem_Virtual_New_Expression_UnaryExpression_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_ValidateUnary_Private_Static_UnaryExpression_UnaryExpression_UnaryExpression_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_ValidateBinary_Private_Static_BinaryExpression_BinaryExpression_BinaryExpression_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChildType_Private_Static_Void_Type_Type_String_0;

		// Token: 0x020001E0 RID: 480
		private sealed class MethodInfoStoreGeneric_Visit_Public_Static_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_Func_2_T_T_0<T>
		{
			// Token: 0x04000FBD RID: 4029
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionVisitor.NativeMethodInfoPtr_Visit_Public_Static_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_Func_2_T_T_0, Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001E1 RID: 481
		private sealed class MethodInfoStoreGeneric_VisitAndConvert_Public_T_T_String_0<T>
		{
			// Token: 0x04000FBE RID: 4030
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionVisitor.NativeMethodInfoPtr_VisitAndConvert_Public_T_T_String_0, Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001E2 RID: 482
		private sealed class MethodInfoStoreGeneric_VisitAndConvert_Public_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_String_0<T>
		{
			// Token: 0x04000FBF RID: 4031
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionVisitor.NativeMethodInfoPtr_VisitAndConvert_Public_ReadOnlyCollection_1_T_ReadOnlyCollection_1_T_String_0, Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001E3 RID: 483
		private sealed class MethodInfoStoreGeneric_VisitLambda_FamOrAssem_Virtual_New_Expression_Expression_1_T_0<T>
		{
			// Token: 0x04000FC0 RID: 4032
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionVisitor.NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_New_Expression_Expression_1_T_0, Il2CppClassPointerStore<ExpressionVisitor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
