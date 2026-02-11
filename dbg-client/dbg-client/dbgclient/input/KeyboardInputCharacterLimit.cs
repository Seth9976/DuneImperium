using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace dbgclient.input
{
	// Token: 0x020000AF RID: 175
	public class KeyboardInputCharacterLimit : MonoBehaviour
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00033BE8 File Offset: 0x00031DE8
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardInputCharacterLimit()
		{
			Il2CppClassPointerStore<KeyboardInputCharacterLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.input", "KeyboardInputCharacterLimit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardInputCharacterLimit>.NativeClassPtr);
			KeyboardInputCharacterLimit.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardInputCharacterLimit>.NativeClassPtr, "inputField");
			KeyboardInputCharacterLimit.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardInputCharacterLimit>.NativeClassPtr, 100664380);
			KeyboardInputCharacterLimit.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardInputCharacterLimit>.NativeClassPtr, 100664381);
			KeyboardInputCharacterLimit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardInputCharacterLimit>.NativeClassPtr, 100664382);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00033C68 File Offset: 0x00031E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503980, XrefRangeEnd = 503984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardInputCharacterLimit.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00033C9C File Offset: 0x00031E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503984, XrefRangeEnd = 503986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardInputCharacterLimit.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00033CD0 File Offset: 0x00031ED0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardInputCharacterLimit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardInputCharacterLimit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardInputCharacterLimit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00005400 File Offset: 0x00003600
		public KeyboardInputCharacterLimit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00033D0C File Offset: 0x00031F0C
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00005409 File Offset: 0x00003609
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardInputCharacterLimit.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardInputCharacterLimit.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
