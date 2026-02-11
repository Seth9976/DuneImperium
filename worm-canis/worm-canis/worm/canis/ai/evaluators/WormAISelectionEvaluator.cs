using System;
using Canis.entities;
using Canis.entities.ai;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Networking.selection.targetinformation;
using worm.canis.ai.choices;

namespace worm.canis.ai.evaluators
{
	// Token: 0x0200021E RID: 542
	public class WormAISelectionEvaluator : AISelectionEvaluator
	{
		// Token: 0x060017D5 RID: 6101 RVA: 0x000B55F8 File Offset: 0x000B37F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormAISelectionEvaluator()
		{
			Il2CppClassPointerStore<WormAISelectionEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.evaluators", "WormAISelectionEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAISelectionEvaluator>.NativeClassPtr);
			WormAISelectionEvaluator.NativeMethodInfoPtr_GetBestTarget_Protected_WormAIChoice_Entity_Il2CppReferenceArray_1_TargetInformation_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAISelectionEvaluator>.NativeClassPtr, 100667325);
			WormAISelectionEvaluator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAISelectionEvaluator>.NativeClassPtr, 100667326);
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x000B5650 File Offset: 0x000B3850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129466, XrefRangeEnd = 129473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIChoice GetBestTarget(Entity first, Il2CppReferenceArray<TargetInformation> infos, WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(infos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAISelectionEvaluator.NativeMethodInfoPtr_GetBestTarget_Protected_WormAIChoice_Entity_Il2CppReferenceArray_1_TargetInformation_WormAIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x000B56C4 File Offset: 0x000B38C4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAISelectionEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAISelectionEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAISelectionEvaluator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x0000A627 File Offset: 0x00008827
		public WormAISelectionEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_GetBestTarget_Protected_WormAIChoice_Entity_Il2CppReferenceArray_1_TargetInformation_WormAIChoiceContext_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
