using System;
using boardgames.menus.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.behaviours
{
	// Token: 0x020002A4 RID: 676
	public class FriendsListButtonBehaviour : VersionedView<FriendChatProvider>
	{
		// Token: 0x0600202C RID: 8236 RVA: 0x00088D3C File Offset: 0x00086F3C
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsListButtonBehaviour()
		{
			Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "FriendsListButtonBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr);
			FriendsListButtonBehaviour.NativeFieldInfoPtr_notificationPip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, "notificationPip");
			FriendsListButtonBehaviour.NativeFieldInfoPtr_modalScopeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, "modalScopeOverride");
			FriendsListButtonBehaviour.NativeFieldInfoPtr_onChatReceivedCollapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, "onChatReceivedCollapsed");
			FriendsListButtonBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668641);
			FriendsListButtonBehaviour.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668642);
			FriendsListButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668643);
			FriendsListButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668644);
			FriendsListButtonBehaviour.NativeMethodInfoPtr_OnListDisplayed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668645);
			FriendsListButtonBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668646);
			FriendsListButtonBehaviour.NativeMethodInfoPtr_Event_OnChatReceived_Private_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668647);
			FriendsListButtonBehaviour.NativeMethodInfoPtr_TryGetRunningFlow_Private_Static_Boolean_byref_RunFriendsListFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668648);
			FriendsListButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, 100668649);
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00088E5C File Offset: 0x0008705C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542074, XrefRangeEnd = 542089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsListButtonBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00088E98 File Offset: 0x00087098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542089, XrefRangeEnd = 542113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsListButtonBehaviour.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00088ED4 File Offset: 0x000870D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542113, XrefRangeEnd = 542129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00088F08 File Offset: 0x00087108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542129, XrefRangeEnd = 542145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Show(bool show)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref show;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00088F48 File Offset: 0x00087148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 542149, RefRangeEnd = 542150, XrefRangeStart = 542145, XrefRangeEnd = 542149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnListDisplayed(bool displayed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.NativeMethodInfoPtr_OnListDisplayed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00088F88 File Offset: 0x00087188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542150, XrefRangeEnd = 542163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00088FBC File Offset: 0x000871BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542163, XrefRangeEnd = 542180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnChatReceived(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.NativeMethodInfoPtr_Event_OnChatReceived_Private_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00089000 File Offset: 0x00087200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542180, XrefRangeEnd = 542191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetRunningFlow(out RunFriendsListFlow flow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.NativeMethodInfoPtr_TryGetRunningFlow_Private_Static_Boolean_byref_RunFriendsListFlow_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				flow = ((intPtr4 == 0) ? null : new RunFriendsListFlow(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00089054 File Offset: 0x00087254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542191, XrefRangeEnd = 542199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsListButtonBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00010E41 File Offset: 0x0000F041
		public FriendsListButtonBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00089090 File Offset: 0x00087290
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x00010E4A File Offset: 0x0000F04A
		public unsafe GameObject notificationPip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListButtonBehaviour.NativeFieldInfoPtr_notificationPip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListButtonBehaviour.NativeFieldInfoPtr_notificationPip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x000890C0 File Offset: 0x000872C0
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x00010E69 File Offset: 0x0000F069
		public unsafe ModalScope modalScopeOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListButtonBehaviour.NativeFieldInfoPtr_modalScopeOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListButtonBehaviour.NativeFieldInfoPtr_modalScopeOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x000890F0 File Offset: 0x000872F0
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x00010E88 File Offset: 0x0000F088
		public unsafe UnityEvent onChatReceivedCollapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListButtonBehaviour.NativeFieldInfoPtr_onChatReceivedCollapsed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListButtonBehaviour.NativeFieldInfoPtr_onChatReceivedCollapsed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeFieldInfoPtr_notificationPip;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeFieldInfoPtr_modalScopeOverride;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedCollapsed;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_Event_Show_Public_Void_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_Event_Show_Public_Void_Boolean_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_OnListDisplayed_Public_Void_Boolean_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnChatReceived_Private_Void_ClientChatMessage_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_TryGetRunningFlow_Private_Static_Boolean_byref_RunFriendsListFlow_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200049D RID: 1181
		[ObfuscatedName("boardgames.behaviours.FriendsListButtonBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06003810 RID: 14352 RVA: 0x000CFF88 File Offset: 0x000CE188
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendsListButtonBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr);
				FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr, "<>9");
				FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr, "<>9__4_1");
				FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr, "<>9__4_0");
				FriendsListButtonBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr, 100668651);
				FriendsListButtonBehaviour.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_FriendChatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr, 100668652);
				FriendsListButtonBehaviour.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_1_Internal_Int64_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr, 100668653);
			}

			// Token: 0x06003811 RID: 14353 RVA: 0x000D002C File Offset: 0x000CE22C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListButtonBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003812 RID: 14354 RVA: 0x000D0068 File Offset: 0x000CE268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542069, XrefRangeEnd = 542074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__4_0(FriendChatProvider.FriendChatInfo c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_FriendChatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003813 RID: 14355 RVA: 0x000D00B8 File Offset: 0x000CE2B8
			[CallerCount(0)]
			public unsafe long _dirtyUpdate_b__4_1(ClientChatMessage m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListButtonBehaviour.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_1_Internal_Int64_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003814 RID: 14356 RVA: 0x0001CD67 File Offset: 0x0001AF67
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001091 RID: 4241
			// (get) Token: 0x06003815 RID: 14357 RVA: 0x000D0108 File Offset: 0x000CE308
			// (set) Token: 0x06003816 RID: 14358 RVA: 0x0001CD70 File Offset: 0x0001AF70
			public unsafe static FriendsListButtonBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListButtonBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001092 RID: 4242
			// (get) Token: 0x06003817 RID: 14359 RVA: 0x000D0130 File Offset: 0x000CE330
			// (set) Token: 0x06003818 RID: 14360 RVA: 0x0001CD82 File Offset: 0x0001AF82
			public unsafe static Func<ClientChatMessage, long> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ClientChatMessage, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001093 RID: 4243
			// (get) Token: 0x06003819 RID: 14361 RVA: 0x000D0158 File Offset: 0x000CE358
			// (set) Token: 0x0600381A RID: 14362 RVA: 0x0001CD94 File Offset: 0x0001AF94
			public unsafe static Func<FriendChatProvider.FriendChatInfo, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FriendChatProvider.FriendChatInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListButtonBehaviour.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400227A RID: 8826
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400227B RID: 8827
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400227C RID: 8828
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400227D RID: 8829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400227E RID: 8830
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_FriendChatInfo_0;

			// Token: 0x0400227F RID: 8831
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_1_Internal_Int64_ClientChatMessage_0;
		}
	}
}
