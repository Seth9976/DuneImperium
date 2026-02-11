using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A7 RID: 167
	[Serializable]
	public class CharacterSubstitutor : Object
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x0002908C File Offset: 0x0002728C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSubstitutor()
		{
			Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "CharacterSubstitutor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr);
			CharacterSubstitutor.NativeFieldInfoPtr_m_SubstitutionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, "m_SubstitutionMethod");
			CharacterSubstitutor.NativeFieldInfoPtr_m_ListMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, "m_ListMode");
			CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, "m_ReplacementsMap");
			CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, "m_ReplacementList");
			CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementsPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, "m_ReplacementsPosition");
			CharacterSubstitutor.NativeFieldInfoPtr__ReplacementMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, "<ReplacementMap>k__BackingField");
			CharacterSubstitutor.NativeMethodInfoPtr_get_Method_Public_get_SubstitutionMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664766);
			CharacterSubstitutor.NativeMethodInfoPtr_set_Method_Public_set_Void_SubstitutionMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664767);
			CharacterSubstitutor.NativeMethodInfoPtr_get_ReplacementMap_Public_get_Dictionary_2_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664768);
			CharacterSubstitutor.NativeMethodInfoPtr_set_ReplacementMap_Private_set_Void_Dictionary_2_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664769);
			CharacterSubstitutor.NativeMethodInfoPtr_get_ListMode_Public_get_ListSelectionMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664770);
			CharacterSubstitutor.NativeMethodInfoPtr_set_ListMode_Public_set_Void_ListSelectionMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664771);
			CharacterSubstitutor.NativeMethodInfoPtr_get_ReplacementList_Public_get_List_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664772);
			CharacterSubstitutor.NativeMethodInfoPtr_GetRandomSeed_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664773);
			CharacterSubstitutor.NativeMethodInfoPtr_ReplaceCharFromMap_Internal_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664774);
			CharacterSubstitutor.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664775);
			CharacterSubstitutor.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664776);
			CharacterSubstitutor.NativeMethodInfoPtr_TransformFragment_Private_Void_WritableMessageFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664777);
			CharacterSubstitutor.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664778);
			CharacterSubstitutor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, 100664779);
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x0002924C File Offset: 0x0002744C
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00029288 File Offset: 0x00027488
		public unsafe CharacterSubstitutor.SubstitutionMethod Method
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_get_Method_Public_get_SubstitutionMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_set_Method_Public_set_Void_SubstitutionMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x000292C8 File Offset: 0x000274C8
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x00029308 File Offset: 0x00027508
		public unsafe Dictionary<char, char> ReplacementMap
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_get_ReplacementMap_Public_get_Dictionary_2_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<char, char>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_set_ReplacementMap_Private_set_Void_Dictionary_2_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x0002934C File Offset: 0x0002754C
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00029388 File Offset: 0x00027588
		public unsafe CharacterSubstitutor.ListSelectionMethod ListMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_get_ListMode_Public_get_ListSelectionMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_set_ListMode_Public_set_Void_ListSelectionMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000293C8 File Offset: 0x000275C8
		public unsafe List<char> ReplacementList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_get_ReplacementList_Public_get_List_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00029408 File Offset: 0x00027608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRandomSeed(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_GetRandomSeed_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00029458 File Offset: 0x00027658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076447, XrefRangeEnd = 1076450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ReplaceCharFromMap(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_ReplaceCharFromMap_Internal_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000294A4 File Offset: 0x000276A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076450, XrefRangeEnd = 1076478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000294D8 File Offset: 0x000276D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076478, XrefRangeEnd = 1076505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0002950C File Offset: 0x0002770C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076530, RefRangeEnd = 1076531, XrefRangeStart = 1076505, XrefRangeEnd = 1076530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformFragment(WritableMessageFragment writableFragment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writableFragment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_TransformFragment_Private_Void_WritableMessageFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00029550 File Offset: 0x00027750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076531, XrefRangeEnd = 1076549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Transform(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00029594 File Offset: 0x00027794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076570, RefRangeEnd = 1076571, XrefRangeStart = 1076549, XrefRangeEnd = 1076570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSubstitutor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitutor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0000525C File Offset: 0x0000345C
		public CharacterSubstitutor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x000295D0 File Offset: 0x000277D0
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00005265 File Offset: 0x00003465
		public unsafe CharacterSubstitutor.SubstitutionMethod m_SubstitutionMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_SubstitutionMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_SubstitutionMethod)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000295F8 File Offset: 0x000277F8
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00005280 File Offset: 0x00003480
		public unsafe CharacterSubstitutor.ListSelectionMethod m_ListMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_ListMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_ListMode)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00029620 File Offset: 0x00027820
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x0000529B File Offset: 0x0000349B
		public unsafe List<CharacterSubstitutor.CharReplacement> m_ReplacementsMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementsMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterSubstitutor.CharReplacement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00029650 File Offset: 0x00027850
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x000052BA File Offset: 0x000034BA
		public unsafe List<char> m_ReplacementList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00029680 File Offset: 0x00027880
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x000052D9 File Offset: 0x000034D9
		public unsafe int m_ReplacementsPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementsPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr_m_ReplacementsPosition)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x000296A8 File Offset: 0x000278A8
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x000052F4 File Offset: 0x000034F4
		public unsafe Dictionary<char, char> _ReplacementMap_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr__ReplacementMap_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<char, char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSubstitutor.NativeFieldInfoPtr__ReplacementMap_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeFieldInfoPtr_m_SubstitutionMethod;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeFieldInfoPtr_m_ListMode;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeFieldInfoPtr_m_ReplacementsMap;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeFieldInfoPtr_m_ReplacementList;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr_m_ReplacementsPosition;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr__ReplacementMap_k__BackingField;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_SubstitutionMethod_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_set_Void_SubstitutionMethod_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementMap_Public_get_Dictionary_2_Char_Char_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_set_ReplacementMap_Private_set_Void_Dictionary_2_Char_Char_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_get_ListMode_Public_get_ListSelectionMethod_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_set_ListMode_Public_set_Void_ListSelectionMethod_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementList_Public_get_List_1_Char_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomSeed_Private_Int32_String_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceCharFromMap_Internal_Char_Char_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_TransformFragment_Private_Void_WritableMessageFragment_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000163 RID: 355
		public enum SubstitutionMethod
		{
			// Token: 0x04000A74 RID: 2676
			ToUpper,
			// Token: 0x04000A75 RID: 2677
			ToLower,
			// Token: 0x04000A76 RID: 2678
			List,
			// Token: 0x04000A77 RID: 2679
			Map
		}

		// Token: 0x02000164 RID: 356
		[Serializable]
		[StructLayout(2)]
		public struct CharReplacement
		{
			// Token: 0x06000F48 RID: 3912 RVA: 0x00041774 File Offset: 0x0003F974
			// Note: this type is marked as 'beforefieldinit'.
			static CharReplacement()
			{
				Il2CppClassPointerStore<CharacterSubstitutor.CharReplacement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterSubstitutor>.NativeClassPtr, "CharReplacement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSubstitutor.CharReplacement>.NativeClassPtr);
				CharacterSubstitutor.CharReplacement.NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitutor.CharReplacement>.NativeClassPtr, "original");
				CharacterSubstitutor.CharReplacement.NativeFieldInfoPtr_replacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitutor.CharReplacement>.NativeClassPtr, "replacement");
			}

			// Token: 0x06000F49 RID: 3913 RVA: 0x00008661 File Offset: 0x00006861
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterSubstitutor.CharReplacement>.NativeClassPtr, ref this));
			}

			// Token: 0x04000A78 RID: 2680
			private static readonly IntPtr NativeFieldInfoPtr_original;

			// Token: 0x04000A79 RID: 2681
			private static readonly IntPtr NativeFieldInfoPtr_replacement;

			// Token: 0x04000A7A RID: 2682
			[FieldOffset(0)]
			public char original;

			// Token: 0x04000A7B RID: 2683
			[FieldOffset(2)]
			public char replacement;
		}

		// Token: 0x02000165 RID: 357
		public enum ListSelectionMethod
		{
			// Token: 0x04000A7D RID: 2685
			Random,
			// Token: 0x04000A7E RID: 2686
			LoopFromPrevious,
			// Token: 0x04000A7F RID: 2687
			LoopFromStart
		}
	}
}
