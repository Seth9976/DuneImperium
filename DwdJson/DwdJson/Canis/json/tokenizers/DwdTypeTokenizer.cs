using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using JsonFx.Serialization;
using JsonFx.Serialization.GraphCycles;

namespace Canis.json.tokenizers
{
	// Token: 0x0200001A RID: 26
	public class DwdTypeTokenizer : Object
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00005C38 File Offset: 0x00003E38
		// Note: this type is marked as 'beforefieldinit'.
		static DwdTypeTokenizer()
		{
			Il2CppClassPointerStore<DwdTypeTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json.tokenizers", "DwdTypeTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdTypeTokenizer>.NativeClassPtr);
			DwdTypeTokenizer.NativeFieldInfoPtr_TokenizedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdTypeTokenizer>.NativeClassPtr, "TokenizedTypes");
			DwdTypeTokenizer.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdTypeTokenizer>.NativeClassPtr, 100663406);
			DwdTypeTokenizer.NativeMethodInfoPtr_Tokenize_Public_Abstract_Virtual_New_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdTypeTokenizer>.NativeClassPtr, 100663407);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005CA4 File Offset: 0x00003EA4
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdTypeTokenizer(Il2CppReferenceArray<Type> tokenizedTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdTypeTokenizer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizedTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdTypeTokenizer.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005CF0 File Offset: 0x00003EF0
		[CallerCount(0)]
		public unsafe virtual bool Tokenize(DwdModelWalker walker, ICycleDetector detector, List<Token> tokens, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(walker);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdTypeTokenizer.NativeMethodInfoPtr_Tokenize_Public_Abstract_Virtual_New_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000025AC File Offset: 0x000007AC
		public DwdTypeTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00005D80 File Offset: 0x00003F80
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000025B5 File Offset: 0x000007B5
		public unsafe Il2CppReferenceArray<Type> TokenizedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdTypeTokenizer.NativeFieldInfoPtr_TokenizedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdTypeTokenizer.NativeFieldInfoPtr_TokenizedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_TokenizedTypes;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Public_Abstract_Virtual_New_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0;
	}
}
