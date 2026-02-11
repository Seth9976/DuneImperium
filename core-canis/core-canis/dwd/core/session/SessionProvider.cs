using System;
using Canis.json.events;
using Canis.utils.ids;
using dwd.core.data.providers;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Reflection;
using UnityEngine.SceneManagement;

namespace dwd.core.session
{
	// Token: 0x020000F7 RID: 247
	public class SessionProvider : DataProvider
	{
		// Token: 0x06000E80 RID: 3712 RVA: 0x0004D248 File Offset: 0x0004B448
		// Note: this type is marked as 'beforefieldinit'.
		static SessionProvider()
		{
			Il2CppClassPointerStore<SessionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.session", "SessionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr);
			SessionProvider.NativeFieldInfoPtr_eventHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, "eventHandlers");
			SessionProvider.NativeMethodInfoPtr_Logout_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665395);
			SessionProvider.NativeMethodInfoPtr_Terminate_Public_Virtual_New_Void_DisconnectReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665396);
			SessionProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665397);
			SessionProvider.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665398);
			SessionProvider.NativeMethodInfoPtr_DispatchOfflineMessage_Public_Void_DWDEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665399);
			SessionProvider.NativeMethodInfoPtr_dispatch_Protected_Void_DWDEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665400);
			SessionProvider.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665401);
			SessionProvider.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665402);
			SessionProvider.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665403);
			SessionProvider.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665404);
			SessionProvider.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665405);
			SessionProvider.NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_Final_New_Void_Object_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665406);
			SessionProvider.NativeMethodInfoPtr_WriteSimpleMessage_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665407);
			SessionProvider.NativeMethodInfoPtr_GenerateSimpleMessage_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665408);
			SessionProvider.NativeMethodInfoPtr_GenerateDisconnect_Protected_Disconnected_DisconnectReasons_SocketError_Exception_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665409);
			SessionProvider.NativeMethodInfoPtr_HandleOnLevelWasLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665410);
			SessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, 100665411);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0004D3E0 File Offset: 0x0004B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867334, XrefRangeEnd = 867416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Logout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SessionProvider.NativeMethodInfoPtr_Logout_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0004D41C File Offset: 0x0004B61C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Terminate(WargSession.DisconnectReasons reason = WargSession.DisconnectReasons.Error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SessionProvider.NativeMethodInfoPtr_Terminate_Public_Virtual_New_Void_DisconnectReasons_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0004D468 File Offset: 0x0004B668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867416, XrefRangeEnd = 867426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0004D49C File Offset: 0x0004B69C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867438, RefRangeEnd = 867439, XrefRangeStart = 867426, XrefRangeEnd = 867438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SessionProvider.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 867456, RefRangeEnd = 867461, XrefRangeStart = 867439, XrefRangeEnd = 867456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchOfflineMessage(DWDEvent message, bool sanitize = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr_DispatchOfflineMessage_Public_Void_DWDEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0004D528 File Offset: 0x0004B728
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 867470, RefRangeEnd = 867474, XrefRangeStart = 867461, XrefRangeEnd = 867470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dispatch(DWDEvent message, bool logUnhandled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logUnhandled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr_dispatch_Protected_Void_DWDEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0004D578 File Offset: 0x0004B778
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 867480, RefRangeEnd = 867487, XrefRangeStart = 867474, XrefRangeEnd = 867480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddListener<T>(Action listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.MethodInfoStoreGeneric_AddListener_Public_Virtual_Final_New_Void_Action_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0004D5BC File Offset: 0x0004B7BC
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 867493, RefRangeEnd = 867539, XrefRangeStart = 867487, XrefRangeEnd = 867493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddListener<T>(Action<T> listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.MethodInfoStoreGeneric_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0004D600 File Offset: 0x0004B800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 867545, RefRangeEnd = 867547, XrefRangeStart = 867539, XrefRangeEnd = 867545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveListener<T>(Action listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.MethodInfoStoreGeneric_RemoveListener_Public_Virtual_Final_New_Void_Action_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0004D644 File Offset: 0x0004B844
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 867553, RefRangeEnd = 867594, XrefRangeStart = 867547, XrefRangeEnd = 867553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveListener<T>(Action<T> listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.MethodInfoStoreGeneric_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0004D688 File Offset: 0x0004B888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867594, XrefRangeEnd = 867600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SessionProvider.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0004D6D8 File Offset: 0x0004B8D8
		[CallerCount(0)]
		public unsafe virtual void WriteFromAccount(Object message, AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_Final_New_Void_Object_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0004D72C File Offset: 0x0004B92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867600, XrefRangeEnd = 867616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteSimpleMessage(string messageName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr_WriteSimpleMessage_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0004D770 File Offset: 0x0004B970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867616, XrefRangeEnd = 867631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GenerateSimpleMessage(string messageName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr_GenerateSimpleMessage_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0004D7B4 File Offset: 0x0004B9B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 867640, RefRangeEnd = 867643, XrefRangeStart = 867631, XrefRangeEnd = 867640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SessionProvider.Disconnected GenerateDisconnect(WargSession.DisconnectReasons reason, SocketError socketError, Exception exception, int recentLatencySample, double sessionLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reason;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recentLatencySample;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr_GenerateDisconnect_Protected_Disconnected_DisconnectReasons_SocketError_Exception_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SessionProvider.Disconnected>(intPtr3) : null;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0004D83C File Offset: 0x0004BA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867643, XrefRangeEnd = 867645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr_HandleOnLevelWasLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0004D888 File Offset: 0x0004BA88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 867651, RefRangeEnd = 867653, XrefRangeStart = 867645, XrefRangeEnd = 867651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SessionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00006EAB File Offset: 0x000050AB
		public SessionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0004D8C4 File Offset: 0x0004BAC4
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00006EB4 File Offset: 0x000050B4
		public unsafe EventHandlers eventHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.NativeFieldInfoPtr_eventHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandlers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.NativeFieldInfoPtr_eventHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr_eventHandlers;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_Logout_Public_Virtual_New_Void_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_Terminate_Public_Virtual_New_Void_DisconnectReasons_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_DispatchOfflineMessage_Public_Void_DWDEvent_Boolean_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_dispatch_Protected_Void_DWDEvent_Boolean_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_Final_New_Void_Object_AccountID_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_WriteSimpleMessage_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSimpleMessage_Public_Static_Object_String_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_GenerateDisconnect_Protected_Disconnected_DisconnectReasons_SocketError_Exception_Int32_Double_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_HandleOnLevelWasLoaded_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002B2 RID: 690
		public class Disconnected : DWDEvent
		{
			// Token: 0x06002066 RID: 8294 RVA: 0x000927BC File Offset: 0x000909BC
			// Note: this type is marked as 'beforefieldinit'.
			static Disconnected()
			{
				Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionProvider>.NativeClassPtr, "Disconnected");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr);
				SessionProvider.Disconnected.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr, "Reason");
				SessionProvider.Disconnected.NativeFieldInfoPtr_SocketError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr, "SocketError");
				SessionProvider.Disconnected.NativeFieldInfoPtr_Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr, "Exception");
				SessionProvider.Disconnected.NativeFieldInfoPtr_RecentLatencySamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr, "RecentLatencySamples");
				SessionProvider.Disconnected.NativeFieldInfoPtr_SessionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr, "SessionLength");
				SessionProvider.Disconnected.NativeMethodInfoPtr__ctor_Internal_Void_DisconnectReasons_SocketError_Exception_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr, 100665412);
			}

			// Token: 0x06002067 RID: 8295 RVA: 0x00092860 File Offset: 0x00090A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867328, XrefRangeEnd = 867334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Disconnected(WargSession.DisconnectReasons reason, SocketError socketError, Exception exception, int recentLatencySample, double sessionLength)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionProvider.Disconnected>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref reason;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketError;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recentLatencySample;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionProvider.Disconnected.NativeMethodInfoPtr__ctor_Internal_Void_DisconnectReasons_SocketError_Exception_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002068 RID: 8296 RVA: 0x0000DC54 File Offset: 0x0000BE54
			public Disconnected(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x06002069 RID: 8297 RVA: 0x000928E4 File Offset: 0x00090AE4
			// (set) Token: 0x0600206A RID: 8298 RVA: 0x0000DC5D File Offset: 0x0000BE5D
			public unsafe WargSession.DisconnectReasons Reason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_Reason);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_Reason)) = value;
				}
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x0600206B RID: 8299 RVA: 0x0009290C File Offset: 0x00090B0C
			// (set) Token: 0x0600206C RID: 8300 RVA: 0x0000DC78 File Offset: 0x0000BE78
			public unsafe SocketError SocketError
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_SocketError);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_SocketError)) = value;
				}
			}

			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x0600206D RID: 8301 RVA: 0x00092934 File Offset: 0x00090B34
			// (set) Token: 0x0600206E RID: 8302 RVA: 0x0000DC93 File Offset: 0x0000BE93
			public unsafe Exception Exception
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_Exception);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_Exception), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x0600206F RID: 8303 RVA: 0x00092964 File Offset: 0x00090B64
			// (set) Token: 0x06002070 RID: 8304 RVA: 0x0000DCB2 File Offset: 0x0000BEB2
			public unsafe Il2CppStructArray<int> RecentLatencySamples
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_RecentLatencySamples);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_RecentLatencySamples), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06002071 RID: 8305 RVA: 0x00092994 File Offset: 0x00090B94
			// (set) Token: 0x06002072 RID: 8306 RVA: 0x0000DCD1 File Offset: 0x0000BED1
			public unsafe double SessionLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_SessionLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SessionProvider.Disconnected.NativeFieldInfoPtr_SessionLength)) = value;
				}
			}

			// Token: 0x0400168D RID: 5773
			private static readonly IntPtr NativeFieldInfoPtr_Reason;

			// Token: 0x0400168E RID: 5774
			private static readonly IntPtr NativeFieldInfoPtr_SocketError;

			// Token: 0x0400168F RID: 5775
			private static readonly IntPtr NativeFieldInfoPtr_Exception;

			// Token: 0x04001690 RID: 5776
			private static readonly IntPtr NativeFieldInfoPtr_RecentLatencySamples;

			// Token: 0x04001691 RID: 5777
			private static readonly IntPtr NativeFieldInfoPtr_SessionLength;

			// Token: 0x04001692 RID: 5778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DisconnectReasons_SocketError_Exception_Int32_Double_0;
		}

		// Token: 0x020002B3 RID: 691
		private sealed class MethodInfoStoreGeneric_AddListener_Public_Virtual_Final_New_Void_Action_0<T>
		{
			// Token: 0x04001693 RID: 5779
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SessionProvider.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0, Il2CppClassPointerStore<SessionProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002B4 RID: 692
		private sealed class MethodInfoStoreGeneric_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0<T>
		{
			// Token: 0x04001694 RID: 5780
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SessionProvider.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0, Il2CppClassPointerStore<SessionProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002B5 RID: 693
		private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Virtual_Final_New_Void_Action_0<T>
		{
			// Token: 0x04001695 RID: 5781
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SessionProvider.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0, Il2CppClassPointerStore<SessionProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002B6 RID: 694
		private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0<T>
		{
			// Token: 0x04001696 RID: 5782
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SessionProvider.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0, Il2CppClassPointerStore<SessionProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
