using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000FD RID: 253
	public class ListMap : ObjectMap
	{
		// Token: 0x06001705 RID: 5893 RVA: 0x00078F98 File Offset: 0x00077198
		// Note: this type is marked as 'beforefieldinit'.
		static ListMap()
		{
			Il2CppClassPointerStore<ListMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "ListMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListMap>.NativeClassPtr);
			ListMap.NativeFieldInfoPtr__itemInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListMap>.NativeClassPtr, "_itemInfo");
			ListMap.NativeFieldInfoPtr__choiceMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListMap>.NativeClassPtr, "_choiceMember");
			ListMap.NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666922);
			ListMap.NativeMethodInfoPtr_get_ItemInfo_Public_get_XmlTypeMapElementInfoList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666923);
			ListMap.NativeMethodInfoPtr_set_ItemInfo_Public_set_Void_XmlTypeMapElementInfoList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666924);
			ListMap.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666925);
			ListMap.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666926);
			ListMap.NativeMethodInfoPtr_FindTextElement_Public_XmlTypeMapElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666927);
			ListMap.NativeMethodInfoPtr_GetArrayType_Public_Void_Int32_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666928);
			ListMap.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666929);
			ListMap.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666930);
			ListMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666931);
		}

		// Token: 0x17000765 RID: 1893
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x000790B8 File Offset: 0x000772B8
		public unsafe string ChoiceMember
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x000790FC File Offset: 0x000772FC
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x0007913C File Offset: 0x0007733C
		public unsafe XmlTypeMapElementInfoList ItemInfo
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_get_ItemInfo_Public_get_XmlTypeMapElementInfoList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_set_ItemInfo_Public_set_Void_XmlTypeMapElementInfoList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00079180 File Offset: 0x00077380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 390291, RefRangeEnd = 390294, XrefRangeStart = 390251, XrefRangeEnd = 390291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo FindElement(Object ob, int index, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfo>(intPtr3) : null;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000791F0 File Offset: 0x000773F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390294, XrefRangeEnd = 390305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo FindElement(string elementName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfo>(intPtr3) : null;
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00079254 File Offset: 0x00077454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390305, XrefRangeEnd = 390317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo FindTextElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_FindTextElement_Public_XmlTypeMapElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfo>(intPtr3) : null;
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00079294 File Offset: 0x00077494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390333, RefRangeEnd = 390334, XrefRangeStart = 390317, XrefRangeEnd = 390333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetArrayType(int itemCount, out string localName, out string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref itemCount;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_GetArrayType_Public_Void_Int32_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			localName = IL2CPP.Il2CppStringToManaged(intPtr);
			ns = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00079308 File Offset: 0x00077508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390334, XrefRangeEnd = 390339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListMap.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00079360 File Offset: 0x00077560
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListMap.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x000793A8 File Offset: 0x000775A8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00009D0E File Offset: 0x00007F0E
		public ListMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x000793E4 File Offset: 0x000775E4
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x00009D17 File Offset: 0x00007F17
		public unsafe XmlTypeMapElementInfoList _itemInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListMap.NativeFieldInfoPtr__itemInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListMap.NativeFieldInfoPtr__itemInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00079414 File Offset: 0x00077614
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x00009D36 File Offset: 0x00007F36
		public unsafe string _choiceMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListMap.NativeFieldInfoPtr__choiceMember);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListMap.NativeFieldInfoPtr__choiceMember), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeFieldInfoPtr__itemInfo;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeFieldInfoPtr__choiceMember;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemInfo_Public_get_XmlTypeMapElementInfoList_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemInfo_Public_set_Void_XmlTypeMapElementInfoList_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Int32_Object_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_String_String_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_FindTextElement_Public_XmlTypeMapElementInfo_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayType_Public_Void_Int32_byref_String_byref_String_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
