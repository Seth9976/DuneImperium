using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.animation
{
	// Token: 0x0200000A RID: 10
	public class ExposeImageProperty : MonoBehaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003C34 File Offset: 0x00001E34
		// Note: this type is marked as 'beforefieldinit'.
		static ExposeImageProperty()
		{
			Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "ExposeImageProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr);
			ExposeImageProperty.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr, "property");
			ExposeImageProperty.NativeFieldInfoPtr_floatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr, "floatValue");
			ExposeImageProperty.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr, "image");
			ExposeImageProperty.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr, "mat");
			ExposeImageProperty.NativeFieldInfoPtr_propertyHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr, "propertyHash");
			ExposeImageProperty.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr, 100663336);
			ExposeImageProperty.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr, 100663337);
			ExposeImageProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr, 100663338);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003D04 File Offset: 0x00001F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263274, XrefRangeEnd = 1263280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExposeImageProperty.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003D38 File Offset: 0x00001F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263280, XrefRangeEnd = 1263282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExposeImageProperty.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003D6C File Offset: 0x00001F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263282, XrefRangeEnd = 1263287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExposeImageProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExposeImageProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExposeImageProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002302 File Offset: 0x00000502
		public ExposeImageProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003DA8 File Offset: 0x00001FA8
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000230B File Offset: 0x0000050B
		public unsafe string property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_property);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003DD0 File Offset: 0x00001FD0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000232A File Offset: 0x0000052A
		public unsafe float floatValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_floatValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_floatValue)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00003DF8 File Offset: 0x00001FF8
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002345 File Offset: 0x00000545
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00003E28 File Offset: 0x00002028
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002364 File Offset: 0x00000564
		public unsafe Material mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00003E58 File Offset: 0x00002058
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002383 File Offset: 0x00000583
		public unsafe int propertyHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_propertyHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposeImageProperty.NativeFieldInfoPtr_propertyHash)) = value;
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_property;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_floatValue;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_mat;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_propertyHash;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
