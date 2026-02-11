using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000034 RID: 52
	public class ScopeExpression : BlockExpression
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0001FC48 File Offset: 0x0001DE48
		// Note: this type is marked as 'beforefieldinit'.
		static ScopeExpression()
		{
			Il2CppClassPointerStore<ScopeExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ScopeExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopeExpression>.NativeClassPtr);
			ScopeExpression.NativeFieldInfoPtr__variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeExpression>.NativeClassPtr, "_variables");
			ScopeExpression.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeExpression>.NativeClassPtr, 100664098);
			ScopeExpression.NativeMethodInfoPtr_GetOrMakeVariables_Internal_Virtual_ReadOnlyCollection_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeExpression>.NativeClassPtr, 100664099);
			ScopeExpression.NativeMethodInfoPtr_get_VariablesList_Protected_get_IReadOnlyList_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeExpression>.NativeClassPtr, 100664100);
			ScopeExpression.NativeMethodInfoPtr_ReuseOrValidateVariables_Internal_IReadOnlyList_1_ParameterExpression_ReadOnlyCollection_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeExpression>.NativeClassPtr, 100664101);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0001FCDC File Offset: 0x0001DEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScopeExpression(IReadOnlyList<ParameterExpression> variables)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopeExpression>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeExpression.NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0001FD28 File Offset: 0x0001DF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011943, XrefRangeEnd = 1011946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScopeExpression.NativeMethodInfoPtr_GetOrMakeVariables_Internal_Virtual_ReadOnlyCollection_1_ParameterExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ParameterExpression>>(intPtr3) : null;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0001FD74 File Offset: 0x0001DF74
		public unsafe IReadOnlyList<ParameterExpression> VariablesList
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeExpression.NativeMethodInfoPtr_get_VariablesList_Protected_get_IReadOnlyList_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ParameterExpression>>(intPtr3) : null;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0001FDB4 File Offset: 0x0001DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011946, XrefRangeEnd = 1011952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeExpression.NativeMethodInfoPtr_ReuseOrValidateVariables_Internal_IReadOnlyList_1_ParameterExpression_ReadOnlyCollection_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ParameterExpression>>(intPtr3) : null;
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002B18 File Offset: 0x00000D18
		public ScopeExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001FE04 File Offset: 0x0001E004
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00002B21 File Offset: 0x00000D21
		public unsafe IReadOnlyList<ParameterExpression> _variables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeExpression.NativeFieldInfoPtr__variables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ParameterExpression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeExpression.NativeFieldInfoPtr__variables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr__variables;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IReadOnlyList_1_ParameterExpression_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeVariables_Internal_Virtual_ReadOnlyCollection_1_ParameterExpression_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_get_VariablesList_Protected_get_IReadOnlyList_1_ParameterExpression_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_ReuseOrValidateVariables_Internal_IReadOnlyList_1_ParameterExpression_ReadOnlyCollection_1_ParameterExpression_0;
	}
}
