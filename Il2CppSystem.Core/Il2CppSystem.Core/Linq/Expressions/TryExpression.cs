using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000088 RID: 136
	public sealed class TryExpression : Expression
	{
		// Token: 0x0600072F RID: 1839 RVA: 0x00031CBC File Offset: 0x0002FEBC
		// Note: this type is marked as 'beforefieldinit'.
		static TryExpression()
		{
			Il2CppClassPointerStore<TryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "TryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TryExpression>.NativeClassPtr);
			TryExpression.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, "<Type>k__BackingField");
			TryExpression.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, "<Body>k__BackingField");
			TryExpression.NativeFieldInfoPtr__Handlers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, "<Handlers>k__BackingField");
			TryExpression.NativeFieldInfoPtr__Finally_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, "<Finally>k__BackingField");
			TryExpression.NativeFieldInfoPtr__Fault_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, "<Fault>k__BackingField");
			TryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_Expression_Expression_Expression_ReadOnlyCollection_1_CatchBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664749);
			TryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664750);
			TryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664751);
			TryExpression.NativeMethodInfoPtr_get_Body_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664752);
			TryExpression.NativeMethodInfoPtr_get_Handlers_Public_get_ReadOnlyCollection_1_CatchBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664753);
			TryExpression.NativeMethodInfoPtr_get_Finally_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664754);
			TryExpression.NativeMethodInfoPtr_get_Fault_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664755);
			TryExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664756);
			TryExpression.NativeMethodInfoPtr_Update_Public_TryExpression_Expression_IEnumerable_1_CatchBlock_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryExpression>.NativeClassPtr, 100664757);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00031E04 File Offset: 0x00030004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015136, RefRangeEnd = 1015137, XrefRangeStart = 1015127, XrefRangeEnd = 1015136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TryExpression(Type type, Expression body, Expression @finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@finally);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fault);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_Expression_Expression_Expression_ReadOnlyCollection_1_CatchBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00031E9C File Offset: 0x0003009C
		public unsafe override Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00031EDC File Offset: 0x000300DC
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00031F18 File Offset: 0x00030118
		public unsafe Expression Body
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr_get_Body_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00031F58 File Offset: 0x00030158
		public unsafe ReadOnlyCollection<CatchBlock> Handlers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr_get_Handlers_Public_get_ReadOnlyCollection_1_CatchBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<CatchBlock>>(intPtr3) : null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00031F98 File Offset: 0x00030198
		public unsafe Expression Finally
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr_get_Finally_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00031FD8 File Offset: 0x000301D8
		public unsafe Expression Fault
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr_get_Fault_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00032018 File Offset: 0x00030218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015137, XrefRangeEnd = 1015138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00032068 File Offset: 0x00030268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015138, XrefRangeEnd = 1015142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@finally);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fault);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryExpression.NativeMethodInfoPtr_Update_Public_TryExpression_Expression_IEnumerable_1_CatchBlock_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TryExpression>(intPtr3) : null;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00003C2B File Offset: 0x00001E2B
		public TryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x000320F0 File Offset: 0x000302F0
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00003C34 File Offset: 0x00001E34
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00032120 File Offset: 0x00030320
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00003C53 File Offset: 0x00001E53
		public unsafe Expression _Body_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Body_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00032150 File Offset: 0x00030350
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00003C72 File Offset: 0x00001E72
		public unsafe ReadOnlyCollection<CatchBlock> _Handlers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Handlers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<CatchBlock>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Handlers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00032180 File Offset: 0x00030380
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00003C91 File Offset: 0x00001E91
		public unsafe Expression _Finally_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Finally_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Finally_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000321B0 File Offset: 0x000303B0
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public unsafe Expression _Fault_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Fault_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryExpression.NativeFieldInfoPtr__Fault_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr__Handlers_k__BackingField;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr__Finally_k__BackingField;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr__Fault_k__BackingField;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_Expression_Expression_Expression_ReadOnlyCollection_1_CatchBlock_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Public_get_Expression_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_get_Handlers_Public_get_ReadOnlyCollection_1_CatchBlock_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_get_Finally_Public_get_Expression_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_get_Fault_Public_get_Expression_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_TryExpression_Expression_IEnumerable_1_CatchBlock_Expression_Expression_0;
	}
}
