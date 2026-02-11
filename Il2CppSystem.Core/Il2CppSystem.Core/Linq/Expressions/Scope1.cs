using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000035 RID: 53
	public sealed class Scope1 : ScopeExpression
	{
		// Token: 0x0600032C RID: 812 RVA: 0x0001FE34 File Offset: 0x0001E034
		// Note: this type is marked as 'beforefieldinit'.
		static Scope1()
		{
			Il2CppClassPointerStore<Scope1>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Scope1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scope1>.NativeClassPtr);
			Scope1.NativeFieldInfoPtr__body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scope1>.NativeClassPtr, "_body");
			Scope1.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scope1>.NativeClassPtr, 100664102);
			Scope1.NativeMethodInfoPtr__ctor_Private_Void_IReadOnlyList_1_ParameterExpression_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scope1>.NativeClassPtr, 100664103);
			Scope1.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scope1>.NativeClassPtr, 100664104);
			Scope1.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scope1>.NativeClassPtr, 100664105);
			Scope1.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scope1>.NativeClassPtr, 100664106);
			Scope1.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scope1>.NativeClassPtr, 100664107);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011952, XrefRangeEnd = 1011953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scope1(IReadOnlyList<ParameterExpression> variables, Expression body)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scope1>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scope1.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001FF50 File Offset: 0x0001E150
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1011836, RefRangeEnd = 1011843, XrefRangeStart = 1011836, XrefRangeEnd = 1011843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scope1(IReadOnlyList<ParameterExpression> variables, Object body)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scope1>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scope1.NativeMethodInfoPtr__ctor_Private_Void_IReadOnlyList_1_ParameterExpression_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011953, XrefRangeEnd = 1011960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetExpression(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scope1.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		public unsafe override int ExpressionCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scope1.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00020038 File Offset: 0x0001E238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011960, XrefRangeEnd = 1011961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scope1.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00020078 File Offset: 0x0001E278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011961, XrefRangeEnd = 1011979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Il2CppReferenceArray<Expression> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scope1.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr3) : null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002B40 File Offset: 0x00000D40
		public Scope1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000200DC File Offset: 0x0001E2DC
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00002B49 File Offset: 0x00000D49
		public unsafe Object _body
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scope1.NativeFieldInfoPtr__body);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scope1.NativeFieldInfoPtr__body), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr__body;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_Expression_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IReadOnlyList_1_ParameterExpression_Object_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0;
	}
}
