using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000072 RID: 114
	public sealed class MethodCallExpression2 : MethodCallExpression
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x0002CD58 File Offset: 0x0002AF58
		// Note: this type is marked as 'beforefieldinit'.
		static MethodCallExpression2()
		{
			Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MethodCallExpression2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr);
			MethodCallExpression2.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr, "_arg0");
			MethodCallExpression2.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr, "_arg1");
			MethodCallExpression2.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr, 100664555);
			MethodCallExpression2.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr, 100664556);
			MethodCallExpression2.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr, 100664557);
			MethodCallExpression2.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr, 100664558);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0002CE00 File Offset: 0x0002B000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1014357, RefRangeEnd = 1014360, XrefRangeStart = 1014350, XrefRangeEnd = 1014357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCallExpression2(MethodInfo method, Expression arg0, Expression arg1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCallExpression2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression2.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0002CE70 File Offset: 0x0002B070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014360, XrefRangeEnd = 1014363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression2.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0002CEBC File Offset: 0x0002B0BC
		public unsafe override int ArgumentCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression2.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014363, XrefRangeEnd = 1014378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCallExpression2.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCallExpression>(intPtr3) : null;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000371E File Offset: 0x0000191E
		public MethodCallExpression2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0002CF5C File Offset: 0x0002B15C
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00003727 File Offset: 0x00001927
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression2.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression2.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0002CF8C File Offset: 0x0002B18C
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00003746 File Offset: 0x00001946
		public unsafe Expression _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression2.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCallExpression2.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_Expression_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0;
	}
}
