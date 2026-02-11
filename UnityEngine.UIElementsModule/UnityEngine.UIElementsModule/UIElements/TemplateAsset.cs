using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F4 RID: 500
	[Serializable]
	public class TemplateAsset : VisualElementAsset
	{
		// Token: 0x06002767 RID: 10087 RVA: 0x000ADAF4 File Offset: 0x000ABCF4
		// Note: this type is marked as 'beforefieldinit'.
		static TemplateAsset()
		{
			Il2CppClassPointerStore<TemplateAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TemplateAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemplateAsset>.NativeClassPtr);
			TemplateAsset.NativeFieldInfoPtr_m_TemplateAlias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateAsset>.NativeClassPtr, "m_TemplateAlias");
			TemplateAsset.NativeFieldInfoPtr_m_AttributeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateAsset>.NativeClassPtr, "m_AttributeOverrides");
			TemplateAsset.NativeFieldInfoPtr_m_SlotUsages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateAsset>.NativeClassPtr, "m_SlotUsages");
			TemplateAsset.NativeMethodInfoPtr_get_attributeOverrides_Public_get_List_1_AttributeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateAsset>.NativeClassPtr, 100669227);
			TemplateAsset.NativeMethodInfoPtr_get_slotUsages_Internal_get_List_1_SlotUsageEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateAsset>.NativeClassPtr, 100669228);
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x000ADB88 File Offset: 0x000ABD88
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x0001009D File Offset: 0x0000E29D
		public unsafe List<TemplateAsset.AttributeOverride> attributeOverrides
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 343165, RefRangeEnd = 343166, XrefRangeStart = 343158, XrefRangeEnd = 343165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateAsset.NativeMethodInfoPtr_get_attributeOverrides_Public_get_List_1_AttributeOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TemplateAsset.AttributeOverride>>(intPtr3) : null;
			}
			set
			{
				this.m_AttributeOverrides = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000ADBC8 File Offset: 0x000ABDC8
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x000100A7 File Offset: 0x0000E2A7
		public unsafe List<VisualTreeAsset.SlotUsageEntry> slotUsages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateAsset.NativeMethodInfoPtr_get_slotUsages_Internal_get_List_1_SlotUsageEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<VisualTreeAsset.SlotUsageEntry>>(intPtr3) : null;
			}
			set
			{
				this.m_SlotUsages = value;
			}
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x0001002D File Offset: 0x0000E22D
		public TemplateAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x000ADC08 File Offset: 0x000ABE08
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x00010036 File Offset: 0x0000E236
		public unsafe string m_TemplateAlias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.NativeFieldInfoPtr_m_TemplateAlias);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.NativeFieldInfoPtr_m_TemplateAlias), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000ADC30 File Offset: 0x000ABE30
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x00010055 File Offset: 0x0000E255
		public unsafe List<TemplateAsset.AttributeOverride> m_AttributeOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.NativeFieldInfoPtr_m_AttributeOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TemplateAsset.AttributeOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.NativeFieldInfoPtr_m_AttributeOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000ADC60 File Offset: 0x000ABE60
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x00010074 File Offset: 0x0000E274
		public unsafe List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.NativeFieldInfoPtr_m_SlotUsages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualTreeAsset.SlotUsageEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.NativeFieldInfoPtr_m_SlotUsages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000ADC90 File Offset: 0x000ABE90
		// (set) Token: 0x06002772 RID: 10098 RVA: 0x00010093 File Offset: 0x0000E293
		public string templateAlias
		{
			get
			{
				return this.m_TemplateAlias;
			}
			set
			{
				this.m_TemplateAlias = value;
			}
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000ADCA8 File Offset: 0x000ABEA8
		public void AddSlotUsage(string slotName, int resId)
		{
			bool flag = this.m_SlotUsages == null;
			if (flag)
			{
				this.m_SlotUsages = new List<VisualTreeAsset.SlotUsageEntry>();
			}
			this.m_SlotUsages.Add(new VisualTreeAsset.SlotUsageEntry(slotName, resId));
		}

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeFieldInfoPtr_m_TemplateAlias;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeFieldInfoPtr_m_AttributeOverrides;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeFieldInfoPtr_m_SlotUsages;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_get_attributeOverrides_Public_get_List_1_AttributeOverride_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_get_slotUsages_Internal_get_List_1_SlotUsageEntry_0;

		// Token: 0x020004FF RID: 1279
		[Serializable]
		public sealed class AttributeOverride : ValueType
		{
			// Token: 0x06003F9D RID: 16285 RVA: 0x000FD6DC File Offset: 0x000FB8DC
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeOverride()
			{
				Il2CppClassPointerStore<TemplateAsset.AttributeOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemplateAsset>.NativeClassPtr, "AttributeOverride");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemplateAsset.AttributeOverride>.NativeClassPtr);
				TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_ElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateAsset.AttributeOverride>.NativeClassPtr, "m_ElementName");
				TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_AttributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateAsset.AttributeOverride>.NativeClassPtr, "m_AttributeName");
				TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateAsset.AttributeOverride>.NativeClassPtr, "m_Value");
			}

			// Token: 0x06003F9E RID: 16286 RVA: 0x0001AABF File Offset: 0x00018CBF
			public AttributeOverride(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003F9F RID: 16287 RVA: 0x0001AAC8 File Offset: 0x00018CC8
			public AttributeOverride()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemplateAsset.AttributeOverride>.NativeClassPtr))
			{
			}

			// Token: 0x1700130F RID: 4879
			// (get) Token: 0x06003FA0 RID: 16288 RVA: 0x000FD744 File Offset: 0x000FB944
			// (set) Token: 0x06003FA1 RID: 16289 RVA: 0x0001AADA File Offset: 0x00018CDA
			public unsafe string m_ElementName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_ElementName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_ElementName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001310 RID: 4880
			// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x000FD76C File Offset: 0x000FB96C
			// (set) Token: 0x06003FA3 RID: 16291 RVA: 0x0001AAF9 File Offset: 0x00018CF9
			public unsafe string m_AttributeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_AttributeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_AttributeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001311 RID: 4881
			// (get) Token: 0x06003FA4 RID: 16292 RVA: 0x000FD794 File Offset: 0x000FB994
			// (set) Token: 0x06003FA5 RID: 16293 RVA: 0x0001AB18 File Offset: 0x00018D18
			public unsafe string m_Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_Value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateAsset.AttributeOverride.NativeFieldInfoPtr_m_Value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002CED RID: 11501
			private static readonly IntPtr NativeFieldInfoPtr_m_ElementName;

			// Token: 0x04002CEE RID: 11502
			private static readonly IntPtr NativeFieldInfoPtr_m_AttributeName;

			// Token: 0x04002CEF RID: 11503
			private static readonly IntPtr NativeFieldInfoPtr_m_Value;
		}
	}
}
