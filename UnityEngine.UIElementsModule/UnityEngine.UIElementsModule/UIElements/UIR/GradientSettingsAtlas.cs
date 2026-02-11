using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000253 RID: 595
	public class GradientSettingsAtlas : Object
	{
		// Token: 0x06002C05 RID: 11269 RVA: 0x000BDDD0 File Offset: 0x000BBFD0
		// Note: this type is marked as 'beforefieldinit'.
		static GradientSettingsAtlas()
		{
			Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "GradientSettingsAtlas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr);
			GradientSettingsAtlas.NativeFieldInfoPtr_s_MarkerWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "s_MarkerWrite");
			GradientSettingsAtlas.NativeFieldInfoPtr_s_MarkerCommit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "s_MarkerCommit");
			GradientSettingsAtlas.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "m_Length");
			GradientSettingsAtlas.NativeFieldInfoPtr_m_ElemWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "m_ElemWidth");
			GradientSettingsAtlas.NativeFieldInfoPtr_m_Allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "m_Allocator");
			GradientSettingsAtlas.NativeFieldInfoPtr_m_Atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "m_Atlas");
			GradientSettingsAtlas.NativeFieldInfoPtr_m_RawAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "m_RawAtlas");
			GradientSettingsAtlas.NativeFieldInfoPtr_s_TextureCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "s_TextureCounter");
			GradientSettingsAtlas.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "<disposed>k__BackingField");
			GradientSettingsAtlas.NativeFieldInfoPtr__MustCommit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "<MustCommit>k__BackingField");
			GradientSettingsAtlas.NativeMethodInfoPtr_get_length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669819);
			GradientSettingsAtlas.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669820);
			GradientSettingsAtlas.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669821);
			GradientSettingsAtlas.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669822);
			GradientSettingsAtlas.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669823);
			GradientSettingsAtlas.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669824);
			GradientSettingsAtlas.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669825);
			GradientSettingsAtlas.NativeMethodInfoPtr_get_atlas_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669826);
			GradientSettingsAtlas.NativeMethodInfoPtr_Add_Public_Alloc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669827);
			GradientSettingsAtlas.NativeMethodInfoPtr_Write_Public_Void_Alloc_Il2CppStructArray_1_GradientSettings_GradientRemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669828);
			GradientSettingsAtlas.NativeMethodInfoPtr_get_MustCommit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669829);
			GradientSettingsAtlas.NativeMethodInfoPtr_set_MustCommit_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669830);
			GradientSettingsAtlas.NativeMethodInfoPtr_Commit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669831);
			GradientSettingsAtlas.NativeMethodInfoPtr_PrepareAtlas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, 100669832);
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x000BDFE0 File Offset: 0x000BC1E0
		public unsafe int length
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_get_length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x000BE01C File Offset: 0x000BC21C
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x000BE058 File Offset: 0x000BC258
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000BE098 File Offset: 0x000BC298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349971, RefRangeEnd = 349972, XrefRangeStart = 349967, XrefRangeEnd = 349971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000BE0CC File Offset: 0x000BC2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349972, XrefRangeEnd = 349976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientSettingsAtlas.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000BE118 File Offset: 0x000BC318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349986, RefRangeEnd = 349987, XrefRangeStart = 349976, XrefRangeEnd = 349986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientSettingsAtlas(int length = 4096)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000BE160 File Offset: 0x000BC360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349987, XrefRangeEnd = 349996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x000BE194 File Offset: 0x000BC394
		public unsafe Texture2D atlas
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 337628, RefRangeEnd = 337663, XrefRangeStart = 337628, XrefRangeEnd = 337663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_get_atlas_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000BE1D4 File Offset: 0x000BC3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350001, RefRangeEnd = 350002, XrefRangeStart = 349996, XrefRangeEnd = 350001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alloc Add(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_Add_Public_Alloc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Alloc(intPtr);
			}
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000BE218 File Offset: 0x000BC418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350021, RefRangeEnd = 350022, XrefRangeStart = 350002, XrefRangeEnd = 350021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Alloc alloc, Il2CppStructArray<GradientSettings> settings, GradientRemap remap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(alloc));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_Write_Public_Void_Alloc_Il2CppStructArray_1_GradientSettings_GradientRemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x000BE284 File Offset: 0x000BC484
		// (set) Token: 0x06002C11 RID: 11281 RVA: 0x000BE2C0 File Offset: 0x000BC4C0
		public unsafe bool MustCommit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_get_MustCommit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_set_MustCommit_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000BE300 File Offset: 0x000BC500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350044, RefRangeEnd = 350045, XrefRangeStart = 350022, XrefRangeEnd = 350044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_Commit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000BE334 File Offset: 0x000BC534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350045, XrefRangeEnd = 350065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareAtlas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.NativeMethodInfoPtr_PrepareAtlas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00011DFB File Offset: 0x0000FFFB
		public GradientSettingsAtlas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x000BE368 File Offset: 0x000BC568
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x00011E04 File Offset: 0x00010004
		public unsafe static ProfilerMarker s_MarkerWrite
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(GradientSettingsAtlas.NativeFieldInfoPtr_s_MarkerWrite, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GradientSettingsAtlas.NativeFieldInfoPtr_s_MarkerWrite, (void*)(&value));
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000BE384 File Offset: 0x000BC584
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x00011E12 File Offset: 0x00010012
		public unsafe static ProfilerMarker s_MarkerCommit
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(GradientSettingsAtlas.NativeFieldInfoPtr_s_MarkerCommit, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GradientSettingsAtlas.NativeFieldInfoPtr_s_MarkerCommit, (void*)(&value));
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x000BE3A0 File Offset: 0x000BC5A0
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x00011E20 File Offset: 0x00010020
		public unsafe int m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x000BE3C8 File Offset: 0x000BC5C8
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x00011E3B File Offset: 0x0001003B
		public unsafe int m_ElemWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_ElemWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_ElemWidth)) = value;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x000BE3F0 File Offset: 0x000BC5F0
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x00011E56 File Offset: 0x00010056
		public unsafe BestFitAllocator m_Allocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_Allocator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_Allocator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x000BE420 File Offset: 0x000BC620
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00011E75 File Offset: 0x00010075
		public unsafe Texture2D m_Atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_Atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_Atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x000BE450 File Offset: 0x000BC650
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00011E94 File Offset: 0x00010094
		public GradientSettingsAtlas.RawTexture m_RawAtlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_RawAtlas);
				return new GradientSettingsAtlas.RawTexture(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr_m_RawAtlas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x000BE480 File Offset: 0x000BC680
		// (set) Token: 0x06002C24 RID: 11300 RVA: 0x00011EC2 File Offset: 0x000100C2
		public unsafe static int s_TextureCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GradientSettingsAtlas.NativeFieldInfoPtr_s_TextureCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GradientSettingsAtlas.NativeFieldInfoPtr_s_TextureCounter, (void*)(&value));
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000BE49C File Offset: 0x000BC69C
		// (set) Token: 0x06002C26 RID: 11302 RVA: 0x00011ED0 File Offset: 0x000100D0
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x000BE4C4 File Offset: 0x000BC6C4
		// (set) Token: 0x06002C28 RID: 11304 RVA: 0x00011EEB File Offset: 0x000100EB
		public unsafe bool _MustCommit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr__MustCommit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.NativeFieldInfoPtr__MustCommit_k__BackingField)) = value;
			}
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000BE4EC File Offset: 0x000BC6EC
		public void Remove(Alloc alloc)
		{
			bool disposed = this.disposed;
			if (disposed)
			{
				DisposeHelper.NotifyDisposedUsed(this);
			}
			else
			{
				this.m_Allocator.Free(alloc);
			}
		}

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerWrite;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerCommit;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeFieldInfoPtr_m_ElemWidth;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeFieldInfoPtr_m_Allocator;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeFieldInfoPtr_m_Atlas;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeFieldInfoPtr_m_RawAtlas;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeFieldInfoPtr_s_TextureCounter;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeFieldInfoPtr__MustCommit_k__BackingField;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Internal_get_Int32_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_get_atlas_Public_get_Texture2D_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Alloc_Int32_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Alloc_Il2CppStructArray_1_GradientSettings_GradientRemap_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_get_MustCommit_Public_get_Boolean_0;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeMethodInfoPtr_set_MustCommit_Private_set_Void_Boolean_0;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Void_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr_PrepareAtlas_Private_Void_0;

		// Token: 0x0200054F RID: 1359
		public sealed class RawTexture : ValueType
		{
			// Token: 0x06004170 RID: 16752 RVA: 0x001024C0 File Offset: 0x001006C0
			// Note: this type is marked as 'beforefieldinit'.
			static RawTexture()
			{
				Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GradientSettingsAtlas>.NativeClassPtr, "RawTexture");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr);
				GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_rgba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr, "rgba");
				GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr, "width");
				GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr, "height");
				GradientSettingsAtlas.RawTexture.NativeMethodInfoPtr_WriteRawInt2Packed_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr, 100669834);
				GradientSettingsAtlas.RawTexture.NativeMethodInfoPtr_WriteRawFloat4Packed_Public_Void_Single_Single_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr, 100669835);
			}

			// Token: 0x06004171 RID: 16753 RVA: 0x00102550 File Offset: 0x00100750
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349964, RefRangeEnd = 349966, XrefRangeStart = 349964, XrefRangeEnd = 349964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteRawInt2Packed(int v0, int v1, int destX, int destY)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.RawTexture.NativeMethodInfoPtr_WriteRawInt2Packed_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004172 RID: 16754 RVA: 0x001025C0 File Offset: 0x001007C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349966, RefRangeEnd = 349967, XrefRangeStart = 349966, XrefRangeEnd = 349966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref f0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f2;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f3;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSettingsAtlas.RawTexture.NativeMethodInfoPtr_WriteRawFloat4Packed_Public_Void_Single_Single_Single_Single_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004173 RID: 16755 RVA: 0x0001BB85 File Offset: 0x00019D85
			public RawTexture(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004174 RID: 16756 RVA: 0x0001BB8E File Offset: 0x00019D8E
			public RawTexture()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientSettingsAtlas.RawTexture>.NativeClassPtr))
			{
			}

			// Token: 0x1700139C RID: 5020
			// (get) Token: 0x06004175 RID: 16757 RVA: 0x0010264C File Offset: 0x0010084C
			// (set) Token: 0x06004176 RID: 16758 RVA: 0x0001BBA0 File Offset: 0x00019DA0
			public unsafe Il2CppStructArray<Color32> rgba
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_rgba);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_rgba), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700139D RID: 5021
			// (get) Token: 0x06004177 RID: 16759 RVA: 0x0010267C File Offset: 0x0010087C
			// (set) Token: 0x06004178 RID: 16760 RVA: 0x0001BBBF File Offset: 0x00019DBF
			public unsafe int width
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_width);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_width)) = value;
				}
			}

			// Token: 0x1700139E RID: 5022
			// (get) Token: 0x06004179 RID: 16761 RVA: 0x001026A4 File Offset: 0x001008A4
			// (set) Token: 0x0600417A RID: 16762 RVA: 0x0001BBDA File Offset: 0x00019DDA
			public unsafe int height
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_height);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSettingsAtlas.RawTexture.NativeFieldInfoPtr_height)) = value;
				}
			}

			// Token: 0x04002E02 RID: 11778
			private static readonly IntPtr NativeFieldInfoPtr_rgba;

			// Token: 0x04002E03 RID: 11779
			private static readonly IntPtr NativeFieldInfoPtr_width;

			// Token: 0x04002E04 RID: 11780
			private static readonly IntPtr NativeFieldInfoPtr_height;

			// Token: 0x04002E05 RID: 11781
			private static readonly IntPtr NativeMethodInfoPtr_WriteRawInt2Packed_Public_Void_Int32_Int32_Int32_Int32_0;

			// Token: 0x04002E06 RID: 11782
			private static readonly IntPtr NativeMethodInfoPtr_WriteRawFloat4Packed_Public_Void_Single_Single_Single_Single_Int32_Int32_0;
		}
	}
}
