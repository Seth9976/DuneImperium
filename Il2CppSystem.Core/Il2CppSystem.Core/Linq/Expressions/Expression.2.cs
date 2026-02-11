using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000059 RID: 89
	public class Expression<TDelegate> : LambdaExpression
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x00029BF8 File Offset: 0x00027DF8
		// Note: this type is marked as 'beforefieldinit'.
		static Expression()
		{
			Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr);
			Expression<TDelegate>.NativeMethodInfoPtr__ctor_Internal_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr, 100664464);
			Expression<TDelegate>.NativeMethodInfoPtr_get_TypeCore_Internal_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr, 100664465);
			Expression<TDelegate>.NativeMethodInfoPtr_get_PublicType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr, 100664466);
			Expression<TDelegate>.NativeMethodInfoPtr_Compile_Public_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr, 100664467);
			Expression<TDelegate>.NativeMethodInfoPtr_Compile_Public_TDelegate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr, 100664468);
			Expression<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_New_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr, 100664469);
			Expression<TDelegate>.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr, 100664470);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00029CF0 File Offset: 0x00027EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014030, XrefRangeEnd = 1014031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression(Expression body)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression<TDelegate>.NativeMethodInfoPtr__ctor_Internal_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00029D3C File Offset: 0x00027F3C
		public unsafe override Type TypeCore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014031, XrefRangeEnd = 1014035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression<TDelegate>.NativeMethodInfoPtr_get_TypeCore_Internal_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00029D7C File Offset: 0x00027F7C
		public unsafe override Type PublicType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014035, XrefRangeEnd = 1014047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Expression<TDelegate>.NativeMethodInfoPtr_get_PublicType_Internal_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00029DC8 File Offset: 0x00027FC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1014054, RefRangeEnd = 1014057, XrefRangeStart = 1014047, XrefRangeEnd = 1014054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TDelegate Compile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression<TDelegate>.NativeMethodInfoPtr_Compile_Public_TDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TDelegate>(intPtr, false, true);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00029E04 File Offset: 0x00028004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014057, XrefRangeEnd = 1014064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TDelegate Compile(bool preferInterpretation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preferInterpretation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression<TDelegate>.NativeMethodInfoPtr_Compile_Public_TDelegate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TDelegate>(intPtr, false, true);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00029E4C File Offset: 0x0002804C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014064, XrefRangeEnd = 1014066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression<TDelegate> Rewrite(Expression body, Il2CppReferenceArray<ParameterExpression> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Expression<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_New_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression<TDelegate>>(intPtr3) : null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00029EBC File Offset: 0x000280BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014066, XrefRangeEnd = 1014068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Expression<TDelegate>.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000032CB File Offset: 0x000014CB
		public Expression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCore_Internal_Virtual_Final_get_Type_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicType_Internal_Virtual_get_Type_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_TDelegate_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_TDelegate_Boolean_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_New_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;
	}
}
