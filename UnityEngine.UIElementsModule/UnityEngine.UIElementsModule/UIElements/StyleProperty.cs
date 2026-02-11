using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C4 RID: 452
	[Serializable]
	public class StyleProperty : Object
	{
		// Token: 0x06002384 RID: 9092 RVA: 0x000A0424 File Offset: 0x0009E624
		// Note: this type is marked as 'beforefieldinit'.
		static StyleProperty()
		{
			Il2CppClassPointerStore<StyleProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr);
			StyleProperty.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "m_Name");
			StyleProperty.NativeFieldInfoPtr_m_Line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "m_Line");
			StyleProperty.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "m_Values");
			StyleProperty.NativeFieldInfoPtr_isCustomProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "isCustomProperty");
			StyleProperty.NativeFieldInfoPtr_requireVariableResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "requireVariableResolve");
			StyleProperty.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, 100668713);
			StyleProperty.NativeMethodInfoPtr_get_values_Public_get_Il2CppStructArray_1_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, 100668714);
			StyleProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, 100668715);
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x000A04F4 File Offset: 0x0009E6F4
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x0000E979 File Offset: 0x0000CB79
		public unsafe string name
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleProperty.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000A052C File Offset: 0x0009E72C
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x0000E98D File Offset: 0x0000CB8D
		public unsafe Il2CppStructArray<StyleValueHandle> values
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 337628, RefRangeEnd = 337663, XrefRangeStart = 337628, XrefRangeEnd = 337628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleProperty.NativeMethodInfoPtr_get_values_Public_get_Il2CppStructArray_1_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr3) : null;
			}
			set
			{
				this.m_Values = value;
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x000A056C File Offset: 0x0009E76C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0000E8E1 File Offset: 0x0000CAE1
		public StyleProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x000A05A8 File Offset: 0x0009E7A8
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x0000E8EA File Offset: 0x0000CAEA
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x000A05D0 File Offset: 0x0009E7D0
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x0000E909 File Offset: 0x0000CB09
		public unsafe int m_Line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Line)) = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000A05F8 File Offset: 0x0009E7F8
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x0000E924 File Offset: 0x0000CB24
		public unsafe Il2CppStructArray<StyleValueHandle> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x000A0628 File Offset: 0x0009E828
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x0000E943 File Offset: 0x0000CB43
		public unsafe bool isCustomProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_isCustomProperty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_isCustomProperty)) = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x000A0650 File Offset: 0x0009E850
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x0000E95E File Offset: 0x0000CB5E
		public unsafe bool requireVariableResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_requireVariableResolve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_requireVariableResolve)) = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x000A0678 File Offset: 0x0009E878
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x0000E983 File Offset: 0x0000CB83
		public int line
		{
			get
			{
				return this.m_Line;
			}
			set
			{
				this.m_Line = value;
			}
		}

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeFieldInfoPtr_m_Line;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeFieldInfoPtr_isCustomProperty;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeFieldInfoPtr_requireVariableResolve;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_get_values_Public_get_Il2CppStructArray_1_StyleValueHandle_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
