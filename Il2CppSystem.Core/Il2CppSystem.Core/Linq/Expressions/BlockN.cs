using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000033 RID: 51
	public class BlockN : BlockExpression
	{
		// Token: 0x0600031B RID: 795 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		// Note: this type is marked as 'beforefieldinit'.
		static BlockN()
		{
			Il2CppClassPointerStore<BlockN>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "BlockN");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockN>.NativeClassPtr);
			BlockN.NativeFieldInfoPtr__expressions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockN>.NativeClassPtr, "_expressions");
			BlockN.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockN>.NativeClassPtr, 100664093);
			BlockN.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockN>.NativeClassPtr, 100664094);
			BlockN.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockN>.NativeClassPtr, 100664095);
			BlockN.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockN>.NativeClassPtr, 100664096);
			BlockN.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockN>.NativeClassPtr, 100664097);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001FA70 File Offset: 0x0001DC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011919, XrefRangeEnd = 1011924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockN(IReadOnlyList<Expression> expressions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockN>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expressions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockN.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0001FABC File Offset: 0x0001DCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011924, XrefRangeEnd = 1011928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetExpression(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockN.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001FB14 File Offset: 0x0001DD14
		public unsafe override int ExpressionCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011928, XrefRangeEnd = 1011932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockN.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0001FB5C File Offset: 0x0001DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011932, XrefRangeEnd = 1011935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockN.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011935, XrefRangeEnd = 1011943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockN.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr3) : null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public BlockN(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001FC18 File Offset: 0x0001DE18
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00002AF9 File Offset: 0x00000CF9
		public unsafe IReadOnlyList<Expression> _expressions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockN.NativeFieldInfoPtr__expressions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockN.NativeFieldInfoPtr__expressions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr__expressions;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_Expression_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0;
	}
}
