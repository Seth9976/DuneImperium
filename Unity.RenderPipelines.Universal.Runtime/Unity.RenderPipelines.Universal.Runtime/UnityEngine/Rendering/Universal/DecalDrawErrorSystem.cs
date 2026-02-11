using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000064 RID: 100
	public class DecalDrawErrorSystem : DecalDrawSystem
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x000330F4 File Offset: 0x000312F4
		// Note: this type is marked as 'beforefieldinit'.
		static DecalDrawErrorSystem()
		{
			Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawErrorSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr);
			DecalDrawErrorSystem.NativeFieldInfoPtr_m_Technique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr, "m_Technique");
			DecalDrawErrorSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_DecalTechnique_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr, 100664479);
			DecalDrawErrorSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr, 100664480);
			DecalDrawErrorSystem.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_DecalEntityChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr, 100664481);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00033174 File Offset: 0x00031374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606523, RefRangeEnd = 606524, XrefRangeStart = 606517, XrefRangeEnd = 606523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalDrawErrorSystem(DecalEntityManager entityManager, DecalTechnique technique)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref technique;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawErrorSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_DecalTechnique_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000331D0 File Offset: 0x000313D0
		[CallerCount(0)]
		public unsafe override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawErrorSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00033228 File Offset: 0x00031428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606524, XrefRangeEnd = 606526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Material GetMaterial(DecalEntityChunk decalEntityChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalEntityChunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawErrorSystem.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_DecalEntityChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00005B73 File Offset: 0x00003D73
		public DecalDrawErrorSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00033284 File Offset: 0x00031484
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00005B7C File Offset: 0x00003D7C
		public unsafe DecalTechnique m_Technique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawErrorSystem.NativeFieldInfoPtr_m_Technique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawErrorSystem.NativeFieldInfoPtr_m_Technique)) = value;
			}
		}

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeFieldInfoPtr_m_Technique;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_DecalTechnique_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_DecalEntityChunk_0;
	}
}
