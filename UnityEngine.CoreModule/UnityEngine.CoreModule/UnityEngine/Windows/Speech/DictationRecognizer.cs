using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000195 RID: 405
	public sealed class DictationRecognizer : Object
	{
		// Token: 0x06001E5E RID: 7774 RVA: 0x00089028 File Offset: 0x00087228
		// Note: this type is marked as 'beforefieldinit'.
		static DictationRecognizer()
		{
			Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "DictationRecognizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr);
			DictationRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "m_Recognizer");
			DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesis");
			DictationRecognizer.NativeFieldInfoPtr_DictationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResult");
			DictationRecognizer.NativeFieldInfoPtr_DictationComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationComplete");
			DictationRecognizer.NativeFieldInfoPtr_DictationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationError");
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100667482);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100667483);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100667484);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100667485);
			DictationRecognizer.CreateDelegateField = IL2CPP.ResolveICall<DictationRecognizer.CreateDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Create");
			DictationRecognizer.StartDelegateField = IL2CPP.ResolveICall<DictationRecognizer.StartDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Start");
			DictationRecognizer.StopDelegateField = IL2CPP.ResolveICall<DictationRecognizer.StopDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Stop");
			DictationRecognizer.DestroyDelegateField = IL2CPP.ResolveICall<DictationRecognizer.DestroyDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Destroy");
			DictationRecognizer.DestroyThreadedDelegateField = IL2CPP.ResolveICall<DictationRecognizer.DestroyThreadedDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::DestroyThreaded");
			DictationRecognizer.GetStatusDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetStatusDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetStatus");
			DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetAutoSilenceTimeoutSeconds");
			DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::SetAutoSilenceTimeoutSeconds");
			DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetInitialSilenceTimeoutSeconds");
			DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::SetInitialSilenceTimeoutSeconds");
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000891A4 File Offset: 0x000873A4
		[CallerCount(0)]
		public unsafe void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000891E8 File Offset: 0x000873E8
		[CallerCount(0)]
		public unsafe void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumConfidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00089238 File Offset: 0x00087438
		[CallerCount(0)]
		public unsafe void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cause;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00089278 File Offset: 0x00087478
		[CallerCount(0)]
		public unsafe void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0000B6F6 File Offset: 0x000098F6
		public DictationRecognizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000892C8 File Offset: 0x000874C8
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0000B6FF File Offset: 0x000098FF
		public unsafe IntPtr m_Recognizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000892F0 File Offset: 0x000874F0
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0000B71A File Offset: 0x0000991A
		public unsafe DictationRecognizer.DictationHypothesisDelegate DictationHypothesis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationHypothesisDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00089320 File Offset: 0x00087520
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0000B739 File Offset: 0x00009939
		public unsafe DictationRecognizer.DictationResultDelegate DictationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationResultDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x00089350 File Offset: 0x00087550
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0000B758 File Offset: 0x00009958
		public unsafe DictationRecognizer.DictationCompletedDelegate DictationComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationCompletedDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x00089380 File Offset: 0x00087580
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0000B777 File Offset: 0x00009977
		public unsafe DictationRecognizer.DictationErrorHandler DictationError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationErrorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0000B796 File Offset: 0x00009996
		public static IntPtr Create(Object self, ConfidenceLevel minimumConfidence, DictationTopicConstraint topicConstraint)
		{
			return DictationRecognizer.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), minimumConfidence, topicConstraint);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0000B7AA File Offset: 0x000099AA
		public static void Start(IntPtr self)
		{
			DictationRecognizer.StartDelegateField(self);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0000B7B7 File Offset: 0x000099B7
		public static void Stop(IntPtr self)
		{
			DictationRecognizer.StopDelegateField(self);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0000B7C4 File Offset: 0x000099C4
		public static void Destroy(IntPtr self)
		{
			DictationRecognizer.DestroyDelegateField(self);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0000B7D1 File Offset: 0x000099D1
		public static void DestroyThreaded(IntPtr self)
		{
			DictationRecognizer.DestroyThreadedDelegateField(self);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0000B7DE File Offset: 0x000099DE
		public static SpeechSystemStatus GetStatus(IntPtr self)
		{
			return DictationRecognizer.GetStatusDelegateField(self);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0000B7EB File Offset: 0x000099EB
		public static float GetAutoSilenceTimeoutSeconds(IntPtr self)
		{
			return DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegateField(self);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0000B7F8 File Offset: 0x000099F8
		public static void SetAutoSilenceTimeoutSeconds(IntPtr self, float value)
		{
			DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegateField(self, value);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0000B806 File Offset: 0x00009A06
		public static float GetInitialSilenceTimeoutSeconds(IntPtr self)
		{
			return DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegateField(self);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0000B813 File Offset: 0x00009A13
		public static void SetInitialSilenceTimeoutSeconds(IntPtr self, float value)
		{
			DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegateField(self, value);
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0000B821 File Offset: 0x00009A21
		public void add_DictationHypothesis(DictationRecognizer.DictationHypothesisDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0000B82E File Offset: 0x00009A2E
		public void remove_DictationHypothesis(DictationRecognizer.DictationHypothesisDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0000B83B File Offset: 0x00009A3B
		public void add_DictationResult(DictationRecognizer.DictationResultDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0000B848 File Offset: 0x00009A48
		public void remove_DictationResult(DictationRecognizer.DictationResultDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0000B855 File Offset: 0x00009A55
		public void add_DictationComplete(DictationRecognizer.DictationCompletedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0000B862 File Offset: 0x00009A62
		public void remove_DictationComplete(DictationRecognizer.DictationCompletedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0000B86F File Offset: 0x00009A6F
		public void add_DictationError(DictationRecognizer.DictationErrorHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0000B87C File Offset: 0x00009A7C
		public void remove_DictationError(DictationRecognizer.DictationErrorHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x000893B0 File Offset: 0x000875B0
		public SpeechSystemStatus Status
		{
			get
			{
				return (this.m_Recognizer != IntPtr.Zero) ? DictationRecognizer.GetStatus(this.m_Recognizer) : SpeechSystemStatus.Stopped;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x000893E4 File Offset: 0x000875E4
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x00089420 File Offset: 0x00087620
		public float AutoSilenceTimeoutSeconds
		{
			get
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				float num;
				if (flag)
				{
					num = 0f;
				}
				else
				{
					num = DictationRecognizer.GetAutoSilenceTimeoutSeconds(this.m_Recognizer);
				}
				return num;
			}
			set
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				if (!flag)
				{
					DictationRecognizer.SetAutoSilenceTimeoutSeconds(this.m_Recognizer, value);
				}
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x00089454 File Offset: 0x00087654
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x00089490 File Offset: 0x00087690
		public float InitialSilenceTimeoutSeconds
		{
			get
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				float num;
				if (flag)
				{
					num = 0f;
				}
				else
				{
					num = DictationRecognizer.GetInitialSilenceTimeoutSeconds(this.m_Recognizer);
				}
				return num;
			}
			set
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				if (!flag)
				{
					DictationRecognizer.SetInitialSilenceTimeoutSeconds(this.m_Recognizer, value);
				}
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000894C4 File Offset: 0x000876C4
		public override void Finalize()
		{
			try
			{
				bool flag = this.m_Recognizer != IntPtr.Zero;
				if (flag)
				{
					DictationRecognizer.DestroyThreaded(this.m_Recognizer);
					this.m_Recognizer = IntPtr.Zero;
					GC.SuppressFinalize(this);
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00089524 File Offset: 0x00087724
		public void Start()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				DictationRecognizer.Start(this.m_Recognizer);
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00089554 File Offset: 0x00087754
		public void Stop()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				DictationRecognizer.Stop(this.m_Recognizer);
			}
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00089584 File Offset: 0x00087784
		public void Dispose()
		{
			bool flag = this.m_Recognizer != IntPtr.Zero;
			if (flag)
			{
				DictationRecognizer.Destroy(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeFieldInfoPtr_m_Recognizer;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeFieldInfoPtr_DictationHypothesis;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_DictationResult;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeFieldInfoPtr_DictationComplete;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeFieldInfoPtr_DictationError;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly DictationRecognizer.CreateDelegate CreateDelegateField;

		// Token: 0x04001AA3 RID: 6819
		private static readonly DictationRecognizer.StartDelegate StartDelegateField;

		// Token: 0x04001AA4 RID: 6820
		private static readonly DictationRecognizer.StopDelegate StopDelegateField;

		// Token: 0x04001AA5 RID: 6821
		private static readonly DictationRecognizer.DestroyDelegate DestroyDelegateField;

		// Token: 0x04001AA6 RID: 6822
		private static readonly DictationRecognizer.DestroyThreadedDelegate DestroyThreadedDelegateField;

		// Token: 0x04001AA7 RID: 6823
		private static readonly DictationRecognizer.GetStatusDelegate GetStatusDelegateField;

		// Token: 0x04001AA8 RID: 6824
		private static readonly DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegate GetAutoSilenceTimeoutSecondsDelegateField;

		// Token: 0x04001AA9 RID: 6825
		private static readonly DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegate SetAutoSilenceTimeoutSecondsDelegateField;

		// Token: 0x04001AAA RID: 6826
		private static readonly DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegate GetInitialSilenceTimeoutSecondsDelegateField;

		// Token: 0x04001AAB RID: 6827
		private static readonly DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegate SetInitialSilenceTimeoutSecondsDelegateField;

		// Token: 0x0200084D RID: 2125
		public sealed class DictationHypothesisDelegate : MulticastDelegate
		{
			// Token: 0x0600395B RID: 14683 RVA: 0x000142BA File Offset: 0x000124BA
			// Note: this type is marked as 'beforefieldinit'.
			static DictationHypothesisDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesisDelegate");
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100667486);
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100667487);
			}

			// Token: 0x0600395C RID: 14684 RVA: 0x000BD3AC File Offset: 0x000BB5AC
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationHypothesisDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600395D RID: 14685 RVA: 0x000BD408 File Offset: 0x000BB608
			[CallerCount(0)]
			public unsafe void Invoke(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600395E RID: 14686 RVA: 0x000142F8 File Offset: 0x000124F8
			public DictationHypothesisDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600395F RID: 14687 RVA: 0x00014301 File Offset: 0x00012501
			public static implicit operator DictationRecognizer.DictationHypothesisDelegate(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationHypothesisDelegate>(A_0);
			}

			// Token: 0x06003960 RID: 14688 RVA: 0x00014309 File Offset: 0x00012509
			public static DictationRecognizer.DictationHypothesisDelegate operator +(DictationRecognizer.DictationHypothesisDelegate A_0, DictationRecognizer.DictationHypothesisDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationHypothesisDelegate>();
			}

			// Token: 0x06003961 RID: 14689 RVA: 0x00014317 File Offset: 0x00012517
			public static DictationRecognizer.DictationHypothesisDelegate operator -(DictationRecognizer.DictationHypothesisDelegate A_0, DictationRecognizer.DictationHypothesisDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationHypothesisDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002CC4 RID: 11460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CC5 RID: 11461
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;
		}

		// Token: 0x0200084E RID: 2126
		public sealed class DictationResultDelegate : MulticastDelegate
		{
			// Token: 0x06003962 RID: 14690 RVA: 0x00014328 File Offset: 0x00012528
			// Note: this type is marked as 'beforefieldinit'.
			static DictationResultDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResultDelegate");
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100667488);
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100667489);
			}

			// Token: 0x06003963 RID: 14691 RVA: 0x000BD44C File Offset: 0x000BB64C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 426984, RefRangeEnd = 426986, XrefRangeStart = 426984, XrefRangeEnd = 426986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationResultDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003964 RID: 14692 RVA: 0x000BD4A8 File Offset: 0x000BB6A8
			[CallerCount(0)]
			public unsafe void Invoke(string text, ConfidenceLevel confidence)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003965 RID: 14693 RVA: 0x00014366 File Offset: 0x00012566
			public DictationResultDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003966 RID: 14694 RVA: 0x0001436F File Offset: 0x0001256F
			public static implicit operator DictationRecognizer.DictationResultDelegate(Action<string, ConfidenceLevel> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationResultDelegate>(A_0);
			}

			// Token: 0x06003967 RID: 14695 RVA: 0x00014377 File Offset: 0x00012577
			public static DictationRecognizer.DictationResultDelegate operator +(DictationRecognizer.DictationResultDelegate A_0, DictationRecognizer.DictationResultDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationResultDelegate>();
			}

			// Token: 0x06003968 RID: 14696 RVA: 0x00014385 File Offset: 0x00012585
			public static DictationRecognizer.DictationResultDelegate operator -(DictationRecognizer.DictationResultDelegate A_0, DictationRecognizer.DictationResultDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationResultDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002CC6 RID: 11462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CC7 RID: 11463
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0;
		}

		// Token: 0x0200084F RID: 2127
		public sealed class DictationCompletedDelegate : MulticastDelegate
		{
			// Token: 0x06003969 RID: 14697 RVA: 0x00014396 File Offset: 0x00012596
			// Note: this type is marked as 'beforefieldinit'.
			static DictationCompletedDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationCompletedDelegate");
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100667490);
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100667491);
			}

			// Token: 0x0600396A RID: 14698 RVA: 0x000BD4F8 File Offset: 0x000BB6F8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 677799, RefRangeEnd = 677853, XrefRangeStart = 677799, XrefRangeEnd = 677853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationCompletedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600396B RID: 14699 RVA: 0x000BD554 File Offset: 0x000BB754
			[CallerCount(0)]
			public unsafe void Invoke(DictationCompletionCause cause)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref cause;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600396C RID: 14700 RVA: 0x000143D4 File Offset: 0x000125D4
			public DictationCompletedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600396D RID: 14701 RVA: 0x000143DD File Offset: 0x000125DD
			public static implicit operator DictationRecognizer.DictationCompletedDelegate(Action<DictationCompletionCause> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationCompletedDelegate>(A_0);
			}

			// Token: 0x0600396E RID: 14702 RVA: 0x000143E5 File Offset: 0x000125E5
			public static DictationRecognizer.DictationCompletedDelegate operator +(DictationRecognizer.DictationCompletedDelegate A_0, DictationRecognizer.DictationCompletedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationCompletedDelegate>();
			}

			// Token: 0x0600396F RID: 14703 RVA: 0x000143F3 File Offset: 0x000125F3
			public static DictationRecognizer.DictationCompletedDelegate operator -(DictationRecognizer.DictationCompletedDelegate A_0, DictationRecognizer.DictationCompletedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationCompletedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002CC8 RID: 11464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CC9 RID: 11465
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0;
		}

		// Token: 0x02000850 RID: 2128
		public sealed class DictationErrorHandler : MulticastDelegate
		{
			// Token: 0x06003970 RID: 14704 RVA: 0x00014404 File Offset: 0x00012604
			// Note: this type is marked as 'beforefieldinit'.
			static DictationErrorHandler()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationErrorHandler");
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100667492);
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100667493);
			}

			// Token: 0x06003971 RID: 14705 RVA: 0x000BD594 File Offset: 0x000BB794
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 426984, RefRangeEnd = 426986, XrefRangeStart = 426984, XrefRangeEnd = 426986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationErrorHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003972 RID: 14706 RVA: 0x000BD5F0 File Offset: 0x000BB7F0
			[CallerCount(0)]
			public unsafe void Invoke(string error, int hresult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003973 RID: 14707 RVA: 0x00014442 File Offset: 0x00012642
			public DictationErrorHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003974 RID: 14708 RVA: 0x0001444B File Offset: 0x0001264B
			public static implicit operator DictationRecognizer.DictationErrorHandler(Action<string, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationErrorHandler>(A_0);
			}

			// Token: 0x06003975 RID: 14709 RVA: 0x00014453 File Offset: 0x00012653
			public static DictationRecognizer.DictationErrorHandler operator +(DictationRecognizer.DictationErrorHandler A_0, DictationRecognizer.DictationErrorHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationErrorHandler>();
			}

			// Token: 0x06003976 RID: 14710 RVA: 0x00014461 File Offset: 0x00012661
			public static DictationRecognizer.DictationErrorHandler operator -(DictationRecognizer.DictationErrorHandler A_0, DictationRecognizer.DictationErrorHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationErrorHandler>();
				}
				return delegate2;
			}

			// Token: 0x04002CCA RID: 11466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CCB RID: 11467
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0;
		}

		// Token: 0x02000851 RID: 2129
		// (Invoke) Token: 0x06003978 RID: 14712
		private delegate IntPtr CreateDelegate(IntPtr self, ConfidenceLevel minimumConfidence, DictationTopicConstraint topicConstraint);

		// Token: 0x02000852 RID: 2130
		// (Invoke) Token: 0x0600397A RID: 14714
		private delegate void StartDelegate(IntPtr self);

		// Token: 0x02000853 RID: 2131
		// (Invoke) Token: 0x0600397C RID: 14716
		private delegate void StopDelegate(IntPtr self);

		// Token: 0x02000854 RID: 2132
		// (Invoke) Token: 0x0600397E RID: 14718
		private delegate void DestroyDelegate(IntPtr self);

		// Token: 0x02000855 RID: 2133
		// (Invoke) Token: 0x06003980 RID: 14720
		private delegate void DestroyThreadedDelegate(IntPtr self);

		// Token: 0x02000856 RID: 2134
		// (Invoke) Token: 0x06003982 RID: 14722
		private delegate SpeechSystemStatus GetStatusDelegate(IntPtr self);

		// Token: 0x02000857 RID: 2135
		// (Invoke) Token: 0x06003984 RID: 14724
		private delegate float GetAutoSilenceTimeoutSecondsDelegate(IntPtr self);

		// Token: 0x02000858 RID: 2136
		// (Invoke) Token: 0x06003986 RID: 14726
		private delegate void SetAutoSilenceTimeoutSecondsDelegate(IntPtr self, float value);

		// Token: 0x02000859 RID: 2137
		// (Invoke) Token: 0x06003988 RID: 14728
		private delegate float GetInitialSilenceTimeoutSecondsDelegate(IntPtr self);

		// Token: 0x0200085A RID: 2138
		// (Invoke) Token: 0x0600398A RID: 14730
		private delegate void SetInitialSilenceTimeoutSecondsDelegate(IntPtr self, float value);
	}
}
