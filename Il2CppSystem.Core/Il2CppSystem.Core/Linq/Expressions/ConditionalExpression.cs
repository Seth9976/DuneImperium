using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200003D RID: 61
	public class ConditionalExpression : Expression
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00021110 File Offset: 0x0001F310
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalExpression()
		{
			Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ConditionalExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr);
			ConditionalExpression.NativeFieldInfoPtr__Test_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, "<Test>k__BackingField");
			ConditionalExpression.NativeFieldInfoPtr__IfTrue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, "<IfTrue>k__BackingField");
			ConditionalExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664148);
			ConditionalExpression.NativeMethodInfoPtr_Make_Internal_Static_ConditionalExpression_Expression_Expression_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664149);
			ConditionalExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664150);
			ConditionalExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664151);
			ConditionalExpression.NativeMethodInfoPtr_get_Test_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664152);
			ConditionalExpression.NativeMethodInfoPtr_get_IfTrue_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664153);
			ConditionalExpression.NativeMethodInfoPtr_get_IfFalse_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664154);
			ConditionalExpression.NativeMethodInfoPtr_GetFalse_Internal_Virtual_New_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664155);
			ConditionalExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664156);
			ConditionalExpression.NativeMethodInfoPtr_Update_Public_ConditionalExpression_Expression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr, 100664157);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00021230 File Offset: 0x0001F430
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1012125, RefRangeEnd = 1012129, XrefRangeStart = 1012119, XrefRangeEnd = 1012125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalExpression(Expression test, Expression ifTrue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(test);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifTrue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00021290 File Offset: 0x0001F490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012155, RefRangeEnd = 1012157, XrefRangeStart = 1012129, XrefRangeEnd = 1012155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(test);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifTrue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifFalse);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalExpression.NativeMethodInfoPtr_Make_Internal_Static_ConditionalExpression_Expression_Expression_Expression_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalExpression>(intPtr3) : null;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0002130C File Offset: 0x0001F50C
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 72449, RefRangeEnd = 72472, XrefRangeStart = 72449, XrefRangeEnd = 72472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00021348 File Offset: 0x0001F548
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00021394 File Offset: 0x0001F594
		public unsafe Expression Test
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalExpression.NativeMethodInfoPtr_get_Test_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600037A RID: 890 RVA: 0x000213D4 File Offset: 0x0001F5D4
		public unsafe Expression IfTrue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalExpression.NativeMethodInfoPtr_get_IfTrue_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00021414 File Offset: 0x0001F614
		public unsafe Expression IfFalse
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 868124, RefRangeEnd = 868148, XrefRangeStart = 868124, XrefRangeEnd = 868148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalExpression.NativeMethodInfoPtr_get_IfFalse_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00021454 File Offset: 0x0001F654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012157, XrefRangeEnd = 1012161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression GetFalse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalExpression.NativeMethodInfoPtr_GetFalse_Internal_Virtual_New_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000214A0 File Offset: 0x0001F6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012161, XrefRangeEnd = 1012162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000214FC File Offset: 0x0001F6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012162, XrefRangeEnd = 1012167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(test);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifTrue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifFalse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalExpression.NativeMethodInfoPtr_Update_Public_ConditionalExpression_Expression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalExpression>(intPtr3) : null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002CCF File Offset: 0x00000ECF
		public ConditionalExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00021570 File Offset: 0x0001F770
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public unsafe Expression _Test_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalExpression.NativeFieldInfoPtr__Test_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalExpression.NativeFieldInfoPtr__Test_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000215A0 File Offset: 0x0001F7A0
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00002CF7 File Offset: 0x00000EF7
		public unsafe Expression _IfTrue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalExpression.NativeFieldInfoPtr__IfTrue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalExpression.NativeFieldInfoPtr__IfTrue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr__Test_k__BackingField;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr__IfTrue_k__BackingField;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_Make_Internal_Static_ConditionalExpression_Expression_Expression_Expression_Type_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_Type_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_get_Test_Public_get_Expression_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_get_IfTrue_Public_get_Expression_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_get_IfFalse_Public_get_Expression_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_GetFalse_Internal_Virtual_New_Expression_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_ConditionalExpression_Expression_Expression_Expression_0;
	}
}
