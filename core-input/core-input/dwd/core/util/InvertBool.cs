using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.util
{
	// Token: 0x02000036 RID: 54
	public class InvertBool : MonoBehaviour
	{
		// Token: 0x06000199 RID: 409 RVA: 0x0000C06C File Offset: 0x0000A26C
		// Note: this type is marked as 'beforefieldinit'.
		static InvertBool()
		{
			Il2CppClassPointerStore<InvertBool>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.util", "InvertBool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvertBool>.NativeClassPtr);
			InvertBool.NativeFieldInfoPtr_output_InverseValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvertBool>.NativeClassPtr, "output_InverseValue");
			InvertBool.NativeMethodInfoPtr_get_Output_InverseValue_Public_get_UnityEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertBool>.NativeClassPtr, 100663512);
			InvertBool.NativeMethodInfoPtr_Input_BoolValue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertBool>.NativeClassPtr, 100663513);
			InvertBool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertBool>.NativeClassPtr, 100663514);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		public unsafe UnityEvent<bool> Output_InverseValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvertBool.NativeMethodInfoPtr_get_Output_InverseValue_Public_get_UnityEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000C12C File Offset: 0x0000A32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120156, XrefRangeEnd = 1120160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Input_BoolValue(bool inputValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvertBool.NativeMethodInfoPtr_Input_BoolValue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000C16C File Offset: 0x0000A36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120160, XrefRangeEnd = 1120168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvertBool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvertBool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvertBool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002EDA File Offset: 0x000010DA
		public InvertBool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002EE3 File Offset: 0x000010E3
		public unsafe UnityEventBool output_InverseValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvertBool.NativeFieldInfoPtr_output_InverseValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvertBool.NativeFieldInfoPtr_output_InverseValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_output_InverseValue;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_get_Output_InverseValue_Public_get_UnityEvent_1_Boolean_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_Input_BoolValue_Public_Void_Boolean_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
