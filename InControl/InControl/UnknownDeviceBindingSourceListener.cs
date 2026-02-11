using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200001F RID: 31
	public class UnknownDeviceBindingSourceListener : Object
	{
		// Token: 0x0600020F RID: 527 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		// Note: this type is marked as 'beforefieldinit'.
		static UnknownDeviceBindingSourceListener()
		{
			Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnknownDeviceBindingSourceListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr);
			UnknownDeviceBindingSourceListener.NativeFieldInfoPtr_detectFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr, "detectFound");
			UnknownDeviceBindingSourceListener.NativeFieldInfoPtr_detectPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr, "detectPhase");
			UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr, 100663597);
			UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_TakeSnapshotOnUnknownDevices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr, 100663598);
			UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr, 100663599);
			UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_IsPressed_Private_Boolean_UnknownDeviceControl_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr, 100663600);
			UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_ListenForControl_Private_UnknownDeviceControl_BindingListenOptions_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr, 100663601);
			UnknownDeviceBindingSourceListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr, 100663602);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000F694 File Offset: 0x0000D894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769010, XrefRangeEnd = 769028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000F6C8 File Offset: 0x0000D8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769028, XrefRangeEnd = 769042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeSnapshotOnUnknownDevices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_TakeSnapshotOnUnknownDevices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000F6FC File Offset: 0x0000D8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769042, XrefRangeEnd = 769080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listenOptions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingSource>(intPtr3) : null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000F760 File Offset: 0x0000D960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769080, XrefRangeEnd = 769088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPressed(UnknownDeviceControl control, InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_IsPressed_Private_Boolean_UnknownDeviceControl_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000F7BC File Offset: 0x0000D9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769088, XrefRangeEnd = 769097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownDeviceControl ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listenOptions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSourceListener.NativeMethodInfoPtr_ListenForControl_Private_UnknownDeviceControl_BindingListenOptions_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000F81C File Offset: 0x0000DA1C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownDeviceBindingSourceListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownDeviceBindingSourceListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSourceListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002B72 File Offset: 0x00000D72
		public UnknownDeviceBindingSourceListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000F858 File Offset: 0x0000DA58
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002B7B File Offset: 0x00000D7B
		public unsafe UnknownDeviceControl detectFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownDeviceBindingSourceListener.NativeFieldInfoPtr_detectFound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownDeviceBindingSourceListener.NativeFieldInfoPtr_detectFound)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000F880 File Offset: 0x0000DA80
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002B96 File Offset: 0x00000D96
		public unsafe UnknownDeviceBindingSourceListener.DetectPhase detectPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownDeviceBindingSourceListener.NativeFieldInfoPtr_detectPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownDeviceBindingSourceListener.NativeFieldInfoPtr_detectPhase)) = value;
			}
		}

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_detectFound;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_detectPhase;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_TakeSnapshotOnUnknownDevices_Private_Void_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_IsPressed_Private_Boolean_UnknownDeviceControl_InputDevice_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_ListenForControl_Private_UnknownDeviceControl_BindingListenOptions_InputDevice_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000210 RID: 528
		public enum DetectPhase
		{
			// Token: 0x04000D85 RID: 3461
			WaitForInitialRelease,
			// Token: 0x04000D86 RID: 3462
			WaitForControlPress,
			// Token: 0x04000D87 RID: 3463
			WaitForControlRelease
		}
	}
}
