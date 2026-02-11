using System;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.match.dataRenderers
{
	// Token: 0x02000133 RID: 307
	public class WormHagalRulesSubscriber : VersionedSubscriber<SelectedData<string>>
	{
		// Token: 0x06000DCE RID: 3534 RVA: 0x00041CA0 File Offset: 0x0003FEA0
		// Note: this type is marked as 'beforefieldinit'.
		static WormHagalRulesSubscriber()
		{
			Il2CppClassPointerStore<WormHagalRulesSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHagalRulesSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHagalRulesSubscriber>.NativeClassPtr);
			WormHagalRulesSubscriber.NativeFieldInfoPtr_ruleLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalRulesSubscriber>.NativeClassPtr, "ruleLocKey");
			WormHagalRulesSubscriber.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalRulesSubscriber>.NativeClassPtr, "text");
			WormHagalRulesSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalRulesSubscriber>.NativeClassPtr, 100665163);
			WormHagalRulesSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalRulesSubscriber>.NativeClassPtr, 100665164);
			WormHagalRulesSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalRulesSubscriber>.NativeClassPtr, 100665165);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00041D34 File Offset: 0x0003FF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705944, XrefRangeEnd = 705948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHagalRulesSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00041D70 File Offset: 0x0003FF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705948, XrefRangeEnd = 705956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHagalRulesSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00041DAC File Offset: 0x0003FFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705956, XrefRangeEnd = 705962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHagalRulesSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHagalRulesSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalRulesSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00009472 File Offset: 0x00007672
		public WormHagalRulesSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00041DE8 File Offset: 0x0003FFE8
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x0000947B File Offset: 0x0000767B
		public unsafe string ruleLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalRulesSubscriber.NativeFieldInfoPtr_ruleLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalRulesSubscriber.NativeFieldInfoPtr_ruleLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00041E10 File Offset: 0x00040010
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x0000949A File Offset: 0x0000769A
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalRulesSubscriber.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalRulesSubscriber.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_ruleLocKey;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
