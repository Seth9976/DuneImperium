using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200002F RID: 47
	public sealed class Block2 : BlockExpression
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x0001ED24 File Offset: 0x0001CF24
		// Note: this type is marked as 'beforefieldinit'.
		static Block2()
		{
			Il2CppClassPointerStore<Block2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Block2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Block2>.NativeClassPtr);
			Block2.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block2>.NativeClassPtr, "_arg0");
			Block2.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block2>.NativeClassPtr, "_arg1");
			Block2.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block2>.NativeClassPtr, 100664073);
			Block2.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block2>.NativeClassPtr, 100664074);
			Block2.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block2>.NativeClassPtr, 100664075);
			Block2.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block2>.NativeClassPtr, 100664076);
			Block2.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block2>.NativeClassPtr, 100664077);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1011836, RefRangeEnd = 1011843, XrefRangeStart = 1011830, XrefRangeEnd = 1011836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Block2(Expression arg0, Expression arg1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Block2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block2.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001EE40 File Offset: 0x0001D040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011843, XrefRangeEnd = 1011846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetExpression(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block2.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0001EE8C File Offset: 0x0001D08C
		public unsafe override int ExpressionCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block2.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011846, XrefRangeEnd = 1011847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block2.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001EF08 File Offset: 0x0001D108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011847, XrefRangeEnd = 1011856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block2.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr3) : null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000291A File Offset: 0x00000B1A
		public Block2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0001EF6C File Offset: 0x0001D16C
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00002923 File Offset: 0x00000B23
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block2.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block2.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0001EF9C File Offset: 0x0001D19C
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00002942 File Offset: 0x00000B42
		public unsafe Expression _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block2.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block2.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0;
	}
}
