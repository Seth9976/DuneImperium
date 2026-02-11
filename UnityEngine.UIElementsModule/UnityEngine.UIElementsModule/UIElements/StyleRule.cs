using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C5 RID: 453
	[Serializable]
	public class StyleRule : Object
	{
		// Token: 0x06002397 RID: 9111 RVA: 0x000A0690 File Offset: 0x0009E890
		// Note: this type is marked as 'beforefieldinit'.
		static StyleRule()
		{
			Il2CppClassPointerStore<StyleRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleRule>.NativeClassPtr);
			StyleRule.NativeFieldInfoPtr_m_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, "m_Properties");
			StyleRule.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, "line");
			StyleRule.NativeFieldInfoPtr_customPropertiesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, "customPropertiesCount");
			StyleRule.NativeMethodInfoPtr_get_properties_Public_get_Il2CppReferenceArray_1_StyleProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, 100668716);
			StyleRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, 100668717);
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x000A0724 File Offset: 0x0009E924
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x0000E9F5 File Offset: 0x0000CBF5
		public unsafe Il2CppReferenceArray<StyleProperty> properties
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRule.NativeMethodInfoPtr_get_properties_Public_get_Il2CppReferenceArray_1_StyleProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleProperty>>(intPtr3) : null;
			}
			set
			{
				this.m_Properties = value;
			}
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x000A0764 File Offset: 0x0009E964
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0000E997 File Offset: 0x0000CB97
		public StyleRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x000A07A0 File Offset: 0x0009E9A0
		// (set) Token: 0x0600239C RID: 9116 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		public unsafe Il2CppReferenceArray<StyleProperty> m_Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_m_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_m_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x000A07D0 File Offset: 0x0009E9D0
		// (set) Token: 0x0600239E RID: 9118 RVA: 0x0000E9BF File Offset: 0x0000CBBF
		public unsafe int line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_line)) = value;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x000A07F8 File Offset: 0x0009E9F8
		// (set) Token: 0x060023A0 RID: 9120 RVA: 0x0000E9DA File Offset: 0x0000CBDA
		public unsafe int customPropertiesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_customPropertiesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_customPropertiesCount)) = value;
			}
		}

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeFieldInfoPtr_m_Properties;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeFieldInfoPtr_customPropertiesCount;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_get_properties_Public_get_Il2CppReferenceArray_1_StyleProperty_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
