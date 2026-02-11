using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000007 RID: 7
public class AudioFader : Object
{
	// Token: 0x060000E7 RID: 231 RVA: 0x0001718C File Offset: 0x0001538C
	// Note: this type is marked as 'beforefieldinit'.
	static AudioFader()
	{
		Il2CppClassPointerStore<AudioFader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AudioFader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioFader>.NativeClassPtr);
		AudioFader.NativeFieldInfoPtr__fadeOutTotalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, "_fadeOutTotalTime");
		AudioFader.NativeFieldInfoPtr__fadeOutStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, "_fadeOutStartTime");
		AudioFader.NativeFieldInfoPtr__fadeInTotalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, "_fadeInTotalTime");
		AudioFader.NativeFieldInfoPtr__fadeInStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, "_fadeInStartTime");
		AudioFader.NativeFieldInfoPtr__time_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, "<time>k__BackingField");
		AudioFader.NativeMethodInfoPtr_get_time_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663434);
		AudioFader.NativeMethodInfoPtr_set_time_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663435);
		AudioFader.NativeMethodInfoPtr_get_isFadingOutComplete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663436);
		AudioFader.NativeMethodInfoPtr_get_isFadingOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663437);
		AudioFader.NativeMethodInfoPtr_get_isFadingOutOrScheduled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663438);
		AudioFader.NativeMethodInfoPtr_get_isFadingIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663439);
		AudioFader.NativeMethodInfoPtr_Set0_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663440);
		AudioFader.NativeMethodInfoPtr_FadeIn_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663441);
		AudioFader.NativeMethodInfoPtr_FadeIn_Public_Void_Single_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663442);
		AudioFader.NativeMethodInfoPtr_FadeOut_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663443);
		AudioFader.NativeMethodInfoPtr_Get_Public_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663444);
		AudioFader.NativeMethodInfoPtr__GetFadeOutValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663445);
		AudioFader.NativeMethodInfoPtr__GetFadeInValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663446);
		AudioFader.NativeMethodInfoPtr__GetFadeValue_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663447);
		AudioFader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioFader>.NativeClassPtr, 100663448);
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000E8 RID: 232 RVA: 0x0001734C File Offset: 0x0001554C
	// (set) Token: 0x060000E9 RID: 233 RVA: 0x00017388 File Offset: 0x00015588
	public unsafe double time
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_get_time_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_set_time_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000EA RID: 234 RVA: 0x000173C8 File Offset: 0x000155C8
	public unsafe bool isFadingOutComplete
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_get_isFadingOutComplete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000EB RID: 235 RVA: 0x00017404 File Offset: 0x00015604
	public unsafe bool isFadingOut
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_get_isFadingOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060000EC RID: 236 RVA: 0x00017440 File Offset: 0x00015640
	public unsafe bool isFadingOutOrScheduled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_get_isFadingOutOrScheduled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060000ED RID: 237 RVA: 0x0001747C File Offset: 0x0001567C
	public unsafe bool isFadingIn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_get_isFadingIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000EE RID: 238 RVA: 0x000174B8 File Offset: 0x000156B8
	[CallerCount(0)]
	public unsafe void Set0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_Set0_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x000174EC File Offset: 0x000156EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852099, XrefRangeEnd = 852100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FadeIn(float fadeInTime, bool stopCurrentFadeOut = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeInTime;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopCurrentFadeOut;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_FadeIn_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00017538 File Offset: 0x00015738
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 852102, RefRangeEnd = 852104, XrefRangeStart = 852100, XrefRangeEnd = 852102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FadeIn(float fadeInTime, double startToFadeTime, bool stopCurrentFadeOut = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeInTime;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startToFadeTime;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopCurrentFadeOut;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_FadeIn_Public_Void_Single_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00017594 File Offset: 0x00015794
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852104, RefRangeEnd = 852105, XrefRangeStart = 852104, XrefRangeEnd = 852104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FadeOut(float fadeOutLength, float startToFadeTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutLength;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startToFadeTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_FadeOut_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000175E0 File Offset: 0x000157E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852107, RefRangeEnd = 852108, XrefRangeStart = 852105, XrefRangeEnd = 852107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Get(out bool finishedFadeOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = &finishedFadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr_Get_Public_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0001762C File Offset: 0x0001582C
	[CallerCount(0)]
	public unsafe float _GetFadeOutValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr__GetFadeOutValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00017668 File Offset: 0x00015868
	[CallerCount(0)]
	public unsafe float _GetFadeInValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr__GetFadeInValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x000176A4 File Offset: 0x000158A4
	[CallerCount(0)]
	public unsafe float _GetFadeValue(float t, float dt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dt;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr__GetFadeValue_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x000176FC File Offset: 0x000158FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852108, XrefRangeEnd = 852109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioFader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioFader>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioFader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000250C File Offset: 0x0000070C
	public AudioFader(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x00017738 File Offset: 0x00015938
	// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002515 File Offset: 0x00000715
	public unsafe float _fadeOutTotalTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__fadeOutTotalTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__fadeOutTotalTime)) = value;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000FA RID: 250 RVA: 0x00017760 File Offset: 0x00015960
	// (set) Token: 0x060000FB RID: 251 RVA: 0x00002530 File Offset: 0x00000730
	public unsafe double _fadeOutStartTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__fadeOutStartTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__fadeOutStartTime)) = value;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000FC RID: 252 RVA: 0x00017788 File Offset: 0x00015988
	// (set) Token: 0x060000FD RID: 253 RVA: 0x0000254B File Offset: 0x0000074B
	public unsafe float _fadeInTotalTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__fadeInTotalTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__fadeInTotalTime)) = value;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000FE RID: 254 RVA: 0x000177B0 File Offset: 0x000159B0
	// (set) Token: 0x060000FF RID: 255 RVA: 0x00002566 File Offset: 0x00000766
	public unsafe double _fadeInStartTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__fadeInStartTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__fadeInStartTime)) = value;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000100 RID: 256 RVA: 0x000177D8 File Offset: 0x000159D8
	// (set) Token: 0x06000101 RID: 257 RVA: 0x00002581 File Offset: 0x00000781
	public unsafe double _time_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__time_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioFader.NativeFieldInfoPtr__time_k__BackingField)) = value;
		}
	}

	// Token: 0x040000B3 RID: 179
	private static readonly IntPtr NativeFieldInfoPtr__fadeOutTotalTime;

	// Token: 0x040000B4 RID: 180
	private static readonly IntPtr NativeFieldInfoPtr__fadeOutStartTime;

	// Token: 0x040000B5 RID: 181
	private static readonly IntPtr NativeFieldInfoPtr__fadeInTotalTime;

	// Token: 0x040000B6 RID: 182
	private static readonly IntPtr NativeFieldInfoPtr__fadeInStartTime;

	// Token: 0x040000B7 RID: 183
	private static readonly IntPtr NativeFieldInfoPtr__time_k__BackingField;

	// Token: 0x040000B8 RID: 184
	private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Double_0;

	// Token: 0x040000B9 RID: 185
	private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Double_0;

	// Token: 0x040000BA RID: 186
	private static readonly IntPtr NativeMethodInfoPtr_get_isFadingOutComplete_Public_get_Boolean_0;

	// Token: 0x040000BB RID: 187
	private static readonly IntPtr NativeMethodInfoPtr_get_isFadingOut_Public_get_Boolean_0;

	// Token: 0x040000BC RID: 188
	private static readonly IntPtr NativeMethodInfoPtr_get_isFadingOutOrScheduled_Public_get_Boolean_0;

	// Token: 0x040000BD RID: 189
	private static readonly IntPtr NativeMethodInfoPtr_get_isFadingIn_Public_get_Boolean_0;

	// Token: 0x040000BE RID: 190
	private static readonly IntPtr NativeMethodInfoPtr_Set0_Public_Void_0;

	// Token: 0x040000BF RID: 191
	private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Public_Void_Single_Boolean_0;

	// Token: 0x040000C0 RID: 192
	private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Public_Void_Single_Double_Boolean_0;

	// Token: 0x040000C1 RID: 193
	private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Public_Void_Single_Single_0;

	// Token: 0x040000C2 RID: 194
	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Single_byref_Boolean_0;

	// Token: 0x040000C3 RID: 195
	private static readonly IntPtr NativeMethodInfoPtr__GetFadeOutValue_Private_Single_0;

	// Token: 0x040000C4 RID: 196
	private static readonly IntPtr NativeMethodInfoPtr__GetFadeInValue_Private_Single_0;

	// Token: 0x040000C5 RID: 197
	private static readonly IntPtr NativeMethodInfoPtr__GetFadeValue_Private_Single_Single_Single_0;

	// Token: 0x040000C6 RID: 198
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
