using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000254 RID: 596
	public sealed class LocalKeyword : ValueType
	{
		// Token: 0x060028BA RID: 10426 RVA: 0x000A9FF0 File Offset: 0x000A81F0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalKeyword()
		{
			Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LocalKeyword");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr);
			LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_SpaceInfo");
			LocalKeyword.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_Name");
			LocalKeyword.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_Index");
			LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668481);
			LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668482);
			LocalKeyword.NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668483);
			LocalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668484);
			LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668485);
			LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668486);
			LocalKeyword.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668487);
			LocalKeyword.GetComputeShaderKeywordCountDelegateField = IL2CPP.ResolveICall<LocalKeyword.GetComputeShaderKeywordCountDelegate>("UnityEngine.Rendering.LocalKeyword::GetComputeShaderKeywordCount");
			LocalKeyword.GetComputeShaderKeywordIndexDelegateField = IL2CPP.ResolveICall<LocalKeyword.GetComputeShaderKeywordIndexDelegate>("UnityEngine.Rendering.LocalKeyword::GetComputeShaderKeywordIndex");
			LocalKeyword.IsDynamic_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsDynamic_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsDynamic_Injected");
			LocalKeyword.IsOverridable_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsOverridable_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsOverridable_Injected");
			LocalKeyword.GetKeywordType_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.GetKeywordType_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::GetKeywordType_Injected");
			LocalKeyword.IsValid_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsValid_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsValid_Injected");
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000AA144 File Offset: 0x000A8344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685493, XrefRangeEnd = 685495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetShaderKeywordCount(Shader shader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000AA188 File Offset: 0x000A8388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685495, XrefRangeEnd = 685497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetShaderKeywordIndex(Shader shader, string keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000AA1DC File Offset: 0x000A83DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685523, RefRangeEnd = 685524, XrefRangeStart = 685497, XrefRangeEnd = 685523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalKeyword(Shader shader, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000AA240 File Offset: 0x000A8440
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 323759, RefRangeEnd = 323772, XrefRangeStart = 323759, XrefRangeEnd = 323772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000AA27C File Offset: 0x000A847C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685524, XrefRangeEnd = 685528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000AA2D0 File Offset: 0x000A84D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685528, XrefRangeEnd = 685529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LocalKeyword rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000AA328 File Offset: 0x000A8528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685529, XrefRangeEnd = 685531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0000FC79 File Offset: 0x0000DE79
		public LocalKeyword(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0000FC82 File Offset: 0x0000DE82
		public LocalKeyword()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
		{
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x000AA36C File Offset: 0x000A856C
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x0000FC94 File Offset: 0x0000DE94
		public unsafe LocalKeywordSpace m_SpaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo)) = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000AA394 File Offset: 0x000A8594
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x0000FCAF File Offset: 0x0000DEAF
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000AA3BC File Offset: 0x000A85BC
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x0000FCCE File Offset: 0x0000DECE
		public unsafe uint m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0000FCE9 File Offset: 0x0000DEE9
		public static bool IsDynamic(LocalKeyword kw)
		{
			return LocalKeyword.IsDynamic_Injected(ref kw);
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0000FCF2 File Offset: 0x0000DEF2
		public static bool IsOverridable(LocalKeyword kw)
		{
			return LocalKeyword.IsOverridable_Injected(ref kw);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0000FCFB File Offset: 0x0000DEFB
		public static uint GetComputeShaderKeywordCount(ComputeShader shader)
		{
			return LocalKeyword.GetComputeShaderKeywordCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0000FD0D File Offset: 0x0000DF0D
		public static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword)
		{
			return LocalKeyword.GetComputeShaderKeywordIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0000FD25 File Offset: 0x0000DF25
		public static ShaderKeywordType GetKeywordType(LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.GetKeywordType_Injected(ref spaceInfo, keyword);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0000FD2F File Offset: 0x0000DF2F
		public static bool IsValid(LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.IsValid_Injected(ref spaceInfo, keyword);
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000AA3E4 File Offset: 0x000A85E4
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x000AA3FC File Offset: 0x000A85FC
		public unsafe bool isDynamic
		{
			get
			{
				return LocalKeyword.IsDynamic(*this);
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000AA41C File Offset: 0x000A861C
		public unsafe bool isOverridable
		{
			get
			{
				return LocalKeyword.IsOverridable(*this);
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x000AA43C File Offset: 0x000A863C
		public bool isValid
		{
			get
			{
				return LocalKeyword.IsValid(this.m_SpaceInfo, this.m_Index);
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000AA460 File Offset: 0x000A8660
		public ShaderKeywordType type
		{
			get
			{
				return LocalKeyword.GetKeywordType(this.m_SpaceInfo, this.m_Index);
			}
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000AA484 File Offset: 0x000A8684
		public static bool operator ==(LocalKeyword lhs, LocalKeyword rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000AA4A0 File Offset: 0x000A86A0
		public static bool operator !=(LocalKeyword lhs, LocalKeyword rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000AA4BC File Offset: 0x000A86BC
		public unsafe static bool IsDynamic_Injected(ref LocalKeyword kw)
		{
			LocalKeyword.IsDynamic_InjectedDelegate isDynamic_InjectedDelegateField = LocalKeyword.IsDynamic_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(kw);
			return isDynamic_InjectedDelegateField(&intPtr);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000AA4E0 File Offset: 0x000A86E0
		public unsafe static bool IsOverridable_Injected(ref LocalKeyword kw)
		{
			LocalKeyword.IsOverridable_InjectedDelegate isOverridable_InjectedDelegateField = LocalKeyword.IsOverridable_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(kw);
			return isOverridable_InjectedDelegateField(&intPtr);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0000FD39 File Offset: 0x0000DF39
		public static ShaderKeywordType GetKeywordType_Injected(ref LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.GetKeywordType_InjectedDelegateField(ref spaceInfo, keyword);
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0000FD47 File Offset: 0x0000DF47
		public static bool IsValid_Injected(ref LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.IsValid_InjectedDelegateField(ref spaceInfo, keyword);
		}

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeFieldInfoPtr_m_SpaceInfo;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002447 RID: 9287
		private static readonly LocalKeyword.GetComputeShaderKeywordCountDelegate GetComputeShaderKeywordCountDelegateField;

		// Token: 0x04002448 RID: 9288
		private static readonly LocalKeyword.GetComputeShaderKeywordIndexDelegate GetComputeShaderKeywordIndexDelegateField;

		// Token: 0x04002449 RID: 9289
		private static readonly LocalKeyword.IsDynamic_InjectedDelegate IsDynamic_InjectedDelegateField;

		// Token: 0x0400244A RID: 9290
		private static readonly LocalKeyword.IsOverridable_InjectedDelegate IsOverridable_InjectedDelegateField;

		// Token: 0x0400244B RID: 9291
		private static readonly LocalKeyword.GetKeywordType_InjectedDelegate GetKeywordType_InjectedDelegateField;

		// Token: 0x0400244C RID: 9292
		private static readonly LocalKeyword.IsValid_InjectedDelegate IsValid_InjectedDelegateField;

		// Token: 0x020009ED RID: 2541
		// (Invoke) Token: 0x06003CF7 RID: 15607
		private delegate uint GetComputeShaderKeywordCountDelegate(IntPtr shader);

		// Token: 0x020009EE RID: 2542
		// (Invoke) Token: 0x06003CF9 RID: 15609
		private delegate uint GetComputeShaderKeywordIndexDelegate(IntPtr shader, IntPtr keyword);

		// Token: 0x020009EF RID: 2543
		// (Invoke) Token: 0x06003CFB RID: 15611
		private delegate bool IsDynamic_InjectedDelegate(IntPtr kw);

		// Token: 0x020009F0 RID: 2544
		// (Invoke) Token: 0x06003CFD RID: 15613
		private delegate bool IsOverridable_InjectedDelegate(IntPtr kw);

		// Token: 0x020009F1 RID: 2545
		// (Invoke) Token: 0x06003CFF RID: 15615
		private delegate ShaderKeywordType GetKeywordType_InjectedDelegate(IntPtr spaceInfo, uint keyword);

		// Token: 0x020009F2 RID: 2546
		// (Invoke) Token: 0x06003D01 RID: 15617
		private delegate bool IsValid_InjectedDelegate(IntPtr spaceInfo, uint keyword);
	}
}
