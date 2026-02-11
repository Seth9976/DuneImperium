using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000088 RID: 136
	public class VoodooMoveCommand : Command
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x000248B0 File Offset: 0x00022AB0
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooMoveCommand()
		{
			Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooMoveCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr);
			VoodooMoveCommand.NativeFieldInfoPtr_nextMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "nextMove");
			VoodooMoveCommand.NativeFieldInfoPtr_prevMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "prevMove");
			VoodooMoveCommand.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "context");
			VoodooMoveCommand.NativeFieldInfoPtr_destinations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "destinations");
			VoodooMoveCommand.NativeFieldInfoPtr_positionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "positionMap");
			VoodooMoveCommand.NativeFieldInfoPtr_poolManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "poolManager");
			VoodooMoveCommand.NativeFieldInfoPtr_finishedMoves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "finishedMoves");
			VoodooMoveCommand.NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664462);
			VoodooMoveCommand.NativeMethodInfoPtr_AddView_Public_Void_Int32_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664463);
			VoodooMoveCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664464);
			VoodooMoveCommand.NativeMethodInfoPtr_moveItem_Protected_Void_UnitView_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664465);
			VoodooMoveCommand.NativeMethodInfoPtr_onPathUnblock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664466);
			VoodooMoveCommand.NativeMethodInfoPtr_onPathComplete_Private_Void_UnitView_PathAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664467);
			VoodooMoveCommand.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664468);
			VoodooMoveCommand.NativeMethodInfoPtr_validateSlots_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664469);
			VoodooMoveCommand.NativeMethodInfoPtr_initializePositions_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664470);
			VoodooMoveCommand.NativeMethodInfoPtr_waitForMovesToFinish_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664471);
			VoodooMoveCommand.NativeMethodInfoPtr_waitForStagger_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, 100664472);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00024A48 File Offset: 0x00022C48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1115858, RefRangeEnd = 1115864, XrefRangeStart = 1115845, XrefRangeEnd = 1115858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooMoveCommand(MoveContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00024A94 File Offset: 0x00022C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1115881, RefRangeEnd = 1115882, XrefRangeStart = 1115864, XrefRangeEnd = 1115881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddView(int positionInParent, UnitView ev)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positionInParent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ev);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr_AddView_Public_Void_Int32_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00024AE4 File Offset: 0x00022CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115882, XrefRangeEnd = 1115886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooMoveCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00024B30 File Offset: 0x00022D30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1115968, RefRangeEnd = 1115970, XrefRangeStart = 1115886, XrefRangeEnd = 1115968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void moveItem(UnitView unit, LocalTransform destLocalTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLocalTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr_moveItem_Protected_Void_UnitView_LocalTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00024B80 File Offset: 0x00022D80
		[CallerCount(0)]
		public unsafe void onPathUnblock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr_onPathUnblock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00024BB4 File Offset: 0x00022DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115970, XrefRangeEnd = 1115976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onPathComplete(UnitView view, PathAnimator path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr_onPathComplete_Private_Void_UnitView_PathAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00024C08 File Offset: 0x00022E08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1115986, RefRangeEnd = 1115989, XrefRangeStart = 1115976, XrefRangeEnd = 1115986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooMoveCommand.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00024C58 File Offset: 0x00022E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1116003, RefRangeEnd = 1116004, XrefRangeStart = 1115989, XrefRangeEnd = 1116003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void validateSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr_validateSlots_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00024C8C File Offset: 0x00022E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1116028, RefRangeEnd = 1116029, XrefRangeStart = 1116004, XrefRangeEnd = 1116028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initializePositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr_initializePositions_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00024CC0 File Offset: 0x00022EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1116034, RefRangeEnd = 1116035, XrefRangeStart = 1116029, XrefRangeEnd = 1116034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForMovesToFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr_waitForMovesToFinish_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00024D00 File Offset: 0x00022F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1116040, RefRangeEnd = 1116041, XrefRangeStart = 1116035, XrefRangeEnd = 1116040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.NativeMethodInfoPtr_waitForStagger_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00005FB5 File Offset: 0x000041B5
		public VoodooMoveCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00024D40 File Offset: 0x00022F40
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00005FBE File Offset: 0x000041BE
		public unsafe VoodooMoveCommand nextMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_nextMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooMoveCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_nextMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00024D70 File Offset: 0x00022F70
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00005FDD File Offset: 0x000041DD
		public unsafe VoodooMoveCommand prevMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_prevMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooMoveCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_prevMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00024DA0 File Offset: 0x00022FA0
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00005FFC File Offset: 0x000041FC
		public new unsafe MoveContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00024DD0 File Offset: 0x00022FD0
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x0000601B File Offset: 0x0000421B
		public unsafe Il2CppStructArray<LocalTransform> destinations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_destinations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LocalTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_destinations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00024E00 File Offset: 0x00023000
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x0000603A File Offset: 0x0000423A
		public unsafe Dictionary<UnitView, UnitPosition> positionMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_positionMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UnitView, UnitPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_positionMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00024E30 File Offset: 0x00023030
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00006059 File Offset: 0x00004259
		public unsafe PoolManager poolManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_poolManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_poolManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00024E60 File Offset: 0x00023060
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00006078 File Offset: 0x00004278
		public unsafe int finishedMoves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_finishedMoves);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.NativeFieldInfoPtr_finishedMoves)) = value;
			}
		}

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr_nextMove;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeFieldInfoPtr_prevMove;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeFieldInfoPtr_destinations;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeFieldInfoPtr_positionMap;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeFieldInfoPtr_poolManager;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeFieldInfoPtr_finishedMoves;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_AddView_Public_Void_Int32_UnitView_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_moveItem_Protected_Void_UnitView_LocalTransform_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_onPathUnblock_Private_Void_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_onPathComplete_Private_Void_UnitView_PathAnimator_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_New_Void_UnitView_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_validateSlots_Protected_Void_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_initializePositions_Protected_Void_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_waitForMovesToFinish_Protected_IEnumerator_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_waitForStagger_Protected_IEnumerator_0;

		// Token: 0x0200010A RID: 266
		[ObfuscatedName("lotus.VoodooMoveCommand+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06000DC7 RID: 3527 RVA: 0x00035AD4 File Offset: 0x00033CD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<VoodooMoveCommand.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooMoveCommand.__c__DisplayClass10_0>.NativeClassPtr);
				VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand.__c__DisplayClass10_0>.NativeClassPtr, "unit");
				VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand.__c__DisplayClass10_0>.NativeClassPtr, "path");
				VoodooMoveCommand.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand.__c__DisplayClass10_0>.NativeClassPtr, 100664473);
				VoodooMoveCommand.__c__DisplayClass10_0.NativeMethodInfoPtr__moveItem_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand.__c__DisplayClass10_0>.NativeClassPtr, 100664474);
			}

			// Token: 0x06000DC8 RID: 3528 RVA: 0x00035B64 File Offset: 0x00033D64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooMoveCommand.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DC9 RID: 3529 RVA: 0x00035BA0 File Offset: 0x00033DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115815, XrefRangeEnd = 1115821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _moveItem_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand.__c__DisplayClass10_0.NativeMethodInfoPtr__moveItem_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DCA RID: 3530 RVA: 0x00008DAB File Offset: 0x00006FAB
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00035BD4 File Offset: 0x00033DD4
			// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00008DB4 File Offset: 0x00006FB4
			public unsafe VoodooMoveCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooMoveCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00035C04 File Offset: 0x00033E04
			// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00008DD3 File Offset: 0x00006FD3
			public unsafe UnitView unit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr_unit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr_unit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00035C34 File Offset: 0x00033E34
			// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00008DF2 File Offset: 0x00006FF2
			public unsafe PathAnimator path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr_path);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand.__c__DisplayClass10_0.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400088D RID: 2189
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400088E RID: 2190
			private static readonly IntPtr NativeFieldInfoPtr_unit;

			// Token: 0x0400088F RID: 2191
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04000890 RID: 2192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000891 RID: 2193
			private static readonly IntPtr NativeMethodInfoPtr__moveItem_b__0_Internal_Void_0;
		}

		// Token: 0x0200010B RID: 267
		[ObfuscatedName("lotus.VoodooMoveCommand+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x06000DD1 RID: 3537 RVA: 0x00035C64 File Offset: 0x00033E64
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr);
				VoodooMoveCommand._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr, "<>1__state");
				VoodooMoveCommand._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr, "<>2__current");
				VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr, 100664475);
				VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr, 100664476);
				VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr, 100664477);
				VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr, 100664478);
				VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr, 100664479);
				VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr, 100664480);
			}

			// Token: 0x06000DD2 RID: 3538 RVA: 0x00035D30 File Offset: 0x00033F30
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooMoveCommand._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DD3 RID: 3539 RVA: 0x00035D78 File Offset: 0x00033F78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DD4 RID: 3540 RVA: 0x00035DAC File Offset: 0x00033FAC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00035DE8 File Offset: 0x00033FE8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DD6 RID: 3542 RVA: 0x00035E28 File Offset: 0x00034028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115821, XrefRangeEnd = 1115826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00035E5C File Offset: 0x0003405C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DD8 RID: 3544 RVA: 0x00008E11 File Offset: 0x00007011
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00035E9C File Offset: 0x0003409C
			// (set) Token: 0x06000DDA RID: 3546 RVA: 0x00008E1A File Offset: 0x0000701A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00035EC4 File Offset: 0x000340C4
			// (set) Token: 0x06000DDC RID: 3548 RVA: 0x00008E35 File Offset: 0x00007035
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000892 RID: 2194
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000893 RID: 2195
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000894 RID: 2196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000895 RID: 2197
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000896 RID: 2198
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000897 RID: 2199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000898 RID: 2200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000899 RID: 2201
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200010C RID: 268
		[ObfuscatedName("lotus.VoodooMoveCommand+<waitForMovesToFinish>d__16")]
		public sealed class _waitForMovesToFinish_d__16 : Object
		{
			// Token: 0x06000DDD RID: 3549 RVA: 0x00035EF4 File Offset: 0x000340F4
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForMovesToFinish_d__16()
			{
				Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "<waitForMovesToFinish>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr);
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, "<>1__state");
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, "<>2__current");
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, "<>4__this");
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, 100664481);
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, 100664482);
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, 100664483);
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, 100664484);
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, 100664485);
				VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr, 100664486);
			}

			// Token: 0x06000DDE RID: 3550 RVA: 0x00035FD4 File Offset: 0x000341D4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForMovesToFinish_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooMoveCommand._waitForMovesToFinish_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DDF RID: 3551 RVA: 0x0003601C File Offset: 0x0003421C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DE0 RID: 3552 RVA: 0x00036050 File Offset: 0x00034250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115826, XrefRangeEnd = 1115828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0003608C File Offset: 0x0003428C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DE2 RID: 3554 RVA: 0x000360CC File Offset: 0x000342CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115828, XrefRangeEnd = 1115833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00036100 File Offset: 0x00034300
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DE4 RID: 3556 RVA: 0x00008E54 File Offset: 0x00007054
			public _waitForMovesToFinish_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00036140 File Offset: 0x00034340
			// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x00008E5D File Offset: 0x0000705D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00036168 File Offset: 0x00034368
			// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x00008E78 File Offset: 0x00007078
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00036198 File Offset: 0x00034398
			// (set) Token: 0x06000DEA RID: 3562 RVA: 0x00008E97 File Offset: 0x00007097
			public unsafe VoodooMoveCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooMoveCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForMovesToFinish_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400089A RID: 2202
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400089B RID: 2203
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400089C RID: 2204
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400089D RID: 2205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400089E RID: 2206
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400089F RID: 2207
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008A0 RID: 2208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008A1 RID: 2209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008A2 RID: 2210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200010D RID: 269
		[ObfuscatedName("lotus.VoodooMoveCommand+<waitForStagger>d__17")]
		public sealed class _waitForStagger_d__17 : Object
		{
			// Token: 0x06000DEB RID: 3563 RVA: 0x000361C8 File Offset: 0x000343C8
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForStagger_d__17()
			{
				Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooMoveCommand>.NativeClassPtr, "<waitForStagger>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr);
				VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, "<>1__state");
				VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, "<>2__current");
				VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, "<>4__this");
				VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, 100664487);
				VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, 100664488);
				VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, 100664489);
				VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, 100664490);
				VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, 100664491);
				VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr, 100664492);
			}

			// Token: 0x06000DEC RID: 3564 RVA: 0x000362A8 File Offset: 0x000344A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForStagger_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooMoveCommand._waitForStagger_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DED RID: 3565 RVA: 0x000362F0 File Offset: 0x000344F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DEE RID: 3566 RVA: 0x00036324 File Offset: 0x00034524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115833, XrefRangeEnd = 1115840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00036360 File Offset: 0x00034560
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DF0 RID: 3568 RVA: 0x000363A0 File Offset: 0x000345A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115840, XrefRangeEnd = 1115845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x000363D4 File Offset: 0x000345D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooMoveCommand._waitForStagger_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DF2 RID: 3570 RVA: 0x00008EB6 File Offset: 0x000070B6
			public _waitForStagger_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00036414 File Offset: 0x00034614
			// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x00008EBF File Offset: 0x000070BF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0003643C File Offset: 0x0003463C
			// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00008EDA File Offset: 0x000070DA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0003646C File Offset: 0x0003466C
			// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00008EF9 File Offset: 0x000070F9
			public unsafe VoodooMoveCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooMoveCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooMoveCommand._waitForStagger_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008A3 RID: 2211
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008A4 RID: 2212
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008A5 RID: 2213
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008A6 RID: 2214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008A7 RID: 2215
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008A8 RID: 2216
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008A9 RID: 2217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008AA RID: 2218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008AB RID: 2219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
