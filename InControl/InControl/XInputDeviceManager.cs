using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using InControl.Internal;
using XInputDotNetPure;

namespace InControl
{
	// Token: 0x02000073 RID: 115
	public class XInputDeviceManager : InputDeviceManager
	{
		// Token: 0x06000A9E RID: 2718 RVA: 0x0002E438 File Offset: 0x0002C638
		// Note: this type is marked as 'beforefieldinit'.
		static XInputDeviceManager()
		{
			Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "XInputDeviceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr);
			XInputDeviceManager.NativeFieldInfoPtr_deviceConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, "deviceConnected");
			XInputDeviceManager.NativeFieldInfoPtr_maxDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, "maxDevices");
			XInputDeviceManager.NativeFieldInfoPtr_gamePadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, "gamePadState");
			XInputDeviceManager.NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, "thread");
			XInputDeviceManager.NativeFieldInfoPtr_timeStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, "timeStep");
			XInputDeviceManager.NativeFieldInfoPtr_bufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, "bufferSize");
			XInputDeviceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664757);
			XInputDeviceManager.NativeMethodInfoPtr_StartWorker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664758);
			XInputDeviceManager.NativeMethodInfoPtr_StopWorker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664759);
			XInputDeviceManager.NativeMethodInfoPtr_Worker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664760);
			XInputDeviceManager.NativeMethodInfoPtr_GetState_Internal_GamePadState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664761);
			XInputDeviceManager.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664762);
			XInputDeviceManager.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664763);
			XInputDeviceManager.NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Boolean_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664764);
			XInputDeviceManager.NativeMethodInfoPtr_Enable_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr, 100664765);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0002E594 File Offset: 0x0002C794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791240, XrefRangeEnd = 791311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XInputDeviceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XInputDeviceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDeviceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002E5D0 File Offset: 0x0002C7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791311, XrefRangeEnd = 791324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartWorker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDeviceManager.NativeMethodInfoPtr_StartWorker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002E604 File Offset: 0x0002C804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791324, XrefRangeEnd = 791327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopWorker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDeviceManager.NativeMethodInfoPtr_StopWorker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0002E638 File Offset: 0x0002C838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791327, XrefRangeEnd = 791333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Worker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDeviceManager.NativeMethodInfoPtr_Worker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0002E66C File Offset: 0x0002C86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791333, XrefRangeEnd = 791336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamePadState GetState(int deviceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDeviceManager.NativeMethodInfoPtr_GetState_Internal_GamePadState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0002E6B8 File Offset: 0x0002C8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791336, XrefRangeEnd = 791350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XInputDeviceManager.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0002E710 File Offset: 0x0002C910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XInputDeviceManager.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0002E74C File Offset: 0x0002C94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791358, RefRangeEnd = 791359, XrefRangeStart = 791350, XrefRangeEnd = 791358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckPlatformSupport(ICollection<string> errors)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(errors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDeviceManager.NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Boolean_ICollection_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0002E790 File Offset: 0x0002C990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791419, RefRangeEnd = 791420, XrefRangeStart = 791359, XrefRangeEnd = 791419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDeviceManager.NativeMethodInfoPtr_Enable_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00005F23 File Offset: 0x00004123
		public XInputDeviceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0002E7B8 File Offset: 0x0002C9B8
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00005F2C File Offset: 0x0000412C
		public unsafe Il2CppStructArray<bool> deviceConnected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_deviceConnected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_deviceConnected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0002E7E8 File Offset: 0x0002C9E8
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00005F4B File Offset: 0x0000414B
		public unsafe static int maxDevices
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XInputDeviceManager.NativeFieldInfoPtr_maxDevices, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XInputDeviceManager.NativeFieldInfoPtr_maxDevices, (void*)(&value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0002E804 File Offset: 0x0002CA04
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00005F59 File Offset: 0x00004159
		public unsafe Il2CppReferenceArray<RingBuffer<GamePadState>> gamePadState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_gamePadState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RingBuffer<GamePadState>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_gamePadState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002E834 File Offset: 0x0002CA34
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00005F78 File Offset: 0x00004178
		public unsafe Thread thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0002E864 File Offset: 0x0002CA64
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00005F97 File Offset: 0x00004197
		public unsafe int timeStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_timeStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_timeStep)) = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002E88C File Offset: 0x0002CA8C
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00005FB2 File Offset: 0x000041B2
		public unsafe int bufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_bufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDeviceManager.NativeFieldInfoPtr_bufferSize)) = value;
			}
		}

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_deviceConnected;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_maxDevices;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_gamePadState;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeFieldInfoPtr_thread;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeFieldInfoPtr_timeStep;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeFieldInfoPtr_bufferSize;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_StartWorker_Private_Void_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_StopWorker_Private_Void_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_Worker_Private_Void_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Internal_GamePadState_Int32_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Boolean_ICollection_1_String_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Internal_Static_Void_0;
	}
}
