using System;
using dwd.core.settings;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.dataRenderers
{
	// Token: 0x0200005A RID: 90
	public class FirstTimeReminderRenderer : MonoBehaviour
	{
		// Token: 0x06000370 RID: 880 RVA: 0x00028804 File Offset: 0x00026A04
		// Note: this type is marked as 'beforefieldinit'.
		static FirstTimeReminderRenderer()
		{
			Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.dataRenderers", "FirstTimeReminderRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr);
			FirstTimeReminderRenderer.NativeFieldInfoPtr_eventsForHasSeenFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr, "eventsForHasSeenFeature");
			FirstTimeReminderRenderer.NativeFieldInfoPtr_seenFeaturePrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr, "seenFeaturePrefKey");
			FirstTimeReminderRenderer.NativeFieldInfoPtr_hasSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr, "hasSetting");
			FirstTimeReminderRenderer.NativeFieldInfoPtr_setting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr, "setting");
			FirstTimeReminderRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr, 100663838);
			FirstTimeReminderRenderer.NativeMethodInfoPtr_Event_SeeFeature_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr, 100663839);
			FirstTimeReminderRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr, 100663840);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000288C0 File Offset: 0x00026AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499829, XrefRangeEnd = 499842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstTimeReminderRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000288F4 File Offset: 0x00026AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499842, XrefRangeEnd = 499848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SeeFeature()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstTimeReminderRenderer.NativeMethodInfoPtr_Event_SeeFeature_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00028928 File Offset: 0x00026B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499848, XrefRangeEnd = 499853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirstTimeReminderRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstTimeReminderRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstTimeReminderRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000037E0 File Offset: 0x000019E0
		public FirstTimeReminderRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00028964 File Offset: 0x00026B64
		// (set) Token: 0x06000376 RID: 886 RVA: 0x000037E9 File Offset: 0x000019E9
		public unsafe BoolUnityEvents eventsForHasSeenFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstTimeReminderRenderer.NativeFieldInfoPtr_eventsForHasSeenFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstTimeReminderRenderer.NativeFieldInfoPtr_eventsForHasSeenFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00028994 File Offset: 0x00026B94
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00003808 File Offset: 0x00001A08
		public unsafe string seenFeaturePrefKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstTimeReminderRenderer.NativeFieldInfoPtr_seenFeaturePrefKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstTimeReminderRenderer.NativeFieldInfoPtr_seenFeaturePrefKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000379 RID: 889 RVA: 0x000289BC File Offset: 0x00026BBC
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003827 File Offset: 0x00001A27
		public unsafe bool hasSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstTimeReminderRenderer.NativeFieldInfoPtr_hasSetting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstTimeReminderRenderer.NativeFieldInfoPtr_hasSetting)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600037B RID: 891 RVA: 0x000289E4 File Offset: 0x00026BE4
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003842 File Offset: 0x00001A42
		public unsafe IWritableSettingDefinition<bool> setting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstTimeReminderRenderer.NativeFieldInfoPtr_setting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWritableSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstTimeReminderRenderer.NativeFieldInfoPtr_setting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_eventsForHasSeenFeature;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_seenFeaturePrefKey;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr_hasSetting;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeFieldInfoPtr_setting;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_Event_SeeFeature_Public_Void_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
