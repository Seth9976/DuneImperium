using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000193 RID: 403
	public static class PhraseRecognitionSystem : Object
	{
		// Token: 0x06001E38 RID: 7736 RVA: 0x00088B4C File Offset: 0x00086D4C
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognitionSystem()
		{
			Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognitionSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr);
			PhraseRecognitionSystem.NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnError");
			PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnStatusChanged");
			PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100667472);
			PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100667473);
			PhraseRecognitionSystem.get_isSupportedDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.get_isSupportedDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::get_isSupported");
			PhraseRecognitionSystem.get_StatusDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.get_StatusDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::get_Status");
			PhraseRecognitionSystem.RestartDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.RestartDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::Restart");
			PhraseRecognitionSystem.ShutdownDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.ShutdownDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::Shutdown");
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00088C08 File Offset: 0x00086E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677853, XrefRangeEnd = 677855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00088C3C File Offset: 0x00086E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677855, XrefRangeEnd = 677857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0000B595 File Offset: 0x00009795
		public PhraseRecognitionSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00088C70 File Offset: 0x00086E70
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x0000B59E File Offset: 0x0000979E
		public unsafe static PhraseRecognitionSystem.ErrorDelegate OnError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognitionSystem.ErrorDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00088C98 File Offset: 0x00086E98
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x0000B5B0 File Offset: 0x000097B0
		public unsafe static PhraseRecognitionSystem.StatusDelegate OnStatusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognitionSystem.StatusDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0000B5C2 File Offset: 0x000097C2
		public static bool isSupported
		{
			get
			{
				return PhraseRecognitionSystem.get_isSupportedDelegateField();
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0000B5CE File Offset: 0x000097CE
		public static SpeechSystemStatus Status
		{
			get
			{
				return PhraseRecognitionSystem.get_StatusDelegateField();
			}
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0000B5DA File Offset: 0x000097DA
		public static void Restart()
		{
			PhraseRecognitionSystem.RestartDelegateField();
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0000B5E6 File Offset: 0x000097E6
		public static void Shutdown()
		{
			PhraseRecognitionSystem.ShutdownDelegateField();
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0000B5F2 File Offset: 0x000097F2
		public static void add_OnError(PhraseRecognitionSystem.ErrorDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0000B5FF File Offset: 0x000097FF
		public static void remove_OnError(PhraseRecognitionSystem.ErrorDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0000B60C File Offset: 0x0000980C
		public static void add_OnStatusChanged(PhraseRecognitionSystem.StatusDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0000B619 File Offset: 0x00009819
		public static void remove_OnStatusChanged(PhraseRecognitionSystem.StatusDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeFieldInfoPtr_OnError;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeFieldInfoPtr_OnStatusChanged;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly PhraseRecognitionSystem.get_isSupportedDelegate get_isSupportedDelegateField;

		// Token: 0x04001A8B RID: 6795
		private static readonly PhraseRecognitionSystem.get_StatusDelegate get_StatusDelegateField;

		// Token: 0x04001A8C RID: 6796
		private static readonly PhraseRecognitionSystem.RestartDelegate RestartDelegateField;

		// Token: 0x04001A8D RID: 6797
		private static readonly PhraseRecognitionSystem.ShutdownDelegate ShutdownDelegateField;

		// Token: 0x0200083F RID: 2111
		public sealed class ErrorDelegate : MulticastDelegate
		{
			// Token: 0x06003930 RID: 14640 RVA: 0x00014170 File Offset: 0x00012370
			// Note: this type is marked as 'beforefieldinit'.
			static ErrorDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "ErrorDelegate");
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100667474);
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100667475);
			}

			// Token: 0x06003931 RID: 14641 RVA: 0x000BD1D0 File Offset: 0x000BB3D0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 677799, RefRangeEnd = 677853, XrefRangeStart = 677796, XrefRangeEnd = 677799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003932 RID: 14642 RVA: 0x000BD22C File Offset: 0x000BB42C
			[CallerCount(0)]
			public unsafe void Invoke(SpeechError errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref errorCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003933 RID: 14643 RVA: 0x000141AE File Offset: 0x000123AE
			public ErrorDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003934 RID: 14644 RVA: 0x000141B7 File Offset: 0x000123B7
			public static implicit operator PhraseRecognitionSystem.ErrorDelegate(Action<SpeechError> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.ErrorDelegate>(A_0);
			}

			// Token: 0x06003935 RID: 14645 RVA: 0x000141BF File Offset: 0x000123BF
			public static PhraseRecognitionSystem.ErrorDelegate operator +(PhraseRecognitionSystem.ErrorDelegate A_0, PhraseRecognitionSystem.ErrorDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognitionSystem.ErrorDelegate>();
			}

			// Token: 0x06003936 RID: 14646 RVA: 0x000141CD File Offset: 0x000123CD
			public static PhraseRecognitionSystem.ErrorDelegate operator -(PhraseRecognitionSystem.ErrorDelegate A_0, PhraseRecognitionSystem.ErrorDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhraseRecognitionSystem.ErrorDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002CBE RID: 11454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CBF RID: 11455
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0;
		}

		// Token: 0x02000840 RID: 2112
		public sealed class StatusDelegate : MulticastDelegate
		{
			// Token: 0x06003937 RID: 14647 RVA: 0x000141DE File Offset: 0x000123DE
			// Note: this type is marked as 'beforefieldinit'.
			static StatusDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "StatusDelegate");
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100667476);
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100667477);
			}

			// Token: 0x06003938 RID: 14648 RVA: 0x000BD26C File Offset: 0x000BB46C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 677799, RefRangeEnd = 677853, XrefRangeStart = 677799, XrefRangeEnd = 677853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StatusDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003939 RID: 14649 RVA: 0x000BD2C8 File Offset: 0x000BB4C8
			[CallerCount(0)]
			public unsafe void Invoke(SpeechSystemStatus status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref status;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600393A RID: 14650 RVA: 0x0001421C File Offset: 0x0001241C
			public StatusDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600393B RID: 14651 RVA: 0x00014225 File Offset: 0x00012425
			public static implicit operator PhraseRecognitionSystem.StatusDelegate(Action<SpeechSystemStatus> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.StatusDelegate>(A_0);
			}

			// Token: 0x0600393C RID: 14652 RVA: 0x0001422D File Offset: 0x0001242D
			public static PhraseRecognitionSystem.StatusDelegate operator +(PhraseRecognitionSystem.StatusDelegate A_0, PhraseRecognitionSystem.StatusDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognitionSystem.StatusDelegate>();
			}

			// Token: 0x0600393D RID: 14653 RVA: 0x0001423B File Offset: 0x0001243B
			public static PhraseRecognitionSystem.StatusDelegate operator -(PhraseRecognitionSystem.StatusDelegate A_0, PhraseRecognitionSystem.StatusDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhraseRecognitionSystem.StatusDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002CC0 RID: 11456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CC1 RID: 11457
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0;
		}

		// Token: 0x02000841 RID: 2113
		// (Invoke) Token: 0x0600393F RID: 14655
		private delegate bool get_isSupportedDelegate();

		// Token: 0x02000842 RID: 2114
		// (Invoke) Token: 0x06003941 RID: 14657
		private delegate SpeechSystemStatus get_StatusDelegate();

		// Token: 0x02000843 RID: 2115
		// (Invoke) Token: 0x06003943 RID: 14659
		private delegate void RestartDelegate();

		// Token: 0x02000844 RID: 2116
		// (Invoke) Token: 0x06003945 RID: 14661
		private delegate void ShutdownDelegate();
	}
}
