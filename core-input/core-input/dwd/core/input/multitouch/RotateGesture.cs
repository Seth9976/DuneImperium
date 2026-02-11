using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.multitouch
{
	// Token: 0x0200006D RID: 109
	public sealed class RotateGesture : MonoBehaviour
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x00014030 File Offset: 0x00012230
		// Note: this type is marked as 'beforefieldinit'.
		static RotateGesture()
		{
			Il2CppClassPointerStore<RotateGesture>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "RotateGesture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr);
			RotateGesture.NativeFieldInfoPtr__TwoFingerGesture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr, "<TwoFingerGesture>k__BackingField");
			RotateGesture.NativeFieldInfoPtr_PreviousPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr, "PreviousPosition");
			RotateGesture.NativeMethodInfoPtr_get_TwoFingerGesture_Public_get_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr, 100663774);
			RotateGesture.NativeMethodInfoPtr_set_TwoFingerGesture_Private_set_Void_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr, 100663775);
			RotateGesture.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr, 100663776);
			RotateGesture.NativeMethodInfoPtr_get_Delta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr, 100663777);
			RotateGesture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr, 100663778);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x000140EC File Offset: 0x000122EC
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0001412C File Offset: 0x0001232C
		public unsafe Gesture TwoFingerGesture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateGesture.NativeMethodInfoPtr_get_TwoFingerGesture_Public_get_Gesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateGesture.NativeMethodInfoPtr_set_TwoFingerGesture_Private_set_Void_Gesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00014170 File Offset: 0x00012370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122585, XrefRangeEnd = 1122593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateGesture.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x000141A4 File Offset: 0x000123A4
		public unsafe float Delta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122593, XrefRangeEnd = 1122595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateGesture.NativeMethodInfoPtr_get_Delta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000141E0 File Offset: 0x000123E0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateGesture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateGesture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateGesture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000046BB File Offset: 0x000028BB
		public RotateGesture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0001421C File Offset: 0x0001241C
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x000046C4 File Offset: 0x000028C4
		public unsafe Gesture _TwoFingerGesture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateGesture.NativeFieldInfoPtr__TwoFingerGesture_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateGesture.NativeFieldInfoPtr__TwoFingerGesture_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0001424C File Offset: 0x0001244C
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x000046E3 File Offset: 0x000028E3
		public unsafe ReadOnlyDictionary<TouchPress, Vector2> PreviousPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateGesture.NativeFieldInfoPtr_PreviousPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<TouchPress, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateGesture.NativeFieldInfoPtr_PreviousPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr__TwoFingerGesture_k__BackingField;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_PreviousPosition;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoFingerGesture_Public_get_Gesture_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_set_TwoFingerGesture_Private_set_Void_Gesture_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_get_Delta_Public_get_Single_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
