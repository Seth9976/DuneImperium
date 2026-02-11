using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Canis.entities.ai
{
	// Token: 0x020000F7 RID: 247
	public class AbilityMethodEvaluator : AISelectionEvaluator
	{
		// Token: 0x06000ADE RID: 2782 RVA: 0x00047DF0 File Offset: 0x00045FF0
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityMethodEvaluator()
		{
			Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AbilityMethodEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr);
			AbilityMethodEvaluator.NativeFieldInfoPtr_DelegateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr, "DelegateType");
			AbilityMethodEvaluator.NativeFieldInfoPtr_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr, "MethodName");
			AbilityMethodEvaluator.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr, "ability");
			AbilityMethodEvaluator.NativeFieldInfoPtr_delegateInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr, "delegateInfo");
			AbilityMethodEvaluator.NativeMethodInfoPtr__ctor_Public_Void_AIEvaluateSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr, 100665668);
			AbilityMethodEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr, 100665669);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00047E98 File Offset: 0x00046098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 567948, RefRangeEnd = 567950, XrefRangeStart = 567938, XrefRangeEnd = 567948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityMethodEvaluator(AIEvaluateSelection evaluator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityMethodEvaluator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityMethodEvaluator.NativeMethodInfoPtr__ctor_Public_Void_AIEvaluateSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00047EE4 File Offset: 0x000460E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567950, XrefRangeEnd = 567985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityMethodEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00005F26 File Offset: 0x00004126
		public AbilityMethodEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00047F40 File Offset: 0x00046140
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00005F2F File Offset: 0x0000412F
		public unsafe string DelegateType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMethodEvaluator.NativeFieldInfoPtr_DelegateType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMethodEvaluator.NativeFieldInfoPtr_DelegateType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00047F68 File Offset: 0x00046168
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00005F4E File Offset: 0x0000414E
		public unsafe string MethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMethodEvaluator.NativeFieldInfoPtr_MethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMethodEvaluator.NativeFieldInfoPtr_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00047F90 File Offset: 0x00046190
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00005F6D File Offset: 0x0000416D
		public new unsafe AbilityDefinition ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMethodEvaluator.NativeFieldInfoPtr_ability);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMethodEvaluator.NativeFieldInfoPtr_ability), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00047FC0 File Offset: 0x000461C0
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00005F8C File Offset: 0x0000418C
		public unsafe MethodInfo delegateInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMethodEvaluator.NativeFieldInfoPtr_delegateInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityMethodEvaluator.NativeFieldInfoPtr_delegateInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr_DelegateType;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr_MethodName;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr_ability;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr_delegateInfo;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIEvaluateSelection_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0;
	}
}
