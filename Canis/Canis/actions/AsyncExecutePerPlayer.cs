using System;
using Canis.actions.serialized;
using Canis.data;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x02000199 RID: 409
	public class AsyncExecutePerPlayer : Action
	{
		// Token: 0x060011C5 RID: 4549 RVA: 0x00061690 File Offset: 0x0005F890
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncExecutePerPlayer()
		{
			Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "AsyncExecutePerPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr);
			AsyncExecutePerPlayer.NativeFieldInfoPtr_halt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "halt");
			AsyncExecutePerPlayer.NativeFieldInfoPtr_actionGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "actionGenerator");
			AsyncExecutePerPlayer.NativeFieldInfoPtr_currentPlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "currentPlayerIndex");
			AsyncExecutePerPlayer.NativeFieldInfoPtr__LastAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "<LastAction>k__BackingField");
			AsyncExecutePerPlayer.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "id");
			AsyncExecutePerPlayer.NativeFieldInfoPtr_runningPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "runningPlayers");
			AsyncExecutePerPlayer.NativeFieldInfoPtr_currentPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "currentPlayer");
			AsyncExecutePerPlayer.NativeMethodInfoPtr_get_LastAction_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667053);
			AsyncExecutePerPlayer.NativeMethodInfoPtr_set_LastAction_Private_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667054);
			AsyncExecutePerPlayer.NativeMethodInfoPtr__ctor_Public_Void_Func_2_PlayerEntity_Action_IEnumerable_1_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667055);
			AsyncExecutePerPlayer.NativeMethodInfoPtr__ctor_Public_Void_SerializedAsyncExecutePerPlayer_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667056);
			AsyncExecutePerPlayer.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667057);
			AsyncExecutePerPlayer.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667058);
			AsyncExecutePerPlayer.NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667059);
			AsyncExecutePerPlayer.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667060);
			AsyncExecutePerPlayer.NativeMethodInfoPtr__HandleReturningAction_b__13_0_Private_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667061);
			AsyncExecutePerPlayer.NativeMethodInfoPtr__HandleReturningAction_b__13_1_Private_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667062);
			AsyncExecutePerPlayer.NativeMethodInfoPtr__HandleReturningAction_b__13_2_Private_Boolean_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, 100667063);
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00061828 File Offset: 0x0005FA28
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x00061868 File Offset: 0x0005FA68
		public unsafe Action LastAction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.NativeMethodInfoPtr_get_LastAction_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.NativeMethodInfoPtr_set_LastAction_Private_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x000618AC File Offset: 0x0005FAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584455, XrefRangeEnd = 584468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncExecutePerPlayer(Func<PlayerEntity, Action> actionGenerator, IEnumerable<PlayerEntity> playersToRun, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionGenerator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playersToRun);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.NativeMethodInfoPtr__ctor_Public_Void_Func_2_PlayerEntity_Action_IEnumerable_1_PlayerEntity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0006191C File Offset: 0x0005FB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584468, XrefRangeEnd = 584494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncExecutePerPlayer(SerializedAsyncExecutePerPlayer serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.NativeMethodInfoPtr__ctor_Public_Void_SerializedAsyncExecutePerPlayer_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0006197C File Offset: 0x0005FB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584494, XrefRangeEnd = 584500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncExecutePerPlayer.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000619C8 File Offset: 0x0005FBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584500, XrefRangeEnd = 584510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncExecutePerPlayer.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00061A18 File Offset: 0x0005FC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584510, XrefRangeEnd = 584511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action Intercept(Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00061A68 File Offset: 0x0005FC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584511, XrefRangeEnd = 584539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncExecutePerPlayer.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00061AC4 File Offset: 0x0005FCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584539, XrefRangeEnd = 584549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _HandleReturningAction_b__13_0(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.NativeMethodInfoPtr__HandleReturningAction_b__13_0_Private_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00061B14 File Offset: 0x0005FD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584549, XrefRangeEnd = 584561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _HandleReturningAction_b__13_1(PendingSelection selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.NativeMethodInfoPtr__HandleReturningAction_b__13_1_Private_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00061B64 File Offset: 0x0005FD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584561, XrefRangeEnd = 584568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _HandleReturningAction_b__13_2(SerializedAction sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.NativeMethodInfoPtr__HandleReturningAction_b__13_2_Private_Boolean_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00008D35 File Offset: 0x00006F35
		public AsyncExecutePerPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00061BB4 File Offset: 0x0005FDB4
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x00008D3E File Offset: 0x00006F3E
		public unsafe bool halt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_halt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_halt)) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00061BDC File Offset: 0x0005FDDC
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x00008D59 File Offset: 0x00006F59
		public unsafe Func<PlayerEntity, Action> actionGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_actionGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_actionGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00061C0C File Offset: 0x0005FE0C
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x00008D78 File Offset: 0x00006F78
		public unsafe int currentPlayerIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_currentPlayerIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_currentPlayerIndex)) = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00061C34 File Offset: 0x0005FE34
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x00008D93 File Offset: 0x00006F93
		public unsafe Action _LastAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr__LastAction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr__LastAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00061C64 File Offset: 0x0005FE64
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x00008DB2 File Offset: 0x00006FB2
		public unsafe WrappedID id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WrappedID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00061C94 File Offset: 0x0005FE94
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x00008DD1 File Offset: 0x00006FD1
		public unsafe List<PlayerEntity> runningPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_runningPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_runningPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00061CC4 File Offset: 0x0005FEC4
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x00008DF0 File Offset: 0x00006FF0
		public unsafe PlayerEntity currentPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_currentPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.NativeFieldInfoPtr_currentPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr_halt;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeFieldInfoPtr_actionGenerator;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerIndex;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeFieldInfoPtr__LastAction_k__BackingField;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_runningPlayers;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayer;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_get_LastAction_Public_get_Action_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_set_LastAction_Private_set_Void_Action_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_PlayerEntity_Action_IEnumerable_1_PlayerEntity_Match_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAsyncExecutePerPlayer_Match_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Action_Action_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr__HandleReturningAction_b__13_0_Private_Boolean_PlayerEntity_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr__HandleReturningAction_b__13_1_Private_Boolean_PendingSelection_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr__HandleReturningAction_b__13_2_Private_Boolean_SerializedAction_0;

		// Token: 0x020003D5 RID: 981
		[ObfuscatedName("Canis.actions.AsyncExecutePerPlayer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002992 RID: 10642 RVA: 0x000B3578 File Offset: 0x000B1778
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AsyncExecutePerPlayer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c>.NativeClassPtr);
				AsyncExecutePerPlayer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c>.NativeClassPtr, "<>9");
				AsyncExecutePerPlayer.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c>.NativeClassPtr, "<>9__15_0");
				AsyncExecutePerPlayer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c>.NativeClassPtr, 100667065);
				AsyncExecutePerPlayer.__c.NativeMethodInfoPtr__MakeSerializedAction_b__15_0_Internal_EntityID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c>.NativeClassPtr, 100667066);
			}

			// Token: 0x06002993 RID: 10643 RVA: 0x000B35F4 File Offset: 0x000B17F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002994 RID: 10644 RVA: 0x000B3630 File Offset: 0x000B1830
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedAction_b__15_0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.__c.NativeMethodInfoPtr__MakeSerializedAction_b__15_0_Internal_EntityID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06002995 RID: 10645 RVA: 0x00013DFE File Offset: 0x00011FFE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x06002996 RID: 10646 RVA: 0x000B3680 File Offset: 0x000B1880
			// (set) Token: 0x06002997 RID: 10647 RVA: 0x00013E07 File Offset: 0x00012007
			public unsafe static AsyncExecutePerPlayer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncExecutePerPlayer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncExecutePerPlayer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncExecutePerPlayer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x06002998 RID: 10648 RVA: 0x000B36A8 File Offset: 0x000B18A8
			// (set) Token: 0x06002999 RID: 10649 RVA: 0x00013E19 File Offset: 0x00012019
			public unsafe static Func<PlayerEntity, EntityID> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncExecutePerPlayer.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncExecutePerPlayer.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019FA RID: 6650
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019FB RID: 6651
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040019FC RID: 6652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019FD RID: 6653
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__15_0_Internal_EntityID_PlayerEntity_0;
		}

		// Token: 0x020003D6 RID: 982
		[ObfuscatedName("Canis.actions.AsyncExecutePerPlayer+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600299A RID: 10650 RVA: 0x000B36D0 File Offset: 0x000B18D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<AsyncExecutePerPlayer.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c__DisplayClass11_0>.NativeClassPtr);
				AsyncExecutePerPlayer.__c__DisplayClass11_0.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c__DisplayClass11_0>.NativeClassPtr, "m");
				AsyncExecutePerPlayer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c__DisplayClass11_0>.NativeClassPtr, 100667067);
				AsyncExecutePerPlayer.__c__DisplayClass11_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_PlayerEntity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c__DisplayClass11_0>.NativeClassPtr, 100667068);
			}

			// Token: 0x0600299B RID: 10651 RVA: 0x000B3738 File Offset: 0x000B1938
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncExecutePerPlayer.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600299C RID: 10652 RVA: 0x000B3774 File Offset: 0x000B1974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584413, XrefRangeEnd = 584426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PlayerEntity> __ctor_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer.__c__DisplayClass11_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_PlayerEntity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
				}
			}

			// Token: 0x0600299D RID: 10653 RVA: 0x00013E2B File Offset: 0x0001202B
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x0600299E RID: 10654 RVA: 0x000B37C4 File Offset: 0x000B19C4
			// (set) Token: 0x0600299F RID: 10655 RVA: 0x00013E34 File Offset: 0x00012034
			public unsafe Match m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.__c__DisplayClass11_0.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer.__c__DisplayClass11_0.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019FE RID: 6654
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x040019FF RID: 6655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A00 RID: 6656
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_PlayerEntity_EntityID_0;
		}

		// Token: 0x020003D7 RID: 983
		[ObfuscatedName("Canis.actions.AsyncExecutePerPlayer+<execute>d__12")]
		public sealed class _execute_d__12 : Object
		{
			// Token: 0x060029A0 RID: 10656 RVA: 0x000B37F4 File Offset: 0x000B19F4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__12()
			{
				Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncExecutePerPlayer>.NativeClassPtr, "<execute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr);
				AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, "<>1__state");
				AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, "<>2__current");
				AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, "<>l__initialThreadId");
				AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, "<>4__this");
				AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, 100667069);
				AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, 100667070);
				AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, 100667071);
				AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, 100667072);
				AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, 100667073);
				AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, 100667074);
				AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, 100667075);
				AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr, 100667076);
			}

			// Token: 0x060029A1 RID: 10657 RVA: 0x000B3910 File Offset: 0x000B1B10
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncExecutePerPlayer._execute_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029A2 RID: 10658 RVA: 0x000B3958 File Offset: 0x000B1B58
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029A3 RID: 10659 RVA: 0x000B398C File Offset: 0x000B1B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584426, XrefRangeEnd = 584448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A84 RID: 2692
			// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000B39C8 File Offset: 0x000B1BC8
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060029A5 RID: 10661 RVA: 0x000B3A08 File Offset: 0x000B1C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584448, XrefRangeEnd = 584453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000B3A3C File Offset: 0x000B1C3C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029A7 RID: 10663 RVA: 0x000B3A7C File Offset: 0x000B1C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584453, XrefRangeEnd = 584455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060029A8 RID: 10664 RVA: 0x000B3ABC File Offset: 0x000B1CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncExecutePerPlayer._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060029A9 RID: 10665 RVA: 0x00013E53 File Offset: 0x00012053
			public _execute_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x060029AA RID: 10666 RVA: 0x000B3AFC File Offset: 0x000B1CFC
			// (set) Token: 0x060029AB RID: 10667 RVA: 0x00013E5C File Offset: 0x0001205C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x060029AC RID: 10668 RVA: 0x000B3B24 File Offset: 0x000B1D24
			// (set) Token: 0x060029AD RID: 10669 RVA: 0x00013E77 File Offset: 0x00012077
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A82 RID: 2690
			// (get) Token: 0x060029AE RID: 10670 RVA: 0x000B3B54 File Offset: 0x000B1D54
			// (set) Token: 0x060029AF RID: 10671 RVA: 0x00013E96 File Offset: 0x00012096
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000B3B7C File Offset: 0x000B1D7C
			// (set) Token: 0x060029B1 RID: 10673 RVA: 0x00013EB1 File Offset: 0x000120B1
			public unsafe AsyncExecutePerPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncExecutePerPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncExecutePerPlayer._execute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A01 RID: 6657
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A02 RID: 6658
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A03 RID: 6659
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001A04 RID: 6660
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A05 RID: 6661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A06 RID: 6662
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A07 RID: 6663
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A08 RID: 6664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001A09 RID: 6665
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A0A RID: 6666
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A0B RID: 6667
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001A0C RID: 6668
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
