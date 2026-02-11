using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000037 RID: 55
	public sealed class ScopeWithType : ScopeN
	{
		// Token: 0x06000340 RID: 832 RVA: 0x000203F4 File Offset: 0x0001E5F4
		// Note: this type is marked as 'beforefieldinit'.
		static ScopeWithType()
		{
			Il2CppClassPointerStore<ScopeWithType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ScopeWithType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopeWithType>.NativeClassPtr);
			ScopeWithType.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeWithType>.NativeClassPtr, "<Type>k__BackingField");
			ScopeWithType.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_IReadOnlyList_1_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeWithType>.NativeClassPtr, 100664114);
			ScopeWithType.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeWithType>.NativeClassPtr, 100664115);
			ScopeWithType.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeWithType>.NativeClassPtr, 100664116);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00020474 File Offset: 0x0001E674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012005, RefRangeEnd = 1012006, XrefRangeStart = 1012003, XrefRangeEnd = 1012005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScopeWithType(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopeWithType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expressions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeWithType.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_IReadOnlyList_1_Expression_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000204E4 File Offset: 0x0001E6E4
		public unsafe override Type Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeWithType.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00020524 File Offset: 0x0001E724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012006, XrefRangeEnd = 1012025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Il2CppReferenceArray<Expression> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeWithType.NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr3) : null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002B90 File Offset: 0x00000D90
		public ScopeWithType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00020588 File Offset: 0x0001E788
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00002B99 File Offset: 0x00000D99
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeWithType.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeWithType.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_IReadOnlyList_1_Expression_Type_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Virtual_BlockExpression_ReadOnlyCollection_1_ParameterExpression_Il2CppReferenceArray_1_Expression_0;
	}
}
