using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000194 RID: 404
	public class PhraseRecognizer : Object
	{
		// Token: 0x06001E48 RID: 7752 RVA: 0x00088CC0 File Offset: 0x00086EC0
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognizer()
		{
			Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr);
			PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "m_Recognizer");
			PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "OnPhraseRecognized");
			PhraseRecognizer.NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100667478);
			PhraseRecognizer.NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100667479);
			PhraseRecognizer.CreateFromKeywordsDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.CreateFromKeywordsDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::CreateFromKeywords");
			PhraseRecognizer.CreateFromGrammarFileDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.CreateFromGrammarFileDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::CreateFromGrammarFile");
			PhraseRecognizer.Start_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.Start_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Start_Internal");
			PhraseRecognizer.Stop_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.Stop_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Stop_Internal");
			PhraseRecognizer.IsRunning_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.IsRunning_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::IsRunning_Internal");
			PhraseRecognizer.DestroyDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.DestroyDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Destroy");
			PhraseRecognizer.DestroyThreadedDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.DestroyThreadedDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::DestroyThreaded");
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00088DAC File Offset: 0x00086FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677860, XrefRangeEnd = 677870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, long phraseStartFileTime, long phraseDurationTicks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(semanticMeanings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseStartFileTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseDurationTicks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00088E2C File Offset: 0x0008702C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677870, XrefRangeEnd = 677886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<SemanticMeaning> MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keys;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref values;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueSizes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr3) : null;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x0000B626 File Offset: 0x00009826
		public PhraseRecognizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00088E98 File Offset: 0x00087098
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0000B62F File Offset: 0x0000982F
		public unsafe IntPtr m_Recognizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00088EC0 File Offset: 0x000870C0
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0000B64A File Offset: 0x0000984A
		public unsafe PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognizer.PhraseRecognizedDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0000B669 File Offset: 0x00009869
		public static IntPtr CreateFromKeywords(Object self, Il2CppStringArray keywords, ConfidenceLevel minimumConfidence)
		{
			return PhraseRecognizer.CreateFromKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.Il2CppObjectBaseToPtr(keywords), minimumConfidence);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0000B682 File Offset: 0x00009882
		public static IntPtr CreateFromGrammarFile(Object self, string grammarFilePath, ConfidenceLevel minimumConfidence)
		{
			return PhraseRecognizer.CreateFromGrammarFileDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(grammarFilePath), minimumConfidence);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0000B69B File Offset: 0x0000989B
		public static void Start_Internal(IntPtr recognizer)
		{
			PhraseRecognizer.Start_InternalDelegateField(recognizer);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0000B6A8 File Offset: 0x000098A8
		public static void Stop_Internal(IntPtr recognizer)
		{
			PhraseRecognizer.Stop_InternalDelegateField(recognizer);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0000B6B5 File Offset: 0x000098B5
		public static bool IsRunning_Internal(IntPtr recognizer)
		{
			return PhraseRecognizer.IsRunning_InternalDelegateField(recognizer);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0000B6C2 File Offset: 0x000098C2
		public static void Destroy(IntPtr recognizer)
		{
			PhraseRecognizer.DestroyDelegateField(recognizer);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0000B6CF File Offset: 0x000098CF
		public static void DestroyThreaded(IntPtr recognizer)
		{
			PhraseRecognizer.DestroyThreadedDelegateField(recognizer);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0000B6DC File Offset: 0x000098DC
		public void add_OnPhraseRecognized(PhraseRecognizer.PhraseRecognizedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0000B6E9 File Offset: 0x000098E9
		public void remove_OnPhraseRecognized(PhraseRecognizer.PhraseRecognizedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00088EF0 File Offset: 0x000870F0
		public override void Finalize()
		{
			try
			{
				bool flag = this.m_Recognizer != IntPtr.Zero;
				if (flag)
				{
					PhraseRecognizer.DestroyThreaded(this.m_Recognizer);
					this.m_Recognizer = IntPtr.Zero;
					GC.SuppressFinalize(this);
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00088F50 File Offset: 0x00087150
		public void Start()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				PhraseRecognizer.Start_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00088F80 File Offset: 0x00087180
		public void Stop()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				PhraseRecognizer.Stop_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00088FB0 File Offset: 0x000871B0
		public void Dispose()
		{
			bool flag = this.m_Recognizer != IntPtr.Zero;
			if (flag)
			{
				PhraseRecognizer.Destroy(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00088FF4 File Offset: 0x000871F4
		public bool IsRunning
		{
			get
			{
				return this.m_Recognizer != IntPtr.Zero && PhraseRecognizer.IsRunning_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeFieldInfoPtr_m_Recognizer;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_OnPhraseRecognized;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly PhraseRecognizer.CreateFromKeywordsDelegate CreateFromKeywordsDelegateField;

		// Token: 0x04001A93 RID: 6803
		private static readonly PhraseRecognizer.CreateFromGrammarFileDelegate CreateFromGrammarFileDelegateField;

		// Token: 0x04001A94 RID: 6804
		private static readonly PhraseRecognizer.Start_InternalDelegate Start_InternalDelegateField;

		// Token: 0x04001A95 RID: 6805
		private static readonly PhraseRecognizer.Stop_InternalDelegate Stop_InternalDelegateField;

		// Token: 0x04001A96 RID: 6806
		private static readonly PhraseRecognizer.IsRunning_InternalDelegate IsRunning_InternalDelegateField;

		// Token: 0x04001A97 RID: 6807
		private static readonly PhraseRecognizer.DestroyDelegate DestroyDelegateField;

		// Token: 0x04001A98 RID: 6808
		private static readonly PhraseRecognizer.DestroyThreadedDelegate DestroyThreadedDelegateField;

		// Token: 0x02000845 RID: 2117
		public sealed class PhraseRecognizedDelegate : MulticastDelegate
		{
			// Token: 0x06003946 RID: 14662 RVA: 0x0001424C File Offset: 0x0001244C
			// Note: this type is marked as 'beforefieldinit'.
			static PhraseRecognizedDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "PhraseRecognizedDelegate");
				PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr, 100667480);
				PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr, 100667481);
			}

			// Token: 0x06003947 RID: 14663 RVA: 0x000BD308 File Offset: 0x000BB508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677857, XrefRangeEnd = 677860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PhraseRecognizedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003948 RID: 14664 RVA: 0x000BD364 File Offset: 0x000BB564
			[CallerCount(0)]
			public unsafe void Invoke(PhraseRecognizedEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003949 RID: 14665 RVA: 0x0001428A File Offset: 0x0001248A
			public PhraseRecognizedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600394A RID: 14666 RVA: 0x00014293 File Offset: 0x00012493
			public static implicit operator PhraseRecognizer.PhraseRecognizedDelegate(Action<PhraseRecognizedEventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognizer.PhraseRecognizedDelegate>(A_0);
			}

			// Token: 0x0600394B RID: 14667 RVA: 0x0001429B File Offset: 0x0001249B
			public static PhraseRecognizer.PhraseRecognizedDelegate operator +(PhraseRecognizer.PhraseRecognizedDelegate A_0, PhraseRecognizer.PhraseRecognizedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognizer.PhraseRecognizedDelegate>();
			}

			// Token: 0x0600394C RID: 14668 RVA: 0x000142A9 File Offset: 0x000124A9
			public static PhraseRecognizer.PhraseRecognizedDelegate operator -(PhraseRecognizer.PhraseRecognizedDelegate A_0, PhraseRecognizer.PhraseRecognizedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhraseRecognizer.PhraseRecognizedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002CC2 RID: 11458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CC3 RID: 11459
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0;
		}

		// Token: 0x02000846 RID: 2118
		// (Invoke) Token: 0x0600394E RID: 14670
		private delegate IntPtr CreateFromKeywordsDelegate(IntPtr self, IntPtr keywords, ConfidenceLevel minimumConfidence);

		// Token: 0x02000847 RID: 2119
		// (Invoke) Token: 0x06003950 RID: 14672
		private delegate IntPtr CreateFromGrammarFileDelegate(IntPtr self, IntPtr grammarFilePath, ConfidenceLevel minimumConfidence);

		// Token: 0x02000848 RID: 2120
		// (Invoke) Token: 0x06003952 RID: 14674
		private delegate void Start_InternalDelegate(IntPtr recognizer);

		// Token: 0x02000849 RID: 2121
		// (Invoke) Token: 0x06003954 RID: 14676
		private delegate void Stop_InternalDelegate(IntPtr recognizer);

		// Token: 0x0200084A RID: 2122
		// (Invoke) Token: 0x06003956 RID: 14678
		private delegate bool IsRunning_InternalDelegate(IntPtr recognizer);

		// Token: 0x0200084B RID: 2123
		// (Invoke) Token: 0x06003958 RID: 14680
		private delegate void DestroyDelegate(IntPtr recognizer);

		// Token: 0x0200084C RID: 2124
		// (Invoke) Token: 0x0600395A RID: 14682
		private delegate void DestroyThreadedDelegate(IntPtr recognizer);
	}
}
