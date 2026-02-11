using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004D RID: 77
	public class AxisEventData : BaseEventData
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x0002A6BC File Offset: 0x000288BC
		// Note: this type is marked as 'beforefieldinit'.
		static AxisEventData()
		{
			Il2CppClassPointerStore<AxisEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "AxisEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr);
			AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, "<moveVector>k__BackingField");
			AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, "<moveDir>k__BackingField");
			AxisEventData.NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664808);
			AxisEventData.NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664809);
			AxisEventData.NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664810);
			AxisEventData.NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664811);
			AxisEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664812);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0002A778 File Offset: 0x00028978
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0002A7B4 File Offset: 0x000289B4
		public unsafe Vector2 moveVector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0002A7F4 File Offset: 0x000289F4
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0002A830 File Offset: 0x00028A30
		public unsafe MoveDirection moveDir
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0002A870 File Offset: 0x00028A70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1094788, RefRangeEnd = 1094792, XrefRangeStart = 1094784, XrefRangeEnd = 1094788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000050A5 File Offset: 0x000032A5
		public AxisEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0002A8BC File Offset: 0x00028ABC
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x000050AE File Offset: 0x000032AE
		public unsafe Vector2 _moveVector_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0002A8E4 File Offset: 0x00028AE4
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x000050C9 File Offset: 0x000032C9
		public unsafe MoveDirection _moveDir_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField)) = value;
			}
		}

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr__moveVector_k__BackingField;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr__moveDir_k__BackingField;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;
	}
}
