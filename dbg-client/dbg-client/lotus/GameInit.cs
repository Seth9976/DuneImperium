using System;
using boardgames.menus.commands;
using boardgames.steam;
using canis.archetypes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.notifications.messages.incoming;
using dwd.core.session;
using dwd.core.ui.prompt.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using ImaginationOverflow.UniversalDeepLinking;
using localization;
using Networking.game;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace lotus
{
	// Token: 0x0200001B RID: 27
	public class GameInit : MonoBehaviour
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00020898 File Offset: 0x0001EA98
		// Note: this type is marked as 'beforefieldinit'.
		static GameInit()
		{
			Il2CppClassPointerStore<GameInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lotus", "GameInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInit>.NativeClassPtr);
			GameInit.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "client");
			GameInit.NativeFieldInfoPtr_gameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "gameSession");
			GameInit.NativeFieldInfoPtr_isRejoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "isRejoin");
			GameInit.NativeMethodInfoPtr_get_isBatchMode_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663470);
			GameInit.NativeMethodInfoPtr_getArchetypes_Protected_Abstract_Virtual_New_Archetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663471);
			GameInit.NativeMethodInfoPtr_initClientVersion_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663472);
			GameInit.NativeMethodInfoPtr_configureSharedPrefs_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663473);
			GameInit.NativeMethodInfoPtr_get_QualityLevels_Public_Virtual_New_get_List_1_ValueTuple_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663474);
			GameInit.NativeMethodInfoPtr_getSteamAppID_Protected_Virtual_New_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663475);
			GameInit.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663476);
			GameInit.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663477);
			GameInit.NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663478);
			GameInit.NativeMethodInfoPtr_initDeepLinking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663479);
			GameInit.NativeMethodInfoPtr_Instance_LinkActivated_Private_Void_LinkActivation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663480);
			GameInit.NativeMethodInfoPtr_Decompress_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663481);
			GameInit.NativeMethodInfoPtr_ShouldGoDirectlyToGameOnLinkActivation_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663482);
			GameInit.NativeMethodInfoPtr_GoDirectlyToGame_Protected_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663483);
			GameInit.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663484);
			GameInit.NativeMethodInfoPtr_PromptUserForOptionsAndAdvance_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663485);
			GameInit.NativeMethodInfoPtr_initPlatformScenes_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663486);
			GameInit.NativeMethodInfoPtr_HasSplashInBuildSettings_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663487);
			GameInit.NativeMethodInfoPtr_initPlatformSocial_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663488);
			GameInit.NativeMethodInfoPtr_getSupportedLocales_Protected_Virtual_New_Dictionary_2_String_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663489);
			GameInit.NativeMethodInfoPtr_getSystemLanguage_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663490);
			GameInit.NativeMethodInfoPtr_RegisterManagers_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663491);
			GameInit.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit>.NativeClassPtr, 100663492);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00020AD0 File Offset: 0x0001ECD0
		public unsafe bool isBatchMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 496945, RefRangeEnd = 496946, XrefRangeStart = 496923, XrefRangeEnd = 496945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_get_isBatchMode_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00020B0C File Offset: 0x0001ED0C
		[CallerCount(0)]
		public unsafe virtual Archetypes getArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_getArchetypes_Protected_Abstract_Virtual_New_Archetypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetypes>(intPtr3) : null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00020B58 File Offset: 0x0001ED58
		[CallerCount(0)]
		public unsafe virtual void initClientVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_initClientVersion_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00020B94 File Offset: 0x0001ED94
		[CallerCount(0)]
		public unsafe virtual void configureSharedPrefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_configureSharedPrefs_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00020BD0 File Offset: 0x0001EDD0
		public unsafe virtual List<ValueTuple<int, string>> QualityLevels
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496946, XrefRangeEnd = 496950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_get_QualityLevels_Public_Virtual_New_get_List_1_ValueTuple_2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<int, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00020C1C File Offset: 0x0001EE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496950, XrefRangeEnd = 496970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint getSteamAppID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_getSteamAppID_Protected_Virtual_New_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00020C64 File Offset: 0x0001EE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496970, XrefRangeEnd = 496996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00020C98 File Offset: 0x0001EE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496996, XrefRangeEnd = 497001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00020CD8 File Offset: 0x0001EED8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00020D14 File Offset: 0x0001EF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497001, XrefRangeEnd = 497030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initDeepLinking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_initDeepLinking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00020D48 File Offset: 0x0001EF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497030, XrefRangeEnd = 497105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Instance_LinkActivated(LinkActivation s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_Instance_LinkActivated_Private_Void_LinkActivation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00020D8C File Offset: 0x0001EF8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497132, RefRangeEnd = 497133, XrefRangeStart = 497105, XrefRangeEnd = 497132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Decompress(string compressedString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(compressedString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_Decompress_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00020DC8 File Offset: 0x0001EFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497133, XrefRangeEnd = 497150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldGoDirectlyToGameOnLinkActivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_ShouldGoDirectlyToGameOnLinkActivation_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00020E10 File Offset: 0x0001F010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497150, XrefRangeEnd = 497177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command GoDirectlyToGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_GoDirectlyToGame_Protected_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00020E5C File Offset: 0x0001F05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497177, XrefRangeEnd = 497192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00020E90 File Offset: 0x0001F090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497192, XrefRangeEnd = 497197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PromptUserForOptionsAndAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_PromptUserForOptionsAndAdvance_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00020ED0 File Offset: 0x0001F0D0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void initPlatformScenes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_initPlatformScenes_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00020F0C File Offset: 0x0001F10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497197, XrefRangeEnd = 497206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSplashInBuildSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_HasSplashInBuildSettings_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00020F48 File Offset: 0x0001F148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497206, XrefRangeEnd = 497210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator initPlatformSocial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_initPlatformSocial_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00020F88 File Offset: 0x0001F188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497210, XrefRangeEnd = 497258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<string, TextLocalization.Locale> getSupportedLocales()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInit.NativeMethodInfoPtr_getSupportedLocales_Protected_Virtual_New_Dictionary_2_String_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TextLocalization.Locale>>(intPtr3) : null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00020FD4 File Offset: 0x0001F1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497258, XrefRangeEnd = 497265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getSystemLanguage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_getSystemLanguage_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0002100C File Offset: 0x0001F20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497265, XrefRangeEnd = 497275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterManagers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr_RegisterManagers_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00021034 File Offset: 0x0001F234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497280, RefRangeEnd = 497281, XrefRangeStart = 497275, XrefRangeEnd = 497280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameInit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002647 File Offset: 0x00000847
		public GameInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00021070 File Offset: 0x0001F270
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002650 File Offset: 0x00000850
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00021098 File Offset: 0x0001F298
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000266F File Offset: 0x0000086F
		public unsafe DWDGameSession gameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit.NativeFieldInfoPtr_gameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit.NativeFieldInfoPtr_gameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000210C8 File Offset: 0x0001F2C8
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000268E File Offset: 0x0000088E
		public unsafe bool isRejoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit.NativeFieldInfoPtr_isRejoin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit.NativeFieldInfoPtr_isRejoin)) = value;
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_gameSession;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_isRejoin;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_isBatchMode_Private_get_Boolean_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_getArchetypes_Protected_Abstract_Virtual_New_Archetypes_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_initClientVersion_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_configureSharedPrefs_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_QualityLevels_Public_Virtual_New_get_List_1_ValueTuple_2_Int32_String_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_getSteamAppID_Protected_Virtual_New_UInt32_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_initDeepLinking_Private_Void_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Instance_LinkActivated_Private_Void_LinkActivation_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_Decompress_Private_Static_String_String_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_ShouldGoDirectlyToGameOnLinkActivation_Protected_Virtual_New_Boolean_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GoDirectlyToGame_Protected_Virtual_New_Command_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_PromptUserForOptionsAndAdvance_Private_IEnumerator_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_initPlatformScenes_Protected_Virtual_New_Void_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_HasSplashInBuildSettings_Private_Boolean_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_initPlatformSocial_Private_IEnumerator_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_getSupportedLocales_Protected_Virtual_New_Dictionary_2_String_Locale_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_getSystemLanguage_Private_String_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_RegisterManagers_Private_Static_Void_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020002D2 RID: 722
		[ObfuscatedName("lotus.GameInit+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x060021E6 RID: 8678 RVA: 0x0008DE3C File Offset: 0x0008C03C
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<GameInit.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInit.__O>.NativeClassPtr);
				GameInit.__O.NativeFieldInfoPtr__0___SendErrorToAnalytics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__O>.NativeClassPtr, "<0>__SendErrorToAnalytics");
				GameInit.__O.NativeFieldInfoPtr__1___NEVER_AUTO_ACKNOWLEDGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__O>.NativeClassPtr, "<1>__NEVER_AUTO_ACKNOWLEDGE");
			}

			// Token: 0x060021E7 RID: 8679 RVA: 0x00011B58 File Offset: 0x0000FD58
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0008DE90 File Offset: 0x0008C090
			// (set) Token: 0x060021E9 RID: 8681 RVA: 0x00011B61 File Offset: 0x0000FD61
			public unsafe static Action<string, string, LogType> _0___SendErrorToAnalytics
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__O.NativeFieldInfoPtr__0___SendErrorToAnalytics, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string, LogType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__O.NativeFieldInfoPtr__0___SendErrorToAnalytics, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x060021EA RID: 8682 RVA: 0x0008DEB8 File Offset: 0x0008C0B8
			// (set) Token: 0x060021EB RID: 8683 RVA: 0x00011B73 File Offset: 0x0000FD73
			public unsafe static Predicate<Notification> _1___NEVER_AUTO_ACKNOWLEDGE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__O.NativeFieldInfoPtr__1___NEVER_AUTO_ACKNOWLEDGE, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Notification>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__O.NativeFieldInfoPtr__1___NEVER_AUTO_ACKNOWLEDGE, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001553 RID: 5459
			private static readonly IntPtr NativeFieldInfoPtr__0___SendErrorToAnalytics;

			// Token: 0x04001554 RID: 5460
			private static readonly IntPtr NativeFieldInfoPtr__1___NEVER_AUTO_ACKNOWLEDGE;
		}

		// Token: 0x020002D3 RID: 723
		[ObfuscatedName("lotus.GameInit+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060021EC RID: 8684 RVA: 0x0008DEE0 File Offset: 0x0008C0E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr);
				GameInit.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9");
				GameInit.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9__12_1");
				GameInit.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9__12_0");
				GameInit.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9__15_0");
				GameInit.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9__20_0");
				GameInit.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9__20_1");
				GameInit.__c.NativeFieldInfoPtr___9__20_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9__20_2");
				GameInit.__c.NativeFieldInfoPtr___9__20_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9__20_3");
				GameInit.__c.NativeFieldInfoPtr___9__20_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, "<>9__20_4");
				GameInit.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663494);
				GameInit.__c.NativeMethodInfoPtr__Start_b__12_1_Internal_IEnumerator_DisplayGenericPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663495);
				GameInit.__c.NativeMethodInfoPtr__Start_b__12_0_Internal_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663496);
				GameInit.__c.NativeMethodInfoPtr__Instance_LinkActivated_b__15_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663497);
				GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_0_Internal_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663498);
				GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_1_Internal_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663499);
				GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_2_Internal_IEnumerator_RunUIScaleFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663500);
				GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_3_Internal_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663501);
				GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_4_Internal_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr, 100663502);
			}

			// Token: 0x060021ED RID: 8685 RVA: 0x0008E074 File Offset: 0x0008C274
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInit.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021EE RID: 8686 RVA: 0x0008E0B0 File Offset: 0x0008C2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496394, XrefRangeEnd = 496400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Start_b__12_1(DisplayGenericPrompt _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__Start_b__12_1_Internal_IEnumerator_DisplayGenericPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060021EF RID: 8687 RVA: 0x0008E100 File Offset: 0x0008C300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496400, XrefRangeEnd = 496411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__12_0(AccountID accountID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__Start_b__12_0_Internal_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021F0 RID: 8688 RVA: 0x0008E150 File Offset: 0x0008C350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496411, XrefRangeEnd = 496412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Instance_LinkActivated_b__15_0(Command command)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__Instance_LinkActivated_b__15_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021F1 RID: 8689 RVA: 0x0008E1A0 File Offset: 0x0008C3A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496412, XrefRangeEnd = 496420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _PromptUserForOptionsAndAdvance_b__20_0(IEnumerator _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_0_Internal_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060021F2 RID: 8690 RVA: 0x0008E1F0 File Offset: 0x0008C3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496420, XrefRangeEnd = 496424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _PromptUserForOptionsAndAdvance_b__20_1(IEnumerator _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_1_Internal_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060021F3 RID: 8691 RVA: 0x0008E240 File Offset: 0x0008C440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496424, XrefRangeEnd = 496432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _PromptUserForOptionsAndAdvance_b__20_2(RunUIScaleFlow _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_2_Internal_IEnumerator_RunUIScaleFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060021F4 RID: 8692 RVA: 0x0008E290 File Offset: 0x0008C490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496432, XrefRangeEnd = 496437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PromptUserForOptionsAndAdvance_b__20_3(IEnumerator _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_3_Internal_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021F5 RID: 8693 RVA: 0x0008E2D4 File Offset: 0x0008C4D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496437, XrefRangeEnd = 496441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _PromptUserForOptionsAndAdvance_b__20_4(IEnumerator _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c.NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_4_Internal_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060021F6 RID: 8694 RVA: 0x00011B85 File Offset: 0x0000FD85
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0008E324 File Offset: 0x0008C524
			// (set) Token: 0x060021F8 RID: 8696 RVA: 0x00011B8E File Offset: 0x0000FD8E
			public unsafe static GameInit.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInit.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0008E34C File Offset: 0x0008C54C
			// (set) Token: 0x060021FA RID: 8698 RVA: 0x00011BA0 File Offset: 0x0000FDA0
			public unsafe static Func<DisplayGenericPrompt, IEnumerator> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DisplayGenericPrompt, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x060021FB RID: 8699 RVA: 0x0008E374 File Offset: 0x0008C574
			// (set) Token: 0x060021FC RID: 8700 RVA: 0x00011BB2 File Offset: 0x0000FDB2
			public unsafe static Func<AccountID, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x060021FD RID: 8701 RVA: 0x0008E39C File Offset: 0x0008C59C
			// (set) Token: 0x060021FE RID: 8702 RVA: 0x00011BC4 File Offset: 0x0000FDC4
			public unsafe static Func<Command, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x060021FF RID: 8703 RVA: 0x0008E3C4 File Offset: 0x0008C5C4
			// (set) Token: 0x06002200 RID: 8704 RVA: 0x00011BD6 File Offset: 0x0000FDD6
			public unsafe static Func<IEnumerator, IEnumerator> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x06002201 RID: 8705 RVA: 0x0008E3EC File Offset: 0x0008C5EC
			// (set) Token: 0x06002202 RID: 8706 RVA: 0x00011BE8 File Offset: 0x0000FDE8
			public unsafe static Func<IEnumerator, IEnumerator> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x06002203 RID: 8707 RVA: 0x0008E414 File Offset: 0x0008C614
			// (set) Token: 0x06002204 RID: 8708 RVA: 0x00011BFA File Offset: 0x0000FDFA
			public unsafe static Func<RunUIScaleFlow, IEnumerator> __9__20_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9__20_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RunUIScaleFlow, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9__20_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x06002205 RID: 8709 RVA: 0x0008E43C File Offset: 0x0008C63C
			// (set) Token: 0x06002206 RID: 8710 RVA: 0x00011C0C File Offset: 0x0000FE0C
			public unsafe static Action<IEnumerator> __9__20_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9__20_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9__20_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x06002207 RID: 8711 RVA: 0x0008E464 File Offset: 0x0008C664
			// (set) Token: 0x06002208 RID: 8712 RVA: 0x00011C1E File Offset: 0x0000FE1E
			public unsafe static Func<IEnumerator, IEnumerator> __9__20_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInit.__c.NativeFieldInfoPtr___9__20_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInit.__c.NativeFieldInfoPtr___9__20_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001555 RID: 5461
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001556 RID: 5462
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04001557 RID: 5463
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04001558 RID: 5464
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04001559 RID: 5465
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400155A RID: 5466
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x0400155B RID: 5467
			private static readonly IntPtr NativeFieldInfoPtr___9__20_2;

			// Token: 0x0400155C RID: 5468
			private static readonly IntPtr NativeFieldInfoPtr___9__20_3;

			// Token: 0x0400155D RID: 5469
			private static readonly IntPtr NativeFieldInfoPtr___9__20_4;

			// Token: 0x0400155E RID: 5470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400155F RID: 5471
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__12_1_Internal_IEnumerator_DisplayGenericPrompt_0;

			// Token: 0x04001560 RID: 5472
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__12_0_Internal_Boolean_AccountID_0;

			// Token: 0x04001561 RID: 5473
			private static readonly IntPtr NativeMethodInfoPtr__Instance_LinkActivated_b__15_0_Internal_Boolean_Command_0;

			// Token: 0x04001562 RID: 5474
			private static readonly IntPtr NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_0_Internal_IEnumerator_IEnumerator_0;

			// Token: 0x04001563 RID: 5475
			private static readonly IntPtr NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_1_Internal_IEnumerator_IEnumerator_0;

			// Token: 0x04001564 RID: 5476
			private static readonly IntPtr NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_2_Internal_IEnumerator_RunUIScaleFlow_0;

			// Token: 0x04001565 RID: 5477
			private static readonly IntPtr NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_3_Internal_Void_IEnumerator_0;

			// Token: 0x04001566 RID: 5478
			private static readonly IntPtr NativeMethodInfoPtr__PromptUserForOptionsAndAdvance_b__20_4_Internal_IEnumerator_IEnumerator_0;
		}

		// Token: 0x020002D4 RID: 724
		[ObfuscatedName("lotus.GameInit+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002209 RID: 8713 RVA: 0x0008E48C File Offset: 0x0008C68C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<GameInit.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInit.__c__DisplayClass4_0>.NativeClassPtr);
				GameInit.__c__DisplayClass4_0.NativeFieldInfoPtr_batchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit.__c__DisplayClass4_0>.NativeClassPtr, "batchMode");
				GameInit.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c__DisplayClass4_0>.NativeClassPtr, 100663503);
				GameInit.__c__DisplayClass4_0.NativeMethodInfoPtr__get_isBatchMode_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit.__c__DisplayClass4_0>.NativeClassPtr, 100663504);
			}

			// Token: 0x0600220A RID: 8714 RVA: 0x0008E4F4 File Offset: 0x0008C6F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInit.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600220B RID: 8715 RVA: 0x0008E530 File Offset: 0x0008C730
			[CallerCount(0)]
			public unsafe void _get_isBatchMode_b__0(string v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit.__c__DisplayClass4_0.NativeMethodInfoPtr__get_isBatchMode_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600220C RID: 8716 RVA: 0x00011C30 File Offset: 0x0000FE30
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x0600220D RID: 8717 RVA: 0x0008E574 File Offset: 0x0008C774
			// (set) Token: 0x0600220E RID: 8718 RVA: 0x00011C39 File Offset: 0x0000FE39
			public unsafe bool batchMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit.__c__DisplayClass4_0.NativeFieldInfoPtr_batchMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit.__c__DisplayClass4_0.NativeFieldInfoPtr_batchMode)) = value;
				}
			}

			// Token: 0x04001567 RID: 5479
			private static readonly IntPtr NativeFieldInfoPtr_batchMode;

			// Token: 0x04001568 RID: 5480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001569 RID: 5481
			private static readonly IntPtr NativeMethodInfoPtr__get_isBatchMode_b__0_Internal_Void_String_0;
		}

		// Token: 0x020002D5 RID: 725
		[ObfuscatedName("lotus.GameInit+<PromptUserForOptionsAndAdvance>d__20")]
		public sealed class _PromptUserForOptionsAndAdvance_d__20 : global::Il2CppSystem.Object
		{
			// Token: 0x0600220F RID: 8719 RVA: 0x0008E59C File Offset: 0x0008C79C
			// Note: this type is marked as 'beforefieldinit'.
			static _PromptUserForOptionsAndAdvance_d__20()
			{
				Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "<PromptUserForOptionsAndAdvance>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr);
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, "<>1__state");
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, "<>2__current");
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, "<>4__this");
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr__handle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, "<handle>5__2");
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, 100663505);
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, 100663506);
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, 100663507);
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, 100663508);
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, 100663509);
				GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr, 100663510);
			}

			// Token: 0x06002210 RID: 8720 RVA: 0x0008E690 File Offset: 0x0008C890
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PromptUserForOptionsAndAdvance_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInit._PromptUserForOptionsAndAdvance_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002211 RID: 8721 RVA: 0x0008E6D8 File Offset: 0x0008C8D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002212 RID: 8722 RVA: 0x0008E70C File Offset: 0x0008C90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496441, XrefRangeEnd = 496582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x06002213 RID: 8723 RVA: 0x0008E748 File Offset: 0x0008C948
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002214 RID: 8724 RVA: 0x0008E788 File Offset: 0x0008C988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496582, XrefRangeEnd = 496587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x06002215 RID: 8725 RVA: 0x0008E7BC File Offset: 0x0008C9BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002216 RID: 8726 RVA: 0x00011C54 File Offset: 0x0000FE54
			public _PromptUserForOptionsAndAdvance_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x06002217 RID: 8727 RVA: 0x0008E7FC File Offset: 0x0008C9FC
			// (set) Token: 0x06002218 RID: 8728 RVA: 0x00011C5D File Offset: 0x0000FE5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x06002219 RID: 8729 RVA: 0x0008E824 File Offset: 0x0008CA24
			// (set) Token: 0x0600221A RID: 8730 RVA: 0x00011C78 File Offset: 0x0000FE78
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x0600221B RID: 8731 RVA: 0x0008E854 File Offset: 0x0008CA54
			// (set) Token: 0x0600221C RID: 8732 RVA: 0x00011C97 File Offset: 0x0000FE97
			public unsafe GameInit __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x0600221D RID: 8733 RVA: 0x0008E884 File Offset: 0x0008CA84
			// (set) Token: 0x0600221E RID: 8734 RVA: 0x00011CB6 File Offset: 0x0000FEB6
			public AsyncOperationHandle<IList<IResourceLocation>> _handle_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr__handle_5__2);
					return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._PromptUserForOptionsAndAdvance_d__20.NativeFieldInfoPtr__handle_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400156A RID: 5482
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400156B RID: 5483
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400156C RID: 5484
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400156D RID: 5485
			private static readonly IntPtr NativeFieldInfoPtr__handle_5__2;

			// Token: 0x0400156E RID: 5486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400156F RID: 5487
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001570 RID: 5488
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001571 RID: 5489
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001572 RID: 5490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001573 RID: 5491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002D6 RID: 726
		[ObfuscatedName("lotus.GameInit+<Start>d__12")]
		public sealed class _Start_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x0600221F RID: 8735 RVA: 0x0008E8B4 File Offset: 0x0008CAB4
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__12()
			{
				Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "<Start>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr);
				GameInit._Start_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, "<>1__state");
				GameInit._Start_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, "<>2__current");
				GameInit._Start_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, "<>4__this");
				GameInit._Start_d__12.NativeFieldInfoPtr__sessionProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, "<sessionProvider>5__2");
				GameInit._Start_d__12.NativeFieldInfoPtr__initCommands_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, "<initCommands>5__3");
				GameInit._Start_d__12.NativeFieldInfoPtr__steam_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, "<steam>5__4");
				GameInit._Start_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, 100663511);
				GameInit._Start_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, 100663512);
				GameInit._Start_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, 100663513);
				GameInit._Start_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, 100663514);
				GameInit._Start_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, 100663515);
				GameInit._Start_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr, 100663516);
			}

			// Token: 0x06002220 RID: 8736 RVA: 0x0008E9D0 File Offset: 0x0008CBD0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInit._Start_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._Start_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002221 RID: 8737 RVA: 0x0008EA18 File Offset: 0x0008CC18
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._Start_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002222 RID: 8738 RVA: 0x0008EA4C File Offset: 0x0008CC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496587, XrefRangeEnd = 496901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._Start_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x06002223 RID: 8739 RVA: 0x0008EA88 File Offset: 0x0008CC88
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._Start_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002224 RID: 8740 RVA: 0x0008EAC8 File Offset: 0x0008CCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496901, XrefRangeEnd = 496906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._Start_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x06002225 RID: 8741 RVA: 0x0008EAFC File Offset: 0x0008CCFC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._Start_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002226 RID: 8742 RVA: 0x00011CE4 File Offset: 0x0000FEE4
			public _Start_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x06002227 RID: 8743 RVA: 0x0008EB3C File Offset: 0x0008CD3C
			// (set) Token: 0x06002228 RID: 8744 RVA: 0x00011CED File Offset: 0x0000FEED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x06002229 RID: 8745 RVA: 0x0008EB64 File Offset: 0x0008CD64
			// (set) Token: 0x0600222A RID: 8746 RVA: 0x00011D08 File Offset: 0x0000FF08
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000928 RID: 2344
			// (get) Token: 0x0600222B RID: 8747 RVA: 0x0008EB94 File Offset: 0x0008CD94
			// (set) Token: 0x0600222C RID: 8748 RVA: 0x00011D27 File Offset: 0x0000FF27
			public unsafe GameInit __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000929 RID: 2345
			// (get) Token: 0x0600222D RID: 8749 RVA: 0x0008EBC4 File Offset: 0x0008CDC4
			// (set) Token: 0x0600222E RID: 8750 RVA: 0x00011D46 File Offset: 0x0000FF46
			public unsafe SessionProvider _sessionProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr__sessionProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr__sessionProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092A RID: 2346
			// (get) Token: 0x0600222F RID: 8751 RVA: 0x0008EBF4 File Offset: 0x0008CDF4
			// (set) Token: 0x06002230 RID: 8752 RVA: 0x00011D65 File Offset: 0x0000FF65
			public unsafe IFailable _initCommands_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr__initCommands_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr__initCommands_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092B RID: 2347
			// (get) Token: 0x06002231 RID: 8753 RVA: 0x0008EC24 File Offset: 0x0008CE24
			// (set) Token: 0x06002232 RID: 8754 RVA: 0x00011D84 File Offset: 0x0000FF84
			public unsafe Steam _steam_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr__steam_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Steam>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._Start_d__12.NativeFieldInfoPtr__steam_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001574 RID: 5492
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001575 RID: 5493
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001576 RID: 5494
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001577 RID: 5495
			private static readonly IntPtr NativeFieldInfoPtr__sessionProvider_5__2;

			// Token: 0x04001578 RID: 5496
			private static readonly IntPtr NativeFieldInfoPtr__initCommands_5__3;

			// Token: 0x04001579 RID: 5497
			private static readonly IntPtr NativeFieldInfoPtr__steam_5__4;

			// Token: 0x0400157A RID: 5498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400157B RID: 5499
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400157C RID: 5500
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400157D RID: 5501
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400157E RID: 5502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400157F RID: 5503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002D7 RID: 727
		[ObfuscatedName("lotus.GameInit+<initPlatformSocial>d__23")]
		public sealed class _initPlatformSocial_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x06002233 RID: 8755 RVA: 0x0008EC54 File Offset: 0x0008CE54
			// Note: this type is marked as 'beforefieldinit'.
			static _initPlatformSocial_d__23()
			{
				Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInit>.NativeClassPtr, "<initPlatformSocial>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr);
				GameInit._initPlatformSocial_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr, "<>1__state");
				GameInit._initPlatformSocial_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr, "<>2__current");
				GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr, 100663517);
				GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr, 100663518);
				GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr, 100663519);
				GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr, 100663520);
				GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr, 100663521);
				GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr, 100663522);
			}

			// Token: 0x06002234 RID: 8756 RVA: 0x0008ED20 File Offset: 0x0008CF20
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _initPlatformSocial_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInit._initPlatformSocial_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x0008ED68 File Offset: 0x0008CF68
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002236 RID: 8758 RVA: 0x0008ED9C File Offset: 0x0008CF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496906, XrefRangeEnd = 496918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000930 RID: 2352
			// (get) Token: 0x06002237 RID: 8759 RVA: 0x0008EDD8 File Offset: 0x0008CFD8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002238 RID: 8760 RVA: 0x0008EE18 File Offset: 0x0008D018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496918, XrefRangeEnd = 496923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000931 RID: 2353
			// (get) Token: 0x06002239 RID: 8761 RVA: 0x0008EE4C File Offset: 0x0008D04C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInit._initPlatformSocial_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600223A RID: 8762 RVA: 0x00011DA3 File Offset: 0x0000FFA3
			public _initPlatformSocial_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x0600223B RID: 8763 RVA: 0x0008EE8C File Offset: 0x0008D08C
			// (set) Token: 0x0600223C RID: 8764 RVA: 0x00011DAC File Offset: 0x0000FFAC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._initPlatformSocial_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._initPlatformSocial_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700092F RID: 2351
			// (get) Token: 0x0600223D RID: 8765 RVA: 0x0008EEB4 File Offset: 0x0008D0B4
			// (set) Token: 0x0600223E RID: 8766 RVA: 0x00011DC7 File Offset: 0x0000FFC7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._initPlatformSocial_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInit._initPlatformSocial_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001580 RID: 5504
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001581 RID: 5505
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001582 RID: 5506
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001583 RID: 5507
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001584 RID: 5508
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001585 RID: 5509
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001586 RID: 5510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001587 RID: 5511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
