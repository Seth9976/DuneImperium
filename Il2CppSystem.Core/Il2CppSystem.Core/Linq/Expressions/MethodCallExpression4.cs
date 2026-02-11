using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000074 RID: 116
	public sealed class MethodCallExpression4 : MethodCallExpression
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x0002D278 File Offset: 0x0002B478
		// Note: this type is marked as 'beforefieldinit'.
		static MethodCallExpression4()
		{
			Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MethodCallExpression4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr);
			MethodCallExpression4.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr, "_arg0");
			MethodCallExpression4.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr, "_arg1");
			MethodCallExpression4.NativeFieldInfoPtr__arg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr, "_arg2");
			MethodCallExpression4.NativeFieldInfoPtr__arg3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr, "_arg3");
			MethodCallExpression4.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr, 100664563);
			MethodCallExpression4.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr, 100664564);
			MethodCallExpression4.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr, 100664565);
			MethodCallExpression4.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr, 100664566);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0002D348 File Offset: 0x0002B548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014415, RefRangeEnd = 1014416, XrefRangeStart = 1014406, XrefRangeEnd = 1014415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCallExpression4(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCallExpression4>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression4.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0002D3E0 File Offset: 0x0002B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014416, XrefRangeEnd = 1014417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression4.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0002D42C File Offset: 0x0002B62C
		public unsafe override int ArgumentCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression4.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0002D468 File Offset: 0x0002B668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014417, XrefRangeEnd = 1014436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression4.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCallExpression>(intPtr3) : null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000037CB File Offset: 0x000019CB
		public MethodCallExpression4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0002D4CC File Offset: 0x0002B6CC
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x000037D4 File Offset: 0x000019D4
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression4.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression4.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0002D4FC File Offset: 0x0002B6FC
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x000037F3 File Offset: 0x000019F3
		public unsafe Expression _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression4.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression4.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0002D52C File Offset: 0x0002B72C
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00003812 File Offset: 0x00001A12
		public unsafe Expression _arg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression4.NativeFieldInfoPtr__arg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression4.NativeFieldInfoPtr__arg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0002D55C File Offset: 0x0002B75C
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00003831 File Offset: 0x00001A31
		public unsafe Expression _arg3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression4.NativeFieldInfoPtr__arg3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression4.NativeFieldInfoPtr__arg3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr__arg2;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr__arg3;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_Expression_Expression_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0;
	}
}
