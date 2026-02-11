using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E9 RID: 489
	public sealed class UQueryBuilder<T> : ValueType where T : VisualElement
	{
		// Token: 0x060026B3 RID: 9907 RVA: 0x000ABD38 File Offset: 0x000A9F38
		// Note: this type is marked as 'beforefieldinit'.
		static UQueryBuilder()
		{
			Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UQueryBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr);
			UQueryBuilder<T>.NativeFieldInfoPtr_m_StyleSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, "m_StyleSelectors");
			UQueryBuilder<T>.NativeFieldInfoPtr_m_Parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, "m_Parts");
			UQueryBuilder<T>.NativeFieldInfoPtr_m_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, "m_Element");
			UQueryBuilder<T>.NativeFieldInfoPtr_m_Matchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, "m_Matchers");
			UQueryBuilder<T>.NativeFieldInfoPtr_m_Relationship = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, "m_Relationship");
			UQueryBuilder<T>.NativeFieldInfoPtr_pseudoStatesMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, "pseudoStatesMask");
			UQueryBuilder<T>.NativeFieldInfoPtr_negatedPseudoStatesMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, "negatedPseudoStatesMask");
			UQueryBuilder<T>.NativeMethodInfoPtr_get_styleSelectors_Private_get_List_1_StyleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669187);
			UQueryBuilder<T>.NativeMethodInfoPtr_get_parts_Private_get_List_1_StyleSelectorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669188);
			UQueryBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669189);
			UQueryBuilder<T>.NativeMethodInfoPtr_Class_Public_UQueryBuilder_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669190);
			UQueryBuilder<T>.NativeMethodInfoPtr_Name_Public_UQueryBuilder_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669191);
			UQueryBuilder<T>.NativeMethodInfoPtr_SingleBaseType_Internal_UQueryBuilder_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669192);
			UQueryBuilder<T>.NativeMethodInfoPtr_AddClass_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669193);
			UQueryBuilder<T>.NativeMethodInfoPtr_AddName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669194);
			UQueryBuilder<T>.NativeMethodInfoPtr_AddPseudoStatesRuleIfNecessasy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669195);
			UQueryBuilder<T>.NativeMethodInfoPtr_FinishSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669196);
			UQueryBuilder<T>.NativeMethodInfoPtr_CurrentSelectorEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669197);
			UQueryBuilder<T>.NativeMethodInfoPtr_FinishCurrentSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669198);
			UQueryBuilder<T>.NativeMethodInfoPtr_Build_Public_UQueryState_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669199);
			UQueryBuilder<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UQueryBuilder_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669200);
			UQueryBuilder<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669201);
			UQueryBuilder<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr, 100669202);
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x000ABF70 File Offset: 0x000AA170
		public unsafe List<StyleSelector> styleSelectors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342659, XrefRangeEnd = 342666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_get_styleSelectors_Private_get_List_1_StyleSelector_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StyleSelector>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
		public unsafe List<StyleSelectorPart> parts
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342666, XrefRangeEnd = 342673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_get_parts_Private_get_List_1_StyleSelectorPart_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StyleSelectorPart>>(intPtr3) : null;
			}
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000ABFF8 File Offset: 0x000AA1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342673, XrefRangeEnd = 342683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UQueryBuilder(VisualElement visualElement)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visualElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x000AC048 File Offset: 0x000AA248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342683, XrefRangeEnd = 342690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UQueryBuilder<T> Class(string classname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(classname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_Class_Public_UQueryBuilder_1_T_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new UQueryBuilder<T>(intPtr);
			}
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x000AC098 File Offset: 0x000AA298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342690, XrefRangeEnd = 342697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UQueryBuilder<T> Name(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_Name_Public_UQueryBuilder_1_T_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new UQueryBuilder<T>(intPtr);
			}
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000AC0E8 File Offset: 0x000AA2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342697, XrefRangeEnd = 342710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UQueryBuilder<T> SingleBaseType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_SingleBaseType_Internal_UQueryBuilder_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new UQueryBuilder<T>(intPtr);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000AC124 File Offset: 0x000AA324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342710, XrefRangeEnd = 342716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClass(string c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_AddClass_Private_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x000AC16C File Offset: 0x000AA36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342716, XrefRangeEnd = 342722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddName(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_AddName_Private_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x000AC1B4 File Offset: 0x000AA3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342722, XrefRangeEnd = 342728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPseudoStatesRuleIfNecessasy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_AddPseudoStatesRuleIfNecessasy_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000AC1EC File Offset: 0x000AA3EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342751, RefRangeEnd = 342753, XrefRangeStart = 342728, XrefRangeEnd = 342751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_FinishSelector_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000AC224 File Offset: 0x000AA424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342753, XrefRangeEnd = 342756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CurrentSelectorEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_CurrentSelectorEmpty_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000AC268 File Offset: 0x000AA468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342778, RefRangeEnd = 342779, XrefRangeStart = 342756, XrefRangeEnd = 342778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishCurrentSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_FinishCurrentSelector_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000AC2A0 File Offset: 0x000AA4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342779, XrefRangeEnd = 342795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UQueryState<T> Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_Build_Public_UQueryState_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new UQueryState<T>(intPtr);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000AC2DC File Offset: 0x000AA4DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342817, RefRangeEnd = 342818, XrefRangeStart = 342795, XrefRangeEnd = 342817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(UQueryBuilder<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UQueryBuilder_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x000AC334 File Offset: 0x000AA534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342818, XrefRangeEnd = 342826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x000AC388 File Offset: 0x000AA588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342826, XrefRangeEnd = 342849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryBuilder<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0000FB45 File Offset: 0x0000DD45
		public UQueryBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0000FB4E File Offset: 0x0000DD4E
		public UQueryBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQueryBuilder<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000AC3CC File Offset: 0x000AA5CC
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x0000FB60 File Offset: 0x0000DD60
		public unsafe List<StyleSelector> m_StyleSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_StyleSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_StyleSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x000AC3FC File Offset: 0x000AA5FC
		// (set) Token: 0x060026C9 RID: 9929 RVA: 0x0000FB7F File Offset: 0x0000DD7F
		public unsafe List<StyleSelectorPart> m_Parts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_Parts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSelectorPart>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_Parts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x000AC42C File Offset: 0x000AA62C
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x0000FB9E File Offset: 0x0000DD9E
		public unsafe VisualElement m_Element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_Element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_Element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x000AC45C File Offset: 0x000AA65C
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x0000FBBD File Offset: 0x0000DDBD
		public unsafe List<RuleMatcher> m_Matchers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_Matchers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuleMatcher>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_Matchers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x000AC48C File Offset: 0x000AA68C
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x0000FBDC File Offset: 0x0000DDDC
		public unsafe StyleSelectorRelationship m_Relationship
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_Relationship);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_m_Relationship)) = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x000AC4B4 File Offset: 0x000AA6B4
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x0000FBF7 File Offset: 0x0000DDF7
		public unsafe int pseudoStatesMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_pseudoStatesMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_pseudoStatesMask)) = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x000AC4DC File Offset: 0x000AA6DC
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x0000FC12 File Offset: 0x0000DE12
		public unsafe int negatedPseudoStatesMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_negatedPseudoStatesMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryBuilder<T>.NativeFieldInfoPtr_negatedPseudoStatesMask)) = value;
			}
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x000AC504 File Offset: 0x000AA704
		public UQueryBuilder<T2> Descendents<T2>([Optional] string name, Il2CppStringArray classNames) where T2 : VisualElement
		{
			this.FinishCurrentSelector();
			this.AddType<T2>();
			this.AddName(name);
			this.AddClasses(classNames);
			return this.AddRelationship<T2>(StyleSelectorRelationship.Descendent);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0000FC2D File Offset: 0x0000DE2D
		public UQueryBuilder<T2> Descendents<T2>([Optional] string name, params string[] classNames) where T2 : VisualElement
		{
			return this.Descendents(name, new Il2CppStringArray(classNames));
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x000AC53C File Offset: 0x000AA73C
		public UQueryBuilder<T2> Descendents<T2>([Optional] string name, [Optional] string classname) where T2 : VisualElement
		{
			this.FinishCurrentSelector();
			this.AddType<T2>();
			this.AddName(name);
			this.AddClass(classname);
			return this.AddRelationship<T2>(StyleSelectorRelationship.Descendent);
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x000AC574 File Offset: 0x000AA774
		public UQueryBuilder<T2> Children<T2>([Optional] string name, Il2CppStringArray classes) where T2 : VisualElement
		{
			this.FinishCurrentSelector();
			this.AddType<T2>();
			this.AddName(name);
			this.AddClasses(classes);
			return this.AddRelationship<T2>(StyleSelectorRelationship.Child);
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		public UQueryBuilder<T2> Children<T2>([Optional] string name, params string[] classes) where T2 : VisualElement
		{
			return this.Children(name, new Il2CppStringArray(classes));
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x000AC5AC File Offset: 0x000AA7AC
		public UQueryBuilder<T2> Children<T2>([Optional] string name, [Optional] string className) where T2 : VisualElement
		{
			this.FinishCurrentSelector();
			this.AddType<T2>();
			this.AddName(name);
			this.AddClass(className);
			return this.AddRelationship<T2>(StyleSelectorRelationship.Child);
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x000AC5E4 File Offset: 0x000AA7E4
		public UQueryBuilder<T2> OfType<T2>([Optional] string name, Il2CppStringArray classes) where T2 : VisualElement
		{
			this.AddType<T2>();
			this.AddName(name);
			this.AddClasses(classes);
			return this.AddRelationship<T2>(StyleSelectorRelationship.None);
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x0000FC4B File Offset: 0x0000DE4B
		public UQueryBuilder<T2> OfType<T2>([Optional] string name, params string[] classes) where T2 : VisualElement
		{
			return this.OfType(name, new Il2CppStringArray(classes));
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000AC614 File Offset: 0x000AA814
		public UQueryBuilder<T2> OfType<T2>([Optional] string name, [Optional] string className) where T2 : VisualElement
		{
			this.AddType<T2>();
			this.AddName(name);
			this.AddClass(className);
			return this.AddRelationship<T2>(StyleSelectorRelationship.None);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0000FC5A File Offset: 0x0000DE5A
		public UQueryBuilder<T> Where(Func<T, bool> selectorPredicate)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0000FC67 File Offset: 0x0000DE67
		public void AddClasses(Il2CppStringArray classes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0000FC74 File Offset: 0x0000DE74
		public void AddClasses(params string[] classes)
		{
			this.AddClasses(new Il2CppStringArray(classes));
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000AC644 File Offset: 0x000AA844
		public void AddType<T2>() where T2 : VisualElement
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T2>()) != Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>());
			if (flag)
			{
				this.parts.Add(StyleSelectorPart.CreatePredicate(UQuery.IsOfType.s_Instance));
			}
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000AC688 File Offset: 0x000AA888
		public unsafe UQueryBuilder<T> AddPseudoState(PseudoStates s)
		{
			this.pseudoStatesMask |= (int)s;
			return *this;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000AC6B0 File Offset: 0x000AA8B0
		public unsafe UQueryBuilder<T> AddNegativePseudoState(PseudoStates s)
		{
			this.negatedPseudoStatesMask |= (int)s;
			return *this;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x000AC6D8 File Offset: 0x000AA8D8
		public UQueryBuilder<T> Active()
		{
			return this.AddPseudoState(PseudoStates.Active);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000AC6F4 File Offset: 0x000AA8F4
		public UQueryBuilder<T> NotActive()
		{
			return this.AddNegativePseudoState(PseudoStates.Active);
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0000FC82 File Offset: 0x0000DE82
		public UQueryBuilder<T> Visible()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0000FC8F File Offset: 0x0000DE8F
		public UQueryBuilder<T> NotVisible()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x000AC710 File Offset: 0x000AA910
		public UQueryBuilder<T> Hovered()
		{
			return this.AddPseudoState(PseudoStates.Hover);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x000AC72C File Offset: 0x000AA92C
		public UQueryBuilder<T> NotHovered()
		{
			return this.AddNegativePseudoState(PseudoStates.Hover);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000AC748 File Offset: 0x000AA948
		public UQueryBuilder<T> Checked()
		{
			return this.AddPseudoState(PseudoStates.Checked);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000AC764 File Offset: 0x000AA964
		public UQueryBuilder<T> NotChecked()
		{
			return this.AddNegativePseudoState(PseudoStates.Checked);
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000AC780 File Offset: 0x000AA980
		public UQueryBuilder<T> Selected()
		{
			return this.AddPseudoState(PseudoStates.Checked);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000AC79C File Offset: 0x000AA99C
		public UQueryBuilder<T> NotSelected()
		{
			return this.AddNegativePseudoState(PseudoStates.Checked);
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000AC7B8 File Offset: 0x000AA9B8
		public UQueryBuilder<T> Enabled()
		{
			return this.AddNegativePseudoState(PseudoStates.Disabled);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000AC7D4 File Offset: 0x000AA9D4
		public UQueryBuilder<T> NotEnabled()
		{
			return this.AddPseudoState(PseudoStates.Disabled);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000AC7F0 File Offset: 0x000AA9F0
		public UQueryBuilder<T> Focused()
		{
			return this.AddPseudoState(PseudoStates.Focus);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000AC80C File Offset: 0x000AAA0C
		public UQueryBuilder<T> NotFocused()
		{
			return this.AddNegativePseudoState(PseudoStates.Focus);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000AC828 File Offset: 0x000AAA28
		public UQueryBuilder<T2> AddRelationship<T2>(StyleSelectorRelationship relationship) where T2 : VisualElement
		{
			UQueryBuilder<T2> uqueryBuilder;
			uqueryBuilder..ctor(this.m_Element);
			uqueryBuilder.m_Matchers = this.m_Matchers;
			uqueryBuilder.m_Parts = this.m_Parts;
			uqueryBuilder.m_StyleSelectors = this.m_StyleSelectors;
			uqueryBuilder.m_Relationship = ((relationship == StyleSelectorRelationship.None) ? this.m_Relationship : relationship);
			uqueryBuilder.pseudoStatesMask = this.pseudoStatesMask;
			uqueryBuilder.negatedPseudoStatesMask = this.negatedPseudoStatesMask;
			return uqueryBuilder;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000AC89C File Offset: 0x000AAA9C
		public static implicit operator T(UQueryBuilder<T> s)
		{
			return s.First();
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
		public static bool operator ==(UQueryBuilder<T> builder1, UQueryBuilder<T> builder2)
		{
			return builder1.Equals(builder2);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000AC8D4 File Offset: 0x000AAAD4
		public static bool operator !=(UQueryBuilder<T> builder1, UQueryBuilder<T> builder2)
		{
			return !(builder1 == builder2);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x000AC8F0 File Offset: 0x000AAAF0
		public T First()
		{
			UQueryState<T> uqueryState = this.Build();
			return uqueryState.First();
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000AC910 File Offset: 0x000AAB10
		public T Last()
		{
			UQueryState<T> uqueryState = this.Build();
			return uqueryState.Last();
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000AC930 File Offset: 0x000AAB30
		public List<T> ToList()
		{
			UQueryState<T> uqueryState = this.Build();
			return uqueryState.ToList();
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x000AC950 File Offset: 0x000AAB50
		public void ToList(List<T> results)
		{
			UQueryState<T> uqueryState = this.Build();
			uqueryState.ToList(results);
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x000AC970 File Offset: 0x000AAB70
		public T AtIndex(int index)
		{
			UQueryState<T> uqueryState = this.Build();
			return uqueryState.AtIndex(index);
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x000AC994 File Offset: 0x000AAB94
		public void ForEach<T2>(List<T2> result, Func<T, T2> funcCall)
		{
			UQueryState<T> uqueryState = this.Build();
			uqueryState.ForEach<T2>(result, funcCall);
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x000AC9B4 File Offset: 0x000AABB4
		public List<T2> ForEach<T2>(Func<T, T2> funcCall)
		{
			UQueryState<T> uqueryState = this.Build();
			return uqueryState.ForEach<T2>(funcCall);
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x000AC9D8 File Offset: 0x000AABD8
		public void ForEach(Action<T> funcCall)
		{
			UQueryState<T> uqueryState = this.Build();
			uqueryState.ForEach(funcCall);
		}

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSelectors;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeFieldInfoPtr_m_Parts;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeFieldInfoPtr_m_Element;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeFieldInfoPtr_m_Matchers;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeFieldInfoPtr_m_Relationship;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeFieldInfoPtr_pseudoStatesMask;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeFieldInfoPtr_negatedPseudoStatesMask;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSelectors_Private_get_List_1_StyleSelector_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_get_parts_Private_get_List_1_StyleSelectorPart_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_Class_Public_UQueryBuilder_1_T_String_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_Name_Public_UQueryBuilder_1_T_String_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_SingleBaseType_Internal_UQueryBuilder_1_T_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_AddClass_Private_Void_String_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Private_Void_String_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_AddPseudoStatesRuleIfNecessasy_Private_Void_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_FinishSelector_Private_Void_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr_CurrentSelectorEmpty_Private_Boolean_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_FinishCurrentSelector_Private_Void_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_UQueryState_1_T_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UQueryBuilder_1_T_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
