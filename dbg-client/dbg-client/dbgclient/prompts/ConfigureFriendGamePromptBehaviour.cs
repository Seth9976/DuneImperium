using System;
using Canis.utils.ids;
using dbgclient.data;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.UI;

namespace dbgclient.prompts
{
	// Token: 0x02000090 RID: 144
	public class ConfigureFriendGamePromptBehaviour : PromptBehaviour<ConfigureFriendGamePrompt>
	{
		// Token: 0x06000599 RID: 1433 RVA: 0x0002F638 File Offset: 0x0002D838
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureFriendGamePromptBehaviour()
		{
			Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts", "ConfigureFriendGamePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr);
			ConfigureFriendGamePromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, "confirmButton");
			ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, 100664160);
			ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_Event_InviteFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, 100664161);
			ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_InviteFriend_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, 100664162);
			ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_Event_RemoveFriend_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, 100664163);
			ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, 100664164);
			ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, 100664165);
			ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, 100664166);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0002F708 File Offset: 0x0002D908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502184, XrefRangeEnd = 502195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0002F744 File Offset: 0x0002D944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502195, XrefRangeEnd = 502201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_InviteFriend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_Event_InviteFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0002F778 File Offset: 0x0002D978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502201, XrefRangeEnd = 502206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InviteFriend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_InviteFriend_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0002F7B8 File Offset: 0x0002D9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502206, XrefRangeEnd = 502218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RemoveFriend(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_Event_RemoveFriend_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0002F7F8 File Offset: 0x0002D9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502218, XrefRangeEnd = 502230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0002F82C File Offset: 0x0002DA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502230, XrefRangeEnd = 502237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0002F860 File Offset: 0x0002DA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502237, XrefRangeEnd = 502240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureFriendGamePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000047F9 File Offset: 0x000029F9
		public ConfigureFriendGamePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0002F89C File Offset: 0x0002DA9C
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00004802 File Offset: 0x00002A02
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_Event_InviteFriend_Public_Void_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_InviteFriend_Private_IEnumerator_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_Event_RemoveFriend_Public_Void_Int32_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000304 RID: 772
		[ObfuscatedName("dbgclient.prompts.ConfigureFriendGamePromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600248A RID: 9354 RVA: 0x00095B78 File Offset: 0x00093D78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour.__c>.NativeClassPtr);
				ConfigureFriendGamePromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour.__c>.NativeClassPtr, "<>9");
				ConfigureFriendGamePromptBehaviour.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour.__c>.NativeClassPtr, "<>9__3_0");
				ConfigureFriendGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour.__c>.NativeClassPtr, 100664168);
				ConfigureFriendGamePromptBehaviour.__c.NativeMethodInfoPtr__InviteFriend_b__3_0_Internal_AccountID_FriendGameInviteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour.__c>.NativeClassPtr, 100664169);
			}

			// Token: 0x0600248B RID: 9355 RVA: 0x00095BF4 File Offset: 0x00093DF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600248C RID: 9356 RVA: 0x00095C30 File Offset: 0x00093E30
			[CallerCount(0)]
			public unsafe AccountID _InviteFriend_b__3_0(FriendGameInviteData f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour.__c.NativeMethodInfoPtr__InviteFriend_b__3_0_Internal_AccountID_FriendGameInviteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x0600248D RID: 9357 RVA: 0x00013078 File Offset: 0x00011278
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A02 RID: 2562
			// (get) Token: 0x0600248E RID: 9358 RVA: 0x00095C80 File Offset: 0x00093E80
			// (set) Token: 0x0600248F RID: 9359 RVA: 0x00013081 File Offset: 0x00011281
			public unsafe static ConfigureFriendGamePromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigureFriendGamePromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureFriendGamePromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigureFriendGamePromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A03 RID: 2563
			// (get) Token: 0x06002490 RID: 9360 RVA: 0x00095CA8 File Offset: 0x00093EA8
			// (set) Token: 0x06002491 RID: 9361 RVA: 0x00013093 File Offset: 0x00011293
			public unsafe static Func<FriendGameInviteData, AccountID> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigureFriendGamePromptBehaviour.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FriendGameInviteData, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigureFriendGamePromptBehaviour.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016F3 RID: 5875
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016F4 RID: 5876
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040016F5 RID: 5877
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016F6 RID: 5878
			private static readonly IntPtr NativeMethodInfoPtr__InviteFriend_b__3_0_Internal_AccountID_FriendGameInviteData_0;
		}

		// Token: 0x02000305 RID: 773
		[ObfuscatedName("dbgclient.prompts.ConfigureFriendGamePromptBehaviour+<InviteFriend>d__3")]
		public sealed class _InviteFriend_d__3 : Object
		{
			// Token: 0x06002492 RID: 9362 RVA: 0x00095CD0 File Offset: 0x00093ED0
			// Note: this type is marked as 'beforefieldinit'.
			static _InviteFriend_d__3()
			{
				Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour>.NativeClassPtr, "<InviteFriend>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr);
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, "<>1__state");
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, "<>2__current");
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, "<>4__this");
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr__configData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, "<configData>5__2");
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr__friendGameInvitePrompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, "<friendGameInvitePrompt>5__3");
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, 100664170);
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, 100664171);
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, 100664172);
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, 100664173);
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, 100664174);
				ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr, 100664175);
			}

			// Token: 0x06002493 RID: 9363 RVA: 0x00095DD8 File Offset: 0x00093FD8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InviteFriend_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureFriendGamePromptBehaviour._InviteFriend_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002494 RID: 9364 RVA: 0x00095E20 File Offset: 0x00094020
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002495 RID: 9365 RVA: 0x00095E54 File Offset: 0x00094054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502093, XrefRangeEnd = 502179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x06002496 RID: 9366 RVA: 0x00095E90 File Offset: 0x00094090
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002497 RID: 9367 RVA: 0x00095ED0 File Offset: 0x000940D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502179, XrefRangeEnd = 502184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x06002498 RID: 9368 RVA: 0x00095F04 File Offset: 0x00094104
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002499 RID: 9369 RVA: 0x000130A5 File Offset: 0x000112A5
			public _InviteFriend_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A04 RID: 2564
			// (get) Token: 0x0600249A RID: 9370 RVA: 0x00095F44 File Offset: 0x00094144
			// (set) Token: 0x0600249B RID: 9371 RVA: 0x000130AE File Offset: 0x000112AE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A05 RID: 2565
			// (get) Token: 0x0600249C RID: 9372 RVA: 0x00095F6C File Offset: 0x0009416C
			// (set) Token: 0x0600249D RID: 9373 RVA: 0x000130C9 File Offset: 0x000112C9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x0600249E RID: 9374 RVA: 0x00095F9C File Offset: 0x0009419C
			// (set) Token: 0x0600249F RID: 9375 RVA: 0x000130E8 File Offset: 0x000112E8
			public unsafe ConfigureFriendGamePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureFriendGamePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x060024A0 RID: 9376 RVA: 0x00095FCC File Offset: 0x000941CC
			// (set) Token: 0x060024A1 RID: 9377 RVA: 0x00013107 File Offset: 0x00011307
			public unsafe FriendGameConfigData _configData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr__configData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendGameConfigData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr__configData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x060024A2 RID: 9378 RVA: 0x00095FFC File Offset: 0x000941FC
			// (set) Token: 0x060024A3 RID: 9379 RVA: 0x00013126 File Offset: 0x00011326
			public unsafe FriendGameInvitePrompt _friendGameInvitePrompt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr__friendGameInvitePrompt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendGameInvitePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureFriendGamePromptBehaviour._InviteFriend_d__3.NativeFieldInfoPtr__friendGameInvitePrompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016F7 RID: 5879
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016F8 RID: 5880
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016F9 RID: 5881
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016FA RID: 5882
			private static readonly IntPtr NativeFieldInfoPtr__configData_5__2;

			// Token: 0x040016FB RID: 5883
			private static readonly IntPtr NativeFieldInfoPtr__friendGameInvitePrompt_5__3;

			// Token: 0x040016FC RID: 5884
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016FD RID: 5885
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016FE RID: 5886
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016FF RID: 5887
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001700 RID: 5888
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001701 RID: 5889
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
