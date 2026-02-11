using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200007A RID: 122
	public class NewArrayExpression : Expression
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x0002E228 File Offset: 0x0002C428
		// Note: this type is marked as 'beforefieldinit'.
		static NewArrayExpression()
		{
			Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "NewArrayExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr);
			NewArrayExpression.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr, "<Type>k__BackingField");
			NewArrayExpression.NativeFieldInfoPtr__Expressions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr, "<Expressions>k__BackingField");
			NewArrayExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr, 100664587);
			NewArrayExpression.NativeMethodInfoPtr_Make_Internal_Static_NewArrayExpression_ExpressionType_Type_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr, 100664588);
			NewArrayExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr, 100664589);
			NewArrayExpression.NativeMethodInfoPtr_get_Expressions_Public_get_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr, 100664590);
			NewArrayExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr, 100664591);
			NewArrayExpression.NativeMethodInfoPtr_Update_Public_NewArrayExpression_IEnumerable_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr, 100664592);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0002E2F8 File Offset: 0x0002C4F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1014549, RefRangeEnd = 1014552, XrefRangeStart = 1014543, XrefRangeEnd = 1014549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewArrayExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expressions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0002E358 File Offset: 0x0002C558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1014558, RefRangeEnd = 1014560, XrefRangeStart = 1014552, XrefRangeEnd = 1014558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expressions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayExpression.NativeMethodInfoPtr_Make_Internal_Static_NewArrayExpression_ExpressionType_Type_ReadOnlyCollection_1_Expression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NewArrayExpression>(intPtr3) : null;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0002E3BC File Offset: 0x0002C5BC
		public unsafe override Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0002E3FC File Offset: 0x0002C5FC
		public unsafe ReadOnlyCollection<Expression> Expressions
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayExpression.NativeMethodInfoPtr_get_Expressions_Public_get_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002E43C File Offset: 0x0002C63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014560, XrefRangeEnd = 1014561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewArrayExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0002E498 File Offset: 0x0002C698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014561, XrefRangeEnd = 1014571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewArrayExpression Update(IEnumerable<Expression> expressions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expressions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayExpression.NativeMethodInfoPtr_Update_Public_NewArrayExpression_IEnumerable_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NewArrayExpression>(intPtr3) : null;
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000039D2 File Offset: 0x00001BD2
		public NewArrayExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x000039DB File Offset: 0x00001BDB
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayExpression.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayExpression.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0002E518 File Offset: 0x0002C718
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x000039FA File Offset: 0x00001BFA
		public unsafe ReadOnlyCollection<Expression> _Expressions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayExpression.NativeFieldInfoPtr__Expressions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayExpression.NativeFieldInfoPtr__Expressions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeFieldInfoPtr__Expressions_k__BackingField;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_Make_Internal_Static_NewArrayExpression_ExpressionType_Type_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_get_Expressions_Public_get_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_NewArrayExpression_IEnumerable_1_Expression_0;
	}
}
