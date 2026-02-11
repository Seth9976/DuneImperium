using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200005B RID: 91
	public sealed class Expression0<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x0002A010 File Offset: 0x00028210
		// Note: this type is marked as 'beforefieldinit'.
		static Expression0()
		{
			Il2CppClassPointerStore<Expression0<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression0<TDelegate>>.NativeClassPtr);
			Expression0<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression0<TDelegate>>.NativeClassPtr, 100664472);
			Expression0<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression0<TDelegate>>.NativeClassPtr, 100664473);
			Expression0<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression0<TDelegate>>.NativeClassPtr, 100664474);
			Expression0<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression0<TDelegate>>.NativeClassPtr, 100664475);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0002A0CC File Offset: 0x000282CC
		[CallerCount(0)]
		public unsafe Expression0(Expression body)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expression0<TDelegate>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression0<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0002A118 File Offset: 0x00028318
		public unsafe override int ParameterCount
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression0<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0002A154 File Offset: 0x00028354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014119, XrefRangeEnd = 1014122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ParameterExpression GetParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression0<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0002A1A0 File Offset: 0x000283A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014122, XrefRangeEnd = 1014125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression<TDelegate> Rewrite(Expression body, Il2CppReferenceArray<ParameterExpression> parameters)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression0<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression<TDelegate>>(intPtr3) : null;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000032DD File Offset: 0x000014DD
		public Expression0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0;
	}
}
