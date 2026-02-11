using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.datarenderers
{
	// Token: 0x0200016D RID: 365
	public class DailyChallengeBadgeRankTextRenderer : Subscriber<DailyChallengeBadgeData>
	{
		// Token: 0x0600103E RID: 4158 RVA: 0x00050E78 File Offset: 0x0004F078
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeBadgeRankTextRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeBadgeRankTextRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "DailyChallengeBadgeRankTextRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeBadgeRankTextRenderer>.NativeClassPtr);
			DailyChallengeBadgeRankTextRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeRankTextRenderer>.NativeClassPtr, "text");
			DailyChallengeBadgeRankTextRenderer.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeRankTextRenderer>.NativeClassPtr, "key");
			DailyChallengeBadgeRankTextRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeBadgeRankTextRenderer>.NativeClassPtr, 100665578);
			DailyChallengeBadgeRankTextRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeBadgeRankTextRenderer>.NativeClassPtr, 100665579);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513883, XrefRangeEnd = 513896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeBadgeRankTextRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00050F34 File Offset: 0x0004F134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513896, XrefRangeEnd = 513902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeBadgeRankTextRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeBadgeRankTextRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeBadgeRankTextRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00009DF5 File Offset: 0x00007FF5
		public DailyChallengeBadgeRankTextRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00050F70 File Offset: 0x0004F170
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00009DFE File Offset: 0x00007FFE
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeRankTextRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeRankTextRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x00050FA0 File Offset: 0x0004F1A0
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x00009E1D File Offset: 0x0000801D
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeRankTextRenderer.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeRankTextRenderer.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
