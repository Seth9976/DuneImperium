using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.CSharp;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000B2 RID: 178
	public class CodeIdentifier : Object
	{
		// Token: 0x0600124C RID: 4684 RVA: 0x00067008 File Offset: 0x00065208
		// Note: this type is marked as 'beforefieldinit'.
		static CodeIdentifier()
		{
			Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "CodeIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr);
			CodeIdentifier.NativeFieldInfoPtr_csharp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, "csharp");
			CodeIdentifier.NativeMethodInfoPtr_MakePascal_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, 100666325);
			CodeIdentifier.NativeMethodInfoPtr_MakeValid_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, 100666326);
			CodeIdentifier.NativeMethodInfoPtr_IsValidStart_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, 100666327);
			CodeIdentifier.NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, 100666328);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0006709C File Offset: 0x0006529C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383607, XrefRangeEnd = 383641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakePascal(string identifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeIdentifier.NativeMethodInfoPtr_MakePascal_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x000670D8 File Offset: 0x000652D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383641, XrefRangeEnd = 383664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeValid(string identifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeIdentifier.NativeMethodInfoPtr_MakeValid_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00067114 File Offset: 0x00065314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383668, RefRangeEnd = 383670, XrefRangeStart = 383664, XrefRangeEnd = 383668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidStart(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeIdentifier.NativeMethodInfoPtr_IsValidStart_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00067154 File Offset: 0x00065354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383670, XrefRangeEnd = 383674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeIdentifier.NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00007BC8 File Offset: 0x00005DC8
		public CodeIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00067194 File Offset: 0x00065394
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x00007BD1 File Offset: 0x00005DD1
		public unsafe static CodeDomProvider csharp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CodeIdentifier.NativeFieldInfoPtr_csharp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodeDomProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodeIdentifier.NativeFieldInfoPtr_csharp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeFieldInfoPtr_csharp;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_MakePascal_Public_Static_String_String_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_MakeValid_Public_Static_String_String_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_IsValidStart_Private_Static_Boolean_Char_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Char_0;
	}
}
