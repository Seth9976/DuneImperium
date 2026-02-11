using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.XmlConfiguration
{
	// Token: 0x020000FF RID: 255
	public sealed class XmlReaderSection : Object
	{
		// Token: 0x06001728 RID: 5928 RVA: 0x00079854 File Offset: 0x00077A54
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReaderSection()
		{
			Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XmlConfiguration", "XmlReaderSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr);
			XmlReaderSection.NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100666943);
			XmlReaderSection.NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100666944);
			XmlReaderSection.NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100666945);
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x000798C0 File Offset: 0x00077AC0
		public unsafe static bool ProhibitDefaultUrlResolver
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSection.NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000798F0 File Offset: 0x00077AF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 390390, RefRangeEnd = 390394, XrefRangeStart = 390386, XrefRangeEnd = 390390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlResolver CreateDefaultResolver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSection.NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00079924 File Offset: 0x00077B24
		public unsafe static bool CollapseWhiteSpaceIntoEmptyString
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSection.NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00009DF5 File Offset: 0x00007FF5
		public XmlReaderSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0;
	}
}
