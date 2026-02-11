using System;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x0200014C RID: 332
	public class AutoUpdateCheck : MonoBehaviour
	{
		// Token: 0x060010F7 RID: 4343 RVA: 0x00045428 File Offset: 0x00043628
		// Note: this type is marked as 'beforefieldinit'.
		static AutoUpdateCheck()
		{
			Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menus", "AutoUpdateCheck");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr);
			AutoUpdateCheck.NativeFieldInfoPtr_PlatformAndroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "PlatformAndroid");
			AutoUpdateCheck.NativeFieldInfoPtr_PlatformIos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "PlatformIos");
			AutoUpdateCheck.NativeFieldInfoPtr_PlatformSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "PlatformSwitch");
			AutoUpdateCheck.NativeFieldInfoPtr_PlatformSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "PlatformSteam");
			AutoUpdateCheck.NativeFieldInfoPtr_PlatformGameCoreXboxSeries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "PlatformGameCoreXboxSeries");
			AutoUpdateCheck.NativeFieldInfoPtr_PlatformGameCoreXboxOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "PlatformGameCoreXboxOne");
			AutoUpdateCheck.NativeFieldInfoPtr_confirmKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "confirmKey");
			AutoUpdateCheck.NativeFieldInfoPtr_cancelKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "cancelKey");
			AutoUpdateCheck.NativeFieldInfoPtr_platformMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "platformMap");
			AutoUpdateCheck.NativeFieldInfoPtr_upgradeVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "upgradeVersion");
			AutoUpdateCheck.NativeFieldInfoPtr_currentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "currentVersion");
			AutoUpdateCheck.NativeFieldInfoPtr_editorTestingPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "editorTestingPlatform");
			AutoUpdateCheck.NativeFieldInfoPtr_platformString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "platformString");
			AutoUpdateCheck.NativeMethodInfoPtr_shouldUpgrade_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, 100665783);
			AutoUpdateCheck.NativeMethodInfoPtr_autoUpdateCheck_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, 100665784);
			AutoUpdateCheck.NativeMethodInfoPtr_DoUpgrade_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, 100665785);
			AutoUpdateCheck.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, 100665786);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000455AC File Offset: 0x000437AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999777, XrefRangeEnd = 999780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool shouldUpgrade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck.NativeMethodInfoPtr_shouldUpgrade_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x000455E8 File Offset: 0x000437E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999780, XrefRangeEnd = 999785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator autoUpdateCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck.NativeMethodInfoPtr_autoUpdateCheck_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00045628 File Offset: 0x00043828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999785, XrefRangeEnd = 999790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoUpgrade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck.NativeMethodInfoPtr_DoUpgrade_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00045668 File Offset: 0x00043868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999790, XrefRangeEnd = 999803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoUpdateCheck()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00009E0C File Offset: 0x0000800C
		public AutoUpdateCheck(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x000456A4 File Offset: 0x000438A4
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x00009E15 File Offset: 0x00008015
		public unsafe static string PlatformAndroid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformAndroid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformAndroid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x000456C4 File Offset: 0x000438C4
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x00009E27 File Offset: 0x00008027
		public unsafe static string PlatformIos
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformIos, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformIos, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x000456E4 File Offset: 0x000438E4
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x00009E39 File Offset: 0x00008039
		public unsafe static string PlatformSwitch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformSwitch, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformSwitch, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x00045704 File Offset: 0x00043904
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x00009E4B File Offset: 0x0000804B
		public unsafe static string PlatformSteam
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformSteam, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformSteam, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00045724 File Offset: 0x00043924
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x00009E5D File Offset: 0x0000805D
		public unsafe static string PlatformGameCoreXboxSeries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformGameCoreXboxSeries, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformGameCoreXboxSeries, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00045744 File Offset: 0x00043944
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x00009E6F File Offset: 0x0000806F
		public unsafe static string PlatformGameCoreXboxOne
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformGameCoreXboxOne, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoUpdateCheck.NativeFieldInfoPtr_PlatformGameCoreXboxOne, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00045764 File Offset: 0x00043964
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00009E81 File Offset: 0x00008081
		public unsafe string confirmKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_confirmKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_confirmKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0004578C File Offset: 0x0004398C
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00009EA0 File Offset: 0x000080A0
		public unsafe string cancelKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_cancelKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_cancelKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000457B4 File Offset: 0x000439B4
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x00009EBF File Offset: 0x000080BF
		public unsafe static Dictionary<RuntimePlatform, string> platformMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AutoUpdateCheck.NativeFieldInfoPtr_platformMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RuntimePlatform, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoUpdateCheck.NativeFieldInfoPtr_platformMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000457DC File Offset: 0x000439DC
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00009ED1 File Offset: 0x000080D1
		public unsafe AutoUpdateCheck.UpdateVersionInfo upgradeVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_upgradeVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoUpdateCheck.UpdateVersionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_upgradeVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0004580C File Offset: 0x00043A0C
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x00009EF0 File Offset: 0x000080F0
		public unsafe AutoUpdateCheck.UpdateVersionInfo currentVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_currentVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoUpdateCheck.UpdateVersionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_currentVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x0004583C File Offset: 0x00043A3C
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x00009F0F File Offset: 0x0000810F
		public unsafe string editorTestingPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_editorTestingPlatform);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_editorTestingPlatform), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x00045864 File Offset: 0x00043A64
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x00009F2E File Offset: 0x0000812E
		public unsafe string platformString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_platformString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.NativeFieldInfoPtr_platformString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_PlatformAndroid;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_PlatformIos;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeFieldInfoPtr_PlatformSwitch;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeFieldInfoPtr_PlatformSteam;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeFieldInfoPtr_PlatformGameCoreXboxSeries;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeFieldInfoPtr_PlatformGameCoreXboxOne;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeFieldInfoPtr_confirmKey;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeFieldInfoPtr_cancelKey;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeFieldInfoPtr_platformMap;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_upgradeVersion;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeFieldInfoPtr_currentVersion;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeFieldInfoPtr_editorTestingPlatform;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_platformString;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_shouldUpgrade_Public_Boolean_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_autoUpdateCheck_Public_IEnumerator_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_DoUpgrade_Public_IEnumerator_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000278 RID: 632
		public class UpdateVersionInfo : global::Il2CppSystem.Object
		{
			// Token: 0x06001D11 RID: 7441 RVA: 0x0006AC00 File Offset: 0x00068E00
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateVersionInfo()
			{
				Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "UpdateVersionInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr);
				AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_majorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, "majorVersion");
				AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_minorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, "minorVersion");
				AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_hotfixVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, "hotfixVersion");
				AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_upgradeURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, "upgradeURL");
				AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_forceClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, "forceClose");
				AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr_FromString_Public_Static_UpdateVersionInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, 100665788);
				AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr_compareVersion_Public_UpdateVersionInfo_UpdateVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, 100665789);
				AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, 100665790);
				AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr_ToVersionString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, 100665791);
				AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr, 100665792);
			}

			// Token: 0x06001D12 RID: 7442 RVA: 0x0006ACF4 File Offset: 0x00068EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999618, XrefRangeEnd = 999626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static AutoUpdateCheck.UpdateVersionInfo FromString(string inputStr)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(inputStr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr_FromString_Public_Static_UpdateVersionInfo_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoUpdateCheck.UpdateVersionInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06001D13 RID: 7443 RVA: 0x0006AD38 File Offset: 0x00068F38
			[CallerCount(0)]
			public unsafe AutoUpdateCheck.UpdateVersionInfo compareVersion(AutoUpdateCheck.UpdateVersionInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr_compareVersion_Public_UpdateVersionInfo_UpdateVersionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoUpdateCheck.UpdateVersionInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06001D14 RID: 7444 RVA: 0x0006AD88 File Offset: 0x00068F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999626, XrefRangeEnd = 999654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001D15 RID: 7445 RVA: 0x0006ADCC File Offset: 0x00068FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999654, XrefRangeEnd = 999671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ToVersionString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr_ToVersionString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x0006AE04 File Offset: 0x00069004
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateVersionInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoUpdateCheck.UpdateVersionInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck.UpdateVersionInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D17 RID: 7447 RVA: 0x0000FA34 File Offset: 0x0000DC34
			public UpdateVersionInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06001D18 RID: 7448 RVA: 0x0006AE40 File Offset: 0x00069040
			// (set) Token: 0x06001D19 RID: 7449 RVA: 0x0000FA3D File Offset: 0x0000DC3D
			public unsafe int majorVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_majorVersion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_majorVersion)) = value;
				}
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0006AE68 File Offset: 0x00069068
			// (set) Token: 0x06001D1B RID: 7451 RVA: 0x0000FA58 File Offset: 0x0000DC58
			public unsafe int minorVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_minorVersion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_minorVersion)) = value;
				}
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06001D1C RID: 7452 RVA: 0x0006AE90 File Offset: 0x00069090
			// (set) Token: 0x06001D1D RID: 7453 RVA: 0x0000FA73 File Offset: 0x0000DC73
			public unsafe int hotfixVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_hotfixVersion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_hotfixVersion)) = value;
				}
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06001D1E RID: 7454 RVA: 0x0006AEB8 File Offset: 0x000690B8
			// (set) Token: 0x06001D1F RID: 7455 RVA: 0x0000FA8E File Offset: 0x0000DC8E
			public unsafe string upgradeURL
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_upgradeURL);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_upgradeURL), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0006AEE0 File Offset: 0x000690E0
			// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0000FAAD File Offset: 0x0000DCAD
			public unsafe bool forceClose
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_forceClose);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck.UpdateVersionInfo.NativeFieldInfoPtr_forceClose)) = value;
				}
			}

			// Token: 0x040011B0 RID: 4528
			private static readonly IntPtr NativeFieldInfoPtr_majorVersion;

			// Token: 0x040011B1 RID: 4529
			private static readonly IntPtr NativeFieldInfoPtr_minorVersion;

			// Token: 0x040011B2 RID: 4530
			private static readonly IntPtr NativeFieldInfoPtr_hotfixVersion;

			// Token: 0x040011B3 RID: 4531
			private static readonly IntPtr NativeFieldInfoPtr_upgradeURL;

			// Token: 0x040011B4 RID: 4532
			private static readonly IntPtr NativeFieldInfoPtr_forceClose;

			// Token: 0x040011B5 RID: 4533
			private static readonly IntPtr NativeMethodInfoPtr_FromString_Public_Static_UpdateVersionInfo_String_0;

			// Token: 0x040011B6 RID: 4534
			private static readonly IntPtr NativeMethodInfoPtr_compareVersion_Public_UpdateVersionInfo_UpdateVersionInfo_0;

			// Token: 0x040011B7 RID: 4535
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040011B8 RID: 4536
			private static readonly IntPtr NativeMethodInfoPtr_ToVersionString_Public_String_0;

			// Token: 0x040011B9 RID: 4537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000279 RID: 633
		[ObfuscatedName("boardgames.menus.AutoUpdateCheck+<DoUpgrade>d__16")]
		public sealed class _DoUpgrade_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x06001D22 RID: 7458 RVA: 0x0006AF08 File Offset: 0x00069108
			// Note: this type is marked as 'beforefieldinit'.
			static _DoUpgrade_d__16()
			{
				Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "<DoUpgrade>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr);
				AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, "<>1__state");
				AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, "<>2__current");
				AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, "<>4__this");
				AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr__dialog_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, "<dialog>5__2");
				AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, 100665793);
				AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, 100665794);
				AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, 100665795);
				AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, 100665796);
				AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, 100665797);
				AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr, 100665798);
			}

			// Token: 0x06001D23 RID: 7459 RVA: 0x0006AFFC File Offset: 0x000691FC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoUpgrade_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoUpdateCheck._DoUpgrade_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D24 RID: 7460 RVA: 0x0006B044 File Offset: 0x00069244
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D25 RID: 7461 RVA: 0x0006B078 File Offset: 0x00069278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999671, XrefRangeEnd = 999688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0006B0B4 File Offset: 0x000692B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D27 RID: 7463 RVA: 0x0006B0F4 File Offset: 0x000692F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999688, XrefRangeEnd = 999693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0006B128 File Offset: 0x00069328
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._DoUpgrade_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D29 RID: 7465 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
			public _DoUpgrade_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0006B168 File Offset: 0x00069368
			// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0000FAD1 File Offset: 0x0000DCD1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0006B190 File Offset: 0x00069390
			// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0000FAEC File Offset: 0x0000DCEC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0006B1C0 File Offset: 0x000693C0
			// (set) Token: 0x06001D2F RID: 7471 RVA: 0x0000FB0B File Offset: 0x0000DD0B
			public unsafe AutoUpdateCheck __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoUpdateCheck>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0006B1F0 File Offset: 0x000693F0
			// (set) Token: 0x06001D31 RID: 7473 RVA: 0x0000FB2A File Offset: 0x0000DD2A
			public unsafe ConfirmOrCancelDialog _dialog_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr__dialog_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrCancelDialog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._DoUpgrade_d__16.NativeFieldInfoPtr__dialog_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011BA RID: 4538
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011BB RID: 4539
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011BC RID: 4540
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011BD RID: 4541
			private static readonly IntPtr NativeFieldInfoPtr__dialog_5__2;

			// Token: 0x040011BE RID: 4542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011BF RID: 4543
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011C0 RID: 4544
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011C1 RID: 4545
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011C2 RID: 4546
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011C3 RID: 4547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200027A RID: 634
		[ObfuscatedName("boardgames.menus.AutoUpdateCheck+<autoUpdateCheck>d__15")]
		public sealed class _autoUpdateCheck_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06001D32 RID: 7474 RVA: 0x0006B220 File Offset: 0x00069420
			// Note: this type is marked as 'beforefieldinit'.
			static _autoUpdateCheck_d__15()
			{
				Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AutoUpdateCheck>.NativeClassPtr, "<autoUpdateCheck>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr);
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, "<>1__state");
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, "<>2__current");
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, "<>4__this");
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr__url_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, "<url>5__2");
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr__www_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, "<www>5__3");
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, 100665799);
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, 100665800);
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, 100665801);
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, 100665802);
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, 100665803);
				AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr, 100665804);
			}

			// Token: 0x06001D33 RID: 7475 RVA: 0x0006B328 File Offset: 0x00069528
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _autoUpdateCheck_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoUpdateCheck._autoUpdateCheck_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x0006B370 File Offset: 0x00069570
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D35 RID: 7477 RVA: 0x0006B3A4 File Offset: 0x000695A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999693, XrefRangeEnd = 999772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06001D36 RID: 7478 RVA: 0x0006B3E0 File Offset: 0x000695E0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D37 RID: 7479 RVA: 0x0006B420 File Offset: 0x00069620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999772, XrefRangeEnd = 999777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0006B454 File Offset: 0x00069654
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoUpdateCheck._autoUpdateCheck_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D39 RID: 7481 RVA: 0x0000FB49 File Offset: 0x0000DD49
			public _autoUpdateCheck_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0006B494 File Offset: 0x00069694
			// (set) Token: 0x06001D3B RID: 7483 RVA: 0x0000FB52 File Offset: 0x0000DD52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0006B4BC File Offset: 0x000696BC
			// (set) Token: 0x06001D3D RID: 7485 RVA: 0x0000FB6D File Offset: 0x0000DD6D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x06001D3E RID: 7486 RVA: 0x0006B4EC File Offset: 0x000696EC
			// (set) Token: 0x06001D3F RID: 7487 RVA: 0x0000FB8C File Offset: 0x0000DD8C
			public unsafe AutoUpdateCheck __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoUpdateCheck>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0006B51C File Offset: 0x0006971C
			// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0000FBAB File Offset: 0x0000DDAB
			public unsafe string _url_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr__url_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr__url_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0006B544 File Offset: 0x00069744
			// (set) Token: 0x06001D43 RID: 7491 RVA: 0x0000FBCA File Offset: 0x0000DDCA
			public unsafe DwdWebRequestCommand _www_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr__www_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoUpdateCheck._autoUpdateCheck_d__15.NativeFieldInfoPtr__www_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011C4 RID: 4548
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011C5 RID: 4549
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011C6 RID: 4550
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011C7 RID: 4551
			private static readonly IntPtr NativeFieldInfoPtr__url_5__2;

			// Token: 0x040011C8 RID: 4552
			private static readonly IntPtr NativeFieldInfoPtr__www_5__3;

			// Token: 0x040011C9 RID: 4553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011CA RID: 4554
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011CB RID: 4555
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011CC RID: 4556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011CD RID: 4557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011CE RID: 4558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
