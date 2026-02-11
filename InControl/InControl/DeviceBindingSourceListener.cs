using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000012 RID: 18
	public class DeviceBindingSourceListener : Object
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00009898 File Offset: 0x00007A98
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceBindingSourceListener()
		{
			Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "DeviceBindingSourceListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr);
			DeviceBindingSourceListener.NativeFieldInfoPtr_detectFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr, "detectFound");
			DeviceBindingSourceListener.NativeFieldInfoPtr_detectPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr, "detectPhase");
			DeviceBindingSourceListener.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr, 100663384);
			DeviceBindingSourceListener.NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr, 100663385);
			DeviceBindingSourceListener.NativeMethodInfoPtr_IsPressed_Private_Boolean_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr, 100663386);
			DeviceBindingSourceListener.NativeMethodInfoPtr_IsPressed_Private_Boolean_InputControlType_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr, 100663387);
			DeviceBindingSourceListener.NativeMethodInfoPtr_ListenForControl_Private_InputControlType_BindingListenOptions_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr, 100663388);
			DeviceBindingSourceListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr, 100663389);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009968 File Offset: 0x00007B68
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSourceListener.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000999C File Offset: 0x00007B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767617, XrefRangeEnd = 767627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSourceListener.NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingSource>(intPtr3) : null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00009A00 File Offset: 0x00007C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767633, RefRangeEnd = 767634, XrefRangeStart = 767627, XrefRangeEnd = 767633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPressed(InputControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSourceListener.NativeMethodInfoPtr_IsPressed_Private_Boolean_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00009A50 File Offset: 0x00007C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767634, XrefRangeEnd = 767641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPressed(InputControlType control, InputDevice device)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSourceListener.NativeMethodInfoPtr_IsPressed_Private_Boolean_InputControlType_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00009AAC File Offset: 0x00007CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767641, XrefRangeEnd = 767649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlType ListenForControl(BindingListenOptions listenOptions, InputDevice device)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSourceListener.NativeMethodInfoPtr_ListenForControl_Private_InputControlType_BindingListenOptions_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00009B0C File Offset: 0x00007D0C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBindingSourceListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceBindingSourceListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSourceListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002302 File Offset: 0x00000502
		public DeviceBindingSourceListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00009B48 File Offset: 0x00007D48
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000230B File Offset: 0x0000050B
		public unsafe InputControlType detectFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceBindingSourceListener.NativeFieldInfoPtr_detectFound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceBindingSourceListener.NativeFieldInfoPtr_detectFound)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00009B70 File Offset: 0x00007D70
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002326 File Offset: 0x00000526
		public unsafe int detectPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceBindingSourceListener.NativeFieldInfoPtr_detectPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceBindingSourceListener.NativeFieldInfoPtr_detectPhase)) = value;
			}
		}

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_detectFound;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_detectPhase;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_IsPressed_Private_Boolean_InputControl_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_IsPressed_Private_Boolean_InputControlType_InputDevice_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_ListenForControl_Private_InputControlType_BindingListenOptions_InputDevice_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
