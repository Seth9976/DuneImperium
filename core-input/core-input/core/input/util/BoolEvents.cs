using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace core.input.util
{
	// Token: 0x0200000B RID: 11
	public class BoolEvents : MonoBehaviour
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00007E20 File Offset: 0x00006020
		// Note: this type is marked as 'beforefieldinit'.
		static BoolEvents()
		{
			Il2CppClassPointerStore<BoolEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "core.input.util", "BoolEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolEvents>.NativeClassPtr);
			BoolEvents.NativeFieldInfoPtr_output_OnInputTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolEvents>.NativeClassPtr, "output_OnInputTrue");
			BoolEvents.NativeFieldInfoPtr_output_OnInputFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolEvents>.NativeClassPtr, "output_OnInputFalse");
			BoolEvents.NativeMethodInfoPtr_get_Output_OnInputTrue_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEvents>.NativeClassPtr, 100663329);
			BoolEvents.NativeMethodInfoPtr_get_Output_OnInputFalse_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEvents>.NativeClassPtr, 100663330);
			BoolEvents.NativeMethodInfoPtr_Input_BoolValue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEvents>.NativeClassPtr, 100663331);
			BoolEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEvents>.NativeClassPtr, 100663332);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00007EC8 File Offset: 0x000060C8
		public unsafe UnityEvent Output_OnInputTrue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEvents.NativeMethodInfoPtr_get_Output_OnInputTrue_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00007F08 File Offset: 0x00006108
		public unsafe UnityEvent Output_OnInputFalse
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEvents.NativeMethodInfoPtr_get_Output_OnInputFalse_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00007F48 File Offset: 0x00006148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119083, XrefRangeEnd = 1119086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Input_BoolValue(bool boolVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref boolVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEvents.NativeMethodInfoPtr_Input_BoolValue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007F88 File Offset: 0x00006188
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000021C6 File Offset: 0x000003C6
		public BoolEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00007FC4 File Offset: 0x000061C4
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000021CF File Offset: 0x000003CF
		public unsafe UnityEvent output_OnInputTrue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEvents.NativeFieldInfoPtr_output_OnInputTrue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEvents.NativeFieldInfoPtr_output_OnInputTrue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00007FF4 File Offset: 0x000061F4
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000021EE File Offset: 0x000003EE
		public unsafe UnityEvent output_OnInputFalse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEvents.NativeFieldInfoPtr_output_OnInputFalse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEvents.NativeFieldInfoPtr_output_OnInputFalse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_output_OnInputTrue;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_output_OnInputFalse;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_Output_OnInputTrue_Public_get_UnityEvent_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_Output_OnInputFalse_Public_get_UnityEvent_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Input_BoolValue_Public_Void_Boolean_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
