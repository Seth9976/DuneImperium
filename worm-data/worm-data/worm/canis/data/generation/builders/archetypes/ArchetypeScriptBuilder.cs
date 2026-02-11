using System;
using System.Runtime.InteropServices;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.data.generation.builders.archetypes
{
	// Token: 0x0200000B RID: 11
	public class ArchetypeScriptBuilder : ScriptBuilder
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00003BA4 File Offset: 0x00001DA4
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeScriptBuilder()
		{
			Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "worm.canis.data.generation.builders.archetypes", "ArchetypeScriptBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr);
			ArchetypeScriptBuilder.NativeFieldInfoPtr__NameSpace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, "<NameSpace>k__BackingField");
			ArchetypeScriptBuilder.NativeFieldInfoPtr__UseDirective_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, "<UseDirective>k__BackingField");
			ArchetypeScriptBuilder.NativeFieldInfoPtr__DirectiveName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, "<DirectiveName>k__BackingField");
			ArchetypeScriptBuilder.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, "attributes");
			ArchetypeScriptBuilder.NativeMethodInfoPtr_get_NameSpace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663361);
			ArchetypeScriptBuilder.NativeMethodInfoPtr_set_NameSpace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663362);
			ArchetypeScriptBuilder.NativeMethodInfoPtr_get_UseDirective_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663363);
			ArchetypeScriptBuilder.NativeMethodInfoPtr_set_UseDirective_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663364);
			ArchetypeScriptBuilder.NativeMethodInfoPtr_get_DirectiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663365);
			ArchetypeScriptBuilder.NativeMethodInfoPtr_set_DirectiveName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663366);
			ArchetypeScriptBuilder.NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_IReadOnlyList_1_AttributeConstructionParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663367);
			ArchetypeScriptBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663368);
			ArchetypeScriptBuilder.NativeMethodInfoPtr_AddAttribute_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663369);
			ArchetypeScriptBuilder.NativeMethodInfoPtr_AddAttributes_Public_Virtual_Final_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr, 100663370);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003CEC File Offset: 0x00001EEC
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00003D24 File Offset: 0x00001F24
		public unsafe string NameSpace
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_get_NameSpace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_set_NameSpace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003D68 File Offset: 0x00001F68
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public unsafe bool UseDirective
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_get_UseDirective_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_set_UseDirective_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00003DE4 File Offset: 0x00001FE4
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00003E1C File Offset: 0x0000201C
		public unsafe string DirectiveName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_get_DirectiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_set_DirectiveName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003E60 File Offset: 0x00002060
		public unsafe virtual IReadOnlyList<AttributeConstructionParameters> Attributes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_IReadOnlyList_1_AttributeConstructionParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AttributeConstructionParameters>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003EA0 File Offset: 0x000020A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246519, XrefRangeEnd = 1246527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeScriptBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeScriptBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003EDC File Offset: 0x000020DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246527, XrefRangeEnd = 1246544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddAttribute(string attributeName, string attributeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_AddAttribute_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003F30 File Offset: 0x00002130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246544, XrefRangeEnd = 1246554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddAttributes(AttributeConstructionParameters attr1, [Optional] Il2CppReferenceArray<AttributeConstructionParameters> attrs)
		{
			if (attrs == null)
			{
				attrs = new Il2CppReferenceArray<AttributeConstructionParameters>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeScriptBuilder.NativeMethodInfoPtr_AddAttributes_Public_Virtual_Final_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000022A2 File Offset: 0x000004A2
		public virtual void AddAttributes(AttributeConstructionParameters attr1, params AttributeConstructionParameters[] attrs)
		{
			this.AddAttributes(attr1, new Il2CppReferenceArray<AttributeConstructionParameters>(attrs));
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000022B1 File Offset: 0x000004B1
		public ArchetypeScriptBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003F94 File Offset: 0x00002194
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000022BA File Offset: 0x000004BA
		public unsafe string _NameSpace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeScriptBuilder.NativeFieldInfoPtr__NameSpace_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeScriptBuilder.NativeFieldInfoPtr__NameSpace_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003FBC File Offset: 0x000021BC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022D9 File Offset: 0x000004D9
		public unsafe bool _UseDirective_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeScriptBuilder.NativeFieldInfoPtr__UseDirective_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeScriptBuilder.NativeFieldInfoPtr__UseDirective_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003FE4 File Offset: 0x000021E4
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000022F4 File Offset: 0x000004F4
		public unsafe string _DirectiveName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeScriptBuilder.NativeFieldInfoPtr__DirectiveName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeScriptBuilder.NativeFieldInfoPtr__DirectiveName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000400C File Offset: 0x0000220C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002313 File Offset: 0x00000513
		public unsafe List<AttributeConstructionParameters> attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeScriptBuilder.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AttributeConstructionParameters>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeScriptBuilder.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr__NameSpace_k__BackingField;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr__UseDirective_k__BackingField;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr__DirectiveName_k__BackingField;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_get_NameSpace_Public_get_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_set_NameSpace_Public_set_Void_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDirective_Public_get_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_set_UseDirective_Public_set_Void_Boolean_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectiveName_Public_get_String_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_set_DirectiveName_Public_set_Void_String_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_IReadOnlyList_1_AttributeConstructionParameters_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributes_Public_Virtual_Final_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0;
	}
}
