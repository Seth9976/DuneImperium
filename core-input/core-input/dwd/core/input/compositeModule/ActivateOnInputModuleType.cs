using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000081 RID: 129
	public class ActivateOnInputModuleType : VersionedView<CurrentInputModuleType>
	{
		// Token: 0x0600056D RID: 1389 RVA: 0x0001808C File Offset: 0x0001628C
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateOnInputModuleType()
		{
			Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "ActivateOnInputModuleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr);
			ActivateOnInputModuleType.NativeFieldInfoPtr_inputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr, "inputModuleType");
			ActivateOnInputModuleType.NativeFieldInfoPtr_objectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr, "objectsToActivate");
			ActivateOnInputModuleType.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr, 100663971);
			ActivateOnInputModuleType.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr, 100663972);
			ActivateOnInputModuleType.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr, 100663973);
			ActivateOnInputModuleType.NativeMethodInfoPtr_updateObjects_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr, 100663974);
			ActivateOnInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr, 100663975);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00018148 File Offset: 0x00016348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124325, XrefRangeEnd = 1124338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivateOnInputModuleType.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00018184 File Offset: 0x00016384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124338, XrefRangeEnd = 1124344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivateOnInputModuleType.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000181C0 File Offset: 0x000163C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124344, XrefRangeEnd = 1124347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivateOnInputModuleType.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000181FC File Offset: 0x000163FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1124353, RefRangeEnd = 1124355, XrefRangeStart = 1124347, XrefRangeEnd = 1124353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateObjects(bool shouldActivate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldActivate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateOnInputModuleType.NativeMethodInfoPtr_updateObjects_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001823C File Offset: 0x0001643C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124355, XrefRangeEnd = 1124365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateOnInputModuleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateOnInputModuleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateOnInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00004FE7 File Offset: 0x000031E7
		public ActivateOnInputModuleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00018278 File Offset: 0x00016478
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00004FF0 File Offset: 0x000031F0
		public unsafe string inputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateOnInputModuleType.NativeFieldInfoPtr_inputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateOnInputModuleType.NativeFieldInfoPtr_inputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x000182A0 File Offset: 0x000164A0
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0000500F File Offset: 0x0000320F
		public unsafe Il2CppReferenceArray<GameObject> objectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateOnInputModuleType.NativeFieldInfoPtr_objectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateOnInputModuleType.NativeFieldInfoPtr_objectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_inputModuleType;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr_objectsToActivate;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_updateObjects_Private_Void_Boolean_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
