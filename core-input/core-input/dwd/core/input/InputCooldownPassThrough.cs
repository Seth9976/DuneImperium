using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input
{
	// Token: 0x02000047 RID: 71
	public class InputCooldownPassThrough : MonoBehaviour
	{
		// Token: 0x06000211 RID: 529 RVA: 0x0000D554 File Offset: 0x0000B754
		// Note: this type is marked as 'beforefieldinit'.
		static InputCooldownPassThrough()
		{
			Il2CppClassPointerStore<InputCooldownPassThrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "InputCooldownPassThrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputCooldownPassThrough>.NativeClassPtr);
			InputCooldownPassThrough.NativeFieldInfoPtr_cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCooldownPassThrough>.NativeClassPtr, "cooldown");
			InputCooldownPassThrough.NativeFieldInfoPtr_lastInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCooldownPassThrough>.NativeClassPtr, "lastInput");
			InputCooldownPassThrough.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCooldownPassThrough>.NativeClassPtr, "inputAction");
			InputCooldownPassThrough.NativeMethodInfoPtr_PassThrough_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCooldownPassThrough>.NativeClassPtr, 100663567);
			InputCooldownPassThrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCooldownPassThrough>.NativeClassPtr, 100663568);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120430, XrefRangeEnd = 1120434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassThrough(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCooldownPassThrough.NativeMethodInfoPtr_PassThrough_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000D628 File Offset: 0x0000B828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120434, XrefRangeEnd = 1120442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputCooldownPassThrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputCooldownPassThrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCooldownPassThrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00003370 File Offset: 0x00001570
		public InputCooldownPassThrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000D664 File Offset: 0x0000B864
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00003379 File Offset: 0x00001579
		public unsafe float cooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCooldownPassThrough.NativeFieldInfoPtr_cooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCooldownPassThrough.NativeFieldInfoPtr_cooldown)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000D68C File Offset: 0x0000B88C
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00003394 File Offset: 0x00001594
		public unsafe float lastInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCooldownPassThrough.NativeFieldInfoPtr_lastInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCooldownPassThrough.NativeFieldInfoPtr_lastInput)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000D6B4 File Offset: 0x0000B8B4
		// (set) Token: 0x0600021A RID: 538 RVA: 0x000033AF File Offset: 0x000015AF
		public unsafe UnityEventFloat inputAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCooldownPassThrough.NativeFieldInfoPtr_inputAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCooldownPassThrough.NativeFieldInfoPtr_inputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_cooldown;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_lastInput;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_inputAction;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_PassThrough_Public_Void_Single_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
