using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002C7 RID: 711
	public sealed class ChannelServices : Object
	{
		// Token: 0x06002CEE RID: 11502 RVA: 0x000EAD9C File Offset: 0x000E8F9C
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelServices()
		{
			Il2CppClassPointerStore<ChannelServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "ChannelServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr);
			ChannelServices.NativeFieldInfoPtr_registeredChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "registeredChannels");
			ChannelServices.NativeFieldInfoPtr_delayedClientChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "delayedClientChannels");
			ChannelServices.NativeFieldInfoPtr__crossContextSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "_crossContextSink");
			ChannelServices.NativeFieldInfoPtr_CrossContextUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "CrossContextUrl");
			ChannelServices.NativeFieldInfoPtr_oldStartModeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "oldStartModeTypes");
			ChannelServices.NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670527);
			ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670528);
			ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670529);
			ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670530);
			ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670531);
			ChannelServices.NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670532);
			ChannelServices.NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670533);
			ChannelServices.NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670534);
			ChannelServices.NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670535);
			ChannelServices.NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670536);
			ChannelServices.NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670537);
			ChannelServices.NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670538);
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000EAF20 File Offset: 0x000E9120
		public unsafe static CrossContextChannel CrossContextChannel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381110, XrefRangeEnd = 1381114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CrossContextChannel>(intPtr3) : null;
			}
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x000EAF54 File Offset: 0x000E9154
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1381174, RefRangeEnd = 1381177, XrefRangeStart = 1381114, XrefRangeEnd = 1381174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink CreateClientChannelSinkChain(string url, Object remoteChannelData, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x000EAFC8 File Offset: 0x000E91C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1381186, RefRangeEnd = 1381188, XrefRangeStart = 1381177, XrefRangeEnd = 1381186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, Il2CppReferenceArray<Object> channelDataArray, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channelDataArray);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x000EB04C File Offset: 0x000E924C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381192, RefRangeEnd = 1381193, XrefRangeStart = 1381188, XrefRangeEnd = 1381192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannel(IChannel chnl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chnl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x000EB084 File Offset: 0x000E9284
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1381249, RefRangeEnd = 1381252, XrefRangeStart = 1381193, XrefRangeEnd = 1381249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannel(IChannel chnl, bool ensureSecurity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chnl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ensureSecurity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x000EB0C8 File Offset: 0x000E92C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381403, RefRangeEnd = 1381404, XrefRangeStart = 1381252, XrefRangeEnd = 1381403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannelConfig(ChannelData channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000EB100 File Offset: 0x000E9300
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1381421, RefRangeEnd = 1381423, XrefRangeStart = 1381404, XrefRangeEnd = 1381421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateProvider(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x000EB144 File Offset: 0x000E9344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381477, RefRangeEnd = 1381478, XrefRangeStart = 1381423, XrefRangeEnd = 1381477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage SyncDispatchMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000EB188 File Offset: 0x000E9388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381497, RefRangeEnd = 1381498, XrefRangeStart = 1381478, XrefRangeEnd = 1381497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReturnMessage CheckIncomingMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x000EB1CC File Offset: 0x000E93CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381524, RefRangeEnd = 1381525, XrefRangeStart = 1381498, XrefRangeEnd = 1381524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x000EB224 File Offset: 0x000E9424
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLocalCall(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000EB268 File Offset: 0x000E9468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1381566, RefRangeEnd = 1381568, XrefRangeStart = 1381525, XrefRangeEnd = 1381566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCurrentChannelInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x0000F131 File Offset: 0x0000D331
		public ChannelServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x000EB29C File Offset: 0x000E949C
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x0000F13A File Offset: 0x0000D33A
		public unsafe static ArrayList registeredChannels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_registeredChannels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_registeredChannels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x000EB2C4 File Offset: 0x000E94C4
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x0000F14C File Offset: 0x0000D34C
		public unsafe static ArrayList delayedClientChannels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_delayedClientChannels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_delayedClientChannels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x000EB2EC File Offset: 0x000E94EC
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x0000F15E File Offset: 0x0000D35E
		public unsafe static CrossContextChannel _crossContextSink
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr__crossContextSink, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrossContextChannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr__crossContextSink, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000EB314 File Offset: 0x000E9514
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x0000F170 File Offset: 0x0000D370
		public unsafe static string CrossContextUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_CrossContextUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_CrossContextUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000EB334 File Offset: 0x000E9534
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x0000F182 File Offset: 0x0000D382
		public unsafe static IList oldStartModeTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_oldStartModeTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_oldStartModeTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeFieldInfoPtr_registeredChannels;

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeFieldInfoPtr_delayedClientChannels;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeFieldInfoPtr__crossContextSink;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeFieldInfoPtr_CrossContextUrl;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeFieldInfoPtr_oldStartModeTypes;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0;

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0;

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0;

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0;

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0;
	}
}
