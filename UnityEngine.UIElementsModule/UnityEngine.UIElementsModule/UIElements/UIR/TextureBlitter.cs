using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200026E RID: 622
	public class TextureBlitter : Object
	{
		// Token: 0x06002E07 RID: 11783 RVA: 0x000C46F0 File Offset: 0x000C28F0
		// Note: this type is marked as 'beforefieldinit'.
		static TextureBlitter()
		{
			Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "TextureBlitter");
			TextureBlitter.NativeFieldInfoPtr_k_TextureIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "k_TextureIds");
			TextureBlitter.NativeFieldInfoPtr_s_CommitSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "s_CommitSampler");
			TextureBlitter.NativeFieldInfoPtr_m_SingleBlit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "m_SingleBlit");
			TextureBlitter.NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "m_BlitMaterial");
			TextureBlitter.NativeFieldInfoPtr_m_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "m_Properties");
			TextureBlitter.NativeFieldInfoPtr_m_Viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "m_Viewport");
			TextureBlitter.NativeFieldInfoPtr_m_PrevRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "m_PrevRT");
			TextureBlitter.NativeFieldInfoPtr_m_PendingBlits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "m_PendingBlits");
			TextureBlitter.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "<disposed>k__BackingField");
			TextureBlitter.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670006);
			TextureBlitter.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670007);
			TextureBlitter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670008);
			TextureBlitter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670009);
			TextureBlitter.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670011);
			TextureBlitter.NativeMethodInfoPtr_QueueBlit_Public_Void_Texture_RectInt_Vector2Int_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670012);
			TextureBlitter.NativeMethodInfoPtr_BlitOneNow_Public_Void_RenderTexture_Texture_RectInt_Vector2Int_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670013);
			TextureBlitter.NativeMethodInfoPtr_Commit_Public_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670014);
			TextureBlitter.NativeMethodInfoPtr_BeginBlit_Private_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670015);
			TextureBlitter.NativeMethodInfoPtr_DoBlit_Private_Void_IList_1_BlitInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670016);
			TextureBlitter.NativeMethodInfoPtr_EndBlit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, 100670017);
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x000C48A8 File Offset: 0x000C2AA8
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x000C48E4 File Offset: 0x000C2AE4
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000C4924 File Offset: 0x000C2B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351761, RefRangeEnd = 351762, XrefRangeStart = 351757, XrefRangeEnd = 351761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000C4958 File Offset: 0x000C2B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351762, XrefRangeEnd = 351767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureBlitter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000C49A4 File Offset: 0x000C2BA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351779, RefRangeEnd = 351780, XrefRangeStart = 351767, XrefRangeEnd = 351779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureBlitter(int capacity = 512)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000C49EC File Offset: 0x000C2BEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351788, RefRangeEnd = 351790, XrefRangeStart = 351780, XrefRangeEnd = 351788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBorder;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_QueueBlit_Public_Void_Texture_RectInt_Vector2Int_Boolean_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000C4A68 File Offset: 0x000C2C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351795, RefRangeEnd = 351796, XrefRangeStart = 351790, XrefRangeEnd = 351795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstPos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBorder;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_BlitOneNow_Public_Void_RenderTexture_Texture_RectInt_Vector2Int_Boolean_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x000C4AF4 File Offset: 0x000C2CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351804, RefRangeEnd = 351805, XrefRangeStart = 351796, XrefRangeEnd = 351804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commit(RenderTexture dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dst);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_Commit_Public_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x000C4B38 File Offset: 0x000C2D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351839, RefRangeEnd = 351841, XrefRangeStart = 351805, XrefRangeEnd = 351839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBlit(RenderTexture dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dst);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_BeginBlit_Private_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x000C4B7C File Offset: 0x000C2D7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351888, RefRangeEnd = 351890, XrefRangeStart = 351841, XrefRangeEnd = 351888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoBlit(IList<TextureBlitter.BlitInfo> blitInfos, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blitInfos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_DoBlit_Private_Void_IList_1_BlitInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x000C4BCC File Offset: 0x000C2DCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351895, RefRangeEnd = 351897, XrefRangeStart = 351890, XrefRangeEnd = 351895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndBlit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureBlitter.NativeMethodInfoPtr_EndBlit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x00012EBD File Offset: 0x000110BD
		public TextureBlitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x000C4C00 File Offset: 0x000C2E00
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x00012EC6 File Offset: 0x000110C6
		public unsafe static Il2CppStructArray<int> k_TextureIds
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureBlitter.NativeFieldInfoPtr_k_TextureIds, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureBlitter.NativeFieldInfoPtr_k_TextureIds, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x000C4C28 File Offset: 0x000C2E28
		// (set) Token: 0x06002E17 RID: 11799 RVA: 0x00012ED8 File Offset: 0x000110D8
		public unsafe static ProfilerMarker s_CommitSampler
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextureBlitter.NativeFieldInfoPtr_s_CommitSampler, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureBlitter.NativeFieldInfoPtr_s_CommitSampler, (void*)(&value));
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000C4C44 File Offset: 0x000C2E44
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x00012EE6 File Offset: 0x000110E6
		public unsafe Il2CppReferenceArray<TextureBlitter.BlitInfo> m_SingleBlit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_SingleBlit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextureBlitter.BlitInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_SingleBlit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000C4C74 File Offset: 0x000C2E74
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x00012F05 File Offset: 0x00011105
		public unsafe Material m_BlitMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_BlitMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_BlitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000C4CA4 File Offset: 0x000C2EA4
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x00012F24 File Offset: 0x00011124
		public unsafe MaterialPropertyBlock m_Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x000C4CD4 File Offset: 0x000C2ED4
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x00012F43 File Offset: 0x00011143
		public unsafe RectInt m_Viewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_Viewport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_Viewport)) = value;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x000C4CFC File Offset: 0x000C2EFC
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x00012F5E File Offset: 0x0001115E
		public unsafe RenderTexture m_PrevRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_PrevRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_PrevRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x000C4D2C File Offset: 0x000C2F2C
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x00012F7D File Offset: 0x0001117D
		public unsafe List<TextureBlitter.BlitInfo> m_PendingBlits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_PendingBlits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextureBlitter.BlitInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr_m_PendingBlits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x000C4D5C File Offset: 0x000C2F5C
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x00012F9C File Offset: 0x0001119C
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x00012FB7 File Offset: 0x000111B7
		public int queueLength
		{
			get
			{
				return this.m_PendingBlits.Count;
			}
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00012FC4 File Offset: 0x000111C4
		public void Reset()
		{
			this.m_PendingBlits.Clear();
		}

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeFieldInfoPtr_k_TextureIds;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeFieldInfoPtr_s_CommitSampler;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleBlit;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitMaterial;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeFieldInfoPtr_m_Properties;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeFieldInfoPtr_m_Viewport;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevRT;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingBlits;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeMethodInfoPtr_QueueBlit_Public_Void_Texture_RectInt_Vector2Int_Boolean_Color_0;

		// Token: 0x04002131 RID: 8497
		private static readonly IntPtr NativeMethodInfoPtr_BlitOneNow_Public_Void_RenderTexture_Texture_RectInt_Vector2Int_Boolean_Color_0;

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Void_RenderTexture_0;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeMethodInfoPtr_BeginBlit_Private_Void_RenderTexture_0;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeMethodInfoPtr_DoBlit_Private_Void_IList_1_BlitInfo_Int32_0;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeMethodInfoPtr_EndBlit_Private_Void_0;

		// Token: 0x04002136 RID: 8502
		public const int k_TextureSlotCount = 8;

		// Token: 0x0200055C RID: 1372
		public sealed class BlitInfo : ValueType
		{
			// Token: 0x060041E2 RID: 16866 RVA: 0x00103650 File Offset: 0x00101850
			// Note: this type is marked as 'beforefieldinit'.
			static BlitInfo()
			{
				Il2CppClassPointerStore<TextureBlitter.BlitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextureBlitter>.NativeClassPtr, "BlitInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureBlitter.BlitInfo>.NativeClassPtr);
				TextureBlitter.BlitInfo.NativeFieldInfoPtr_src = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter.BlitInfo>.NativeClassPtr, "src");
				TextureBlitter.BlitInfo.NativeFieldInfoPtr_srcRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter.BlitInfo>.NativeClassPtr, "srcRect");
				TextureBlitter.BlitInfo.NativeFieldInfoPtr_dstPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter.BlitInfo>.NativeClassPtr, "dstPos");
				TextureBlitter.BlitInfo.NativeFieldInfoPtr_border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter.BlitInfo>.NativeClassPtr, "border");
				TextureBlitter.BlitInfo.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureBlitter.BlitInfo>.NativeClassPtr, "tint");
			}

			// Token: 0x060041E3 RID: 16867 RVA: 0x0001C06A File Offset: 0x0001A26A
			public BlitInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060041E4 RID: 16868 RVA: 0x0001C073 File Offset: 0x0001A273
			public BlitInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureBlitter.BlitInfo>.NativeClassPtr))
			{
			}

			// Token: 0x170013BF RID: 5055
			// (get) Token: 0x060041E5 RID: 16869 RVA: 0x001036E0 File Offset: 0x001018E0
			// (set) Token: 0x060041E6 RID: 16870 RVA: 0x0001C085 File Offset: 0x0001A285
			public unsafe Texture src
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_src);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_src), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C0 RID: 5056
			// (get) Token: 0x060041E7 RID: 16871 RVA: 0x00103710 File Offset: 0x00101910
			// (set) Token: 0x060041E8 RID: 16872 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
			public unsafe RectInt srcRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_srcRect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_srcRect)) = value;
				}
			}

			// Token: 0x170013C1 RID: 5057
			// (get) Token: 0x060041E9 RID: 16873 RVA: 0x00103738 File Offset: 0x00101938
			// (set) Token: 0x060041EA RID: 16874 RVA: 0x0001C0BF File Offset: 0x0001A2BF
			public unsafe Vector2Int dstPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_dstPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_dstPos)) = value;
				}
			}

			// Token: 0x170013C2 RID: 5058
			// (get) Token: 0x060041EB RID: 16875 RVA: 0x00103760 File Offset: 0x00101960
			// (set) Token: 0x060041EC RID: 16876 RVA: 0x0001C0DA File Offset: 0x0001A2DA
			public unsafe int border
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_border);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_border)) = value;
				}
			}

			// Token: 0x170013C3 RID: 5059
			// (get) Token: 0x060041ED RID: 16877 RVA: 0x00103788 File Offset: 0x00101988
			// (set) Token: 0x060041EE RID: 16878 RVA: 0x0001C0F5 File Offset: 0x0001A2F5
			public unsafe Color tint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_tint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureBlitter.BlitInfo.NativeFieldInfoPtr_tint)) = value;
				}
			}

			// Token: 0x04002E37 RID: 11831
			private static readonly IntPtr NativeFieldInfoPtr_src;

			// Token: 0x04002E38 RID: 11832
			private static readonly IntPtr NativeFieldInfoPtr_srcRect;

			// Token: 0x04002E39 RID: 11833
			private static readonly IntPtr NativeFieldInfoPtr_dstPos;

			// Token: 0x04002E3A RID: 11834
			private static readonly IntPtr NativeFieldInfoPtr_border;

			// Token: 0x04002E3B RID: 11835
			private static readonly IntPtr NativeFieldInfoPtr_tint;
		}
	}
}
