using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.console
{
	// Token: 0x02000011 RID: 17
	public class ConsoleInputWatcher : MonoBehaviour
	{
		// Token: 0x060000DD RID: 221 RVA: 0x000052D4 File Offset: 0x000034D4
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleInputWatcher()
		{
			Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.console", "ConsoleInputWatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr);
			ConsoleInputWatcher.NativeFieldInfoPtr_keyboardKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr, "keyboardKey");
			ConsoleInputWatcher.NativeFieldInfoPtr_touchScreenReq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr, "touchScreenReq");
			ConsoleInputWatcher.NativeFieldInfoPtr_joystickAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr, "joystickAxes");
			ConsoleInputWatcher.NativeFieldInfoPtr_innerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr, "innerPanel");
			ConsoleInputWatcher.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr, 100663370);
			ConsoleInputWatcher.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr, 100663371);
			ConsoleInputWatcher.NativeMethodInfoPtr_ToggleConsole_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr, 100663372);
			ConsoleInputWatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr, 100663373);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000053A4 File Offset: 0x000035A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256101, XrefRangeEnd = 1256103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleInputWatcher.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000053D8 File Offset: 0x000035D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256103, XrefRangeEnd = 1256132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleInputWatcher.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000540C File Offset: 0x0000360C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256132, XrefRangeEnd = 1256135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleInputWatcher.NativeMethodInfoPtr_ToggleConsole_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005440 File Offset: 0x00003640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256135, XrefRangeEnd = 1256143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleInputWatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleInputWatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleInputWatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002845 File Offset: 0x00000A45
		public ConsoleInputWatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000547C File Offset: 0x0000367C
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000284E File Offset: 0x00000A4E
		public unsafe KeyCode keyboardKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleInputWatcher.NativeFieldInfoPtr_keyboardKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleInputWatcher.NativeFieldInfoPtr_keyboardKey)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000054A4 File Offset: 0x000036A4
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002869 File Offset: 0x00000A69
		public unsafe int touchScreenReq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleInputWatcher.NativeFieldInfoPtr_touchScreenReq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleInputWatcher.NativeFieldInfoPtr_touchScreenReq)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000054CC File Offset: 0x000036CC
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002884 File Offset: 0x00000A84
		public unsafe List<string> joystickAxes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleInputWatcher.NativeFieldInfoPtr_joystickAxes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleInputWatcher.NativeFieldInfoPtr_joystickAxes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000054FC File Offset: 0x000036FC
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000028A3 File Offset: 0x00000AA3
		public unsafe GameObject innerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleInputWatcher.NativeFieldInfoPtr_innerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleInputWatcher.NativeFieldInfoPtr_innerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_keyboardKey;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_touchScreenReq;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_joystickAxes;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_innerPanel;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_ToggleConsole_Public_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
