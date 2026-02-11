using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011C RID: 284
	public static class ResourcesAPIInternal : Object
	{
		// Token: 0x060016F9 RID: 5881 RVA: 0x0006DEC8 File Offset: 0x0006C0C8
		// Note: this type is marked as 'beforefieldinit'.
		static ResourcesAPIInternal()
		{
			Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourcesAPIInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr);
			ResourcesAPIInternal.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100666461);
			ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100666462);
			ResourcesAPIInternal.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100666463);
			ResourcesAPIInternal.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100666464);
			ResourcesAPIInternal.NativeMethodInfoPtr_LoadAsyncInternal_Internal_Static_ResourceRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100666465);
			ResourcesAPIInternal.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100666466);
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0006DF70 File Offset: 0x0006C170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660296, XrefRangeEnd = 660298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0006DFB4 File Offset: 0x0006C1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660298, XrefRangeEnd = 660300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Shader FindShaderByName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0006DFF8 File Offset: 0x0006C1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660300, XrefRangeEnd = 660302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Load(string path, Type systemTypeInstance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0006E050 File Offset: 0x0006C250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660302, XrefRangeEnd = 660304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0006E0A8 File Offset: 0x0006C2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660304, XrefRangeEnd = 660306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceRequest LoadAsyncInternal(string path, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_LoadAsyncInternal_Internal_Static_ResourceRequest_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0006E100 File Offset: 0x0006C300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660306, XrefRangeEnd = 660308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadAsset(Object assetToUnload)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetToUnload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000090DF File Offset: 0x000072DF
		public ResourcesAPIInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsyncInternal_Internal_Static_ResourceRequest_String_Type_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0;

		// Token: 0x02000714 RID: 1812
		public static class EntitiesAssetGC
		{
		}
	}
}
