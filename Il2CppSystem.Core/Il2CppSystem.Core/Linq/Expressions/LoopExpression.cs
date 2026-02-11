using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000062 RID: 98
	public sealed class LoopExpression : Expression
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x0002AFCC File Offset: 0x000291CC
		// Note: this type is marked as 'beforefieldinit'.
		static LoopExpression()
		{
			Il2CppClassPointerStore<LoopExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "LoopExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr);
			LoopExpression.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, "<Body>k__BackingField");
			LoopExpression.NativeFieldInfoPtr__BreakLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, "<BreakLabel>k__BackingField");
			LoopExpression.NativeFieldInfoPtr__ContinueLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, "<ContinueLabel>k__BackingField");
			LoopExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_LabelTarget_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, 100664497);
			LoopExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, 100664498);
			LoopExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, 100664499);
			LoopExpression.NativeMethodInfoPtr_get_Body_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, 100664500);
			LoopExpression.NativeMethodInfoPtr_get_BreakLabel_Public_get_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, 100664501);
			LoopExpression.NativeMethodInfoPtr_get_ContinueLabel_Public_get_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, 100664502);
			LoopExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, 100664503);
			LoopExpression.NativeMethodInfoPtr_Update_Public_LoopExpression_LabelTarget_LabelTarget_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr, 100664504);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0002B0D8 File Offset: 0x000292D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014206, RefRangeEnd = 1014207, XrefRangeStart = 1014199, XrefRangeEnd = 1014206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoopExpression(Expression body, LabelTarget @break, LabelTarget @continue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@break);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@continue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_LabelTarget_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0002B148 File Offset: 0x00029348
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014207, XrefRangeEnd = 1014213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0002B188 File Offset: 0x00029388
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0002B1C4 File Offset: 0x000293C4
		public unsafe Expression Body
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopExpression.NativeMethodInfoPtr_get_Body_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0002B204 File Offset: 0x00029404
		public unsafe LabelTarget BreakLabel
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopExpression.NativeMethodInfoPtr_get_BreakLabel_Public_get_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr3) : null;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0002B244 File Offset: 0x00029444
		public unsafe LabelTarget ContinueLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopExpression.NativeMethodInfoPtr_get_ContinueLabel_Public_get_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr3) : null;
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0002B284 File Offset: 0x00029484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014213, XrefRangeEnd = 1014214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0002B2D4 File Offset: 0x000294D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014214, XrefRangeEnd = 1014219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(breakLabel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continueLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoopExpression.NativeMethodInfoPtr_Update_Public_LoopExpression_LabelTarget_LabelTarget_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoopExpression>(intPtr3) : null;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000346D File Offset: 0x0000166D
		public LoopExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0002B348 File Offset: 0x00029548
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00003476 File Offset: 0x00001676
		public unsafe Expression _Body_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopExpression.NativeFieldInfoPtr__Body_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopExpression.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0002B378 File Offset: 0x00029578
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00003495 File Offset: 0x00001695
		public unsafe LabelTarget _BreakLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopExpression.NativeFieldInfoPtr__BreakLabel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopExpression.NativeFieldInfoPtr__BreakLabel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0002B3A8 File Offset: 0x000295A8
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x000034B4 File Offset: 0x000016B4
		public unsafe LabelTarget _ContinueLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopExpression.NativeFieldInfoPtr__ContinueLabel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoopExpression.NativeFieldInfoPtr__ContinueLabel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr__BreakLabel_k__BackingField;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr__ContinueLabel_k__BackingField;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_LabelTarget_LabelTarget_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Public_get_Expression_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_get_BreakLabel_Public_get_LabelTarget_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_ContinueLabel_Public_get_LabelTarget_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_LoopExpression_LabelTarget_LabelTarget_Expression_0;
	}
}
