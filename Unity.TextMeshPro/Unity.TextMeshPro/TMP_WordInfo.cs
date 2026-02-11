using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000018 RID: 24
	public sealed class TMP_WordInfo : ValueType
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00012168 File Offset: 0x00010368
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_WordInfo()
		{
			Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_WordInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr);
			TMP_WordInfo.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "textComponent");
			TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "firstCharacterIndex");
			TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "lastCharacterIndex");
			TMP_WordInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "characterCount");
			TMP_WordInfo.NativeMethodInfoPtr_GetWord_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, 100663577);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000121FC File Offset: 0x000103FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037942, XrefRangeEnd = 1037949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_WordInfo.NativeMethodInfoPtr_GetWord_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002E44 File Offset: 0x00001044
		public TMP_WordInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002E4D File Offset: 0x0000104D
		public TMP_WordInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00012238 File Offset: 0x00010438
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002E5F File Offset: 0x0000105F
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00012268 File Offset: 0x00010468
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002E7E File Offset: 0x0000107E
		public unsafe int firstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00012290 File Offset: 0x00010490
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002E99 File Offset: 0x00001099
		public unsafe int lastCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000122B8 File Offset: 0x000104B8
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00002EB4 File Offset: 0x000010B4
		public unsafe int characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_characterCount)) = value;
			}
		}

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_GetWord_Public_String_0;
	}
}
