using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace lib.canis.console.src
{
	// Token: 0x02000015 RID: 21
	public class ActivateInputField : MonoBehaviour
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00005BD0 File Offset: 0x00003DD0
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateInputField()
		{
			Il2CppClassPointerStore<ActivateInputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "lib.canis.console.src", "ActivateInputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateInputField>.NativeClassPtr);
			ActivateInputField.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateInputField>.NativeClassPtr, "inputField");
			ActivateInputField.NativeMethodInfoPtr_Event_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateInputField>.NativeClassPtr, 100663389);
			ActivateInputField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateInputField>.NativeClassPtr, 100663390);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005C3C File Offset: 0x00003E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256303, XrefRangeEnd = 1256305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateInputField.NativeMethodInfoPtr_Event_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005C70 File Offset: 0x00003E70
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateInputField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateInputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateInputField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000029EC File Offset: 0x00000BEC
		public ActivateInputField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00005CAC File Offset: 0x00003EAC
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000029F5 File Offset: 0x00000BF5
		public unsafe InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateInputField.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateInputField.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_Event_Activate_Public_Void_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
