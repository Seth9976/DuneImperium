using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.debug
{
	// Token: 0x02000074 RID: 116
	public class TrackSelectedGameObject : MonoBehaviour
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x00014A78 File Offset: 0x00012C78
		// Note: this type is marked as 'beforefieldinit'.
		static TrackSelectedGameObject()
		{
			Il2CppClassPointerStore<TrackSelectedGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.debug", "TrackSelectedGameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSelectedGameObject>.NativeClassPtr);
			TrackSelectedGameObject.NativeFieldInfoPtr_currentlySelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSelectedGameObject>.NativeClassPtr, "currentlySelected");
			TrackSelectedGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSelectedGameObject>.NativeClassPtr, 100663795);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00014AD0 File Offset: 0x00012CD0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackSelectedGameObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackSelectedGameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackSelectedGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000491D File Offset: 0x00002B1D
		public TrackSelectedGameObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00014B0C File Offset: 0x00012D0C
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00004926 File Offset: 0x00002B26
		public unsafe GameObject currentlySelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackSelectedGameObject.NativeFieldInfoPtr_currentlySelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackSelectedGameObject.NativeFieldInfoPtr_currentlySelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_currentlySelected;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
