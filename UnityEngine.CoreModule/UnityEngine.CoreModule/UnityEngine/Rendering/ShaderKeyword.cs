using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000256 RID: 598
	public sealed class ShaderKeyword : ValueType
	{
		// Token: 0x060028EE RID: 10478 RVA: 0x000AA7E8 File Offset: 0x000A89E8
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderKeyword()
		{
			Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderKeyword");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr);
			ShaderKeyword.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_Name");
			ShaderKeyword.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_Index");
			ShaderKeyword.NativeFieldInfoPtr_m_IsLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsLocal");
			ShaderKeyword.NativeFieldInfoPtr_m_IsCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsCompute");
			ShaderKeyword.NativeFieldInfoPtr_m_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsValid");
			ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668492);
			ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668493);
			ShaderKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668494);
			ShaderKeyword.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668495);
			ShaderKeyword.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668496);
			ShaderKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668497);
			ShaderKeyword.GetKeywordCountDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetKeywordCountDelegate>("UnityEngine.Rendering.ShaderKeyword::GetKeywordCount");
			ShaderKeyword.GetKeywordIndexDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetKeywordIndexDelegate>("UnityEngine.Rendering.ShaderKeyword::GetKeywordIndex");
			ShaderKeyword.GetComputeShaderKeywordCountDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetComputeShaderKeywordCountDelegate>("UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordCount");
			ShaderKeyword.GetComputeShaderKeywordIndexDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetComputeShaderKeywordIndexDelegate>("UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordIndex");
			ShaderKeyword.GetGlobalShaderKeywordTypeDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetGlobalShaderKeywordTypeDelegate>("UnityEngine.Rendering.ShaderKeyword::GetGlobalShaderKeywordType");
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x000AA940 File Offset: 0x000A8B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685537, XrefRangeEnd = 685539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetGlobalKeywordCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000AA970 File Offset: 0x000A8B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685539, XrefRangeEnd = 685541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetGlobalKeywordIndex(string keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685541, XrefRangeEnd = 685543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateGlobalKeyword(string keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x000AA9EC File Offset: 0x000A8BEC
		public unsafe string name
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000AAA28 File Offset: 0x000A8C28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 685552, RefRangeEnd = 685556, XrefRangeStart = 685543, XrefRangeEnd = 685552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderKeyword(string keywordName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keywordName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000AAA78 File Offset: 0x000A8C78
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0000FD8C File Offset: 0x0000DF8C
		public ShaderKeyword(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0000FD95 File Offset: 0x0000DF95
		public ShaderKeyword()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr))
		{
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x000AAAB4 File Offset: 0x000A8CB4
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x0000FDA7 File Offset: 0x0000DFA7
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x000AAADC File Offset: 0x000A8CDC
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x0000FDC6 File Offset: 0x0000DFC6
		public unsafe uint m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x000AAB04 File Offset: 0x000A8D04
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x0000FDE1 File Offset: 0x0000DFE1
		public unsafe bool m_IsLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsLocal)) = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x000AAB2C File Offset: 0x000A8D2C
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		public unsafe bool m_IsCompute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsCompute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsCompute)) = value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x000AAB54 File Offset: 0x000A8D54
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x0000FE17 File Offset: 0x0000E017
		public unsafe bool m_IsValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsValid)) = value;
			}
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0000FE32 File Offset: 0x0000E032
		public static uint GetKeywordCount(Shader shader)
		{
			return ShaderKeyword.GetKeywordCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x0000FE44 File Offset: 0x0000E044
		public static uint GetKeywordIndex(Shader shader, string keyword)
		{
			return ShaderKeyword.GetKeywordIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x0000FE5C File Offset: 0x0000E05C
		public static uint GetComputeShaderKeywordCount(ComputeShader shader)
		{
			return ShaderKeyword.GetComputeShaderKeywordCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x0000FE6E File Offset: 0x0000E06E
		public static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword)
		{
			return ShaderKeyword.GetComputeShaderKeywordIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x0000FE86 File Offset: 0x0000E086
		public static ShaderKeywordType GetGlobalShaderKeywordType(uint keyword)
		{
			return ShaderKeyword.GetGlobalShaderKeywordTypeDelegateField(keyword);
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x000AAB7C File Offset: 0x000A8D7C
		public static ShaderKeywordType GetGlobalKeywordType(ShaderKeyword index)
		{
			bool flag = index.IsValid();
			ShaderKeywordType shaderKeywordType;
			if (flag)
			{
				shaderKeywordType = ShaderKeyword.GetGlobalShaderKeywordType(index.m_Index);
			}
			else
			{
				shaderKeywordType = ShaderKeywordType.UserDefined;
			}
			return shaderKeywordType;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x000AABAC File Offset: 0x000A8DAC
		public static bool IsKeywordLocal(ShaderKeyword keyword)
		{
			return keyword.m_IsLocal;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000AABC4 File Offset: 0x000A8DC4
		public bool IsValid()
		{
			return this.m_IsValid;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000AABDC File Offset: 0x000A8DDC
		public bool IsValid(ComputeShader shader)
		{
			return this.m_IsValid;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000AABF4 File Offset: 0x000A8DF4
		public bool IsValid(Shader shader)
		{
			return this.m_IsValid;
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x000AAC0C File Offset: 0x000A8E0C
		public int index
		{
			get
			{
				return (int)this.m_Index;
			}
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000AAC24 File Offset: 0x000A8E24
		public static ShaderKeywordType GetKeywordType(Shader shader, ShaderKeyword index)
		{
			return ShaderKeywordType.UserDefined;
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000AAC38 File Offset: 0x000A8E38
		public static ShaderKeywordType GetKeywordType(ComputeShader shader, ShaderKeyword index)
		{
			return ShaderKeywordType.UserDefined;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000AAC4C File Offset: 0x000A8E4C
		public static string GetGlobalKeywordName(ShaderKeyword index)
		{
			return index.m_Name;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000AAC64 File Offset: 0x000A8E64
		public static string GetKeywordName(Shader shader, ShaderKeyword index)
		{
			return index.m_Name;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000AAC7C File Offset: 0x000A8E7C
		public static string GetKeywordName(ComputeShader shader, ShaderKeyword index)
		{
			return index.m_Name;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000AAC94 File Offset: 0x000A8E94
		public unsafe ShaderKeywordType GetKeywordType()
		{
			return ShaderKeyword.GetGlobalKeywordType(*this);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000AACB4 File Offset: 0x000A8EB4
		public unsafe string GetKeywordName()
		{
			return ShaderKeyword.GetGlobalKeywordName(*this);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000AACD4 File Offset: 0x000A8ED4
		public string GetName()
		{
			return this.GetKeywordName();
		}

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeFieldInfoPtr_m_IsLocal;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCompute;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeFieldInfoPtr_m_IsValid;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002462 RID: 9314
		private static readonly ShaderKeyword.GetKeywordCountDelegate GetKeywordCountDelegateField;

		// Token: 0x04002463 RID: 9315
		private static readonly ShaderKeyword.GetKeywordIndexDelegate GetKeywordIndexDelegateField;

		// Token: 0x04002464 RID: 9316
		private static readonly ShaderKeyword.GetComputeShaderKeywordCountDelegate GetComputeShaderKeywordCountDelegateField;

		// Token: 0x04002465 RID: 9317
		private static readonly ShaderKeyword.GetComputeShaderKeywordIndexDelegate GetComputeShaderKeywordIndexDelegateField;

		// Token: 0x04002466 RID: 9318
		private static readonly ShaderKeyword.GetGlobalShaderKeywordTypeDelegate GetGlobalShaderKeywordTypeDelegateField;

		// Token: 0x020009F7 RID: 2551
		// (Invoke) Token: 0x06003D0B RID: 15627
		private delegate uint GetKeywordCountDelegate(IntPtr shader);

		// Token: 0x020009F8 RID: 2552
		// (Invoke) Token: 0x06003D0D RID: 15629
		private delegate uint GetKeywordIndexDelegate(IntPtr shader, IntPtr keyword);

		// Token: 0x020009F9 RID: 2553
		// (Invoke) Token: 0x06003D0F RID: 15631
		private delegate uint GetComputeShaderKeywordCountDelegate(IntPtr shader);

		// Token: 0x020009FA RID: 2554
		// (Invoke) Token: 0x06003D11 RID: 15633
		private delegate uint GetComputeShaderKeywordIndexDelegate(IntPtr shader, IntPtr keyword);

		// Token: 0x020009FB RID: 2555
		// (Invoke) Token: 0x06003D13 RID: 15635
		private delegate ShaderKeywordType GetGlobalShaderKeywordTypeDelegate(uint keyword);
	}
}
