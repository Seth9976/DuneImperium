using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace boardgames.hints
{
	// Token: 0x0200013F RID: 319
	public class DBGHinter : Observer
	{
		// Token: 0x06000E93 RID: 3731 RVA: 0x0004BF84 File Offset: 0x0004A184
		// Note: this type is marked as 'beforefieldinit'.
		static DBGHinter()
		{
			Il2CppClassPointerStore<DBGHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.hints", "DBGHinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr);
			DBGHinter.NativeFieldInfoPtr_hintAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "hintAnimator");
			DBGHinter.NativeFieldInfoPtr_hintLinkedCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "hintLinkedCollider");
			DBGHinter.NativeFieldInfoPtr_animParameterSafetyCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "animParameterSafetyCheck");
			DBGHinter.NativeFieldInfoPtr_viewLayersForHinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "viewLayersForHinting");
			DBGHinter.NativeFieldInfoPtr_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "manager");
			DBGHinter.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "entityID");
			DBGHinter.NativeFieldInfoPtr_paramDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "paramDependencies");
			DBGHinter.NativeFieldInfoPtr_paramNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "paramNames");
			DBGHinter.NativeFieldInfoPtr_ev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "ev");
			DBGHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665423);
			DBGHinter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665424);
			DBGHinter.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665425);
			DBGHinter.NativeMethodInfoPtr_SetHint_Public_Virtual_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665426);
			DBGHinter.NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665427);
			DBGHinter.NativeMethodInfoPtr_Register_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665428);
			DBGHinter.NativeMethodInfoPtr_Unregister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665429);
			DBGHinter.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665430);
			DBGHinter.NativeMethodInfoPtr_MatchesLayer_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665431);
			DBGHinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, 100665432);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0004C130 File Offset: 0x0004A330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512257, RefRangeEnd = 512260, XrefRangeStart = 512193, XrefRangeEnd = 512257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0004C16C File Offset: 0x0004A36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512260, XrefRangeEnd = 512269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0004C1A0 File Offset: 0x0004A3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512269, XrefRangeEnd = 512278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0004C1D4 File Offset: 0x0004A3D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512299, RefRangeEnd = 512301, XrefRangeStart = 512278, XrefRangeEnd = 512299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHint(string flavor, bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGHinter.NativeMethodInfoPtr_SetHint_Public_Virtual_New_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0004C230 File Offset: 0x0004A430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512301, XrefRangeEnd = 512310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onDespawn(PoolableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0004C274 File Offset: 0x0004A474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512310, XrefRangeEnd = 512320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.NativeMethodInfoPtr_Register_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0004C2A8 File Offset: 0x0004A4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512320, XrefRangeEnd = 512329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.NativeMethodInfoPtr_Unregister_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0004C2DC File Offset: 0x0004A4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512329, XrefRangeEnd = 512365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGHinter.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0004C318 File Offset: 0x0004A518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512365, XrefRangeEnd = 512368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MatchesLayer(int viewLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.NativeMethodInfoPtr_MatchesLayer_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0004C364 File Offset: 0x0004A564
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512382, RefRangeEnd = 512385, XrefRangeStart = 512368, XrefRangeEnd = 512382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGHinter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00009088 File Offset: 0x00007288
		public DBGHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x00009091 File Offset: 0x00007291
		public unsafe Animator hintAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_hintAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_hintAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0004C3D0 File Offset: 0x0004A5D0
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x000090B0 File Offset: 0x000072B0
		public unsafe Collider hintLinkedCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_hintLinkedCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_hintLinkedCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0004C400 File Offset: 0x0004A600
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x000090CF File Offset: 0x000072CF
		public unsafe bool animParameterSafetyCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_animParameterSafetyCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_animParameterSafetyCheck)) = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0004C428 File Offset: 0x0004A628
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000090EA File Offset: 0x000072EA
		public unsafe List<int> viewLayersForHinting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_viewLayersForHinting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_viewLayersForHinting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0004C458 File Offset: 0x0004A658
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00009109 File Offset: 0x00007309
		public unsafe DBGHintManager manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGHintManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0004C488 File Offset: 0x0004A688
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00009128 File Offset: 0x00007328
		public unsafe EntityID entityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_entityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0004C4B8 File Offset: 0x0004A6B8
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00009147 File Offset: 0x00007347
		public unsafe AnimParamDependencies paramDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_paramDependencies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimParamDependencies>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_paramDependencies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00009166 File Offset: 0x00007366
		public unsafe List<string> paramNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_paramNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_paramNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0004C518 File Offset: 0x0004A718
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00009185 File Offset: 0x00007385
		public unsafe EntityView ev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_ev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHinter.NativeFieldInfoPtr_ev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_hintAnimator;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_hintLinkedCollider;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_animParameterSafetyCheck;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_viewLayersForHinting;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_manager;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_entityID;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeFieldInfoPtr_paramDependencies;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_paramNames;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_ev;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_SetHint_Public_Virtual_New_Void_String_Boolean_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_MatchesLayer_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000367 RID: 871
		[ObfuscatedName("boardgames.hints.DBGHinter+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600291D RID: 10525 RVA: 0x000A3ADC File Offset: 0x000A1CDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGHinter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGHinter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGHinter.__c>.NativeClassPtr);
				DBGHinter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter.__c>.NativeClassPtr, "<>9");
				DBGHinter.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHinter.__c>.NativeClassPtr, "<>9__9_0");
				DBGHinter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter.__c>.NativeClassPtr, 100665434);
				DBGHinter.__c.NativeMethodInfoPtr__Start_b__9_0_Internal_String_AnimatorControllerParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHinter.__c>.NativeClassPtr, 100665435);
			}

			// Token: 0x0600291E RID: 10526 RVA: 0x000A3B58 File Offset: 0x000A1D58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGHinter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600291F RID: 10527 RVA: 0x000A3B94 File Offset: 0x000A1D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512191, XrefRangeEnd = 512193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Start_b__9_0(AnimatorControllerParameter p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHinter.__c.NativeMethodInfoPtr__Start_b__9_0_Internal_String_AnimatorControllerParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002920 RID: 10528 RVA: 0x0001537F File Offset: 0x0001357F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B8F RID: 2959
			// (get) Token: 0x06002921 RID: 10529 RVA: 0x000A3BDC File Offset: 0x000A1DDC
			// (set) Token: 0x06002922 RID: 10530 RVA: 0x00015388 File Offset: 0x00013588
			public unsafe static DBGHinter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGHinter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGHinter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGHinter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B90 RID: 2960
			// (get) Token: 0x06002923 RID: 10531 RVA: 0x000A3C04 File Offset: 0x000A1E04
			// (set) Token: 0x06002924 RID: 10532 RVA: 0x0001539A File Offset: 0x0001359A
			public unsafe static Func<AnimatorControllerParameter, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGHinter.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AnimatorControllerParameter, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGHinter.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019BB RID: 6587
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019BC RID: 6588
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040019BD RID: 6589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019BE RID: 6590
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__9_0_Internal_String_AnimatorControllerParameter_0;
		}
	}
}
