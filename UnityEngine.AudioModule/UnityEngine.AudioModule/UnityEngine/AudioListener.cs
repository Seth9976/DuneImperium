using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public sealed class AudioListener : AudioBehaviour
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003D1C File Offset: 0x00001F1C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioListener()
		{
			Il2CppClassPointerStore<AudioListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioListener>.NativeClassPtr);
			AudioListener.NativeMethodInfoPtr_GetOutputDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663313);
			AudioListener.NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663314);
			AudioListener.NativeMethodInfoPtr_get_volume_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663315);
			AudioListener.NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663316);
			AudioListener.NativeMethodInfoPtr_get_pause_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663317);
			AudioListener.NativeMethodInfoPtr_set_pause_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663318);
			AudioListener.NativeMethodInfoPtr_get_velocityUpdateMode_Public_get_AudioVelocityUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663319);
			AudioListener.NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663320);
			AudioListener.NativeMethodInfoPtr_GetOutputData_Public_Static_Il2CppStructArray_1_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663321);
			AudioListener.NativeMethodInfoPtr_GetOutputData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663322);
			AudioListener.NativeMethodInfoPtr_GetSpectrumData_Public_Static_Il2CppStructArray_1_Single_Int32_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663323);
			AudioListener.NativeMethodInfoPtr_GetSpectrumData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663324);
			AudioListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663325);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003E50 File Offset: 0x00002050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258931, XrefRangeEnd = 1258933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetOutputDataHelper([Out] Il2CppStructArray<float> samples, int channel)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_GetOutputDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*samples = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003EA4 File Offset: 0x000020A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258933, XrefRangeEnd = 1258935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSpectrumDataHelper([Out] Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref window;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*samples = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003F08 File Offset: 0x00002108
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00003F38 File Offset: 0x00002138
		public unsafe static float volume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258935, XrefRangeEnd = 1258937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_get_volume_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258937, XrefRangeEnd = 1258939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003F6C File Offset: 0x0000216C
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00003F9C File Offset: 0x0000219C
		public unsafe static bool pause
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258939, XrefRangeEnd = 1258941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_get_pause_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258941, XrefRangeEnd = 1258943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_set_pause_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003FD0 File Offset: 0x000021D0
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000400C File Offset: 0x0000220C
		public unsafe AudioVelocityUpdateMode velocityUpdateMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258943, XrefRangeEnd = 1258945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_get_velocityUpdateMode_Public_get_AudioVelocityUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258945, XrefRangeEnd = 1258947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000404C File Offset: 0x0000224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258947, XrefRangeEnd = 1258952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> GetOutputData(int numSamples, int channel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numSamples;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_GetOutputData_Public_Static_Il2CppStructArray_1_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000409C File Offset: 0x0000229C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetOutputData(Il2CppStructArray<float> samples, int channel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(samples);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_GetOutputData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000040E0 File Offset: 0x000022E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258952, XrefRangeEnd = 1258957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numSamples;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_GetSpectrumData_Public_Static_Il2CppStructArray_1_Single_Int32_Int32_FFTWindow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000413C File Offset: 0x0000233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSpectrumData(Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(samples);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_GetSpectrumData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004190 File Offset: 0x00002390
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000232C File Offset: 0x0000052C
		public AudioListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_volume_Public_Static_get_Single_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_pause_Public_Static_get_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_set_pause_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_get_velocityUpdateMode_Public_get_AudioVelocityUpdateMode_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputData_Public_Static_Il2CppStructArray_1_Single_Int32_Int32_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumData_Public_Static_Il2CppStructArray_1_Single_Int32_Int32_FFTWindow_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
