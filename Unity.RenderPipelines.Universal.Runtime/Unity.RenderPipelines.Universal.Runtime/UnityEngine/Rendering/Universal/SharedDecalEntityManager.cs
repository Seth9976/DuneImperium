using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C4 RID: 196
	public class SharedDecalEntityManager : Object
	{
		// Token: 0x06000F18 RID: 3864 RVA: 0x00049548 File Offset: 0x00047748
		// Note: this type is marked as 'beforefieldinit'.
		static SharedDecalEntityManager()
		{
			Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "SharedDecalEntityManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr);
			SharedDecalEntityManager.NativeFieldInfoPtr_m_DecalEntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, "m_DecalEntityManager");
			SharedDecalEntityManager.NativeFieldInfoPtr_m_ReferenceCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, "m_ReferenceCounter");
			SharedDecalEntityManager.NativeMethodInfoPtr_Get_Public_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665207);
			SharedDecalEntityManager.NativeMethodInfoPtr_Release_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665208);
			SharedDecalEntityManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665209);
			SharedDecalEntityManager.NativeMethodInfoPtr_OnDecalAdd_Private_Void_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665210);
			SharedDecalEntityManager.NativeMethodInfoPtr_OnDecalRemove_Private_Void_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665211);
			SharedDecalEntityManager.NativeMethodInfoPtr_OnDecalPropertyChange_Private_Void_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665212);
			SharedDecalEntityManager.NativeMethodInfoPtr_OnAllDecalPropertyChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665213);
			SharedDecalEntityManager.NativeMethodInfoPtr_OnDecalMaterialChange_Private_Void_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665214);
			SharedDecalEntityManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr, 100665215);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00049654 File Offset: 0x00047854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614929, RefRangeEnd = 614930, XrefRangeStart = 614882, XrefRangeEnd = 614929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalEntityManager Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr_Get_Public_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr3) : null;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00049694 File Offset: 0x00047894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614930, XrefRangeEnd = 614964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(DecalEntityManager decalEntityManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalEntityManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr_Release_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000496D8 File Offset: 0x000478D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614964, XrefRangeEnd = 614999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0004970C File Offset: 0x0004790C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614999, XrefRangeEnd = 615001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDecalAdd(DecalProjector decalProjector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalProjector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr_OnDecalAdd_Private_Void_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00049750 File Offset: 0x00047950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615001, XrefRangeEnd = 615003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDecalRemove(DecalProjector decalProjector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalProjector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr_OnDecalRemove_Private_Void_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00049794 File Offset: 0x00047994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615003, XrefRangeEnd = 615005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDecalPropertyChange(DecalProjector decalProjector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalProjector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr_OnDecalPropertyChange_Private_Void_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000497D8 File Offset: 0x000479D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615005, XrefRangeEnd = 615007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAllDecalPropertyChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr_OnAllDecalPropertyChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0004980C File Offset: 0x00047A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615007, XrefRangeEnd = 615010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDecalMaterialChange(DecalProjector decalProjector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalProjector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr_OnDecalMaterialChange_Private_Void_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00049850 File Offset: 0x00047A50
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedDecalEntityManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedDecalEntityManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedDecalEntityManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x000094D7 File Offset: 0x000076D7
		public SharedDecalEntityManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0004988C File Offset: 0x00047A8C
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x000094E0 File Offset: 0x000076E0
		public unsafe DecalEntityManager m_DecalEntityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedDecalEntityManager.NativeFieldInfoPtr_m_DecalEntityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedDecalEntityManager.NativeFieldInfoPtr_m_DecalEntityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000498BC File Offset: 0x00047ABC
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x000094FF File Offset: 0x000076FF
		public unsafe int m_ReferenceCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedDecalEntityManager.NativeFieldInfoPtr_m_ReferenceCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedDecalEntityManager.NativeFieldInfoPtr_m_ReferenceCounter)) = value;
			}
		}

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalEntityManager;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr_m_ReferenceCounter;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DecalEntityManager_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_DecalEntityManager_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_OnDecalAdd_Private_Void_DecalProjector_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_OnDecalRemove_Private_Void_DecalProjector_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_OnDecalPropertyChange_Private_Void_DecalProjector_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_OnAllDecalPropertyChange_Private_Void_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_OnDecalMaterialChange_Private_Void_DecalProjector_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
