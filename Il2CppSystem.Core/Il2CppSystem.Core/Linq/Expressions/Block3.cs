using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000030 RID: 48
	public sealed class Block3 : BlockExpression
	{
		// Token: 0x060002EE RID: 750 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		// Note: this type is marked as 'beforefieldinit'.
		static Block3()
		{
			Il2CppClassPointerStore<Block3>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Block3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Block3>.NativeClassPtr);
			Block3.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block3>.NativeClassPtr, "_arg0");
			Block3.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block3>.NativeClassPtr, "_arg1");
			Block3.NativeFieldInfoPtr__arg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block3>.NativeClassPtr, "_arg2");
			Block3.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block3>.NativeClassPtr, 100664078);
			Block3.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block3>.NativeClassPtr, 100664079);
			Block3.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block3>.NativeClassPtr, 100664080);
			Block3.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block3>.NativeClassPtr, 100664081);
			Block3.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block3>.NativeClassPtr, 100664082);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001F09C File Offset: 0x0001D29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011863, RefRangeEnd = 1011864, XrefRangeStart = 1011856, XrefRangeEnd = 1011863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Block3(Expression arg0, Expression arg1, Expression arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Block3>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block3.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001F10C File Offset: 0x0001D30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011864, XrefRangeEnd = 1011865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetExpression(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block3.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0001F158 File Offset: 0x0001D358
		public unsafe override int ExpressionCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block3.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001F194 File Offset: 0x0001D394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block3.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0001F1D4 File Offset: 0x0001D3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011865, XrefRangeEnd = 1011875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block3.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr3) : null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002961 File Offset: 0x00000B61
		public Block3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0001F238 File Offset: 0x0001D438
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000296A File Offset: 0x00000B6A
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block3.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block3.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0001F268 File Offset: 0x0001D468
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00002989 File Offset: 0x00000B89
		public unsafe Expression _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block3.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block3.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0001F298 File Offset: 0x0001D498
		// (set) Token: 0x060002FA RID: 762 RVA: 0x000029A8 File Offset: 0x00000BA8
		public unsafe Expression _arg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block3.NativeFieldInfoPtr__arg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block3.NativeFieldInfoPtr__arg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr__arg2;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0;
	}
}
