using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.SceneManagement;

namespace InControl
{
	// Token: 0x02000022 RID: 34
	public class InControlManager : SingletonMonoBehavior<InControlManager>
	{
		// Token: 0x0600022B RID: 555 RVA: 0x0000FD24 File Offset: 0x0000DF24
		// Note: this type is marked as 'beforefieldinit'.
		static InControlManager()
		{
			Il2CppClassPointerStore<InControlManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InControlManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlManager>.NativeClassPtr);
			InControlManager.NativeFieldInfoPtr_logDebugInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "logDebugInfo");
			InControlManager.NativeFieldInfoPtr_invertYAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "invertYAxis");
			InControlManager.NativeFieldInfoPtr_useFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "useFixedUpdate");
			InControlManager.NativeFieldInfoPtr_dontDestroyOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "dontDestroyOnLoad");
			InControlManager.NativeFieldInfoPtr_suspendInBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "suspendInBackground");
			InControlManager.NativeFieldInfoPtr_updateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "updateMode");
			InControlManager.NativeFieldInfoPtr_enableICade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "enableICade");
			InControlManager.NativeFieldInfoPtr_enableXInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "enableXInput");
			InControlManager.NativeFieldInfoPtr_xInputOverrideUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "xInputOverrideUpdateRate");
			InControlManager.NativeFieldInfoPtr_xInputUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "xInputUpdateRate");
			InControlManager.NativeFieldInfoPtr_xInputOverrideBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "xInputOverrideBufferSize");
			InControlManager.NativeFieldInfoPtr_xInputBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "xInputBufferSize");
			InControlManager.NativeFieldInfoPtr_enableNativeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "enableNativeInput");
			InControlManager.NativeFieldInfoPtr_nativeInputEnableXInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "nativeInputEnableXInput");
			InControlManager.NativeFieldInfoPtr_nativeInputEnableMFi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "nativeInputEnableMFi");
			InControlManager.NativeFieldInfoPtr_nativeInputPreventSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "nativeInputPreventSleep");
			InControlManager.NativeFieldInfoPtr_nativeInputOverrideUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "nativeInputOverrideUpdateRate");
			InControlManager.NativeFieldInfoPtr_nativeInputUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "nativeInputUpdateRate");
			InControlManager.NativeFieldInfoPtr_applicationHasQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, "applicationHasQuit");
			InControlManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663616);
			InControlManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663617);
			InControlManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663618);
			InControlManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663619);
			InControlManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663620);
			InControlManager.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663621);
			InControlManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663622);
			InControlManager.NativeMethodInfoPtr_OnSceneWasLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663623);
			InControlManager.NativeMethodInfoPtr_LogMessage_Private_Static_Void_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663624);
			InControlManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlManager>.NativeClassPtr, 100663625);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000FF98 File Offset: 0x0000E198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769138, XrefRangeEnd = 769238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000FFCC File Offset: 0x0000E1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769238, XrefRangeEnd = 769255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00010000 File Offset: 0x0000E200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769255, XrefRangeEnd = 769267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00010034 File Offset: 0x0000E234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769267, XrefRangeEnd = 769274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00010068 File Offset: 0x0000E268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769274, XrefRangeEnd = 769281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationFocus(bool focusState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focusState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000100A8 File Offset: 0x0000E2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769281, XrefRangeEnd = 769288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationPause(bool pauseState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pauseState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000100E8 File Offset: 0x0000E2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769288, XrefRangeEnd = 769295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001011C File Offset: 0x0000E31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769295, XrefRangeEnd = 769302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSceneWasLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_OnSceneWasLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00010168 File Offset: 0x0000E368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769302, XrefRangeEnd = 769312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogMessage(LogMessage logMessage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(logMessage));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr_LogMessage_Private_Static_Void_LogMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000101A4 File Offset: 0x0000E3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769312, XrefRangeEnd = 769318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InControlManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002BD1 File Offset: 0x00000DD1
		public InControlManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000101E0 File Offset: 0x0000E3E0
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002BDA File Offset: 0x00000DDA
		public unsafe bool logDebugInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_logDebugInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_logDebugInfo)) = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00010208 File Offset: 0x0000E408
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public unsafe bool invertYAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_invertYAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_invertYAxis)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00010230 File Offset: 0x0000E430
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002C10 File Offset: 0x00000E10
		public unsafe bool useFixedUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_useFixedUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_useFixedUpdate)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00010258 File Offset: 0x0000E458
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00002C2B File Offset: 0x00000E2B
		public unsafe bool dontDestroyOnLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_dontDestroyOnLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_dontDestroyOnLoad)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00010280 File Offset: 0x0000E480
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002C46 File Offset: 0x00000E46
		public unsafe bool suspendInBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_suspendInBackground);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_suspendInBackground)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000102A8 File Offset: 0x0000E4A8
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002C61 File Offset: 0x00000E61
		public unsafe InControlUpdateMode updateMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_updateMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_updateMode)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000102D0 File Offset: 0x0000E4D0
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002C7C File Offset: 0x00000E7C
		public unsafe bool enableICade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_enableICade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_enableICade)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000245 RID: 581 RVA: 0x000102F8 File Offset: 0x0000E4F8
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002C97 File Offset: 0x00000E97
		public unsafe bool enableXInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_enableXInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_enableXInput)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00010320 File Offset: 0x0000E520
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002CB2 File Offset: 0x00000EB2
		public unsafe bool xInputOverrideUpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_xInputOverrideUpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_xInputOverrideUpdateRate)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00010348 File Offset: 0x0000E548
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002CCD File Offset: 0x00000ECD
		public unsafe int xInputUpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_xInputUpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_xInputUpdateRate)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00010370 File Offset: 0x0000E570
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002CE8 File Offset: 0x00000EE8
		public unsafe bool xInputOverrideBufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_xInputOverrideBufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_xInputOverrideBufferSize)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00010398 File Offset: 0x0000E598
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002D03 File Offset: 0x00000F03
		public unsafe int xInputBufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_xInputBufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_xInputBufferSize)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000103C0 File Offset: 0x0000E5C0
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002D1E File Offset: 0x00000F1E
		public unsafe bool enableNativeInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_enableNativeInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_enableNativeInput)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000103E8 File Offset: 0x0000E5E8
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002D39 File Offset: 0x00000F39
		public unsafe bool nativeInputEnableXInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputEnableXInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputEnableXInput)) = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00010410 File Offset: 0x0000E610
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002D54 File Offset: 0x00000F54
		public unsafe bool nativeInputEnableMFi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputEnableMFi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputEnableMFi)) = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00010438 File Offset: 0x0000E638
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002D6F File Offset: 0x00000F6F
		public unsafe bool nativeInputPreventSleep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputPreventSleep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputPreventSleep)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00010460 File Offset: 0x0000E660
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002D8A File Offset: 0x00000F8A
		public unsafe bool nativeInputOverrideUpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputOverrideUpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputOverrideUpdateRate)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00010488 File Offset: 0x0000E688
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002DA5 File Offset: 0x00000FA5
		public unsafe int nativeInputUpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputUpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_nativeInputUpdateRate)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000104B0 File Offset: 0x0000E6B0
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public unsafe bool applicationHasQuit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_applicationHasQuit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlManager.NativeFieldInfoPtr_applicationHasQuit)) = value;
			}
		}

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_logDebugInfo;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_invertYAxis;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_useFixedUpdate;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_dontDestroyOnLoad;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_suspendInBackground;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_updateMode;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_enableICade;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_enableXInput;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_xInputOverrideUpdateRate;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_xInputUpdateRate;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_xInputOverrideBufferSize;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_xInputBufferSize;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_enableNativeInput;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_nativeInputEnableXInput;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_nativeInputEnableMFi;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_nativeInputPreventSleep;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr_nativeInputOverrideUpdateRate;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_nativeInputUpdateRate;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_applicationHasQuit;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneWasLoaded_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_LogMessage_Private_Static_Void_LogMessage_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
