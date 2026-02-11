using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Configuration
{
	// Token: 0x02000003 RID: 3
	public class ConfigurationSection : ConfigurationElement
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002310 File Offset: 0x00000510
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationSection()
		{
			Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr);
			ConfigurationSection.NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr, 100663301);
			ConfigurationSection.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr, 100663302);
			ConfigurationSection.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr, 100663303);
			ConfigurationSection.NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_New_String_ConfigurationElement_String_ConfigurationSaveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002390 File Offset: 0x00000590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275217, XrefRangeEnd = 1275220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeserializeSection(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationSection.NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_New_Void_XmlReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023E0 File Offset: 0x000005E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275220, XrefRangeEnd = 1275223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationSection.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002428 File Offset: 0x00000628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275223, XrefRangeEnd = 1275226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationSection.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002464 File Offset: 0x00000664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275226, XrefRangeEnd = 1275229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationSection.NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_New_String_ConfigurationElement_String_ConfigurationSaveMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002059 File Offset: 0x00000259
		public ConfigurationSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_New_Void_XmlReader_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_New_String_ConfigurationElement_String_ConfigurationSaveMode_0;
	}
}
