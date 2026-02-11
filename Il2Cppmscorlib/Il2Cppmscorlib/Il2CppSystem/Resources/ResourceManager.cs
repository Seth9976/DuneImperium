using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003EF RID: 1007
	[Serializable]
	public class ResourceManager : Object
	{
		// Token: 0x06003AC7 RID: 15047 RVA: 0x0011B2D8 File Offset: 0x001194D8
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManager()
		{
			Il2CppClassPointerStore<ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr);
			ResourceManager.NativeFieldInfoPtr_BaseNameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "BaseNameField");
			ResourceManager.NativeFieldInfoPtr_ResourceSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResourceSets");
			ResourceManager.NativeFieldInfoPtr__resourceSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_resourceSets");
			ResourceManager.NativeFieldInfoPtr_moduleDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "moduleDir");
			ResourceManager.NativeFieldInfoPtr_MainAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MainAssembly");
			ResourceManager.NativeFieldInfoPtr__locationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_locationInfo");
			ResourceManager.NativeFieldInfoPtr__userResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_userResourceSet");
			ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_neutralResourcesCulture");
			ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_lastUsedResourceCache");
			ResourceManager.NativeFieldInfoPtr__ignoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_ignoreCase");
			ResourceManager.NativeFieldInfoPtr_UseManifest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "UseManifest");
			ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "UseSatelliteAssem");
			ResourceManager.NativeFieldInfoPtr__fallbackLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_fallbackLoc");
			ResourceManager.NativeFieldInfoPtr__satelliteContractVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_satelliteContractVersion");
			ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_lookedForSatelliteContractVersion");
			ResourceManager.NativeFieldInfoPtr__callingAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_callingAssembly");
			ResourceManager.NativeFieldInfoPtr_m_callingAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_callingAssembly");
			ResourceManager.NativeFieldInfoPtr_resourceGroveler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "resourceGroveler");
			ResourceManager.NativeFieldInfoPtr_MagicNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MagicNumber");
			ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "HeaderVersionNumber");
			ResourceManager.NativeFieldInfoPtr__minResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_minResourceSet");
			ResourceManager.NativeFieldInfoPtr_ResReaderTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResReaderTypeName");
			ResourceManager.NativeFieldInfoPtr_ResSetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResSetTypeName");
			ResourceManager.NativeFieldInfoPtr_MscorlibName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MscorlibName");
			ResourceManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "DEBUG");
			ResourceManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672077);
			ResourceManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672078);
			ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672079);
			ResourceManager.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672080);
			ResourceManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672081);
			ResourceManager.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672082);
			ResourceManager.NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672083);
			ResourceManager.NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672084);
			ResourceManager.NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672085);
			ResourceManager.NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672086);
			ResourceManager.NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672087);
			ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672088);
			ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672089);
			ResourceManager.NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672090);
			ResourceManager.NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672091);
			ResourceManager.NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672092);
			ResourceManager.NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672093);
			ResourceManager.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672094);
			ResourceManager.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100672095);
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x0011B678 File Offset: 0x00119878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397156, RefRangeEnd = 1397157, XrefRangeStart = 1397149, XrefRangeEnd = 1397156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x0011B6AC File Offset: 0x001198AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397157, XrefRangeEnd = 1397174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x0011B6E8 File Offset: 0x001198E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1397228, RefRangeEnd = 1397234, XrefRangeStart = 1397174, XrefRangeEnd = 1397228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManager(Type resourceSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x0011B734 File Offset: 0x00119934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397234, XrefRangeEnd = 1397237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x0011B77C File Offset: 0x0011997C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397237, XrefRangeEnd = 1397269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x0011B7C4 File Offset: 0x001199C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397269, XrefRangeEnd = 1397305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x0011B80C File Offset: 0x00119A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397305, XrefRangeEnd = 1397334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommonAssemblyInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x0011B840 File Offset: 0x00119A40
		public unsafe virtual string BaseName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x0011B884 File Offset: 0x00119A84
		public unsafe UltimateResourceFallbackLocation FallbackLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x0011B8C0 File Offset: 0x00119AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397334, XrefRangeEnd = 1397350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetResourceFileName(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x0011B914 File Offset: 0x00119B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397376, RefRangeEnd = 1397377, XrefRangeStart = 1397350, XrefRangeEnd = 1397376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet GetFirstResourceSet(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
			}
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x0011B964 File Offset: 0x00119B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397377, XrefRangeEnd = 1397378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x0011B9DC File Offset: 0x00119BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397448, RefRangeEnd = 1397449, XrefRangeStart = 1397378, XrefRangeEnd = 1397448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedCulture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x0011BA58 File Offset: 0x00119C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397467, RefRangeEnd = 1397468, XrefRangeStart = 1397449, XrefRangeEnd = 1397467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localResourceSets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(rs);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			rs = ((intPtr4 == 0) ? null : new ResourceSet(intPtr4));
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x0011BAC8 File Offset: 0x00119CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397512, RefRangeEnd = 1397513, XrefRangeStart = 1397468, XrefRangeEnd = 1397512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version GetSatelliteContractVersion(Assembly a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x0011BB0C File Offset: 0x00119D0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1397532, RefRangeEnd = 1397537, XrefRangeStart = 1397513, XrefRangeEnd = 1397532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asmTypeName1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asmName2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x0011BB74 File Offset: 0x00119D74
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppXConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x0011BBA8 File Offset: 0x00119DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 460545, RefRangeEnd = 460546, XrefRangeStart = 460545, XrefRangeEnd = 460546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x0011BBFC File Offset: 0x00119DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397537, XrefRangeEnd = 1397568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(string name, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00015CFC File Offset: 0x00013EFC
		public ResourceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x0011BC64 File Offset: 0x00119E64
		// (set) Token: 0x06003ADD RID: 15069 RVA: 0x00015D05 File Offset: 0x00013F05
		public unsafe string BaseNameField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_BaseNameField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_BaseNameField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06003ADE RID: 15070 RVA: 0x0011BC8C File Offset: 0x00119E8C
		// (set) Token: 0x06003ADF RID: 15071 RVA: 0x00015D24 File Offset: 0x00013F24
		public unsafe Hashtable ResourceSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_ResourceSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_ResourceSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x0011BCBC File Offset: 0x00119EBC
		// (set) Token: 0x06003AE1 RID: 15073 RVA: 0x00015D43 File Offset: 0x00013F43
		public unsafe Dictionary<string, ResourceSet> _resourceSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__resourceSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__resourceSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x0011BCEC File Offset: 0x00119EEC
		// (set) Token: 0x06003AE3 RID: 15075 RVA: 0x00015D62 File Offset: 0x00013F62
		public unsafe string moduleDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_moduleDir);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_moduleDir), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x0011BD14 File Offset: 0x00119F14
		// (set) Token: 0x06003AE5 RID: 15077 RVA: 0x00015D81 File Offset: 0x00013F81
		public unsafe Assembly MainAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_MainAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_MainAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x0011BD44 File Offset: 0x00119F44
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x00015DA0 File Offset: 0x00013FA0
		public unsafe Type _locationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__locationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__locationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x0011BD74 File Offset: 0x00119F74
		// (set) Token: 0x06003AE9 RID: 15081 RVA: 0x00015DBF File Offset: 0x00013FBF
		public unsafe Type _userResourceSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__userResourceSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__userResourceSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x0011BDA4 File Offset: 0x00119FA4
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x00015DDE File Offset: 0x00013FDE
		public unsafe CultureInfo _neutralResourcesCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x0011BDD4 File Offset: 0x00119FD4
		// (set) Token: 0x06003AED RID: 15085 RVA: 0x00015DFD File Offset: 0x00013FFD
		public unsafe ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager.CultureNameResourceSetPair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x0011BE04 File Offset: 0x0011A004
		// (set) Token: 0x06003AEF RID: 15087 RVA: 0x00015E1C File Offset: 0x0001401C
		public unsafe bool _ignoreCase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__ignoreCase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__ignoreCase)) = value;
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x0011BE2C File Offset: 0x0011A02C
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x00015E37 File Offset: 0x00014037
		public unsafe bool UseManifest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseManifest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseManifest)) = value;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x0011BE54 File Offset: 0x0011A054
		// (set) Token: 0x06003AF3 RID: 15091 RVA: 0x00015E52 File Offset: 0x00014052
		public unsafe bool UseSatelliteAssem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem)) = value;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x0011BE7C File Offset: 0x0011A07C
		// (set) Token: 0x06003AF5 RID: 15093 RVA: 0x00015E6D File Offset: 0x0001406D
		public unsafe UltimateResourceFallbackLocation _fallbackLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__fallbackLoc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__fallbackLoc)) = value;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x0011BEA4 File Offset: 0x0011A0A4
		// (set) Token: 0x06003AF7 RID: 15095 RVA: 0x00015E88 File Offset: 0x00014088
		public unsafe Version _satelliteContractVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__satelliteContractVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__satelliteContractVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x0011BED4 File Offset: 0x0011A0D4
		// (set) Token: 0x06003AF9 RID: 15097 RVA: 0x00015EA7 File Offset: 0x000140A7
		public unsafe bool _lookedForSatelliteContractVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion)) = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x0011BEFC File Offset: 0x0011A0FC
		// (set) Token: 0x06003AFB RID: 15099 RVA: 0x00015EC2 File Offset: 0x000140C2
		public unsafe Assembly _callingAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__callingAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__callingAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x0011BF2C File Offset: 0x0011A12C
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x00015EE1 File Offset: 0x000140E1
		public unsafe RuntimeAssembly m_callingAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_callingAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_callingAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x0011BF5C File Offset: 0x0011A15C
		// (set) Token: 0x06003AFF RID: 15103 RVA: 0x00015F00 File Offset: 0x00014100
		public unsafe IResourceGroveler resourceGroveler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_resourceGroveler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceGroveler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_resourceGroveler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x0011BF8C File Offset: 0x0011A18C
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x00015F1F File Offset: 0x0001411F
		public unsafe static int MagicNumber
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_MagicNumber, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_MagicNumber, (void*)(&value));
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x0011BFA8 File Offset: 0x0011A1A8
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x00015F2D File Offset: 0x0001412D
		public unsafe static int HeaderVersionNumber
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber, (void*)(&value));
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06003B04 RID: 15108 RVA: 0x0011BFC4 File Offset: 0x0011A1C4
		// (set) Token: 0x06003B05 RID: 15109 RVA: 0x00015F3B File Offset: 0x0001413B
		public unsafe static Type _minResourceSet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr__minResourceSet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr__minResourceSet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x0011BFEC File Offset: 0x0011A1EC
		// (set) Token: 0x06003B07 RID: 15111 RVA: 0x00015F4D File Offset: 0x0001414D
		public unsafe static string ResReaderTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_ResReaderTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_ResReaderTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x0011C00C File Offset: 0x0011A20C
		// (set) Token: 0x06003B09 RID: 15113 RVA: 0x00015F5F File Offset: 0x0001415F
		public unsafe static string ResSetTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_ResSetTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_ResSetTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x0011C02C File Offset: 0x0011A22C
		// (set) Token: 0x06003B0B RID: 15115 RVA: 0x00015F71 File Offset: 0x00014171
		public unsafe static string MscorlibName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_MscorlibName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_MscorlibName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x0011C04C File Offset: 0x0011A24C
		// (set) Token: 0x06003B0D RID: 15117 RVA: 0x00015F83 File Offset: 0x00014183
		public unsafe static int DEBUG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_DEBUG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x04002FA0 RID: 12192
		private static readonly IntPtr NativeFieldInfoPtr_BaseNameField;

		// Token: 0x04002FA1 RID: 12193
		private static readonly IntPtr NativeFieldInfoPtr_ResourceSets;

		// Token: 0x04002FA2 RID: 12194
		private static readonly IntPtr NativeFieldInfoPtr__resourceSets;

		// Token: 0x04002FA3 RID: 12195
		private static readonly IntPtr NativeFieldInfoPtr_moduleDir;

		// Token: 0x04002FA4 RID: 12196
		private static readonly IntPtr NativeFieldInfoPtr_MainAssembly;

		// Token: 0x04002FA5 RID: 12197
		private static readonly IntPtr NativeFieldInfoPtr__locationInfo;

		// Token: 0x04002FA6 RID: 12198
		private static readonly IntPtr NativeFieldInfoPtr__userResourceSet;

		// Token: 0x04002FA7 RID: 12199
		private static readonly IntPtr NativeFieldInfoPtr__neutralResourcesCulture;

		// Token: 0x04002FA8 RID: 12200
		private static readonly IntPtr NativeFieldInfoPtr__lastUsedResourceCache;

		// Token: 0x04002FA9 RID: 12201
		private static readonly IntPtr NativeFieldInfoPtr__ignoreCase;

		// Token: 0x04002FAA RID: 12202
		private static readonly IntPtr NativeFieldInfoPtr_UseManifest;

		// Token: 0x04002FAB RID: 12203
		private static readonly IntPtr NativeFieldInfoPtr_UseSatelliteAssem;

		// Token: 0x04002FAC RID: 12204
		private static readonly IntPtr NativeFieldInfoPtr__fallbackLoc;

		// Token: 0x04002FAD RID: 12205
		private static readonly IntPtr NativeFieldInfoPtr__satelliteContractVersion;

		// Token: 0x04002FAE RID: 12206
		private static readonly IntPtr NativeFieldInfoPtr__lookedForSatelliteContractVersion;

		// Token: 0x04002FAF RID: 12207
		private static readonly IntPtr NativeFieldInfoPtr__callingAssembly;

		// Token: 0x04002FB0 RID: 12208
		private static readonly IntPtr NativeFieldInfoPtr_m_callingAssembly;

		// Token: 0x04002FB1 RID: 12209
		private static readonly IntPtr NativeFieldInfoPtr_resourceGroveler;

		// Token: 0x04002FB2 RID: 12210
		private static readonly IntPtr NativeFieldInfoPtr_MagicNumber;

		// Token: 0x04002FB3 RID: 12211
		private static readonly IntPtr NativeFieldInfoPtr_HeaderVersionNumber;

		// Token: 0x04002FB4 RID: 12212
		private static readonly IntPtr NativeFieldInfoPtr__minResourceSet;

		// Token: 0x04002FB5 RID: 12213
		private static readonly IntPtr NativeFieldInfoPtr_ResReaderTypeName;

		// Token: 0x04002FB6 RID: 12214
		private static readonly IntPtr NativeFieldInfoPtr_ResSetTypeName;

		// Token: 0x04002FB7 RID: 12215
		private static readonly IntPtr NativeFieldInfoPtr_MscorlibName;

		// Token: 0x04002FB8 RID: 12216
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04002FB9 RID: 12217
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04002FBA RID: 12218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002FBB RID: 12219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04002FBC RID: 12220
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04002FBD RID: 12221
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x04002FBE RID: 12222
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x04002FBF RID: 12223
		private static readonly IntPtr NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0;

		// Token: 0x04002FC0 RID: 12224
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0;

		// Token: 0x04002FC1 RID: 12225
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0;

		// Token: 0x04002FC2 RID: 12226
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0;

		// Token: 0x04002FC3 RID: 12227
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0;

		// Token: 0x04002FC4 RID: 12228
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0;

		// Token: 0x04002FC5 RID: 12229
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002FC6 RID: 12230
		private static readonly IntPtr NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0;

		// Token: 0x04002FC7 RID: 12231
		private static readonly IntPtr NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0;

		// Token: 0x04002FC8 RID: 12232
		private static readonly IntPtr NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0;

		// Token: 0x04002FC9 RID: 12233
		private static readonly IntPtr NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0;

		// Token: 0x04002FCA RID: 12234
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0;

		// Token: 0x04002FCB RID: 12235
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0;

		// Token: 0x020006B5 RID: 1717
		public class CultureNameResourceSetPair : Object
		{
			// Token: 0x06005C67 RID: 23655 RVA: 0x001A3578 File Offset: 0x001A1778
			// Note: this type is marked as 'beforefieldinit'.
			static CultureNameResourceSetPair()
			{
				Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "CultureNameResourceSetPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr);
				ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, "lastCultureName");
				ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, "lastResourceSet");
				ResourceManager.CultureNameResourceSetPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, 100672097);
			}

			// Token: 0x06005C68 RID: 23656 RVA: 0x001A35E0 File Offset: 0x001A17E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CultureNameResourceSetPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.CultureNameResourceSetPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C69 RID: 23657 RVA: 0x00021843 File Offset: 0x0001FA43
			public CultureNameResourceSetPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700179F RID: 6047
			// (get) Token: 0x06005C6A RID: 23658 RVA: 0x001A361C File Offset: 0x001A181C
			// (set) Token: 0x06005C6B RID: 23659 RVA: 0x0002184C File Offset: 0x0001FA4C
			public unsafe string lastCultureName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170017A0 RID: 6048
			// (get) Token: 0x06005C6C RID: 23660 RVA: 0x001A3644 File Offset: 0x001A1844
			// (set) Token: 0x06005C6D RID: 23661 RVA: 0x0002186B File Offset: 0x0001FA6B
			public unsafe ResourceSet lastResourceSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B18 RID: 19224
			private static readonly IntPtr NativeFieldInfoPtr_lastCultureName;

			// Token: 0x04004B19 RID: 19225
			private static readonly IntPtr NativeFieldInfoPtr_lastResourceSet;

			// Token: 0x04004B1A RID: 19226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020006B6 RID: 1718
		public class ResourceManagerMediator : Object
		{
			// Token: 0x06005C6E RID: 23662 RVA: 0x001A3674 File Offset: 0x001A1874
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceManagerMediator()
			{
				Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResourceManagerMediator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr);
				ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, "_rm");
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672098);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672099);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672100);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672101);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672102);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672103);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672104);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672105);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672106);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672107);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672108);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672109);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672110);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672111);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672112);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100672113);
			}

			// Token: 0x06005C6F RID: 23663 RVA: 0x001A37F4 File Offset: 0x001A19F4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1397085, RefRangeEnd = 1397089, XrefRangeStart = 1397077, XrefRangeEnd = 1397085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResourceManagerMediator(ResourceManager rm)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170017A2 RID: 6050
			// (get) Token: 0x06005C70 RID: 23664 RVA: 0x001A3840 File Offset: 0x001A1A40
			public unsafe string ModuleDir
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 567366, RefRangeEnd = 567370, XrefRangeStart = 567366, XrefRangeEnd = 567370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170017A3 RID: 6051
			// (get) Token: 0x06005C71 RID: 23665 RVA: 0x001A3878 File Offset: 0x001A1A78
			public unsafe Type LocationInfo
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 1397089, RefRangeEnd = 1397096, XrefRangeStart = 1397089, XrefRangeEnd = 1397089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x170017A4 RID: 6052
			// (get) Token: 0x06005C72 RID: 23666 RVA: 0x001A38B8 File Offset: 0x001A1AB8
			public unsafe Type UserResourceSet
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 1397096, RefRangeEnd = 1397101, XrefRangeStart = 1397096, XrefRangeEnd = 1397096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x170017A5 RID: 6053
			// (get) Token: 0x06005C73 RID: 23667 RVA: 0x001A38F8 File Offset: 0x001A1AF8
			public unsafe string BaseNameField
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 399714, RefRangeEnd = 399719, XrefRangeStart = 399714, XrefRangeEnd = 399719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170017A6 RID: 6054
			// (get) Token: 0x06005C74 RID: 23668 RVA: 0x001A3930 File Offset: 0x001A1B30
			public unsafe CultureInfo NeutralResourcesCulture
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 1397101, RefRangeEnd = 1397107, XrefRangeStart = 1397101, XrefRangeEnd = 1397101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06005C75 RID: 23669 RVA: 0x001A3970 File Offset: 0x001A1B70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1397108, RefRangeEnd = 1397110, XrefRangeStart = 1397107, XrefRangeEnd = 1397108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetResourceFileName(CultureInfo culture)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170017A7 RID: 6055
			// (get) Token: 0x06005C76 RID: 23670 RVA: 0x001A39B8 File Offset: 0x001A1BB8
			// (set) Token: 0x06005C77 RID: 23671 RVA: 0x001A39F4 File Offset: 0x001A1BF4
			public unsafe bool LookedForSatelliteContractVersion
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1397110, RefRangeEnd = 1397111, XrefRangeStart = 1397110, XrefRangeEnd = 1397110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1397111, RefRangeEnd = 1397112, XrefRangeStart = 1397111, XrefRangeEnd = 1397111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170017A8 RID: 6056
			// (get) Token: 0x06005C78 RID: 23672 RVA: 0x001A3A34 File Offset: 0x001A1C34
			// (set) Token: 0x06005C79 RID: 23673 RVA: 0x001A3A74 File Offset: 0x001A1C74
			public unsafe Version SatelliteContractVersion
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1397112, RefRangeEnd = 1397115, XrefRangeStart = 1397112, XrefRangeEnd = 1397112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1397117, RefRangeEnd = 1397118, XrefRangeStart = 1397115, XrefRangeEnd = 1397117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005C7A RID: 23674 RVA: 0x001A3AB8 File Offset: 0x001A1CB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1397122, RefRangeEnd = 1397123, XrefRangeStart = 1397118, XrefRangeEnd = 1397122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Version ObtainSatelliteContractVersion(Assembly a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
				}
			}

			// Token: 0x170017A9 RID: 6057
			// (get) Token: 0x06005C7B RID: 23675 RVA: 0x001A3B08 File Offset: 0x001A1D08
			public unsafe UltimateResourceFallbackLocation FallbackLoc
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 1397123, RefRangeEnd = 1397129, XrefRangeStart = 1397123, XrefRangeEnd = 1397123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170017AA RID: 6058
			// (get) Token: 0x06005C7C RID: 23676 RVA: 0x001A3B44 File Offset: 0x001A1D44
			public unsafe RuntimeAssembly CallingAssembly
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1397129, RefRangeEnd = 1397132, XrefRangeStart = 1397129, XrefRangeEnd = 1397129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
				}
			}

			// Token: 0x170017AB RID: 6059
			// (get) Token: 0x06005C7D RID: 23677 RVA: 0x001A3B84 File Offset: 0x001A1D84
			public unsafe RuntimeAssembly MainAssembly
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 1397134, RefRangeEnd = 1397149, XrefRangeStart = 1397132, XrefRangeEnd = 1397134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
				}
			}

			// Token: 0x170017AC RID: 6060
			// (get) Token: 0x06005C7E RID: 23678 RVA: 0x001A3BC4 File Offset: 0x001A1DC4
			public unsafe string BaseName
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 558651, RefRangeEnd = 558652, XrefRangeStart = 558651, XrefRangeEnd = 558652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005C7F RID: 23679 RVA: 0x0002188A File Offset: 0x0001FA8A
			public ResourceManagerMediator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017A1 RID: 6049
			// (get) Token: 0x06005C80 RID: 23680 RVA: 0x001A3BFC File Offset: 0x001A1DFC
			// (set) Token: 0x06005C81 RID: 23681 RVA: 0x00021893 File Offset: 0x0001FA93
			public unsafe ResourceManager _rm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B1B RID: 19227
			private static readonly IntPtr NativeFieldInfoPtr__rm;

			// Token: 0x04004B1C RID: 19228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0;

			// Token: 0x04004B1D RID: 19229
			private static readonly IntPtr NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0;

			// Token: 0x04004B1E RID: 19230
			private static readonly IntPtr NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0;

			// Token: 0x04004B1F RID: 19231
			private static readonly IntPtr NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0;

			// Token: 0x04004B20 RID: 19232
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0;

			// Token: 0x04004B21 RID: 19233
			private static readonly IntPtr NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0;

			// Token: 0x04004B22 RID: 19234
			private static readonly IntPtr NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0;

			// Token: 0x04004B23 RID: 19235
			private static readonly IntPtr NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0;

			// Token: 0x04004B24 RID: 19236
			private static readonly IntPtr NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0;

			// Token: 0x04004B25 RID: 19237
			private static readonly IntPtr NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0;

			// Token: 0x04004B26 RID: 19238
			private static readonly IntPtr NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0;

			// Token: 0x04004B27 RID: 19239
			private static readonly IntPtr NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0;

			// Token: 0x04004B28 RID: 19240
			private static readonly IntPtr NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0;

			// Token: 0x04004B29 RID: 19241
			private static readonly IntPtr NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0;

			// Token: 0x04004B2A RID: 19242
			private static readonly IntPtr NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0;

			// Token: 0x04004B2B RID: 19243
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseName_Internal_get_String_0;
		}
	}
}
