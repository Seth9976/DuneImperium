using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x02000024 RID: 36
public class PlayAudioSoundWithDelay : MonoBehaviour
{
	// Token: 0x0600011C RID: 284 RVA: 0x0001418C File Offset: 0x0001238C
	// Note: this type is marked as 'beforefieldinit'.
	static PlayAudioSoundWithDelay()
	{
		Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "PlayAudioSoundWithDelay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr);
		PlayAudioSoundWithDelay.NativeFieldInfoPtr_soundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, "soundName");
		PlayAudioSoundWithDelay.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, "delay");
		PlayAudioSoundWithDelay.NativeFieldInfoPtr_playOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, "playOnEnable");
		PlayAudioSoundWithDelay.NativeFieldInfoPtr_playAtLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, "playAtLocation");
		PlayAudioSoundWithDelay.NativeFieldInfoPtr_stopRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, "stopRequested");
		PlayAudioSoundWithDelay.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, 100663514);
		PlayAudioSoundWithDelay.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, 100663515);
		PlayAudioSoundWithDelay.NativeMethodInfoPtr_play_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, 100663516);
		PlayAudioSoundWithDelay.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, 100663517);
		PlayAudioSoundWithDelay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, 100663518);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00014284 File Offset: 0x00012484
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983345, XrefRangeEnd = 983346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x000142B8 File Offset: 0x000124B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983346, XrefRangeEnd = 983347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x000142EC File Offset: 0x000124EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983347, XrefRangeEnd = 983352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator play()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayAudioSoundWithDelay.NativeMethodInfoPtr_play_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00014338 File Offset: 0x00012538
	[CallerCount(0)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000121 RID: 289 RVA: 0x0001436C File Offset: 0x0001256C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983352, XrefRangeEnd = 983356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayAudioSoundWithDelay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0000281F File Offset: 0x00000A1F
	public PlayAudioSoundWithDelay(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000123 RID: 291 RVA: 0x000143A8 File Offset: 0x000125A8
	// (set) Token: 0x06000124 RID: 292 RVA: 0x00002828 File Offset: 0x00000A28
	public unsafe string soundName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_soundName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_soundName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000125 RID: 293 RVA: 0x000143D0 File Offset: 0x000125D0
	// (set) Token: 0x06000126 RID: 294 RVA: 0x00002847 File Offset: 0x00000A47
	public unsafe float delay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_delay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_delay)) = value;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000127 RID: 295 RVA: 0x000143F8 File Offset: 0x000125F8
	// (set) Token: 0x06000128 RID: 296 RVA: 0x00002862 File Offset: 0x00000A62
	public unsafe bool playOnEnable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_playOnEnable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_playOnEnable)) = value;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000129 RID: 297 RVA: 0x00014420 File Offset: 0x00012620
	// (set) Token: 0x0600012A RID: 298 RVA: 0x0000287D File Offset: 0x00000A7D
	public unsafe bool playAtLocation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_playAtLocation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_playAtLocation)) = value;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600012B RID: 299 RVA: 0x00014448 File Offset: 0x00012648
	// (set) Token: 0x0600012C RID: 300 RVA: 0x00002898 File Offset: 0x00000A98
	public unsafe bool stopRequested
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_stopRequested);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay.NativeFieldInfoPtr_stopRequested)) = value;
		}
	}

	// Token: 0x040000B5 RID: 181
	private static readonly IntPtr NativeFieldInfoPtr_soundName;

	// Token: 0x040000B6 RID: 182
	private static readonly IntPtr NativeFieldInfoPtr_delay;

	// Token: 0x040000B7 RID: 183
	private static readonly IntPtr NativeFieldInfoPtr_playOnEnable;

	// Token: 0x040000B8 RID: 184
	private static readonly IntPtr NativeFieldInfoPtr_playAtLocation;

	// Token: 0x040000B9 RID: 185
	private static readonly IntPtr NativeFieldInfoPtr_stopRequested;

	// Token: 0x040000BA RID: 186
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040000BB RID: 187
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040000BC RID: 188
	private static readonly IntPtr NativeMethodInfoPtr_play_Protected_Virtual_New_IEnumerator_0;

	// Token: 0x040000BD RID: 189
	private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	// Token: 0x040000BE RID: 190
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200019D RID: 413
	[ObfuscatedName("PlayAudioSoundWithDelay+<play>d__6")]
	public sealed class _play_d__6 : global::Il2CppSystem.Object
	{
		// Token: 0x06001428 RID: 5160 RVA: 0x0004F4EC File Offset: 0x0004D6EC
		// Note: this type is marked as 'beforefieldinit'.
		static _play_d__6()
		{
			Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayAudioSoundWithDelay>.NativeClassPtr, "<play>d__6");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr);
			PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, "<>1__state");
			PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, "<>2__current");
			PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, "<>4__this");
			PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr__startTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, "<startTime>5__2");
			PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr__playingSound_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, "<playingSound>5__3");
			PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, 100663519);
			PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, 100663520);
			PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, 100663521);
			PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, 100663522);
			PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, 100663523);
			PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr, 100663524);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0004F5F4 File Offset: 0x0004D7F4
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _play_d__6(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAudioSoundWithDelay._play_d__6>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0004F63C File Offset: 0x0004D83C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0004F670 File Offset: 0x0004D870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983332, XrefRangeEnd = 983340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0004F6AC File Offset: 0x0004D8AC
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0004F6EC File Offset: 0x0004D8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983340, XrefRangeEnd = 983345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0004F720 File Offset: 0x0004D920
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSoundWithDelay._play_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0000B698 File Offset: 0x00009898
		public _play_d__6(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0004F760 File Offset: 0x0004D960
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x0000B6A1 File Offset: 0x000098A1
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0004F788 File Offset: 0x0004D988
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000B6BC File Offset: 0x000098BC
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0004F7B8 File Offset: 0x0004D9B8
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x0000B6DB File Offset: 0x000098DB
		public unsafe PlayAudioSoundWithDelay __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayAudioSoundWithDelay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0004F7E8 File Offset: 0x0004D9E8
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x0000B6FA File Offset: 0x000098FA
		public unsafe float _startTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr__startTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr__startTime_5__2)) = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0004F810 File Offset: 0x0004DA10
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x0000B715 File Offset: 0x00009915
		public unsafe AudioObject _playingSound_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr__playingSound_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSoundWithDelay._play_d__6.NativeFieldInfoPtr__playingSound_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeFieldInfoPtr__startTime_5__2;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeFieldInfoPtr__playingSound_5__3;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
