using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200018A RID: 394
	public sealed class HTML_LinkAtPosition_t : ValueType
	{
		// Token: 0x060013D2 RID: 5074 RVA: 0x00068C2C File Offset: 0x00066E2C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_LinkAtPosition_t()
		{
			Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_LinkAtPosition_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr);
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "X");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "Y");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_PchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "PchURL");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_BInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "BInput");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_BLiveLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "BLiveLink");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "_datasize");
			HTML_LinkAtPosition_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, 100667254);
			HTML_LinkAtPosition_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, 100667255);
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00068D10 File Offset: 0x00066F10
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950875, XrefRangeEnd = 950879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_LinkAtPosition_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x00068D54 File Offset: 0x00066F54
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_LinkAtPosition_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0000639B File Offset: 0x0000459B
		public HTML_LinkAtPosition_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x000063A4 File Offset: 0x000045A4
		public HTML_LinkAtPosition_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00068D98 File Offset: 0x00066F98
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x000063B6 File Offset: 0x000045B6
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00068DC0 File Offset: 0x00066FC0
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x000063D1 File Offset: 0x000045D1
		public unsafe uint X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_X);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_X)) = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00068DE8 File Offset: 0x00066FE8
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x000063EC File Offset: 0x000045EC
		public unsafe uint Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_Y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_Y)) = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00068E10 File Offset: 0x00067010
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x00006407 File Offset: 0x00004607
		public unsafe string PchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_PchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_PchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x00068E38 File Offset: 0x00067038
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00006426 File Offset: 0x00004626
		public unsafe bool BInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_BInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_BInput)) = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00068E60 File Offset: 0x00067060
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x00006441 File Offset: 0x00004641
		public unsafe bool BLiveLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_BLiveLink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_BLiveLink)) = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00068E88 File Offset: 0x00067088
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0000645C File Offset: 0x0000465C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_LinkAtPosition_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_LinkAtPosition_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeFieldInfoPtr_PchURL;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeFieldInfoPtr_BInput;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeFieldInfoPtr_BLiveLink;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
