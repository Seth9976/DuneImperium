using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000051 RID: 81
	public sealed class InvocationExpression1 : InvocationExpression
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x000282E4 File Offset: 0x000264E4
		// Note: this type is marked as 'beforefieldinit'.
		static InvocationExpression1()
		{
			Il2CppClassPointerStore<InvocationExpression1>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "InvocationExpression1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvocationExpression1>.NativeClassPtr);
			InvocationExpression1.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvocationExpression1>.NativeClassPtr, "_arg0");
			InvocationExpression1.NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression1>.NativeClassPtr, 100664418);
			InvocationExpression1.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression1>.NativeClassPtr, 100664419);
			InvocationExpression1.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression1>.NativeClassPtr, 100664420);
			InvocationExpression1.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression1>.NativeClassPtr, 100664421);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00028378 File Offset: 0x00026578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013911, RefRangeEnd = 1013912, XrefRangeStart = 1013909, XrefRangeEnd = 1013911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvocationExpression1(Expression lambda, Type returnType, Expression arg0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvocationExpression1>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression1.NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000283E8 File Offset: 0x000265E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013912, XrefRangeEnd = 1013921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression1.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00028434 File Offset: 0x00026634
		public unsafe override int ArgumentCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression1.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00028470 File Offset: 0x00026670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013921, XrefRangeEnd = 1013930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override InvocationExpression Rewrite(Expression lambda, Il2CppReferenceArray<Expression> arguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression1.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvocationExpression>(intPtr3) : null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00003017 File Offset: 0x00001217
		public InvocationExpression1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x000284D4 File Offset: 0x000266D4
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00003020 File Offset: 0x00001220
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression1.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression1.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0;
	}
}
