using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.skirmishScripts
{
	// Token: 0x0200004D RID: 77
	public class SkirmishCollections : Object
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0002C1E8 File Offset: 0x0002A3E8
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishCollections()
		{
			Il2CppClassPointerStore<SkirmishCollections>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishCollections");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishCollections>.NativeClassPtr);
			SkirmishCollections.NativeMethodInfoPtr_get_AllRulesModifiers_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishCollections>.NativeClassPtr, 100664272);
			SkirmishCollections.NativeMethodInfoPtr_get_AllScoringMethods_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishCollections>.NativeClassPtr, 100664273);
			SkirmishCollections.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishCollections>.NativeClassPtr, 100664274);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0002C254 File Offset: 0x0002A454
		public unsafe virtual IReadOnlyList<SkirmishRulesModifier> AllRulesModifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishCollections.NativeMethodInfoPtr_get_AllRulesModifiers_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SkirmishRulesModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SkirmishRulesModifier>>(intPtr3) : null;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		public unsafe virtual IReadOnlyList<SkirmishScoringMethod> AllScoringMethods
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishCollections.NativeMethodInfoPtr_get_AllScoringMethods_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SkirmishScoringMethod_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SkirmishScoringMethod>>(intPtr3) : null;
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0002C2EC File Offset: 0x0002A4EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishCollections()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishCollections>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishCollections.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00004252 File Offset: 0x00002452
		public SkirmishCollections(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_get_AllRulesModifiers_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SkirmishRulesModifier_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_get_AllScoringMethods_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SkirmishScoringMethod_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
