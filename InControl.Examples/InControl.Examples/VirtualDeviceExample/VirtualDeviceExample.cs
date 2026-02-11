using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace VirtualDeviceExample
{
	// Token: 0x02000009 RID: 9
	public class VirtualDeviceExample : MonoBehaviour
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00004428 File Offset: 0x00002628
		// Note: this type is marked as 'beforefieldinit'.
		static VirtualDeviceExample()
		{
			Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "VirtualDeviceExample", "VirtualDeviceExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr);
			VirtualDeviceExample.NativeFieldInfoPtr_leftObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr, "leftObject");
			VirtualDeviceExample.NativeFieldInfoPtr_rightObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr, "rightObject");
			VirtualDeviceExample.NativeFieldInfoPtr_virtualDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr, "virtualDevice");
			VirtualDeviceExample.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr, 100663352);
			VirtualDeviceExample.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr, 100663353);
			VirtualDeviceExample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr, 100663354);
			VirtualDeviceExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr, 100663355);
			VirtualDeviceExample.NativeMethodInfoPtr__OnEnable_b__3_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr, 100663356);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000044F8 File Offset: 0x000026F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251590, XrefRangeEnd = 1251646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDeviceExample.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000452C File Offset: 0x0000272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251646, XrefRangeEnd = 1251650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDeviceExample.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004560 File Offset: 0x00002760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251650, XrefRangeEnd = 1251695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDeviceExample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004594 File Offset: 0x00002794
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VirtualDeviceExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VirtualDeviceExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDeviceExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000045D0 File Offset: 0x000027D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251695, XrefRangeEnd = 1251699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__3_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDeviceExample.NativeMethodInfoPtr__OnEnable_b__3_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000246F File Offset: 0x0000066F
		public VirtualDeviceExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00004604 File Offset: 0x00002804
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002478 File Offset: 0x00000678
		public unsafe GameObject leftObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDeviceExample.NativeFieldInfoPtr_leftObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDeviceExample.NativeFieldInfoPtr_leftObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00004634 File Offset: 0x00002834
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002497 File Offset: 0x00000697
		public unsafe GameObject rightObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDeviceExample.NativeFieldInfoPtr_rightObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDeviceExample.NativeFieldInfoPtr_rightObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004664 File Offset: 0x00002864
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000024B6 File Offset: 0x000006B6
		public unsafe VirtualDevice virtualDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDeviceExample.NativeFieldInfoPtr_virtualDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VirtualDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDeviceExample.NativeFieldInfoPtr_virtualDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_leftObject;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_rightObject;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_virtualDevice;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__3_0_Private_Void_0;
	}
}
