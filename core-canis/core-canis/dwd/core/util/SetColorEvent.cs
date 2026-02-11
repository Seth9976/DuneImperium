using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.util
{
	// Token: 0x02000096 RID: 150
	public class SetColorEvent : MonoBehaviour
	{
		// Token: 0x06000A70 RID: 2672 RVA: 0x0003B3BC File Offset: 0x000395BC
		// Note: this type is marked as 'beforefieldinit'.
		static SetColorEvent()
		{
			Il2CppClassPointerStore<SetColorEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "SetColorEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetColorEvent>.NativeClassPtr);
			SetColorEvent.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetColorEvent>.NativeClassPtr, "colors");
			SetColorEvent.NativeFieldInfoPtr_onSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetColorEvent>.NativeClassPtr, "onSet");
			SetColorEvent.NativeMethodInfoPtr_Event_Set_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetColorEvent>.NativeClassPtr, 100664748);
			SetColorEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetColorEvent>.NativeClassPtr, 100664749);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0003B43C File Offset: 0x0003963C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862802, XrefRangeEnd = 862805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Set(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetColorEvent.NativeMethodInfoPtr_Event_Set_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0003B47C File Offset: 0x0003967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862805, XrefRangeEnd = 862820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetColorEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetColorEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetColorEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00005B96 File Offset: 0x00003D96
		public SetColorEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0003B4B8 File Offset: 0x000396B8
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00005B9F File Offset: 0x00003D9F
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetColorEvent.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetColorEvent.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0003B4E8 File Offset: 0x000396E8
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00005BBE File Offset: 0x00003DBE
		public unsafe UnityEvent<Color> onSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetColorEvent.NativeFieldInfoPtr_onSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetColorEvent.NativeFieldInfoPtr_onSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_onSet;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_Event_Set_Public_Void_Int32_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
