using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x0200006A RID: 106
	[Serializable]
	public class ListFormatter : FormatterBase
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x0001B898 File Offset: 0x00019A98
		// Note: this type is marked as 'beforefieldinit'.
		static ListFormatter()
		{
			Il2CppClassPointerStore<ListFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "ListFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr);
			ListFormatter.NativeFieldInfoPtr_m_SmartSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, "m_SmartSettings");
			ListFormatter.NativeFieldInfoPtr__CollectionIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, "<CollectionIndex>k__BackingField");
			ListFormatter.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, 100664198);
			ListFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, 100664199);
			ListFormatter.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, 100664200);
			ListFormatter.NativeMethodInfoPtr_get_CollectionIndex_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, 100664201);
			ListFormatter.NativeMethodInfoPtr_set_CollectionIndex_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, 100664202);
			ListFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, 100664203);
			ListFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr, 100664204);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0001B97C File Offset: 0x00019B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071930, RefRangeEnd = 1071931, XrefRangeStart = 1071923, XrefRangeEnd = 1071930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListFormatter(SmartFormatter formatter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListFormatter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListFormatter.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0001B9C8 File Offset: 0x00019BC8
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071931, XrefRangeEnd = 1071943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0001BA14 File Offset: 0x00019C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071943, XrefRangeEnd = 1071966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListFormatter.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0001BA64 File Offset: 0x00019C64
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x0001BA94 File Offset: 0x00019C94
		public unsafe static int CollectionIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071966, XrefRangeEnd = 1071970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListFormatter.NativeMethodInfoPtr_get_CollectionIndex_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071970, XrefRangeEnd = 1071974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListFormatter.NativeMethodInfoPtr_set_CollectionIndex_Private_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071974, XrefRangeEnd = 1072109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0001BB20 File Offset: 0x00019D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072109, XrefRangeEnd = 1072145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00003E7A File Offset: 0x0000207A
		public ListFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0001BB64 File Offset: 0x00019D64
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00003E83 File Offset: 0x00002083
		public unsafe SmartSettings m_SmartSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListFormatter.NativeFieldInfoPtr_m_SmartSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListFormatter.NativeFieldInfoPtr_m_SmartSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0001BB94 File Offset: 0x00019D94
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00003EA2 File Offset: 0x000020A2
		public unsafe static int _CollectionIndex_k__BackingField
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ListFormatter.NativeFieldInfoPtr__CollectionIndex_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListFormatter.NativeFieldInfoPtr__CollectionIndex_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_m_SmartSettings;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr__CollectionIndex_k__BackingField;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_get_CollectionIndex_Private_Static_get_Int32_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_set_CollectionIndex_Private_Static_set_Void_Int32_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0;
	}
}
