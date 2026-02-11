using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000040 RID: 64
	public class BaseMeshEffect : UIBehaviour
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x00026C7C File Offset: 0x00024E7C
		// Note: this type is marked as 'beforefieldinit'.
		static BaseMeshEffect()
		{
			Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "BaseMeshEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr);
			BaseMeshEffect.NativeFieldInfoPtr_m_Graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, "m_Graphic");
			BaseMeshEffect.NativeMethodInfoPtr_get_graphic_Protected_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664619);
			BaseMeshEffect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664620);
			BaseMeshEffect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664621);
			BaseMeshEffect.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664622);
			BaseMeshEffect.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664623);
			BaseMeshEffect.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664624);
			BaseMeshEffect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664625);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00026D4C File Offset: 0x00024F4C
		public unsafe Graphic graphic
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1093870, RefRangeEnd = 1093882, XrefRangeStart = 1093862, XrefRangeEnd = 1093870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMeshEffect.NativeMethodInfoPtr_get_graphic_Protected_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00026D8C File Offset: 0x00024F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093882, XrefRangeEnd = 1093889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00026DC8 File Offset: 0x00024FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093889, XrefRangeEnd = 1093897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00026E04 File Offset: 0x00025004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093897, XrefRangeEnd = 1093905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00026E40 File Offset: 0x00025040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093905, XrefRangeEnd = 1093928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_New_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00026E90 File Offset: 0x00025090
		[CallerCount(0)]
		public unsafe virtual void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00026EE0 File Offset: 0x000250E0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseMeshEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMeshEffect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00004CD7 File Offset: 0x00002ED7
		public BaseMeshEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00026F1C File Offset: 0x0002511C
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public unsafe Graphic m_Graphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMeshEffect.NativeFieldInfoPtr_m_Graphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMeshEffect.NativeFieldInfoPtr_m_Graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_m_Graphic;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_get_graphic_Protected_get_Graphic_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_New_Void_Mesh_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
