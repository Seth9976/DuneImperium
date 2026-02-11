using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000FC RID: 252
	public class ClassMap : ObjectMap
	{
		// Token: 0x060016CE RID: 5838 RVA: 0x000783B8 File Offset: 0x000765B8
		// Note: this type is marked as 'beforefieldinit'.
		static ClassMap()
		{
			Il2CppClassPointerStore<ClassMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "ClassMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassMap>.NativeClassPtr);
			ClassMap.NativeFieldInfoPtr__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_elements");
			ClassMap.NativeFieldInfoPtr__elementMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_elementMembers");
			ClassMap.NativeFieldInfoPtr__attributeMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_attributeMembers");
			ClassMap.NativeFieldInfoPtr__attributeMembersArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_attributeMembersArray");
			ClassMap.NativeFieldInfoPtr__flatLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_flatLists");
			ClassMap.NativeFieldInfoPtr__allMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_allMembers");
			ClassMap.NativeFieldInfoPtr__membersWithDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_membersWithDefault");
			ClassMap.NativeFieldInfoPtr__listMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_listMembers");
			ClassMap.NativeFieldInfoPtr__defaultAnyElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_defaultAnyElement");
			ClassMap.NativeFieldInfoPtr__defaultAnyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_defaultAnyAttribute");
			ClassMap.NativeFieldInfoPtr__namespaceDeclarations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_namespaceDeclarations");
			ClassMap.NativeFieldInfoPtr__xmlTextCollector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_xmlTextCollector");
			ClassMap.NativeFieldInfoPtr__returnMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_returnMember");
			ClassMap.NativeFieldInfoPtr__ignoreMemberNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_ignoreMemberNamespace");
			ClassMap.NativeFieldInfoPtr__canBeSimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_canBeSimpleType");
			ClassMap.NativeFieldInfoPtr__isOrderDependentMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_isOrderDependentMap");
			ClassMap.NativeMethodInfoPtr_AddMember_Public_Void_XmlTypeMapMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666901);
			ClassMap.NativeMethodInfoPtr_RegisterFlatList_Private_Void_XmlTypeMapMemberExpandable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666902);
			ClassMap.NativeMethodInfoPtr_GetAttribute_Public_XmlTypeMapMemberAttribute_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666903);
			ClassMap.NativeMethodInfoPtr_GetElement_Public_XmlTypeMapElementInfo_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666904);
			ClassMap.NativeMethodInfoPtr_GetElement_Public_XmlTypeMapElementInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666905);
			ClassMap.NativeMethodInfoPtr_BuildKey_Private_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666906);
			ClassMap.NativeMethodInfoPtr_get_IsOrderDependentMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666907);
			ClassMap.NativeMethodInfoPtr_get_DefaultAnyElementMember_Public_get_XmlTypeMapMemberAnyElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666908);
			ClassMap.NativeMethodInfoPtr_get_DefaultAnyAttributeMember_Public_get_XmlTypeMapMemberAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666909);
			ClassMap.NativeMethodInfoPtr_get_NamespaceDeclarations_Public_get_XmlTypeMapMemberNamespaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666910);
			ClassMap.NativeMethodInfoPtr_get_AttributeMembers_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666911);
			ClassMap.NativeMethodInfoPtr_get_ElementMembers_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666912);
			ClassMap.NativeMethodInfoPtr_get_AllMembers_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666913);
			ClassMap.NativeMethodInfoPtr_get_FlatLists_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666914);
			ClassMap.NativeMethodInfoPtr_get_ListMembers_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666915);
			ClassMap.NativeMethodInfoPtr_get_XmlTextCollector_Public_get_XmlTypeMapMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666916);
			ClassMap.NativeMethodInfoPtr_get_ReturnMember_Public_get_XmlTypeMapMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666917);
			ClassMap.NativeMethodInfoPtr_get_SimpleContentBaseType_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666918);
			ClassMap.NativeMethodInfoPtr_SetCanBeSimpleType_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666919);
			ClassMap.NativeMethodInfoPtr_get_HasSimpleContent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666920);
			ClassMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666921);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000786CC File Offset: 0x000768CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390095, RefRangeEnd = 390096, XrefRangeStart = 390029, XrefRangeEnd = 390095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMember(XmlTypeMapMember member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_AddMember_Public_Void_XmlTypeMapMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00078710 File Offset: 0x00076910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390102, RefRangeEnd = 390103, XrefRangeStart = 390096, XrefRangeEnd = 390102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterFlatList(XmlTypeMapMemberExpandable member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_RegisterFlatList_Private_Void_XmlTypeMapMemberExpandable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00078754 File Offset: 0x00076954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390115, RefRangeEnd = 390116, XrefRangeStart = 390103, XrefRangeEnd = 390115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberAttribute GetAttribute(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_GetAttribute_Public_XmlTypeMapMemberAttribute_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberAttribute>(intPtr3) : null;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x000787B8 File Offset: 0x000769B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390116, XrefRangeEnd = 390139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimalOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_GetElement_Public_XmlTypeMapElementInfo_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfo>(intPtr3) : null;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00078828 File Offset: 0x00076A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390139, XrefRangeEnd = 390153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo GetElement(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_GetElement_Public_XmlTypeMapElementInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfo>(intPtr3) : null;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0007888C File Offset: 0x00076A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390153, XrefRangeEnd = 390163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BuildKey(string name, string ns, int explicitOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref explicitOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_BuildKey_Private_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x000788F4 File Offset: 0x00076AF4
		public unsafe bool IsOrderDependentMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390163, XrefRangeEnd = 390191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_IsOrderDependentMap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00078930 File Offset: 0x00076B30
		public unsafe XmlTypeMapMemberAnyElement DefaultAnyElementMember
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_DefaultAnyElementMember_Public_get_XmlTypeMapMemberAnyElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberAnyElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00078970 File Offset: 0x00076B70
		public unsafe XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_DefaultAnyAttributeMember_Public_get_XmlTypeMapMemberAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberAnyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x000789B0 File Offset: 0x00076BB0
		public unsafe XmlTypeMapMemberNamespaces NamespaceDeclarations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_NamespaceDeclarations_Public_get_XmlTypeMapMemberNamespaces_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberNamespaces>(intPtr3) : null;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x000789F0 File Offset: 0x00076BF0
		public unsafe ICollection AttributeMembers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 390217, RefRangeEnd = 390218, XrefRangeStart = 390191, XrefRangeEnd = 390217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_AttributeMembers_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00078A30 File Offset: 0x00076C30
		public unsafe ICollection ElementMembers
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_ElementMembers_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00078A70 File Offset: 0x00076C70
		public unsafe ArrayList AllMembers
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_AllMembers_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x00078AB0 File Offset: 0x00076CB0
		public unsafe ArrayList FlatLists
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_FlatLists_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00078AF0 File Offset: 0x00076CF0
		public unsafe ArrayList ListMembers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_ListMembers_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00078B30 File Offset: 0x00076D30
		public unsafe XmlTypeMapMember XmlTextCollector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_XmlTextCollector_Public_get_XmlTypeMapMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr3) : null;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00078B70 File Offset: 0x00076D70
		public unsafe XmlTypeMapMember ReturnMember
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_ReturnMember_Public_get_XmlTypeMapMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr3) : null;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00078BB0 File Offset: 0x00076DB0
		public unsafe XmlQualifiedName SimpleContentBaseType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 390230, RefRangeEnd = 390231, XrefRangeStart = 390218, XrefRangeEnd = 390230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_SimpleContentBaseType_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00078BF0 File Offset: 0x00076DF0
		[CallerCount(0)]
		public unsafe void SetCanBeSimpleType(bool can)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref can;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_SetCanBeSimpleType_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00078C30 File Offset: 0x00076E30
		public unsafe bool HasSimpleContent
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 390236, RefRangeEnd = 390239, XrefRangeStart = 390231, XrefRangeEnd = 390236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_HasSimpleContent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00078C6C File Offset: 0x00076E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390250, RefRangeEnd = 390251, XrefRangeStart = 390239, XrefRangeEnd = 390250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClassMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00009B0E File Offset: 0x00007D0E
		public ClassMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x00078CA8 File Offset: 0x00076EA8
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x00009B17 File Offset: 0x00007D17
		public unsafe Hashtable _elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x00078CD8 File Offset: 0x00076ED8
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x00009B36 File Offset: 0x00007D36
		public unsafe ArrayList _elementMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__elementMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__elementMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x00078D08 File Offset: 0x00076F08
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x00009B55 File Offset: 0x00007D55
		public unsafe Hashtable _attributeMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__attributeMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__attributeMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00078D38 File Offset: 0x00076F38
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x00009B74 File Offset: 0x00007D74
		public unsafe Il2CppReferenceArray<XmlTypeMapMemberAttribute> _attributeMembersArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__attributeMembersArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTypeMapMemberAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__attributeMembersArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00078D68 File Offset: 0x00076F68
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00009B93 File Offset: 0x00007D93
		public unsafe ArrayList _flatLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__flatLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__flatLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00078D98 File Offset: 0x00076F98
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x00009BB2 File Offset: 0x00007DB2
		public unsafe ArrayList _allMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__allMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__allMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x00078DC8 File Offset: 0x00076FC8
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x00009BD1 File Offset: 0x00007DD1
		public unsafe ArrayList _membersWithDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__membersWithDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__membersWithDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00078DF8 File Offset: 0x00076FF8
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x00009BF0 File Offset: 0x00007DF0
		public unsafe ArrayList _listMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__listMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__listMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00078E28 File Offset: 0x00077028
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x00009C0F File Offset: 0x00007E0F
		public unsafe XmlTypeMapMemberAnyElement _defaultAnyElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__defaultAnyElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberAnyElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__defaultAnyElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x00078E58 File Offset: 0x00077058
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x00009C2E File Offset: 0x00007E2E
		public unsafe XmlTypeMapMemberAnyAttribute _defaultAnyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__defaultAnyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__defaultAnyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x00078E88 File Offset: 0x00077088
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x00009C4D File Offset: 0x00007E4D
		public unsafe XmlTypeMapMemberNamespaces _namespaceDeclarations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__namespaceDeclarations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberNamespaces>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__namespaceDeclarations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x00078EB8 File Offset: 0x000770B8
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x00009C6C File Offset: 0x00007E6C
		public unsafe XmlTypeMapMember _xmlTextCollector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__xmlTextCollector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__xmlTextCollector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00078EE8 File Offset: 0x000770E8
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x00009C8B File Offset: 0x00007E8B
		public unsafe XmlTypeMapMember _returnMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__returnMember);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__returnMember), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00078F18 File Offset: 0x00077118
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x00009CAA File Offset: 0x00007EAA
		public unsafe bool _ignoreMemberNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__ignoreMemberNamespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__ignoreMemberNamespace)) = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00078F40 File Offset: 0x00077140
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x00009CC5 File Offset: 0x00007EC5
		public unsafe bool _canBeSimpleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__canBeSimpleType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__canBeSimpleType)) = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00078F68 File Offset: 0x00077168
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x00009CE0 File Offset: 0x00007EE0
		public Nullable<bool> _isOrderDependentMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__isOrderDependentMap);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__isOrderDependentMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeFieldInfoPtr__elements;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeFieldInfoPtr__elementMembers;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeFieldInfoPtr__attributeMembers;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeFieldInfoPtr__attributeMembersArray;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeFieldInfoPtr__flatLists;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeFieldInfoPtr__allMembers;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr__membersWithDefault;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeFieldInfoPtr__listMembers;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeFieldInfoPtr__defaultAnyElement;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeFieldInfoPtr__defaultAnyAttribute;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr__namespaceDeclarations;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr__xmlTextCollector;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr__returnMember;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeFieldInfoPtr__ignoreMemberNamespace;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr__canBeSimpleType;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr__isOrderDependentMap;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_AddMember_Public_Void_XmlTypeMapMember_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFlatList_Private_Void_XmlTypeMapMemberExpandable_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_XmlTypeMapMemberAttribute_String_String_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_XmlTypeMapElementInfo_String_String_Int32_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_XmlTypeMapElementInfo_String_String_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_BuildKey_Private_String_String_String_Int32_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOrderDependentMap_Public_get_Boolean_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAnyElementMember_Public_get_XmlTypeMapMemberAnyElement_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAnyAttributeMember_Public_get_XmlTypeMapMemberAnyAttribute_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceDeclarations_Public_get_XmlTypeMapMemberNamespaces_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeMembers_Public_get_ICollection_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementMembers_Public_get_ICollection_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_get_AllMembers_Public_get_ArrayList_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_get_FlatLists_Public_get_ArrayList_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_get_ListMembers_Public_get_ArrayList_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTextCollector_Public_get_XmlTypeMapMember_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnMember_Public_get_XmlTypeMapMember_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_get_SimpleContentBaseType_Public_get_XmlQualifiedName_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_SetCanBeSimpleType_Public_Void_Boolean_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSimpleContent_Public_get_Boolean_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
