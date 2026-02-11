using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000BE RID: 190
	[StructLayout(2)]
	public struct InventoryResult
	{
		// Token: 0x06000C5A RID: 3162 RVA: 0x00052778 File Offset: 0x00050978
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryResult()
		{
			Il2CppClassPointerStore<InventoryResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "InventoryResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr);
			InventoryResult.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, "_id");
			InventoryResult.NativeFieldInfoPtr__Expired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, "<Expired>k__BackingField");
			InventoryResult.NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666356);
			InventoryResult.NativeMethodInfoPtr_set_Expired_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666357);
			InventoryResult.NativeMethodInfoPtr__ctor_Internal_Void_SteamInventoryResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666358);
			InventoryResult.NativeMethodInfoPtr_get_ItemCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666359);
			InventoryResult.NativeMethodInfoPtr_BelongsTo_Public_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666360);
			InventoryResult.NativeMethodInfoPtr_GetItems_Public_Il2CppReferenceArray_1_InventoryItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666361);
			InventoryResult.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666362);
			InventoryResult.NativeMethodInfoPtr_GetAsync_Internal_Static_Task_1_Nullable_1_InventoryResult_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666363);
			InventoryResult.NativeMethodInfoPtr_Serialize_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, 100666364);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00052884 File Offset: 0x00050A84
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x000528B4 File Offset: 0x00050AB4
		public unsafe bool Expired
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685122, RefRangeEnd = 685123, XrefRangeStart = 685122, XrefRangeEnd = 685123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr_set_Expired_Internal_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000528E8 File Offset: 0x00050AE8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 337402, RefRangeEnd = 337414, XrefRangeStart = 337402, XrefRangeEnd = 337414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InventoryResult(SteamInventoryResult_t id, bool expired)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr__ctor_Internal_Void_SteamInventoryResult_t_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00052928 File Offset: 0x00050B28
		public unsafe int ItemCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947143, XrefRangeEnd = 947145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr_get_ItemCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00052958 File Offset: 0x00050B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947145, XrefRangeEnd = 947148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BelongsTo(SteamId steamId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr_BelongsTo_Public_Boolean_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00052998 File Offset: 0x00050B98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 947161, RefRangeEnd = 947163, XrefRangeStart = 947148, XrefRangeEnd = 947161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<InventoryItem> GetItems(bool includeProperties = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeProperties;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr_GetItems_Public_Il2CppReferenceArray_1_InventoryItem_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryItem>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000529D8 File Offset: 0x00050BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947163, XrefRangeEnd = 947165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00052A00 File Offset: 0x00050C00
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 947178, RefRangeEnd = 947189, XrefRangeStart = 947165, XrefRangeEnd = 947178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> GetAsync(SteamInventoryResult_t sresult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sresult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr_GetAsync_Internal_Static_Task_1_Nullable_1_InventoryResult_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00052A40 File Offset: 0x00050C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947189, XrefRangeEnd = 947198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Serialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult.NativeMethodInfoPtr_Serialize_Public_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00003085 File Offset: 0x00001285
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, ref this));
		}

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeFieldInfoPtr__Expired_k__BackingField;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_set_Expired_Internal_set_Void_Boolean_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SteamInventoryResult_t_Boolean_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemCount_Public_get_Int32_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_BelongsTo_Public_Boolean_SteamId_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_GetItems_Public_Il2CppReferenceArray_1_InventoryItem_Boolean_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_GetAsync_Internal_Static_Task_1_Nullable_1_InventoryResult_SteamInventoryResult_t_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001301 RID: 4865
		[FieldOffset(0)]
		public SteamInventoryResult_t _id;

		// Token: 0x04001302 RID: 4866
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool _Expired_k__BackingField;

		// Token: 0x02000281 RID: 641
		[ObfuscatedName("Steamworks.InventoryResult+<GetAsync>d__11")]
		public sealed class _GetAsync_d__11 : ValueType
		{
			// Token: 0x0600207B RID: 8315 RVA: 0x0008F0F0 File Offset: 0x0008D2F0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAsync_d__11()
			{
				Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryResult>.NativeClassPtr, "<GetAsync>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr);
				InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr, "<>1__state");
				InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr, "<>t__builder");
				InventoryResult._GetAsync_d__11.NativeFieldInfoPtr_sresult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr, "sresult");
				InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___result_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr, "<_result>5__2");
				InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr, "<>u__1");
				InventoryResult._GetAsync_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr, 100666365);
				InventoryResult._GetAsync_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr, 100666366);
			}

			// Token: 0x0600207C RID: 8316 RVA: 0x0008F1A8 File Offset: 0x0008D3A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947109, XrefRangeEnd = 947137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult._GetAsync_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600207D RID: 8317 RVA: 0x0008F1E0 File Offset: 0x0008D3E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947137, XrefRangeEnd = 947143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryResult._GetAsync_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600207E RID: 8318 RVA: 0x0000C685 File Offset: 0x0000A885
			public _GetAsync_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600207F RID: 8319 RVA: 0x0000C68E File Offset: 0x0000A88E
			public _GetAsync_d__11()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryResult._GetAsync_d__11>.NativeClassPtr))
			{
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x06002080 RID: 8320 RVA: 0x0008F228 File Offset: 0x0008D428
			// (set) Token: 0x06002081 RID: 8321 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x06002082 RID: 8322 RVA: 0x0008F250 File Offset: 0x0008D450
			// (set) Token: 0x06002083 RID: 8323 RVA: 0x0000C6BB File Offset: 0x0000A8BB
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x06002084 RID: 8324 RVA: 0x0008F280 File Offset: 0x0008D480
			// (set) Token: 0x06002085 RID: 8325 RVA: 0x0000C6E9 File Offset: 0x0000A8E9
			public unsafe SteamInventoryResult_t sresult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr_sresult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr_sresult)) = value;
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06002086 RID: 8326 RVA: 0x0008F2A8 File Offset: 0x0008D4A8
			// (set) Token: 0x06002087 RID: 8327 RVA: 0x0000C704 File Offset: 0x0000A904
			public unsafe Result __result_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___result_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___result_5__2)) = value;
				}
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06002088 RID: 8328 RVA: 0x0008F2D0 File Offset: 0x0008D4D0
			// (set) Token: 0x06002089 RID: 8329 RVA: 0x0000C71F File Offset: 0x0000A91F
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryResult._GetAsync_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022CF RID: 8911
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022D0 RID: 8912
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022D1 RID: 8913
			private static readonly IntPtr NativeFieldInfoPtr_sresult;

			// Token: 0x040022D2 RID: 8914
			private static readonly IntPtr NativeFieldInfoPtr___result_5__2;

			// Token: 0x040022D3 RID: 8915
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040022D4 RID: 8916
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022D5 RID: 8917
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
