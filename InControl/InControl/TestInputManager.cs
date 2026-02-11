using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000074 RID: 116
	public class TestInputManager : MonoBehaviour
	{
		// Token: 0x06000AB5 RID: 2741 RVA: 0x0002E8B4 File Offset: 0x0002CAB4
		// Note: this type is marked as 'beforefieldinit'.
		static TestInputManager()
		{
			Il2CppClassPointerStore<TestInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TestInputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr);
			TestInputManager.NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, "font");
			TestInputManager.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, "style");
			TestInputManager.NativeFieldInfoPtr_logMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, "logMessages");
			TestInputManager.NativeFieldInfoPtr_isPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, "isPaused");
			TestInputManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664766);
			TestInputManager.NativeMethodInfoPtr_HandleInputUpdate_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664767);
			TestInputManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664768);
			TestInputManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664769);
			TestInputManager.NativeMethodInfoPtr_CheckForPauseButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664770);
			TestInputManager.NativeMethodInfoPtr_SetColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664771);
			TestInputManager.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664772);
			TestInputManager.NativeMethodInfoPtr_DrawUnityInputDebugger_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664773);
			TestInputManager.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664774);
			TestInputManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664775);
			TestInputManager.NativeMethodInfoPtr__OnEnable_b__4_0_Private_Void_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, 100664776);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002EA10 File Offset: 0x0002CC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791451, XrefRangeEnd = 791522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0002EA44 File Offset: 0x0002CC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791522, XrefRangeEnd = 791562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInputUpdate(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_HandleInputUpdate_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002EA90 File Offset: 0x0002CC90
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791562, XrefRangeEnd = 791581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0002EAF8 File Offset: 0x0002CCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791581, XrefRangeEnd = 791591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForPauseButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_CheckForPauseButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791591, XrefRangeEnd = 791593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_SetColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0002EB6C File Offset: 0x0002CD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791593, XrefRangeEnd = 792014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0002EBA0 File Offset: 0x0002CDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792014, XrefRangeEnd = 792091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawUnityInputDebugger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_DrawUnityInputDebugger_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0002EBD4 File Offset: 0x0002CDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792091, XrefRangeEnd = 792104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0002EC08 File Offset: 0x0002CE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792104, XrefRangeEnd = 792117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TestInputManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0002EC44 File Offset: 0x0002CE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792117, XrefRangeEnd = 792120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__4_0(LogMessage logMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(logMessage));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.NativeMethodInfoPtr__OnEnable_b__4_0_Private_Void_LogMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00005FCD File Offset: 0x000041CD
		public TestInputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0002EC8C File Offset: 0x0002CE8C
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00005FD6 File Offset: 0x000041D6
		public unsafe Font font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestInputManager.NativeFieldInfoPtr_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestInputManager.NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002ECBC File Offset: 0x0002CEBC
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00005FF5 File Offset: 0x000041F5
		public unsafe GUIStyle style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestInputManager.NativeFieldInfoPtr_style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestInputManager.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00006014 File Offset: 0x00004214
		public unsafe List<LogMessage> logMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestInputManager.NativeFieldInfoPtr_logMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LogMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestInputManager.NativeFieldInfoPtr_logMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0002ED1C File Offset: 0x0002CF1C
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00006033 File Offset: 0x00004233
		public unsafe bool isPaused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestInputManager.NativeFieldInfoPtr_isPaused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestInputManager.NativeFieldInfoPtr_isPaused)) = value;
			}
		}

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_font;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_logMessages;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr_isPaused;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputUpdate_Private_Void_UInt64_Single_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_CheckForPauseButton_Private_Void_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Private_Void_Color_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_DrawUnityInputDebugger_Private_Void_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__4_0_Private_Void_LogMessage_0;

		// Token: 0x02000224 RID: 548
		[ObfuscatedName("InControl.TestInputManager+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060011CD RID: 4557 RVA: 0x00045ED8 File Offset: 0x000440D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TestInputManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr);
				TestInputManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr, "<>9");
				TestInputManager.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr, "<>9__4_1");
				TestInputManager.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr, "<>9__4_2");
				TestInputManager.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr, "<>9__4_3");
				TestInputManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr, 100664778);
				TestInputManager.__c.NativeMethodInfoPtr__OnEnable_b__4_1_Internal_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr, 100664779);
				TestInputManager.__c.NativeMethodInfoPtr__OnEnable_b__4_2_Internal_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr, 100664780);
				TestInputManager.__c.NativeMethodInfoPtr__OnEnable_b__4_3_Internal_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr, 100664781);
			}

			// Token: 0x060011CE RID: 4558 RVA: 0x00045FA4 File Offset: 0x000441A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestInputManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011CF RID: 4559 RVA: 0x00045FE0 File Offset: 0x000441E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791420, XrefRangeEnd = 791428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnable_b__4_1(InputDevice inputDevice)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.__c.NativeMethodInfoPtr__OnEnable_b__4_1_Internal_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011D0 RID: 4560 RVA: 0x00046024 File Offset: 0x00044224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791428, XrefRangeEnd = 791436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnable_b__4_2(InputDevice inputDevice)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.__c.NativeMethodInfoPtr__OnEnable_b__4_2_Internal_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011D1 RID: 4561 RVA: 0x00046068 File Offset: 0x00044268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791436, XrefRangeEnd = 791451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnable_b__4_3(InputDevice inputDevice)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestInputManager.__c.NativeMethodInfoPtr__OnEnable_b__4_3_Internal_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011D2 RID: 4562 RVA: 0x00007274 File Offset: 0x00005474
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000460AC File Offset: 0x000442AC
			// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0000727D File Offset: 0x0000547D
			public unsafe static TestInputManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TestInputManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TestInputManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TestInputManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000460D4 File Offset: 0x000442D4
			// (set) Token: 0x060011D6 RID: 4566 RVA: 0x0000728F File Offset: 0x0000548F
			public unsafe static Action<InputDevice> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TestInputManager.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TestInputManager.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x060011D7 RID: 4567 RVA: 0x000460FC File Offset: 0x000442FC
			// (set) Token: 0x060011D8 RID: 4568 RVA: 0x000072A1 File Offset: 0x000054A1
			public unsafe static Action<InputDevice> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TestInputManager.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TestInputManager.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x060011D9 RID: 4569 RVA: 0x00046124 File Offset: 0x00044324
			// (set) Token: 0x060011DA RID: 4570 RVA: 0x000072B3 File Offset: 0x000054B3
			public unsafe static Action<InputDevice> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TestInputManager.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TestInputManager.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DFF RID: 3583
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000E00 RID: 3584
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04000E01 RID: 3585
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04000E02 RID: 3586
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x04000E03 RID: 3587
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E04 RID: 3588
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__4_1_Internal_Void_InputDevice_0;

			// Token: 0x04000E05 RID: 3589
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__4_2_Internal_Void_InputDevice_0;

			// Token: 0x04000E06 RID: 3590
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__4_3_Internal_Void_InputDevice_0;
		}
	}
}
