using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000089 RID: 137
	public sealed class TypeBinaryExpression : Expression
	{
		// Token: 0x06000744 RID: 1860 RVA: 0x000321E0 File Offset: 0x000303E0
		// Note: this type is marked as 'beforefieldinit'.
		static TypeBinaryExpression()
		{
			Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "TypeBinaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr);
			TypeBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, "<NodeType>k__BackingField");
			TypeBinaryExpression.NativeFieldInfoPtr__Expression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, "<Expression>k__BackingField");
			TypeBinaryExpression.NativeFieldInfoPtr__TypeOperand_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, "<TypeOperand>k__BackingField");
			TypeBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Type_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, 100664758);
			TypeBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, 100664759);
			TypeBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, 100664760);
			TypeBinaryExpression.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, 100664761);
			TypeBinaryExpression.NativeMethodInfoPtr_get_TypeOperand_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, 100664762);
			TypeBinaryExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, 100664763);
			TypeBinaryExpression.NativeMethodInfoPtr_Update_Public_TypeBinaryExpression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr, 100664764);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000322D8 File Offset: 0x000304D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1015148, RefRangeEnd = 1015150, XrefRangeStart = 1015142, XrefRangeEnd = 1015148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeBinaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeOperand);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Type_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00032344 File Offset: 0x00030544
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015150, XrefRangeEnd = 1015156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00032384 File Offset: 0x00030584
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000323C0 File Offset: 0x000305C0
		public unsafe Expression Expression
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBinaryExpression.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00032400 File Offset: 0x00030600
		public unsafe Type TypeOperand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBinaryExpression.NativeMethodInfoPtr_get_TypeOperand_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00032440 File Offset: 0x00030640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015156, XrefRangeEnd = 1015157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBinaryExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00032490 File Offset: 0x00030690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015157, XrefRangeEnd = 1015163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeBinaryExpression Update(Expression expression)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBinaryExpression.NativeMethodInfoPtr_Update_Public_TypeBinaryExpression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeBinaryExpression>(intPtr3) : null;
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00003CCF File Offset: 0x00001ECF
		public TypeBinaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x000324E0 File Offset: 0x000306E0
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public unsafe ExpressionType _NodeType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00032508 File Offset: 0x00030708
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00003CF3 File Offset: 0x00001EF3
		public unsafe Expression _Expression_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeBinaryExpression.NativeFieldInfoPtr__Expression_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeBinaryExpression.NativeFieldInfoPtr__Expression_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00032538 File Offset: 0x00030738
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00003D12 File Offset: 0x00001F12
		public unsafe Type _TypeOperand_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeBinaryExpression.NativeFieldInfoPtr__TypeOperand_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeBinaryExpression.NativeFieldInfoPtr__TypeOperand_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr__NodeType_k__BackingField;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr__Expression_k__BackingField;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr__TypeOperand_k__BackingField;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Type_ExpressionType_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_get_Expression_Public_get_Expression_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeOperand_Public_get_Type_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_TypeBinaryExpression_Expression_0;
	}
}
