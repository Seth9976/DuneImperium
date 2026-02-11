using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000257 RID: 599
	[StructLayout(2)]
	public struct ShaderKeywordSet
	{
		// Token: 0x06002914 RID: 10516 RVA: 0x000AACEC File Offset: 0x000A8EEC
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderKeywordSet()
		{
			Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderKeywordSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr);
			ShaderKeywordSet.NativeFieldInfoPtr_m_KeywordState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_KeywordState");
			ShaderKeywordSet.NativeFieldInfoPtr_m_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_Shader");
			ShaderKeywordSet.NativeFieldInfoPtr_m_ComputeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_ComputeShader");
			ShaderKeywordSet.NativeFieldInfoPtr_m_StateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_StateIndex");
			ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100668498);
			ShaderKeywordSet.NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100668499);
			ShaderKeywordSet.NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100668500);
			ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100668501);
			ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::IsGlobalKeywordEnabled_Injected");
			ShaderKeywordSet.IsKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.IsKeywordEnabled_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::IsKeywordEnabled_Injected");
			ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::EnableGlobalKeyword_Injected");
			ShaderKeywordSet.EnableKeywordName_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.EnableKeywordName_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::EnableKeywordName_Injected");
			ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::DisableGlobalKeyword_Injected");
			ShaderKeywordSet.DisableKeywordName_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.DisableKeywordName_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::DisableKeywordName_Injected");
			ShaderKeywordSet.GetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.GetEnabledKeywords_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::GetEnabledKeywords_Injected");
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000AAE28 File Offset: 0x000A9028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685556, XrefRangeEnd = 685558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeywordNameEnabled(ShaderKeywordSet state, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000AAE78 File Offset: 0x000A9078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685558, XrefRangeEnd = 685567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckKeywordCompatible(ShaderKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000AAEB4 File Offset: 0x000A90B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 685578, RefRangeEnd = 685582, XrefRangeStart = 685567, XrefRangeEnd = 685578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabled(ShaderKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000AAEFC File Offset: 0x000A90FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685582, XrefRangeEnd = 685584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeywordNameEnabled_Injected(ref ShaderKeywordSet state, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0000FE93 File Offset: 0x0000E093
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, ref this));
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0000FEA5 File Offset: 0x0000E0A5
		public static bool IsGlobalKeywordEnabled(ShaderKeywordSet state, uint index)
		{
			return ShaderKeywordSet.IsGlobalKeywordEnabled_Injected(ref state, index);
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x0000FEAF File Offset: 0x0000E0AF
		public static bool IsKeywordEnabled(ShaderKeywordSet state, LocalKeywordSpace keywordSpace, uint index)
		{
			return ShaderKeywordSet.IsKeywordEnabled_Injected(ref state, ref keywordSpace, index);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x0000FEBB File Offset: 0x0000E0BB
		public static void EnableGlobalKeyword(ShaderKeywordSet state, uint index)
		{
			ShaderKeywordSet.EnableGlobalKeyword_Injected(ref state, index);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0000FEC5 File Offset: 0x0000E0C5
		public static void EnableKeywordName(ShaderKeywordSet state, string name)
		{
			ShaderKeywordSet.EnableKeywordName_Injected(ref state, name);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0000FECF File Offset: 0x0000E0CF
		public static void DisableGlobalKeyword(ShaderKeywordSet state, uint index)
		{
			ShaderKeywordSet.DisableGlobalKeyword_Injected(ref state, index);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0000FED9 File Offset: 0x0000E0D9
		public static void DisableKeywordName(ShaderKeywordSet state, string name)
		{
			ShaderKeywordSet.DisableKeywordName_Injected(ref state, name);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x0000FEE3 File Offset: 0x0000E0E3
		public static Il2CppReferenceArray<ShaderKeyword> GetEnabledKeywords(ShaderKeywordSet state)
		{
			return ShaderKeywordSet.GetEnabledKeywords_Injected(ref state);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000AAF4C File Offset: 0x000A914C
		public bool IsEnabled(GlobalKeyword keyword)
		{
			return ShaderKeywordSet.IsGlobalKeywordEnabled(this, keyword.m_Index);
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000AAF70 File Offset: 0x000A9170
		public bool IsEnabled(LocalKeyword keyword)
		{
			return ShaderKeywordSet.IsKeywordEnabled(this, keyword.m_SpaceInfo, keyword.m_Index);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000AAF9C File Offset: 0x000A919C
		public void Enable(ShaderKeyword keyword)
		{
			this.CheckKeywordCompatible(keyword);
			bool flag = keyword.m_IsLocal || !keyword.IsValid();
			if (flag)
			{
				ShaderKeywordSet.EnableKeywordName(this, keyword.m_Name);
			}
			else
			{
				ShaderKeywordSet.EnableGlobalKeyword(this, keyword.m_Index);
			}
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000AAFF4 File Offset: 0x000A91F4
		public void Disable(ShaderKeyword keyword)
		{
			bool flag = keyword.m_IsLocal || !keyword.IsValid();
			if (flag)
			{
				ShaderKeywordSet.DisableKeywordName(this, keyword.m_Name);
			}
			else
			{
				ShaderKeywordSet.DisableGlobalKeyword(this, keyword.m_Index);
			}
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000AB044 File Offset: 0x000A9244
		public Il2CppReferenceArray<ShaderKeyword> GetShaderKeywords()
		{
			return ShaderKeywordSet.GetEnabledKeywords(this);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		public static bool IsGlobalKeywordEnabled_Injected(ref ShaderKeywordSet state, uint index)
		{
			return ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegateField(ref state, index);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0000FEFA File Offset: 0x0000E0FA
		public static bool IsKeywordEnabled_Injected(ref ShaderKeywordSet state, ref LocalKeywordSpace keywordSpace, uint index)
		{
			return ShaderKeywordSet.IsKeywordEnabled_InjectedDelegateField(ref state, ref keywordSpace, index);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0000FF09 File Offset: 0x0000E109
		public static void EnableGlobalKeyword_Injected(ref ShaderKeywordSet state, uint index)
		{
			ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegateField(ref state, index);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0000FF17 File Offset: 0x0000E117
		public static void EnableKeywordName_Injected(ref ShaderKeywordSet state, string name)
		{
			ShaderKeywordSet.EnableKeywordName_InjectedDelegateField(ref state, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0000FF2A File Offset: 0x0000E12A
		public static void DisableGlobalKeyword_Injected(ref ShaderKeywordSet state, uint index)
		{
			ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegateField(ref state, index);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0000FF38 File Offset: 0x0000E138
		public static void DisableKeywordName_Injected(ref ShaderKeywordSet state, string name)
		{
			ShaderKeywordSet.DisableKeywordName_InjectedDelegateField(ref state, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000AB064 File Offset: 0x000A9264
		public static Il2CppReferenceArray<ShaderKeyword> GetEnabledKeywords_Injected(ref ShaderKeywordSet state)
		{
			IntPtr intPtr = ShaderKeywordSet.GetEnabledKeywords_InjectedDelegateField(ref state);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShaderKeyword>>(intPtr2) : null;
		}

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeFieldInfoPtr_m_KeywordState;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeFieldInfoPtr_m_Shader;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeFieldInfoPtr_m_ComputeShader;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeFieldInfoPtr_m_StateIndex;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_String_0;

		// Token: 0x0400246F RID: 9327
		[FieldOffset(0)]
		public IntPtr m_KeywordState;

		// Token: 0x04002470 RID: 9328
		[FieldOffset(8)]
		public IntPtr m_Shader;

		// Token: 0x04002471 RID: 9329
		[FieldOffset(16)]
		public IntPtr m_ComputeShader;

		// Token: 0x04002472 RID: 9330
		[FieldOffset(24)]
		public ulong m_StateIndex;

		// Token: 0x04002473 RID: 9331
		private static readonly ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegate IsGlobalKeywordEnabled_InjectedDelegateField;

		// Token: 0x04002474 RID: 9332
		private static readonly ShaderKeywordSet.IsKeywordEnabled_InjectedDelegate IsKeywordEnabled_InjectedDelegateField;

		// Token: 0x04002475 RID: 9333
		private static readonly ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegate EnableGlobalKeyword_InjectedDelegateField;

		// Token: 0x04002476 RID: 9334
		private static readonly ShaderKeywordSet.EnableKeywordName_InjectedDelegate EnableKeywordName_InjectedDelegateField;

		// Token: 0x04002477 RID: 9335
		private static readonly ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegate DisableGlobalKeyword_InjectedDelegateField;

		// Token: 0x04002478 RID: 9336
		private static readonly ShaderKeywordSet.DisableKeywordName_InjectedDelegate DisableKeywordName_InjectedDelegateField;

		// Token: 0x04002479 RID: 9337
		private static readonly ShaderKeywordSet.GetEnabledKeywords_InjectedDelegate GetEnabledKeywords_InjectedDelegateField;

		// Token: 0x020009FC RID: 2556
		// (Invoke) Token: 0x06003D15 RID: 15637
		private delegate bool IsGlobalKeywordEnabled_InjectedDelegate(IntPtr state, uint index);

		// Token: 0x020009FD RID: 2557
		// (Invoke) Token: 0x06003D17 RID: 15639
		private delegate bool IsKeywordEnabled_InjectedDelegate(IntPtr state, IntPtr keywordSpace, uint index);

		// Token: 0x020009FE RID: 2558
		// (Invoke) Token: 0x06003D19 RID: 15641
		private delegate void EnableGlobalKeyword_InjectedDelegate(IntPtr state, uint index);

		// Token: 0x020009FF RID: 2559
		// (Invoke) Token: 0x06003D1B RID: 15643
		private delegate void EnableKeywordName_InjectedDelegate(IntPtr state, IntPtr name);

		// Token: 0x02000A00 RID: 2560
		// (Invoke) Token: 0x06003D1D RID: 15645
		private delegate void DisableGlobalKeyword_InjectedDelegate(IntPtr state, uint index);

		// Token: 0x02000A01 RID: 2561
		// (Invoke) Token: 0x06003D1F RID: 15647
		private delegate void DisableKeywordName_InjectedDelegate(IntPtr state, IntPtr name);

		// Token: 0x02000A02 RID: 2562
		// (Invoke) Token: 0x06003D21 RID: 15649
		private delegate IntPtr GetEnabledKeywords_InjectedDelegate(IntPtr state);
	}
}
