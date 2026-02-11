using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000026 RID: 38
	public class BinaryExpression : Expression
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x000170A0 File Offset: 0x000152A0
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryExpression()
		{
			Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "BinaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr);
			BinaryExpression.NativeFieldInfoPtr__Right_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, "<Right>k__BackingField");
			BinaryExpression.NativeFieldInfoPtr__Left_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, "<Left>k__BackingField");
			BinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663808);
			BinaryExpression.NativeMethodInfoPtr_get_CanReduce_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663809);
			BinaryExpression.NativeMethodInfoPtr_IsOpAssignment_Private_Static_Boolean_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663810);
			BinaryExpression.NativeMethodInfoPtr_get_Right_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663811);
			BinaryExpression.NativeMethodInfoPtr_get_Left_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663812);
			BinaryExpression.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663813);
			BinaryExpression.NativeMethodInfoPtr_GetMethod_Internal_Virtual_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663814);
			BinaryExpression.NativeMethodInfoPtr_Update_Public_BinaryExpression_Expression_LambdaExpression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663815);
			BinaryExpression.NativeMethodInfoPtr_Reduce_Public_Virtual_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663816);
			BinaryExpression.NativeMethodInfoPtr_GetBinaryOpFromAssignmentOp_Private_Static_ExpressionType_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663817);
			BinaryExpression.NativeMethodInfoPtr_ReduceVariable_Private_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663818);
			BinaryExpression.NativeMethodInfoPtr_ReduceMember_Private_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663819);
			BinaryExpression.NativeMethodInfoPtr_ReduceIndex_Private_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663820);
			BinaryExpression.NativeMethodInfoPtr_get_Conversion_Public_get_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663821);
			BinaryExpression.NativeMethodInfoPtr_GetConversion_Internal_Virtual_New_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663822);
			BinaryExpression.NativeMethodInfoPtr_get_IsLifted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663823);
			BinaryExpression.NativeMethodInfoPtr_get_IsLiftedToNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663824);
			BinaryExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663825);
			BinaryExpression.NativeMethodInfoPtr_get_IsLiftedLogical_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663826);
			BinaryExpression.NativeMethodInfoPtr_get_IsReferenceComparison_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663827);
			BinaryExpression.NativeMethodInfoPtr_ReduceUserdefinedLifted_Internal_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr, 100663828);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001729C File Offset: 0x0001549C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1006854, RefRangeEnd = 1006872, XrefRangeStart = 1006848, XrefRangeEnd = 1006854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryExpression(Expression left, Expression right)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000172FC File Offset: 0x000154FC
		public unsafe override bool CanReduce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryExpression.NativeMethodInfoPtr_get_CanReduce_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00017344 File Offset: 0x00015544
		[CallerCount(0)]
		public unsafe static bool IsOpAssignment(ExpressionType op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_IsOpAssignment_Private_Static_Boolean_ExpressionType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00017384 File Offset: 0x00015584
		public unsafe Expression Right
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_get_Right_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000173C4 File Offset: 0x000155C4
		public unsafe Expression Left
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_get_Left_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00017404 File Offset: 0x00015604
		public unsafe MethodInfo Method
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 868124, RefRangeEnd = 868148, XrefRangeStart = 868124, XrefRangeEnd = 868148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00017444 File Offset: 0x00015644
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryExpression.NativeMethodInfoPtr_GetMethod_Internal_Virtual_New_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00017490 File Offset: 0x00015690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006873, RefRangeEnd = 1006874, XrefRangeStart = 1006872, XrefRangeEnd = 1006873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversion);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_Update_Public_BinaryExpression_Expression_LambdaExpression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BinaryExpression>(intPtr3) : null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00017504 File Offset: 0x00015704
		[CallerCount(0)]
		public unsafe override Expression Reduce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryExpression.NativeMethodInfoPtr_Reduce_Public_Virtual_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00017550 File Offset: 0x00015750
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1006874, RefRangeEnd = 1006877, XrefRangeStart = 1006874, XrefRangeEnd = 1006874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_GetBinaryOpFromAssignmentOp_Private_Static_ExpressionType_ExpressionType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00017590 File Offset: 0x00015790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006877, XrefRangeEnd = 1006888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ReduceVariable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_ReduceVariable_Private_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000175D0 File Offset: 0x000157D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006888, XrefRangeEnd = 1006944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ReduceMember()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_ReduceMember_Private_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00017610 File Offset: 0x00015810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006944, XrefRangeEnd = 1007052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ReduceIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_ReduceIndex_Private_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00017650 File Offset: 0x00015850
		public unsafe LambdaExpression Conversion
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1007052, RefRangeEnd = 1007057, XrefRangeStart = 1007052, XrefRangeEnd = 1007052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_get_Conversion_Public_get_LambdaExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LambdaExpression>(intPtr3) : null;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00017690 File Offset: 0x00015890
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LambdaExpression GetConversion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryExpression.NativeMethodInfoPtr_GetConversion_Internal_Virtual_New_LambdaExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LambdaExpression>(intPtr3) : null;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000176DC File Offset: 0x000158DC
		public unsafe bool IsLifted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1007062, RefRangeEnd = 1007063, XrefRangeStart = 1007057, XrefRangeEnd = 1007062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_get_IsLifted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00017718 File Offset: 0x00015918
		public unsafe bool IsLiftedToNull
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1007065, RefRangeEnd = 1007069, XrefRangeStart = 1007063, XrefRangeEnd = 1007065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_get_IsLiftedToNull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00017754 File Offset: 0x00015954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007069, XrefRangeEnd = 1007070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000177B0 File Offset: 0x000159B0
		public unsafe bool IsLiftedLogical
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1007082, RefRangeEnd = 1007083, XrefRangeStart = 1007070, XrefRangeEnd = 1007082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_get_IsLiftedLogical_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000177EC File Offset: 0x000159EC
		public unsafe bool IsReferenceComparison
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007083, XrefRangeEnd = 1007086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_get_IsReferenceComparison_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00017828 File Offset: 0x00015A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007086, XrefRangeEnd = 1007235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ReduceUserdefinedLifted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryExpression.NativeMethodInfoPtr_ReduceUserdefinedLifted_Internal_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002712 File Offset: 0x00000912
		public BinaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00017868 File Offset: 0x00015A68
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000271B File Offset: 0x0000091B
		public unsafe Expression _Right_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryExpression.NativeFieldInfoPtr__Right_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryExpression.NativeFieldInfoPtr__Right_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00017898 File Offset: 0x00015A98
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000273A File Offset: 0x0000093A
		public unsafe Expression _Left_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryExpression.NativeFieldInfoPtr__Left_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryExpression.NativeFieldInfoPtr__Left_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr__Right_k__BackingField;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr__Left_k__BackingField;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_get_CanReduce_Public_Virtual_get_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_IsOpAssignment_Private_Static_Boolean_ExpressionType_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Expression_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_Expression_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Internal_Virtual_New_MethodInfo_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_BinaryExpression_Expression_LambdaExpression_Expression_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_Reduce_Public_Virtual_Expression_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_GetBinaryOpFromAssignmentOp_Private_Static_ExpressionType_ExpressionType_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_ReduceVariable_Private_Expression_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_ReduceMember_Private_Expression_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_ReduceIndex_Private_Expression_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_Conversion_Public_get_LambdaExpression_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_GetConversion_Internal_Virtual_New_LambdaExpression_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLifted_Public_get_Boolean_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLiftedToNull_Public_get_Boolean_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLiftedLogical_Internal_get_Boolean_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReferenceComparison_Internal_get_Boolean_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_ReduceUserdefinedLifted_Internal_Expression_0;
	}
}
