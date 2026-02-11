using System;
using Canis.json.events;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.game;
using UnityEngine.Networking;

namespace boardgames.match.commands
{
	// Token: 0x0200028F RID: 655
	public class PlayCanisOnlineMatch : PlayMatchCommand
	{
		// Token: 0x06001EBF RID: 7871 RVA: 0x00083F78 File Offset: 0x00082178
		// Note: this type is marked as 'beforefieldinit'.
		static PlayCanisOnlineMatch()
		{
			Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "PlayCanisOnlineMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr);
			PlayCanisOnlineMatch.NativeFieldInfoPtr_gameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, "gameSession");
			PlayCanisOnlineMatch.NativeFieldInfoPtr_isRejoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, "isRejoin");
			PlayCanisOnlineMatch.NativeFieldInfoPtr_playerSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, "playerSession");
			PlayCanisOnlineMatch.NativeFieldInfoPtr__gamePropertiesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, "_gamePropertiesDict");
			PlayCanisOnlineMatch.NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668371);
			PlayCanisOnlineMatch.NativeMethodInfoPtr__ctor_Public_Void_DWDGameSession_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668372);
			PlayCanisOnlineMatch.NativeMethodInfoPtr__ctor_Public_Void_DWDPlayerSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668373);
			PlayCanisOnlineMatch.NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668374);
			PlayCanisOnlineMatch.NativeMethodInfoPtr_get_gamePropertiesDict_Private_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668375);
			PlayCanisOnlineMatch.NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668376);
			PlayCanisOnlineMatch.NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668377);
			PlayCanisOnlineMatch.NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668378);
			PlayCanisOnlineMatch.NativeMethodInfoPtr_GetServerEndpoint_Private_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668379);
			PlayCanisOnlineMatch.NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668380);
			PlayCanisOnlineMatch.NativeMethodInfoPtr_LogContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668381);
			PlayCanisOnlineMatch.NativeMethodInfoPtr__establishMatchContext_b__7_1_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668382);
			PlayCanisOnlineMatch.NativeMethodInfoPtr__setupSessionRelay_b__13_1_Private_Object_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668383);
			PlayCanisOnlineMatch.NativeMethodInfoPtr__setupSessionRelay_b__13_2_Private_Object_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668384);
			PlayCanisOnlineMatch.NativeMethodInfoPtr__setupSessionRelay_b__13_3_Private_Object_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, 100668385);
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00084124 File Offset: 0x00082324
		public unsafe override GameID GameID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539887, XrefRangeEnd = 539889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayCanisOnlineMatch.NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00084170 File Offset: 0x00082370
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 539891, RefRangeEnd = 539906, XrefRangeStart = 539889, XrefRangeEnd = 539891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayCanisOnlineMatch(DWDGameSession gameSession, bool isRejoin)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameSession);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRejoin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr__ctor_Public_Void_DWDGameSession_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000841CC File Offset: 0x000823CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 539909, RefRangeEnd = 539910, XrefRangeStart = 539906, XrefRangeEnd = 539909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayCanisOnlineMatch(DWDPlayerSession playerSession)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr__ctor_Public_Void_DWDPlayerSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00084218 File Offset: 0x00082418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539910, XrefRangeEnd = 539915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator establishMatchContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayCanisOnlineMatch.NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00084264 File Offset: 0x00082464
		public unsafe Dictionary<string, string> gamePropertiesDict
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 539939, RefRangeEnd = 539942, XrefRangeStart = 539915, XrefRangeEnd = 539939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr_get_gamePropertiesDict_Private_get_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x000842A4 File Offset: 0x000824A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539942, XrefRangeEnd = 539967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComposition createGameData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayCanisOnlineMatch.NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x000842F0 File Offset: 0x000824F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539967, XrefRangeEnd = 539983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<DataComponent> createSpinnerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayCanisOnlineMatch.NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataComponent>>(intPtr3) : null;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0008433C File Offset: 0x0008253C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539983, XrefRangeEnd = 539988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator setupSessionRelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayCanisOnlineMatch.NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00084388 File Offset: 0x00082588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539988, XrefRangeEnd = 540002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetServerEndpoint(bool secure, string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref secure;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr_GetServerEndpoint_Private_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000843E0 File Offset: 0x000825E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540002, XrefRangeEnd = 540007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator handleLoadTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayCanisOnlineMatch.NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0008442C File Offset: 0x0008262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540007, XrefRangeEnd = 540049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr_LogContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00084460 File Offset: 0x00082660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540049, XrefRangeEnd = 540061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _establishMatchContext_b__7_1(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr__establishMatchContext_b__7_1_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x000844A4 File Offset: 0x000826A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540061, XrefRangeEnd = 540073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _setupSessionRelay_b__13_1(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr__setupSessionRelay_b__13_1_Private_Object_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x000844F4 File Offset: 0x000826F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540073, XrefRangeEnd = 540085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _setupSessionRelay_b__13_2(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr__setupSessionRelay_b__13_2_Private_Object_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00084544 File Offset: 0x00082744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540085, XrefRangeEnd = 540097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _setupSessionRelay_b__13_3(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.NativeMethodInfoPtr__setupSessionRelay_b__13_3_Private_Object_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x0001037E File Offset: 0x0000E57E
		public PlayCanisOnlineMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00084594 File Offset: 0x00082794
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x00010387 File Offset: 0x0000E587
		public unsafe DWDGameSession gameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch.NativeFieldInfoPtr_gameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch.NativeFieldInfoPtr_gameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x000845C4 File Offset: 0x000827C4
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x000103A6 File Offset: 0x0000E5A6
		public unsafe bool isRejoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch.NativeFieldInfoPtr_isRejoin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch.NativeFieldInfoPtr_isRejoin)) = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x000845EC File Offset: 0x000827EC
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x000103C1 File Offset: 0x0000E5C1
		public unsafe DWDPlayerSession playerSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch.NativeFieldInfoPtr_playerSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDPlayerSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch.NativeFieldInfoPtr_playerSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x0008461C File Offset: 0x0008281C
		// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x000103E0 File Offset: 0x0000E5E0
		public unsafe Dictionary<string, string> _gamePropertiesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch.NativeFieldInfoPtr__gamePropertiesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch.NativeFieldInfoPtr__gamePropertiesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr_gameSession;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeFieldInfoPtr_isRejoin;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeFieldInfoPtr_playerSession;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeFieldInfoPtr__gamePropertiesDict;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DWDGameSession_Boolean_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DWDPlayerSession_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_get_gamePropertiesDict_Private_get_Dictionary_2_String_String_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_GetServerEndpoint_Private_String_Boolean_String_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_LogContext_Private_Void_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr__establishMatchContext_b__7_1_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr__setupSessionRelay_b__13_1_Private_Object_Dictionary_2_String_String_0;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr__setupSessionRelay_b__13_2_Private_Object_Dictionary_2_String_String_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr__setupSessionRelay_b__13_3_Private_Object_Dictionary_2_String_String_0;

		// Token: 0x02000485 RID: 1157
		[ObfuscatedName("boardgames.match.commands.PlayCanisOnlineMatch+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060036B9 RID: 14009 RVA: 0x000CBFB0 File Offset: 0x000CA1B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr);
				PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr, "<>9");
				PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr, "<>9__7_0");
				PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr, "<>9__13_0");
				PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr, "<>9__13_4");
				PlayCanisOnlineMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr, 100668387);
				PlayCanisOnlineMatch.__c.NativeMethodInfoPtr__establishMatchContext_b__7_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr, 100668388);
				PlayCanisOnlineMatch.__c.NativeMethodInfoPtr__setupSessionRelay_b__13_0_Internal_Boolean_DWDGameProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr, 100668389);
				PlayCanisOnlineMatch.__c.NativeMethodInfoPtr__setupSessionRelay_b__13_4_Internal_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr, 100668390);
			}

			// Token: 0x060036BA RID: 14010 RVA: 0x000CC07C File Offset: 0x000CA27C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCanisOnlineMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036BB RID: 14011 RVA: 0x000CC0B8 File Offset: 0x000CA2B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539659, XrefRangeEnd = 539667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _establishMatchContext_b__7_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.__c.NativeMethodInfoPtr__establishMatchContext_b__7_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060036BC RID: 14012 RVA: 0x000CC0FC File Offset: 0x000CA2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539667, XrefRangeEnd = 539671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setupSessionRelay_b__13_0(DWDGameProperty gp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.__c.NativeMethodInfoPtr__setupSessionRelay_b__13_0_Internal_Boolean_DWDGameProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036BD RID: 14013 RVA: 0x000CC14C File Offset: 0x000CA34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539671, XrefRangeEnd = 539676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setupSessionRelay_b__13_4(DWDEvent m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch.__c.NativeMethodInfoPtr__setupSessionRelay_b__13_4_Internal_Boolean_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036BE RID: 14014 RVA: 0x0001C280 File Offset: 0x0001A480
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001016 RID: 4118
			// (get) Token: 0x060036BF RID: 14015 RVA: 0x000CC19C File Offset: 0x000CA39C
			// (set) Token: 0x060036C0 RID: 14016 RVA: 0x0001C289 File Offset: 0x0001A489
			public unsafe static PlayCanisOnlineMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayCanisOnlineMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001017 RID: 4119
			// (get) Token: 0x060036C1 RID: 14017 RVA: 0x000CC1C4 File Offset: 0x000CA3C4
			// (set) Token: 0x060036C2 RID: 14018 RVA: 0x0001C29B File Offset: 0x0001A49B
			public unsafe static Action<UnityWebRequest> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001018 RID: 4120
			// (get) Token: 0x060036C3 RID: 14019 RVA: 0x000CC1EC File Offset: 0x000CA3EC
			// (set) Token: 0x060036C4 RID: 14020 RVA: 0x0001C2AD File Offset: 0x0001A4AD
			public unsafe static Predicate<DWDGameProperty> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<DWDGameProperty>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001019 RID: 4121
			// (get) Token: 0x060036C5 RID: 14021 RVA: 0x000CC214 File Offset: 0x000CA414
			// (set) Token: 0x060036C6 RID: 14022 RVA: 0x0001C2BF File Offset: 0x0001A4BF
			public unsafe static Func<DWDEvent, bool> __9__13_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DWDEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayCanisOnlineMatch.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021AC RID: 8620
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040021AD RID: 8621
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040021AE RID: 8622
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040021AF RID: 8623
			private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

			// Token: 0x040021B0 RID: 8624
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021B1 RID: 8625
			private static readonly IntPtr NativeMethodInfoPtr__establishMatchContext_b__7_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x040021B2 RID: 8626
			private static readonly IntPtr NativeMethodInfoPtr__setupSessionRelay_b__13_0_Internal_Boolean_DWDGameProperty_0;

			// Token: 0x040021B3 RID: 8627
			private static readonly IntPtr NativeMethodInfoPtr__setupSessionRelay_b__13_4_Internal_Boolean_DWDEvent_0;
		}

		// Token: 0x02000486 RID: 1158
		[ObfuscatedName("boardgames.match.commands.PlayCanisOnlineMatch+<establishMatchContext>d__7")]
		public sealed class _establishMatchContext_d__7 : Object
		{
			// Token: 0x060036C7 RID: 14023 RVA: 0x000CC23C File Offset: 0x000CA43C
			// Note: this type is marked as 'beforefieldinit'.
			static _establishMatchContext_d__7()
			{
				Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, "<establishMatchContext>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr);
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, "<>1__state");
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, "<>2__current");
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, "<>4__this");
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr__joinGameURL_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, "<joinGameURL>5__2");
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr__requestCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, "<requestCommand>5__3");
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668391);
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668392);
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668393);
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668394);
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668395);
				PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668396);
			}

			// Token: 0x060036C8 RID: 14024 RVA: 0x000CC344 File Offset: 0x000CA544
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _establishMatchContext_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCanisOnlineMatch._establishMatchContext_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060036C9 RID: 14025 RVA: 0x000CC38C File Offset: 0x000CA58C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036CA RID: 14026 RVA: 0x000CC3C0 File Offset: 0x000CA5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539676, XrefRangeEnd = 539738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700101F RID: 4127
			// (get) Token: 0x060036CB RID: 14027 RVA: 0x000CC3FC File Offset: 0x000CA5FC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036CC RID: 14028 RVA: 0x000CC43C File Offset: 0x000CA63C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539738, XrefRangeEnd = 539743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001020 RID: 4128
			// (get) Token: 0x060036CD RID: 14029 RVA: 0x000CC470 File Offset: 0x000CA670
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036CE RID: 14030 RVA: 0x0001C2D1 File Offset: 0x0001A4D1
			public _establishMatchContext_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700101A RID: 4122
			// (get) Token: 0x060036CF RID: 14031 RVA: 0x000CC4B0 File Offset: 0x000CA6B0
			// (set) Token: 0x060036D0 RID: 14032 RVA: 0x0001C2DA File Offset: 0x0001A4DA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700101B RID: 4123
			// (get) Token: 0x060036D1 RID: 14033 RVA: 0x000CC4D8 File Offset: 0x000CA6D8
			// (set) Token: 0x060036D2 RID: 14034 RVA: 0x0001C2F5 File Offset: 0x0001A4F5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700101C RID: 4124
			// (get) Token: 0x060036D3 RID: 14035 RVA: 0x000CC508 File Offset: 0x000CA708
			// (set) Token: 0x060036D4 RID: 14036 RVA: 0x0001C314 File Offset: 0x0001A514
			public unsafe PlayCanisOnlineMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayCanisOnlineMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700101D RID: 4125
			// (get) Token: 0x060036D5 RID: 14037 RVA: 0x000CC538 File Offset: 0x000CA738
			// (set) Token: 0x060036D6 RID: 14038 RVA: 0x0001C333 File Offset: 0x0001A533
			public unsafe string _joinGameURL_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr__joinGameURL_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr__joinGameURL_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700101E RID: 4126
			// (get) Token: 0x060036D7 RID: 14039 RVA: 0x000CC560 File Offset: 0x000CA760
			// (set) Token: 0x060036D8 RID: 14040 RVA: 0x0001C352 File Offset: 0x0001A552
			public unsafe DwdWebRequestCommand _requestCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr__requestCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._establishMatchContext_d__7.NativeFieldInfoPtr__requestCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021B4 RID: 8628
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021B5 RID: 8629
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021B6 RID: 8630
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021B7 RID: 8631
			private static readonly IntPtr NativeFieldInfoPtr__joinGameURL_5__2;

			// Token: 0x040021B8 RID: 8632
			private static readonly IntPtr NativeFieldInfoPtr__requestCommand_5__3;

			// Token: 0x040021B9 RID: 8633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040021BA RID: 8634
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021BB RID: 8635
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040021BC RID: 8636
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021BD RID: 8637
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021BE RID: 8638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000487 RID: 1159
		[ObfuscatedName("boardgames.match.commands.PlayCanisOnlineMatch+<handleLoadTimeout>d__15")]
		public sealed class _handleLoadTimeout_d__15 : Object
		{
			// Token: 0x060036D9 RID: 14041 RVA: 0x000CC590 File Offset: 0x000CA790
			// Note: this type is marked as 'beforefieldinit'.
			static _handleLoadTimeout_d__15()
			{
				Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, "<handleLoadTimeout>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr);
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, "<>1__state");
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, "<>2__current");
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, "<>4__this");
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr__checkActiveCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, "<checkActiveCommand>5__2");
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, 100668397);
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, 100668398);
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, 100668399);
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, 100668400);
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, 100668401);
				PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr, 100668402);
			}

			// Token: 0x060036DA RID: 14042 RVA: 0x000CC684 File Offset: 0x000CA884
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _handleLoadTimeout_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCanisOnlineMatch._handleLoadTimeout_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060036DB RID: 14043 RVA: 0x000CC6CC File Offset: 0x000CA8CC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036DC RID: 14044 RVA: 0x000CC700 File Offset: 0x000CA900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539743, XrefRangeEnd = 539761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001025 RID: 4133
			// (get) Token: 0x060036DD RID: 14045 RVA: 0x000CC73C File Offset: 0x000CA93C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036DE RID: 14046 RVA: 0x000CC77C File Offset: 0x000CA97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539761, XrefRangeEnd = 539766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001026 RID: 4134
			// (get) Token: 0x060036DF RID: 14047 RVA: 0x000CC7B0 File Offset: 0x000CA9B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036E0 RID: 14048 RVA: 0x0001C371 File Offset: 0x0001A571
			public _handleLoadTimeout_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001021 RID: 4129
			// (get) Token: 0x060036E1 RID: 14049 RVA: 0x000CC7F0 File Offset: 0x000CA9F0
			// (set) Token: 0x060036E2 RID: 14050 RVA: 0x0001C37A File Offset: 0x0001A57A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001022 RID: 4130
			// (get) Token: 0x060036E3 RID: 14051 RVA: 0x000CC818 File Offset: 0x000CAA18
			// (set) Token: 0x060036E4 RID: 14052 RVA: 0x0001C395 File Offset: 0x0001A595
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001023 RID: 4131
			// (get) Token: 0x060036E5 RID: 14053 RVA: 0x000CC848 File Offset: 0x000CAA48
			// (set) Token: 0x060036E6 RID: 14054 RVA: 0x0001C3B4 File Offset: 0x0001A5B4
			public unsafe PlayCanisOnlineMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayCanisOnlineMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001024 RID: 4132
			// (get) Token: 0x060036E7 RID: 14055 RVA: 0x000CC878 File Offset: 0x000CAA78
			// (set) Token: 0x060036E8 RID: 14056 RVA: 0x0001C3D3 File Offset: 0x0001A5D3
			public unsafe CheckActiveInGame _checkActiveCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr__checkActiveCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckActiveInGame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._handleLoadTimeout_d__15.NativeFieldInfoPtr__checkActiveCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021BF RID: 8639
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021C0 RID: 8640
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021C1 RID: 8641
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021C2 RID: 8642
			private static readonly IntPtr NativeFieldInfoPtr__checkActiveCommand_5__2;

			// Token: 0x040021C3 RID: 8643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040021C4 RID: 8644
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021C5 RID: 8645
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040021C6 RID: 8646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021C7 RID: 8647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021C8 RID: 8648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000488 RID: 1160
		[ObfuscatedName("boardgames.match.commands.PlayCanisOnlineMatch+<setupSessionRelay>d__13")]
		public sealed class _setupSessionRelay_d__13 : Object
		{
			// Token: 0x060036E9 RID: 14057 RVA: 0x000CC8A8 File Offset: 0x000CAAA8
			// Note: this type is marked as 'beforefieldinit'.
			static _setupSessionRelay_d__13()
			{
				Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCanisOnlineMatch>.NativeClassPtr, "<setupSessionRelay>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr);
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, "<>1__state");
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, "<>2__current");
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, "<>4__this");
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr__network_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, "<network>5__2");
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, 100668403);
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, 100668404);
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, 100668405);
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, 100668406);
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, 100668407);
				PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr, 100668408);
			}

			// Token: 0x060036EA RID: 14058 RVA: 0x000CC99C File Offset: 0x000CAB9C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _setupSessionRelay_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCanisOnlineMatch._setupSessionRelay_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060036EB RID: 14059 RVA: 0x000CC9E4 File Offset: 0x000CABE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036EC RID: 14060 RVA: 0x000CCA18 File Offset: 0x000CAC18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539766, XrefRangeEnd = 539882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700102B RID: 4139
			// (get) Token: 0x060036ED RID: 14061 RVA: 0x000CCA54 File Offset: 0x000CAC54
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036EE RID: 14062 RVA: 0x000CCA94 File Offset: 0x000CAC94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539882, XrefRangeEnd = 539887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700102C RID: 4140
			// (get) Token: 0x060036EF RID: 14063 RVA: 0x000CCAC8 File Offset: 0x000CACC8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036F0 RID: 14064 RVA: 0x0001C3F2 File Offset: 0x0001A5F2
			public _setupSessionRelay_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001027 RID: 4135
			// (get) Token: 0x060036F1 RID: 14065 RVA: 0x000CCB08 File Offset: 0x000CAD08
			// (set) Token: 0x060036F2 RID: 14066 RVA: 0x0001C3FB File Offset: 0x0001A5FB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001028 RID: 4136
			// (get) Token: 0x060036F3 RID: 14067 RVA: 0x000CCB30 File Offset: 0x000CAD30
			// (set) Token: 0x060036F4 RID: 14068 RVA: 0x0001C416 File Offset: 0x0001A616
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001029 RID: 4137
			// (get) Token: 0x060036F5 RID: 14069 RVA: 0x000CCB60 File Offset: 0x000CAD60
			// (set) Token: 0x060036F6 RID: 14070 RVA: 0x0001C435 File Offset: 0x0001A635
			public unsafe PlayCanisOnlineMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayCanisOnlineMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700102A RID: 4138
			// (get) Token: 0x060036F7 RID: 14071 RVA: 0x000CCB90 File Offset: 0x000CAD90
			// (set) Token: 0x060036F8 RID: 14072 RVA: 0x0001C454 File Offset: 0x0001A654
			public unsafe CanisNetworkState _network_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr__network_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisNetworkState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayCanisOnlineMatch._setupSessionRelay_d__13.NativeFieldInfoPtr__network_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021C9 RID: 8649
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021CA RID: 8650
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021CB RID: 8651
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021CC RID: 8652
			private static readonly IntPtr NativeFieldInfoPtr__network_5__2;

			// Token: 0x040021CD RID: 8653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040021CE RID: 8654
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021CF RID: 8655
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040021D0 RID: 8656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021D1 RID: 8657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021D2 RID: 8658
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
