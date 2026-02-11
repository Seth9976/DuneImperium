using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.prefabs.implementations.byflavor
{
	// Token: 0x02000116 RID: 278
	public class PrefabByFlavorMetadata : MonoBehaviour
	{
		// Token: 0x06000FBF RID: 4031 RVA: 0x00051FE4 File Offset: 0x000501E4
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabByFlavorMetadata()
		{
			Il2CppClassPointerStore<PrefabByFlavorMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.implementations.byflavor", "PrefabByFlavorMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabByFlavorMetadata>.NativeClassPtr);
			PrefabByFlavorMetadata.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabByFlavorMetadata>.NativeClassPtr, "metadata");
			PrefabByFlavorMetadata.NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_PrefabFlavorsMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorMetadata>.NativeClassPtr, 100665599);
			PrefabByFlavorMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorMetadata>.NativeClassPtr, 100665600);
			PrefabByFlavorMetadata.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorMetadata>.NativeClassPtr, 100665601);
			PrefabByFlavorMetadata.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorMetadata>.NativeClassPtr, 100665602);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00052078 File Offset: 0x00050278
		[CallerCount(0)]
		public unsafe virtual PrefabFlavorsMetaData GetMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorMetadata.NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_PrefabFlavorsMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorsMetaData(intPtr);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000520B0 File Offset: 0x000502B0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabByFlavorMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabByFlavorMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000520EC File Offset: 0x000502EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject IGameObject_get_gameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorMetadata.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0005212C File Offset: 0x0005032C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform IGameObject_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorMetadata.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0000764E File Offset: 0x0000584E
		public PrefabByFlavorMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0005216C File Offset: 0x0005036C
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00007657 File Offset: 0x00005857
		public PrefabFlavorsMetaData metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabByFlavorMetadata.NativeFieldInfoPtr_metadata);
				return new PrefabFlavorsMetaData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabByFlavorMetadata.NativeFieldInfoPtr_metadata), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeFieldInfoPtr_metadata;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_PrefabFlavorsMetaData_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;
	}
}
