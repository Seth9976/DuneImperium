using System;
using Canis;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Networking;

namespace zen.src.matchMaking.commands
{
	// Token: 0x02000061 RID: 97
	public class GetReconnectableGames : Command
	{
		// Token: 0x0600051D RID: 1309 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
		// Note: this type is marked as 'beforefieldinit'.
		static GetReconnectableGames()
		{
			Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.matchMaking.commands", "GetReconnectableGames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr);
			GetReconnectableGames.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, "client");
			GetReconnectableGames.NativeFieldInfoPtr__Games_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, "<Games>k__BackingField");
			GetReconnectableGames.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, 100664000);
			GetReconnectableGames.NativeMethodInfoPtr_get_Games_Public_get_List_1_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, 100664001);
			GetReconnectableGames.NativeMethodInfoPtr_set_Games_Private_set_Void_List_1_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, 100664002);
			GetReconnectableGames.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, 100664003);
			GetReconnectableGames.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, 100664004);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00020080 File Offset: 0x0001E280
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetReconnectableGames(string c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000200CC File Offset: 0x0001E2CC
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0002010C File Offset: 0x0001E30C
		public unsafe List<SaveMetaData> Games
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.NativeMethodInfoPtr_get_Games_Public_get_List_1_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SaveMetaData>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.NativeMethodInfoPtr_set_Games_Private_set_Void_List_1_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00020150 File Offset: 0x0001E350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986761, XrefRangeEnd = 986766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetReconnectableGames.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0002019C File Offset: 0x0001E39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986766, XrefRangeEnd = 986770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00004666 File Offset: 0x00002866
		public GetReconnectableGames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x000201D4 File Offset: 0x0001E3D4
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0000466F File Offset: 0x0000286F
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000201FC File Offset: 0x0001E3FC
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0000468E File Offset: 0x0000288E
		public unsafe List<SaveMetaData> _Games_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames.NativeFieldInfoPtr__Games_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SaveMetaData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames.NativeFieldInfoPtr__Games_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr__Games_k__BackingField;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_get_Games_Public_get_List_1_SaveMetaData_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_set_Games_Private_set_Void_List_1_SaveMetaData_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x020001CF RID: 463
		[ObfuscatedName("zen.src.matchMaking.commands.GetReconnectableGames+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001606 RID: 5638 RVA: 0x00055100 File Offset: 0x00053300
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr);
				GetReconnectableGames.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr, "<>9");
				GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr, "<>9__6_0");
				GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr, "<>9__6_2");
				GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr, "<>9__6_3");
				GetReconnectableGames.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr, 100664006);
				GetReconnectableGames.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr, 100664007);
				GetReconnectableGames.__c.NativeMethodInfoPtr__execute_b__6_2_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr, 100664008);
				GetReconnectableGames.__c.NativeMethodInfoPtr__execute_b__6_3_Internal_String_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr, 100664009);
			}

			// Token: 0x06001607 RID: 5639 RVA: 0x000551CC File Offset: 0x000533CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetReconnectableGames.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001608 RID: 5640 RVA: 0x00055208 File Offset: 0x00053408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986672, XrefRangeEnd = 986680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__6_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001609 RID: 5641 RVA: 0x0005524C File Offset: 0x0005344C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986680, XrefRangeEnd = 986694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__6_2(ErrorInfo status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(status));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.__c.NativeMethodInfoPtr__execute_b__6_2_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600160A RID: 5642 RVA: 0x00055294 File Offset: 0x00053494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986694, XrefRangeEnd = 986695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _execute_b__6_3(SaveMetaData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.__c.NativeMethodInfoPtr__execute_b__6_3_Internal_String_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600160B RID: 5643 RVA: 0x0000C4E3 File Offset: 0x0000A6E3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x0600160C RID: 5644 RVA: 0x000552DC File Offset: 0x000534DC
			// (set) Token: 0x0600160D RID: 5645 RVA: 0x0000C4EC File Offset: 0x0000A6EC
			public unsafe static GetReconnectableGames.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetReconnectableGames.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetReconnectableGames.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetReconnectableGames.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x0600160E RID: 5646 RVA: 0x00055304 File Offset: 0x00053504
			// (set) Token: 0x0600160F RID: 5647 RVA: 0x0000C4FE File Offset: 0x0000A6FE
			public unsafe static Action<UnityWebRequest> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x06001610 RID: 5648 RVA: 0x0005532C File Offset: 0x0005352C
			// (set) Token: 0x06001611 RID: 5649 RVA: 0x0000C510 File Offset: 0x0000A710
			public unsafe static Action<ErrorInfo> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x06001612 RID: 5650 RVA: 0x00055354 File Offset: 0x00053554
			// (set) Token: 0x06001613 RID: 5651 RVA: 0x0000C522 File Offset: 0x0000A722
			public unsafe static Func<SaveMetaData, string> __9__6_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SaveMetaData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetReconnectableGames.__c.NativeFieldInfoPtr___9__6_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D5E RID: 3422
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000D5F RID: 3423
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04000D60 RID: 3424
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x04000D61 RID: 3425
			private static readonly IntPtr NativeFieldInfoPtr___9__6_3;

			// Token: 0x04000D62 RID: 3426
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000D63 RID: 3427
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x04000D64 RID: 3428
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_2_Internal_Void_ErrorInfo_0;

			// Token: 0x04000D65 RID: 3429
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_3_Internal_String_SaveMetaData_0;
		}

		// Token: 0x020001D0 RID: 464
		[ObfuscatedName("zen.src.matchMaking.commands.GetReconnectableGames+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06001614 RID: 5652 RVA: 0x0005537C File Offset: 0x0005357C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<GetReconnectableGames.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetReconnectableGames.__c__DisplayClass6_0>.NativeClassPtr);
				GetReconnectableGames.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				GetReconnectableGames.__c__DisplayClass6_0.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames.__c__DisplayClass6_0>.NativeClassPtr, "url");
				GetReconnectableGames.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames.__c__DisplayClass6_0>.NativeClassPtr, 100664010);
				GetReconnectableGames.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames.__c__DisplayClass6_0>.NativeClassPtr, 100664011);
			}

			// Token: 0x06001615 RID: 5653 RVA: 0x000553F8 File Offset: 0x000535F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetReconnectableGames.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001616 RID: 5654 RVA: 0x00055434 File Offset: 0x00053634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986695, XrefRangeEnd = 986726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__1(DwdWebRequestCommand request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001617 RID: 5655 RVA: 0x0000C534 File Offset: 0x0000A734
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x06001618 RID: 5656 RVA: 0x00055478 File Offset: 0x00053678
			// (set) Token: 0x06001619 RID: 5657 RVA: 0x0000C53D File Offset: 0x0000A73D
			public unsafe GetReconnectableGames __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetReconnectableGames>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x0600161A RID: 5658 RVA: 0x000554A8 File Offset: 0x000536A8
			// (set) Token: 0x0600161B RID: 5659 RVA: 0x0000C55C File Offset: 0x0000A75C
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames.__c__DisplayClass6_0.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames.__c__DisplayClass6_0.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000D66 RID: 3430
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D67 RID: 3431
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x04000D68 RID: 3432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000D69 RID: 3433
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0;
		}

		// Token: 0x020001D1 RID: 465
		[ObfuscatedName("zen.src.matchMaking.commands.GetReconnectableGames+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x0600161C RID: 5660 RVA: 0x000554D0 File Offset: 0x000536D0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetReconnectableGames>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr);
				GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, "<>1__state");
				GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, "<>2__current");
				GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, "<>4__this");
				GetReconnectableGames._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, 100664012);
				GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, 100664013);
				GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, 100664014);
				GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, 100664015);
				GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, 100664016);
				GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr, 100664017);
			}

			// Token: 0x0600161D RID: 5661 RVA: 0x000555B0 File Offset: 0x000537B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetReconnectableGames._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600161E RID: 5662 RVA: 0x000555F8 File Offset: 0x000537F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600161F RID: 5663 RVA: 0x0005562C File Offset: 0x0005382C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986726, XrefRangeEnd = 986756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x06001620 RID: 5664 RVA: 0x00055668 File Offset: 0x00053868
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001621 RID: 5665 RVA: 0x000556A8 File Offset: 0x000538A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986756, XrefRangeEnd = 986761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x06001622 RID: 5666 RVA: 0x000556DC File Offset: 0x000538DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetReconnectableGames._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001623 RID: 5667 RVA: 0x0000C57B File Offset: 0x0000A77B
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x06001624 RID: 5668 RVA: 0x0005571C File Offset: 0x0005391C
			// (set) Token: 0x06001625 RID: 5669 RVA: 0x0000C584 File Offset: 0x0000A784
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x06001626 RID: 5670 RVA: 0x00055744 File Offset: 0x00053944
			// (set) Token: 0x06001627 RID: 5671 RVA: 0x0000C59F File Offset: 0x0000A79F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x06001628 RID: 5672 RVA: 0x00055774 File Offset: 0x00053974
			// (set) Token: 0x06001629 RID: 5673 RVA: 0x0000C5BE File Offset: 0x0000A7BE
			public unsafe GetReconnectableGames __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetReconnectableGames>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetReconnectableGames._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D6A RID: 3434
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D6B RID: 3435
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D6C RID: 3436
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D6D RID: 3437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D6E RID: 3438
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D6F RID: 3439
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D70 RID: 3440
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D71 RID: 3441
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D72 RID: 3442
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
