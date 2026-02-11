using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore
{
	// Token: 0x02000002 RID: 2
	[Serializable]
	public sealed class FaceInfo : ValueType
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002CFC File Offset: 0x00000EFC
		// Note: this type is marked as 'beforefieldinit'.
		static FaceInfo()
		{
			Il2CppClassPointerStore<FaceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore", "FaceInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr);
			FaceInfo.NativeFieldInfoPtr_m_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_FaceIndex");
			FaceInfo.NativeFieldInfoPtr_m_FamilyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_FamilyName");
			FaceInfo.NativeFieldInfoPtr_m_StyleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StyleName");
			FaceInfo.NativeFieldInfoPtr_m_PointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_PointSize");
			FaceInfo.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_Scale");
			FaceInfo.NativeFieldInfoPtr_m_UnitsPerEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_UnitsPerEM");
			FaceInfo.NativeFieldInfoPtr_m_LineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_LineHeight");
			FaceInfo.NativeFieldInfoPtr_m_AscentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_AscentLine");
			FaceInfo.NativeFieldInfoPtr_m_CapLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_CapLine");
			FaceInfo.NativeFieldInfoPtr_m_MeanLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_MeanLine");
			FaceInfo.NativeFieldInfoPtr_m_Baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_Baseline");
			FaceInfo.NativeFieldInfoPtr_m_DescentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_DescentLine");
			FaceInfo.NativeFieldInfoPtr_m_SuperscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SuperscriptOffset");
			FaceInfo.NativeFieldInfoPtr_m_SuperscriptSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SuperscriptSize");
			FaceInfo.NativeFieldInfoPtr_m_SubscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SubscriptOffset");
			FaceInfo.NativeFieldInfoPtr_m_SubscriptSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SubscriptSize");
			FaceInfo.NativeFieldInfoPtr_m_UnderlineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_UnderlineOffset");
			FaceInfo.NativeFieldInfoPtr_m_UnderlineThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_UnderlineThickness");
			FaceInfo.NativeFieldInfoPtr_m_StrikethroughOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StrikethroughOffset");
			FaceInfo.NativeFieldInfoPtr_m_StrikethroughThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StrikethroughThickness");
			FaceInfo.NativeFieldInfoPtr_m_TabWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_TabWidth");
			FaceInfo.NativeMethodInfoPtr_get_faceIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663297);
			FaceInfo.NativeMethodInfoPtr_get_familyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663298);
			FaceInfo.NativeMethodInfoPtr_set_familyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663299);
			FaceInfo.NativeMethodInfoPtr_get_styleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663300);
			FaceInfo.NativeMethodInfoPtr_set_styleName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663301);
			FaceInfo.NativeMethodInfoPtr_get_pointSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663302);
			FaceInfo.NativeMethodInfoPtr_set_pointSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663303);
			FaceInfo.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663304);
			FaceInfo.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663305);
			FaceInfo.NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663306);
			FaceInfo.NativeMethodInfoPtr_set_lineHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663307);
			FaceInfo.NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663308);
			FaceInfo.NativeMethodInfoPtr_set_ascentLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663309);
			FaceInfo.NativeMethodInfoPtr_get_capLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663310);
			FaceInfo.NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663311);
			FaceInfo.NativeMethodInfoPtr_get_meanLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663312);
			FaceInfo.NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663313);
			FaceInfo.NativeMethodInfoPtr_get_baseline_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663314);
			FaceInfo.NativeMethodInfoPtr_set_baseline_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663315);
			FaceInfo.NativeMethodInfoPtr_get_descentLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663316);
			FaceInfo.NativeMethodInfoPtr_set_descentLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663317);
			FaceInfo.NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663318);
			FaceInfo.NativeMethodInfoPtr_set_superscriptOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663319);
			FaceInfo.NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663320);
			FaceInfo.NativeMethodInfoPtr_set_superscriptSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663321);
			FaceInfo.NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663322);
			FaceInfo.NativeMethodInfoPtr_set_subscriptOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663323);
			FaceInfo.NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663324);
			FaceInfo.NativeMethodInfoPtr_set_subscriptSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663325);
			FaceInfo.NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663326);
			FaceInfo.NativeMethodInfoPtr_set_underlineOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663327);
			FaceInfo.NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663328);
			FaceInfo.NativeMethodInfoPtr_set_underlineThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663329);
			FaceInfo.NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663330);
			FaceInfo.NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663331);
			FaceInfo.NativeMethodInfoPtr_set_strikethroughThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663332);
			FaceInfo.NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663333);
			FaceInfo.NativeMethodInfoPtr_set_tabWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663334);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000031C8 File Offset: 0x000013C8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000022AA File Offset: 0x000004AA
		public unsafe int faceIndex
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_faceIndex_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FaceIndex = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000320C File Offset: 0x0000140C
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00003248 File Offset: 0x00001448
		public unsafe string familyName
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 323759, RefRangeEnd = 323772, XrefRangeStart = 323759, XrefRangeEnd = 323772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_familyName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_familyName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00003290 File Offset: 0x00001490
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000032CC File Offset: 0x000014CC
		public unsafe string styleName
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_styleName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_styleName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00003314 File Offset: 0x00001514
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00003358 File Offset: 0x00001558
		public unsafe int pointSize
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_pointSize_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_pointSize_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000339C File Offset: 0x0000159C
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000033E0 File Offset: 0x000015E0
		public unsafe float scale
		{
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1252657, RefRangeEnd = 1252710, XrefRangeStart = 1252657, XrefRangeEnd = 1252657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 604702, RefRangeEnd = 604705, XrefRangeStart = 604702, XrefRangeEnd = 604705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00003424 File Offset: 0x00001624
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00003468 File Offset: 0x00001668
		public unsafe float lineHeight
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 678105, RefRangeEnd = 678110, XrefRangeStart = 678105, XrefRangeEnd = 678110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604705, RefRangeEnd = 604706, XrefRangeStart = 604705, XrefRangeEnd = 604706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_lineHeight_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000034AC File Offset: 0x000016AC
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000034F0 File Offset: 0x000016F0
		public unsafe float ascentLine
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 1252710, RefRangeEnd = 1252736, XrefRangeStart = 1252710, XrefRangeEnd = 1252710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604706, RefRangeEnd = 604707, XrefRangeStart = 604706, XrefRangeEnd = 604707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_ascentLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00003534 File Offset: 0x00001734
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00003578 File Offset: 0x00001778
		public unsafe float capLine
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 318216, RefRangeEnd = 318232, XrefRangeStart = 318216, XrefRangeEnd = 318232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_capLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318232, RefRangeEnd = 318235, XrefRangeStart = 318232, XrefRangeEnd = 318235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000035BC File Offset: 0x000017BC
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00003600 File Offset: 0x00001800
		public unsafe float meanLine
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1252736, RefRangeEnd = 1252741, XrefRangeStart = 1252736, XrefRangeEnd = 1252736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_meanLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318236, RefRangeEnd = 318239, XrefRangeStart = 318236, XrefRangeEnd = 318239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00003644 File Offset: 0x00001844
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00003688 File Offset: 0x00001888
		public unsafe float baseline
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1252741, RefRangeEnd = 1252755, XrefRangeStart = 1252741, XrefRangeEnd = 1252741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_baseline_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 320619, RefRangeEnd = 320620, XrefRangeStart = 320619, XrefRangeEnd = 320620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_baseline_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000036CC File Offset: 0x000018CC
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00003710 File Offset: 0x00001910
		public unsafe float descentLine
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 1032702, RefRangeEnd = 1032747, XrefRangeStart = 1032702, XrefRangeEnd = 1032747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_descentLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 850305, RefRangeEnd = 850310, XrefRangeStart = 850305, XrefRangeEnd = 850310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_descentLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003754 File Offset: 0x00001954
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00003798 File Offset: 0x00001998
		public unsafe float superscriptOffset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1032748, RefRangeEnd = 1032751, XrefRangeStart = 1032748, XrefRangeEnd = 1032751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604707, RefRangeEnd = 604708, XrefRangeStart = 604707, XrefRangeEnd = 604708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_superscriptOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000037DC File Offset: 0x000019DC
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00003820 File Offset: 0x00001A20
		public unsafe float superscriptSize
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1088553, RefRangeEnd = 1088556, XrefRangeStart = 1088553, XrefRangeEnd = 1088556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599561, RefRangeEnd = 599562, XrefRangeStart = 599561, XrefRangeEnd = 599562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_superscriptSize_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00003864 File Offset: 0x00001A64
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000038A8 File Offset: 0x00001AA8
		public unsafe float subscriptOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599562, RefRangeEnd = 599563, XrefRangeStart = 599562, XrefRangeEnd = 599563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_subscriptOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000038EC File Offset: 0x00001AEC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00003930 File Offset: 0x00001B30
		public unsafe float subscriptSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318239, RefRangeEnd = 318240, XrefRangeStart = 318239, XrefRangeEnd = 318240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_subscriptSize_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003974 File Offset: 0x00001B74
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000039B8 File Offset: 0x00001BB8
		public unsafe float underlineOffset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1088550, RefRangeEnd = 1088553, XrefRangeStart = 1088550, XrefRangeEnd = 1088553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1080963, RefRangeEnd = 1080964, XrefRangeStart = 1080963, XrefRangeEnd = 1080964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_underlineOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000039FC File Offset: 0x00001BFC
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00003A40 File Offset: 0x00001C40
		public unsafe float underlineThickness
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1088556, RefRangeEnd = 1088558, XrefRangeStart = 1088556, XrefRangeEnd = 1088558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 885351, RefRangeEnd = 885352, XrefRangeStart = 885351, XrefRangeEnd = 885352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_underlineThickness_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003A84 File Offset: 0x00001C84
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00003AC8 File Offset: 0x00001CC8
		public unsafe float strikethroughOffset
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1252755, RefRangeEnd = 1252760, XrefRangeStart = 1252755, XrefRangeEnd = 1252755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1046597, RefRangeEnd = 1046600, XrefRangeStart = 1046597, XrefRangeEnd = 1046600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003F38 File Offset: 0x00002138
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003B0C File Offset: 0x00001D0C
		public unsafe float strikethroughThickness
		{
			get
			{
				return this.m_StrikethroughThickness;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 357469, RefRangeEnd = 357470, XrefRangeStart = 357469, XrefRangeEnd = 357470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_strikethroughThickness_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003B50 File Offset: 0x00001D50
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00003B94 File Offset: 0x00001D94
		public unsafe float tabWidth
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1252760, RefRangeEnd = 1252765, XrefRangeStart = 1252760, XrefRangeEnd = 1252760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1080808, RefRangeEnd = 1080809, XrefRangeStart = 1080808, XrefRangeEnd = 1080809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_tabWidth_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		public FaceInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002059 File Offset: 0x00000259
		public FaceInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003BD8 File Offset: 0x00001DD8
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe int m_FaceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_FaceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_FaceIndex)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003C00 File Offset: 0x00001E00
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002086 File Offset: 0x00000286
		public unsafe string m_FamilyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_FamilyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_FamilyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003C28 File Offset: 0x00001E28
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000020A5 File Offset: 0x000002A5
		public unsafe string m_StyleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StyleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StyleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003C50 File Offset: 0x00001E50
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000020C4 File Offset: 0x000002C4
		public unsafe int m_PointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_PointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_PointSize)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003C78 File Offset: 0x00001E78
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000020DF File Offset: 0x000002DF
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003CA0 File Offset: 0x00001EA0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000020FA File Offset: 0x000002FA
		public unsafe int m_UnitsPerEM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnitsPerEM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnitsPerEM)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003CC8 File Offset: 0x00001EC8
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002115 File Offset: 0x00000315
		public unsafe float m_LineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_LineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_LineHeight)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003CF0 File Offset: 0x00001EF0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002130 File Offset: 0x00000330
		public unsafe float m_AscentLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_AscentLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_AscentLine)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003D18 File Offset: 0x00001F18
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0000214B File Offset: 0x0000034B
		public unsafe float m_CapLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_CapLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_CapLine)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003D40 File Offset: 0x00001F40
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002166 File Offset: 0x00000366
		public unsafe float m_MeanLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_MeanLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_MeanLine)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003D68 File Offset: 0x00001F68
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002181 File Offset: 0x00000381
		public unsafe float m_Baseline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_Baseline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_Baseline)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003D90 File Offset: 0x00001F90
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000219C File Offset: 0x0000039C
		public unsafe float m_DescentLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_DescentLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_DescentLine)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003DB8 File Offset: 0x00001FB8
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000021B7 File Offset: 0x000003B7
		public unsafe float m_SuperscriptOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SuperscriptOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SuperscriptOffset)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003DE0 File Offset: 0x00001FE0
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000021D2 File Offset: 0x000003D2
		public unsafe float m_SuperscriptSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SuperscriptSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SuperscriptSize)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003E08 File Offset: 0x00002008
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000021ED File Offset: 0x000003ED
		public unsafe float m_SubscriptOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SubscriptOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SubscriptOffset)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003E30 File Offset: 0x00002030
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002208 File Offset: 0x00000408
		public unsafe float m_SubscriptSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SubscriptSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SubscriptSize)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003E58 File Offset: 0x00002058
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002223 File Offset: 0x00000423
		public unsafe float m_UnderlineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnderlineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnderlineOffset)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003E80 File Offset: 0x00002080
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000223E File Offset: 0x0000043E
		public unsafe float m_UnderlineThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnderlineThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnderlineThickness)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003EA8 File Offset: 0x000020A8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002259 File Offset: 0x00000459
		public unsafe float m_StrikethroughOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StrikethroughOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StrikethroughOffset)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003ED0 File Offset: 0x000020D0
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002274 File Offset: 0x00000474
		public unsafe float m_StrikethroughThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StrikethroughThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StrikethroughThickness)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003EF8 File Offset: 0x000020F8
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000228F File Offset: 0x0000048F
		public unsafe float m_TabWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_TabWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_TabWidth)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003F20 File Offset: 0x00002120
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000022B4 File Offset: 0x000004B4
		public int unitsPerEM
		{
			get
			{
				return this.m_UnitsPerEM;
			}
			set
			{
				this.m_UnitsPerEM = value;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003F50 File Offset: 0x00002150
		public bool Compare(FaceInfo other)
		{
			return this.familyName == other.familyName && this.styleName == other.styleName && this.faceIndex == other.faceIndex && this.pointSize == other.pointSize && FontEngineUtilities.Approximately(this.scale, other.scale) && FontEngineUtilities.Approximately((float)this.unitsPerEM, (float)other.unitsPerEM) && FontEngineUtilities.Approximately(this.lineHeight, other.lineHeight) && FontEngineUtilities.Approximately(this.ascentLine, other.ascentLine) && FontEngineUtilities.Approximately(this.capLine, other.capLine) && FontEngineUtilities.Approximately(this.meanLine, other.meanLine) && FontEngineUtilities.Approximately(this.baseline, other.baseline) && FontEngineUtilities.Approximately(this.descentLine, other.descentLine) && FontEngineUtilities.Approximately(this.superscriptOffset, other.superscriptOffset) && FontEngineUtilities.Approximately(this.superscriptSize, other.superscriptSize) && FontEngineUtilities.Approximately(this.subscriptOffset, other.subscriptOffset) && FontEngineUtilities.Approximately(this.subscriptSize, other.subscriptSize) && FontEngineUtilities.Approximately(this.underlineOffset, other.underlineOffset) && FontEngineUtilities.Approximately(this.underlineThickness, other.underlineThickness) && FontEngineUtilities.Approximately(this.strikethroughOffset, other.strikethroughOffset) && FontEngineUtilities.Approximately(this.strikethroughThickness, other.strikethroughThickness) && FontEngineUtilities.Approximately(this.tabWidth, other.tabWidth);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceIndex;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_FamilyName;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleName;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_m_PointSize;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_UnitsPerEM;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_m_LineHeight;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_m_AscentLine;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_m_CapLine;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_m_MeanLine;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_Baseline;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_m_DescentLine;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_m_SuperscriptOffset;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_m_SuperscriptSize;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_m_SubscriptOffset;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_m_SubscriptSize;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_m_UnderlineOffset;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_m_UnderlineThickness;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_m_StrikethroughOffset;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_m_StrikethroughThickness;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_m_TabWidth;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_faceIndex_Internal_get_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_familyName_Public_get_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_set_familyName_Public_set_Void_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_styleName_Public_get_String_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_styleName_Public_set_Void_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_pointSize_Public_get_Int32_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_set_pointSize_Public_set_Void_Int32_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_set_lineHeight_Public_set_Void_Single_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_set_ascentLine_Public_set_Void_Single_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_capLine_Public_get_Single_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_meanLine_Public_get_Single_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_baseline_Public_get_Single_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_set_baseline_Public_set_Void_Single_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_descentLine_Public_get_Single_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_set_descentLine_Public_set_Void_Single_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_set_superscriptOffset_Public_set_Void_Single_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_set_superscriptSize_Public_set_Void_Single_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_set_subscriptOffset_Public_set_Void_Single_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_set_subscriptSize_Public_set_Void_Single_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_set_underlineOffset_Public_set_Void_Single_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_set_underlineThickness_Public_set_Void_Single_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_set_strikethroughThickness_Public_set_Void_Single_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_set_tabWidth_Public_set_Void_Single_0;
	}
}
