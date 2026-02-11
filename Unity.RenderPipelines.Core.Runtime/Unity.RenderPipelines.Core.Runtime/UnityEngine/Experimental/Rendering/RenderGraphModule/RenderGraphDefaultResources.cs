using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000018 RID: 24
	public class RenderGraphDefaultResources : Object
	{
		// Token: 0x06000243 RID: 579 RVA: 0x00015C40 File Offset: 0x00013E40
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphDefaultResources()
		{
			Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphDefaultResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr);
			RenderGraphDefaultResources.NativeFieldInfoPtr_m_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "m_IsValid");
			RenderGraphDefaultResources.NativeFieldInfoPtr_m_BlackTexture2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "m_BlackTexture2D");
			RenderGraphDefaultResources.NativeFieldInfoPtr_m_WhiteTexture2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "m_WhiteTexture2D");
			RenderGraphDefaultResources.NativeFieldInfoPtr_m_ShadowTexture2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "m_ShadowTexture2D");
			RenderGraphDefaultResources.NativeFieldInfoPtr__blackTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackTexture>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__whiteTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<whiteTexture>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__clearTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<clearTextureXR>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__magentaTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<magentaTextureXR>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__blackTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackTextureXR>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__blackTextureArrayXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackTextureArrayXR>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__blackUIntTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackUIntTextureXR>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__blackTexture3DXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackTexture3DXR>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__whiteTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<whiteTextureXR>k__BackingField");
			RenderGraphDefaultResources.NativeFieldInfoPtr__defaultShadowTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<defaultShadowTexture>k__BackingField");
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663562);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackTexture_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663563);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_whiteTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663564);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_whiteTexture_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663565);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_clearTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663566);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_clearTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663567);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_magentaTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663568);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_magentaTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663569);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663570);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663571);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackTextureArrayXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663572);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackTextureArrayXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663573);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackUIntTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663574);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackUIntTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663575);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackTexture3DXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663576);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackTexture3DXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663577);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_whiteTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663578);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_whiteTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663579);
			RenderGraphDefaultResources.NativeMethodInfoPtr_get_defaultShadowTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663580);
			RenderGraphDefaultResources.NativeMethodInfoPtr_set_defaultShadowTexture_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663581);
			RenderGraphDefaultResources.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663582);
			RenderGraphDefaultResources.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663583);
			RenderGraphDefaultResources.NativeMethodInfoPtr_InitializeForRendering_Internal_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100663584);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00015F54 File Offset: 0x00014154
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00015F90 File Offset: 0x00014190
		public unsafe TextureHandle blackTexture
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackTexture_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00015FD0 File Offset: 0x000141D0
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0001600C File Offset: 0x0001420C
		public unsafe TextureHandle whiteTexture
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_whiteTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_whiteTexture_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0001604C File Offset: 0x0001424C
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00016088 File Offset: 0x00014288
		public unsafe TextureHandle clearTextureXR
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_clearTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_clearTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000160C8 File Offset: 0x000142C8
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00016104 File Offset: 0x00014304
		public unsafe TextureHandle magentaTextureXR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_magentaTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_magentaTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00016144 File Offset: 0x00014344
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00016180 File Offset: 0x00014380
		public unsafe TextureHandle blackTextureXR
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000161C0 File Offset: 0x000143C0
		// (set) Token: 0x0600024F RID: 591 RVA: 0x000161FC File Offset: 0x000143FC
		public unsafe TextureHandle blackTextureArrayXR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackTextureArrayXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackTextureArrayXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0001623C File Offset: 0x0001443C
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00016278 File Offset: 0x00014478
		public unsafe TextureHandle blackUIntTextureXR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackUIntTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackUIntTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000162B8 File Offset: 0x000144B8
		// (set) Token: 0x06000253 RID: 595 RVA: 0x000162F4 File Offset: 0x000144F4
		public unsafe TextureHandle blackTexture3DXR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_blackTexture3DXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_blackTexture3DXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00016334 File Offset: 0x00014534
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00016370 File Offset: 0x00014570
		public unsafe TextureHandle whiteTextureXR
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_whiteTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_whiteTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000163B0 File Offset: 0x000145B0
		// (set) Token: 0x06000257 RID: 599 RVA: 0x000163EC File Offset: 0x000145EC
		public unsafe TextureHandle defaultShadowTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_get_defaultShadowTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_set_defaultShadowTexture_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001642C File Offset: 0x0001462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956811, XrefRangeEnd = 956825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphDefaultResources()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00016468 File Offset: 0x00014668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956825, XrefRangeEnd = 956829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001649C File Offset: 0x0001469C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 956855, RefRangeEnd = 956856, XrefRangeStart = 956829, XrefRangeEnd = 956855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeForRendering(RenderGraph renderGraph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDefaultResources.NativeMethodInfoPtr_InitializeForRendering_Internal_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002F63 File Offset: 0x00001163
		public RenderGraphDefaultResources(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000164E0 File Offset: 0x000146E0
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002F6C File Offset: 0x0000116C
		public unsafe bool m_IsValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr_m_IsValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr_m_IsValid)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00016508 File Offset: 0x00014708
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002F87 File Offset: 0x00001187
		public unsafe RTHandle m_BlackTexture2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr_m_BlackTexture2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr_m_BlackTexture2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00016538 File Offset: 0x00014738
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002FA6 File Offset: 0x000011A6
		public unsafe RTHandle m_WhiteTexture2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr_m_WhiteTexture2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr_m_WhiteTexture2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00016568 File Offset: 0x00014768
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002FC5 File Offset: 0x000011C5
		public unsafe RTHandle m_ShadowTexture2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr_m_ShadowTexture2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr_m_ShadowTexture2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00016598 File Offset: 0x00014798
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002FE4 File Offset: 0x000011E4
		public unsafe TextureHandle _blackTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackTexture_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackTexture_k__BackingField)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000165C0 File Offset: 0x000147C0
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002FFF File Offset: 0x000011FF
		public unsafe TextureHandle _whiteTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__whiteTexture_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__whiteTexture_k__BackingField)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000268 RID: 616 RVA: 0x000165E8 File Offset: 0x000147E8
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000301A File Offset: 0x0000121A
		public unsafe TextureHandle _clearTextureXR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__clearTextureXR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__clearTextureXR_k__BackingField)) = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00016610 File Offset: 0x00014810
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00003035 File Offset: 0x00001235
		public unsafe TextureHandle _magentaTextureXR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__magentaTextureXR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__magentaTextureXR_k__BackingField)) = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00016638 File Offset: 0x00014838
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00003050 File Offset: 0x00001250
		public unsafe TextureHandle _blackTextureXR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackTextureXR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackTextureXR_k__BackingField)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00016660 File Offset: 0x00014860
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0000306B File Offset: 0x0000126B
		public unsafe TextureHandle _blackTextureArrayXR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackTextureArrayXR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackTextureArrayXR_k__BackingField)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00016688 File Offset: 0x00014888
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00003086 File Offset: 0x00001286
		public unsafe TextureHandle _blackUIntTextureXR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackUIntTextureXR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackUIntTextureXR_k__BackingField)) = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000166B0 File Offset: 0x000148B0
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000030A1 File Offset: 0x000012A1
		public unsafe TextureHandle _blackTexture3DXR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackTexture3DXR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__blackTexture3DXR_k__BackingField)) = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000166D8 File Offset: 0x000148D8
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000030BC File Offset: 0x000012BC
		public unsafe TextureHandle _whiteTextureXR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__whiteTextureXR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__whiteTextureXR_k__BackingField)) = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00016700 File Offset: 0x00014900
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000030D7 File Offset: 0x000012D7
		public unsafe TextureHandle _defaultShadowTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__defaultShadowTexture_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDefaultResources.NativeFieldInfoPtr__defaultShadowTexture_k__BackingField)) = value;
			}
		}

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_m_IsValid;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTexture2D;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_m_WhiteTexture2D;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowTexture2D;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr__blackTexture_k__BackingField;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr__whiteTexture_k__BackingField;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr__clearTextureXR_k__BackingField;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr__magentaTextureXR_k__BackingField;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr__blackTextureXR_k__BackingField;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr__blackTextureArrayXR_k__BackingField;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr__blackUIntTextureXR_k__BackingField;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr__blackTexture3DXR_k__BackingField;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr__whiteTextureXR_k__BackingField;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr__defaultShadowTexture_k__BackingField;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_blackTexture_Public_get_TextureHandle_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_set_blackTexture_Private_set_Void_TextureHandle_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_get_TextureHandle_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_set_whiteTexture_Private_set_Void_TextureHandle_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_clearTextureXR_Public_get_TextureHandle_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_set_clearTextureXR_Private_set_Void_TextureHandle_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_magentaTextureXR_Public_get_TextureHandle_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_set_magentaTextureXR_Private_set_Void_TextureHandle_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_blackTextureXR_Public_get_TextureHandle_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_set_blackTextureXR_Private_set_Void_TextureHandle_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_get_blackTextureArrayXR_Public_get_TextureHandle_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_set_blackTextureArrayXR_Private_set_Void_TextureHandle_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_blackUIntTextureXR_Public_get_TextureHandle_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_set_blackUIntTextureXR_Private_set_Void_TextureHandle_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_get_blackTexture3DXR_Public_get_TextureHandle_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_set_blackTexture3DXR_Private_set_Void_TextureHandle_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTextureXR_Public_get_TextureHandle_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_set_whiteTextureXR_Private_set_Void_TextureHandle_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultShadowTexture_Public_get_TextureHandle_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultShadowTexture_Private_set_Void_TextureHandle_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_InitializeForRendering_Internal_Void_RenderGraph_0;
	}
}
