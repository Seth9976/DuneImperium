using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200017F RID: 383
	public sealed class HTML_NeedsPaint_t : ValueType
	{
		// Token: 0x0600134E RID: 4942 RVA: 0x000678C0 File Offset: 0x00065AC0
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_NeedsPaint_t()
		{
			Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_NeedsPaint_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr);
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_PBGRA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "PBGRA");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnWide");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnTall");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnUpdateX");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnUpdateY");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnUpdateWide");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnUpdateTall");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnScrollX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnScrollX");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnScrollY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnScrollY");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_FlPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "FlPageScale");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_UnPageSerial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "UnPageSerial");
			HTML_NeedsPaint_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "_datasize");
			HTML_NeedsPaint_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, 100667221);
			HTML_NeedsPaint_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, 100667222);
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00067A1C File Offset: 0x00065C1C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950831, XrefRangeEnd = 950835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_NeedsPaint_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x00067A60 File Offset: 0x00065C60
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_NeedsPaint_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00005EAF File Offset: 0x000040AF
		public HTML_NeedsPaint_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00005EB8 File Offset: 0x000040B8
		public HTML_NeedsPaint_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00067AA4 File Offset: 0x00065CA4
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00005ECA File Offset: 0x000040CA
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00067ACC File Offset: 0x00065CCC
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00005EE5 File Offset: 0x000040E5
		public unsafe string PBGRA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_PBGRA);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_PBGRA), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00067AF4 File Offset: 0x00065CF4
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00005F04 File Offset: 0x00004104
		public unsafe uint UnWide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnWide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnWide)) = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00067B1C File Offset: 0x00065D1C
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x00005F1F File Offset: 0x0000411F
		public unsafe uint UnTall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnTall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnTall)) = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00067B44 File Offset: 0x00065D44
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x00005F3A File Offset: 0x0000413A
		public unsafe uint UnUpdateX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateX)) = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00067B6C File Offset: 0x00065D6C
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x00005F55 File Offset: 0x00004155
		public unsafe uint UnUpdateY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateY)) = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00067B94 File Offset: 0x00065D94
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x00005F70 File Offset: 0x00004170
		public unsafe uint UnUpdateWide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateWide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateWide)) = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00067BBC File Offset: 0x00065DBC
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x00005F8B File Offset: 0x0000418B
		public unsafe uint UnUpdateTall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateTall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnUpdateTall)) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00067BE4 File Offset: 0x00065DE4
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00005FA6 File Offset: 0x000041A6
		public unsafe uint UnScrollX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnScrollX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnScrollX)) = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x00067C0C File Offset: 0x00065E0C
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x00005FC1 File Offset: 0x000041C1
		public unsafe uint UnScrollY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnScrollY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnScrollY)) = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x00067C34 File Offset: 0x00065E34
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x00005FDC File Offset: 0x000041DC
		public unsafe float FlPageScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_FlPageScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_FlPageScale)) = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x00067C5C File Offset: 0x00065E5C
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x00005FF7 File Offset: 0x000041F7
		public unsafe uint UnPageSerial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnPageSerial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NeedsPaint_t.NativeFieldInfoPtr_UnPageSerial)) = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00067C84 File Offset: 0x00065E84
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00006012 File Offset: 0x00004212
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_NeedsPaint_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_NeedsPaint_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeFieldInfoPtr_PBGRA;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeFieldInfoPtr_UnWide;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeFieldInfoPtr_UnTall;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeFieldInfoPtr_UnUpdateX;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeFieldInfoPtr_UnUpdateY;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeFieldInfoPtr_UnUpdateWide;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeFieldInfoPtr_UnUpdateTall;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeFieldInfoPtr_UnScrollX;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeFieldInfoPtr_UnScrollY;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeFieldInfoPtr_FlPageScale;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeFieldInfoPtr_UnPageSerial;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
