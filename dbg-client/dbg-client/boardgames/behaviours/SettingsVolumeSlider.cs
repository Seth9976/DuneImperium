using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.UI;
using zen.analytics;

namespace boardgames.behaviours
{
	// Token: 0x020002AF RID: 687
	public class SettingsVolumeSlider : VersionedView<AudioPreferencesModel>
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x00089E28 File Offset: 0x00088028
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsVolumeSlider()
		{
			Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "SettingsVolumeSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr);
			SettingsVolumeSlider.NativeFieldInfoPtr_audioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, "audioType");
			SettingsVolumeSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, "slider");
			SettingsVolumeSlider.NativeFieldInfoPtr_muteToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, "muteToggle");
			SettingsVolumeSlider.NativeFieldInfoPtr_analyticsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, "analyticsManager");
			SettingsVolumeSlider.NativeFieldInfoPtr_volumeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, "volumeChanged");
			SettingsVolumeSlider.NativeFieldInfoPtr_sliderInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, "sliderInitialized");
			SettingsVolumeSlider.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, 100668701);
			SettingsVolumeSlider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, 100668702);
			SettingsVolumeSlider.NativeMethodInfoPtr_InitSlider_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, 100668703);
			SettingsVolumeSlider.NativeMethodInfoPtr_Event_VolumeChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, 100668704);
			SettingsVolumeSlider.NativeMethodInfoPtr_Event_MutedChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, 100668705);
			SettingsVolumeSlider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, 100668706);
			SettingsVolumeSlider.NativeMethodInfoPtr_logAnalyticsMessage_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, 100668707);
			SettingsVolumeSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, 100668708);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00089F70 File Offset: 0x00088170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542535, XrefRangeEnd = 542557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsVolumeSlider.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00089FAC File Offset: 0x000881AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542557, XrefRangeEnd = 542560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsVolumeSlider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00089FE8 File Offset: 0x000881E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542560, XrefRangeEnd = 542565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InitSlider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider.NativeMethodInfoPtr_InitSlider_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0008A028 File Offset: 0x00088228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542565, XrefRangeEnd = 542568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_VolumeChanged(float newVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVolume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider.NativeMethodInfoPtr_Event_VolumeChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x0008A068 File Offset: 0x00088268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542568, XrefRangeEnd = 542581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_MutedChanged(bool mute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mute;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider.NativeMethodInfoPtr_Event_MutedChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x0008A0A8 File Offset: 0x000882A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542581, XrefRangeEnd = 542600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x0008A0DC File Offset: 0x000882DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 542619, RefRangeEnd = 542621, XrefRangeStart = 542600, XrefRangeEnd = 542619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void logAnalyticsMessage(string optionName, string valueName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider.NativeMethodInfoPtr_logAnalyticsMessage_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x0008A130 File Offset: 0x00088330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542621, XrefRangeEnd = 542624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsVolumeSlider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00011075 File Offset: 0x0000F275
		public SettingsVolumeSlider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0008A16C File Offset: 0x0008836C
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0001107E File Offset: 0x0000F27E
		public unsafe AudioType audioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_audioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_audioType)) = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0008A194 File Offset: 0x00088394
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x00011099 File Offset: 0x0000F299
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0008A1C4 File Offset: 0x000883C4
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x000110B8 File Offset: 0x0000F2B8
		public unsafe Toggle muteToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_muteToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_muteToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0008A1F4 File Offset: 0x000883F4
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x000110D7 File Offset: 0x0000F2D7
		public unsafe AnalyticsManager analyticsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_analyticsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_analyticsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0008A224 File Offset: 0x00088424
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x000110F6 File Offset: 0x0000F2F6
		public unsafe bool volumeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_volumeChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_volumeChanged)) = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0008A24C File Offset: 0x0008844C
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x00011111 File Offset: 0x0000F311
		public unsafe bool sliderInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_sliderInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider.NativeFieldInfoPtr_sliderInitialized)) = value;
			}
		}

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeFieldInfoPtr_audioType;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeFieldInfoPtr_muteToggle;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeFieldInfoPtr_analyticsManager;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeFieldInfoPtr_volumeChanged;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeFieldInfoPtr_sliderInitialized;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_InitSlider_Private_IEnumerator_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_Event_VolumeChanged_Private_Void_Single_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_Event_MutedChanged_Private_Void_Boolean_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_logAnalyticsMessage_Private_Void_String_String_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004A5 RID: 1189
		[ObfuscatedName("boardgames.behaviours.SettingsVolumeSlider+<InitSlider>d__8")]
		public sealed class _InitSlider_d__8 : Object
		{
			// Token: 0x06003860 RID: 14432 RVA: 0x000D0D6C File Offset: 0x000CEF6C
			// Note: this type is marked as 'beforefieldinit'.
			static _InitSlider_d__8()
			{
				Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsVolumeSlider>.NativeClassPtr, "<InitSlider>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr);
				SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, "<>1__state");
				SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, "<>2__current");
				SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, "<>4__this");
				SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, 100668709);
				SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, 100668710);
				SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, 100668711);
				SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, 100668712);
				SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, 100668713);
				SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr, 100668714);
			}

			// Token: 0x06003861 RID: 14433 RVA: 0x000D0E4C File Offset: 0x000CF04C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InitSlider_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsVolumeSlider._InitSlider_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003862 RID: 14434 RVA: 0x000D0E94 File Offset: 0x000CF094
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003863 RID: 14435 RVA: 0x000D0EC8 File Offset: 0x000CF0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542527, XrefRangeEnd = 542530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010AC RID: 4268
			// (get) Token: 0x06003864 RID: 14436 RVA: 0x000D0F04 File Offset: 0x000CF104
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003865 RID: 14437 RVA: 0x000D0F44 File Offset: 0x000CF144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542530, XrefRangeEnd = 542535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010AD RID: 4269
			// (get) Token: 0x06003866 RID: 14438 RVA: 0x000D0F78 File Offset: 0x000CF178
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsVolumeSlider._InitSlider_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003867 RID: 14439 RVA: 0x0001D01A File Offset: 0x0001B21A
			public _InitSlider_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010A9 RID: 4265
			// (get) Token: 0x06003868 RID: 14440 RVA: 0x000D0FB8 File Offset: 0x000CF1B8
			// (set) Token: 0x06003869 RID: 14441 RVA: 0x0001D023 File Offset: 0x0001B223
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010AA RID: 4266
			// (get) Token: 0x0600386A RID: 14442 RVA: 0x000D0FE0 File Offset: 0x000CF1E0
			// (set) Token: 0x0600386B RID: 14443 RVA: 0x0001D03E File Offset: 0x0001B23E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AB RID: 4267
			// (get) Token: 0x0600386C RID: 14444 RVA: 0x000D1010 File Offset: 0x000CF210
			// (set) Token: 0x0600386D RID: 14445 RVA: 0x0001D05D File Offset: 0x0001B25D
			public unsafe SettingsVolumeSlider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsVolumeSlider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsVolumeSlider._InitSlider_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022A5 RID: 8869
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022A6 RID: 8870
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040022A7 RID: 8871
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022A8 RID: 8872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040022A9 RID: 8873
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022AA RID: 8874
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040022AB RID: 8875
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040022AC RID: 8876
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022AD RID: 8877
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
