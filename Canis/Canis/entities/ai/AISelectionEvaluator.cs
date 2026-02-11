using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities.ai
{
	// Token: 0x02000103 RID: 259
	public class AISelectionEvaluator : Object
	{
		// Token: 0x06000B8C RID: 2956 RVA: 0x0004A8F8 File Offset: 0x00048AF8
		// Note: this type is marked as 'beforefieldinit'.
		static AISelectionEvaluator()
		{
			Il2CppClassPointerStore<AISelectionEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AISelectionEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AISelectionEvaluator>.NativeClassPtr);
			AISelectionEvaluator.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISelectionEvaluator>.NativeClassPtr, "AbilityID");
			AISelectionEvaluator.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISelectionEvaluator>.NativeClassPtr, "ability");
			AISelectionEvaluator.NativeMethodInfoPtr_GetAbility_Public_AbilityDefinition_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AISelectionEvaluator>.NativeClassPtr, 100665790);
			AISelectionEvaluator.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AISelectionEvaluator>.NativeClassPtr, 100665791);
			AISelectionEvaluator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AISelectionEvaluator>.NativeClassPtr, 100665792);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0004A98C File Offset: 0x00048B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570024, XrefRangeEnd = 570028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityDefinition GetAbility(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AISelectionEvaluator.NativeMethodInfoPtr_GetAbility_Public_AbilityDefinition_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0004A9DC File Offset: 0x00048BDC
		[CallerCount(0)]
		public unsafe virtual AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AISelectionEvaluator.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0004AA38 File Offset: 0x00048C38
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AISelectionEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AISelectionEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AISelectionEvaluator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00006349 File Offset: 0x00004549
		public AISelectionEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0004AA74 File Offset: 0x00048C74
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00006352 File Offset: 0x00004552
		public unsafe EntityID AbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AISelectionEvaluator.NativeFieldInfoPtr_AbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AISelectionEvaluator.NativeFieldInfoPtr_AbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0004AAA4 File Offset: 0x00048CA4
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00006371 File Offset: 0x00004571
		public unsafe AbilityDefinition ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AISelectionEvaluator.NativeFieldInfoPtr_ability);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AISelectionEvaluator.NativeFieldInfoPtr_ability), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr_ability;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_GetAbility_Public_AbilityDefinition_Match_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_AIChoice_AIChoiceContext_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
