using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.input.multitouch
{
	// Token: 0x02000068 RID: 104
	public class GestureProcessor : Object
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x00012FBC File Offset: 0x000111BC
		// Note: this type is marked as 'beforefieldinit'.
		static GestureProcessor()
		{
			Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "GestureProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr);
			GestureProcessor.NativeFieldInfoPtr_updateGesturesCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr, "updateGesturesCallback");
			GestureProcessor.NativeFieldInfoPtr_GestureDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr, "GestureDict");
			GestureProcessor.NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr, 100663734);
			GestureProcessor.NativeMethodInfoPtr_GetGesture_Public_Gesture_Int32_List_1_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr, 100663735);
			GestureProcessor.NativeMethodInfoPtr_UpdateGestures_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr, 100663736);
			GestureProcessor.NativeMethodInfoPtr_HandleNewTouch_Public_Void_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr, 100663737);
			GestureProcessor.NativeMethodInfoPtr_RemoveTouch_Public_Void_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr, 100663738);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00013078 File Offset: 0x00011278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122145, XrefRangeEnd = 1122154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GestureProcessor(Action updateGesturesCallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GestureProcessor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updateGesturesCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureProcessor.NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000130C4 File Offset: 0x000112C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122154, XrefRangeEnd = 1122165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gesture GetGesture(int fingers, List<TouchPress> currentTouches)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fingers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTouches);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureProcessor.NativeMethodInfoPtr_GetGesture_Public_Gesture_Int32_List_1_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr3) : null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00013124 File Offset: 0x00011324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1122182, RefRangeEnd = 1122183, XrefRangeStart = 1122165, XrefRangeEnd = 1122182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGestures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureProcessor.NativeMethodInfoPtr_UpdateGestures_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00013158 File Offset: 0x00011358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1122199, RefRangeEnd = 1122200, XrefRangeStart = 1122183, XrefRangeEnd = 1122199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleNewTouch(TouchPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureProcessor.NativeMethodInfoPtr_HandleNewTouch_Public_Void_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001319C File Offset: 0x0001139C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1122233, RefRangeEnd = 1122234, XrefRangeStart = 1122200, XrefRangeEnd = 1122233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTouch(TouchPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureProcessor.NativeMethodInfoPtr_RemoveTouch_Public_Void_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000442E File Offset: 0x0000262E
		public GestureProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x000131E0 File Offset: 0x000113E0
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00004437 File Offset: 0x00002637
		public unsafe Action updateGesturesCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GestureProcessor.NativeFieldInfoPtr_updateGesturesCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GestureProcessor.NativeFieldInfoPtr_updateGesturesCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00013210 File Offset: 0x00011410
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00004456 File Offset: 0x00002656
		public unsafe Dictionary<int, MutableGesture> GestureDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GestureProcessor.NativeFieldInfoPtr_GestureDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MutableGesture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GestureProcessor.NativeFieldInfoPtr_GestureDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_updateGesturesCallback;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_GestureDict;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_GetGesture_Public_Gesture_Int32_List_1_TouchPress_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGestures_Public_Void_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_HandleNewTouch_Public_Void_TouchPress_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTouch_Public_Void_TouchPress_0;
	}
}
