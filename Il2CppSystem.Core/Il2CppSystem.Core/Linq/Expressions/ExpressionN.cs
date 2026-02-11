using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200005F RID: 95
	public class ExpressionN<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x0002A9E8 File Offset: 0x00028BE8
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionN()
		{
			Il2CppClassPointerStore<ExpressionN<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ExpressionN`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionN<TDelegate>>.NativeClassPtr);
			ExpressionN<TDelegate>.NativeFieldInfoPtr__parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionN<TDelegate>>.NativeClassPtr, "_parameters");
			ExpressionN<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_IReadOnlyList_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionN<TDelegate>>.NativeClassPtr, 100664488);
			ExpressionN<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionN<TDelegate>>.NativeClassPtr, 100664489);
			ExpressionN<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionN<TDelegate>>.NativeClassPtr, 100664490);
			ExpressionN<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionN<TDelegate>>.NativeClassPtr, 100664491);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0002AAB8 File Offset: 0x00028CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionN(Expression body, IReadOnlyList<ParameterExpression> parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionN<TDelegate>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionN<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_IReadOnlyList_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0002AB18 File Offset: 0x00028D18
		public unsafe override int ParameterCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014184, XrefRangeEnd = 1014188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionN<TDelegate>.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0002AB60 File Offset: 0x00028D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014188, XrefRangeEnd = 1014193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ParameterExpression GetParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionN<TDelegate>.NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0002ABB8 File Offset: 0x00028DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014193, XrefRangeEnd = 1014198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionN<TDelegate>.NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression<TDelegate>>(intPtr3) : null;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000033BB File Offset: 0x000015BB
		public ExpressionN(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0002AC28 File Offset: 0x00028E28
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x000033C4 File Offset: 0x000015C4
		public unsafe IReadOnlyList<ParameterExpression> _parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionN<TDelegate>.NativeFieldInfoPtr__parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ParameterExpression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionN<TDelegate>.NativeFieldInfoPtr__parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr__parameters;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_IReadOnlyList_1_ParameterExpression_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_Virtual_ParameterExpression_Int32_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_Expression_1_TDelegate_Expression_Il2CppReferenceArray_1_ParameterExpression_0;
	}
}
