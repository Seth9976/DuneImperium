using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000050 RID: 80
	public sealed class InvocationExpression0 : InvocationExpression
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x00028118 File Offset: 0x00026318
		// Note: this type is marked as 'beforefieldinit'.
		static InvocationExpression0()
		{
			Il2CppClassPointerStore<InvocationExpression0>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "InvocationExpression0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvocationExpression0>.NativeClassPtr);
			InvocationExpression0.NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression0>.NativeClassPtr, 100664414);
			InvocationExpression0.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression0>.NativeClassPtr, 100664415);
			InvocationExpression0.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression0>.NativeClassPtr, 100664416);
			InvocationExpression0.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression0>.NativeClassPtr, 100664417);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00028198 File Offset: 0x00026398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1013897, RefRangeEnd = 1013899, XrefRangeStart = 1013896, XrefRangeEnd = 1013897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvocationExpression0(Expression lambda, Type returnType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvocationExpression0>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression0.NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000281F8 File Offset: 0x000263F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013899, XrefRangeEnd = 1013905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression0.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00028244 File Offset: 0x00026444
		public unsafe override int ArgumentCount
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression0.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00028280 File Offset: 0x00026480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013905, XrefRangeEnd = 1013909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression0.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvocationExpression>(intPtr3) : null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000300E File Offset: 0x0000120E
		public InvocationExpression0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0;
	}
}
