using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000080 RID: 128
	public class DocumentationInfo : Object
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentationInfo()
		{
			Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DocumentationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr);
			DocumentationInfo.NativeFieldInfoPtr_fallbackVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr, "fallbackVersion");
			DocumentationInfo.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr, "url");
			DocumentationInfo.NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr, 100664647);
			DocumentationInfo.NativeMethodInfoPtr_GetPageLink_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr, 100664648);
			DocumentationInfo.NativeMethodInfoPtr_GetPageLink_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr, 100664649);
			DocumentationInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr, 100664650);
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0002D960 File Offset: 0x0002BB60
		public unsafe static string version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965909, XrefRangeEnd = 965911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentationInfo.NativeMethodInfoPtr_get_version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0002D98C File Offset: 0x0002BB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965911, XrefRangeEnd = 965940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPageLink(string packageName, string pageName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(packageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pageName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentationInfo.NativeMethodInfoPtr_GetPageLink_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0002D9DC File Offset: 0x0002BBDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 965966, RefRangeEnd = 965968, XrefRangeStart = 965940, XrefRangeEnd = 965966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPageLink(string packageName, string pageName, string pageHash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(packageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pageName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pageHash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentationInfo.NativeMethodInfoPtr_GetPageLink_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0002DA3C File Offset: 0x0002BC3C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentationInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentationInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentationInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000055F8 File Offset: 0x000037F8
		public DocumentationInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0002DA78 File Offset: 0x0002BC78
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00005601 File Offset: 0x00003801
		public unsafe static string fallbackVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DocumentationInfo.NativeFieldInfoPtr_fallbackVersion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DocumentationInfo.NativeFieldInfoPtr_fallbackVersion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0002DA98 File Offset: 0x0002BC98
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00005613 File Offset: 0x00003813
		public unsafe static string url
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DocumentationInfo.NativeFieldInfoPtr_url, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DocumentationInfo.NativeFieldInfoPtr_url, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_fallbackVersion;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_GetPageLink_Public_Static_String_String_String_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_GetPageLink_Public_Static_String_String_String_String_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
