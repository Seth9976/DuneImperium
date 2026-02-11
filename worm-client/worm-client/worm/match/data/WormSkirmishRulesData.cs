using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x0200019F RID: 415
	public class WormSkirmishRulesData : DataComponent
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x00050094 File Offset: 0x0004E294
		// Note: this type is marked as 'beforefieldinit'.
		static WormSkirmishRulesData()
		{
			Il2CppClassPointerStore<WormSkirmishRulesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormSkirmishRulesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishRulesData>.NativeClassPtr);
			WormSkirmishRulesData.NativeFieldInfoPtr_SkirmishRuleMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesData>.NativeClassPtr, "SkirmishRuleMods");
			WormSkirmishRulesData.NativeFieldInfoPtr_ScoringMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesData>.NativeClassPtr, "ScoringMethods");
			WormSkirmishRulesData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishRulesData>.NativeClassPtr, 100665817);
			WormSkirmishRulesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishRulesData>.NativeClassPtr, 100665818);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00050114 File Offset: 0x0004E314
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 712139, RefRangeEnd = 712142, XrefRangeStart = 712130, XrefRangeEnd = 712139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSkirmishRulesData(IReadOnlyList<int> skirmishRuleMods, IReadOnlyList<int> scoringMethods)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishRulesData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skirmishRuleMods);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scoringMethods);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishRulesData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00050174 File Offset: 0x0004E374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712142, XrefRangeEnd = 712153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSkirmishRulesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0000B9A3 File Offset: 0x00009BA3
		public WormSkirmishRulesData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x000501B8 File Offset: 0x0004E3B8
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x0000B9AC File Offset: 0x00009BAC
		public unsafe IReadOnlyList<int> SkirmishRuleMods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesData.NativeFieldInfoPtr_SkirmishRuleMods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesData.NativeFieldInfoPtr_SkirmishRuleMods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x000501E8 File Offset: 0x0004E3E8
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x0000B9CB File Offset: 0x00009BCB
		public unsafe IReadOnlyList<int> ScoringMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesData.NativeFieldInfoPtr_ScoringMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesData.NativeFieldInfoPtr_ScoringMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishRuleMods;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr_ScoringMethods;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
