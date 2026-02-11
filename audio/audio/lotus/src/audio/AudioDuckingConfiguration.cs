using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace lotus.src.audio
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class AudioDuckingConfiguration : Object
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00003C74 File Offset: 0x00001E74
		// Note: this type is marked as 'beforefieldinit'.
		static AudioDuckingConfiguration()
		{
			Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio", "AudioDuckingConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr);
			AudioDuckingConfiguration.NativeFieldInfoPtr_categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, "categoryName");
			AudioDuckingConfiguration.NativeFieldInfoPtr_duckPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, "duckPercent");
			AudioDuckingConfiguration.NativeFieldInfoPtr_duckDownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, "duckDownDuration");
			AudioDuckingConfiguration.NativeFieldInfoPtr_duckUpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, "duckUpDuration");
			AudioDuckingConfiguration.NativeMethodInfoPtr_get_CategoryName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663336);
			AudioDuckingConfiguration.NativeMethodInfoPtr_set_CategoryName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663337);
			AudioDuckingConfiguration.NativeMethodInfoPtr_get_DuckPercent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663338);
			AudioDuckingConfiguration.NativeMethodInfoPtr_set_DuckPercent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663339);
			AudioDuckingConfiguration.NativeMethodInfoPtr_get_DuckDownDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663340);
			AudioDuckingConfiguration.NativeMethodInfoPtr_set_DuckDownDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663341);
			AudioDuckingConfiguration.NativeMethodInfoPtr_get_DuckUpDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663342);
			AudioDuckingConfiguration.NativeMethodInfoPtr_set_DuckUpDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663343);
			AudioDuckingConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr, 100663344);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003DA8 File Offset: 0x00001FA8
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00003DE0 File Offset: 0x00001FE0
		public unsafe string CategoryName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr_get_CategoryName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr_set_CategoryName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00003E24 File Offset: 0x00002024
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00003E60 File Offset: 0x00002060
		public unsafe float DuckPercent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr_get_DuckPercent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr_set_DuckPercent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00003EDC File Offset: 0x000020DC
		public unsafe float DuckDownDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr_get_DuckDownDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 604702, RefRangeEnd = 604705, XrefRangeStart = 604702, XrefRangeEnd = 604705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr_set_DuckDownDuration_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00003F1C File Offset: 0x0000211C
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00003F58 File Offset: 0x00002158
		public unsafe float DuckUpDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr_get_DuckUpDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr_set_DuckUpDuration_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003F98 File Offset: 0x00002198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261508, XrefRangeEnd = 1261512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioDuckingConfiguration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioDuckingConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioDuckingConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002360 File Offset: 0x00000560
		public AudioDuckingConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003FD4 File Offset: 0x000021D4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002369 File Offset: 0x00000569
		public unsafe string categoryName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioDuckingConfiguration.NativeFieldInfoPtr_categoryName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioDuckingConfiguration.NativeFieldInfoPtr_categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003FFC File Offset: 0x000021FC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002388 File Offset: 0x00000588
		public unsafe float duckPercent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioDuckingConfiguration.NativeFieldInfoPtr_duckPercent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioDuckingConfiguration.NativeFieldInfoPtr_duckPercent)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004024 File Offset: 0x00002224
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000023A3 File Offset: 0x000005A3
		public unsafe float duckDownDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioDuckingConfiguration.NativeFieldInfoPtr_duckDownDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioDuckingConfiguration.NativeFieldInfoPtr_duckDownDuration)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000404C File Offset: 0x0000224C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000023BE File Offset: 0x000005BE
		public unsafe float duckUpDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioDuckingConfiguration.NativeFieldInfoPtr_duckUpDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioDuckingConfiguration.NativeFieldInfoPtr_duckUpDuration)) = value;
			}
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_categoryName;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_duckPercent;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_duckDownDuration;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_duckUpDuration;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_CategoryName_Public_get_String_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_set_CategoryName_Protected_set_Void_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_DuckPercent_Public_get_Single_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_set_DuckPercent_Public_set_Void_Single_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_DuckDownDuration_Public_get_Single_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_set_DuckDownDuration_Public_set_Void_Single_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_DuckUpDuration_Public_get_Single_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_set_DuckUpDuration_Public_set_Void_Single_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
