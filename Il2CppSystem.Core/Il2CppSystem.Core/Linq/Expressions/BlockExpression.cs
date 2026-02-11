using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200002E RID: 46
	public class BlockExpression : Expression
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x0001E84C File Offset: 0x0001CA4C
		// Note: this type is marked as 'beforefieldinit'.
		static BlockExpression()
		{
			Il2CppClassPointerStore<BlockExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "BlockExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr);
			BlockExpression.NativeMethodInfoPtr_get_Expressions_Public_get_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664061);
			BlockExpression.NativeMethodInfoPtr_get_Variables_Public_get_ReadOnlyCollection_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664062);
			BlockExpression.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664063);
			BlockExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664064);
			BlockExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664065);
			BlockExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664066);
			BlockExpression.NativeMethodInfoPtr_GetExpression_Internal_Virtual_New_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664067);
			BlockExpression.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664068);
			BlockExpression.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_New_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664069);
			BlockExpression.NativeMethodInfoPtr_GetOrMakeVariables_Internal_Virtual_New_ReadOnlyCollection_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664070);
			BlockExpression.NativeMethodInfoPtr_Rewrite_Internal_Virtual_New_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664071);
			BlockExpression.NativeMethodInfoPtr_ReturnReadOnlyExpressions_Internal_Static_ReadOnlyCollection_1_Expression_BlockExpression_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr, 100664072);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0001E96C File Offset: 0x0001CB6C
		public unsafe ReadOnlyCollection<Expression> Expressions
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1011778, RefRangeEnd = 1011786, XrefRangeStart = 1011778, XrefRangeEnd = 1011778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpression.NativeMethodInfoPtr_get_Expressions_Public_get_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0001E9AC File Offset: 0x0001CBAC
		public unsafe ReadOnlyCollection<ParameterExpression> Variables
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 308626, RefRangeEnd = 308638, XrefRangeStart = 308626, XrefRangeEnd = 308638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpression.NativeMethodInfoPtr_get_Variables_Public_get_ReadOnlyCollection_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ParameterExpression>>(intPtr3) : null;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0001E9EC File Offset: 0x0001CBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011786, XrefRangeEnd = 1011790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockExpression()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockExpression>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpression.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001EA28 File Offset: 0x0001CC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011790, XrefRangeEnd = 1011791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0001EA84 File Offset: 0x0001CC84
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011791, XrefRangeEnd = 1011792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0001EB0C File Offset: 0x0001CD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011792, XrefRangeEnd = 1011795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression GetExpression(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockExpression.NativeMethodInfoPtr_GetExpression_Internal_Virtual_New_Expression_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0001EB64 File Offset: 0x0001CD64
		public unsafe virtual int ExpressionCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011795, XrefRangeEnd = 1011798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockExpression.NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001EBAC File Offset: 0x0001CDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011798, XrefRangeEnd = 1011801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockExpression.NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_New_ReadOnlyCollection_1_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001EBF8 File Offset: 0x0001CDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011801, XrefRangeEnd = 1011805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockExpression.NativeMethodInfoPtr_GetOrMakeVariables_Internal_Virtual_New_ReadOnlyCollection_1_ParameterExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ParameterExpression>>(intPtr3) : null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001EC44 File Offset: 0x0001CE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011805, XrefRangeEnd = 1011808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Il2CppReferenceArray<Expression> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlockExpression.NativeMethodInfoPtr_Rewrite_Internal_Virtual_New_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr3) : null;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1011825, RefRangeEnd = 1011830, XrefRangeStart = 1011808, XrefRangeEnd = 1011825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref Object collection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BlockExpression.NativeMethodInfoPtr_ReturnReadOnlyExpressions_Internal_Static_ReadOnlyCollection_1_Expression_BlockExpression_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			collection = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr5) : null;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002911 File Offset: 0x00000B11
		public BlockExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_get_Expressions_Public_get_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_Variables_Public_get_ReadOnlyCollection_1_ParameterExpression_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_Type_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_New_Expression_Int32_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpressionCount_Internal_Virtual_New_get_Int32_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeExpressions_Internal_Virtual_New_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeVariables_Internal_Virtual_New_ReadOnlyCollection_1_ParameterExpression_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_New_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_ReturnReadOnlyExpressions_Internal_Static_ReadOnlyCollection_1_Expression_BlockExpression_byref_Object_0;
	}
}
