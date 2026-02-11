using System;
using Canis.entities;
using Canis.hasExecutionStack;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.messages;

namespace Canis.messageRouters
{
	// Token: 0x0200006A RID: 106
	public class MainMessageRouter : MessageRouter
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x0002FE48 File Offset: 0x0002E048
		// Note: this type is marked as 'beforefieldinit'.
		static MainMessageRouter()
		{
			Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messageRouters", "MainMessageRouter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr);
			MainMessageRouter.NativeFieldInfoPtr_mainExecutionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr, "mainExecutionStack");
			MainMessageRouter.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr, 100664472);
			MainMessageRouter.NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr, 100664473);
			MainMessageRouter.NativeMethodInfoPtr_ClearTimers_Public_Void_AccountID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr, 100664474);
			MainMessageRouter.NativeMethodInfoPtr_HasPendingResponse_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr, 100664475);
			MainMessageRouter.NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_PlayerEntity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr, 100664476);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 555193, RefRangeEnd = 555196, XrefRangeStart = 555187, XrefRangeEnd = 555193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMessageRouter(Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0002FF3C File Offset: 0x0002E13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555196, XrefRangeEnd = 555245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool handle(Object response, string messageName, AccountID accountID = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMessageRouter.NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555332, RefRangeEnd = 555333, XrefRangeStart = 555245, XrefRangeEnd = 555332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTimers(AccountID accountID, int counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.NativeMethodInfoPtr_ClearTimers_Public_Void_AccountID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00030008 File Offset: 0x0002E208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555338, RefRangeEnd = 555339, XrefRangeStart = 555333, XrefRangeEnd = 555338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPendingResponse(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.NativeMethodInfoPtr_HasPendingResponse_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00030054 File Offset: 0x0002E254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555339, XrefRangeEnd = 555344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEntity GetPlayerEntityForCounter(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_PlayerEntity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000477F File Offset: 0x0000297F
		public MainMessageRouter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000300A0 File Offset: 0x0002E2A0
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00004788 File Offset: 0x00002988
		public unsafe IHasExecutionStack mainExecutionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.NativeFieldInfoPtr_mainExecutionStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.NativeFieldInfoPtr_mainExecutionStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_mainExecutionStack;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_ClearTimers_Public_Void_AccountID_Int32_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingResponse_Public_Boolean_Int32_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_PlayerEntity_Int32_0;

		// Token: 0x020002BF RID: 703
		[ObfuscatedName("Canis.messageRouters.MainMessageRouter+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001DB5 RID: 7605 RVA: 0x0008B15C File Offset: 0x0008935C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMessageRouter>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr);
				MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, "accountID");
				MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, "counter");
				MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, "<>9__2");
				MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, "<>9__3");
				MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, "<>9__4");
				MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, "<>9__5");
				MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, 100664477);
				MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__0_Internal_Boolean_TimerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, 100664478);
				MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__2_Internal_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, 100664479);
				MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__3_Internal_Boolean_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, 100664480);
				MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__1_Internal_Boolean_TimerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, 100664481);
				MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__4_Internal_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, 100664482);
				MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__5_Internal_Boolean_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr, 100664483);
			}

			// Token: 0x06001DB6 RID: 7606 RVA: 0x0008B28C File Offset: 0x0008948C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMessageRouter.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DB7 RID: 7607 RVA: 0x0008B2C8 File Offset: 0x000894C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555133, XrefRangeEnd = 555156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClearTimers_b__0(TimerInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__0_Internal_Boolean_TimerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DB8 RID: 7608 RVA: 0x0008B318 File Offset: 0x00089518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555156, XrefRangeEnd = 555160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClearTimers_b__2(AccountID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__2_Internal_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DB9 RID: 7609 RVA: 0x0008B368 File Offset: 0x00089568
			[CallerCount(0)]
			public unsafe bool _ClearTimers_b__3(SelectionMessage sel)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__3_Internal_Boolean_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DBA RID: 7610 RVA: 0x0008B3B8 File Offset: 0x000895B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555160, XrefRangeEnd = 555183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClearTimers_b__1(TimerInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__1_Internal_Boolean_TimerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DBB RID: 7611 RVA: 0x0008B408 File Offset: 0x00089608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555183, XrefRangeEnd = 555187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClearTimers_b__4(AccountID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__4_Internal_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DBC RID: 7612 RVA: 0x0008B458 File Offset: 0x00089658
			[CallerCount(0)]
			public unsafe bool _ClearTimers_b__5(SelectionMessage sel)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMessageRouter.__c__DisplayClass3_0.NativeMethodInfoPtr__ClearTimers_b__5_Internal_Boolean_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DBD RID: 7613 RVA: 0x0000E42D File Offset: 0x0000C62D
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0008B4A8 File Offset: 0x000896A8
			// (set) Token: 0x06001DBF RID: 7615 RVA: 0x0000E436 File Offset: 0x0000C636
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x0008B4D8 File Offset: 0x000896D8
			// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x0000E455 File Offset: 0x0000C655
			public unsafe int counter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr_counter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr_counter)) = value;
				}
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0008B500 File Offset: 0x00089700
			// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x0000E470 File Offset: 0x0000C670
			public unsafe Func<AccountID, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountID, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0008B530 File Offset: 0x00089730
			// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x0000E48F File Offset: 0x0000C68F
			public unsafe Func<SelectionMessage, bool> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0008B560 File Offset: 0x00089760
			// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0000E4AE File Offset: 0x0000C6AE
			public unsafe Func<AccountID, bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountID, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0008B590 File Offset: 0x00089790
			// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0000E4CD File Offset: 0x0000C6CD
			public unsafe Func<SelectionMessage, bool> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMessageRouter.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012D7 RID: 4823
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x040012D8 RID: 4824
			private static readonly IntPtr NativeFieldInfoPtr_counter;

			// Token: 0x040012D9 RID: 4825
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040012DA RID: 4826
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x040012DB RID: 4827
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040012DC RID: 4828
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x040012DD RID: 4829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012DE RID: 4830
			private static readonly IntPtr NativeMethodInfoPtr__ClearTimers_b__0_Internal_Boolean_TimerInfo_0;

			// Token: 0x040012DF RID: 4831
			private static readonly IntPtr NativeMethodInfoPtr__ClearTimers_b__2_Internal_Boolean_AccountID_0;

			// Token: 0x040012E0 RID: 4832
			private static readonly IntPtr NativeMethodInfoPtr__ClearTimers_b__3_Internal_Boolean_SelectionMessage_0;

			// Token: 0x040012E1 RID: 4833
			private static readonly IntPtr NativeMethodInfoPtr__ClearTimers_b__1_Internal_Boolean_TimerInfo_0;

			// Token: 0x040012E2 RID: 4834
			private static readonly IntPtr NativeMethodInfoPtr__ClearTimers_b__4_Internal_Boolean_AccountID_0;

			// Token: 0x040012E3 RID: 4835
			private static readonly IntPtr NativeMethodInfoPtr__ClearTimers_b__5_Internal_Boolean_SelectionMessage_0;
		}
	}
}
