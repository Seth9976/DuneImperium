using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000076 RID: 118
	public sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceMethodCallExpression0()
		{
			Il2CppClassPointerStore<InstanceMethodCallExpression0>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "InstanceMethodCallExpression0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceMethodCallExpression0>.NativeClassPtr);
			InstanceMethodCallExpression0.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpression0>.NativeClassPtr, 100664571);
			InstanceMethodCallExpression0.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpression0>.NativeClassPtr, 100664572);
			InstanceMethodCallExpression0.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpression0>.NativeClassPtr, 100664573);
			InstanceMethodCallExpression0.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceMethodCallExpression0>.NativeClassPtr, 100664574);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0002D974 File Offset: 0x0002BB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014469, XrefRangeEnd = 1014470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceMethodCallExpression0(MethodInfo method, Expression instance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceMethodCallExpression0>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpression0.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0002D9D4 File Offset: 0x0002BBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014470, XrefRangeEnd = 1014476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpression0.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0002DA20 File Offset: 0x0002BC20
		public unsafe override int ArgumentCount
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpression0.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0002DA5C File Offset: 0x0002BC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014476, XrefRangeEnd = 1014480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceMethodCallExpression0.NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCallExpression>(intPtr3) : null;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000038F4 File Offset: 0x00001AF4
		public InstanceMethodCallExpression0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_Expression_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_MethodCallExpression_Expression_IReadOnlyList_1_Expression_0;
	}
}
