using System;
using dwd.core.input.compositeModule;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x0200006B RID: 107
	public class AnimSetOnInputModuleType : VersionedView<CurrentInputModuleType>
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x00022BF8 File Offset: 0x00020DF8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimSetOnInputModuleType()
		{
			Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "AnimSetOnInputModuleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr);
			AnimSetOnInputModuleType.NativeFieldInfoPtr_inputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, "inputModuleType");
			AnimSetOnInputModuleType.NativeFieldInfoPtr_targetAnimParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, "targetAnimParam");
			AnimSetOnInputModuleType.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, "animator");
			AnimSetOnInputModuleType.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, 100664220);
			AnimSetOnInputModuleType.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, 100664221);
			AnimSetOnInputModuleType.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, 100664222);
			AnimSetOnInputModuleType.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, 100664223);
			AnimSetOnInputModuleType.NativeMethodInfoPtr_updateObjects_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, 100664224);
			AnimSetOnInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr, 100664225);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00022CDC File Offset: 0x00020EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988105, XrefRangeEnd = 988132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimSetOnInputModuleType.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00022D18 File Offset: 0x00020F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988132, XrefRangeEnd = 988158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimSetOnInputModuleType.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00022D54 File Offset: 0x00020F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988158, XrefRangeEnd = 988164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimSetOnInputModuleType.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00022D90 File Offset: 0x00020F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988164, XrefRangeEnd = 988167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimSetOnInputModuleType.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00022DCC File Offset: 0x00020FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988167, XrefRangeEnd = 988169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateObjects(bool shouldActivate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldActivate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimSetOnInputModuleType.NativeMethodInfoPtr_updateObjects_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00022E0C File Offset: 0x0002100C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988169, XrefRangeEnd = 988180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimSetOnInputModuleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimSetOnInputModuleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimSetOnInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00004A4F File Offset: 0x00002C4F
		public AnimSetOnInputModuleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00022E48 File Offset: 0x00021048
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00004A58 File Offset: 0x00002C58
		public unsafe string inputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimSetOnInputModuleType.NativeFieldInfoPtr_inputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimSetOnInputModuleType.NativeFieldInfoPtr_inputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00022E70 File Offset: 0x00021070
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00004A77 File Offset: 0x00002C77
		public unsafe string targetAnimParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimSetOnInputModuleType.NativeFieldInfoPtr_targetAnimParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimSetOnInputModuleType.NativeFieldInfoPtr_targetAnimParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00022E98 File Offset: 0x00021098
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00004A96 File Offset: 0x00002C96
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimSetOnInputModuleType.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimSetOnInputModuleType.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_inputModuleType;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_targetAnimParam;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_updateObjects_Private_Void_Boolean_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
