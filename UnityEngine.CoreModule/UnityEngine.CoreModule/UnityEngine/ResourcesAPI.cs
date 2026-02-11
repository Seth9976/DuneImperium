using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011D RID: 285
	public class ResourcesAPI : Object
	{
		// Token: 0x06001701 RID: 5889 RVA: 0x0006E138 File Offset: 0x0006C338
		// Note: this type is marked as 'beforefieldinit'.
		static ResourcesAPI()
		{
			Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourcesAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr);
			ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, "s_DefaultAPI");
			ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
			ResourcesAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666467);
			ResourcesAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666468);
			ResourcesAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666469);
			ResourcesAPI.NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666470);
			ResourcesAPI.NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666471);
			ResourcesAPI.NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666472);
			ResourcesAPI.NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666473);
			ResourcesAPI.NativeMethodInfoPtr_LoadAsync_FamOrAssem_Virtual_New_ResourceRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666474);
			ResourcesAPI.NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100666475);
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x0006E244 File Offset: 0x0006C444
		public unsafe static ResourcesAPI ActiveAPI
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 660318, RefRangeEnd = 660325, XrefRangeStart = 660308, XrefRangeEnd = 660318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr3) : null;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x0006E278 File Offset: 0x0006C478
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x00009115 File Offset: 0x00007315
		public unsafe static ResourcesAPI overrideAPI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660325, XrefRangeEnd = 660329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr3) : null;
			}
			set
			{
				ResourcesAPI._overrideAPI_k__BackingField = value;
			}
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0006E2AC File Offset: 0x0006C4AC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourcesAPI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0006E2E8 File Offset: 0x0006C4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660329, XrefRangeEnd = 660331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0006E344 File Offset: 0x0006C544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660331, XrefRangeEnd = 660333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Shader FindShaderByName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0006E3A0 File Offset: 0x0006C5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660333, XrefRangeEnd = 660335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Load(string path, Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0006E410 File Offset: 0x0006C610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660335, XrefRangeEnd = 660337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0006E480 File Offset: 0x0006C680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660337, XrefRangeEnd = 660341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_LoadAsync_FamOrAssem_Virtual_New_ResourceRequest_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0006E4F0 File Offset: 0x0006C6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660341, XrefRangeEnd = 660350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnloadAsset(Object assetToUnload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetToUnload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x000090E8 File Offset: 0x000072E8
		public ResourcesAPI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x0006E540 File Offset: 0x0006C740
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x000090F1 File Offset: 0x000072F1
		public unsafe static ResourcesAPI s_DefaultAPI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0006E568 File Offset: 0x0006C768
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x00009103 File Offset: 0x00007303
		public unsafe static ResourcesAPI _overrideAPI_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultAPI;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_FamOrAssem_Virtual_New_ResourceRequest_String_Type_0;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0;
	}
}
