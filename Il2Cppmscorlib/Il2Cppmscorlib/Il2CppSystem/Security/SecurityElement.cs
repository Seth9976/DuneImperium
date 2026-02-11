using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security
{
	// Token: 0x02000222 RID: 546
	[Serializable]
	public sealed class SecurityElement : Object
	{
		// Token: 0x06002432 RID: 9266 RVA: 0x000CA638 File Offset: 0x000C8838
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityElement()
		{
			Il2CppClassPointerStore<SecurityElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr);
			SecurityElement.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "text");
			SecurityElement.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "tag");
			SecurityElement.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "attributes");
			SecurityElement.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "children");
			SecurityElement.NativeFieldInfoPtr_invalid_tag_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_tag_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_text_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_text_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_attr_name_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_attr_value_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_chars");
			SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669405);
			SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669406);
			SecurityElement.NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669407);
			SecurityElement.NativeMethodInfoPtr_get_Tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669408);
			SecurityElement.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669409);
			SecurityElement.NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669410);
			SecurityElement.NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669411);
			SecurityElement.NativeMethodInfoPtr_Escape_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669412);
			SecurityElement.NativeMethodInfoPtr_Unescape_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669413);
			SecurityElement.NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669414);
			SecurityElement.NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669415);
			SecurityElement.NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669416);
			SecurityElement.NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669417);
			SecurityElement.NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669418);
			SecurityElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669419);
			SecurityElement.NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669420);
			SecurityElement.NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669421);
			SecurityElement.NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669422);
			SecurityElement.NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100669423);
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x000CA898 File Offset: 0x000C8A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369877, RefRangeEnd = 1369878, XrefRangeStart = 1369876, XrefRangeEnd = 1369877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement(string tag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x000CA8E4 File Offset: 0x000C8AE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1369924, RefRangeEnd = 1369927, XrefRangeStart = 1369878, XrefRangeEnd = 1369924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement(string tag, string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x000CA944 File Offset: 0x000C8B44
		public unsafe ArrayList Children
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x000CA984 File Offset: 0x000C8B84
		public unsafe string Tag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x000CA9BC File Offset: 0x000C8BBC
		public unsafe string Text
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1369948, RefRangeEnd = 1369949, XrefRangeStart = 1369927, XrefRangeEnd = 1369948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x000CAA00 File Offset: 0x000C8C00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1369980, RefRangeEnd = 1369987, XrefRangeStart = 1369949, XrefRangeEnd = 1369980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x000CAA54 File Offset: 0x000C8C54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1369999, RefRangeEnd = 1370001, XrefRangeStart = 1369987, XrefRangeEnd = 1369999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(SecurityElement child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x000CAA98 File Offset: 0x000C8C98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1370032, RefRangeEnd = 1370036, XrefRangeStart = 1370001, XrefRangeEnd = 1370032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Escape(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_Escape_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x000CAAD4 File Offset: 0x000C8CD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1370065, RefRangeEnd = 1370068, XrefRangeStart = 1370036, XrefRangeEnd = 1370065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Unescape(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_Unescape_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x000CAB10 File Offset: 0x000C8D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370068, XrefRangeEnd = 1370069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidAttributeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x000CAB54 File Offset: 0x000C8D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370069, XrefRangeEnd = 1370070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidAttributeValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x000CAB98 File Offset: 0x000C8D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370070, XrefRangeEnd = 1370071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidTag(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x000CABDC File Offset: 0x000C8DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370071, XrefRangeEnd = 1370072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidText(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x000CAC20 File Offset: 0x000C8E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370076, RefRangeEnd = 1370077, XrefRangeStart = 1370072, XrefRangeEnd = 1370076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement SearchForChildByTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x000CAC70 File Offset: 0x000C8E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370077, XrefRangeEnd = 1370082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x000CACA8 File Offset: 0x000C8EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1370146, RefRangeEnd = 1370148, XrefRangeStart = 1370082, XrefRangeEnd = 1370146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToXml(ref StringBuilder s, int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(s);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			s = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x000CAD10 File Offset: 0x000C8F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370158, RefRangeEnd = 1370159, XrefRangeStart = 1370148, XrefRangeEnd = 1370158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement.SecurityAttribute GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement.SecurityAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x000CAD60 File Offset: 0x000C8F60
		public unsafe string m_strText
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x000CADA4 File Offset: 0x000C8FA4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1370172, RefRangeEnd = 1370189, XrefRangeStart = 1370159, XrefRangeEnd = 1370172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SearchForTextOfLocalName(string strLocalName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strLocalName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		public SecurityElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x000CADEC File Offset: 0x000C8FEC
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x0000B8B1 File Offset: 0x00009AB1
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000CAE14 File Offset: 0x000C9014
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		public unsafe string tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x000CAE3C File Offset: 0x000C903C
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x0000B8EF File Offset: 0x00009AEF
		public unsafe ArrayList attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x000CAE6C File Offset: 0x000C906C
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x0000B90E File Offset: 0x00009B0E
		public unsafe ArrayList children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x000CAE9C File Offset: 0x000C909C
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x0000B92D File Offset: 0x00009B2D
		public unsafe static Il2CppStructArray<char> invalid_tag_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_tag_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_tag_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x000CAEC4 File Offset: 0x000C90C4
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x0000B93F File Offset: 0x00009B3F
		public unsafe static Il2CppStructArray<char> invalid_text_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_text_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_text_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000CAEEC File Offset: 0x000C90EC
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x0000B951 File Offset: 0x00009B51
		public unsafe static Il2CppStructArray<char> invalid_attr_name_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x000CAF14 File Offset: 0x000C9114
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0000B963 File Offset: 0x00009B63
		public unsafe static Il2CppStructArray<char> invalid_attr_value_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x000CAF3C File Offset: 0x000C913C
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0000B975 File Offset: 0x00009B75
		public unsafe static Il2CppStructArray<char> invalid_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeFieldInfoPtr_tag;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr_invalid_tag_chars;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr_invalid_text_chars;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_invalid_attr_name_chars;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_invalid_attr_value_chars;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeFieldInfoPtr_invalid_chars;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_String_0;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeMethodInfoPtr_Escape_Public_Static_String_String_0;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeMethodInfoPtr_Unescape_Private_Static_String_String_0;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0;

		// Token: 0x0200065A RID: 1626
		public class SecurityAttribute : Object
		{
			// Token: 0x06005A50 RID: 23120 RVA: 0x0019D004 File Offset: 0x0019B204
			// Note: this type is marked as 'beforefieldinit'.
			static SecurityAttribute()
			{
				Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "SecurityAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr);
				SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, "_name");
				SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, "_value");
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100669425);
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100669426);
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100669427);
			}

			// Token: 0x06005A51 RID: 23121 RVA: 0x0019D094 File Offset: 0x0019B294
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1369875, RefRangeEnd = 1369876, XrefRangeStart = 1369836, XrefRangeEnd = 1369875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SecurityAttribute(string name, string value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700170E RID: 5902
			// (get) Token: 0x06005A52 RID: 23122 RVA: 0x0019D0F4 File Offset: 0x0019B2F4
			public unsafe string Name
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700170F RID: 5903
			// (get) Token: 0x06005A53 RID: 23123 RVA: 0x0019D12C File Offset: 0x0019B32C
			public unsafe string Value
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005A54 RID: 23124 RVA: 0x00020620 File Offset: 0x0001E820
			public SecurityAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700170C RID: 5900
			// (get) Token: 0x06005A55 RID: 23125 RVA: 0x0019D164 File Offset: 0x0019B364
			// (set) Token: 0x06005A56 RID: 23126 RVA: 0x00020629 File Offset: 0x0001E829
			public unsafe string _name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700170D RID: 5901
			// (get) Token: 0x06005A57 RID: 23127 RVA: 0x0019D18C File Offset: 0x0019B38C
			// (set) Token: 0x06005A58 RID: 23128 RVA: 0x00020648 File Offset: 0x0001E848
			public unsafe string _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040049DF RID: 18911
			private static readonly IntPtr NativeFieldInfoPtr__name;

			// Token: 0x040049E0 RID: 18912
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x040049E1 RID: 18913
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x040049E2 RID: 18914
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x040049E3 RID: 18915
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
		}
	}
}
