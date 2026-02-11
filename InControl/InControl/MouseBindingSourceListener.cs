using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000019 RID: 25
	public class MouseBindingSourceListener : Object
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0000B5C0 File Offset: 0x000097C0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseBindingSourceListener()
		{
			Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "MouseBindingSourceListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr);
			MouseBindingSourceListener.NativeFieldInfoPtr_ScrollWheelThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr, "ScrollWheelThreshold");
			MouseBindingSourceListener.NativeFieldInfoPtr_detectFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr, "detectFound");
			MouseBindingSourceListener.NativeFieldInfoPtr_detectPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr, "detectPhase");
			MouseBindingSourceListener.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr, 100663458);
			MouseBindingSourceListener.NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr, 100663459);
			MouseBindingSourceListener.NativeMethodInfoPtr_IsPressed_Private_Boolean_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr, 100663460);
			MouseBindingSourceListener.NativeMethodInfoPtr_ListenForControl_Private_Mouse_BindingListenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr, 100663461);
			MouseBindingSourceListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr, 100663462);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000B690 File Offset: 0x00009890
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSourceListener.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000B6C4 File Offset: 0x000098C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767931, XrefRangeEnd = 767954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSourceListener.NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingSource>(intPtr3) : null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000B728 File Offset: 0x00009928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767954, XrefRangeEnd = 767971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPressed(Mouse control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSourceListener.NativeMethodInfoPtr_IsPressed_Private_Boolean_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000B774 File Offset: 0x00009974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767971, XrefRangeEnd = 767988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mouse ListenForControl(BindingListenOptions listenOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listenOptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSourceListener.NativeMethodInfoPtr_ListenForControl_Private_Mouse_BindingListenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000B7C4 File Offset: 0x000099C4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseBindingSourceListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseBindingSourceListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSourceListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000247B File Offset: 0x0000067B
		public MouseBindingSourceListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000B800 File Offset: 0x00009A00
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002484 File Offset: 0x00000684
		public unsafe static float ScrollWheelThreshold
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MouseBindingSourceListener.NativeFieldInfoPtr_ScrollWheelThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseBindingSourceListener.NativeFieldInfoPtr_ScrollWheelThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000B81C File Offset: 0x00009A1C
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002492 File Offset: 0x00000692
		public unsafe Mouse detectFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseBindingSourceListener.NativeFieldInfoPtr_detectFound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseBindingSourceListener.NativeFieldInfoPtr_detectFound)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000B844 File Offset: 0x00009A44
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000024AD File Offset: 0x000006AD
		public unsafe int detectPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseBindingSourceListener.NativeFieldInfoPtr_detectPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseBindingSourceListener.NativeFieldInfoPtr_detectPhase)) = value;
			}
		}

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_ScrollWheelThreshold;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr_detectFound;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_detectPhase;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_IsPressed_Private_Boolean_Mouse_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_ListenForControl_Private_Mouse_BindingListenOptions_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
