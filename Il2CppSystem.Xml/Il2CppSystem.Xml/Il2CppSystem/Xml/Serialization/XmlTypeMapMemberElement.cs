using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F3 RID: 243
	public class XmlTypeMapMemberElement : XmlTypeMapMember
	{
		// Token: 0x0600166C RID: 5740 RVA: 0x00076ED0 File Offset: 0x000750D0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberElement()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr);
			XmlTypeMapMemberElement.NativeFieldInfoPtr__elementInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, "_elementInfo");
			XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, "_choiceMember");
			XmlTypeMapMemberElement.NativeFieldInfoPtr__isTextCollector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, "_isTextCollector");
			XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceTypeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, "_choiceTypeData");
			XmlTypeMapMemberElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666857);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ElementInfo_Public_get_XmlTypeMapElementInfoList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666858);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ElementInfo_Public_set_Void_XmlTypeMapElementInfoList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666859);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ChoiceMember_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666860);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666861);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ChoiceTypeData_Public_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666862);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ChoiceTypeData_Public_set_Void_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666863);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666864);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_SetChoice_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666865);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_get_IsXmlTextCollector_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666866);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_set_IsXmlTextCollector_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666867);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0007702C File Offset: 0x0007522C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 389801, RefRangeEnd = 389807, XrefRangeStart = 389800, XrefRangeEnd = 389801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00077068 File Offset: 0x00075268
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x000770A8 File Offset: 0x000752A8
		public unsafe XmlTypeMapElementInfoList ElementInfo
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 389812, RefRangeEnd = 389817, XrefRangeStart = 389807, XrefRangeEnd = 389812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ElementInfo_Public_get_XmlTypeMapElementInfoList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ElementInfo_Public_set_Void_XmlTypeMapElementInfoList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x000770EC File Offset: 0x000752EC
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x00077124 File Offset: 0x00075324
		public unsafe string ChoiceMember
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ChoiceMember_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00077168 File Offset: 0x00075368
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x000771A8 File Offset: 0x000753A8
		public unsafe TypeData ChoiceTypeData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ChoiceTypeData_Public_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ChoiceTypeData_Public_set_Void_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000771EC File Offset: 0x000753EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389832, RefRangeEnd = 389833, XrefRangeStart = 389817, XrefRangeEnd = 389832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo FindElement(Object ob, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfo>(intPtr3) : null;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00077250 File Offset: 0x00075450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389833, XrefRangeEnd = 389837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChoice(Object ob, Object choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choice);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_SetChoice_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x000772A4 File Offset: 0x000754A4
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x000772E0 File Offset: 0x000754E0
		public unsafe bool IsXmlTextCollector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_get_IsXmlTextCollector_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_set_IsXmlTextCollector_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000097FC File Offset: 0x000079FC
		public XmlTypeMapMemberElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00077320 File Offset: 0x00075520
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x00009805 File Offset: 0x00007A05
		public unsafe XmlTypeMapElementInfoList _elementInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__elementInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__elementInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x00077350 File Offset: 0x00075550
		// (set) Token: 0x0600167C RID: 5756 RVA: 0x00009824 File Offset: 0x00007A24
		public unsafe string _choiceMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceMember);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceMember), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00077378 File Offset: 0x00075578
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x00009843 File Offset: 0x00007A43
		public unsafe bool _isTextCollector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__isTextCollector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__isTextCollector)) = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x000773A0 File Offset: 0x000755A0
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x0000985E File Offset: 0x00007A5E
		public unsafe TypeData _choiceTypeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceTypeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceTypeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeFieldInfoPtr__elementInfo;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeFieldInfoPtr__choiceMember;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeFieldInfoPtr__isTextCollector;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeFieldInfoPtr__choiceTypeData;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementInfo_Public_get_XmlTypeMapElementInfoList_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementInfo_Public_set_Void_XmlTypeMapElementInfoList_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoiceMember_Public_get_String_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoiceTypeData_Public_get_TypeData_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_set_ChoiceTypeData_Public_set_Void_TypeData_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Object_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_SetChoice_Public_Void_Object_Object_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXmlTextCollector_Public_get_Boolean_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_set_IsXmlTextCollector_Public_set_Void_Boolean_0;
	}
}
