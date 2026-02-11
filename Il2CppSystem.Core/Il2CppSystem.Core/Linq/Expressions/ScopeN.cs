using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000036 RID: 54
	public class ScopeN : ScopeExpression
	{
		// Token: 0x06000336 RID: 822 RVA: 0x0002010C File Offset: 0x0001E30C
		// Note: this type is marked as 'beforefieldinit'.
		static ScopeN()
		{
			Il2CppClassPointerStore<ScopeN>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ScopeN");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopeN>.NativeClassPtr);
			ScopeN.NativeFieldInfoPtr__body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeN>.NativeClassPtr, "_body");
			ScopeN.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeN>.NativeClassPtr, 100664108);
			ScopeN.NativeMethodInfoPtr_get_Body_Protected_get_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeN>.NativeClassPtr, 100664109);
			ScopeN.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeN>.NativeClassPtr, 100664110);
			ScopeN.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeN>.NativeClassPtr, 100664111);
			ScopeN.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeN>.NativeClassPtr, 100664112);
			ScopeN.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeN>.NativeClassPtr, 100664113);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000201C8 File Offset: 0x0001E3C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1011836, RefRangeEnd = 1011843, XrefRangeStart = 1011836, XrefRangeEnd = 1011843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopeN>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeN.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00020228 File Offset: 0x0001E428
		public unsafe IReadOnlyList<Expression> Body
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeN.NativeMethodInfoPtr_get_Body_Protected_get_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00020268 File Offset: 0x0001E468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011979, XrefRangeEnd = 1011983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetExpression(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScopeN.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000202C0 File Offset: 0x0001E4C0
		public unsafe override int ExpressionCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011983, XrefRangeEnd = 1011987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScopeN.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00020308 File Offset: 0x0001E508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011987, XrefRangeEnd = 1011990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScopeN.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00020354 File Offset: 0x0001E554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011990, XrefRangeEnd = 1012003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScopeN.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr3) : null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002B68 File Offset: 0x00000D68
		public ScopeN(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600033E RID: 830 RVA: 0x000203C4 File Offset: 0x0001E5C4
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00002B71 File Offset: 0x00000D71
		public unsafe IReadOnlyList<Expression> _body
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeN.NativeFieldInfoPtr__body);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeN.NativeFieldInfoPtr__body), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr__body;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_IReadOnlyList_1_Expression_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Protected_get_IReadOnlyList_1_Expression_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0;
	}
}
