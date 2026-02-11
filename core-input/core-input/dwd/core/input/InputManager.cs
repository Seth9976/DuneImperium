using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine;

namespace dwd.core.input
{
	// Token: 0x02000049 RID: 73
	public sealed class InputManager : MonoBehaviour
	{
		// Token: 0x0600022B RID: 555 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		// Note: this type is marked as 'beforefieldinit'.
		static InputManager()
		{
			Il2CppClassPointerStore<InputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "InputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager>.NativeClassPtr);
			InputManager.NativeFieldInfoPtr_simulateMouseWithTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "simulateMouseWithTouches");
			InputManager.NativeFieldInfoPtr_disableCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "disableCursor");
			InputManager.NativeFieldInfoPtr_mouseTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "mouseTimeout");
			InputManager.NativeFieldInfoPtr_cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "cursor");
			InputManager.NativeFieldInfoPtr_presses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "presses");
			InputManager.NativeFieldInfoPtr__Presses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "_Presses");
			InputManager.NativeFieldInfoPtr_anyPressStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "anyPressStarted");
			InputManager.NativeFieldInfoPtr_anyPressEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "anyPressEnded");
			InputManager.NativeFieldInfoPtr_mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "mouse");
			InputManager.NativeFieldInfoPtr_touches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "touches");
			InputManager.NativeFieldInfoPtr_hasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "hasFocus");
			InputManager.NativeFieldInfoPtr_lastUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "lastUpdated");
			InputManager.NativeFieldInfoPtr_lastMouseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "lastMouseTime");
			InputManager.NativeFieldInfoPtr_lastTouchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "lastTouchTime");
			InputManager.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "actions");
			InputManager.NativeFieldInfoPtr_simulateInvalidReported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "simulateInvalidReported");
			InputManager.NativeMethodInfoPtr_Find_Public_Static_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663576);
			InputManager.NativeMethodInfoPtr_get_Cursor_Public_get_Nullable_1_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663577);
			InputManager.NativeMethodInfoPtr_IsMouseOver_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663578);
			InputManager.NativeMethodInfoPtr_get_Presses_Public_get_ReadOnlyCollection_1_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663579);
			InputManager.NativeMethodInfoPtr_get_AnyPressStarted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663580);
			InputManager.NativeMethodInfoPtr_get_AnyPressEnded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663581);
			InputManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663582);
			InputManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663583);
			InputManager.NativeMethodInfoPtr_updatePresses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663584);
			InputManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663585);
			InputManager.NativeMethodInfoPtr_updateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663586);
			InputManager.NativeMethodInfoPtr_validateSimulateMouse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663587);
			InputManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100663588);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1120512, RefRangeEnd = 1120515, XrefRangeStart = 1120509, XrefRangeEnd = 1120512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputManager Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Find_Public_Static_InputManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputManager>(intPtr3) : null;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000DD80 File Offset: 0x0000BF80
		public unsafe Nullable<InputSample> Cursor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120515, XrefRangeEnd = 1120516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_Cursor_Public_get_Nullable_1_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<InputSample>(intPtr);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120516, XrefRangeEnd = 1120523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOver(Transform checkTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(checkTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_IsMouseOver_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000DE08 File Offset: 0x0000C008
		public unsafe ReadOnlyCollection<Press> Presses
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120523, XrefRangeEnd = 1120524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_Presses_Public_get_ReadOnlyCollection_1_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Press>>(intPtr3) : null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000DE48 File Offset: 0x0000C048
		public unsafe bool AnyPressStarted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120524, XrefRangeEnd = 1120525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_AnyPressStarted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000DE84 File Offset: 0x0000C084
		public unsafe bool AnyPressEnded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120525, XrefRangeEnd = 1120526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_AnyPressEnded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120526, XrefRangeEnd = 1120569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120569, XrefRangeEnd = 1120586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000DF28 File Offset: 0x0000C128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120586, XrefRangeEnd = 1120587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updatePresses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_updatePresses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000DF5C File Offset: 0x0000C15C
		[CallerCount(0)]
		public unsafe void OnApplicationFocus(bool hasFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasFocus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000DF9C File Offset: 0x0000C19C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1120667, RefRangeEnd = 1120678, XrefRangeStart = 1120587, XrefRangeEnd = 1120667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_updateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120678, XrefRangeEnd = 1120693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void validateSimulateMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_validateSimulateMouse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000E004 File Offset: 0x0000C204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120693, XrefRangeEnd = 1120708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00003442 File Offset: 0x00001642
		public InputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000E040 File Offset: 0x0000C240
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000344B File Offset: 0x0000164B
		public unsafe bool simulateMouseWithTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_simulateMouseWithTouches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_simulateMouseWithTouches)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000E068 File Offset: 0x0000C268
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00003466 File Offset: 0x00001666
		public unsafe bool disableCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_disableCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_disableCursor)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000E090 File Offset: 0x0000C290
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00003481 File Offset: 0x00001681
		public unsafe float mouseTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_mouseTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_mouseTimeout)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0000349C File Offset: 0x0000169C
		public Nullable<InputSample> cursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_cursor);
				return new Nullable<InputSample>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<InputSample>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_cursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<InputSample>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		// (set) Token: 0x06000243 RID: 579 RVA: 0x000034CA File Offset: 0x000016CA
		public unsafe List<Press> presses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_presses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Press>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_presses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000E118 File Offset: 0x0000C318
		// (set) Token: 0x06000245 RID: 581 RVA: 0x000034E9 File Offset: 0x000016E9
		public unsafe ReadOnlyCollection<Press> _Presses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr__Presses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Press>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr__Presses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000E148 File Offset: 0x0000C348
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00003508 File Offset: 0x00001708
		public unsafe bool anyPressStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_anyPressStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_anyPressStarted)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000E170 File Offset: 0x0000C370
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00003523 File Offset: 0x00001723
		public unsafe bool anyPressEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_anyPressEnded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_anyPressEnded)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000E198 File Offset: 0x0000C398
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0000353E File Offset: 0x0000173E
		public unsafe MousePressInterpreter mouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_mouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MousePressInterpreter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_mouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000355D File Offset: 0x0000175D
		public unsafe TouchPressInterpreter touches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_touches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPressInterpreter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_touches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000E1F8 File Offset: 0x0000C3F8
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0000357C File Offset: 0x0000177C
		public unsafe bool hasFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_hasFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_hasFocus)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000E220 File Offset: 0x0000C420
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00003597 File Offset: 0x00001797
		public unsafe int lastUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_lastUpdated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_lastUpdated)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000E248 File Offset: 0x0000C448
		// (set) Token: 0x06000253 RID: 595 RVA: 0x000035B2 File Offset: 0x000017B2
		public unsafe float lastMouseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_lastMouseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_lastMouseTime)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000E270 File Offset: 0x0000C470
		// (set) Token: 0x06000255 RID: 597 RVA: 0x000035CD File Offset: 0x000017CD
		public unsafe float lastTouchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_lastTouchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_lastTouchTime)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000E298 File Offset: 0x0000C498
		// (set) Token: 0x06000257 RID: 599 RVA: 0x000035E8 File Offset: 0x000017E8
		public unsafe List<PressAction> actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PressAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00003607 File Offset: 0x00001807
		public unsafe bool simulateInvalidReported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_simulateInvalidReported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_simulateInvalidReported)) = value;
			}
		}

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_simulateMouseWithTouches;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_disableCursor;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_mouseTimeout;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_cursor;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_presses;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr__Presses;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_anyPressStarted;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_anyPressEnded;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_mouse;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_touches;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_hasFocus;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_lastUpdated;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_lastMouseTime;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_lastTouchTime;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_actions;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_simulateInvalidReported;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_InputManager_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_Cursor_Public_get_Nullable_1_InputSample_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOver_Public_Boolean_Transform_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_Presses_Public_get_ReadOnlyCollection_1_Press_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyPressStarted_Public_get_Boolean_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyPressEnded_Public_get_Boolean_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_updatePresses_Private_Void_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_updateData_Private_Void_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_validateSimulateMouse_Private_Void_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
