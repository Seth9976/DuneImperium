using System;
using boardgames.data;
using boardgames.matchMaking.commands;
using boardgames.menus.prompts;
using dwd.core.platform.providers;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x020001AA RID: 426
	public class OnlineFriendsRotator : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x0005AD3C File Offset: 0x00058F3C
		// Note: this type is marked as 'beforefieldinit'.
		static OnlineFriendsRotator()
		{
			Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "OnlineFriendsRotator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr);
			OnlineFriendsRotator.NativeFieldInfoPtr_NoneOnlineLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "NoneOnlineLocKey");
			OnlineFriendsRotator.NativeFieldInfoPtr_selectedFriendName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "selectedFriendName");
			OnlineFriendsRotator.NativeFieldInfoPtr_selectedFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "selectedFriend");
			OnlineFriendsRotator.NativeFieldInfoPtr_platformProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "platformProvider");
			OnlineFriendsRotator.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "prompt");
			OnlineFriendsRotator.NativeFieldInfoPtr_currentUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "currentUpdate");
			OnlineFriendsRotator.NativeFieldInfoPtr__filteredAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "_filteredAll");
			OnlineFriendsRotator.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666077);
			OnlineFriendsRotator.NativeMethodInfoPtr_init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666078);
			OnlineFriendsRotator.NativeMethodInfoPtr_StartFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666079);
			OnlineFriendsRotator.NativeMethodInfoPtr_onDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666080);
			OnlineFriendsRotator.NativeMethodInfoPtr_FilterFriends_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666081);
			OnlineFriendsRotator.NativeMethodInfoPtr_listUpdated_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666082);
			OnlineFriendsRotator.NativeMethodInfoPtr_Event_NextFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666083);
			OnlineFriendsRotator.NativeMethodInfoPtr_Event_PreviousFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666084);
			OnlineFriendsRotator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666085);
			OnlineFriendsRotator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666086);
			OnlineFriendsRotator.NativeMethodInfoPtr__FilterFriends_b__11_1_Private_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666087);
			OnlineFriendsRotator.NativeMethodInfoPtr__Event_NextFriend_b__13_0_Private_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666088);
			OnlineFriendsRotator.NativeMethodInfoPtr__Event_PreviousFriend_b__14_0_Private_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, 100666089);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0005AEFC File Offset: 0x000590FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518577, XrefRangeEnd = 518599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlineFriendsRotator.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0005AF38 File Offset: 0x00059138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518599, XrefRangeEnd = 518604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr_init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0005AF78 File Offset: 0x00059178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518612, RefRangeEnd = 518613, XrefRangeStart = 518604, XrefRangeEnd = 518612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr_StartFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0005AFAC File Offset: 0x000591AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518613, XrefRangeEnd = 518627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlineFriendsRotator.NativeMethodInfoPtr_onDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0005AFE8 File Offset: 0x000591E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518627, XrefRangeEnd = 518632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FilterFriends()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr_FilterFriends_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0005B028 File Offset: 0x00059228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518632, XrefRangeEnd = 518633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void listUpdated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr_listUpdated_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0005B05C File Offset: 0x0005925C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518633, XrefRangeEnd = 518679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_NextFriend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr_Event_NextFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0005B090 File Offset: 0x00059290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518679, XrefRangeEnd = 518722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_PreviousFriend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr_Event_PreviousFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0005B0C4 File Offset: 0x000592C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlineFriendsRotator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0005B100 File Offset: 0x00059300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518722, XrefRangeEnd = 518732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlineFriendsRotator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0005B13C File Offset: 0x0005933C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518732, XrefRangeEnd = 518748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _FilterFriends_b__11_1(RosterEntry f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr__FilterFriends_b__11_1_Private_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0005B18C File Offset: 0x0005938C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518748, XrefRangeEnd = 518756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Event_NextFriend_b__13_0(RosterEntry f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr__Event_NextFriend_b__13_0_Private_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0005B1DC File Offset: 0x000593DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518756, XrefRangeEnd = 518764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Event_PreviousFriend_b__14_0(RosterEntry f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.NativeMethodInfoPtr__Event_PreviousFriend_b__14_0_Private_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0000AE69 File Offset: 0x00009069
		public OnlineFriendsRotator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x0005B22C File Offset: 0x0005942C
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x0000AE72 File Offset: 0x00009072
		public unsafe static string NoneOnlineLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OnlineFriendsRotator.NativeFieldInfoPtr_NoneOnlineLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnlineFriendsRotator.NativeFieldInfoPtr_NoneOnlineLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0005B24C File Offset: 0x0005944C
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x0000AE84 File Offset: 0x00009084
		public unsafe TMP_Text selectedFriendName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_selectedFriendName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_selectedFriendName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x0005B27C File Offset: 0x0005947C
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x0000AEA3 File Offset: 0x000090A3
		public unsafe RosterEntry selectedFriend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_selectedFriend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_selectedFriend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0005B2AC File Offset: 0x000594AC
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x0000AEC2 File Offset: 0x000090C2
		public unsafe PlatformProvider platformProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_platformProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_platformProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0005B2DC File Offset: 0x000594DC
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x0000AEE1 File Offset: 0x000090E1
		public unsafe ConfigureGamePromptBehaviour prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureGamePromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0005B30C File Offset: 0x0005950C
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x0000AF00 File Offset: 0x00009100
		public unsafe Coroutine currentUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_currentUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr_currentUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0005B33C File Offset: 0x0005953C
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x0000AF1F File Offset: 0x0000911F
		public unsafe List<RosterEntry> _filteredAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr__filteredAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RosterEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.NativeFieldInfoPtr__filteredAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeFieldInfoPtr_NoneOnlineLocKey;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeFieldInfoPtr_selectedFriendName;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeFieldInfoPtr_selectedFriend;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeFieldInfoPtr_platformProvider;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeFieldInfoPtr_currentUpdate;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeFieldInfoPtr__filteredAll;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_init_Private_IEnumerator_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_StartFilter_Private_Void_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_onDisable_Protected_Virtual_Void_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_FilterFriends_Private_IEnumerator_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_listUpdated_Protected_Void_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_Event_NextFriend_Public_Void_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_Event_PreviousFriend_Public_Void_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr__FilterFriends_b__11_1_Private_Boolean_RosterEntry_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr__Event_NextFriend_b__13_0_Private_Boolean_RosterEntry_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr__Event_PreviousFriend_b__14_0_Private_Boolean_RosterEntry_0;

		// Token: 0x0200039D RID: 925
		[ObfuscatedName("boardgames.menus.OnlineFriendsRotator+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002B5B RID: 11099 RVA: 0x000AA410 File Offset: 0x000A8610
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OnlineFriendsRotator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineFriendsRotator.__c>.NativeClassPtr);
				OnlineFriendsRotator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator.__c>.NativeClassPtr, "<>9");
				OnlineFriendsRotator.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator.__c>.NativeClassPtr, "<>9__11_0");
				OnlineFriendsRotator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator.__c>.NativeClassPtr, 100666091);
				OnlineFriendsRotator.__c.NativeMethodInfoPtr__FilterFriends_b__11_0_Internal_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator.__c>.NativeClassPtr, 100666092);
			}

			// Token: 0x06002B5C RID: 11100 RVA: 0x000AA48C File Offset: 0x000A868C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineFriendsRotator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B5D RID: 11101 RVA: 0x000AA4C8 File Offset: 0x000A86C8
			[CallerCount(0)]
			public unsafe bool _FilterFriends_b__11_0(RosterEntry f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.__c.NativeMethodInfoPtr__FilterFriends_b__11_0_Internal_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B5E RID: 11102 RVA: 0x00016651 File Offset: 0x00014851
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C45 RID: 3141
			// (get) Token: 0x06002B5F RID: 11103 RVA: 0x000AA518 File Offset: 0x000A8718
			// (set) Token: 0x06002B60 RID: 11104 RVA: 0x0001665A File Offset: 0x0001485A
			public unsafe static OnlineFriendsRotator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OnlineFriendsRotator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlineFriendsRotator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OnlineFriendsRotator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C46 RID: 3142
			// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000AA540 File Offset: 0x000A8740
			// (set) Token: 0x06002B62 RID: 11106 RVA: 0x0001666C File Offset: 0x0001486C
			public unsafe static Func<RosterEntry, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OnlineFriendsRotator.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OnlineFriendsRotator.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B07 RID: 6919
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B08 RID: 6920
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04001B09 RID: 6921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B0A RID: 6922
			private static readonly IntPtr NativeMethodInfoPtr__FilterFriends_b__11_0_Internal_Boolean_RosterEntry_0;
		}

		// Token: 0x0200039E RID: 926
		[ObfuscatedName("boardgames.menus.OnlineFriendsRotator+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B63 RID: 11107 RVA: 0x000AA568 File Offset: 0x000A8768
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass11_0>.NativeClassPtr);
				OnlineFriendsRotator.__c__DisplayClass11_0.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass11_0>.NativeClassPtr, "f");
				OnlineFriendsRotator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				OnlineFriendsRotator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass11_0>.NativeClassPtr, 100666093);
				OnlineFriendsRotator.__c__DisplayClass11_0.NativeMethodInfoPtr__FilterFriends_b__2_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass11_0>.NativeClassPtr, 100666094);
			}

			// Token: 0x06002B64 RID: 11108 RVA: 0x000AA5E4 File Offset: 0x000A87E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B65 RID: 11109 RVA: 0x000AA620 File Offset: 0x000A8820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518496, XrefRangeEnd = 518500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FilterFriends_b__2(SubscriptionProvider s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.__c__DisplayClass11_0.NativeMethodInfoPtr__FilterFriends_b__2_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B66 RID: 11110 RVA: 0x0001667E File Offset: 0x0001487E
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C47 RID: 3143
			// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000AA670 File Offset: 0x000A8870
			// (set) Token: 0x06002B68 RID: 11112 RVA: 0x00016687 File Offset: 0x00014887
			public unsafe RosterEntry f
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.__c__DisplayClass11_0.NativeFieldInfoPtr_f);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.__c__DisplayClass11_0.NativeFieldInfoPtr_f), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C48 RID: 3144
			// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000AA6A0 File Offset: 0x000A88A0
			// (set) Token: 0x06002B6A RID: 11114 RVA: 0x000166A6 File Offset: 0x000148A6
			public unsafe OnlineFriendsRotator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlineFriendsRotator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B0B RID: 6923
			private static readonly IntPtr NativeFieldInfoPtr_f;

			// Token: 0x04001B0C RID: 6924
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B0D RID: 6925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B0E RID: 6926
			private static readonly IntPtr NativeMethodInfoPtr__FilterFriends_b__2_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x0200039F RID: 927
		[ObfuscatedName("boardgames.menus.OnlineFriendsRotator+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B6B RID: 11115 RVA: 0x000AA6D0 File Offset: 0x000A88D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass13_0>.NativeClassPtr);
				OnlineFriendsRotator.__c__DisplayClass13_0.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass13_0>.NativeClassPtr, "f");
				OnlineFriendsRotator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass13_0>.NativeClassPtr, 100666095);
				OnlineFriendsRotator.__c__DisplayClass13_0.NativeMethodInfoPtr__Event_NextFriend_b__1_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass13_0>.NativeClassPtr, 100666096);
			}

			// Token: 0x06002B6C RID: 11116 RVA: 0x000AA738 File Offset: 0x000A8938
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B6D RID: 11117 RVA: 0x000AA774 File Offset: 0x000A8974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518500, XrefRangeEnd = 518503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_NextFriend_b__1(SubscriptionProvider s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.__c__DisplayClass13_0.NativeMethodInfoPtr__Event_NextFriend_b__1_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B6E RID: 11118 RVA: 0x000166C5 File Offset: 0x000148C5
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C49 RID: 3145
			// (get) Token: 0x06002B6F RID: 11119 RVA: 0x000AA7C4 File Offset: 0x000A89C4
			// (set) Token: 0x06002B70 RID: 11120 RVA: 0x000166CE File Offset: 0x000148CE
			public unsafe RosterEntry f
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.__c__DisplayClass13_0.NativeFieldInfoPtr_f);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.__c__DisplayClass13_0.NativeFieldInfoPtr_f), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B0F RID: 6927
			private static readonly IntPtr NativeFieldInfoPtr_f;

			// Token: 0x04001B10 RID: 6928
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B11 RID: 6929
			private static readonly IntPtr NativeMethodInfoPtr__Event_NextFriend_b__1_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x020003A0 RID: 928
		[ObfuscatedName("boardgames.menus.OnlineFriendsRotator+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B71 RID: 11121 RVA: 0x000AA7F4 File Offset: 0x000A89F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass14_0>.NativeClassPtr);
				OnlineFriendsRotator.__c__DisplayClass14_0.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass14_0>.NativeClassPtr, "f");
				OnlineFriendsRotator.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass14_0>.NativeClassPtr, 100666097);
				OnlineFriendsRotator.__c__DisplayClass14_0.NativeMethodInfoPtr__Event_PreviousFriend_b__1_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass14_0>.NativeClassPtr, 100666098);
			}

			// Token: 0x06002B72 RID: 11122 RVA: 0x000AA85C File Offset: 0x000A8A5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineFriendsRotator.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B73 RID: 11123 RVA: 0x000AA898 File Offset: 0x000A8A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518503, XrefRangeEnd = 518506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_PreviousFriend_b__1(SubscriptionProvider s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator.__c__DisplayClass14_0.NativeMethodInfoPtr__Event_PreviousFriend_b__1_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B74 RID: 11124 RVA: 0x000166ED File Offset: 0x000148ED
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C4A RID: 3146
			// (get) Token: 0x06002B75 RID: 11125 RVA: 0x000AA8E8 File Offset: 0x000A8AE8
			// (set) Token: 0x06002B76 RID: 11126 RVA: 0x000166F6 File Offset: 0x000148F6
			public unsafe RosterEntry f
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.__c__DisplayClass14_0.NativeFieldInfoPtr_f);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator.__c__DisplayClass14_0.NativeFieldInfoPtr_f), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B12 RID: 6930
			private static readonly IntPtr NativeFieldInfoPtr_f;

			// Token: 0x04001B13 RID: 6931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B14 RID: 6932
			private static readonly IntPtr NativeMethodInfoPtr__Event_PreviousFriend_b__1_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x020003A1 RID: 929
		[ObfuscatedName("boardgames.menus.OnlineFriendsRotator+<FilterFriends>d__11")]
		public sealed class _FilterFriends_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B77 RID: 11127 RVA: 0x000AA918 File Offset: 0x000A8B18
			// Note: this type is marked as 'beforefieldinit'.
			static _FilterFriends_d__11()
			{
				Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "<FilterFriends>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr);
				OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, "<>1__state");
				OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, "<>2__current");
				OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, "<>4__this");
				OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__onlineFriends_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, "<onlineFriends>5__2");
				OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, "<i>5__3");
				OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__canInvite_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, "<canInvite>5__4");
				OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, 100666099);
				OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, 100666100);
				OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, 100666101);
				OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, 100666102);
				OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, 100666103);
				OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr, 100666104);
			}

			// Token: 0x06002B78 RID: 11128 RVA: 0x000AAA34 File Offset: 0x000A8C34
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FilterFriends_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineFriendsRotator._FilterFriends_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B79 RID: 11129 RVA: 0x000AAA7C File Offset: 0x000A8C7C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B7A RID: 11130 RVA: 0x000AAAB0 File Offset: 0x000A8CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518506, XrefRangeEnd = 518562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C51 RID: 3153
			// (get) Token: 0x06002B7B RID: 11131 RVA: 0x000AAAEC File Offset: 0x000A8CEC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B7C RID: 11132 RVA: 0x000AAB2C File Offset: 0x000A8D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518562, XrefRangeEnd = 518567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C52 RID: 3154
			// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000AAB60 File Offset: 0x000A8D60
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._FilterFriends_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B7E RID: 11134 RVA: 0x00016715 File Offset: 0x00014915
			public _FilterFriends_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C4B RID: 3147
			// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000AABA0 File Offset: 0x000A8DA0
			// (set) Token: 0x06002B80 RID: 11136 RVA: 0x0001671E File Offset: 0x0001491E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C4C RID: 3148
			// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000AABC8 File Offset: 0x000A8DC8
			// (set) Token: 0x06002B82 RID: 11138 RVA: 0x00016739 File Offset: 0x00014939
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C4D RID: 3149
			// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000AABF8 File Offset: 0x000A8DF8
			// (set) Token: 0x06002B84 RID: 11140 RVA: 0x00016758 File Offset: 0x00014958
			public unsafe OnlineFriendsRotator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlineFriendsRotator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C4E RID: 3150
			// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000AAC28 File Offset: 0x000A8E28
			// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00016777 File Offset: 0x00014977
			public unsafe List<RosterEntry> _onlineFriends_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__onlineFriends_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RosterEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__onlineFriends_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C4F RID: 3151
			// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000AAC58 File Offset: 0x000A8E58
			// (set) Token: 0x06002B88 RID: 11144 RVA: 0x00016796 File Offset: 0x00014996
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x17000C50 RID: 3152
			// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000AAC80 File Offset: 0x000A8E80
			// (set) Token: 0x06002B8A RID: 11146 RVA: 0x000167B1 File Offset: 0x000149B1
			public unsafe ICanInviteUser _canInvite_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__canInvite_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICanInviteUser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._FilterFriends_d__11.NativeFieldInfoPtr__canInvite_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B15 RID: 6933
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B16 RID: 6934
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B17 RID: 6935
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B18 RID: 6936
			private static readonly IntPtr NativeFieldInfoPtr__onlineFriends_5__2;

			// Token: 0x04001B19 RID: 6937
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04001B1A RID: 6938
			private static readonly IntPtr NativeFieldInfoPtr__canInvite_5__4;

			// Token: 0x04001B1B RID: 6939
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B1C RID: 6940
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B1D RID: 6941
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B1E RID: 6942
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B1F RID: 6943
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B20 RID: 6944
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003A2 RID: 930
		[ObfuscatedName("boardgames.menus.OnlineFriendsRotator+<init>d__7")]
		public sealed class _init_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B8B RID: 11147 RVA: 0x000AACB0 File Offset: 0x000A8EB0
			// Note: this type is marked as 'beforefieldinit'.
			static _init_d__7()
			{
				Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlineFriendsRotator>.NativeClassPtr, "<init>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr);
				OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, "<>1__state");
				OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, "<>2__current");
				OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, "<>4__this");
				OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, 100666105);
				OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, 100666106);
				OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, 100666107);
				OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, 100666108);
				OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, 100666109);
				OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr, 100666110);
			}

			// Token: 0x06002B8C RID: 11148 RVA: 0x000AAD90 File Offset: 0x000A8F90
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _init_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineFriendsRotator._init_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B8D RID: 11149 RVA: 0x000AADD8 File Offset: 0x000A8FD8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8E RID: 11150 RVA: 0x000AAE0C File Offset: 0x000A900C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518567, XrefRangeEnd = 518572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C56 RID: 3158
			// (get) Token: 0x06002B8F RID: 11151 RVA: 0x000AAE48 File Offset: 0x000A9048
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B90 RID: 11152 RVA: 0x000AAE88 File Offset: 0x000A9088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518572, XrefRangeEnd = 518577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C57 RID: 3159
			// (get) Token: 0x06002B91 RID: 11153 RVA: 0x000AAEBC File Offset: 0x000A90BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineFriendsRotator._init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B92 RID: 11154 RVA: 0x000167D0 File Offset: 0x000149D0
			public _init_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C53 RID: 3155
			// (get) Token: 0x06002B93 RID: 11155 RVA: 0x000AAEFC File Offset: 0x000A90FC
			// (set) Token: 0x06002B94 RID: 11156 RVA: 0x000167D9 File Offset: 0x000149D9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C54 RID: 3156
			// (get) Token: 0x06002B95 RID: 11157 RVA: 0x000AAF24 File Offset: 0x000A9124
			// (set) Token: 0x06002B96 RID: 11158 RVA: 0x000167F4 File Offset: 0x000149F4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C55 RID: 3157
			// (get) Token: 0x06002B97 RID: 11159 RVA: 0x000AAF54 File Offset: 0x000A9154
			// (set) Token: 0x06002B98 RID: 11160 RVA: 0x00016813 File Offset: 0x00014A13
			public unsafe OnlineFriendsRotator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlineFriendsRotator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineFriendsRotator._init_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B21 RID: 6945
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B22 RID: 6946
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B23 RID: 6947
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B24 RID: 6948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B25 RID: 6949
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B26 RID: 6950
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B27 RID: 6951
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B28 RID: 6952
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B29 RID: 6953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
