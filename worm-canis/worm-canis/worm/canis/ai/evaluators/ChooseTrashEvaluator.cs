using System;
using Canis.entities.ai;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.ai.evaluators
{
	// Token: 0x0200021A RID: 538
	public class ChooseTrashEvaluator : WormAISelectionEvaluator
	{
		// Token: 0x060017BE RID: 6078 RVA: 0x000B5024 File Offset: 0x000B3224
		// Note: this type is marked as 'beforefieldinit'.
		static ChooseTrashEvaluator()
		{
			Il2CppClassPointerStore<ChooseTrashEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.evaluators", "ChooseTrashEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseTrashEvaluator>.NativeClassPtr);
			ChooseTrashEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseTrashEvaluator>.NativeClassPtr, 100667305);
			ChooseTrashEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseTrashEvaluator>.NativeClassPtr, 100667306);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x000B507C File Offset: 0x000B327C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129130, XrefRangeEnd = 129155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChooseTrashEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000B50D8 File Offset: 0x000B32D8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChooseTrashEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseTrashEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseTrashEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0000A5C5 File Offset: 0x000087C5
		public ChooseTrashEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
