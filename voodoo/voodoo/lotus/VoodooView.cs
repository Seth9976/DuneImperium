using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200008A RID: 138
	public class VoodooView : MonoBehaviour
	{
		// Token: 0x06000845 RID: 2117 RVA: 0x00024FEC File Offset: 0x000231EC
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooView()
		{
			Il2CppClassPointerStore<VoodooView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooView>.NativeClassPtr);
			VoodooView.NativeFieldInfoPtr_Unblock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "Unblock");
			VoodooView.NativeFieldInfoPtr_Stagger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "Stagger");
			VoodooView.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "Visible");
			VoodooView.NativeFieldInfoPtr_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "Hidden");
			VoodooView.NativeFieldInfoPtr_In = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "In");
			VoodooView.NativeFieldInfoPtr_Out = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "Out");
			VoodooView.NativeFieldInfoPtr_logAnimationSignals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "logAnimationSignals");
			VoodooView.NativeFieldInfoPtr_logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "logging");
			VoodooView.NativeFieldInfoPtr__Animator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "<Animator>k__BackingField");
			VoodooView.NativeFieldInfoPtr_OnAnimationSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "OnAnimationSignal");
			VoodooView.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "um");
			VoodooView.NativeFieldInfoPtr_vm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "vm");
			VoodooView.NativeFieldInfoPtr_pm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "pm");
			VoodooView.NativeFieldInfoPtr_cachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "cachedTransform");
			VoodooView.NativeFieldInfoPtr_cachedPoolable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "cachedPoolable");
			VoodooView.NativeFieldInfoPtr_dirtyNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "dirtyNode");
			VoodooView.NativeMethodInfoPtr_get_Animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664496);
			VoodooView.NativeMethodInfoPtr_set_Animator_Public_set_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664497);
			VoodooView.NativeMethodInfoPtr_get_t_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664498);
			VoodooView.NativeMethodInfoPtr_get_poolable_Public_get_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664499);
			VoodooView.NativeMethodInfoPtr_AttachToPoolable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664500);
			VoodooView.NativeMethodInfoPtr_InitProperties_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664501);
			VoodooView.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664502);
			VoodooView.NativeMethodInfoPtr_OnSpawn_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664503);
			VoodooView.NativeMethodInfoPtr_InitFromContext_Public_Virtual_New_Void_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664504);
			VoodooView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_New_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664505);
			VoodooView.NativeMethodInfoPtr_markDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664506);
			VoodooView.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664507);
			VoodooView.NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664508);
			VoodooView.NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664509);
			VoodooView.NativeMethodInfoPtr_PlayTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664510);
			VoodooView.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664511);
			VoodooView.NativeMethodInfoPtr_GetBool_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664512);
			VoodooView.NativeMethodInfoPtr_AnimationSignal_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664513);
			VoodooView.NativeMethodInfoPtr_WaitForSignal_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664514);
			VoodooView.NativeMethodInfoPtr_BubbleUpSignal_Public_Void_String_VoodooView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664515);
			VoodooView.NativeMethodInfoPtr_bubbleSignalRoutine_Private_IEnumerator_String_VoodooView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664516);
			VoodooView.NativeMethodInfoPtr_DestroyNow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664517);
			VoodooView.NativeMethodInfoPtr_Log_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664518);
			VoodooView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, 100664519);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0002533C File Offset: 0x0002353C
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0002537C File Offset: 0x0002357C
		public unsafe Animator Animator
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_get_Animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_set_Animator_Public_set_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x000253C0 File Offset: 0x000235C0
		public unsafe Transform t
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 1116199, RefRangeEnd = 1116240, XrefRangeStart = 1116193, XrefRangeEnd = 1116199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_get_t_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00025400 File Offset: 0x00023600
		public unsafe PoolableItem poolable
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 1116241, RefRangeEnd = 1116275, XrefRangeStart = 1116240, XrefRangeEnd = 1116241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_get_poolable_Public_get_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr3) : null;
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00025440 File Offset: 0x00023640
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1116304, RefRangeEnd = 1116314, XrefRangeStart = 1116275, XrefRangeEnd = 1116304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachToPoolable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_AttachToPoolable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00025474 File Offset: 0x00023674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1116337, RefRangeEnd = 1116338, XrefRangeStart = 1116314, XrefRangeEnd = 1116337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooView.NativeMethodInfoPtr_InitProperties_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000254B0 File Offset: 0x000236B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1116343, RefRangeEnd = 1116345, XrefRangeStart = 1116338, XrefRangeEnd = 1116343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooView.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000254EC File Offset: 0x000236EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312313, RefRangeEnd = 312315, XrefRangeStart = 312313, XrefRangeEnd = 312315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSpawn(PoolableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_OnSpawn_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00025530 File Offset: 0x00023730
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitFromContext(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooView.NativeMethodInfoPtr_InitFromContext_Public_Virtual_New_Void_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00025580 File Offset: 0x00023780
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1116357, RefRangeEnd = 1116359, XrefRangeStart = 1116345, XrefRangeEnd = 1116357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_New_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000255D0 File Offset: 0x000237D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1116364, RefRangeEnd = 1116369, XrefRangeStart = 1116359, XrefRangeEnd = 1116364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void markDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_markDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00025604 File Offset: 0x00023804
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooView.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00025640 File Offset: 0x00023840
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x00025680 File Offset: 0x00023880
		public unsafe virtual LinkedListNode<IAmDirty> DirtyNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116369, XrefRangeEnd = 1116376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000256C4 File Offset: 0x000238C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1116378, RefRangeEnd = 1116379, XrefRangeStart = 1116376, XrefRangeEnd = 1116378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_PlayTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00025708 File Offset: 0x00023908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116379, XrefRangeEnd = 1116381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string key, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00025758 File Offset: 0x00023958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116381, XrefRangeEnd = 1116382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBool(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_GetBool_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000257A8 File Offset: 0x000239A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1116386, RefRangeEnd = 1116388, XrefRangeStart = 1116382, XrefRangeEnd = 1116386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimationSignal(string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_AnimationSignal_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000257EC File Offset: 0x000239EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1116394, RefRangeEnd = 1116397, XrefRangeStart = 1116388, XrefRangeEnd = 1116394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForSignal(string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_WaitForSignal_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0002583C File Offset: 0x00023A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116397, XrefRangeEnd = 1116405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BubbleUpSignal(string signal, VoodooView bubbleView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bubbleView);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_BubbleUpSignal_Public_Void_String_VoodooView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00025890 File Offset: 0x00023A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116405, XrefRangeEnd = 1116412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator bubbleSignalRoutine(string signal, VoodooView bubbleView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bubbleView);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_bubbleSignalRoutine_Private_IEnumerator_String_VoodooView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000258F4 File Offset: 0x00023AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116412, XrefRangeEnd = 1116441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_DestroyNow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00025928 File Offset: 0x00023B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116441, XrefRangeEnd = 1116453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Log(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr_Log_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0002596C File Offset: 0x00023B6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1116459, RefRangeEnd = 1116462, XrefRangeStart = 1116453, XrefRangeEnd = 1116459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0000609C File Offset: 0x0000429C
		public VoodooView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000259A8 File Offset: 0x00023BA8
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x000060A5 File Offset: 0x000042A5
		public unsafe static string Unblock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VoodooView.NativeFieldInfoPtr_Unblock, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VoodooView.NativeFieldInfoPtr_Unblock, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000259C8 File Offset: 0x00023BC8
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x000060B7 File Offset: 0x000042B7
		public unsafe static string Stagger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VoodooView.NativeFieldInfoPtr_Stagger, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VoodooView.NativeFieldInfoPtr_Stagger, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000259E8 File Offset: 0x00023BE8
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x000060C9 File Offset: 0x000042C9
		public unsafe static string Visible
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VoodooView.NativeFieldInfoPtr_Visible, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VoodooView.NativeFieldInfoPtr_Visible, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00025A08 File Offset: 0x00023C08
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x000060DB File Offset: 0x000042DB
		public unsafe static string Hidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VoodooView.NativeFieldInfoPtr_Hidden, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VoodooView.NativeFieldInfoPtr_Hidden, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00025A28 File Offset: 0x00023C28
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x000060ED File Offset: 0x000042ED
		public unsafe static string In
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VoodooView.NativeFieldInfoPtr_In, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VoodooView.NativeFieldInfoPtr_In, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00025A48 File Offset: 0x00023C48
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x000060FF File Offset: 0x000042FF
		public unsafe static string Out
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VoodooView.NativeFieldInfoPtr_Out, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VoodooView.NativeFieldInfoPtr_Out, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00025A68 File Offset: 0x00023C68
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00006111 File Offset: 0x00004311
		public unsafe static bool logAnimationSignals
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(VoodooView.NativeFieldInfoPtr_logAnimationSignals, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VoodooView.NativeFieldInfoPtr_logAnimationSignals, (void*)(&value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00025A84 File Offset: 0x00023C84
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0000611F File Offset: 0x0000431F
		public unsafe bool logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_logging)) = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00025AAC File Offset: 0x00023CAC
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x0000613A File Offset: 0x0000433A
		public unsafe Animator _Animator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr__Animator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr__Animator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00025ADC File Offset: 0x00023CDC
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00006159 File Offset: 0x00004359
		public unsafe AnimationSignalEvent OnAnimationSignal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_OnAnimationSignal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationSignalEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_OnAnimationSignal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00025B0C File Offset: 0x00023D0C
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00006178 File Offset: 0x00004378
		public unsafe UpdateManager um
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_um);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00025B3C File Offset: 0x00023D3C
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00006197 File Offset: 0x00004397
		public unsafe ViewManager vm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_vm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_vm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00025B6C File Offset: 0x00023D6C
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x000061B6 File Offset: 0x000043B6
		public unsafe PoolManager pm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_pm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_pm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00025B9C File Offset: 0x00023D9C
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x000061D5 File Offset: 0x000043D5
		public unsafe Transform cachedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_cachedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_cachedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00025BCC File Offset: 0x00023DCC
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x000061F4 File Offset: 0x000043F4
		public unsafe PoolableItem cachedPoolable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_cachedPoolable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_cachedPoolable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00025BFC File Offset: 0x00023DFC
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00006213 File Offset: 0x00004413
		public unsafe LinkedListNode<IAmDirty> dirtyNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_dirtyNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView.NativeFieldInfoPtr_dirtyNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr_Unblock;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_Stagger;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_Visible;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_Hidden;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_In;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_Out;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_logAnimationSignals;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_logging;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr__Animator_k__BackingField;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_OnAnimationSignal;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_um;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_vm;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_pm;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_cachedTransform;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_cachedPoolable;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_dirtyNode;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_get_Animator_Public_get_Animator_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_set_Animator_Public_set_Void_Animator_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_get_t_Public_get_Transform_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_get_poolable_Public_get_PoolableItem_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_AttachToPoolable_Private_Void_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_InitProperties_Public_Virtual_New_Void_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawn_Private_Void_PoolableItem_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_InitFromContext_Public_Virtual_New_Void_EntityInitializationContext_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_OnDespawn_Public_Virtual_New_Void_PoolableItem_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_markDirty_Public_Void_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_PlayTrigger_Public_Void_String_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_AnimationSignal_Public_Void_String_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_WaitForSignal_Public_IEnumerator_String_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_BubbleUpSignal_Public_Void_String_VoodooView_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_bubbleSignalRoutine_Private_IEnumerator_String_VoodooView_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_DestroyNow_Public_Void_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Void_String_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200010E RID: 270
		[ObfuscatedName("lotus.VoodooView+<WaitForSignal>d__38")]
		public sealed class _WaitForSignal_d__38 : global::Il2CppSystem.Object
		{
			// Token: 0x06000DF9 RID: 3577 RVA: 0x0003649C File Offset: 0x0003469C
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForSignal_d__38()
			{
				Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "<WaitForSignal>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr);
				VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, "<>1__state");
				VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, "<>2__current");
				VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr_signal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, "signal");
				VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, "<>4__this");
				VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr__asd_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, "<asd>5__2");
				VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, 100664520);
				VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, 100664521);
				VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, 100664522);
				VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, 100664523);
				VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, 100664524);
				VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr, 100664525);
			}

			// Token: 0x06000DFA RID: 3578 RVA: 0x000365A4 File Offset: 0x000347A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForSignal_d__38(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooView._WaitForSignal_d__38>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DFB RID: 3579 RVA: 0x000365EC File Offset: 0x000347EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DFC RID: 3580 RVA: 0x00036620 File Offset: 0x00034820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116157, XrefRangeEnd = 1116181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0003665C File Offset: 0x0003485C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DFE RID: 3582 RVA: 0x0003669C File Offset: 0x0003489C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116181, XrefRangeEnd = 1116186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000366D0 File Offset: 0x000348D0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._WaitForSignal_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E00 RID: 3584 RVA: 0x00008F18 File Offset: 0x00007118
			public _WaitForSignal_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06000E01 RID: 3585 RVA: 0x00036710 File Offset: 0x00034910
			// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00008F21 File Offset: 0x00007121
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00036738 File Offset: 0x00034938
			// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00008F3C File Offset: 0x0000713C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00036768 File Offset: 0x00034968
			// (set) Token: 0x06000E06 RID: 3590 RVA: 0x00008F5B File Offset: 0x0000715B
			public unsafe string signal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr_signal);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr_signal), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00036790 File Offset: 0x00034990
			// (set) Token: 0x06000E08 RID: 3592 RVA: 0x00008F7A File Offset: 0x0000717A
			public unsafe VoodooView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06000E09 RID: 3593 RVA: 0x000367C0 File Offset: 0x000349C0
			// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00008F99 File Offset: 0x00007199
			public unsafe AnimationSignalDelegate _asd_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr__asd_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationSignalDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._WaitForSignal_d__38.NativeFieldInfoPtr__asd_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008AC RID: 2220
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008AD RID: 2221
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008AE RID: 2222
			private static readonly IntPtr NativeFieldInfoPtr_signal;

			// Token: 0x040008AF RID: 2223
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008B0 RID: 2224
			private static readonly IntPtr NativeFieldInfoPtr__asd_5__2;

			// Token: 0x040008B1 RID: 2225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008B2 RID: 2226
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008B3 RID: 2227
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008B4 RID: 2228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008B5 RID: 2229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008B6 RID: 2230
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200010F RID: 271
		[ObfuscatedName("lotus.VoodooView+<bubbleSignalRoutine>d__40")]
		public sealed class _bubbleSignalRoutine_d__40 : global::Il2CppSystem.Object
		{
			// Token: 0x06000E0B RID: 3595 RVA: 0x000367F0 File Offset: 0x000349F0
			// Note: this type is marked as 'beforefieldinit'.
			static _bubbleSignalRoutine_d__40()
			{
				Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooView>.NativeClassPtr, "<bubbleSignalRoutine>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr);
				VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, "<>1__state");
				VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, "<>2__current");
				VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, "<>4__this");
				VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr_signal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, "signal");
				VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr_bubbleView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, "bubbleView");
				VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, 100664526);
				VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, 100664527);
				VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, 100664528);
				VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, 100664529);
				VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, 100664530);
				VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr, 100664531);
			}

			// Token: 0x06000E0C RID: 3596 RVA: 0x000368F8 File Offset: 0x00034AF8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _bubbleSignalRoutine_d__40(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooView._bubbleSignalRoutine_d__40>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E0D RID: 3597 RVA: 0x00036940 File Offset: 0x00034B40
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E0E RID: 3598 RVA: 0x00036974 File Offset: 0x00034B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116186, XrefRangeEnd = 1116188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x06000E0F RID: 3599 RVA: 0x000369B0 File Offset: 0x00034BB0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E10 RID: 3600 RVA: 0x000369F0 File Offset: 0x00034BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116188, XrefRangeEnd = 1116193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00036A24 File Offset: 0x00034C24
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooView._bubbleSignalRoutine_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E12 RID: 3602 RVA: 0x00008FB8 File Offset: 0x000071B8
			public _bubbleSignalRoutine_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00036A64 File Offset: 0x00034C64
			// (set) Token: 0x06000E14 RID: 3604 RVA: 0x00008FC1 File Offset: 0x000071C1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00036A8C File Offset: 0x00034C8C
			// (set) Token: 0x06000E16 RID: 3606 RVA: 0x00008FDC File Offset: 0x000071DC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00036ABC File Offset: 0x00034CBC
			// (set) Token: 0x06000E18 RID: 3608 RVA: 0x00008FFB File Offset: 0x000071FB
			public unsafe VoodooView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00036AEC File Offset: 0x00034CEC
			// (set) Token: 0x06000E1A RID: 3610 RVA: 0x0000901A File Offset: 0x0000721A
			public unsafe string signal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr_signal);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr_signal), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00036B14 File Offset: 0x00034D14
			// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00009039 File Offset: 0x00007239
			public unsafe VoodooView bubbleView
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr_bubbleView);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooView._bubbleSignalRoutine_d__40.NativeFieldInfoPtr_bubbleView), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008B7 RID: 2231
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008B8 RID: 2232
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008B9 RID: 2233
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008BA RID: 2234
			private static readonly IntPtr NativeFieldInfoPtr_signal;

			// Token: 0x040008BB RID: 2235
			private static readonly IntPtr NativeFieldInfoPtr_bubbleView;

			// Token: 0x040008BC RID: 2236
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008BD RID: 2237
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008BE RID: 2238
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008BF RID: 2239
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008C0 RID: 2240
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008C1 RID: 2241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
