using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Steamworks;
using UnityEngine;

namespace boardgames.steam
{
	// Token: 0x02000110 RID: 272
	public class Steam : MonoBehaviour
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x0003C624 File Offset: 0x0003A824
		// Note: this type is marked as 'beforefieldinit'.
		static Steam()
		{
			Il2CppClassPointerStore<Steam>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.steam", "Steam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Steam>.NativeClassPtr);
			Steam.NativeFieldInfoPtr_MAX_RETRY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam>.NativeClassPtr, "MAX_RETRY");
			Steam.NativeFieldInfoPtr_APP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam>.NativeClassPtr, "APP_ID");
			Steam.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam>.NativeClassPtr, "<Initialized>k__BackingField");
			Steam.NativeFieldInfoPtr__InitializeException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam>.NativeClassPtr, "<InitializeException>k__BackingField");
			Steam.NativeFieldInfoPtr__UserStatsReceivedResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam>.NativeClassPtr, "<UserStatsReceivedResult>k__BackingField");
			Steam.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665330);
			Steam.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665331);
			Steam.NativeMethodInfoPtr_get_InitializeException_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665332);
			Steam.NativeMethodInfoPtr_set_InitializeException_Private_set_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665333);
			Steam.NativeMethodInfoPtr_get_UserStatsReceivedResult_Public_get_Nullable_1_ValueTuple_2_SteamId_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665334);
			Steam.NativeMethodInfoPtr_set_UserStatsReceivedResult_Private_set_Void_Nullable_1_ValueTuple_2_SteamId_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665335);
			Steam.NativeMethodInfoPtr_Init_Public_Static_Steam_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665336);
			Steam.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665337);
			Steam.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665338);
			Steam.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665339);
			Steam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665340);
			Steam.NativeMethodInfoPtr__Start_b__15_0_Private_Void_SteamId_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam>.NativeClassPtr, 100665341);
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0003C7A8 File Offset: 0x0003A9A8
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0003C7E4 File Offset: 0x0003A9E4
		public unsafe bool Initialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0003C824 File Offset: 0x0003AA24
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0003C864 File Offset: 0x0003AA64
		public unsafe Exception InitializeException
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_get_InitializeException_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_set_InitializeException_Private_set_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003C8A8 File Offset: 0x0003AAA8
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0003C8E0 File Offset: 0x0003AAE0
		public unsafe Nullable<ValueTuple<SteamId, Result>> UserStatsReceivedResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_get_UserStatsReceivedResult_Public_get_Nullable_1_ValueTuple_2_SteamId_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ValueTuple<SteamId, Result>>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_set_UserStatsReceivedResult_Private_set_Void_Nullable_1_ValueTuple_2_SteamId_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0003C928 File Offset: 0x0003AB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 996302, RefRangeEnd = 996303, XrefRangeStart = 996285, XrefRangeEnd = 996302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Steam Init(uint appID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_Init_Public_Static_Steam_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Steam>(intPtr3) : null;
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0003C968 File Offset: 0x0003AB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996303, XrefRangeEnd = 996308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996308, XrefRangeEnd = 996312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0003C9DC File Offset: 0x0003ABDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996312, XrefRangeEnd = 996316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0003CA10 File Offset: 0x0003AC10
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Steam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Steam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0003CA4C File Offset: 0x0003AC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996316, XrefRangeEnd = 996322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__15_0(SteamId steamId, Result result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam.NativeMethodInfoPtr__Start_b__15_0_Private_Void_SteamId_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00008AD1 File Offset: 0x00006CD1
		public Steam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x0003CA98 File Offset: 0x0003AC98
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00008ADA File Offset: 0x00006CDA
		public unsafe static int MAX_RETRY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Steam.NativeFieldInfoPtr_MAX_RETRY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Steam.NativeFieldInfoPtr_MAX_RETRY, (void*)(&value));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0003CAB4 File Offset: 0x0003ACB4
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00008AE8 File Offset: 0x00006CE8
		public unsafe static uint APP_ID
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Steam.NativeFieldInfoPtr_APP_ID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Steam.NativeFieldInfoPtr_APP_ID, (void*)(&value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0003CAD0 File Offset: 0x0003ACD0
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00008AF6 File Offset: 0x00006CF6
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0003CAF8 File Offset: 0x0003ACF8
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00008B11 File Offset: 0x00006D11
		public unsafe Exception _InitializeException_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam.NativeFieldInfoPtr__InitializeException_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam.NativeFieldInfoPtr__InitializeException_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0003CB28 File Offset: 0x0003AD28
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00008B30 File Offset: 0x00006D30
		public Nullable<ValueTuple<SteamId, Result>> _UserStatsReceivedResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam.NativeFieldInfoPtr__UserStatsReceivedResult_k__BackingField);
				return new Nullable<ValueTuple<SteamId, Result>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ValueTuple<SteamId, Result>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam.NativeFieldInfoPtr__UserStatsReceivedResult_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ValueTuple<SteamId, Result>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_MAX_RETRY;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_APP_ID;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr__InitializeException_k__BackingField;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeFieldInfoPtr__UserStatsReceivedResult_k__BackingField;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializeException_Public_get_Exception_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_set_InitializeException_Private_set_Void_Exception_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_get_UserStatsReceivedResult_Public_get_Nullable_1_ValueTuple_2_SteamId_Result_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_set_UserStatsReceivedResult_Private_set_Void_Nullable_1_ValueTuple_2_SteamId_Result_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Steam_UInt32_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__15_0_Private_Void_SteamId_Result_0;

		// Token: 0x02000256 RID: 598
		[ObfuscatedName("boardgames.steam.Steam+<Start>d__15")]
		public sealed class _Start_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06001B84 RID: 7044 RVA: 0x00065FB4 File Offset: 0x000641B4
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__15()
			{
				Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Steam>.NativeClassPtr, "<Start>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr);
				Steam._Start_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, "<>1__state");
				Steam._Start_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, "<>2__current");
				Steam._Start_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, "<>4__this");
				Steam._Start_d__15.NativeFieldInfoPtr__retryCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, "<retryCount>5__2");
				Steam._Start_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, 100665342);
				Steam._Start_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, 100665343);
				Steam._Start_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, 100665344);
				Steam._Start_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, 100665345);
				Steam._Start_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, 100665346);
				Steam._Start_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr, 100665347);
			}

			// Token: 0x06001B85 RID: 7045 RVA: 0x000660A8 File Offset: 0x000642A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Steam._Start_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam._Start_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B86 RID: 7046 RVA: 0x000660F0 File Offset: 0x000642F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam._Start_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B87 RID: 7047 RVA: 0x00066124 File Offset: 0x00064324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996260, XrefRangeEnd = 996280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam._Start_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000821 RID: 2081
			// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00066160 File Offset: 0x00064360
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam._Start_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B89 RID: 7049 RVA: 0x000661A0 File Offset: 0x000643A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996280, XrefRangeEnd = 996285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam._Start_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000822 RID: 2082
			// (get) Token: 0x06001B8A RID: 7050 RVA: 0x000661D4 File Offset: 0x000643D4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Steam._Start_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B8B RID: 7051 RVA: 0x0000EE77 File Offset: 0x0000D077
			public _Start_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00066214 File Offset: 0x00064414
			// (set) Token: 0x06001B8D RID: 7053 RVA: 0x0000EE80 File Offset: 0x0000D080
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam._Start_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam._Start_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x06001B8E RID: 7054 RVA: 0x0006623C File Offset: 0x0006443C
			// (set) Token: 0x06001B8F RID: 7055 RVA: 0x0000EE9B File Offset: 0x0000D09B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam._Start_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam._Start_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0006626C File Offset: 0x0006446C
			// (set) Token: 0x06001B91 RID: 7057 RVA: 0x0000EEBA File Offset: 0x0000D0BA
			public unsafe Steam __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam._Start_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Steam>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam._Start_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0006629C File Offset: 0x0006449C
			// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0000EED9 File Offset: 0x0000D0D9
			public unsafe int _retryCount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam._Start_d__15.NativeFieldInfoPtr__retryCount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Steam._Start_d__15.NativeFieldInfoPtr__retryCount_5__2)) = value;
				}
			}

			// Token: 0x040010B7 RID: 4279
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010B8 RID: 4280
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010B9 RID: 4281
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040010BA RID: 4282
			private static readonly IntPtr NativeFieldInfoPtr__retryCount_5__2;

			// Token: 0x040010BB RID: 4283
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010BC RID: 4284
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010BD RID: 4285
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010BE RID: 4286
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010BF RID: 4287
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010C0 RID: 4288
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
