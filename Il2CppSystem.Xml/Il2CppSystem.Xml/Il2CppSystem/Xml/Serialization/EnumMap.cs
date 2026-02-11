using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000FE RID: 254
	public class EnumMap : ObjectMap
	{
		// Token: 0x06001715 RID: 5909 RVA: 0x0007943C File Offset: 0x0007763C
		// Note: this type is marked as 'beforefieldinit'.
		static EnumMap()
		{
			Il2CppClassPointerStore<EnumMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "EnumMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumMap>.NativeClassPtr);
			EnumMap.NativeFieldInfoPtr__members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_members");
			EnumMap.NativeFieldInfoPtr__isFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_isFlags");
			EnumMap.NativeFieldInfoPtr__enumNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_enumNames");
			EnumMap.NativeFieldInfoPtr__xmlNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_xmlNames");
			EnumMap.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_values");
			EnumMap.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EnumMapMember_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666932);
			EnumMap.NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666933);
			EnumMap.NativeMethodInfoPtr_get_EnumNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666934);
			EnumMap.NativeMethodInfoPtr_get_XmlNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666935);
			EnumMap.NativeMethodInfoPtr_get_Values_Public_get_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666936);
			EnumMap.NativeMethodInfoPtr_GetXmlName_Public_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666937);
			EnumMap.NativeMethodInfoPtr_GetEnumName_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666938);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0007955C File Offset: 0x0007775C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390359, RefRangeEnd = 390360, XrefRangeStart = 390343, XrefRangeEnd = 390359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumMap(Il2CppReferenceArray<EnumMap.EnumMapMember> members, bool isFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EnumMapMember_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x000795B8 File Offset: 0x000777B8
		public unsafe bool IsFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x000795F4 File Offset: 0x000777F4
		public unsafe Il2CppStringArray EnumNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_get_EnumNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x00079634 File Offset: 0x00077834
		public unsafe Il2CppStringArray XmlNames
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_get_XmlNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00079674 File Offset: 0x00077874
		public unsafe Il2CppStructArray<long> Values
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_get_Values_Public_get_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000796B4 File Offset: 0x000778B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390376, RefRangeEnd = 390378, XrefRangeStart = 390360, XrefRangeEnd = 390376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetXmlName(string typeName, Object enumValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_GetXmlName_Public_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00079710 File Offset: 0x00077910
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 390383, RefRangeEnd = 390386, XrefRangeStart = 390378, XrefRangeEnd = 390383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEnumName(string typeName, string xmlName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_GetEnumName_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00009D55 File Offset: 0x00007F55
		public EnumMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0007976C File Offset: 0x0007796C
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x00009D5E File Offset: 0x00007F5E
		public unsafe Il2CppReferenceArray<EnumMap.EnumMapMember> _members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EnumMap.EnumMapMember>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x0007979C File Offset: 0x0007799C
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x00009D7D File Offset: 0x00007F7D
		public unsafe bool _isFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__isFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__isFlags)) = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x000797C4 File Offset: 0x000779C4
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x00009D98 File Offset: 0x00007F98
		public unsafe Il2CppStringArray _enumNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__enumNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__enumNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x000797F4 File Offset: 0x000779F4
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x00009DB7 File Offset: 0x00007FB7
		public unsafe Il2CppStringArray _xmlNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__xmlNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__xmlNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00079824 File Offset: 0x00077A24
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x00009DD6 File Offset: 0x00007FD6
		public unsafe Il2CppStructArray<long> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeFieldInfoPtr__members;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeFieldInfoPtr__isFlags;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeFieldInfoPtr__enumNames;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeFieldInfoPtr__xmlNames;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EnumMapMember_Boolean_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_get_EnumNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_Il2CppStructArray_1_Int64_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlName_Public_String_String_Object_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumName_Public_String_String_String_0;

		// Token: 0x02000253 RID: 595
		public class EnumMapMember : Object
		{
			// Token: 0x06003139 RID: 12601 RVA: 0x000DC63C File Offset: 0x000DA83C
			// Note: this type is marked as 'beforefieldinit'.
			static EnumMapMember()
			{
				Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "EnumMapMember");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr);
				EnumMap.EnumMapMember.NativeFieldInfoPtr__xmlName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, "_xmlName");
				EnumMap.EnumMapMember.NativeFieldInfoPtr__enumName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, "_enumName");
				EnumMap.EnumMapMember.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, "_value");
				EnumMap.EnumMapMember.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, 100666939);
				EnumMap.EnumMapMember.NativeMethodInfoPtr_get_XmlName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, 100666940);
				EnumMap.EnumMapMember.NativeMethodInfoPtr_get_EnumName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, 100666941);
				EnumMap.EnumMapMember.NativeMethodInfoPtr_get_Value_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, 100666942);
			}

			// Token: 0x0600313A RID: 12602 RVA: 0x000DC6F4 File Offset: 0x000DA8F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 390342, RefRangeEnd = 390343, XrefRangeStart = 390339, XrefRangeEnd = 390342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnumMapMember(string xmlName, string enumName, long value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(enumName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.EnumMapMember.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001095 RID: 4245
			// (get) Token: 0x0600313B RID: 12603 RVA: 0x000DC760 File Offset: 0x000DA960
			public unsafe string XmlName
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.EnumMapMember.NativeMethodInfoPtr_get_XmlName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001096 RID: 4246
			// (get) Token: 0x0600313C RID: 12604 RVA: 0x000DC798 File Offset: 0x000DA998
			public unsafe string EnumName
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.EnumMapMember.NativeMethodInfoPtr_get_EnumName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001097 RID: 4247
			// (get) Token: 0x0600313D RID: 12605 RVA: 0x000DC7D0 File Offset: 0x000DA9D0
			public unsafe long Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.EnumMapMember.NativeMethodInfoPtr_get_Value_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600313E RID: 12606 RVA: 0x00014D1F File Offset: 0x00012F1F
			public EnumMapMember(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001092 RID: 4242
			// (get) Token: 0x0600313F RID: 12607 RVA: 0x000DC80C File Offset: 0x000DAA0C
			// (set) Token: 0x06003140 RID: 12608 RVA: 0x00014D28 File Offset: 0x00012F28
			public unsafe string _xmlName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__xmlName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__xmlName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001093 RID: 4243
			// (get) Token: 0x06003141 RID: 12609 RVA: 0x000DC834 File Offset: 0x000DAA34
			// (set) Token: 0x06003142 RID: 12610 RVA: 0x00014D47 File Offset: 0x00012F47
			public unsafe string _enumName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__enumName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__enumName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001094 RID: 4244
			// (get) Token: 0x06003143 RID: 12611 RVA: 0x000DC85C File Offset: 0x000DAA5C
			// (set) Token: 0x06003144 RID: 12612 RVA: 0x00014D66 File Offset: 0x00012F66
			public unsafe long _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__value)) = value;
				}
			}

			// Token: 0x04002619 RID: 9753
			private static readonly IntPtr NativeFieldInfoPtr__xmlName;

			// Token: 0x0400261A RID: 9754
			private static readonly IntPtr NativeFieldInfoPtr__enumName;

			// Token: 0x0400261B RID: 9755
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x0400261C RID: 9756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0;

			// Token: 0x0400261D RID: 9757
			private static readonly IntPtr NativeMethodInfoPtr_get_XmlName_Public_get_String_0;

			// Token: 0x0400261E RID: 9758
			private static readonly IntPtr NativeMethodInfoPtr_get_EnumName_Public_get_String_0;

			// Token: 0x0400261F RID: 9759
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int64_0;
		}
	}
}
