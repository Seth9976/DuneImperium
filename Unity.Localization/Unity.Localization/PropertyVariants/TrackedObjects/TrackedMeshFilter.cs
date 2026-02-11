using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x020000F9 RID: 249
	[Serializable]
	public class TrackedMeshFilter : TrackedObject
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x00036780 File Offset: 0x00034980
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedMeshFilter()
		{
			Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "TrackedMeshFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr);
			TrackedMeshFilter.NativeFieldInfoPtr_k_MeshProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr, "k_MeshProperty");
			TrackedMeshFilter.NativeFieldInfoPtr_m_CurrentOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr, "m_CurrentOperation");
			TrackedMeshFilter.NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr, 100665290);
			TrackedMeshFilter.NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr, 100665291);
			TrackedMeshFilter.NativeMethodInfoPtr_MeshOperationCompleted_Private_Void_AsyncOperationHandle_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr, 100665292);
			TrackedMeshFilter.NativeMethodInfoPtr_SetMesh_Private_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr, 100665293);
			TrackedMeshFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr, 100665294);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0003683C File Offset: 0x00034A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080444, XrefRangeEnd = 1080447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanTrackProperty(string propertyPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedMeshFilter.NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00036894 File Offset: 0x00034A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080447, XrefRangeEnd = 1080498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variantLocale);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultLocale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedMeshFilter.NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000368FC File Offset: 0x00034AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080498, XrefRangeEnd = 1080502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MeshOperationCompleted(AsyncOperationHandle<Mesh> assetOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetOp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMeshFilter.NativeMethodInfoPtr_MeshOperationCompleted_Private_Void_AsyncOperationHandle_1_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00036944 File Offset: 0x00034B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1080507, RefRangeEnd = 1080508, XrefRangeStart = 1080502, XrefRangeEnd = 1080507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMeshFilter.NativeMethodInfoPtr_SetMesh_Private_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00036988 File Offset: 0x00034B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedMeshFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedMeshFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMeshFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00007172 File Offset: 0x00005372
		public TrackedMeshFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x000369C4 File Offset: 0x00034BC4
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0000717B File Offset: 0x0000537B
		public unsafe static string k_MeshProperty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackedMeshFilter.NativeFieldInfoPtr_k_MeshProperty, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackedMeshFilter.NativeFieldInfoPtr_k_MeshProperty, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x000369E4 File Offset: 0x00034BE4
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0000718D File Offset: 0x0000538D
		public AsyncOperationHandle<Mesh> m_CurrentOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMeshFilter.NativeFieldInfoPtr_m_CurrentOperation);
				return new AsyncOperationHandle<Mesh>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Mesh>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMeshFilter.NativeFieldInfoPtr_m_CurrentOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Mesh>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeFieldInfoPtr_k_MeshProperty;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentOperation;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_Boolean_String_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_MeshOperationCompleted_Private_Void_AsyncOperationHandle_1_Mesh_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_SetMesh_Private_Void_Mesh_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
