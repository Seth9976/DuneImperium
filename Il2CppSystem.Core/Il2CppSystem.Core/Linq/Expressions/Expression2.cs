using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200005D RID: 93
	public sealed class Expression2<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x06000552 RID: 1362 RVA: 0x0002A450 File Offset: 0x00028650
		// Note: this type is marked as 'beforefieldinit'.
		static Expression2()
		{
			Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr);
			Expression2<TDelegate>.NativeFieldInfoPtr__par0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr, "_par0");
			Expression2<TDelegate>.NativeFieldInfoPtr__par1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr, "_par1");
			Expression2<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr, 100664480);
			Expression2<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr, 100664481);
			Expression2<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr, 100664482);
			Expression2<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr, 100664483);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002A534 File Offset: 0x00028734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014147, XrefRangeEnd = 1014149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression2(Expression body, ParameterExpression par0, ParameterExpression par1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expression2<TDelegate>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression2<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0002A5A4 File Offset: 0x000287A4
		public unsafe override int ParameterCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression2<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0002A5E0 File Offset: 0x000287E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014149, XrefRangeEnd = 1014152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ParameterExpression GetParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression2<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0002A62C File Offset: 0x0002882C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014152, XrefRangeEnd = 1014165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression2<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression<TDelegate>>(intPtr3) : null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000330E File Offset: 0x0000150E
		public Expression2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0002A690 File Offset: 0x00028890
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00003317 File Offset: 0x00001517
		public unsafe Object _par0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression2<TDelegate>.NativeFieldInfoPtr__par0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression2<TDelegate>.NativeFieldInfoPtr__par0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0002A6C0 File Offset: 0x000288C0
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00003336 File Offset: 0x00001536
		public unsafe ParameterExpression _par1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression2<TDelegate>.NativeFieldInfoPtr__par1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression2<TDelegate>.NativeFieldInfoPtr__par1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr__par0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr__par1;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_ParameterExpression_ParameterExpression_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0;
	}
}
