using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace TMPro
{
	// Token: 0x02000055 RID: 85
	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x000295A8 File Offset: 0x000277A8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteCharacter()
		{
			Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr);
			TMP_SpriteCharacter.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, "m_Name");
			TMP_SpriteCharacter.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, "m_HashCode");
			TMP_SpriteCharacter.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664370);
			TMP_SpriteCharacter.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664371);
			TMP_SpriteCharacter.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664372);
			TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664373);
			TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664374);
			TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteAsset_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664375);
			TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664376);
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0002968C File Offset: 0x0002788C
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x000296C4 File Offset: 0x000278C4
		public unsafe string name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1046407, RefRangeEnd = 1046408, XrefRangeStart = 1046400, XrefRangeEnd = 1046407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00029708 File Offset: 0x00027908
		public unsafe int hashCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00029744 File Offset: 0x00027944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046408, XrefRangeEnd = 1046409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteCharacter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00029780 File Offset: 0x00027980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046409, XrefRangeEnd = 1046412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000297DC File Offset: 0x000279DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046412, XrefRangeEnd = 1046416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteAsset_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00029848 File Offset: 0x00027A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046416, XrefRangeEnd = 1046419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteCharacter(uint unicode, uint glyphIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000067E2 File Offset: 0x000049E2
		public TMP_SpriteCharacter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000298A0 File Offset: 0x00027AA0
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000067EB File Offset: 0x000049EB
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteCharacter.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteCharacter.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000298C8 File Offset: 0x00027AC8
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x0000680A File Offset: 0x00004A0A
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteCharacter.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteCharacter.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteGlyph_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteAsset_TMP_SpriteGlyph_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0;
	}
}
