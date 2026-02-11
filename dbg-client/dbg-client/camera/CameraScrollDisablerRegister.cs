using System;
using boardgames.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbg_client.camera
{
	// Token: 0x02000043 RID: 67
	public class CameraScrollDisablerRegister : MonoBehaviour
	{
		// Token: 0x0600029E RID: 670 RVA: 0x00025C9C File Offset: 0x00023E9C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraScrollDisablerRegister()
		{
			Il2CppClassPointerStore<CameraScrollDisablerRegister>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbg_client.camera", "CameraScrollDisablerRegister");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraScrollDisablerRegister>.NativeClassPtr);
			CameraScrollDisablerRegister.NativeFieldInfoPtr__ScrollDisabler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScrollDisablerRegister>.NativeClassPtr, "<ScrollDisabler>k__BackingField");
			CameraScrollDisablerRegister.NativeMethodInfoPtr_get_ScrollDisabler_Public_get_Disabler_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisablerRegister>.NativeClassPtr, 100663709);
			CameraScrollDisablerRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisablerRegister>.NativeClassPtr, 100663710);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00025D08 File Offset: 0x00023F08
		public unsafe Disabler<GameObject> ScrollDisabler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisablerRegister.NativeMethodInfoPtr_get_ScrollDisabler_Public_get_Disabler_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Disabler<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00025D48 File Offset: 0x00023F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498902, XrefRangeEnd = 498910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraScrollDisablerRegister()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraScrollDisablerRegister>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisablerRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000326A File Offset: 0x0000146A
		public CameraScrollDisablerRegister(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00025D84 File Offset: 0x00023F84
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00003273 File Offset: 0x00001473
		public unsafe Disabler<GameObject> _ScrollDisabler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisablerRegister.NativeFieldInfoPtr__ScrollDisabler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Disabler<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisablerRegister.NativeFieldInfoPtr__ScrollDisabler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr__ScrollDisabler_k__BackingField;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_ScrollDisabler_Public_get_Disabler_1_GameObject_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
