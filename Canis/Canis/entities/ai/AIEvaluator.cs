using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities.ai
{
	// Token: 0x02000102 RID: 258
	public class AIEvaluator : Object
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x0004A834 File Offset: 0x00048A34
		// Note: this type is marked as 'beforefieldinit'.
		static AIEvaluator()
		{
			Il2CppClassPointerStore<AIEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIEvaluator>.NativeClassPtr);
			AIEvaluator.NativeFieldInfoPtr_Evaluator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIEvaluator>.NativeClassPtr, "Evaluator");
			AIEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIEvaluator>.NativeClassPtr, 100665789);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0004A88C File Offset: 0x00048A8C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00006321 File Offset: 0x00004521
		public AIEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0004A8C8 File Offset: 0x00048AC8
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0000632A File Offset: 0x0000452A
		public unsafe AISelectionEvaluator Evaluator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIEvaluator.NativeFieldInfoPtr_Evaluator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AISelectionEvaluator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIEvaluator.NativeFieldInfoPtr_Evaluator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_Evaluator;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
