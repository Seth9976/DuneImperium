using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000074 RID: 116
	public class GradientRule : Object
	{
		// Token: 0x0600089F RID: 2207 RVA: 0x0002BC34 File Offset: 0x00029E34
		// Note: this type is marked as 'beforefieldinit'.
		static GradientRule()
		{
			Il2CppClassPointerStore<GradientRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "GradientRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientRule>.NativeClassPtr);
			GradientRule.NativeFieldInfoPtr__Maxpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, "<Maxpoint>k__BackingField");
			GradientRule.NativeFieldInfoPtr__Midpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, "<Midpoint>k__BackingField");
			GradientRule.NativeFieldInfoPtr__Minpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, "<Minpoint>k__BackingField");
			GradientRule.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, "<ETag>k__BackingField");
			GradientRule.NativeMethodInfoPtr_get_Maxpoint_Public_Virtual_New_get_InterpolationPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664566);
			GradientRule.NativeMethodInfoPtr_set_Maxpoint_Public_Virtual_New_set_Void_InterpolationPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664567);
			GradientRule.NativeMethodInfoPtr_get_Midpoint_Public_Virtual_New_get_InterpolationPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664568);
			GradientRule.NativeMethodInfoPtr_set_Midpoint_Public_Virtual_New_set_Void_InterpolationPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664569);
			GradientRule.NativeMethodInfoPtr_get_Minpoint_Public_Virtual_New_get_InterpolationPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664570);
			GradientRule.NativeMethodInfoPtr_set_Minpoint_Public_Virtual_New_set_Void_InterpolationPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664571);
			GradientRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664572);
			GradientRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664573);
			GradientRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRule>.NativeClassPtr, 100664574);
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0002BD68 File Offset: 0x00029F68
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x0002BDB4 File Offset: 0x00029FB4
		public unsafe virtual InterpolationPoint Maxpoint
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientRule.NativeMethodInfoPtr_get_Maxpoint_Public_Virtual_New_get_InterpolationPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterpolationPoint>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientRule.NativeMethodInfoPtr_set_Maxpoint_Public_Virtual_New_set_Void_InterpolationPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0002BE04 File Offset: 0x0002A004
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0002BE50 File Offset: 0x0002A050
		public unsafe virtual InterpolationPoint Midpoint
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientRule.NativeMethodInfoPtr_get_Midpoint_Public_Virtual_New_get_InterpolationPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterpolationPoint>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientRule.NativeMethodInfoPtr_set_Midpoint_Public_Virtual_New_set_Void_InterpolationPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0002BEA0 File Offset: 0x0002A0A0
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x0002BEEC File Offset: 0x0002A0EC
		public unsafe virtual InterpolationPoint Minpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientRule.NativeMethodInfoPtr_get_Minpoint_Public_Virtual_New_get_InterpolationPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterpolationPoint>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientRule.NativeMethodInfoPtr_set_Minpoint_Public_Virtual_New_set_Void_InterpolationPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0002BF3C File Offset: 0x0002A13C
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0002BF80 File Offset: 0x0002A180
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0002BFD0 File Offset: 0x0002A1D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00006181 File Offset: 0x00004381
		public GradientRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0002C00C File Offset: 0x0002A20C
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0000618A File Offset: 0x0000438A
		public unsafe InterpolationPoint _Maxpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRule.NativeFieldInfoPtr__Maxpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterpolationPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRule.NativeFieldInfoPtr__Maxpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0002C03C File Offset: 0x0002A23C
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x000061A9 File Offset: 0x000043A9
		public unsafe InterpolationPoint _Midpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRule.NativeFieldInfoPtr__Midpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterpolationPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRule.NativeFieldInfoPtr__Midpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0002C06C File Offset: 0x0002A26C
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x000061C8 File Offset: 0x000043C8
		public unsafe InterpolationPoint _Minpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRule.NativeFieldInfoPtr__Minpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterpolationPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRule.NativeFieldInfoPtr__Minpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0002C09C File Offset: 0x0002A29C
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x000061E7 File Offset: 0x000043E7
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRule.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRule.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeFieldInfoPtr__Maxpoint_k__BackingField;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr__Midpoint_k__BackingField;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr__Minpoint_k__BackingField;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_get_Maxpoint_Public_Virtual_New_get_InterpolationPoint_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_set_Maxpoint_Public_Virtual_New_set_Void_InterpolationPoint_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_get_Midpoint_Public_Virtual_New_get_InterpolationPoint_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_set_Midpoint_Public_Virtual_New_set_Void_InterpolationPoint_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_get_Minpoint_Public_Virtual_New_get_InterpolationPoint_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_set_Minpoint_Public_Virtual_New_set_Void_InterpolationPoint_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
