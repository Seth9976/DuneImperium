using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200005C RID: 92
	public sealed class Expression1<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x0002A204 File Offset: 0x00028404
		// Note: this type is marked as 'beforefieldinit'.
		static Expression1()
		{
			Il2CppClassPointerStore<Expression1<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression1<TDelegate>>.NativeClassPtr);
			Expression1<TDelegate>.NativeFieldInfoPtr__par0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression1<TDelegate>>.NativeClassPtr, "_par0");
			Expression1<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression1<TDelegate>>.NativeClassPtr, 100664476);
			Expression1<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression1<TDelegate>>.NativeClassPtr, 100664477);
			Expression1<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression1<TDelegate>>.NativeClassPtr, 100664478);
			Expression1<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression1<TDelegate>>.NativeClassPtr, 100664479);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0002A2D4 File Offset: 0x000284D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014125, XrefRangeEnd = 1014126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression1(Expression body, ParameterExpression par0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expression1<TDelegate>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression1<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0002A334 File Offset: 0x00028534
		public unsafe override int ParameterCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression1<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0002A370 File Offset: 0x00028570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014126, XrefRangeEnd = 1014132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ParameterExpression GetParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression1<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0002A3BC File Offset: 0x000285BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014132, XrefRangeEnd = 1014147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression1<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression<TDelegate>>(intPtr3) : null;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000032E6 File Offset: 0x000014E6
		public Expression1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0002A420 File Offset: 0x00028620
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x000032EF File Offset: 0x000014EF
		public unsafe Object _par0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression1<TDelegate>.NativeFieldInfoPtr__par0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression1<TDelegate>.NativeFieldInfoPtr__par0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr__par0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0;
	}
}
