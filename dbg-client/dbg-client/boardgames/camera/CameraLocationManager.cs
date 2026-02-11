using System;
using boardgames.match.behaviours;
using boardgames.match.commands;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.camera
{
	// Token: 0x0200029C RID: 668
	public class CameraLocationManager : MonoBehaviour
	{
		// Token: 0x06001FAB RID: 8107 RVA: 0x00086F20 File Offset: 0x00085120
		// Note: this type is marked as 'beforefieldinit'.
		static CameraLocationManager()
		{
			Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.camera", "CameraLocationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr);
			CameraLocationManager.NativeFieldInfoPtr_DefaultFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, "DefaultFlavor");
			CameraLocationManager.NativeFieldInfoPtr_cameraToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, "cameraToMove");
			CameraLocationManager.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, "entitiesProvider");
			CameraLocationManager.NativeFieldInfoPtr_lastPlayerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, "lastPlayerAccountID");
			CameraLocationManager.NativeFieldInfoPtr_cameraController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, "cameraController");
			CameraLocationManager.NativeFieldInfoPtr_cachedPlayerLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, "cachedPlayerLocations");
			CameraLocationManager.NativeFieldInfoPtr_entityLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, "entityLocations");
			CameraLocationManager.NativeFieldInfoPtr_transitionCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, "transitionCommand");
			CameraLocationManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668564);
			CameraLocationManager.NativeMethodInfoPtr_get_moveCommandRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668565);
			CameraLocationManager.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668566);
			CameraLocationManager.NativeMethodInfoPtr_InterruptTransition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668567);
			CameraLocationManager.NativeMethodInfoPtr_GoToPlayerChangedLocation_Public_Command_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668568);
			CameraLocationManager.NativeMethodInfoPtr_RecordPlayerLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668569);
			CameraLocationManager.NativeMethodInfoPtr_GoToRecordedPlayerLocation_Public_Command_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668570);
			CameraLocationManager.NativeMethodInfoPtr_SetCameraStartLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668571);
			CameraLocationManager.NativeMethodInfoPtr_RunGameStart_Public_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668572);
			CameraLocationManager.NativeMethodInfoPtr_GoToFullBoardCommand_Public_Command_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668573);
			CameraLocationManager.NativeMethodInfoPtr_GoToLocationCommand_Public_Command_EntityID_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668574);
			CameraLocationManager.NativeMethodInfoPtr_Register_Public_Void_EntityCameraLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668575);
			CameraLocationManager.NativeMethodInfoPtr_Unregister_Public_Void_EntityCameraLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668576);
			CameraLocationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr, 100668577);
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00087108 File Offset: 0x00085308
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541365, XrefRangeEnd = 541368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00087144 File Offset: 0x00085344
		public unsafe bool moveCommandRunning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 541368, RefRangeEnd = 541369, XrefRangeStart = 541368, XrefRangeEnd = 541368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_get_moveCommandRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x00087180 File Offset: 0x00085380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541369, XrefRangeEnd = 541379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000871B4 File Offset: 0x000853B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 541380, RefRangeEnd = 541382, XrefRangeStart = 541379, XrefRangeEnd = 541380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InterruptTransition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_InterruptTransition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x000871E8 File Offset: 0x000853E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541382, XrefRangeEnd = 541407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GoToPlayerChangedLocation(AccountID newPlayerAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPlayerAccountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_GoToPlayerChangedLocation_Public_Command_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00087238 File Offset: 0x00085438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 541413, RefRangeEnd = 541416, XrefRangeStart = 541407, XrefRangeEnd = 541413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPlayerLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_RecordPlayerLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0008726C File Offset: 0x0008546C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 541450, RefRangeEnd = 541451, XrefRangeStart = 541416, XrefRangeEnd = 541450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GoToRecordedPlayerLocation(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_GoToRecordedPlayerLocation_Public_Command_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000872BC File Offset: 0x000854BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 541473, RefRangeEnd = 541474, XrefRangeStart = 541451, XrefRangeEnd = 541473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraStartLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_SetCameraStartLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x000872F0 File Offset: 0x000854F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541474, XrefRangeEnd = 541500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command RunGameStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_RunGameStart_Public_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x00087330 File Offset: 0x00085530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 541502, RefRangeEnd = 541503, XrefRangeStart = 541500, XrefRangeEnd = 541502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GoToFullBoardCommand(string flavor = "Default")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_GoToFullBoardCommand_Public_Command_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00087380 File Offset: 0x00085580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 541531, RefRangeEnd = 541533, XrefRangeStart = 541503, XrefRangeEnd = 541531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GoToLocationCommand(EntityID entityID, string flavor = "Default", bool ignoreAutoRestrictions = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(flavor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreAutoRestrictions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_GoToLocationCommand_Public_Command_EntityID_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x000873F0 File Offset: 0x000855F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541533, XrefRangeEnd = 541549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(EntityCameraLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_Register_Public_Void_EntityCameraLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00087434 File Offset: 0x00085634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541549, XrefRangeEnd = 541564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(EntityCameraLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr_Unregister_Public_Void_EntityCameraLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00087478 File Offset: 0x00085678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541564, XrefRangeEnd = 541579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraLocationManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraLocationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLocationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00010B0C File Offset: 0x0000ED0C
		public CameraLocationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x000874B4 File Offset: 0x000856B4
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x00010B15 File Offset: 0x0000ED15
		public unsafe static string DefaultFlavor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraLocationManager.NativeFieldInfoPtr_DefaultFlavor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraLocationManager.NativeFieldInfoPtr_DefaultFlavor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x000874D4 File Offset: 0x000856D4
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x00010B27 File Offset: 0x0000ED27
		public unsafe Camera cameraToMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_cameraToMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_cameraToMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00087504 File Offset: 0x00085704
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x00010B46 File Offset: 0x0000ED46
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00087534 File Offset: 0x00085734
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x00010B65 File Offset: 0x0000ED65
		public unsafe AccountID lastPlayerAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_lastPlayerAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_lastPlayerAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00087564 File Offset: 0x00085764
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00010B84 File Offset: 0x0000ED84
		public unsafe CinemachineControlProvider cameraController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_cameraController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CinemachineControlProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_cameraController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x00087594 File Offset: 0x00085794
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00010BA3 File Offset: 0x0000EDA3
		public unsafe Dictionary<AccountID, GlobalTransform> cachedPlayerLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_cachedPlayerLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, GlobalTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_cachedPlayerLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000875C4 File Offset: 0x000857C4
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00010BC2 File Offset: 0x0000EDC2
		public unsafe Dictionary<ValueTuple<string, EntityID>, Transform> entityLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_entityLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<string, EntityID>, Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_entityLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000875F4 File Offset: 0x000857F4
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x00010BE1 File Offset: 0x0000EDE1
		public unsafe RunCameraKabbage transitionCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_transitionCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCameraKabbage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLocationManager.NativeFieldInfoPtr_transitionCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeFieldInfoPtr_DefaultFlavor;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeFieldInfoPtr_cameraToMove;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeFieldInfoPtr_lastPlayerAccountID;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeFieldInfoPtr_cameraController;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeFieldInfoPtr_cachedPlayerLocations;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeFieldInfoPtr_entityLocations;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeFieldInfoPtr_transitionCommand;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_get_moveCommandRunning_Public_get_Boolean_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_InterruptTransition_Public_Void_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_GoToPlayerChangedLocation_Public_Command_AccountID_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_RecordPlayerLocation_Public_Void_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_GoToRecordedPlayerLocation_Public_Command_AccountID_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraStartLocation_Public_Void_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_RunGameStart_Public_Command_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_GoToFullBoardCommand_Public_Command_String_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_GoToLocationCommand_Public_Command_EntityID_String_Boolean_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_EntityCameraLocation_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_EntityCameraLocation_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
