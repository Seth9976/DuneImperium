using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A7 RID: 167
	public class SteamNetworkingUtils : SteamSharedClass<SteamNetworkingUtils>
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x000486C4 File Offset: 0x000468C4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingUtils()
		{
			Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamNetworkingUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr);
			SteamNetworkingUtils.NativeFieldInfoPtr_OnDebugOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, "OnDebugOutput");
			SteamNetworkingUtils.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, "<Status>k__BackingField");
			SteamNetworkingUtils.NativeFieldInfoPtr__debugLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, "_debugLevel");
			SteamNetworkingUtils.NativeFieldInfoPtr__debugFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, "_debugFunc");
			SteamNetworkingUtils.NativeFieldInfoPtr_debugMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, "debugMessages");
			SteamNetworkingUtils.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworkingUtils_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665722);
			SteamNetworkingUtils.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665723);
			SteamNetworkingUtils.NativeMethodInfoPtr_InstallCallbacks_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665724);
			SteamNetworkingUtils.NativeMethodInfoPtr_add_OnDebugOutput_Public_Static_add_Void_Action_2_NetDebugOutput_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665725);
			SteamNetworkingUtils.NativeMethodInfoPtr_remove_OnDebugOutput_Public_Static_rem_Void_Action_2_NetDebugOutput_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665726);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_Status_Public_Static_get_SteamNetworkingAvailability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665727);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_Status_Private_Static_set_Void_SteamNetworkingAvailability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665728);
			SteamNetworkingUtils.NativeMethodInfoPtr_InitRelayNetworkAccess_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665729);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_LocalPingLocation_Public_Static_get_Nullable_1_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665730);
			SteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTo_Public_Static_Int32_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665731);
			SteamNetworkingUtils.NativeMethodInfoPtr_WaitForPingDataAsync_Public_Static_Task_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665732);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_LocalTimestamp_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665733);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_FakeSendPacketLoss_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665734);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_FakeSendPacketLoss_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665735);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_FakeRecvPacketLoss_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665736);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_FakeRecvPacketLoss_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665737);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_FakeSendPacketLag_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665738);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_FakeSendPacketLag_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665739);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_FakeRecvPacketLag_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665740);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_FakeRecvPacketLag_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665741);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_ConnectionTimeout_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665742);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_ConnectionTimeout_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665743);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_Timeout_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665744);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_Timeout_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665745);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_SendBufferSize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665746);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_SendBufferSize_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665747);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_AllowWithoutAuth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665748);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_AllowWithoutAuth_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665749);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_Unencrypted_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665750);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_Unencrypted_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665751);
			SteamNetworkingUtils.NativeMethodInfoPtr_get_DebugLevel_Public_Static_get_NetDebugOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665752);
			SteamNetworkingUtils.NativeMethodInfoPtr_set_DebugLevel_Public_Static_set_Void_NetDebugOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665753);
			SteamNetworkingUtils.NativeMethodInfoPtr_OnDebugMessage_Private_Static_Void_NetDebugOutput_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665754);
			SteamNetworkingUtils.NativeMethodInfoPtr_LogDebugMessage_Internal_Static_Void_NetDebugOutput_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665755);
			SteamNetworkingUtils.NativeMethodInfoPtr_OutputDebugMessages_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665756);
			SteamNetworkingUtils.NativeMethodInfoPtr_AllocateMessage_Internal_Static_ptr_NetMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665757);
			SteamNetworkingUtils.NativeMethodInfoPtr_SetConfigInt_Internal_Static_Boolean_NetConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665758);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetConfigInt_Internal_Static_Int32_NetConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665759);
			SteamNetworkingUtils.NativeMethodInfoPtr_SetConfigFloat_Internal_Static_Boolean_NetConfig_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665760);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetConfigFloat_Internal_Static_Single_NetConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665761);
			SteamNetworkingUtils.NativeMethodInfoPtr_SetConfigString_Internal_Static_Boolean_NetConfig_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665762);
			SteamNetworkingUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100665763);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00048AA0 File Offset: 0x00046CA0
		public unsafe static ISteamNetworkingUtils Internal
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 941368, RefRangeEnd = 941387, XrefRangeStart = 941364, XrefRangeEnd = 941368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworkingUtils_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamNetworkingUtils>(intPtr3) : null;
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00048AD4 File Offset: 0x00046CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941387, XrefRangeEnd = 941415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamNetworkingUtils.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00048B20 File Offset: 0x00046D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941415, XrefRangeEnd = 941436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallCallbacks(bool server)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_InstallCallbacks_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00048B54 File Offset: 0x00046D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941436, XrefRangeEnd = 941449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnDebugOutput(Action<NetDebugOutput, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_add_OnDebugOutput_Public_Static_add_Void_Action_2_NetDebugOutput_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00048B8C File Offset: 0x00046D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941449, XrefRangeEnd = 941462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnDebugOutput(Action<NetDebugOutput, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_remove_OnDebugOutput_Public_Static_rem_Void_Action_2_NetDebugOutput_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00048BC4 File Offset: 0x00046DC4
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00048BF4 File Offset: 0x00046DF4
		public unsafe static SteamNetworkingAvailability Status
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941462, XrefRangeEnd = 941466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_Status_Public_Static_get_SteamNetworkingAvailability_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941466, XrefRangeEnd = 941470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_Status_Private_Static_set_Void_SteamNetworkingAvailability_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00048C28 File Offset: 0x00046E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941470, XrefRangeEnd = 941476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitRelayNetworkAccess()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_InitRelayNetworkAccess_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00048C50 File Offset: 0x00046E50
		public unsafe static Nullable<NetPingLocation> LocalPingLocation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941476, XrefRangeEnd = 941486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_LocalPingLocation_Public_Static_get_Nullable_1_NetPingLocation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<NetPingLocation>(intPtr);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00048C7C File Offset: 0x00046E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941486, XrefRangeEnd = 941491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int EstimatePingTo(NetPingLocation target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTo_Public_Static_Int32_NetPingLocation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00048CBC File Offset: 0x00046EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941491, XrefRangeEnd = 941500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WaitForPingDataAsync(float maxAgeInSeconds = 300f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxAgeInSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_WaitForPingDataAsync_Public_Static_Task_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00048CFC File Offset: 0x00046EFC
		public unsafe static long LocalTimestamp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941500, XrefRangeEnd = 941506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_LocalTimestamp_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00048D2C File Offset: 0x00046F2C
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00048D5C File Offset: 0x00046F5C
		public unsafe static float FakeSendPacketLoss
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941506, XrefRangeEnd = 941510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_FakeSendPacketLoss_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941510, XrefRangeEnd = 941514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_FakeSendPacketLoss_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00048D90 File Offset: 0x00046F90
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00048DC0 File Offset: 0x00046FC0
		public unsafe static float FakeRecvPacketLoss
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941514, XrefRangeEnd = 941518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_FakeRecvPacketLoss_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941518, XrefRangeEnd = 941522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_FakeRecvPacketLoss_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00048DF4 File Offset: 0x00046FF4
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00048E24 File Offset: 0x00047024
		public unsafe static float FakeSendPacketLag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941522, XrefRangeEnd = 941526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_FakeSendPacketLag_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941526, XrefRangeEnd = 941530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_FakeSendPacketLag_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00048E58 File Offset: 0x00047058
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00048E88 File Offset: 0x00047088
		public unsafe static float FakeRecvPacketLag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941530, XrefRangeEnd = 941534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_FakeRecvPacketLag_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941534, XrefRangeEnd = 941538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_FakeRecvPacketLag_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00048EBC File Offset: 0x000470BC
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00048EEC File Offset: 0x000470EC
		public unsafe static int ConnectionTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941538, XrefRangeEnd = 941542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_ConnectionTimeout_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941542, XrefRangeEnd = 941546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_ConnectionTimeout_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00048F20 File Offset: 0x00047120
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00048F50 File Offset: 0x00047150
		public unsafe static int Timeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941546, XrefRangeEnd = 941550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_Timeout_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941550, XrefRangeEnd = 941554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_Timeout_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00048F84 File Offset: 0x00047184
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00048FB4 File Offset: 0x000471B4
		public unsafe static int SendBufferSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941554, XrefRangeEnd = 941558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_SendBufferSize_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941558, XrefRangeEnd = 941562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_SendBufferSize_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00048FE8 File Offset: 0x000471E8
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00049018 File Offset: 0x00047218
		public unsafe static int AllowWithoutAuth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941562, XrefRangeEnd = 941566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_AllowWithoutAuth_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941566, XrefRangeEnd = 941570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_AllowWithoutAuth_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0004904C File Offset: 0x0004724C
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x0004907C File Offset: 0x0004727C
		public unsafe static int Unencrypted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941570, XrefRangeEnd = 941574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_Unencrypted_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941574, XrefRangeEnd = 941578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_Unencrypted_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000490B0 File Offset: 0x000472B0
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x000490E0 File Offset: 0x000472E0
		public unsafe static NetDebugOutput DebugLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941578, XrefRangeEnd = 941582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_get_DebugLevel_Public_Static_get_NetDebugOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941582, XrefRangeEnd = 941603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_set_DebugLevel_Public_Static_set_Void_NetDebugOutput_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00049114 File Offset: 0x00047314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941603, XrefRangeEnd = 941615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnDebugMessage(NetDebugOutput nType, IntPtr str)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_OnDebugMessage_Private_Static_Void_NetDebugOutput_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00049154 File Offset: 0x00047354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 941623, RefRangeEnd = 941625, XrefRangeStart = 941615, XrefRangeEnd = 941623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogDebugMessage(NetDebugOutput type, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_LogDebugMessage_Internal_Static_Void_NetDebugOutput_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00049198 File Offset: 0x00047398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 941642, RefRangeEnd = 941643, XrefRangeStart = 941625, XrefRangeEnd = 941642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OutputDebugMessages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_OutputDebugMessages_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000491C0 File Offset: 0x000473C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 941649, RefRangeEnd = 941650, XrefRangeStart = 941643, XrefRangeEnd = 941649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetMsg* AllocateMessage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_AllocateMessage_Internal_Static_ptr_NetMsg_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000491E8 File Offset: 0x000473E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 941656, RefRangeEnd = 941661, XrefRangeStart = 941650, XrefRangeEnd = 941656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetConfigInt(NetConfig type, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SetConfigInt_Internal_Static_Boolean_NetConfig_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00049234 File Offset: 0x00047434
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 941668, RefRangeEnd = 941673, XrefRangeStart = 941661, XrefRangeEnd = 941668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetConfigInt(NetConfig type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetConfigInt_Internal_Static_Int32_NetConfig_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00049274 File Offset: 0x00047474
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 941679, RefRangeEnd = 941683, XrefRangeStart = 941673, XrefRangeEnd = 941679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetConfigFloat(NetConfig type, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SetConfigFloat_Internal_Static_Boolean_NetConfig_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000492C0 File Offset: 0x000474C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 941690, RefRangeEnd = 941694, XrefRangeStart = 941683, XrefRangeEnd = 941690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConfigFloat(NetConfig type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetConfigFloat_Internal_Static_Single_NetConfig_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00049300 File Offset: 0x00047500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941694, XrefRangeEnd = 941702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetConfigString(NetConfig type, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SetConfigString_Internal_Static_Boolean_NetConfig_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00049350 File Offset: 0x00047550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941702, XrefRangeEnd = 941705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002A14 File Offset: 0x00000C14
		public SteamNetworkingUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0004938C File Offset: 0x0004758C
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00002A1D File Offset: 0x00000C1D
		public unsafe static Action<NetDebugOutput, string> OnDebugOutput
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingUtils.NativeFieldInfoPtr_OnDebugOutput, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NetDebugOutput, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingUtils.NativeFieldInfoPtr_OnDebugOutput, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x000493B4 File Offset: 0x000475B4
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00002A2F File Offset: 0x00000C2F
		public unsafe static SteamNetworkingAvailability _Status_k__BackingField
		{
			get
			{
				SteamNetworkingAvailability steamNetworkingAvailability;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingUtils.NativeFieldInfoPtr__Status_k__BackingField, (void*)(&steamNetworkingAvailability));
				return steamNetworkingAvailability;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingUtils.NativeFieldInfoPtr__Status_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x000493D0 File Offset: 0x000475D0
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00002A3D File Offset: 0x00000C3D
		public unsafe static NetDebugOutput _debugLevel
		{
			get
			{
				NetDebugOutput netDebugOutput;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingUtils.NativeFieldInfoPtr__debugLevel, (void*)(&netDebugOutput));
				return netDebugOutput;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingUtils.NativeFieldInfoPtr__debugLevel, (void*)(&value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000493EC File Offset: 0x000475EC
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00002A4B File Offset: 0x00000C4B
		public unsafe static NetDebugFunc _debugFunc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingUtils.NativeFieldInfoPtr__debugFunc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetDebugFunc>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingUtils.NativeFieldInfoPtr__debugFunc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00049414 File Offset: 0x00047614
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00002A5D File Offset: 0x00000C5D
		public unsafe static ConcurrentQueue<SteamNetworkingUtils.DebugMessage> debugMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingUtils.NativeFieldInfoPtr_debugMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<SteamNetworkingUtils.DebugMessage>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingUtils.NativeFieldInfoPtr_debugMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeFieldInfoPtr_OnDebugOutput;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr__debugLevel;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr__debugFunc;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeFieldInfoPtr_debugMessages;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworkingUtils_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_InstallCallbacks_Private_Static_Void_Boolean_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDebugOutput_Public_Static_add_Void_Action_2_NetDebugOutput_String_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDebugOutput_Public_Static_rem_Void_Action_2_NetDebugOutput_String_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Static_get_SteamNetworkingAvailability_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_Static_set_Void_SteamNetworkingAvailability_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_InitRelayNetworkAccess_Public_Static_Void_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPingLocation_Public_Static_get_Nullable_1_NetPingLocation_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_EstimatePingTo_Public_Static_Int32_NetPingLocation_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_WaitForPingDataAsync_Public_Static_Task_Single_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalTimestamp_Public_Static_get_Int64_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_get_FakeSendPacketLoss_Public_Static_get_Single_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_set_FakeSendPacketLoss_Public_Static_set_Void_Single_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_get_FakeRecvPacketLoss_Public_Static_get_Single_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_set_FakeRecvPacketLoss_Public_Static_set_Void_Single_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_get_FakeSendPacketLag_Public_Static_get_Single_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_set_FakeSendPacketLag_Public_Static_set_Void_Single_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_get_FakeRecvPacketLag_Public_Static_get_Single_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_set_FakeRecvPacketLag_Public_Static_set_Void_Single_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionTimeout_Public_Static_get_Int32_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionTimeout_Public_Static_set_Void_Int32_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Static_get_Int32_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_set_Timeout_Public_Static_set_Void_Int32_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_get_SendBufferSize_Public_Static_get_Int32_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_set_SendBufferSize_Public_Static_set_Void_Int32_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowWithoutAuth_Public_Static_get_Int32_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowWithoutAuth_Public_Static_set_Void_Int32_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_get_Unencrypted_Public_Static_get_Int32_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_set_Unencrypted_Public_Static_set_Void_Int32_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugLevel_Public_Static_get_NetDebugOutput_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugLevel_Public_Static_set_Void_NetDebugOutput_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_OnDebugMessage_Private_Static_Void_NetDebugOutput_IntPtr_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_LogDebugMessage_Internal_Static_Void_NetDebugOutput_String_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_OutputDebugMessages_Internal_Static_Void_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_AllocateMessage_Internal_Static_ptr_NetMsg_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigInt_Internal_Static_Boolean_NetConfig_Int32_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigInt_Internal_Static_Int32_NetConfig_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigFloat_Internal_Static_Boolean_NetConfig_Single_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigFloat_Internal_Static_Single_NetConfig_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigString_Internal_Static_Boolean_NetConfig_String_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000249 RID: 585
		public sealed class DebugMessage : ValueType
		{
			// Token: 0x06001D87 RID: 7559 RVA: 0x000878DC File Offset: 0x00085ADC
			// Note: this type is marked as 'beforefieldinit'.
			static DebugMessage()
			{
				Il2CppClassPointerStore<SteamNetworkingUtils.DebugMessage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, "DebugMessage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingUtils.DebugMessage>.NativeClassPtr);
				SteamNetworkingUtils.DebugMessage.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils.DebugMessage>.NativeClassPtr, "Type");
				SteamNetworkingUtils.DebugMessage.NativeFieldInfoPtr_Msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils.DebugMessage>.NativeClassPtr, "Msg");
			}

			// Token: 0x06001D88 RID: 7560 RVA: 0x0000A775 File Offset: 0x00008975
			public DebugMessage(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D89 RID: 7561 RVA: 0x0000A77E File Offset: 0x0000897E
			public DebugMessage()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingUtils.DebugMessage>.NativeClassPtr))
			{
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00087930 File Offset: 0x00085B30
			// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0000A790 File Offset: 0x00008990
			public unsafe NetDebugOutput Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils.DebugMessage.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils.DebugMessage.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00087958 File Offset: 0x00085B58
			// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0000A7AB File Offset: 0x000089AB
			public unsafe string Msg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils.DebugMessage.NativeFieldInfoPtr_Msg);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils.DebugMessage.NativeFieldInfoPtr_Msg), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400213B RID: 8507
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x0400213C RID: 8508
			private static readonly IntPtr NativeFieldInfoPtr_Msg;
		}

		// Token: 0x0200024A RID: 586
		[ObfuscatedName("Steamworks.SteamNetworkingUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D8E RID: 7566 RVA: 0x00087980 File Offset: 0x00085B80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamNetworkingUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingUtils.__c>.NativeClassPtr);
				SteamNetworkingUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils.__c>.NativeClassPtr, "<>9");
				SteamNetworkingUtils.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils.__c>.NativeClassPtr, "<>9__3_0");
				SteamNetworkingUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils.__c>.NativeClassPtr, 100665766);
				SteamNetworkingUtils.__c.NativeMethodInfoPtr__InstallCallbacks_b__3_0_Internal_Void_SteamRelayNetworkStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils.__c>.NativeClassPtr, 100665767);
			}

			// Token: 0x06001D8F RID: 7567 RVA: 0x000879FC File Offset: 0x00085BFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D90 RID: 7568 RVA: 0x00087A38 File Offset: 0x00085C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941322, XrefRangeEnd = 941330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallCallbacks_b__3_0(SteamRelayNetworkStatus_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.__c.NativeMethodInfoPtr__InstallCallbacks_b__3_0_Internal_Void_SteamRelayNetworkStatus_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D91 RID: 7569 RVA: 0x0000A7CA File Offset: 0x000089CA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00087A80 File Offset: 0x00085C80
			// (set) Token: 0x06001D93 RID: 7571 RVA: 0x0000A7D3 File Offset: 0x000089D3
			public unsafe static SteamNetworkingUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamNetworkingUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamNetworkingUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamNetworkingUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00087AA8 File Offset: 0x00085CA8
			// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0000A7E5 File Offset: 0x000089E5
			public unsafe static Action<SteamRelayNetworkStatus_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamNetworkingUtils.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamRelayNetworkStatus_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamNetworkingUtils.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400213D RID: 8509
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400213E RID: 8510
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400213F RID: 8511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002140 RID: 8512
			private static readonly IntPtr NativeMethodInfoPtr__InstallCallbacks_b__3_0_Internal_Void_SteamRelayNetworkStatus_t_0;
		}

		// Token: 0x0200024B RID: 587
		[ObfuscatedName("Steamworks.SteamNetworkingUtils+<WaitForPingDataAsync>d__15")]
		public sealed class _WaitForPingDataAsync_d__15 : ValueType
		{
			// Token: 0x06001D96 RID: 7574 RVA: 0x00087AD0 File Offset: 0x00085CD0
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForPingDataAsync_d__15()
			{
				Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, "<WaitForPingDataAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr);
				SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr, "<>1__state");
				SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr, "<>t__builder");
				SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr_maxAgeInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr, "maxAgeInSeconds");
				SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr__status_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr, "<status>5__2");
				SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr, "<>u__1");
				SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr, 100665768);
				SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr, 100665769);
			}

			// Token: 0x06001D97 RID: 7575 RVA: 0x00087B88 File Offset: 0x00085D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941330, XrefRangeEnd = 941360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D98 RID: 7576 RVA: 0x00087BC0 File Offset: 0x00085DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941360, XrefRangeEnd = 941364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D99 RID: 7577 RVA: 0x0000A7F7 File Offset: 0x000089F7
			public _WaitForPingDataAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D9A RID: 7578 RVA: 0x0000A800 File Offset: 0x00008A00
			public _WaitForPingDataAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingUtils._WaitForPingDataAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00087C08 File Offset: 0x00085E08
			// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0000A812 File Offset: 0x00008A12
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x06001D9D RID: 7581 RVA: 0x00087C30 File Offset: 0x00085E30
			// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0000A82D File Offset: 0x00008A2D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00087C60 File Offset: 0x00085E60
			// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0000A85B File Offset: 0x00008A5B
			public unsafe float maxAgeInSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr_maxAgeInSeconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr_maxAgeInSeconds)) = value;
				}
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x00087C88 File Offset: 0x00085E88
			// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0000A876 File Offset: 0x00008A76
			public SteamRelayNetworkStatus_t _status_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr__status_5__2);
					return new SteamRelayNetworkStatus_t(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr__status_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00087CB8 File Offset: 0x00085EB8
			// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x0000A8A4 File Offset: 0x00008AA4
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingUtils._WaitForPingDataAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002141 RID: 8513
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002142 RID: 8514
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002143 RID: 8515
			private static readonly IntPtr NativeFieldInfoPtr_maxAgeInSeconds;

			// Token: 0x04002144 RID: 8516
			private static readonly IntPtr NativeFieldInfoPtr__status_5__2;

			// Token: 0x04002145 RID: 8517
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002146 RID: 8518
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002147 RID: 8519
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
