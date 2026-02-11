using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000070 RID: 112
	[Serializable]
	public class TemplateFormatter : FormatterBase
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x0001D0EC File Offset: 0x0001B2EC
		// Note: this type is marked as 'beforefieldinit'.
		static TemplateFormatter()
		{
			Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "TemplateFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr);
			TemplateFormatter.NativeFieldInfoPtr_m_Templates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, "m_Templates");
			TemplateFormatter.NativeFieldInfoPtr_m_TemplatesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, "m_TemplatesDict");
			TemplateFormatter.NativeFieldInfoPtr_m_Formatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, "m_Formatter");
			TemplateFormatter.NativeMethodInfoPtr_get_Templates_Private_get_IDictionary_2_String_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664278);
			TemplateFormatter.NativeMethodInfoPtr_get_Formatter_Public_get_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664279);
			TemplateFormatter.NativeMethodInfoPtr_set_Formatter_Public_set_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664280);
			TemplateFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664281);
			TemplateFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664282);
			TemplateFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664283);
			TemplateFormatter.NativeMethodInfoPtr_Register_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664284);
			TemplateFormatter.NativeMethodInfoPtr_Remove_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664285);
			TemplateFormatter.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664286);
			TemplateFormatter.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, 100664287);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0001D220 File Offset: 0x0001B420
		public unsafe IDictionary<string, Format> Templates
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1072863, RefRangeEnd = 1072867, XrefRangeStart = 1072815, XrefRangeEnd = 1072863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.NativeMethodInfoPtr_get_Templates_Private_get_IDictionary_2_String_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Format>>(intPtr3) : null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001D260 File Offset: 0x0001B460
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		public unsafe SmartFormatter Formatter
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1072868, RefRangeEnd = 1072870, XrefRangeStart = 1072867, XrefRangeEnd = 1072868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.NativeMethodInfoPtr_get_Formatter_Public_get_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.NativeMethodInfoPtr_set_Formatter_Public_set_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072870, XrefRangeEnd = 1072879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemplateFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001D320 File Offset: 0x0001B520
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072879, XrefRangeEnd = 1072888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TemplateFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0001D36C File Offset: 0x0001B56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072888, XrefRangeEnd = 1072909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TemplateFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072909, XrefRangeEnd = 1072917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(string templateName, string template)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(templateName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(template);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.NativeMethodInfoPtr_Register_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0001D418 File Offset: 0x0001B618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072917, XrefRangeEnd = 1072923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(string templateName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(templateName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.NativeMethodInfoPtr_Remove_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001D468 File Offset: 0x0001B668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072923, XrefRangeEnd = 1072925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TemplateFormatter.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072925, XrefRangeEnd = 1072930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000401E File Offset: 0x0000221E
		public TemplateFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00004027 File Offset: 0x00002227
		public unsafe List<TemplateFormatter.Template> m_Templates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.NativeFieldInfoPtr_m_Templates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TemplateFormatter.Template>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.NativeFieldInfoPtr_m_Templates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001D508 File Offset: 0x0001B708
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x00004046 File Offset: 0x00002246
		public unsafe IDictionary<string, Format> m_TemplatesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.NativeFieldInfoPtr_m_TemplatesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Format>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.NativeFieldInfoPtr_m_TemplatesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001D538 File Offset: 0x0001B738
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00004065 File Offset: 0x00002265
		public unsafe SmartFormatter m_Formatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.NativeFieldInfoPtr_m_Formatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.NativeFieldInfoPtr_m_Formatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_m_Templates;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_m_TemplatesDict;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_m_Formatter;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_get_Templates_Private_get_IDictionary_2_String_Format_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_get_Formatter_Public_get_SmartFormatter_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatter_Public_set_Void_SmartFormatter_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_String_String_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_String_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0200014B RID: 331
		[Serializable]
		public class Template : Object
		{
			// Token: 0x06000EA2 RID: 3746 RVA: 0x0003F3BC File Offset: 0x0003D5BC
			// Note: this type is marked as 'beforefieldinit'.
			static Template()
			{
				Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemplateFormatter>.NativeClassPtr, "Template");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr);
				TemplateFormatter.Template.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr, "name");
				TemplateFormatter.Template.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr, "text");
				TemplateFormatter.Template.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr, "<Format>k__BackingField");
				TemplateFormatter.Template.NativeMethodInfoPtr_get_Format_Public_get_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr, 100664288);
				TemplateFormatter.Template.NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr, 100664289);
				TemplateFormatter.Template.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr, 100664290);
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0003F460 File Offset: 0x0003D660
			// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x0003F4A0 File Offset: 0x0003D6A0
			public unsafe Format Format
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.Template.NativeMethodInfoPtr_get_Format_Public_get_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.Template.NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000EA5 RID: 3749 RVA: 0x0003F4E4 File Offset: 0x0003D6E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Template()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemplateFormatter.Template>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateFormatter.Template.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EA6 RID: 3750 RVA: 0x00008252 File Offset: 0x00006452
			public Template(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0003F520 File Offset: 0x0003D720
			// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x0000825B File Offset: 0x0000645B
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.Template.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.Template.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0003F548 File Offset: 0x0003D748
			// (set) Token: 0x06000EAA RID: 3754 RVA: 0x0000827A File Offset: 0x0000647A
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.Template.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.Template.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0003F570 File Offset: 0x0003D770
			// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00008299 File Offset: 0x00006499
			public unsafe Format _Format_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.Template.NativeFieldInfoPtr__Format_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Format>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateFormatter.Template.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A0F RID: 2575
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000A10 RID: 2576
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04000A11 RID: 2577
			private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

			// Token: 0x04000A12 RID: 2578
			private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_get_Format_0;

			// Token: 0x04000A13 RID: 2579
			private static readonly IntPtr NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0;

			// Token: 0x04000A14 RID: 2580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
