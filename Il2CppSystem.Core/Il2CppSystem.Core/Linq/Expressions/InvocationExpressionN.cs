using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200004F RID: 79
	public sealed class InvocationExpressionN : InvocationExpression
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x00027EF8 File Offset: 0x000260F8
		// Note: this type is marked as 'beforefieldinit'.
		static InvocationExpressionN()
		{
			Il2CppClassPointerStore<InvocationExpressionN>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "InvocationExpressionN");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvocationExpressionN>.NativeClassPtr);
			InvocationExpressionN.NativeFieldInfoPtr__arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvocationExpressionN>.NativeClassPtr, "_arguments");
			InvocationExpressionN.NativeMethodInfoPtr__ctor_Public_Void_Expression_IReadOnlyList_1_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpressionN>.NativeClassPtr, 100664410);
			InvocationExpressionN.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpressionN>.NativeClassPtr, 100664411);
			InvocationExpressionN.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpressionN>.NativeClassPtr, 100664412);
			InvocationExpressionN.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvocationExpressionN>.NativeClassPtr, 100664413);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00027F8C File Offset: 0x0002618C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013882, XrefRangeEnd = 1013884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvocationExpressionN(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvocationExpressionN>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpressionN.NativeMethodInfoPtr__ctor_Public_Void_Expression_IReadOnlyList_1_Expression_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00027FFC File Offset: 0x000261FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013884, XrefRangeEnd = 1013888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpressionN.NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00028048 File Offset: 0x00026248
		public unsafe override int ArgumentCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013888, XrefRangeEnd = 1013892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpressionN.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00028084 File Offset: 0x00026284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013892, XrefRangeEnd = 1013896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvocationExpressionN.NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvocationExpression>(intPtr3) : null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002FE6 File Offset: 0x000011E6
		public InvocationExpressionN(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x000280E8 File Offset: 0x000262E8
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00002FEF File Offset: 0x000011EF
		public unsafe IReadOnlyList<Expression> _arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpressionN.NativeFieldInfoPtr__arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvocationExpressionN.NativeFieldInfoPtr__arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr__arguments;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_IReadOnlyList_1_Expression_Type_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Expression_Int32_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_InvocationExpression_Expression_Il2CppReferenceArray_1_Expression_0;
	}
}
