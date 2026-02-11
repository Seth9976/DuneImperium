using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200006F RID: 111
	public sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x0002C770 File Offset: 0x0002A970
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceMethodCallExpressionN()
		{
			Il2CppClassPointerStore<InstanceMethodCallExpressionN>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "InstanceMethodCallExpressionN");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceMethodCallExpressionN>.NativeClassPtr);
			InstanceMethodCallExpressionN.NativeFieldInfoPtr__arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceMethodCallExpressionN>.NativeClassPtr, "_arguments");
			InstanceMethodCallExpressionN.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpressionN>.NativeClassPtr, 100664543);
			InstanceMethodCallExpressionN.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpressionN>.NativeClassPtr, 100664544);
			InstanceMethodCallExpressionN.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpressionN>.NativeClassPtr, 100664545);
			InstanceMethodCallExpressionN.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpressionN>.NativeClassPtr, 100664546);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0002C804 File Offset: 0x0002AA04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014307, RefRangeEnd = 1014308, XrefRangeStart = 1014305, XrefRangeEnd = 1014307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IReadOnlyList<Expression> args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceMethodCallExpressionN>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpressionN.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0002C874 File Offset: 0x0002AA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014308, XrefRangeEnd = 1014312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpressionN.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0002C8C0 File Offset: 0x0002AAC0
		public unsafe override int ArgumentCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014312, XrefRangeEnd = 1014316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpressionN.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0002C8FC File Offset: 0x0002AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014316, XrefRangeEnd = 1014320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpressionN.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCallExpression>(intPtr3) : null;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000036C5 File Offset: 0x000018C5
		public InstanceMethodCallExpressionN(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0002C960 File Offset: 0x0002AB60
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x000036CE File Offset: 0x000018CE
		public unsafe IReadOnlyList<Expression> _arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceMethodCallExpressionN.NativeFieldInfoPtr__arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceMethodCallExpressionN.NativeFieldInfoPtr__arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr__arguments;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_IReadOnlyList_1_Expression_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0;
	}
}
