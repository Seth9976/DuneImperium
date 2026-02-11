using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F1 RID: 241
	public class XmlTypeMapMember : Object
	{
		// Token: 0x0600162C RID: 5676 RVA: 0x00076000 File Offset: 0x00074200
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMember()
		{
			Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr);
			XmlTypeMapMember.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_name");
			XmlTypeMapMember.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_index");
			XmlTypeMapMember.NativeFieldInfoPtr__globalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_globalIndex");
			XmlTypeMapMember.NativeFieldInfoPtr__specifiedGlobalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_specifiedGlobalIndex");
			XmlTypeMapMember.NativeFieldInfoPtr__typeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_typeData");
			XmlTypeMapMember.NativeFieldInfoPtr__member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_member");
			XmlTypeMapMember.NativeFieldInfoPtr__specifiedMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_specifiedMember");
			XmlTypeMapMember.NativeFieldInfoPtr__shouldSerialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_shouldSerialize");
			XmlTypeMapMember.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_defaultValue");
			XmlTypeMapMember.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_flags");
			XmlTypeMapMember.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666825);
			XmlTypeMapMember.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666826);
			XmlTypeMapMember.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666827);
			XmlTypeMapMember.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666828);
			XmlTypeMapMember.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666829);
			XmlTypeMapMember.NativeMethodInfoPtr_IsReadOnly_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666830);
			XmlTypeMapMember.NativeMethodInfoPtr_GetValue_Public_Static_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666831);
			XmlTypeMapMember.NativeMethodInfoPtr_GetValue_Public_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666832);
			XmlTypeMapMember.NativeMethodInfoPtr_SetValue_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666833);
			XmlTypeMapMember.NativeMethodInfoPtr_SetValue_Public_Static_Void_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666834);
			XmlTypeMapMember.NativeMethodInfoPtr_InitMember_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666835);
			XmlTypeMapMember.NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666836);
			XmlTypeMapMember.NativeMethodInfoPtr_set_TypeData_Public_set_Void_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666837);
			XmlTypeMapMember.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666838);
			XmlTypeMapMember.NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666839);
			XmlTypeMapMember.NativeMethodInfoPtr_get_GlobalIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666840);
			XmlTypeMapMember.NativeMethodInfoPtr_set_GlobalIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666841);
			XmlTypeMapMember.NativeMethodInfoPtr_get_IsOptionalValueType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666842);
			XmlTypeMapMember.NativeMethodInfoPtr_set_IsOptionalValueType_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666843);
			XmlTypeMapMember.NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666844);
			XmlTypeMapMember.NativeMethodInfoPtr_set_IsReturnValue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666845);
			XmlTypeMapMember.NativeMethodInfoPtr_CheckOptionalValueType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666846);
			XmlTypeMapMember.NativeMethodInfoPtr_GetValueSpecified_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666847);
			XmlTypeMapMember.NativeMethodInfoPtr_SetValueSpecified_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666848);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000762D8 File Offset: 0x000744D8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 389682, RefRangeEnd = 389690, XrefRangeStart = 389676, XrefRangeEnd = 389682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMember()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00076314 File Offset: 0x00074514
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x0007634C File Offset: 0x0007454C
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00076390 File Offset: 0x00074590
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x000763D0 File Offset: 0x000745D0
		public unsafe Object DefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00076414 File Offset: 0x00074614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389694, RefRangeEnd = 389696, XrefRangeStart = 389690, XrefRangeEnd = 389694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadOnly(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_IsReadOnly_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00076464 File Offset: 0x00074664
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389705, RefRangeEnd = 389707, XrefRangeStart = 389696, XrefRangeEnd = 389705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetValue(Object ob, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_GetValue_Public_Static_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x000764BC File Offset: 0x000746BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389718, RefRangeEnd = 389721, XrefRangeStart = 389707, XrefRangeEnd = 389718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_GetValue_Public_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0007650C File Offset: 0x0007470C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389728, RefRangeEnd = 389729, XrefRangeStart = 389721, XrefRangeEnd = 389728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object ob, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_SetValue_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00076560 File Offset: 0x00074760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389729, XrefRangeEnd = 389733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetValue(Object ob, string name, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_SetValue_Public_Static_Void_Object_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x000765BC File Offset: 0x000747BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 389757, RefRangeEnd = 389761, XrefRangeStart = 389733, XrefRangeEnd = 389757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMember(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_InitMember_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00076600 File Offset: 0x00074800
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x00076640 File Offset: 0x00074840
		public unsafe TypeData TypeData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_TypeData_Public_set_Void_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00076684 File Offset: 0x00074884
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x000766C0 File Offset: 0x000748C0
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00076700 File Offset: 0x00074900
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x0007673C File Offset: 0x0007493C
		public unsafe int GlobalIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_GlobalIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_GlobalIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x0007677C File Offset: 0x0007497C
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x000767B8 File Offset: 0x000749B8
		public unsafe bool IsOptionalValueType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 389761, RefRangeEnd = 389762, XrefRangeStart = 389761, XrefRangeEnd = 389761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_IsOptionalValueType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_IsOptionalValueType_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x000767F8 File Offset: 0x000749F8
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00076834 File Offset: 0x00074A34
		public unsafe bool IsReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 330657, RefRangeEnd = 330658, XrefRangeStart = 330657, XrefRangeEnd = 330658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_IsReturnValue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00076874 File Offset: 0x00074A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389765, RefRangeEnd = 389766, XrefRangeStart = 389762, XrefRangeEnd = 389765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckOptionalValueType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_CheckOptionalValueType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x000768B8 File Offset: 0x00074AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389784, RefRangeEnd = 389785, XrefRangeStart = 389766, XrefRangeEnd = 389784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetValueSpecified(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_GetValueSpecified_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00076908 File Offset: 0x00074B08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389793, RefRangeEnd = 389794, XrefRangeStart = 389785, XrefRangeEnd = 389793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueSpecified(Object ob, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_SetValueSpecified_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0000964C File Offset: 0x0000784C
		public XmlTypeMapMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00076958 File Offset: 0x00074B58
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x00009655 File Offset: 0x00007855
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00076980 File Offset: 0x00074B80
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00009674 File Offset: 0x00007874
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x000769A8 File Offset: 0x00074BA8
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x0000968F File Offset: 0x0000788F
		public unsafe int _globalIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__globalIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__globalIndex)) = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x000769D0 File Offset: 0x00074BD0
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x000096AA File Offset: 0x000078AA
		public unsafe int _specifiedGlobalIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__specifiedGlobalIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__specifiedGlobalIndex)) = value;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x000769F8 File Offset: 0x00074BF8
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x000096C5 File Offset: 0x000078C5
		public unsafe TypeData _typeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__typeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__typeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00076A28 File Offset: 0x00074C28
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x000096E4 File Offset: 0x000078E4
		public unsafe MemberInfo _member
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__member);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__member), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x00076A58 File Offset: 0x00074C58
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00009703 File Offset: 0x00007903
		public unsafe MemberInfo _specifiedMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__specifiedMember);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__specifiedMember), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x00076A88 File Offset: 0x00074C88
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x00009722 File Offset: 0x00007922
		public unsafe MethodInfo _shouldSerialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__shouldSerialize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__shouldSerialize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x00076AB8 File Offset: 0x00074CB8
		// (set) Token: 0x06001657 RID: 5719 RVA: 0x00009741 File Offset: 0x00007941
		public unsafe Object _defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x00076AE8 File Offset: 0x00074CE8
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x00009760 File Offset: 0x00007960
		public unsafe int _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeFieldInfoPtr__globalIndex;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeFieldInfoPtr__specifiedGlobalIndex;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeFieldInfoPtr__typeData;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeFieldInfoPtr__member;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeFieldInfoPtr__specifiedMember;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeFieldInfoPtr__shouldSerialize;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_IsReadOnly_Public_Boolean_Type_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Static_Object_Object_String_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Object_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Object_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Static_Void_Object_String_Object_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_InitMember_Private_Void_Type_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeData_Public_set_Void_TypeData_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalIndex_Public_get_Int32_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_set_GlobalIndex_Public_set_Void_Int32_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOptionalValueType_Public_get_Boolean_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOptionalValueType_Public_set_Void_Boolean_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReturnValue_Public_set_Void_Boolean_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_CheckOptionalValueType_Public_Void_Type_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_GetValueSpecified_Public_Boolean_Object_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_SetValueSpecified_Public_Void_Object_Boolean_0;
	}
}
