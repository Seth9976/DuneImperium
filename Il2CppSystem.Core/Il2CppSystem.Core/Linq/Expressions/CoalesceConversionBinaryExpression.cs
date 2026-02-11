using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000029 RID: 41
	public sealed class CoalesceConversionBinaryExpression : BinaryExpression
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00017BA0 File Offset: 0x00015DA0
		// Note: this type is marked as 'beforefieldinit'.
		static CoalesceConversionBinaryExpression()
		{
			Il2CppClassPointerStore<CoalesceConversionBinaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "CoalesceConversionBinaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoalesceConversionBinaryExpression>.NativeClassPtr);
			CoalesceConversionBinaryExpression.NativeFieldInfoPtr__conversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoalesceConversionBinaryExpression>.NativeClassPtr, "_conversion");
			CoalesceConversionBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalesceConversionBinaryExpression>.NativeClassPtr, 100663835);
			CoalesceConversionBinaryExpression.NativeMethodInfoPtr_GetConversion_Internal_Virtual_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalesceConversionBinaryExpression>.NativeClassPtr, 100663836);
			CoalesceConversionBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalesceConversionBinaryExpression>.NativeClassPtr, 100663837);
			CoalesceConversionBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalesceConversionBinaryExpression>.NativeClassPtr, 100663838);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00017C34 File Offset: 0x00015E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007244, XrefRangeEnd = 1007246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoalesceConversionBinaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalesceConversionBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_LambdaExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00017CA4 File Offset: 0x00015EA4
		[CallerCount(0)]
		public unsafe override LambdaExpression GetConversion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalesceConversionBinaryExpression.NativeMethodInfoPtr_GetConversion_Internal_Virtual_LambdaExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LambdaExpression>(intPtr3) : null;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00017CE4 File Offset: 0x00015EE4
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalesceConversionBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00017D20 File Offset: 0x00015F20
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalesceConversionBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002786 File Offset: 0x00000986
		public CoalesceConversionBinaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00017D60 File Offset: 0x00015F60
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000278F File Offset: 0x0000098F
		public unsafe LambdaExpression _conversion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoalesceConversionBinaryExpression.NativeFieldInfoPtr__conversion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LambdaExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoalesceConversionBinaryExpression.NativeFieldInfoPtr__conversion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr__conversion;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_LambdaExpression_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_GetConversion_Internal_Virtual_LambdaExpression_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;
	}
}
