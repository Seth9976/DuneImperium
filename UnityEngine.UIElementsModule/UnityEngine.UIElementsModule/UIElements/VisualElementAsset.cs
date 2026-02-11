using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000214 RID: 532
	[Serializable]
	public class VisualElementAsset : UxmlAsset
	{
		// Token: 0x06002865 RID: 10341 RVA: 0x000B1748 File Offset: 0x000AF948
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementAsset()
		{
			Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr);
			VisualElementAsset.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, "m_Name");
			VisualElementAsset.NativeFieldInfoPtr_m_RuleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, "m_RuleIndex");
			VisualElementAsset.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, "m_Text");
			VisualElementAsset.NativeFieldInfoPtr_m_PickingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, "m_PickingMode");
			VisualElementAsset.NativeFieldInfoPtr_m_Classes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, "m_Classes");
			VisualElementAsset.NativeFieldInfoPtr_m_StylesheetPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, "m_StylesheetPaths");
			VisualElementAsset.NativeFieldInfoPtr_m_Stylesheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, "m_Stylesheets");
			VisualElementAsset.NativeFieldInfoPtr_m_SkipClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, "m_SkipClone");
			VisualElementAsset.NativeMethodInfoPtr_get_ruleIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669359);
			VisualElementAsset.NativeMethodInfoPtr_get_classes_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669360);
			VisualElementAsset.NativeMethodInfoPtr_get_stylesheetPaths_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669361);
			VisualElementAsset.NativeMethodInfoPtr_get_hasStylesheetPaths_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669362);
			VisualElementAsset.NativeMethodInfoPtr_get_stylesheets_Public_get_List_1_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669363);
			VisualElementAsset.NativeMethodInfoPtr_get_hasStylesheets_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669364);
			VisualElementAsset.NativeMethodInfoPtr_get_skipClone_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669365);
			VisualElementAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669366);
			VisualElementAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAsset>.NativeClassPtr, 100669367);
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x000B18CC File Offset: 0x000AFACC
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x000105B1 File Offset: 0x0000E7B1
		public unsafe int ruleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_get_ruleIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_RuleIndex = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x000B1908 File Offset: 0x000AFB08
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x000105BB File Offset: 0x0000E7BB
		public unsafe Il2CppStringArray classes
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 312325, RefRangeEnd = 312368, XrefRangeStart = 312325, XrefRangeEnd = 312368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_get_classes_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			set
			{
				this.m_Classes = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x000B1948 File Offset: 0x000AFB48
		// (set) Token: 0x06002882 RID: 10370 RVA: 0x000105C5 File Offset: 0x0000E7C5
		public unsafe List<string> stylesheetPaths
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 344392, RefRangeEnd = 344393, XrefRangeStart = 344385, XrefRangeEnd = 344392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_get_stylesheetPaths_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			set
			{
				this.m_StylesheetPaths = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x000B1988 File Offset: 0x000AFB88
		public unsafe bool hasStylesheetPaths
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 344393, RefRangeEnd = 344406, XrefRangeStart = 344393, XrefRangeEnd = 344393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_get_hasStylesheetPaths_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x000B19C4 File Offset: 0x000AFBC4
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x000105CF File Offset: 0x0000E7CF
		public unsafe List<StyleSheet> stylesheets
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 344413, RefRangeEnd = 344415, XrefRangeStart = 344406, XrefRangeEnd = 344413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_get_stylesheets_Public_get_List_1_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StyleSheet>>(intPtr3) : null;
			}
			set
			{
				this.m_Stylesheets = value;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x000B1A04 File Offset: 0x000AFC04
		public unsafe bool hasStylesheets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_get_hasStylesheets_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x000B1A40 File Offset: 0x000AFC40
		// (set) Token: 0x06002884 RID: 10372 RVA: 0x000105D9 File Offset: 0x0000E7D9
		public unsafe bool skipClone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_get_skipClone_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_SkipClone = value;
			}
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x000B1A7C File Offset: 0x000AFC7C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x000B1AB0 File Offset: 0x000AFCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344415, XrefRangeEnd = 344443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x000104BC File Offset: 0x0000E6BC
		public VisualElementAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x000B1AE4 File Offset: 0x000AFCE4
		// (set) Token: 0x06002871 RID: 10353 RVA: 0x000104C5 File Offset: 0x0000E6C5
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x000B1B0C File Offset: 0x000AFD0C
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x000104E4 File Offset: 0x0000E6E4
		public unsafe int m_RuleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_RuleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_RuleIndex)) = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x000B1B34 File Offset: 0x000AFD34
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x000104FF File Offset: 0x0000E6FF
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x000B1B5C File Offset: 0x000AFD5C
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x0001051E File Offset: 0x0000E71E
		public unsafe PickingMode m_PickingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_PickingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_PickingMode)) = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x000B1B84 File Offset: 0x000AFD84
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x00010539 File Offset: 0x0000E739
		public unsafe Il2CppStringArray m_Classes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_Classes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_Classes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x000B1BB4 File Offset: 0x000AFDB4
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x00010558 File Offset: 0x0000E758
		public unsafe List<string> m_StylesheetPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_StylesheetPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_StylesheetPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000B1BE4 File Offset: 0x000AFDE4
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x00010577 File Offset: 0x0000E777
		public unsafe List<StyleSheet> m_Stylesheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_Stylesheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSheet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_Stylesheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x000B1C14 File Offset: 0x000AFE14
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x00010596 File Offset: 0x0000E796
		public unsafe bool m_SkipClone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_SkipClone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAsset.NativeFieldInfoPtr_m_SkipClone)) = value;
			}
		}

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeFieldInfoPtr_m_RuleIndex;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeFieldInfoPtr_m_PickingMode;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeFieldInfoPtr_m_Classes;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeFieldInfoPtr_m_StylesheetPaths;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeFieldInfoPtr_m_Stylesheets;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipClone;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr_get_ruleIndex_Public_get_Int32_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_get_classes_Public_get_Il2CppStringArray_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_get_stylesheetPaths_Public_get_List_1_String_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_get_hasStylesheetPaths_Public_get_Boolean_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr_get_stylesheets_Public_get_List_1_StyleSheet_0;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_get_hasStylesheets_Public_get_Boolean_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_get_skipClone_Internal_get_Boolean_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
	}
}
