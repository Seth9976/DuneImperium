using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Configuration
{
	// Token: 0x02000009 RID: 9
	public sealed class IgnoreSection : ConfigurationSection
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002524 File Offset: 0x00000724
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoreSection()
		{
			Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "IgnoreSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr);
			IgnoreSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr, 100663306);
			IgnoreSection.NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr, 100663307);
			IgnoreSection.NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr, 100663308);
			IgnoreSection.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr, 100663309);
			IgnoreSection.NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_Void_ConfigurationElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr, 100663310);
			IgnoreSection.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr, 100663311);
			IgnoreSection.NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_String_ConfigurationElement_String_ConfigurationSaveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr, 100663312);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000025E0 File Offset: 0x000007E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275229, XrefRangeEnd = 1275232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IgnoreSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoreSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000261C File Offset: 0x0000081C
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275232, XrefRangeEnd = 1275235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreSection.NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000265C File Offset: 0x0000085C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275235, XrefRangeEnd = 1275238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSection(XmlReader xmlReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreSection.NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000026A0 File Offset: 0x000008A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275238, XrefRangeEnd = 1275241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreSection.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026DC File Offset: 0x000008DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275241, XrefRangeEnd = 1275244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(ConfigurationElement parentSection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreSection.NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_Void_ConfigurationElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002720 File Offset: 0x00000920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275244, XrefRangeEnd = 1275247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreSection.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002754 File Offset: 0x00000954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275247, XrefRangeEnd = 1275250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreSection.NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_String_ConfigurationElement_String_ConfigurationSaveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000212E File Offset: 0x0000032E
		public IgnoreSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_get_ConfigurationPropertyCollection_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_Void_XmlReader_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_Void_ConfigurationElement_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_String_ConfigurationElement_String_ConfigurationSaveMode_0;
	}
}
