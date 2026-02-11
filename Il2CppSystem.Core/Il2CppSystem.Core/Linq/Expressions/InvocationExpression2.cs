using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000052 RID: 82
	public sealed class InvocationExpression2 : InvocationExpression
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x00028504 File Offset: 0x00026704
		// Note: this type is marked as 'beforefieldinit'.
		static InvocationExpression2()
		{
			Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "InvocationExpression2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr);
			InvocationExpression2.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr, "_arg0");
			InvocationExpression2.NativeFieldInfoPtr__arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr, "_arg1");
			InvocationExpression2.NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr, 100664422);
			InvocationExpression2.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr, 100664423);
			InvocationExpression2.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr, 100664424);
			InvocationExpression2.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr, 100664425);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000285AC File Offset: 0x000267AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1013933, RefRangeEnd = 1013934, XrefRangeStart = 1013930, XrefRangeEnd = 1013933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvocationExpression2(Expression lambda, Type returnType, Expression arg0, Expression arg1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvocationExpression2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression2.NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00028630 File Offset: 0x00026830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013934, XrefRangeEnd = 1013937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression2.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0002867C File Offset: 0x0002687C
		public unsafe override int ArgumentCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression2.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000286B8 File Offset: 0x000268B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013937, XrefRangeEnd = 1013948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpression2.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvocationExpression>(intPtr3) : null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000303F File Offset: 0x0000123F
		public InvocationExpression2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0002871C File Offset: 0x0002691C
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00003048 File Offset: 0x00001248
		public unsafe Object _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression2.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression2.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0002874C File Offset: 0x0002694C
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00003067 File Offset: 0x00001267
		public unsafe Expression _arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression2.NativeFieldInfoPtr__arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpression2.NativeFieldInfoPtr__arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr__arg1;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_Type_Expression_Expression_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0;
	}
}
