using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x02000009 RID: 9
	public sealed class DeepLinkManager : global::Il2CppSystem.Object
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00003D50 File Offset: 0x00001F50
		// Note: this type is marked as 'beforefieldinit'.
		static DeepLinkManager()
		{
			Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "DeepLinkManager");
			DeepLinkManager.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, "<Instance>k__BackingField");
			DeepLinkManager.NativeFieldInfoPtr__IsSteamBuild_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, "<IsSteamBuild>k__BackingField");
			DeepLinkManager.NativeFieldInfoPtr__activated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, "_activated");
			DeepLinkManager.NativeFieldInfoPtr__currProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, "_currProvider");
			DeepLinkManager.NativeFieldInfoPtr__go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, "_go");
			DeepLinkManager.NativeFieldInfoPtr__storedActivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, "_storedActivation");
			DeepLinkManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_DeepLinkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663369);
			DeepLinkManager.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DeepLinkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663370);
			DeepLinkManager.NativeMethodInfoPtr_get_IsSteamBuild_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663371);
			DeepLinkManager.NativeMethodInfoPtr_set_IsSteamBuild_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663372);
			DeepLinkManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663374);
			DeepLinkManager.NativeMethodInfoPtr_add_LinkActivated_Public_add_Void_LinkActivationHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663375);
			DeepLinkManager.NativeMethodInfoPtr_remove_LinkActivated_Public_rem_Void_LinkActivationHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663376);
			DeepLinkManager.NativeMethodInfoPtr_add__activated_Private_add_Void_LinkActivationHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663377);
			DeepLinkManager.NativeMethodInfoPtr_remove__activated_Private_rem_Void_LinkActivationHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663378);
			DeepLinkManager.NativeMethodInfoPtr_ManuallyTriggerDeepLink_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663379);
			DeepLinkManager.NativeMethodInfoPtr_RegisterIfNecessary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663380);
			DeepLinkManager.NativeMethodInfoPtr_IsRunningOnSteamDeck_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663381);
			DeepLinkManager.NativeMethodInfoPtr_CreatePauseGameObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663382);
			DeepLinkManager.NativeMethodInfoPtr__currProvider_LinkReceived_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663383);
			DeepLinkManager.NativeMethodInfoPtr_StoreActivation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663384);
			DeepLinkManager.NativeMethodInfoPtr_OnActivated_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663385);
			DeepLinkManager.NativeMethodInfoPtr_CreateLinkActivation_Private_LinkActivation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663386);
			DeepLinkManager.NativeMethodInfoPtr_GameCameFromPause_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, 100663387);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003F58 File Offset: 0x00002158
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00003F8C File Offset: 0x0000218C
		public unsafe static DeepLinkManager Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240676, XrefRangeEnd = 1240680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_DeepLinkManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeepLinkManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240680, XrefRangeEnd = 1240686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DeepLinkManager_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003FC4 File Offset: 0x000021C4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00004000 File Offset: 0x00002200
		public unsafe bool IsSteamBuild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_get_IsSteamBuild_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_set_IsSteamBuild_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004040 File Offset: 0x00002240
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeepLinkManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000407C File Offset: 0x0000227C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240692, RefRangeEnd = 1240693, XrefRangeStart = 1240686, XrefRangeEnd = 1240692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_LinkActivated(LinkActivationHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_add_LinkActivated_Public_add_Void_LinkActivationHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000040C0 File Offset: 0x000022C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240697, RefRangeEnd = 1240698, XrefRangeStart = 1240693, XrefRangeEnd = 1240697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_LinkActivated(LinkActivationHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_remove_LinkActivated_Public_rem_Void_LinkActivationHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004104 File Offset: 0x00002304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240698, XrefRangeEnd = 1240702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__activated(LinkActivationHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_add__activated_Private_add_Void_LinkActivationHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004148 File Offset: 0x00002348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240697, RefRangeEnd = 1240698, XrefRangeStart = 1240697, XrefRangeEnd = 1240698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__activated(LinkActivationHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_remove__activated_Private_rem_Void_LinkActivationHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000418C File Offset: 0x0000238C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240702, XrefRangeEnd = 1240704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManuallyTriggerDeepLink(string args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_ManuallyTriggerDeepLink_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000041D0 File Offset: 0x000023D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240785, RefRangeEnd = 1240787, XrefRangeStart = 1240704, XrefRangeEnd = 1240785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterIfNecessary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_RegisterIfNecessary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004204 File Offset: 0x00002404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240787, XrefRangeEnd = 1240795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRunningOnSteamDeck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_IsRunningOnSteamDeck_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004234 File Offset: 0x00002434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240824, RefRangeEnd = 1240826, XrefRangeStart = 1240795, XrefRangeEnd = 1240824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreatePauseGameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_CreatePauseGameObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004268 File Offset: 0x00002468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _currProvider_LinkReceived(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr__currProvider_LinkReceived_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000042AC File Offset: 0x000024AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreActivation(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_StoreActivation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000042F0 File Offset: 0x000024F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240827, RefRangeEnd = 1240830, XrefRangeStart = 1240826, XrefRangeEnd = 1240827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnActivated(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_OnActivated_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004340 File Offset: 0x00002540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240857, RefRangeEnd = 1240858, XrefRangeStart = 1240830, XrefRangeEnd = 1240857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkActivation CreateLinkActivation(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_CreateLinkActivation_Private_LinkActivation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkActivation>(intPtr3) : null;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004390 File Offset: 0x00002590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240858, XrefRangeEnd = 1240861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameCameFromPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.NativeMethodInfoPtr_GameCameFromPause_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000222C File Offset: 0x0000042C
		public DeepLinkManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000043C4 File Offset: 0x000025C4
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002235 File Offset: 0x00000435
		public unsafe static DeepLinkManager _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeepLinkManager.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeepLinkManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeepLinkManager.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000043EC File Offset: 0x000025EC
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002247 File Offset: 0x00000447
		public unsafe bool _IsSteamBuild_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__IsSteamBuild_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__IsSteamBuild_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004414 File Offset: 0x00002614
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002262 File Offset: 0x00000462
		public unsafe LinkActivationHandler _activated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__activated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkActivationHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__activated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00004444 File Offset: 0x00002644
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002281 File Offset: 0x00000481
		public unsafe ILinkProvider _currProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__currProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILinkProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__currProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00004474 File Offset: 0x00002674
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022A0 File Offset: 0x000004A0
		public unsafe GameObject _go
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__go);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__go), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000044A4 File Offset: 0x000026A4
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000022BF File Offset: 0x000004BF
		public unsafe string _storedActivation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__storedActivation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.NativeFieldInfoPtr__storedActivation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr__IsSteamBuild_k__BackingField;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr__activated;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr__currProvider;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr__go;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__storedActivation;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DeepLinkManager_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DeepLinkManager_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSteamBuild_Public_get_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSteamBuild_Public_set_Void_Boolean_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_add_LinkActivated_Public_add_Void_LinkActivationHandler_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_remove_LinkActivated_Public_rem_Void_LinkActivationHandler_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_add__activated_Private_add_Void_LinkActivationHandler_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_remove__activated_Private_rem_Void_LinkActivationHandler_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ManuallyTriggerDeepLink_Public_Void_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_RegisterIfNecessary_Private_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_IsRunningOnSteamDeck_Private_Static_Boolean_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_CreatePauseGameObject_Private_Void_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr__currProvider_LinkReceived_Private_Void_String_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_StoreActivation_Private_Void_String_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_OnActivated_Private_Boolean_String_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinkActivation_Private_LinkActivation_String_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_GameCameFromPause_Internal_Void_0;

		// Token: 0x0200001D RID: 29
		public class UrlEncodingParser : Dictionary<string, string>
		{
			// Token: 0x06000166 RID: 358 RVA: 0x00007744 File Offset: 0x00005944
			// Note: this type is marked as 'beforefieldinit'.
			static UrlEncodingParser()
			{
				Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeepLinkManager>.NativeClassPtr, "UrlEncodingParser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr);
				DeepLinkManager.UrlEncodingParser.NativeFieldInfoPtr__Url_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, "<Url>k__BackingField");
				DeepLinkManager.UrlEncodingParser.NativeFieldInfoPtr__Query_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, "<Query>k__BackingField");
				DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_get_Url_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, 100663388);
				DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_set_Url_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, 100663389);
				DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_get_Query_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, 100663390);
				DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_set_Query_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, 100663391);
				DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, 100663392);
				DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_SetValues_Public_Void_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, 100663393);
				DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_Parse_Public_Dictionary_2_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, 100663394);
				DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr, 100663395);
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000167 RID: 359 RVA: 0x00007838 File Offset: 0x00005A38
			// (set) Token: 0x06000168 RID: 360 RVA: 0x00007870 File Offset: 0x00005A70
			public unsafe string Url
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_get_Url_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_set_Url_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000169 RID: 361 RVA: 0x000078B4 File Offset: 0x00005AB4
			// (set) Token: 0x0600016A RID: 362 RVA: 0x000078EC File Offset: 0x00005AEC
			public unsafe string Query
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_get_Query_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_set_Query_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600016B RID: 363 RVA: 0x00007930 File Offset: 0x00005B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240569, XrefRangeEnd = 1240577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UrlEncodingParser(string queryStringOrUrl = null)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeepLinkManager.UrlEncodingParser>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(queryStringOrUrl);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600016C RID: 364 RVA: 0x0000797C File Offset: 0x00005B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240577, XrefRangeEnd = 1240597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValues(string key, IEnumerable<string> values)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_SetValues_Public_Void_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016D RID: 365 RVA: 0x000079D0 File Offset: 0x00005BD0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1240624, RefRangeEnd = 1240626, XrefRangeStart = 1240597, XrefRangeEnd = 1240624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, string> Parse(string query)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(query);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_Parse_Public_Dictionary_2_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00007A20 File Offset: 0x00005C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240626, XrefRangeEnd = 1240676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeepLinkManager.UrlEncodingParser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600016F RID: 367 RVA: 0x000027C9 File Offset: 0x000009C9
			public UrlEncodingParser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000170 RID: 368 RVA: 0x00007A64 File Offset: 0x00005C64
			// (set) Token: 0x06000171 RID: 369 RVA: 0x000027D2 File Offset: 0x000009D2
			public unsafe string _Url_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.UrlEncodingParser.NativeFieldInfoPtr__Url_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.UrlEncodingParser.NativeFieldInfoPtr__Url_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000172 RID: 370 RVA: 0x00007A8C File Offset: 0x00005C8C
			// (set) Token: 0x06000173 RID: 371 RVA: 0x000027F1 File Offset: 0x000009F1
			public unsafe string _Query_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.UrlEncodingParser.NativeFieldInfoPtr__Query_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeepLinkManager.UrlEncodingParser.NativeFieldInfoPtr__Query_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040000F5 RID: 245
			private static readonly IntPtr NativeFieldInfoPtr__Url_k__BackingField;

			// Token: 0x040000F6 RID: 246
			private static readonly IntPtr NativeFieldInfoPtr__Query_k__BackingField;

			// Token: 0x040000F7 RID: 247
			private static readonly IntPtr NativeMethodInfoPtr_get_Url_Private_get_String_0;

			// Token: 0x040000F8 RID: 248
			private static readonly IntPtr NativeMethodInfoPtr_set_Url_Private_set_Void_String_0;

			// Token: 0x040000F9 RID: 249
			private static readonly IntPtr NativeMethodInfoPtr_get_Query_Public_get_String_0;

			// Token: 0x040000FA RID: 250
			private static readonly IntPtr NativeMethodInfoPtr_set_Query_Private_set_Void_String_0;

			// Token: 0x040000FB RID: 251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x040000FC RID: 252
			private static readonly IntPtr NativeMethodInfoPtr_SetValues_Public_Void_String_IEnumerable_1_String_0;

			// Token: 0x040000FD RID: 253
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Dictionary_2_String_String_String_0;

			// Token: 0x040000FE RID: 254
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}
	}
}
