using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.data
{
	// Token: 0x0200005E RID: 94
	public class BasicColor : VersionedDataComponent
	{
		// Token: 0x06000395 RID: 917 RVA: 0x00028E64 File Offset: 0x00027064
		// Note: this type is marked as 'beforefieldinit'.
		static BasicColor()
		{
			Il2CppClassPointerStore<BasicColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.data", "BasicColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicColor>.NativeClassPtr);
			BasicColor.NativeFieldInfoPtr_colorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicColor>.NativeClassPtr, "colorData");
			BasicColor.NativeMethodInfoPtr_get_ColorData_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicColor>.NativeClassPtr, 100663855);
			BasicColor.NativeMethodInfoPtr_set_ColorData_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicColor>.NativeClassPtr, 100663856);
			BasicColor.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicColor>.NativeClassPtr, 100663857);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00028EE4 File Offset: 0x000270E4
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00028F20 File Offset: 0x00027120
		public unsafe Color ColorData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicColor.NativeMethodInfoPtr_get_ColorData_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499919, XrefRangeEnd = 499920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicColor.NativeMethodInfoPtr_set_ColorData_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00028F60 File Offset: 0x00027160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499920, XrefRangeEnd = 499922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicColor(Color c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicColor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicColor.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00003917 File Offset: 0x00001B17
		public BasicColor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00028FA8 File Offset: 0x000271A8
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00003920 File Offset: 0x00001B20
		public unsafe Color colorData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicColor.NativeFieldInfoPtr_colorData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicColor.NativeFieldInfoPtr_colorData)) = value;
			}
		}

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_colorData;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorData_Public_get_Color_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorData_Public_set_Void_Color_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;
	}
}
