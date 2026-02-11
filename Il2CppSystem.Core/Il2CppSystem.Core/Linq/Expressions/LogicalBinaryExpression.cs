using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000027 RID: 39
	public sealed class LogicalBinaryExpression : BinaryExpression
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x000178C8 File Offset: 0x00015AC8
		// Note: this type is marked as 'beforefieldinit'.
		static LogicalBinaryExpression()
		{
			Il2CppClassPointerStore<LogicalBinaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "LogicalBinaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogicalBinaryExpression>.NativeClassPtr);
			LogicalBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalBinaryExpression>.NativeClassPtr, "<NodeType>k__BackingField");
			LogicalBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalBinaryExpression>.NativeClassPtr, 100663829);
			LogicalBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalBinaryExpression>.NativeClassPtr, 100663830);
			LogicalBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalBinaryExpression>.NativeClassPtr, 100663831);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00017948 File Offset: 0x00015B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007235, XrefRangeEnd = 1007236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalBinaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000179B4 File Offset: 0x00015BB4
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007236, XrefRangeEnd = 1007242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000179F4 File Offset: 0x00015BF4
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002759 File Offset: 0x00000959
		public LogicalBinaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00017A30 File Offset: 0x00015C30
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002762 File Offset: 0x00000962
		public unsafe ExpressionType _NodeType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField)) = value;
			}
		}

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr__NodeType_k__BackingField;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;
	}
}
