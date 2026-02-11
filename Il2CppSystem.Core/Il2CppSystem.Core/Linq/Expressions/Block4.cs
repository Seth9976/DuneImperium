using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000031 RID: 49
	public sealed class Block4 : BlockExpression
	{
		// Token: 0x060002FB RID: 763 RVA: 0x0001F2C8 File Offset: 0x0001D4C8
		// Note: this type is marked as 'beforefieldinit'.
		static Block4()
		{
			Il2CppClassPointerStore<Block4>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Block4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Block4>.NativeClassPtr);
			Block4.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block4>.NativeClassPtr, "_arg0");
			Block4.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block4>.NativeClassPtr, "_arg1");
			Block4.NativeFieldInfoPtr__arg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block4>.NativeClassPtr, "_arg2");
			Block4.NativeFieldInfoPtr__arg3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block4>.NativeClassPtr, "_arg3");
			Block4.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block4>.NativeClassPtr, 100664083);
			Block4.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block4>.NativeClassPtr, 100664084);
			Block4.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block4>.NativeClassPtr, 100664085);
			Block4.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block4>.NativeClassPtr, 100664086);
			Block4.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block4>.NativeClassPtr, 100664087);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011883, RefRangeEnd = 1011884, XrefRangeStart = 1011875, XrefRangeEnd = 1011883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Block4(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Block4>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block4.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001F430 File Offset: 0x0001D630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011884, XrefRangeEnd = 1011885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetExpression(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block4.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0001F47C File Offset: 0x0001D67C
		public unsafe override int ExpressionCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block4.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block4.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011885, XrefRangeEnd = 1011896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block4.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr3) : null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000029C7 File Offset: 0x00000BC7
		public Block4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001F55C File Offset: 0x0001D75C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x000029D0 File Offset: 0x00000BD0
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block4.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block4.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001F58C File Offset: 0x0001D78C
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000029EF File Offset: 0x00000BEF
		public unsafe Expression _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block4.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block4.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0001F5BC File Offset: 0x0001D7BC
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00002A0E File Offset: 0x00000C0E
		public unsafe Expression _arg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block4.NativeFieldInfoPtr__arg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block4.NativeFieldInfoPtr__arg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0001F5EC File Offset: 0x0001D7EC
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00002A2D File Offset: 0x00000C2D
		public unsafe Expression _arg3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block4.NativeFieldInfoPtr__arg3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Block4.NativeFieldInfoPtr__arg3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr__arg2;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr__arg3;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_Expression_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_Int32_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0;
	}
}
