using System;
using System.Runtime.InteropServices;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.data.generation.builders.abilities
{
	// Token: 0x0200000C RID: 12
	public class AbilityScriptBuilder : ScriptBuilder
	{
		// Token: 0x06000078 RID: 120 RVA: 0x0000403C File Offset: 0x0000223C
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityScriptBuilder()
		{
			Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "worm.canis.data.generation.builders.abilities", "AbilityScriptBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr);
			AbilityScriptBuilder.NativeFieldInfoPtr__SetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr, "<SetName>k__BackingField");
			AbilityScriptBuilder.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr, "attributes");
			AbilityScriptBuilder.NativeMethodInfoPtr_get_SetName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr, 100663371);
			AbilityScriptBuilder.NativeMethodInfoPtr_set_SetName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr, 100663372);
			AbilityScriptBuilder.NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_IReadOnlyList_1_AttributeConstructionParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr, 100663373);
			AbilityScriptBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr, 100663374);
			AbilityScriptBuilder.NativeMethodInfoPtr_AddAttribute_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr, 100663375);
			AbilityScriptBuilder.NativeMethodInfoPtr_AddAttributes_Public_Virtual_Final_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr, 100663376);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000410C File Offset: 0x0000230C
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00004144 File Offset: 0x00002344
		public unsafe string SetName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityScriptBuilder.NativeMethodInfoPtr_get_SetName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityScriptBuilder.NativeMethodInfoPtr_set_SetName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004188 File Offset: 0x00002388
		public unsafe virtual IReadOnlyList<AttributeConstructionParameters> Attributes
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityScriptBuilder.NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_IReadOnlyList_1_AttributeConstructionParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AttributeConstructionParameters>>(intPtr3) : null;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000041C8 File Offset: 0x000023C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246554, XrefRangeEnd = 1246562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityScriptBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityScriptBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityScriptBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004204 File Offset: 0x00002404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246562, XrefRangeEnd = 1246579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityScriptBuilder.NativeMethodInfoPtr_AddAttribute_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004258 File Offset: 0x00002458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246579, XrefRangeEnd = 1246589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityScriptBuilder.NativeMethodInfoPtr_AddAttributes_Public_Virtual_Final_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002332 File Offset: 0x00000532
		public virtual void AddAttributes(AttributeConstructionParameters attr1, params AttributeConstructionParameters[] attrs)
		{
			this.AddAttributes(attr1, new Il2CppReferenceArray<AttributeConstructionParameters>(attrs));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002341 File Offset: 0x00000541
		public AbilityScriptBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000042BC File Offset: 0x000024BC
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000234A File Offset: 0x0000054A
		public unsafe string _SetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityScriptBuilder.NativeFieldInfoPtr__SetName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityScriptBuilder.NativeFieldInfoPtr__SetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000042E4 File Offset: 0x000024E4
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002369 File Offset: 0x00000569
		public unsafe List<AttributeConstructionParameters> attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityScriptBuilder.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AttributeConstructionParameters>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityScriptBuilder.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr__SetName_k__BackingField;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_SetName_Public_get_String_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_set_SetName_Public_set_Void_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_IReadOnlyList_1_AttributeConstructionParameters_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributes_Public_Virtual_Final_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0;
	}
}
