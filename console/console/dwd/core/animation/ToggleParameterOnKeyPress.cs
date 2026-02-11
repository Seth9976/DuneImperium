using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x0200000B RID: 11
	public class ToggleParameterOnKeyPress : MonoBehaviour
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00004194 File Offset: 0x00002394
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleParameterOnKeyPress()
		{
			Il2CppClassPointerStore<ToggleParameterOnKeyPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.animation", "ToggleParameterOnKeyPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleParameterOnKeyPress>.NativeClassPtr);
			ToggleParameterOnKeyPress.NativeFieldInfoPtr_KeyCombination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnKeyPress>.NativeClassPtr, "KeyCombination");
			ToggleParameterOnKeyPress.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnKeyPress>.NativeClassPtr, "ParameterName");
			ToggleParameterOnKeyPress.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnKeyPress>.NativeClassPtr, 100663332);
			ToggleParameterOnKeyPress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnKeyPress>.NativeClassPtr, 100663333);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004214 File Offset: 0x00002414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255753, XrefRangeEnd = 1255789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnKeyPress.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004248 File Offset: 0x00002448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255789, XrefRangeEnd = 1255801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleParameterOnKeyPress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleParameterOnKeyPress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnKeyPress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000024F0 File Offset: 0x000006F0
		public ToggleParameterOnKeyPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004284 File Offset: 0x00002484
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000024F9 File Offset: 0x000006F9
		public unsafe List<KeyCode> KeyCombination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnKeyPress.NativeFieldInfoPtr_KeyCombination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnKeyPress.NativeFieldInfoPtr_KeyCombination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000042B4 File Offset: 0x000024B4
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002518 File Offset: 0x00000718
		public unsafe string ParameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnKeyPress.NativeFieldInfoPtr_ParameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnKeyPress.NativeFieldInfoPtr_ParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_KeyCombination;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_ParameterName;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
