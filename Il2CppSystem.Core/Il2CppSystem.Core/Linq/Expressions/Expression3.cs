using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200005E RID: 94
	public sealed class Expression3<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x0002A6F0 File Offset: 0x000288F0
		// Note: this type is marked as 'beforefieldinit'.
		static Expression3()
		{
			Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr);
			Expression3<TDelegate>.NativeFieldInfoPtr__par0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr, "_par0");
			Expression3<TDelegate>.NativeFieldInfoPtr__par1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr, "_par1");
			Expression3<TDelegate>.NativeFieldInfoPtr__par2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr, "_par2");
			Expression3<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_ParameterExpression_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr, 100664484);
			Expression3<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr, 100664485);
			Expression3<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr, 100664486);
			Expression3<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr, 100664487);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0002A7E8 File Offset: 0x000289E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014165, XrefRangeEnd = 1014168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression3(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expression3<TDelegate>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression3<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_ParameterExpression_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0002A86C File Offset: 0x00028A6C
		public unsafe override int ParameterCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression3<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0002A8A8 File Offset: 0x00028AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014168, XrefRangeEnd = 1014169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ParameterExpression GetParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression3<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014169, XrefRangeEnd = 1014184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression3<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression<TDelegate>>(intPtr3) : null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00003355 File Offset: 0x00001555
		public Expression3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0002A958 File Offset: 0x00028B58
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0000335E File Offset: 0x0000155E
		public unsafe Object _par0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression3<TDelegate>.NativeFieldInfoPtr__par0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression3<TDelegate>.NativeFieldInfoPtr__par0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0002A988 File Offset: 0x00028B88
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x0000337D File Offset: 0x0000157D
		public unsafe ParameterExpression _par1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression3<TDelegate>.NativeFieldInfoPtr__par1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression3<TDelegate>.NativeFieldInfoPtr__par1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0002A9B8 File Offset: 0x00028BB8
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0000339C File Offset: 0x0000159C
		public unsafe ParameterExpression _par2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression3<TDelegate>.NativeFieldInfoPtr__par2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression3<TDelegate>.NativeFieldInfoPtr__par2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr__par0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr__par1;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr__par2;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_ParameterExpression_ParameterExpression_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0;
	}
}
