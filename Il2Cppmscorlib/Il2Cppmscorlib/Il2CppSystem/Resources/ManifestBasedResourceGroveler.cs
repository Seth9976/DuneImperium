using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003EE RID: 1006
	public class ManifestBasedResourceGroveler : Object
	{
		// Token: 0x06003AB6 RID: 15030 RVA: 0x0011ACC8 File Offset: 0x00118EC8
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestBasedResourceGroveler()
		{
			Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ManifestBasedResourceGroveler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr);
			ManifestBasedResourceGroveler.NativeFieldInfoPtr__mediator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, "_mediator");
			ManifestBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672064);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672065);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_UltimateFallbackFixup_Private_CultureInfo_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672066);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672067);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Internal_ResourceSet_Stream_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672068);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetManifestResourceStream_Private_Stream_RuntimeAssembly_String_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672069);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_CaseInsensitiveManifestResourceStreamLookup_Private_Stream_RuntimeAssembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672070);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetSatelliteAssembly_Private_RuntimeAssembly_CultureInfo_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672071);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_CanUseDefaultResourceClasses_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672072);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetSatelliteAssemblyName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672073);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_HandleSatelliteMissing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672074);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_HandleResourceStreamMissing_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672075);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100672076);
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x0011AE10 File Offset: 0x00119010
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mediator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x0011AE5C File Offset: 0x0011905C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396727, XrefRangeEnd = 1396767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localResourceSets);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x0011AEEC File Offset: 0x001190EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396767, XrefRangeEnd = 1396778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookForCulture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_UltimateFallbackFixup_Private_CultureInfo_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x0011AF3C File Offset: 0x0011913C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1396797, RefRangeEnd = 1396800, XrefRangeStart = 1396778, XrefRangeEnd = 1396797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fallbackLocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x0011AF90 File Offset: 0x00119190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1396854, RefRangeEnd = 1396855, XrefRangeStart = 1396800, XrefRangeEnd = 1396854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet CreateResourceSet(Stream store, Assembly assembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Internal_ResourceSet_Stream_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x0011AFF4 File Offset: 0x001191F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396855, XrefRangeEnd = 1396864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(satellite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetManifestResourceStream_Private_Stream_RuntimeAssembly_String_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x0011B064 File Offset: 0x00119264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1396893, RefRangeEnd = 1396895, XrefRangeStart = 1396864, XrefRangeEnd = 1396893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(satellite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_CaseInsensitiveManifestResourceStreamLookup_Private_Stream_RuntimeAssembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x0011B0C8 File Offset: 0x001192C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1396909, RefRangeEnd = 1396910, XrefRangeStart = 1396895, XrefRangeEnd = 1396909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookForCulture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetSatelliteAssembly_Private_RuntimeAssembly_CultureInfo_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x0011B128 File Offset: 0x00119328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396910, XrefRangeEnd = 1396931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(readerTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resSetTypeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_CanUseDefaultResourceClasses_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x0011B188 File Offset: 0x00119388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396931, XrefRangeEnd = 1396937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSatelliteAssemblyName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetSatelliteAssemblyName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x0011B1C0 File Offset: 0x001193C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396937, XrefRangeEnd = 1397012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSatelliteMissing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_HandleSatelliteMissing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x0011B1F4 File Offset: 0x001193F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397012, XrefRangeEnd = 1397073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleResourceStreamMissing(string fileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_HandleResourceStreamMissing_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x0011B238 File Offset: 0x00119438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397073, XrefRangeEnd = 1397077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fallbackLocation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			cultureName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x00015CD4 File Offset: 0x00013ED4
		public ManifestBasedResourceGroveler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x0011B2A8 File Offset: 0x001194A8
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x00015CDD File Offset: 0x00013EDD
		public unsafe ResourceManager.ResourceManagerMediator _mediator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBasedResourceGroveler.NativeFieldInfoPtr__mediator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager.ResourceManagerMediator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBasedResourceGroveler.NativeFieldInfoPtr__mediator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeFieldInfoPtr__mediator;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeMethodInfoPtr_UltimateFallbackFixup_Private_CultureInfo_CultureInfo_0;

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeMethodInfoPtr_CreateResourceSet_Internal_ResourceSet_Stream_Assembly_0;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Private_Stream_RuntimeAssembly_String_byref_StackCrawlMark_0;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeMethodInfoPtr_CaseInsensitiveManifestResourceStreamLookup_Private_Stream_RuntimeAssembly_String_0;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeMethodInfoPtr_GetSatelliteAssembly_Private_RuntimeAssembly_CultureInfo_byref_StackCrawlMark_0;

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeMethodInfoPtr_CanUseDefaultResourceClasses_Private_Boolean_String_String_0;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeMethodInfoPtr_GetSatelliteAssemblyName_Private_String_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeMethodInfoPtr_HandleSatelliteMissing_Private_Void_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeMethodInfoPtr_HandleResourceStreamMissing_Private_Void_String_0;

		// Token: 0x04002F9F RID: 12191
		private static readonly IntPtr NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0;
	}
}
