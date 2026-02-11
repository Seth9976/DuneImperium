using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200017C RID: 380
	public class NamespaceListV1Compat : NamespaceList
	{
		// Token: 0x06001E11 RID: 7697 RVA: 0x00094E78 File Offset: 0x00093078
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceListV1Compat()
		{
			Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NamespaceListV1Compat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr);
			NamespaceListV1Compat.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr, 100667826);
			NamespaceListV1Compat.NativeMethodInfoPtr_Allows_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr, 100667827);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00094ED0 File Offset: 0x000930D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 397703, RefRangeEnd = 397705, XrefRangeStart = 397702, XrefRangeEnd = 397703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceListV1Compat(string namespaces, string targetNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaces);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceListV1Compat.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00094F30 File Offset: 0x00093130
		[CallerCount(0)]
		public unsafe override bool Allows(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListV1Compat.NativeMethodInfoPtr_Allows_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0000C507 File Offset: 0x0000A707
		public NamespaceListV1Compat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Public_Virtual_Boolean_String_0;
	}
}
