using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200002A RID: 42
	public sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x00017D90 File Offset: 0x00015F90
		// Note: this type is marked as 'beforefieldinit'.
		static OpAssignMethodConversionBinaryExpression()
		{
			Il2CppClassPointerStore<OpAssignMethodConversionBinaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "OpAssignMethodConversionBinaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpAssignMethodConversionBinaryExpression>.NativeClassPtr);
			OpAssignMethodConversionBinaryExpression.NativeFieldInfoPtr__conversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpAssignMethodConversionBinaryExpression>.NativeClassPtr, "_conversion");
			OpAssignMethodConversionBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_MethodInfo_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpAssignMethodConversionBinaryExpression>.NativeClassPtr, 100663839);
			OpAssignMethodConversionBinaryExpression.NativeMethodInfoPtr_GetConversion_Internal_Virtual_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpAssignMethodConversionBinaryExpression>.NativeClassPtr, 100663840);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00017DFC File Offset: 0x00015FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007246, XrefRangeEnd = 1007250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpAssignMethodConversionBinaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpAssignMethodConversionBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_MethodInfo_LambdaExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00017EA0 File Offset: 0x000160A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override LambdaExpression GetConversion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpAssignMethodConversionBinaryExpression.NativeMethodInfoPtr_GetConversion_Internal_Virtual_LambdaExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LambdaExpression>(intPtr3) : null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000027AE File Offset: 0x000009AE
		public OpAssignMethodConversionBinaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00017EE0 File Offset: 0x000160E0
		// (set) Token: 0x060001DD RID: 477 RVA: 0x000027B7 File Offset: 0x000009B7
		public unsafe LambdaExpression _conversion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpAssignMethodConversionBinaryExpression.NativeFieldInfoPtr__conversion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LambdaExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpAssignMethodConversionBinaryExpression.NativeFieldInfoPtr__conversion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr__conversion;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_MethodInfo_LambdaExpression_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_GetConversion_Internal_Virtual_LambdaExpression_0;
	}
}
