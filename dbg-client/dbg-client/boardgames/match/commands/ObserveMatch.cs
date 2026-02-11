using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.platform.data;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.commands
{
	// Token: 0x0200028E RID: 654
	public class ObserveMatch : PlayMatchCommand
	{
		// Token: 0x06001EAE RID: 7854 RVA: 0x00083A84 File Offset: 0x00081C84
		// Note: this type is marked as 'beforefieldinit'.
		static ObserveMatch()
		{
			Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "ObserveMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr);
			ObserveMatch.NativeFieldInfoPtr__gameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, "_gameSession");
			ObserveMatch.NativeFieldInfoPtr__observedPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, "_observedPlayerID");
			ObserveMatch.NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668339);
			ObserveMatch.NativeMethodInfoPtr__ctor_Public_Void_ObserverGameSession_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668340);
			ObserveMatch.NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668341);
			ObserveMatch.NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668342);
			ObserveMatch.NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668343);
			ObserveMatch.NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668344);
			ObserveMatch.NativeMethodInfoPtr_GetServerEndpoint_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668345);
			ObserveMatch.NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668346);
			ObserveMatch.NativeMethodInfoPtr___ctor_b__4_0_Private_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668347);
			ObserveMatch.NativeMethodInfoPtr__setupSessionRelay_b__8_0_Private_Object_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668348);
			ObserveMatch.NativeMethodInfoPtr__setupSessionRelay_b__8_1_Private_Object_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, 100668349);
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00083BB8 File Offset: 0x00081DB8
		public unsafe override GameID GameID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539524, XrefRangeEnd = 539526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveMatch.NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00083C04 File Offset: 0x00081E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 539574, RefRangeEnd = 539575, XrefRangeStart = 539526, XrefRangeEnd = 539574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserveMatch(ObserverGameSession gameSession, AccountID observedPlayerID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameSession);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(observedPlayerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch.NativeMethodInfoPtr__ctor_Public_Void_ObserverGameSession_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00083C64 File Offset: 0x00081E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539575, XrefRangeEnd = 539579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator establishMatchContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveMatch.NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00083CB0 File Offset: 0x00081EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539579, XrefRangeEnd = 539607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComposition createGameData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveMatch.NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00083CFC File Offset: 0x00081EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539607, XrefRangeEnd = 539613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<DataComponent> createSpinnerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveMatch.NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataComponent>>(intPtr3) : null;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00083D48 File Offset: 0x00081F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539613, XrefRangeEnd = 539618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator setupSessionRelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveMatch.NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00083D94 File Offset: 0x00081F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539618, XrefRangeEnd = 539624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetServerEndpoint(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch.NativeMethodInfoPtr_GetServerEndpoint_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00083DDC File Offset: 0x00081FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539624, XrefRangeEnd = 539629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator handleLoadTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveMatch.NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00083E28 File Offset: 0x00082028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539629, XrefRangeEnd = 539635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool __ctor_b__4_0(RosterEntry friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch.NativeMethodInfoPtr___ctor_b__4_0_Private_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00083E78 File Offset: 0x00082078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539635, XrefRangeEnd = 539647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _setupSessionRelay_b__8_0(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch.NativeMethodInfoPtr__setupSessionRelay_b__8_0_Private_Object_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00083EC8 File Offset: 0x000820C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539647, XrefRangeEnd = 539659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _setupSessionRelay_b__8_1(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch.NativeMethodInfoPtr__setupSessionRelay_b__8_1_Private_Object_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00010337 File Offset: 0x0000E537
		public ObserveMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00083F18 File Offset: 0x00082118
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x00010340 File Offset: 0x0000E540
		public unsafe ObserverGameSession _gameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch.NativeFieldInfoPtr__gameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserverGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch.NativeFieldInfoPtr__gameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001EBD RID: 7869 RVA: 0x00083F48 File Offset: 0x00082148
		// (set) Token: 0x06001EBE RID: 7870 RVA: 0x0001035F File Offset: 0x0000E55F
		public unsafe AccountID _observedPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch.NativeFieldInfoPtr__observedPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch.NativeFieldInfoPtr__observedPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeFieldInfoPtr__gameSession;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeFieldInfoPtr__observedPlayerID;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObserverGameSession_AccountID_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_GetServerEndpoint_Private_String_String_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Private_Boolean_RosterEntry_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr__setupSessionRelay_b__8_0_Private_Object_Dictionary_2_String_String_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr__setupSessionRelay_b__8_1_Private_Object_Dictionary_2_String_String_0;

		// Token: 0x02000481 RID: 1153
		[ObfuscatedName("boardgames.match.commands.ObserveMatch+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003687 RID: 13959 RVA: 0x000CB5E4 File Offset: 0x000C97E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObserveMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserveMatch.__c>.NativeClassPtr);
				ObserveMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch.__c>.NativeClassPtr, "<>9");
				ObserveMatch.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch.__c>.NativeClassPtr, "<>9__4_1");
				ObserveMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch.__c>.NativeClassPtr, 100668351);
				ObserveMatch.__c.NativeMethodInfoPtr___ctor_b__4_1_Internal_String_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch.__c>.NativeClassPtr, 100668352);
			}

			// Token: 0x06003688 RID: 13960 RVA: 0x000CB660 File Offset: 0x000C9860
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserveMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003689 RID: 13961 RVA: 0x000CB69C File Offset: 0x000C989C
			[CallerCount(0)]
			public unsafe string __ctor_b__4_1(RosterEntry friend)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch.__c.NativeMethodInfoPtr___ctor_b__4_1_Internal_String_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600368A RID: 13962 RVA: 0x0001C12D File Offset: 0x0001A32D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001005 RID: 4101
			// (get) Token: 0x0600368B RID: 13963 RVA: 0x000CB6E4 File Offset: 0x000C98E4
			// (set) Token: 0x0600368C RID: 13964 RVA: 0x0001C136 File Offset: 0x0001A336
			public unsafe static ObserveMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObserveMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserveMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObserveMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001006 RID: 4102
			// (get) Token: 0x0600368D RID: 13965 RVA: 0x000CB70C File Offset: 0x000C990C
			// (set) Token: 0x0600368E RID: 13966 RVA: 0x0001C148 File Offset: 0x0001A348
			public unsafe static Func<RosterEntry, string> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObserveMatch.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObserveMatch.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400218D RID: 8589
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400218E RID: 8590
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400218F RID: 8591
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002190 RID: 8592
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_1_Internal_String_RosterEntry_0;
		}

		// Token: 0x02000482 RID: 1154
		[ObfuscatedName("boardgames.match.commands.ObserveMatch+<establishMatchContext>d__5")]
		public sealed class _establishMatchContext_d__5 : Object
		{
			// Token: 0x0600368F RID: 13967 RVA: 0x000CB734 File Offset: 0x000C9934
			// Note: this type is marked as 'beforefieldinit'.
			static _establishMatchContext_d__5()
			{
				Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, "<establishMatchContext>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr);
				ObserveMatch._establishMatchContext_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr, "<>1__state");
				ObserveMatch._establishMatchContext_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr, "<>2__current");
				ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr, 100668353);
				ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr, 100668354);
				ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr, 100668355);
				ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr, 100668356);
				ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr, 100668357);
				ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr, 100668358);
			}

			// Token: 0x06003690 RID: 13968 RVA: 0x000CB800 File Offset: 0x000C9A00
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _establishMatchContext_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserveMatch._establishMatchContext_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003691 RID: 13969 RVA: 0x000CB848 File Offset: 0x000C9A48
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003692 RID: 13970 RVA: 0x000CB87C File Offset: 0x000C9A7C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001009 RID: 4105
			// (get) Token: 0x06003693 RID: 13971 RVA: 0x000CB8B8 File Offset: 0x000C9AB8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003694 RID: 13972 RVA: 0x000CB8F8 File Offset: 0x000C9AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539448, XrefRangeEnd = 539453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700100A RID: 4106
			// (get) Token: 0x06003695 RID: 13973 RVA: 0x000CB92C File Offset: 0x000C9B2C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._establishMatchContext_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003696 RID: 13974 RVA: 0x0001C15A File Offset: 0x0001A35A
			public _establishMatchContext_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001007 RID: 4103
			// (get) Token: 0x06003697 RID: 13975 RVA: 0x000CB96C File Offset: 0x000C9B6C
			// (set) Token: 0x06003698 RID: 13976 RVA: 0x0001C163 File Offset: 0x0001A363
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._establishMatchContext_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._establishMatchContext_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001008 RID: 4104
			// (get) Token: 0x06003699 RID: 13977 RVA: 0x000CB994 File Offset: 0x000C9B94
			// (set) Token: 0x0600369A RID: 13978 RVA: 0x0001C17E File Offset: 0x0001A37E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._establishMatchContext_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._establishMatchContext_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002191 RID: 8593
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002192 RID: 8594
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002193 RID: 8595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002194 RID: 8596
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002195 RID: 8597
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002196 RID: 8598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002197 RID: 8599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002198 RID: 8600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000483 RID: 1155
		[ObfuscatedName("boardgames.match.commands.ObserveMatch+<handleLoadTimeout>d__10")]
		public sealed class _handleLoadTimeout_d__10 : Object
		{
			// Token: 0x0600369B RID: 13979 RVA: 0x000CB9C4 File Offset: 0x000C9BC4
			// Note: this type is marked as 'beforefieldinit'.
			static _handleLoadTimeout_d__10()
			{
				Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, "<handleLoadTimeout>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr);
				ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, "<>1__state");
				ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, "<>2__current");
				ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, "<>4__this");
				ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, 100668359);
				ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, 100668360);
				ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, 100668361);
				ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, 100668362);
				ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, 100668363);
				ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr, 100668364);
			}

			// Token: 0x0600369C RID: 13980 RVA: 0x000CBAA4 File Offset: 0x000C9CA4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _handleLoadTimeout_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserveMatch._handleLoadTimeout_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600369D RID: 13981 RVA: 0x000CBAEC File Offset: 0x000C9CEC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600369E RID: 13982 RVA: 0x000CBB20 File Offset: 0x000C9D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539453, XrefRangeEnd = 539461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700100E RID: 4110
			// (get) Token: 0x0600369F RID: 13983 RVA: 0x000CBB5C File Offset: 0x000C9D5C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036A0 RID: 13984 RVA: 0x000CBB9C File Offset: 0x000C9D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539461, XrefRangeEnd = 539466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700100F RID: 4111
			// (get) Token: 0x060036A1 RID: 13985 RVA: 0x000CBBD0 File Offset: 0x000C9DD0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._handleLoadTimeout_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036A2 RID: 13986 RVA: 0x0001C19D File Offset: 0x0001A39D
			public _handleLoadTimeout_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700100B RID: 4107
			// (get) Token: 0x060036A3 RID: 13987 RVA: 0x000CBC10 File Offset: 0x000C9E10
			// (set) Token: 0x060036A4 RID: 13988 RVA: 0x0001C1A6 File Offset: 0x0001A3A6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700100C RID: 4108
			// (get) Token: 0x060036A5 RID: 13989 RVA: 0x000CBC38 File Offset: 0x000C9E38
			// (set) Token: 0x060036A6 RID: 13990 RVA: 0x0001C1C1 File Offset: 0x0001A3C1
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100D RID: 4109
			// (get) Token: 0x060036A7 RID: 13991 RVA: 0x000CBC68 File Offset: 0x000C9E68
			// (set) Token: 0x060036A8 RID: 13992 RVA: 0x0001C1E0 File Offset: 0x0001A3E0
			public unsafe ObserveMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserveMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._handleLoadTimeout_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002199 RID: 8601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400219A RID: 8602
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400219B RID: 8603
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400219C RID: 8604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400219D RID: 8605
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400219E RID: 8606
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400219F RID: 8607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021A0 RID: 8608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021A1 RID: 8609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000484 RID: 1156
		[ObfuscatedName("boardgames.match.commands.ObserveMatch+<setupSessionRelay>d__8")]
		public sealed class _setupSessionRelay_d__8 : Object
		{
			// Token: 0x060036A9 RID: 13993 RVA: 0x000CBC98 File Offset: 0x000C9E98
			// Note: this type is marked as 'beforefieldinit'.
			static _setupSessionRelay_d__8()
			{
				Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserveMatch>.NativeClassPtr, "<setupSessionRelay>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr);
				ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, "<>1__state");
				ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, "<>2__current");
				ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, "<>4__this");
				ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr__network_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, "<network>5__2");
				ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, 100668365);
				ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, 100668366);
				ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, 100668367);
				ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, 100668368);
				ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, 100668369);
				ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr, 100668370);
			}

			// Token: 0x060036AA RID: 13994 RVA: 0x000CBD8C File Offset: 0x000C9F8C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _setupSessionRelay_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserveMatch._setupSessionRelay_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060036AB RID: 13995 RVA: 0x000CBDD4 File Offset: 0x000C9FD4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036AC RID: 13996 RVA: 0x000CBE08 File Offset: 0x000CA008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539466, XrefRangeEnd = 539519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001014 RID: 4116
			// (get) Token: 0x060036AD RID: 13997 RVA: 0x000CBE44 File Offset: 0x000CA044
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036AE RID: 13998 RVA: 0x000CBE84 File Offset: 0x000CA084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539519, XrefRangeEnd = 539524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001015 RID: 4117
			// (get) Token: 0x060036AF RID: 13999 RVA: 0x000CBEB8 File Offset: 0x000CA0B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveMatch._setupSessionRelay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036B0 RID: 14000 RVA: 0x0001C1FF File Offset: 0x0001A3FF
			public _setupSessionRelay_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001010 RID: 4112
			// (get) Token: 0x060036B1 RID: 14001 RVA: 0x000CBEF8 File Offset: 0x000CA0F8
			// (set) Token: 0x060036B2 RID: 14002 RVA: 0x0001C208 File Offset: 0x0001A408
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001011 RID: 4113
			// (get) Token: 0x060036B3 RID: 14003 RVA: 0x000CBF20 File Offset: 0x000CA120
			// (set) Token: 0x060036B4 RID: 14004 RVA: 0x0001C223 File Offset: 0x0001A423
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001012 RID: 4114
			// (get) Token: 0x060036B5 RID: 14005 RVA: 0x000CBF50 File Offset: 0x000CA150
			// (set) Token: 0x060036B6 RID: 14006 RVA: 0x0001C242 File Offset: 0x0001A442
			public unsafe ObserveMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserveMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001013 RID: 4115
			// (get) Token: 0x060036B7 RID: 14007 RVA: 0x000CBF80 File Offset: 0x000CA180
			// (set) Token: 0x060036B8 RID: 14008 RVA: 0x0001C261 File Offset: 0x0001A461
			public unsafe CanisNetworkState _network_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr__network_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisNetworkState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveMatch._setupSessionRelay_d__8.NativeFieldInfoPtr__network_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021A2 RID: 8610
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021A3 RID: 8611
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021A4 RID: 8612
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021A5 RID: 8613
			private static readonly IntPtr NativeFieldInfoPtr__network_5__2;

			// Token: 0x040021A6 RID: 8614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040021A7 RID: 8615
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021A8 RID: 8616
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040021A9 RID: 8617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021AA RID: 8618
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021AB RID: 8619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
