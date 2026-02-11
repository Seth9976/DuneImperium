using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000082 RID: 130
	public sealed class RuntimeVariablesExpression : Expression
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0002EF48 File Offset: 0x0002D148
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeVariablesExpression()
		{
			Il2CppClassPointerStore<RuntimeVariablesExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "RuntimeVariablesExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeVariablesExpression>.NativeClassPtr);
			RuntimeVariablesExpression.NativeFieldInfoPtr__Variables_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeVariablesExpression>.NativeClassPtr, "<Variables>k__BackingField");
			RuntimeVariablesExpression.NativeMethodInfoPtr_get_Variables_Public_get_ReadOnlyCollection_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeVariablesExpression>.NativeClassPtr, 100664613);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0002EFA0 File Offset: 0x0002D1A0
		public unsafe ReadOnlyCollection<ParameterExpression> Variables
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeVariablesExpression.NativeMethodInfoPtr_get_Variables_Public_get_ReadOnlyCollection_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ParameterExpression>>(intPtr3) : null;
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public RuntimeVariablesExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00003ADD File Offset: 0x00001CDD
		public unsafe ReadOnlyCollection<ParameterExpression> _Variables_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeVariablesExpression.NativeFieldInfoPtr__Variables_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ParameterExpression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeVariablesExpression.NativeFieldInfoPtr__Variables_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr__Variables_k__BackingField;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_get_Variables_Public_get_ReadOnlyCollection_1_ParameterExpression_0;
	}
}
