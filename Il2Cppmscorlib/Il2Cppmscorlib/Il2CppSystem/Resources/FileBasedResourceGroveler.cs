using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003EC RID: 1004
	public class FileBasedResourceGroveler : Object
	{
		// Token: 0x06003AAB RID: 15019 RVA: 0x0011A9E4 File Offset: 0x00118BE4
		// Note: this type is marked as 'beforefieldinit'.
		static FileBasedResourceGroveler()
		{
			Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "FileBasedResourceGroveler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr);
			FileBasedResourceGroveler.NativeFieldInfoPtr__mediator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, "_mediator");
			FileBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100672059);
			FileBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100672060);
			FileBasedResourceGroveler.NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100672061);
			FileBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100672062);
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x0011AA78 File Offset: 0x00118C78
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mediator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x0011AAC4 File Offset: 0x00118CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396694, XrefRangeEnd = 1396704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x0011AB54 File Offset: 0x00118D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396704, XrefRangeEnd = 1396711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FindResourceFile(CultureInfo culture, string fileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x0011ABB0 File Offset: 0x00118DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1396726, RefRangeEnd = 1396727, XrefRangeStart = 1396711, XrefRangeEnd = 1396726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet CreateResourceSet(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
			}
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x00015C74 File Offset: 0x00013E74
		public FileBasedResourceGroveler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x0011AC00 File Offset: 0x00118E00
		// (set) Token: 0x06003AB2 RID: 15026 RVA: 0x00015C7D File Offset: 0x00013E7D
		public unsafe ResourceManager.ResourceManagerMediator _mediator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileBasedResourceGroveler.NativeFieldInfoPtr__mediator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager.ResourceManagerMediator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileBasedResourceGroveler.NativeFieldInfoPtr__mediator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeFieldInfoPtr__mediator;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0;
	}
}
