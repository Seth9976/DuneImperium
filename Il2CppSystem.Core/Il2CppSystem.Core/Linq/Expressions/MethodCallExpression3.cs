using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000073 RID: 115
	public sealed class MethodCallExpression3 : MethodCallExpression
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x0002CFBC File Offset: 0x0002B1BC
		// Note: this type is marked as 'beforefieldinit'.
		static MethodCallExpression3()
		{
			Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MethodCallExpression3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr);
			MethodCallExpression3.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr, "_arg0");
			MethodCallExpression3.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr, "_arg1");
			MethodCallExpression3.NativeFieldInfoPtr__arg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr, "_arg2");
			MethodCallExpression3.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr, 100664559);
			MethodCallExpression3.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr, 100664560);
			MethodCallExpression3.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr, 100664561);
			MethodCallExpression3.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr, 100664562);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0002D078 File Offset: 0x0002B278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1014386, RefRangeEnd = 1014388, XrefRangeStart = 1014378, XrefRangeEnd = 1014386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCallExpression3(MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCallExpression3>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression3.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0002D0FC File Offset: 0x0002B2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014388, XrefRangeEnd = 1014389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression3.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0002D148 File Offset: 0x0002B348
		public unsafe override int ArgumentCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression3.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0002D184 File Offset: 0x0002B384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014389, XrefRangeEnd = 1014406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression3.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCallExpression>(intPtr3) : null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00003765 File Offset: 0x00001965
		public MethodCallExpression3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x0000376E File Offset: 0x0000196E
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression3.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression3.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0002D218 File Offset: 0x0002B418
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x0000378D File Offset: 0x0000198D
		public unsafe Expression _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression3.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression3.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0002D248 File Offset: 0x0002B448
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x000037AC File Offset: 0x000019AC
		public unsafe Expression _arg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression3.NativeFieldInfoPtr__arg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression3.NativeFieldInfoPtr__arg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr__arg2;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_Expression_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0;
	}
}
