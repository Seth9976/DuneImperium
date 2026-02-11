using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A9 RID: 169
	[Serializable]
	public class Expander : Object
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x00029970 File Offset: 0x00027B70
		// Note: this type is marked as 'beforefieldinit'.
		static Expander()
		{
			Il2CppClassPointerStore<Expander>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "Expander");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expander>.NativeClassPtr);
			Expander.NativeFieldInfoPtr_m_ExpansionRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expander>.NativeClassPtr, "m_ExpansionRules");
			Expander.NativeFieldInfoPtr_m_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expander>.NativeClassPtr, "m_Location");
			Expander.NativeFieldInfoPtr_m_MinimumStringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expander>.NativeClassPtr, "m_MinimumStringLength");
			Expander.NativeFieldInfoPtr_m_PaddingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expander>.NativeClassPtr, "m_PaddingCharacters");
			Expander.NativeMethodInfoPtr_get_ExpansionRules_Public_get_List_1_ExpansionRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664786);
			Expander.NativeMethodInfoPtr_get_Location_Public_get_InsertLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664787);
			Expander.NativeMethodInfoPtr_set_Location_Public_set_Void_InsertLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664788);
			Expander.NativeMethodInfoPtr_get_PaddingCharacters_Public_get_List_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664789);
			Expander.NativeMethodInfoPtr_get_MinimumStringLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664790);
			Expander.NativeMethodInfoPtr_set_MinimumStringLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664791);
			Expander.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664792);
			Expander.NativeMethodInfoPtr__ctor_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664793);
			Expander.NativeMethodInfoPtr__ctor_Public_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664794);
			Expander.NativeMethodInfoPtr_AddCharacterRange_Public_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664795);
			Expander.NativeMethodInfoPtr_SetConstantExpansion_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664796);
			Expander.NativeMethodInfoPtr_AddExpansionRule_Public_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664797);
			Expander.NativeMethodInfoPtr_GetExpansionForLength_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664798);
			Expander.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664799);
			Expander.NativeMethodInfoPtr_AddPaddingToMessage_Private_Void_Message_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664800);
			Expander.NativeMethodInfoPtr_GetRandomSeed_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander>.NativeClassPtr, 100664801);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00029B30 File Offset: 0x00027D30
		public unsafe List<Expander.ExpansionRule> ExpansionRules
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_get_ExpansionRules_Public_get_List_1_ExpansionRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Expander.ExpansionRule>>(intPtr3) : null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00029B70 File Offset: 0x00027D70
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00029BAC File Offset: 0x00027DAC
		public unsafe Expander.InsertLocation Location
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_get_Location_Public_get_InsertLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_set_Location_Public_set_Void_InsertLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00029BEC File Offset: 0x00027DEC
		public unsafe List<char> PaddingCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_get_PaddingCharacters_Public_get_List_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<char>>(intPtr3) : null;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00029C2C File Offset: 0x00027E2C
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00029C68 File Offset: 0x00027E68
		public unsafe int MinimumStringLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_get_MinimumStringLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_set_MinimumStringLength_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00029CA8 File Offset: 0x00027EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076629, RefRangeEnd = 1076630, XrefRangeStart = 1076592, XrefRangeEnd = 1076629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expander()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expander>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00029CE4 File Offset: 0x00027EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076630, XrefRangeEnd = 1076667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expander(char paddingCharacter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expander>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paddingCharacter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr__ctor_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00029D2C File Offset: 0x00027F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076667, XrefRangeEnd = 1076704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expander(char start, char end)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expander>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr__ctor_Public_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00029D84 File Offset: 0x00027F84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1076708, RefRangeEnd = 1076710, XrefRangeStart = 1076704, XrefRangeEnd = 1076708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCharacterRange(char start, char end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_AddCharacterRange_Public_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00029DD0 File Offset: 0x00027FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076710, XrefRangeEnd = 1076721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConstantExpansion(float expansion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expansion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_SetConstantExpansion_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00029E10 File Offset: 0x00028010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076721, XrefRangeEnd = 1076731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExpansionRule(int minCharacters, int maxCharacters, float expansion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minCharacters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCharacters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expansion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_AddExpansionRule_Public_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00029E6C File Offset: 0x0002806C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076741, RefRangeEnd = 1076742, XrefRangeStart = 1076731, XrefRangeEnd = 1076741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetExpansionForLength(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_GetExpansionForLength_Internal_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00029EB8 File Offset: 0x000280B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076742, XrefRangeEnd = 1076774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Transform(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00029EFC File Offset: 0x000280FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076774, XrefRangeEnd = 1076791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPaddingToMessage(Message message, Il2CppStructArray<char> padding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(padding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_AddPaddingToMessage_Private_Void_Message_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00029F50 File Offset: 0x00028150
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.NativeMethodInfoPtr_GetRandomSeed_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0000535A File Offset: 0x0000355A
		public Expander(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00029FA0 File Offset: 0x000281A0
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00005363 File Offset: 0x00003563
		public unsafe List<Expander.ExpansionRule> m_ExpansionRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expander.NativeFieldInfoPtr_m_ExpansionRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Expander.ExpansionRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expander.NativeFieldInfoPtr_m_ExpansionRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00029FD0 File Offset: 0x000281D0
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00005382 File Offset: 0x00003582
		public unsafe Expander.InsertLocation m_Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expander.NativeFieldInfoPtr_m_Location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expander.NativeFieldInfoPtr_m_Location)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00029FF8 File Offset: 0x000281F8
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x0000539D File Offset: 0x0000359D
		public unsafe int m_MinimumStringLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expander.NativeFieldInfoPtr_m_MinimumStringLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expander.NativeFieldInfoPtr_m_MinimumStringLength)) = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0002A020 File Offset: 0x00028220
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x000053B8 File Offset: 0x000035B8
		public unsafe List<char> m_PaddingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expander.NativeFieldInfoPtr_m_PaddingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expander.NativeFieldInfoPtr_m_PaddingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpansionRules;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_m_Location;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_m_MinimumStringLength;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_m_PaddingCharacters;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpansionRules_Public_get_List_1_ExpansionRule_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_InsertLocation_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_set_Location_Public_set_Void_InsertLocation_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingCharacters_Public_get_List_1_Char_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumStringLength_Public_get_Int32_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_set_MinimumStringLength_Public_set_Void_Int32_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Char_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_AddCharacterRange_Public_Void_Char_Char_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_SetConstantExpansion_Public_Void_Single_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_AddExpansionRule_Public_Void_Int32_Int32_Single_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_GetExpansionForLength_Internal_Single_Int32_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_AddPaddingToMessage_Private_Void_Message_Il2CppStructArray_1_Char_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomSeed_Private_Int32_String_0;

		// Token: 0x02000166 RID: 358
		public enum InsertLocation
		{
			// Token: 0x04000A81 RID: 2689
			Start,
			// Token: 0x04000A82 RID: 2690
			End,
			// Token: 0x04000A83 RID: 2691
			Both
		}

		// Token: 0x02000167 RID: 359
		[Serializable]
		[StructLayout(2)]
		public struct ExpansionRule
		{
			// Token: 0x06000F4A RID: 3914 RVA: 0x000417C8 File Offset: 0x0003F9C8
			// Note: this type is marked as 'beforefieldinit'.
			static ExpansionRule()
			{
				Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Expander>.NativeClassPtr, "ExpansionRule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr);
				Expander.ExpansionRule.NativeFieldInfoPtr_m_MinCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, "m_MinCharacters");
				Expander.ExpansionRule.NativeFieldInfoPtr_m_MaxCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, "m_MaxCharacters");
				Expander.ExpansionRule.NativeFieldInfoPtr_m_ExpansionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, "m_ExpansionAmount");
				Expander.ExpansionRule.NativeMethodInfoPtr_get_MinCharacters_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664802);
				Expander.ExpansionRule.NativeMethodInfoPtr_set_MinCharacters_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664803);
				Expander.ExpansionRule.NativeMethodInfoPtr_get_MaxCharacters_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664804);
				Expander.ExpansionRule.NativeMethodInfoPtr_set_MaxCharacters_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664805);
				Expander.ExpansionRule.NativeMethodInfoPtr_get_ExpansionAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664806);
				Expander.ExpansionRule.NativeMethodInfoPtr_set_ExpansionAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664807);
				Expander.ExpansionRule.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664808);
				Expander.ExpansionRule.NativeMethodInfoPtr_InRange_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664809);
				Expander.ExpansionRule.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ExpansionRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, 100664810);
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000418E4 File Offset: 0x0003FAE4
			// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00041914 File Offset: 0x0003FB14
			public unsafe int MinCharacters
			{
				[CallerCount(200)]
				[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr_get_MinCharacters_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr_set_MinCharacters_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00041948 File Offset: 0x0003FB48
			// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00041978 File Offset: 0x0003FB78
			public unsafe int MaxCharacters
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr_get_MaxCharacters_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr_set_MaxCharacters_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000419AC File Offset: 0x0003FBAC
			// (set) Token: 0x06000F50 RID: 3920 RVA: 0x000419DC File Offset: 0x0003FBDC
			public unsafe float ExpansionAmount
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr_get_ExpansionAmount_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr_set_ExpansionAmount_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000F51 RID: 3921 RVA: 0x00041A10 File Offset: 0x0003FC10
			[CallerCount(0)]
			public unsafe ExpansionRule(int minCharacters, int maxCharacters, float expansion)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref minCharacters;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCharacters;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expansion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F52 RID: 3922 RVA: 0x00041A60 File Offset: 0x0003FC60
			[CallerCount(0)]
			public unsafe bool InRange(int length)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref length;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr_InRange_Internal_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F53 RID: 3923 RVA: 0x00041AA0 File Offset: 0x0003FCA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076591, XrefRangeEnd = 1076592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int CompareTo(Expander.ExpansionRule other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expander.ExpansionRule.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ExpansionRule_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F54 RID: 3924 RVA: 0x00008673 File Offset: 0x00006873
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Expander.ExpansionRule>.NativeClassPtr, ref this));
			}

			// Token: 0x04000A84 RID: 2692
			private static readonly IntPtr NativeFieldInfoPtr_m_MinCharacters;

			// Token: 0x04000A85 RID: 2693
			private static readonly IntPtr NativeFieldInfoPtr_m_MaxCharacters;

			// Token: 0x04000A86 RID: 2694
			private static readonly IntPtr NativeFieldInfoPtr_m_ExpansionAmount;

			// Token: 0x04000A87 RID: 2695
			private static readonly IntPtr NativeMethodInfoPtr_get_MinCharacters_Public_get_Int32_0;

			// Token: 0x04000A88 RID: 2696
			private static readonly IntPtr NativeMethodInfoPtr_set_MinCharacters_Public_set_Void_Int32_0;

			// Token: 0x04000A89 RID: 2697
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharacters_Public_get_Int32_0;

			// Token: 0x04000A8A RID: 2698
			private static readonly IntPtr NativeMethodInfoPtr_set_MaxCharacters_Public_set_Void_Int32_0;

			// Token: 0x04000A8B RID: 2699
			private static readonly IntPtr NativeMethodInfoPtr_get_ExpansionAmount_Public_get_Single_0;

			// Token: 0x04000A8C RID: 2700
			private static readonly IntPtr NativeMethodInfoPtr_set_ExpansionAmount_Public_set_Void_Single_0;

			// Token: 0x04000A8D RID: 2701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_0;

			// Token: 0x04000A8E RID: 2702
			private static readonly IntPtr NativeMethodInfoPtr_InRange_Internal_Boolean_Int32_0;

			// Token: 0x04000A8F RID: 2703
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ExpansionRule_0;

			// Token: 0x04000A90 RID: 2704
			[FieldOffset(0)]
			public int m_MinCharacters;

			// Token: 0x04000A91 RID: 2705
			[FieldOffset(4)]
			public int m_MaxCharacters;

			// Token: 0x04000A92 RID: 2706
			[FieldOffset(8)]
			public float m_ExpansionAmount;
		}
	}
}
