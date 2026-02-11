using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200008A RID: 138
	public sealed class UnaryExpression : Expression
	{
		// Token: 0x06000753 RID: 1875 RVA: 0x00032568 File Offset: 0x00030768
		// Note: this type is marked as 'beforefieldinit'.
		static UnaryExpression()
		{
			Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "UnaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr);
			UnaryExpression.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, "<Type>k__BackingField");
			UnaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, "<NodeType>k__BackingField");
			UnaryExpression.NativeFieldInfoPtr__Operand_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, "<Operand>k__BackingField");
			UnaryExpression.NativeFieldInfoPtr__Method_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, "<Method>k__BackingField");
			UnaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Type_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664765);
			UnaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664766);
			UnaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664767);
			UnaryExpression.NativeMethodInfoPtr_get_Operand_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664768);
			UnaryExpression.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664769);
			UnaryExpression.NativeMethodInfoPtr_get_IsLifted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664770);
			UnaryExpression.NativeMethodInfoPtr_get_IsLiftedToNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664771);
			UnaryExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664772);
			UnaryExpression.NativeMethodInfoPtr_get_CanReduce_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664773);
			UnaryExpression.NativeMethodInfoPtr_Reduce_Public_Virtual_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664774);
			UnaryExpression.NativeMethodInfoPtr_get_IsPrefix_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664775);
			UnaryExpression.NativeMethodInfoPtr_FunctionalOp_Private_UnaryExpression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664776);
			UnaryExpression.NativeMethodInfoPtr_ReduceVariable_Private_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664777);
			UnaryExpression.NativeMethodInfoPtr_ReduceMember_Private_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664778);
			UnaryExpression.NativeMethodInfoPtr_ReduceIndex_Private_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664779);
			UnaryExpression.NativeMethodInfoPtr_Update_Public_UnaryExpression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100664780);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00032728 File Offset: 0x00030928
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1015170, RefRangeEnd = 1015188, XrefRangeStart = 1015163, XrefRangeEnd = 1015170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Type_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x000327A8 File Offset: 0x000309A8
		public unsafe override Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x000327E8 File Offset: 0x000309E8
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00032824 File Offset: 0x00030A24
		public unsafe Expression Operand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_get_Operand_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00032864 File Offset: 0x00030A64
		public unsafe MethodInfo Method
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x000328A4 File Offset: 0x00030AA4
		public unsafe bool IsLifted
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1015195, RefRangeEnd = 1015198, XrefRangeStart = 1015188, XrefRangeEnd = 1015195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_get_IsLifted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x000328E0 File Offset: 0x00030AE0
		public unsafe bool IsLiftedToNull
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1015200, RefRangeEnd = 1015201, XrefRangeStart = 1015198, XrefRangeEnd = 1015200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_get_IsLiftedToNull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0003291C File Offset: 0x00030B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015201, XrefRangeEnd = 1015202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0003296C File Offset: 0x00030B6C
		public unsafe override bool CanReduce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_get_CanReduce_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000329A8 File Offset: 0x00030BA8
		[CallerCount(0)]
		public unsafe override Expression Reduce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_Reduce_Public_Virtual_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x000329E8 File Offset: 0x00030BE8
		public unsafe bool IsPrefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_get_IsPrefix_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00032A24 File Offset: 0x00030C24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1015212, RefRangeEnd = 1015217, XrefRangeStart = 1015202, XrefRangeEnd = 1015212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnaryExpression FunctionalOp(Expression operand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_FunctionalOp_Private_UnaryExpression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnaryExpression>(intPtr3) : null;
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00032A74 File Offset: 0x00030C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015217, XrefRangeEnd = 1015265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ReduceVariable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_ReduceVariable_Private_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00032AB4 File Offset: 0x00030CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015265, XrefRangeEnd = 1015310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ReduceMember()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_ReduceMember_Private_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00032AF4 File Offset: 0x00030CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015310, XrefRangeEnd = 1015412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ReduceIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_ReduceIndex_Private_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00032B34 File Offset: 0x00030D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015412, XrefRangeEnd = 1015416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnaryExpression Update(Expression operand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryExpression.NativeMethodInfoPtr_Update_Public_UnaryExpression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnaryExpression>(intPtr3) : null;
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00003D31 File Offset: 0x00001F31
		public UnaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00032B84 File Offset: 0x00030D84
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00003D3A File Offset: 0x00001F3A
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryExpression.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryExpression.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00032BB4 File Offset: 0x00030DB4
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00003D59 File Offset: 0x00001F59
		public unsafe ExpressionType _NodeType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00032BDC File Offset: 0x00030DDC
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00003D74 File Offset: 0x00001F74
		public unsafe Expression _Operand_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryExpression.NativeFieldInfoPtr__Operand_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryExpression.NativeFieldInfoPtr__Operand_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00032C0C File Offset: 0x00030E0C
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00003D93 File Offset: 0x00001F93
		public unsafe MethodInfo _Method_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryExpression.NativeFieldInfoPtr__Method_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryExpression.NativeFieldInfoPtr__Method_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr__NodeType_k__BackingField;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr__Operand_k__BackingField;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr__Method_k__BackingField;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Type_MethodInfo_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_get_Operand_Public_get_Expression_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLifted_Public_get_Boolean_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLiftedToNull_Public_get_Boolean_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_get_CanReduce_Public_Virtual_get_Boolean_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_Reduce_Public_Virtual_Expression_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrefix_Private_get_Boolean_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_FunctionalOp_Private_UnaryExpression_Expression_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_ReduceVariable_Private_Expression_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_ReduceMember_Private_Expression_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_ReduceIndex_Private_Expression_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_UnaryExpression_Expression_0;
	}
}
