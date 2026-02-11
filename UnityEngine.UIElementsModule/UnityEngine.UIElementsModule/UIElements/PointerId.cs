using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000112 RID: 274
	public static class PointerId : Object
	{
		// Token: 0x060014F3 RID: 5363 RVA: 0x000671CC File Offset: 0x000653CC
		// Note: this type is marked as 'beforefieldinit'.
		static PointerId()
		{
			Il2CppClassPointerStore<PointerId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerId>.NativeClassPtr);
			PointerId.NativeFieldInfoPtr_maxPointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "maxPointers");
			PointerId.NativeFieldInfoPtr_invalidPointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "invalidPointerId");
			PointerId.NativeFieldInfoPtr_mousePointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "mousePointerId");
			PointerId.NativeFieldInfoPtr_touchPointerIdBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "touchPointerIdBase");
			PointerId.NativeFieldInfoPtr_touchPointerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "touchPointerCount");
			PointerId.NativeFieldInfoPtr_penPointerIdBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "penPointerIdBase");
			PointerId.NativeFieldInfoPtr_penPointerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "penPointerCount");
			PointerId.NativeFieldInfoPtr_hoveringPointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "hoveringPointers");
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00009E57 File Offset: 0x00008057
		public PointerId(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0006729C File Offset: 0x0006549C
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x00009E60 File Offset: 0x00008060
		public unsafe static int maxPointers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_maxPointers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_maxPointers, (void*)(&value));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x000672B8 File Offset: 0x000654B8
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x00009E6E File Offset: 0x0000806E
		public unsafe static int invalidPointerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_invalidPointerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_invalidPointerId, (void*)(&value));
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000672D4 File Offset: 0x000654D4
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x00009E7C File Offset: 0x0000807C
		public unsafe static int mousePointerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_mousePointerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_mousePointerId, (void*)(&value));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000672F0 File Offset: 0x000654F0
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x00009E8A File Offset: 0x0000808A
		public unsafe static int touchPointerIdBase
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_touchPointerIdBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_touchPointerIdBase, (void*)(&value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0006730C File Offset: 0x0006550C
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x00009E98 File Offset: 0x00008098
		public unsafe static int touchPointerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_touchPointerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_touchPointerCount, (void*)(&value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x00067328 File Offset: 0x00065528
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x00009EA6 File Offset: 0x000080A6
		public unsafe static int penPointerIdBase
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_penPointerIdBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_penPointerIdBase, (void*)(&value));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x00067344 File Offset: 0x00065544
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x00009EB4 File Offset: 0x000080B4
		public unsafe static int penPointerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_penPointerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_penPointerCount, (void*)(&value));
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x00067360 File Offset: 0x00065560
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x00009EC2 File Offset: 0x000080C2
		public unsafe static Il2CppStructArray<int> hoveringPointers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_hoveringPointers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_hoveringPointers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeFieldInfoPtr_maxPointers;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr_invalidPointerId;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeFieldInfoPtr_mousePointerId;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeFieldInfoPtr_touchPointerIdBase;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeFieldInfoPtr_touchPointerCount;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_penPointerIdBase;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_penPointerCount;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeFieldInfoPtr_hoveringPointers;
	}
}
