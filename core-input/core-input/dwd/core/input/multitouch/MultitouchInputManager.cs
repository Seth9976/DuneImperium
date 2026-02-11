using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input.multitouch
{
	// Token: 0x0200006A RID: 106
	public class MultitouchInputManager : MonoBehaviour
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x00013328 File Offset: 0x00011528
		// Note: this type is marked as 'beforefieldinit'.
		static MultitouchInputManager()
		{
			Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "MultitouchInputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr);
			MultitouchInputManager.NativeFieldInfoPtr_activeTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "activeTouches");
			MultitouchInputManager.NativeFieldInfoPtr_processor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "processor");
			MultitouchInputManager.NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "inputManager");
			MultitouchInputManager.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "<Initialized>k__BackingField");
			MultitouchInputManager.NativeFieldInfoPtr_gestureUpdateFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "gestureUpdateFrame");
			MultitouchInputManager.NativeFieldInfoPtr_touchesThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "touchesThisFrame");
			MultitouchInputManager.NativeFieldInfoPtr_newTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "newTouches");
			MultitouchInputManager.NativeFieldInfoPtr_staleTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "staleTouches");
			MultitouchInputManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663741);
			MultitouchInputManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663742);
			MultitouchInputManager.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663743);
			MultitouchInputManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663744);
			MultitouchInputManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663745);
			MultitouchInputManager.NativeMethodInfoPtr_updateGestures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663746);
			MultitouchInputManager.NativeMethodInfoPtr_processTouches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663747);
			MultitouchInputManager.NativeMethodInfoPtr_GetGesture_Public_Gesture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663748);
			MultitouchInputManager.NativeMethodInfoPtr_Find_Public_Static_MultitouchInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663749);
			MultitouchInputManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, 100663750);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000134C0 File Offset: 0x000116C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122251, XrefRangeEnd = 1122270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000134F4 File Offset: 0x000116F4
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00013530 File Offset: 0x00011730
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00013570 File Offset: 0x00011770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122270, XrefRangeEnd = 1122274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000135A4 File Offset: 0x000117A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122274, XrefRangeEnd = 1122277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000135D8 File Offset: 0x000117D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateGestures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_updateGestures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001360C File Offset: 0x0001180C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1122365, RefRangeEnd = 1122368, XrefRangeStart = 1122277, XrefRangeEnd = 1122365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void processTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_processTouches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00013640 File Offset: 0x00011840
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1122382, RefRangeEnd = 1122387, XrefRangeStart = 1122368, XrefRangeEnd = 1122382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gesture GetGesture(int fingers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fingers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_GetGesture_Public_Gesture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr3) : null;
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0001368C File Offset: 0x0001188C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1122390, RefRangeEnd = 1122391, XrefRangeStart = 1122387, XrefRangeEnd = 1122390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MultitouchInputManager Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr_Find_Public_Static_MultitouchInputManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultitouchInputManager>(intPtr3) : null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000136C0 File Offset: 0x000118C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122391, XrefRangeEnd = 1122416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultitouchInputManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000447E File Offset: 0x0000267E
		public MultitouchInputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000136FC File Offset: 0x000118FC
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00004487 File Offset: 0x00002687
		public unsafe List<TouchPress> activeTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_activeTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_activeTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0001372C File Offset: 0x0001192C
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x000044A6 File Offset: 0x000026A6
		public unsafe GestureProcessor processor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_processor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GestureProcessor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_processor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0001375C File Offset: 0x0001195C
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x000044C5 File Offset: 0x000026C5
		public unsafe InputManager inputManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_inputManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_inputManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0001378C File Offset: 0x0001198C
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x000044E4 File Offset: 0x000026E4
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x000137B4 File Offset: 0x000119B4
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x000044FF File Offset: 0x000026FF
		public unsafe int gestureUpdateFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_gestureUpdateFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_gestureUpdateFrame)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x000137DC File Offset: 0x000119DC
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000451A File Offset: 0x0000271A
		public unsafe HashSet<TouchPress> touchesThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_touchesThisFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<TouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_touchesThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0001380C File Offset: 0x00011A0C
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x00004539 File Offset: 0x00002739
		public unsafe HashSet<TouchPress> newTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_newTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<TouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_newTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001383C File Offset: 0x00011A3C
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00004558 File Offset: 0x00002758
		public unsafe HashSet<TouchPress> staleTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_staleTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<TouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultitouchInputManager.NativeFieldInfoPtr_staleTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_activeTouches;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_processor;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_inputManager;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_gestureUpdateFrame;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_touchesThisFrame;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_newTouches;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_staleTouches;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_updateGestures_Private_Void_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_processTouches_Private_Void_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_GetGesture_Public_Gesture_Int32_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_MultitouchInputManager_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C9 RID: 201
		[ObfuscatedName("dwd.core.input.multitouch.MultitouchInputManager+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060008D2 RID: 2258 RVA: 0x000237B4 File Offset: 0x000219B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MultitouchInputManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultitouchInputManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultitouchInputManager.__c>.NativeClassPtr);
				MultitouchInputManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager.__c>.NativeClassPtr, "<>9");
				MultitouchInputManager.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultitouchInputManager.__c>.NativeClassPtr, "<>9__15_0");
				MultitouchInputManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager.__c>.NativeClassPtr, 100663752);
				MultitouchInputManager.__c.NativeMethodInfoPtr__processTouches_b__15_0_Internal_Int32_TouchPress_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultitouchInputManager.__c>.NativeClassPtr, 100663753);
			}

			// Token: 0x060008D3 RID: 2259 RVA: 0x00023830 File Offset: 0x00021A30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultitouchInputManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008D4 RID: 2260 RVA: 0x0002386C File Offset: 0x00021A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122250, XrefRangeEnd = 1122251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _processTouches_b__15_0(TouchPress x, TouchPress y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultitouchInputManager.__c.NativeMethodInfoPtr__processTouches_b__15_0_Internal_Int32_TouchPress_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008D5 RID: 2261 RVA: 0x000069A8 File Offset: 0x00004BA8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000238CC File Offset: 0x00021ACC
			// (set) Token: 0x060008D7 RID: 2263 RVA: 0x000069B1 File Offset: 0x00004BB1
			public unsafe static MultitouchInputManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultitouchInputManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultitouchInputManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultitouchInputManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000238F4 File Offset: 0x00021AF4
			// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000069C3 File Offset: 0x00004BC3
			public unsafe static Comparison<TouchPress> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultitouchInputManager.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TouchPress>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultitouchInputManager.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000579 RID: 1401
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400057A RID: 1402
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400057B RID: 1403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400057C RID: 1404
			private static readonly IntPtr NativeMethodInfoPtr__processTouches_b__15_0_Internal_Int32_TouchPress_TouchPress_0;
		}
	}
}
