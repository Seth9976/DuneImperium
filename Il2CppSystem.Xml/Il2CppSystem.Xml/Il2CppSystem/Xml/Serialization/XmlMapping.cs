using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D7 RID: 215
	public class XmlMapping : Object
	{
		// Token: 0x06001405 RID: 5125 RVA: 0x0006CA94 File Offset: 0x0006AC94
		// Note: this type is marked as 'beforefieldinit'.
		static XmlMapping()
		{
			Il2CppClassPointerStore<XmlMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr);
			XmlMapping.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "map");
			XmlMapping.NativeFieldInfoPtr_relatedMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "relatedMaps");
			XmlMapping.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "format");
			XmlMapping.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "source");
			XmlMapping.NativeFieldInfoPtr__elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "_elementName");
			XmlMapping.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "_namespace");
			XmlMapping.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "key");
			XmlMapping.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666499);
			XmlMapping.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666500);
			XmlMapping.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666501);
			XmlMapping.NativeMethodInfoPtr_SetKey_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666502);
			XmlMapping.NativeMethodInfoPtr_get_ObjectMap_Internal_get_ObjectMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666503);
			XmlMapping.NativeMethodInfoPtr_set_ObjectMap_Internal_set_Void_ObjectMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666504);
			XmlMapping.NativeMethodInfoPtr_get_RelatedMaps_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666505);
			XmlMapping.NativeMethodInfoPtr_set_RelatedMaps_Internal_set_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666506);
			XmlMapping.NativeMethodInfoPtr_get_Format_Internal_get_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666507);
			XmlMapping.NativeMethodInfoPtr_set_Format_Internal_set_Void_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666508);
			XmlMapping.NativeMethodInfoPtr_get_Source_Internal_get_SerializationSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666509);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0006CC2C File Offset: 0x0006AE2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385825, RefRangeEnd = 385827, XrefRangeStart = 385822, XrefRangeEnd = 385825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlMapping(string elementName, string ns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0006CC8C File Offset: 0x0006AE8C
		public unsafe string ElementName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0006CCC4 File Offset: 0x0006AEC4
		public unsafe string Namespace
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0006CCFC File Offset: 0x0006AEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_SetKey_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0006CD40 File Offset: 0x0006AF40
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0006CD80 File Offset: 0x0006AF80
		public unsafe ObjectMap ObjectMap
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_ObjectMap_Internal_get_ObjectMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectMap>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_set_ObjectMap_Internal_set_Void_ObjectMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0006CDC4 File Offset: 0x0006AFC4
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x0006CE04 File Offset: 0x0006B004
		public unsafe ArrayList RelatedMaps
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_RelatedMaps_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_set_RelatedMaps_Internal_set_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0006CE48 File Offset: 0x0006B048
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x0006CE84 File Offset: 0x0006B084
		public unsafe SerializationFormat Format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_Format_Internal_get_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_set_Format_Internal_set_Void_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0006CEC4 File Offset: 0x0006B0C4
		public unsafe SerializationSource Source
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_Source_Internal_get_SerializationSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationSource>(intPtr3) : null;
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x000088B4 File Offset: 0x00006AB4
		public XmlMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0006CF04 File Offset: 0x0006B104
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x000088BD File Offset: 0x00006ABD
		public unsafe ObjectMap map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0006CF34 File Offset: 0x0006B134
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x000088DC File Offset: 0x00006ADC
		public unsafe ArrayList relatedMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_relatedMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_relatedMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0006CF64 File Offset: 0x0006B164
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x000088FB File Offset: 0x00006AFB
		public unsafe SerializationFormat format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_format)) = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0006CF8C File Offset: 0x0006B18C
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x00008916 File Offset: 0x00006B16
		public unsafe SerializationSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0006CFBC File Offset: 0x0006B1BC
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00008935 File Offset: 0x00006B35
		public unsafe string _elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr__elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr__elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0006CFE4 File Offset: 0x0006B1E4
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x00008954 File Offset: 0x00006B54
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0006D00C File Offset: 0x0006B20C
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00008973 File Offset: 0x00006B73
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeFieldInfoPtr_relatedMaps;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeFieldInfoPtr__elementName;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Void_String_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectMap_Internal_get_ObjectMap_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectMap_Internal_set_Void_ObjectMap_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_get_RelatedMaps_Internal_get_ArrayList_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_set_RelatedMaps_Internal_set_Void_ArrayList_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Internal_get_SerializationFormat_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Internal_set_Void_SerializationFormat_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Internal_get_SerializationSource_0;
	}
}
