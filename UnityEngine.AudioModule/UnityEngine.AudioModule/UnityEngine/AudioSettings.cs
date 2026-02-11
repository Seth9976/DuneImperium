using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public sealed class AudioSettings : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00003420 File Offset: 0x00001620
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSettings()
		{
			Il2CppClassPointerStore<AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr);
			AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioConfigurationChanged");
			AudioSettings.NativeFieldInfoPtr_OnAudioSystemShuttingDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioSystemShuttingDown");
			AudioSettings.NativeFieldInfoPtr_OnAudioSystemStartedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioSystemStartedUp");
			AudioSettings.NativeMethodInfoPtr_get_dspTime_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663297);
			AudioSettings.NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663298);
			AudioSettings.NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663299);
			AudioSettings.NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663300);
			AudioSettings.GetSpeakerModeDelegateField = IL2CPP.ResolveICall<AudioSettings.GetSpeakerModeDelegate>("UnityEngine.AudioSettings::GetSpeakerMode");
			AudioSettings.GetSampleRateDelegateField = IL2CPP.ResolveICall<AudioSettings.GetSampleRateDelegate>("UnityEngine.AudioSettings::GetSampleRate");
			AudioSettings.get_driverCapabilitiesDelegateField = IL2CPP.ResolveICall<AudioSettings.get_driverCapabilitiesDelegate>("UnityEngine.AudioSettings::get_driverCapabilities");
			AudioSettings.get_profilerCaptureFlagsDelegateField = IL2CPP.ResolveICall<AudioSettings.get_profilerCaptureFlagsDelegate>("UnityEngine.AudioSettings::get_profilerCaptureFlags");
			AudioSettings.GetDSPBufferSizeDelegateField = IL2CPP.ResolveICall<AudioSettings.GetDSPBufferSizeDelegate>("UnityEngine.AudioSettings::GetDSPBufferSize");
			AudioSettings.GetSpatializerPluginNameDelegateField = IL2CPP.ResolveICall<AudioSettings.GetSpatializerPluginNameDelegate>("UnityEngine.AudioSettings::GetSpatializerPluginName");
			AudioSettings.get_unityAudioDisabledDelegateField = IL2CPP.ResolveICall<AudioSettings.get_unityAudioDisabledDelegate>("UnityEngine.AudioSettings::get_unityAudioDisabled");
			AudioSettings.set_unityAudioDisabledDelegateField = IL2CPP.ResolveICall<AudioSettings.set_unityAudioDisabledDelegate>("UnityEngine.AudioSettings::set_unityAudioDisabled");
			AudioSettings.GetAmbisonicDecoderPluginNameDelegateField = IL2CPP.ResolveICall<AudioSettings.GetAmbisonicDecoderPluginNameDelegate>("UnityEngine.AudioSettings::GetAmbisonicDecoderPluginName");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00003564 File Offset: 0x00001764
		public unsafe static double dspTime
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1258907, RefRangeEnd = 1258912, XrefRangeStart = 1258905, XrefRangeEnd = 1258907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_get_dspTime_Public_Static_get_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00003594 File Offset: 0x00001794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258912, XrefRangeEnd = 1258914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceWasChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000035C8 File Offset: 0x000017C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258914, XrefRangeEnd = 1258916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnAudioSystemShuttingDown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000035F0 File Offset: 0x000017F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258916, XrefRangeEnd = 1258918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnAudioSystemStartedUp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		public AudioSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00003618 File Offset: 0x00001818
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettings.AudioConfigurationChangeHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00003640 File Offset: 0x00001840
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static Action OnAudioSystemShuttingDown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioSettings.NativeFieldInfoPtr_OnAudioSystemShuttingDown, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSettings.NativeFieldInfoPtr_OnAudioSystemShuttingDown, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00003668 File Offset: 0x00001868
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe static Action OnAudioSystemStartedUp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioSettings.NativeFieldInfoPtr_OnAudioSystemStartedUp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSettings.NativeFieldInfoPtr_OnAudioSystemStartedUp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000208F File Offset: 0x0000028F
		public static AudioSpeakerMode GetSpeakerMode()
		{
			return AudioSettings.GetSpeakerModeDelegateField();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000209B File Offset: 0x0000029B
		public static int GetSampleRate()
		{
			return AudioSettings.GetSampleRateDelegateField();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020A7 File Offset: 0x000002A7
		public static AudioSpeakerMode driverCapabilities
		{
			get
			{
				return AudioSettings.get_driverCapabilitiesDelegateField();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00003690 File Offset: 0x00001890
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020B3 File Offset: 0x000002B3
		public static AudioSpeakerMode speakerMode
		{
			get
			{
				return AudioSettings.GetSpeakerMode();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020C0 File Offset: 0x000002C0
		public static int profilerCaptureFlags
		{
			get
			{
				return AudioSettings.get_profilerCaptureFlagsDelegateField();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000036A8 File Offset: 0x000018A8
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020CC File Offset: 0x000002CC
		public static int outputSampleRate
		{
			get
			{
				return AudioSettings.GetSampleRate();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020D9 File Offset: 0x000002D9
		public static void GetDSPBufferSize(out int bufferLength, out int numBuffers)
		{
			AudioSettings.GetDSPBufferSizeDelegateField(out bufferLength, out numBuffers);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
		public static void SetDSPBufferSize(int bufferLength, int numBuffers)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000036C0 File Offset: 0x000018C0
		public static string GetSpatializerPluginName()
		{
			IntPtr intPtr = AudioSettings.GetSpatializerPluginNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020F4 File Offset: 0x000002F4
		public static void add_OnAudioConfigurationChanged(AudioSettings.AudioConfigurationChangeHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002101 File Offset: 0x00000301
		public static void remove_OnAudioConfigurationChanged(AudioSettings.AudioConfigurationChangeHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000210E File Offset: 0x0000030E
		public static void add_OnAudioSystemShuttingDown(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000211B File Offset: 0x0000031B
		public static void remove_OnAudioSystemShuttingDown(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002128 File Offset: 0x00000328
		public static void add_OnAudioSystemStartedUp(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002135 File Offset: 0x00000335
		public static void remove_OnAudioSystemStartedUp(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002142 File Offset: 0x00000342
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000214E File Offset: 0x0000034E
		public static bool unityAudioDisabled
		{
			get
			{
				return AudioSettings.get_unityAudioDisabledDelegateField();
			}
			set
			{
				AudioSettings.set_unityAudioDisabledDelegateField(value);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000036E0 File Offset: 0x000018E0
		public static string GetAmbisonicDecoderPluginName()
		{
			IntPtr intPtr = AudioSettings.GetAmbisonicDecoderPluginNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003700 File Offset: 0x00001900
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000215B File Offset: 0x0000035B
		public static AudioSpatialExperience audioSpatialExperience
		{
			get
			{
				return AudioSpatialExperience.Bypassed;
			}
			set
			{
				Debug.LogWarning("AudioSettings.audioSpatialExperience is not implemented on this platform.");
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_OnAudioConfigurationChanged;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_OnAudioSystemShuttingDown;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_OnAudioSystemStartedUp;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_dspTime_Public_Static_get_Double_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0;

		// Token: 0x0400001C RID: 28
		private static readonly AudioSettings.GetSpeakerModeDelegate GetSpeakerModeDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly AudioSettings.GetSampleRateDelegate GetSampleRateDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly AudioSettings.get_driverCapabilitiesDelegate get_driverCapabilitiesDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly AudioSettings.get_profilerCaptureFlagsDelegate get_profilerCaptureFlagsDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly AudioSettings.GetDSPBufferSizeDelegate GetDSPBufferSizeDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly AudioSettings.GetSpatializerPluginNameDelegate GetSpatializerPluginNameDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly AudioSettings.get_unityAudioDisabledDelegate get_unityAudioDisabledDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly AudioSettings.set_unityAudioDisabledDelegate set_unityAudioDisabledDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly AudioSettings.GetAmbisonicDecoderPluginNameDelegate GetAmbisonicDecoderPluginNameDelegateField;

		// Token: 0x0200002D RID: 45
		public sealed class AudioConfigurationChangeHandler : MulticastDelegate
		{
			// Token: 0x06000214 RID: 532 RVA: 0x00003268 File Offset: 0x00001468
			// Note: this type is marked as 'beforefieldinit'.
			static AudioConfigurationChangeHandler()
			{
				Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "AudioConfigurationChangeHandler");
				AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr, 100663301);
				AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr, 100663302);
			}

			// Token: 0x06000215 RID: 533 RVA: 0x00008438 File Offset: 0x00006638
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 679310, RefRangeEnd = 679355, XrefRangeStart = 679310, XrefRangeEnd = 679355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AudioConfigurationChangeHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000216 RID: 534 RVA: 0x00008494 File Offset: 0x00006694
			[CallerCount(0)]
			public unsafe void Invoke(bool deviceWasChanged)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref deviceWasChanged;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000217 RID: 535 RVA: 0x000032A6 File Offset: 0x000014A6
			public AudioConfigurationChangeHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000218 RID: 536 RVA: 0x000032AF File Offset: 0x000014AF
			public static implicit operator AudioSettings.AudioConfigurationChangeHandler(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioSettings.AudioConfigurationChangeHandler>(A_0);
			}

			// Token: 0x06000219 RID: 537 RVA: 0x000032B7 File Offset: 0x000014B7
			public static AudioSettings.AudioConfigurationChangeHandler operator +(AudioSettings.AudioConfigurationChangeHandler A_0, AudioSettings.AudioConfigurationChangeHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioSettings.AudioConfigurationChangeHandler>();
			}

			// Token: 0x0600021A RID: 538 RVA: 0x000032C5 File Offset: 0x000014C5
			public static AudioSettings.AudioConfigurationChangeHandler operator -(AudioSettings.AudioConfigurationChangeHandler A_0, AudioSettings.AudioConfigurationChangeHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioSettings.AudioConfigurationChangeHandler>();
				}
				return delegate2;
			}

			// Token: 0x040001C4 RID: 452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001C5 RID: 453
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;
		}

		// Token: 0x0200002E RID: 46
		public static class Mobile
		{
		}

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate AudioSpeakerMode GetSpeakerModeDelegate();

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate int GetSampleRateDelegate();

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate AudioSpeakerMode get_driverCapabilitiesDelegate();

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate int get_profilerCaptureFlagsDelegate();

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000224 RID: 548
		private delegate void GetDSPBufferSizeDelegate([Out] IntPtr bufferLength, [Out] IntPtr numBuffers);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000226 RID: 550
		private delegate IntPtr GetSpatializerPluginNameDelegate();

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000228 RID: 552
		private delegate bool get_unityAudioDisabledDelegate();

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x0600022A RID: 554
		private delegate void set_unityAudioDisabledDelegate(bool value);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600022C RID: 556
		private delegate IntPtr GetAmbisonicDecoderPluginNameDelegate();
	}
}
