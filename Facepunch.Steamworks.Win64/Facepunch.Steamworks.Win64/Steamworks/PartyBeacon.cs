using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000BF RID: 191
	[StructLayout(2)]
	public struct PartyBeacon
	{
		// Token: 0x06000C65 RID: 3173 RVA: 0x00052A74 File Offset: 0x00050C74
		// Note: this type is marked as 'beforefieldinit'.
		static PartyBeacon()
		{
			Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "PartyBeacon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr);
			PartyBeacon.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, "Id");
			PartyBeacon.NativeMethodInfoPtr_get_Internal_Private_Static_get_ISteamParties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, 100666367);
			PartyBeacon.NativeMethodInfoPtr_get_Owner_Public_get_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, 100666368);
			PartyBeacon.NativeMethodInfoPtr_get_MetaData_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, 100666369);
			PartyBeacon.NativeMethodInfoPtr_JoinAsync_Public_Task_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, 100666370);
			PartyBeacon.NativeMethodInfoPtr_OnReservationCompleted_Public_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, 100666371);
			PartyBeacon.NativeMethodInfoPtr_CancelReservation_Public_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, 100666372);
			PartyBeacon.NativeMethodInfoPtr_Destroy_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, 100666373);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00052B44 File Offset: 0x00050D44
		public unsafe static ISteamParties Internal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947234, XrefRangeEnd = 947235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon.NativeMethodInfoPtr_get_Internal_Private_Static_get_ISteamParties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamParties>(intPtr3) : null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00052B78 File Offset: 0x00050D78
		public unsafe SteamId Owner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947235, XrefRangeEnd = 947237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon.NativeMethodInfoPtr_get_Owner_Public_get_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00052BA8 File Offset: 0x00050DA8
		public unsafe string MetaData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947237, XrefRangeEnd = 947239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon.NativeMethodInfoPtr_get_MetaData_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00052BD4 File Offset: 0x00050DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947239, XrefRangeEnd = 947252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> JoinAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon.NativeMethodInfoPtr_JoinAsync_Public_Task_1_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00052C08 File Offset: 0x00050E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947252, XrefRangeEnd = 947255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReservationCompleted(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon.NativeMethodInfoPtr_OnReservationCompleted_Public_Void_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00052C3C File Offset: 0x00050E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947255, XrefRangeEnd = 947258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelReservation(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon.NativeMethodInfoPtr_CancelReservation_Public_Void_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00052C70 File Offset: 0x00050E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947258, XrefRangeEnd = 947261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Destroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon.NativeMethodInfoPtr_Destroy_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00003097 File Offset: 0x00001297
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, ref this));
		}

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Private_Static_get_ISteamParties_0;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_SteamId_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_get_MetaData_Public_get_String_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr_JoinAsync_Public_Task_1_String_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_OnReservationCompleted_Public_Void_SteamId_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_CancelReservation_Public_Void_SteamId_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Boolean_0;

		// Token: 0x0400130B RID: 4875
		[FieldOffset(0)]
		public PartyBeaconID_t Id;

		// Token: 0x02000282 RID: 642
		[ObfuscatedName("Steamworks.PartyBeacon+<JoinAsync>d__7")]
		public sealed class _JoinAsync_d__7 : ValueType
		{
			// Token: 0x0600208A RID: 8330 RVA: 0x0008F300 File Offset: 0x0008D500
			// Note: this type is marked as 'beforefieldinit'.
			static _JoinAsync_d__7()
			{
				Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartyBeacon>.NativeClassPtr, "<JoinAsync>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr);
				PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr, "<>1__state");
				PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr, "<>t__builder");
				PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr, "<>4__this");
				PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr, "<>u__1");
				PartyBeacon._JoinAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr, 100666374);
				PartyBeacon._JoinAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr, 100666375);
			}

			// Token: 0x0600208B RID: 8331 RVA: 0x0008F3A4 File Offset: 0x0008D5A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947198, XrefRangeEnd = 947228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon._JoinAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600208C RID: 8332 RVA: 0x0008F3DC File Offset: 0x0008D5DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947228, XrefRangeEnd = 947234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeacon._JoinAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600208D RID: 8333 RVA: 0x0000C74D File Offset: 0x0000A94D
			public _JoinAsync_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600208E RID: 8334 RVA: 0x0000C756 File Offset: 0x0000A956
			public _JoinAsync_d__7()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartyBeacon._JoinAsync_d__7>.NativeClassPtr))
			{
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x0600208F RID: 8335 RVA: 0x0008F424 File Offset: 0x0008D624
			// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000C768 File Offset: 0x0000A968
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06002091 RID: 8337 RVA: 0x0008F44C File Offset: 0x0008D64C
			// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000C783 File Offset: 0x0000A983
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06002093 RID: 8339 RVA: 0x0008F47C File Offset: 0x0008D67C
			// (set) Token: 0x06002094 RID: 8340 RVA: 0x0000C7B1 File Offset: 0x0000A9B1
			public unsafe PartyBeacon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06002095 RID: 8341 RVA: 0x0008F4A4 File Offset: 0x0008D6A4
			// (set) Token: 0x06002096 RID: 8342 RVA: 0x0000C7CC File Offset: 0x0000A9CC
			public CallResult<JoinPartyCallback_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___u__1);
					return new CallResult<JoinPartyCallback_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<JoinPartyCallback_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyBeacon._JoinAsync_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<JoinPartyCallback_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022D6 RID: 8918
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022D7 RID: 8919
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022D8 RID: 8920
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022D9 RID: 8921
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040022DA RID: 8922
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022DB RID: 8923
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
