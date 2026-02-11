using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000169 RID: 361
	public class DynamicAtlasPage : Object
	{
		// Token: 0x06001AA5 RID: 6821 RVA: 0x0007B3FC File Offset: 0x000795FC
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicAtlasPage()
		{
			Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DynamicAtlasPage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr);
			DynamicAtlasPage.NativeFieldInfoPtr__textureId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "<textureId>k__BackingField");
			DynamicAtlasPage.NativeFieldInfoPtr__atlas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "<atlas>k__BackingField");
			DynamicAtlasPage.NativeFieldInfoPtr__format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "<format>k__BackingField");
			DynamicAtlasPage.NativeFieldInfoPtr__filterMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "<filterMode>k__BackingField");
			DynamicAtlasPage.NativeFieldInfoPtr__minSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "<minSize>k__BackingField");
			DynamicAtlasPage.NativeFieldInfoPtr__maxSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "<maxSize>k__BackingField");
			DynamicAtlasPage.NativeFieldInfoPtr_m_1Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "m_1Padding");
			DynamicAtlasPage.NativeFieldInfoPtr_m_2Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "m_2Padding");
			DynamicAtlasPage.NativeFieldInfoPtr_m_Allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "m_Allocator");
			DynamicAtlasPage.NativeFieldInfoPtr_m_Blitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "m_Blitter");
			DynamicAtlasPage.NativeFieldInfoPtr_m_CurrentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "m_CurrentSize");
			DynamicAtlasPage.NativeFieldInfoPtr_s_TextureCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "s_TextureCounter");
			DynamicAtlasPage.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, "<disposed>k__BackingField");
			DynamicAtlasPage.NativeMethodInfoPtr_get_textureId_Public_get_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667205);
			DynamicAtlasPage.NativeMethodInfoPtr_set_textureId_Private_set_Void_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667206);
			DynamicAtlasPage.NativeMethodInfoPtr_get_atlas_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667207);
			DynamicAtlasPage.NativeMethodInfoPtr_set_atlas_Private_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667208);
			DynamicAtlasPage.NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667209);
			DynamicAtlasPage.NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667210);
			DynamicAtlasPage.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureFormat_FilterMode_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667211);
			DynamicAtlasPage.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667212);
			DynamicAtlasPage.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667213);
			DynamicAtlasPage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667214);
			DynamicAtlasPage.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667215);
			DynamicAtlasPage.NativeMethodInfoPtr_TryAdd_Public_Boolean_Texture2D_byref_Alloc2D_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667216);
			DynamicAtlasPage.NativeMethodInfoPtr_Update_Public_Void_Texture2D_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667217);
			DynamicAtlasPage.NativeMethodInfoPtr_Remove_Public_Void_Alloc2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667218);
			DynamicAtlasPage.NativeMethodInfoPtr_Commit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667219);
			DynamicAtlasPage.NativeMethodInfoPtr_UpdateAtlasTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667220);
			DynamicAtlasPage.NativeMethodInfoPtr_CreateAtlasTexture_Private_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr, 100667221);
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0007B684 File Offset: 0x00079884
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0007B6C0 File Offset: 0x000798C0
		public unsafe TextureId textureId
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_get_textureId_Public_get_TextureId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_set_textureId_Private_set_Void_TextureId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0007B700 File Offset: 0x00079900
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0007B740 File Offset: 0x00079940
		public unsafe RenderTexture atlas
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_get_atlas_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_set_atlas_Private_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0007B784 File Offset: 0x00079984
		public unsafe RenderTextureFormat format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x0007B7C0 File Offset: 0x000799C0
		public unsafe FilterMode filterMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0007B7FC File Offset: 0x000799FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322316, RefRangeEnd = 322320, XrefRangeStart = 322296, XrefRangeEnd = 322316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicAtlasPage(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicAtlasPage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureFormat_FilterMode_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x0007B870 File Offset: 0x00079A70
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x0007B8AC File Offset: 0x00079AAC
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0007B8EC File Offset: 0x00079AEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322324, RefRangeEnd = 322326, XrefRangeStart = 322320, XrefRangeEnd = 322324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0007B920 File Offset: 0x00079B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322326, XrefRangeEnd = 322353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicAtlasPage.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0007B96C File Offset: 0x00079B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322382, RefRangeEnd = 322383, XrefRangeStart = 322353, XrefRangeEnd = 322382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAdd(Texture2D image, out UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc, out RectInt rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_TryAdd_Public_Boolean_Texture2D_byref_Alloc2D_byref_RectInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			alloc = ((intPtr4 == 0) ? null : new UnityEngine.UIElements.UIR.Allocator2D.Alloc2D(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0007B9EC File Offset: 0x00079BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322383, XrefRangeEnd = 322393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(Texture2D image, RectInt rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_Update_Public_Void_Texture2D_RectInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0007BA3C File Offset: 0x00079C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322398, RefRangeEnd = 322399, XrefRangeStart = 322393, XrefRangeEnd = 322398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(alloc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_Remove_Public_Void_Alloc2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0007BA84 File Offset: 0x00079C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322402, RefRangeEnd = 322404, XrefRangeStart = 322399, XrefRangeEnd = 322402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_Commit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0007BAB8 File Offset: 0x00079CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322445, RefRangeEnd = 322446, XrefRangeStart = 322404, XrefRangeEnd = 322445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_UpdateAtlasTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0007BAEC File Offset: 0x00079CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322459, RefRangeEnd = 322460, XrefRangeStart = 322446, XrefRangeEnd = 322459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture CreateAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasPage.NativeMethodInfoPtr_CreateAtlasTexture_Private_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0000C1B2 File Offset: 0x0000A3B2
		public DynamicAtlasPage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0007BB2C File Offset: 0x00079D2C
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0000C1BB File Offset: 0x0000A3BB
		public unsafe TextureId _textureId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__textureId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__textureId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0007BB54 File Offset: 0x00079D54
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
		public unsafe RenderTexture _atlas_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__atlas_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__atlas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0007BB84 File Offset: 0x00079D84
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0000C1F5 File Offset: 0x0000A3F5
		public unsafe RenderTextureFormat _format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__format_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__format_k__BackingField)) = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0007BBAC File Offset: 0x00079DAC
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000C210 File Offset: 0x0000A410
		public unsafe FilterMode _filterMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__filterMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__filterMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0007BBD4 File Offset: 0x00079DD4
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0000C22B File Offset: 0x0000A42B
		public unsafe Vector2Int _minSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__minSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__minSize_k__BackingField)) = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0007BBFC File Offset: 0x00079DFC
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0000C246 File Offset: 0x0000A446
		public unsafe Vector2Int _maxSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__maxSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__maxSize_k__BackingField)) = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0007BC24 File Offset: 0x00079E24
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0000C261 File Offset: 0x0000A461
		public unsafe int m_1Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_1Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_1Padding)) = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0007BC4C File Offset: 0x00079E4C
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x0000C27C File Offset: 0x0000A47C
		public unsafe int m_2Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_2Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_2Padding)) = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0007BC74 File Offset: 0x00079E74
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0000C297 File Offset: 0x0000A497
		public unsafe UnityEngine.UIElements.UIR.Allocator2D m_Allocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_Allocator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.UIR.Allocator2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_Allocator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0007BCA4 File Offset: 0x00079EA4
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0000C2B6 File Offset: 0x0000A4B6
		public unsafe UnityEngine.UIElements.UIR.TextureBlitter m_Blitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_Blitter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.UIR.TextureBlitter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_Blitter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x0007BCD4 File Offset: 0x00079ED4
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x0000C2D5 File Offset: 0x0000A4D5
		public unsafe Vector2Int m_CurrentSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_CurrentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr_m_CurrentSize)) = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0007BCFC File Offset: 0x00079EFC
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		public unsafe static int s_TextureCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DynamicAtlasPage.NativeFieldInfoPtr_s_TextureCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicAtlasPage.NativeFieldInfoPtr_s_TextureCounter, (void*)(&value));
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0007BD18 File Offset: 0x00079F18
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0000C2FE File Offset: 0x0000A4FE
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasPage.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0000C319 File Offset: 0x0000A519
		public Vector2Int minSize
		{
			get
			{
				return this._minSize_k__BackingField;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0000C321 File Offset: 0x0000A521
		public Vector2Int maxSize
		{
			get
			{
				return this._maxSize_k__BackingField;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0000C329 File Offset: 0x0000A529
		public Vector2Int currentSize
		{
			get
			{
				return this.m_CurrentSize;
			}
		}

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeFieldInfoPtr__textureId_k__BackingField;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeFieldInfoPtr__atlas_k__BackingField;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeFieldInfoPtr__format_k__BackingField;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeFieldInfoPtr__filterMode_k__BackingField;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeFieldInfoPtr__minSize_k__BackingField;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr__maxSize_k__BackingField;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr_m_1Padding;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeFieldInfoPtr_m_2Padding;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeFieldInfoPtr_m_Allocator;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeFieldInfoPtr_m_Blitter;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSize;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr_s_TextureCounter;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_get_textureId_Public_get_TextureId_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_set_textureId_Private_set_Void_TextureId_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_get_atlas_Public_get_RenderTexture_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_set_atlas_Private_set_Void_RenderTexture_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTextureFormat_FilterMode_Vector2Int_Vector2Int_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_Texture2D_byref_Alloc2D_byref_RectInt_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Texture2D_RectInt_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Alloc2D_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Void_0;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAtlasTexture_Private_Void_0;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr_CreateAtlasTexture_Private_RenderTexture_0;
	}
}
