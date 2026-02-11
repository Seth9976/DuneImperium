using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F7 RID: 247
	public class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
	{
		// Token: 0x06001692 RID: 5778 RVA: 0x000776DC File Offset: 0x000758DC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberAnyElement()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberAnyElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr);
			XmlTypeMapMemberAnyElement.NativeMethodInfoPtr_IsElementDefined_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr, 100666875);
			XmlTypeMapMemberAnyElement.NativeMethodInfoPtr_get_IsDefaultAny_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr, 100666876);
			XmlTypeMapMemberAnyElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr, 100666877);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00077748 File Offset: 0x00075948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389858, RefRangeEnd = 389859, XrefRangeStart = 389837, XrefRangeEnd = 389858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementDefined(string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAnyElement.NativeMethodInfoPtr_IsElementDefined_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x000777A8 File Offset: 0x000759A8
		public unsafe bool IsDefaultAny
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 389876, RefRangeEnd = 389877, XrefRangeStart = 389859, XrefRangeEnd = 389876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAnyElement.NativeMethodInfoPtr_get_IsDefaultAny_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000777E4 File Offset: 0x000759E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 389801, RefRangeEnd = 389807, XrefRangeStart = 389801, XrefRangeEnd = 389807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberAnyElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAnyElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0000990B File Offset: 0x00007B0B
		public XmlTypeMapMemberAnyElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_IsElementDefined_Public_Boolean_String_String_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultAny_Public_get_Boolean_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
