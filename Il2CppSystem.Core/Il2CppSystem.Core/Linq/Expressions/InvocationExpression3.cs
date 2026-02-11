using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000053 RID: 83
	public sealed class InvocationExpression3 : InvocationExpression
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x0002877C File Offset: 0x0002697C
		// Note: this type is marked as 'beforefieldinit'.
		static InvocationExpression3()
		{
			Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "InvocationExpression3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr);
			InvocationExpression3.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr, "_arg0");
			InvocationExpression3.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr, "_arg1");
			InvocationExpression3.NativeFieldInfoPtr__arg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr, "_arg2");
			InvocationExpression3.NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr, 100664426);
			InvocationExpression3.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr, 100664427);
			InvocationExpression3.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr, 100664428);
			InvocationExpression3.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr, 100664429);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00028838 File Offset: 0x00026A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013952, RefRangeEnd = 1013953, XrefRangeStart = 1013948, XrefRangeEnd = 1013952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvocationExpression3(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvocationExpression3>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression3.NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000288D0 File Offset: 0x00026AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013953, XrefRangeEnd = 1013954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression3.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0002891C File Offset: 0x00026B1C
		public unsafe override int ArgumentCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression3.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00028958 File Offset: 0x00026B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013954, XrefRangeEnd = 1013961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression3.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvocationExpression>(intPtr3) : null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003086 File Offset: 0x00001286
		public InvocationExpression3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x000289BC File Offset: 0x00026BBC
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x0000308F File Offset: 0x0000128F
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression3.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression3.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x000289EC File Offset: 0x00026BEC
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x000030AE File Offset: 0x000012AE
		public unsafe Expression _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression3.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression3.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00028A1C File Offset: 0x00026C1C
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x000030CD File Offset: 0x000012CD
		public unsafe Expression _arg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression3.NativeFieldInfoPtr__arg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression3.NativeFieldInfoPtr__arg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr__arg2;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_Expression_Expression_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0;
	}
}
