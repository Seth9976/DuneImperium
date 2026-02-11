using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200004A RID: 74
	public sealed class GotoExpression : Expression
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x0002709C File Offset: 0x0002529C
		// Note: this type is marked as 'beforefieldinit'.
		static GotoExpression()
		{
			Il2CppClassPointerStore<GotoExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "GotoExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr);
			GotoExpression.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, "<Type>k__BackingField");
			GotoExpression.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, "<Value>k__BackingField");
			GotoExpression.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, "<Target>k__BackingField");
			GotoExpression.NativeFieldInfoPtr__Kind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, "<Kind>k__BackingField");
			GotoExpression.NativeMethodInfoPtr__ctor_Internal_Void_GotoExpressionKind_LabelTarget_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, 100664381);
			GotoExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, 100664382);
			GotoExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, 100664383);
			GotoExpression.NativeMethodInfoPtr_get_Value_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, 100664384);
			GotoExpression.NativeMethodInfoPtr_get_Target_Public_get_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, 100664385);
			GotoExpression.NativeMethodInfoPtr_get_Kind_Public_get_GotoExpressionKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, 100664386);
			GotoExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, 100664387);
			GotoExpression.NativeMethodInfoPtr_Update_Public_GotoExpression_LabelTarget_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr, 100664388);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000271BC File Offset: 0x000253BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013817, RefRangeEnd = 1013818, XrefRangeStart = 1013810, XrefRangeEnd = 1013817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GotoExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoExpression.NativeMethodInfoPtr__ctor_Internal_Void_GotoExpressionKind_LabelTarget_Expression_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0002723C File Offset: 0x0002543C
		public unsafe override Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0002727C File Offset: 0x0002547C
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000272B8 File Offset: 0x000254B8
		public unsafe Expression Value
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoExpression.NativeMethodInfoPtr_get_Value_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x000272F8 File Offset: 0x000254F8
		public unsafe LabelTarget Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoExpression.NativeMethodInfoPtr_get_Target_Public_get_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr3) : null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00027338 File Offset: 0x00025538
		public unsafe GotoExpressionKind Kind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoExpression.NativeMethodInfoPtr_get_Kind_Public_get_GotoExpressionKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00027374 File Offset: 0x00025574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013818, XrefRangeEnd = 1013819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000273C4 File Offset: 0x000255C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013819, XrefRangeEnd = 1013820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GotoExpression Update(LabelTarget target, Expression value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoExpression.NativeMethodInfoPtr_Update_Public_GotoExpression_LabelTarget_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GotoExpression>(intPtr3) : null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002EA6 File Offset: 0x000010A6
		public GotoExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00027428 File Offset: 0x00025628
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00002EAF File Offset: 0x000010AF
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoExpression.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoExpression.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00027458 File Offset: 0x00025658
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00002ECE File Offset: 0x000010CE
		public unsafe Expression _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoExpression.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoExpression.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00027488 File Offset: 0x00025688
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00002EED File Offset: 0x000010ED
		public unsafe LabelTarget _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoExpression.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoExpression.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000274B8 File Offset: 0x000256B8
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00002F0C File Offset: 0x0000110C
		public unsafe GotoExpressionKind _Kind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoExpression.NativeFieldInfoPtr__Kind_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoExpression.NativeFieldInfoPtr__Kind_k__BackingField)) = value;
			}
		}

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr__Kind_k__BackingField;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GotoExpressionKind_LabelTarget_Expression_Type_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Expression_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_LabelTarget_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_get_GotoExpressionKind_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_GotoExpression_LabelTarget_Expression_0;
	}
}
