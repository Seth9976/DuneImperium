using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;

namespace lib.canis.dataRenderers
{
	// Token: 0x02000032 RID: 50
	public class SpriteAtlasLookupRenderer : VersionedDataComponentObserver<ImageLookup>
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00023700 File Offset: 0x00021900
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlasLookupRenderer()
		{
			Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dataRenderers", "SpriteAtlasLookupRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr);
			SpriteAtlasLookupRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr, "atlasName");
			SpriteAtlasLookupRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr, "spriteNameFormat");
			SpriteAtlasLookupRenderer.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr, "spriteRenderer");
			SpriteAtlasLookupRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr, 100663601);
			SpriteAtlasLookupRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr, 100663602);
			SpriteAtlasLookupRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr, 100663603);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000237A8 File Offset: 0x000219A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497915, XrefRangeEnd = 497920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpriteAtlasLookupRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000237E4 File Offset: 0x000219E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497920, XrefRangeEnd = 497936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpriteAtlasLookupRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00023820 File Offset: 0x00021A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497936, XrefRangeEnd = 497944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteAtlasLookupRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasLookupRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLookupRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002C5B File Offset: 0x00000E5B
		public SpriteAtlasLookupRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0002385C File Offset: 0x00021A5C
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002C64 File Offset: 0x00000E64
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLookupRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLookupRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00023884 File Offset: 0x00021A84
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002C83 File Offset: 0x00000E83
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLookupRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLookupRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000238AC File Offset: 0x00021AAC
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002CA2 File Offset: 0x00000EA2
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLookupRenderer.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLookupRenderer.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
