using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200019B RID: 411
	public sealed class PhraseRecognizedEventArgs : ValueType
	{
		// Token: 0x06001E90 RID: 7824 RVA: 0x00089678 File Offset: 0x00087878
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognizedEventArgs()
		{
			Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr);
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "confidence");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "semanticMeanings");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "text");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseStartTime");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseDuration");
			PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, 100667494);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00089720 File Offset: 0x00087920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677886, XrefRangeEnd = 677888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(semanticMeanings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseStartTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0000B8E2 File Offset: 0x00009AE2
		public PhraseRecognizedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0000B8EB File Offset: 0x00009AEB
		public PhraseRecognizedEventArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x000897AC File Offset: 0x000879AC
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x0000B8FD File Offset: 0x00009AFD
		public unsafe ConfidenceLevel confidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence)) = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000897D4 File Offset: 0x000879D4
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0000B918 File Offset: 0x00009B18
		public unsafe Il2CppReferenceArray<SemanticMeaning> semanticMeanings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00089804 File Offset: 0x00087A04
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0000B937 File Offset: 0x00009B37
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x0008982C File Offset: 0x00087A2C
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x0000B956 File Offset: 0x00009B56
		public unsafe DateTime phraseStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime)) = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x00089854 File Offset: 0x00087A54
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x0000B971 File Offset: 0x00009B71
		public unsafe TimeSpan phraseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration)) = value;
			}
		}

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_confidence;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeFieldInfoPtr_semanticMeanings;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeFieldInfoPtr_phraseStartTime;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeFieldInfoPtr_phraseDuration;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0;
	}
}
